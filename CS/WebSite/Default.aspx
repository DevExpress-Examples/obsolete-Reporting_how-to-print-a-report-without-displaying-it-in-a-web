<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript">
    function printReport() {

        var iframe = document.getElementById('reportout');
        if (iframe != null) {
            document.body.removeChild(iframe);
        }
        iframe = document.createElement("iframe");
        iframe.setAttribute("id", "reportout");
        iframe.style.width = 0 + "px";
        iframe.style.height = 0 + "px";
        document.body.appendChild(iframe);
        document.getElementById('reportout').contentWindow.location = 'Report.aspx';
    }
</script>
    <title>Direct printing</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="Button1" type="button" value="Print Report via Adobe PDF plugin" onclick="printReport()"/></div>
    </form>
        <iframe id="reportout" width="0" height="0"></iframe>
</body>
</html>
