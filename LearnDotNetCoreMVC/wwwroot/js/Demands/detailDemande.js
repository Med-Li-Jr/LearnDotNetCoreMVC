function responseModal(action) {
    $("#" + action).modal("toggle");
}
function deleteModal(idDemande) {
    var htmlValue = `
<form method="post" action="/@ViewContext.RouteData.Values["controller"].ToString()/` + idDemande + `">
                        <button class="btn" data-dismiss="modal">
                            <i class="ace-icon fa fa-times"></i>
                            No
                        </button>

                        <button class="btn btn-danger" type="submit">
                            <i class="ace-icon fa fa-check"></i>
                            Yes
                        </button>
</form>
            `;
    $("#footerModal").html(htmlValue);
    $("#modal-form-confirm-delete").modal("toggle");
}