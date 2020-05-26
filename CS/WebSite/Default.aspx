<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript">
    function printReport() {
        window.open("Report.aspx", "PrintingFrame")
        var frameElement = document.getElementById("FrameToPrint");
        frameElement.addEventListener("load", function (e) {
            if (frameElement.contentDocument.contentType !== "text/html")
                frameElement.contentWindow.print();
        });
    }
</script>
    <title>Direct printing</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <iframe id="FrameToPrint" name="PrintingFrame" style="position:absolute; left: -10000px; top: -10000px;"></iframe>
        <input id="Button1" type="button" value="Print Report with iFrame" onclick="printReport()"/></div>
        <b>Note:</b> Printing with an invisible iFrame element is not recommended. Although this solution provides more desktop-like experience, it's not guaranteed to work reliably across all browsers. For example, it won't work in the Edge or Safary browser. <br />
    </form>
</body>
</html>
