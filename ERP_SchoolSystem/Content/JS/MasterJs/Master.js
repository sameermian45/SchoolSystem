
$("#frmDepartment").validate({
    submitHandler: function (form)
    {
        // do other things for a valid form
        var data = $('form').serialize();
        $.ajax({
            url: "/Master/DepartmentIndex",
            type: 'POST',           
            data:data,
            success: function (response) {
                if (!response.isError) {
                    var objData = response.objectData;
                    toastr.success(response.message);
                }
                else {
                    toastr.error(response.message)
                }

            },
            error: function (data) {
                toastr.error("Something went wrong")
            }

        });
       
    }
});