jQuery(function ($) {
    //initiate dataTables plugin
    var myTable =
        $('#dynamic-table')
            .DataTable({
                bAutoWidth: false,
                "aoColumns": [
                    null, null, null, null, null,
                    { "bSortable": false }
                ],
                "aaSorting": [],
                select: {
                    style: 'multi'
                }
            });
})
