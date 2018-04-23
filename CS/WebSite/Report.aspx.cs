using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using DevExpress.XtraPrinting;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            XtraReport1 r = new XtraReport1();
            r.CreateDocument();
            PdfExportOptions opts = new PdfExportOptions();
            opts.ShowPrintDialogOnOpen = true;
            r.ExportToPdf(ms, opts);
            ms.Seek(0, SeekOrigin.Begin);
            byte[] report = ms.ToArray();
            Page.Response.ContentType = "application/pdf";
            Page.Response.Clear();
            Page.Response.OutputStream.Write(report, 0, report.Length);
            Page.Response.End();
        }
    }
}
