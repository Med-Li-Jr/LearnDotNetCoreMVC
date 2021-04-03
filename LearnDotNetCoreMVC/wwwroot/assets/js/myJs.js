let tbodyListeDemande = document.getElementById("tbodyListeDemande");


let config = {
    method: 'get',
    url: 'http://localhost:5056/requests'
};

function init(param) {
    axios(param)
        .then(function (response) {
            console.log(response)
            if (response.data.hasError === true) {
                alert(response.data.messageResponse)
            }
            else {
                configurationDashboard(response.data.organizations)
            }
        })
        .catch(function (error) {
            alert(error);
            console.log(error)
        });

}

function configurationDashboard(data) {

    let nbrDemande = data.length;
    let nbrDemandeAccepter = 0;
    let nbrDemandeAttendre = 0;
    let nbrDemandeRefuser = 0;


    for (let i = 0; i < nbrDemande; i++) {

        if (data[i].regDemandDecision === "Attendre") {
            nbrDemandeAttendre++;

            let nameOrg = data[i].name + " ";


            let row = document.createElement("tr");

            let firstCell = document.createElement("td");
            firstCell.innerHTML = `
                <td class="center">
                    <label class="pos-rel">
                        <input type="checkbox" class="ace" />
                        <span class="lbl"></span>
                    </label>
                </td>
            `;

            let secondCell = document.createElement("td");

            secondCell.innerHTML = `
                <td>
                    <a href="#">`+nameOrg+`</a>
                </td>
            `;

            let firdCell = document.createElement("td");

            firdCell.innerHTML = `
            <td>
                `+nameOrg+`
            </td>
        `;;

            let fourthCell = document.createElement("td");
            fourthCell.innerHTML = `<td>` + data[i].regDemandDate + `</td>`;

            let cellStatus = document.createElement("td");
            cellStatus.innerHTML = `<td class="hidden-480">
            <span class="label label-sm label-warning">` + data[i].regDemandDecision + `</span>
    </td>`;

            let cellAction = document.createElement("td");
            cellAction.innerHTML = `
            
            <td>
            <div class="hidden-sm hidden-xs action-buttons">
                <a class="blue" href="#">
                    <i class="ace-icon fa fa-search-plus bigger-130"></i>
                </a>

                <a class="green" href="#">
                    <i class="ace-icon fa fa-pencil bigger-130"></i>
                </a>

                <a class="red" href="#">
                    <i class="ace-icon fa fa-trash-o bigger-130"></i>
                </a>
            </div>

            <div class="hidden-md hidden-lg">
                <div class="inline pos-rel">
                    <button class="btn btn-minier btn-yellow dropdown-toggle" data-toggle="dropdown" data-position="auto">
                        <i class="ace-icon fa fa-caret-down icon-only bigger-120"></i>
                    </button>

                    <ul class="dropdown-menu dropdown-only-icon dropdown-yellow dropdown-menu-right dropdown-caret dropdown-close">
                        <li>
                            <a href="#" class="tooltip-info" data-rel="tooltip" title="View">
                                <span class="blue">
                                    <i class="ace-icon fa fa-search-plus bigger-120"></i>
                                </span>
                            </a>
                        </li>

                        <li>
                            <a href="#" class="tooltip-success" data-rel="tooltip" title="Edit">
                                <span class="green">
                                    <i class="ace-icon fa fa-pencil-square-o bigger-120"></i>
                                </span>
                            </a>
                        </li>

                        <li>
                            <a href="#" class="tooltip-error" data-rel="tooltip" title="Delete">
                                <span class="red">
                                    <i class="ace-icon fa fa-trash-o bigger-120"></i>
                                </span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </td>
            `;

            row.appendChild(firstCell);
            row.appendChild(secondCell);
            row.appendChild(firdCell);
            row.appendChild(fourthCell);
            row.appendChild(cellStatus);
            row.appendChild(cellAction);

            tbodyListeDemande.appendChild(row);

        }

        if (data[i].regDemandDecision === "Accepter") {
            nbrDemandeAccepter++;
        }

        if (data[i].regDemandDecision === "Refuser") {
            nbrDemandeRefuser++
        }
    }

/*
    nbrTotal.innerHTML = nbrDemande;
    nbrAccepter.innerText = nbrDemandeAccepter;
    nbrAttendre.innerText = nbrDemandeAttendre;
    nbrRefuser.innerText = nbrDemandeRefuser;*/
}

init(config);