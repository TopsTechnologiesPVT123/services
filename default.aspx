<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ServiceOrientedApplication._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
            <script type="text/javascript">
                function CallMethods() {
                    $.ajax({
                        type: "POST",
                        url: "default.aspx/login",
                        data: JSON.stringify({ "uname": "bhadresh", "password": "bhadresh" }),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (data) { alert(data.d); },
                        failure: function (response) {
                            alert(response.d);
                        }
                    });
                }

                CallMethods();
            </script>
        </div>
    </form>
</body>
</html>
