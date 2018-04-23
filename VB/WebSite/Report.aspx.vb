Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Xml.Linq
Imports System.IO
Imports DevExpress.XtraPrinting

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Using ms As New MemoryStream()
			Dim r As New XtraReport1()
			r.CreateDocument()
			Dim opts As New PdfExportOptions()
			opts.ShowPrintDialogOnOpen = True
			r.ExportToPdf(ms, opts)
			ms.Seek(0, SeekOrigin.Begin)
			Dim report() As Byte = ms.ToArray()
			Page.Response.ContentType = "application/pdf"
			Page.Response.Clear()
			Page.Response.OutputStream.Write(report, 0, report.Length)
			Page.Response.End()
		End Using
	End Sub
End Class
