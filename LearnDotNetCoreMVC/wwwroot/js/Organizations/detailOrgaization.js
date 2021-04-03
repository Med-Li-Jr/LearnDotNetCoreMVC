
let tabDetail = document.getElementById("tabDetail");
let allInput = document.getElementsByClassName("col-xs-11");
let textCountry = document.getElementById("textCountry");
let countrySelect = document.getElementById("countrySelect");
let typeSelect = document.getElementById("typeSelect");
let typeText = document.getElementById("typeText");
let statusSelect = document.getElementById("statusSelect");
let statusText = document.getElementById("statusText");

let btnEdit = document.getElementById("BtnEditer")
let btnSave = document.getElementById("BtnSave");

function editerBtnClicked() {

    textCountry.setAttribute("hidden", true);
    countrySelect.removeAttribute("hidden");

    typeText.setAttribute("hidden", true);
    typeSelect.removeAttribute("hidden");

    statusText.setAttribute("hidden", true);
    statusSelect.removeAttribute("hidden");

    for (const inp of allInput) {
        console.log(inp.value + " // " + inp.selected)
        inp.removeAttribute('readonly');
    }
    tabDetail.click();
    btnEdit.setAttribute("hidden", true);
    btnSave.removeAttribute("hidden");
}
function saveBtnClicked() {

    countrySelect.setAttribute("hidden", true);
    textCountry.removeAttribute("hidden");

    typeSelect.setAttribute("hidden", true);
    typeText.removeAttribute("hidden");

    statusSelect.setAttribute("hidden", true);
    statusText.removeAttribute("hidden");

    for (const inp of allInput) {
        inp.setAttribute('readonly', true);
    }
    tabDetail.click();
    btnEdit.removeAttribute("hidden");
    btnSave.setAttribute("hidden", true);
}



$('.easy-pie-chart.percentage').each(function () {
    var $box = $(this).closest('.infobox');
    var barColor = $(this).data('color') || (!$box.hasClass('infobox-dark') ? $box.css('color') : 'rgba(255,255,255,0.95)');
    var trackColor = barColor == 'rgba(255,255,255,0.95)' ? 'rgba(255,255,255,0.25)' : '#E2E2E2';
    var size = parseInt($(this).data('size')) || 50;
    $(this).easyPieChart({
        barColor: barColor,
        trackColor: trackColor,
        scaleColor: false,
        lineCap: 'butt',
        lineWidth: parseInt(size / 10),
        animate: ace.vars['old_ie'] ? false : 1000,
        size: size
    });
})

$('.sparkline').each(function () {
    var $box = $(this).closest('.infobox');
    var barColor = !$box.hasClass('infobox-dark') ? $box.css('color') : '#FFF';
    $(this).sparkline('html',
        {
            tagValuesAttribute: 'data-values',
            type: 'bar',
            barColor: barColor,
            chartRangeMin: $(this).data('min') || 0
        });
});


//flot chart resize plugin, somehow manipulates default browser resize event to optimize it!
//but sometimes it brings up errors with normal resize event handlers
$.resize.throttleWindow = false;

var placeholder = $('#piechart-placeholder').css({ 'width': '90%', 'min-height': '150px' });
var data = [
    { label: "social networks", data: 38.7, color: "#68BC31" },
    { label: "search engines", data: 24.5, color: "#2091CF" },
    { label: "ad campaigns", data: 8.2, color: "#AF4E96" },
    { label: "direct traffic", data: 18.6, color: "#DA5430" },
    { label: "other", data: 10, color: "#FEE074" }
]

function drawPieChart(placeholder, data, position) {
    $.plot(placeholder, data, {
        series: {
            pie: {
                show: true,
                tilt: 0.8,
                highlight: {
                    opacity: 0.25
                },
                stroke: {
                    color: '#fff',
                    width: 2
                },
                startAngle: 2
            }
        },
        legend: {
            show: true,
            position: position || "ne",
            labelBoxBorderColor: null,
            margin: [-30, 15]
        }
        ,
        grid: {
            hoverable: true,
            clickable: true
        }
    })
}
drawPieChart(placeholder, data);

/**
we saved the drawing function and the data to redraw with different position later when switching to RTL mode dynamically
so that's not needed actually.
*/
placeholder.data('chart', data);
placeholder.data('draw', drawPieChart);


//pie chart tooltip example
var $tooltip = $("<div class='tooltip top in'><div class='tooltip-inner'></div></div>").hide().appendTo('body');
var previousPoint = null;

placeholder.on('plothover', function (event, pos, item) {
    if (item) {
        if (previousPoint != item.seriesIndex) {
            previousPoint = item.seriesIndex;
            var tip = item.series['label'] + " : " + item.series['percent'] + '%';
            $tooltip.show().children(0).text(tip);
        }
        $tooltip.css({ top: pos.pageY + 10, left: pos.pageX + 10 });
    } else {
        $tooltip.hide();
        previousPoint = null;
    }

});

/////////////////////////////////////
$(document).one('ajaxloadstart.page', function (e) {
    $tooltip.remove();
});

var d1 = [];
for (var i = 0; i < Math.PI * 2; i += 0.5) {
    d1.push([i, Math.sin(i)]);
}

var d2 = [];
for (var i = 0; i < Math.PI * 2; i += 0.5) {
    d2.push([i, Math.cos(i)]);
}

var d3 = [];
for (var i = 0; i < Math.PI * 2; i += 0.2) {
    d3.push([i, Math.tan(i)]);
}


var sales_charts = $('#sales-charts').css({ 'width': '100%', 'height': '220px' });
$.plot("#sales-charts", [
    { label: "Domains", data: d1 },
    { label: "Hosting", data: d2 },
    { label: "Services", data: d3 }
], {
    hoverable: true,
    shadowSize: 0,
    series: {
        lines: { show: true },
        points: { show: true }
    },
    xaxis: {
        tickLength: 0
    },
    yaxis: {
        ticks: 10,
        min: -2,
        max: 2,
        tickDecimals: 3
    },
    grid: {
        backgroundColor: { colors: ["#fff", "#fff"] },
        borderWidth: 1,
        borderColor: '#555'
    }
});


$('#recent-box [data-rel="tooltip"]').tooltip({ placement: tooltip_placement });
function tooltip_placement(context, source) {
    var $source = $(source);
    var $parent = $source.closest('.tab-content')
    var off1 = $parent.offset();
    var w1 = $parent.width();

    var off2 = $source.offset();
    //var w2 = $source.width();

    if (parseInt(off2.left) < parseInt(off1.left) + parseInt(w1 / 2)) return 'right';
    return 'left';
}


$('.dialogs,.comments').ace_scroll({
    size: 300
});

jQuery(function ($) {
    //initiate dataTables plugin
    var myTable =
        $('#dynamic-table')
            .DataTable({
                bAutoWidth: false,
                "aoColumns": [
                    null, null, null,
                    { "bSortable": false }
                ],
                "aaSorting": [],
                select: {
                    style: 'multi'
                }
            });
})




