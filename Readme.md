
# Reporting for ASP.NET - How to print a report without displaying it in a web application

<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Report.aspx.cs](./CS/WebSite/Report.aspx.cs) (VB: [Report.aspx.vb](./VB/WebSite/Report.aspx.vb))
<!-- default file list end -->

This example demonstrates how to use the browser's built-in PDF viewer to print a report in an ASP.NET application.
To do this, export the report to PDF and use the [Page.Response.OutputStream.Write](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream.write) method to send the exported document to the output.

## See Also

* [How to print/export XtraReport in an ASP.NET WebForms application without showing a report preview](https://supportcenter.devexpress.com/ticket/details/t227361/how-to-print-export-xtrareport-in-an-asp-net-webforms-application-without-showing-a)
* [How to print/export XtraReport in an ASP.NET MVC application without showing a report preview](https://supportcenter.devexpress.com/ticket/details/t569785/reporting-for-asp-net-mvc-how-to-print-or-export-a-report-without-showing-a-preview)

