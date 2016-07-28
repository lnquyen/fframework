$(document).ready(function () {
    var url;
    function add(){
        $('#dlg').dialog('open').dialog('center').dialog('setTitle','Thêm mới');
        $('#fmDonVi').form('clear');
        url = "@Url.Action("Create", "DonVi")";
    }
    function edit(){
        var row = $('#dgDonVI').datagrid('getSelected');
        if (row){
            $('#dlg').dialog('open').dialog('center').dialog('setTitle','Cập nhật thông tin');
            $('#fmDonVi').form('load', row);
            url = "@Url.Action("Update", "DonVi")";
        }
    }
    function save(){
        $('#fm').form('submit',{
            url: url,
            onSubmit: function(){
                return $(this).form('validate');
            },
            success: function(result){
                var result = eval('('+result+')');
                if (result.errorMsg){
                    $.messager.show({
                        title: 'Error',
                        msg: result.errorMsg
                    });
                } else {
                    $('#dlg').dialog('close');        // close the dialog
                    $('#dg').datagrid('reload');    // reload the user data
                }
            }
        });
    }
    function remove(){
        var row = $('#dg').datagrid('getSelected');
        if (row){
            $.messager.confirm('Confirm','Are you sure you want to destroy this user?',function(r){
                if (r){
                    $.post('destroy_user.php',{id:row.id},function(result){
                        if (result.success){
                            $('#dg').datagrid('reload');    // reload the user data
                        } else {
                            $.messager.show({    // show error message
                                title: 'Error',
                                msg: result.errorMsg
                            });
                        }
                    },'json');
                }
            });
        }
    }
});