Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
	Private xrLabel1 As XRLabel
	Private xrPageInfo1 As XRPageInfo
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel1
		' 
		Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.xrLabel1.Location = New System.Drawing.Point(175, 33)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.Size = New System.Drawing.Size(325, 42)
		Me.xrLabel1.StylePriority.UseFont = False
		Me.xrLabel1.Text = "SAMPLE REPORT"
		' 
		' PageHeader
		' 
		Me.PageHeader.Height = 30
		Me.PageHeader.Name = "PageHeader"
		Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' PageFooter
		' 
		Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1})
		Me.PageFooter.Height = 73
		Me.PageFooter.Name = "PageFooter"
		Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrPageInfo1
		' 
		Me.xrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.xrPageInfo1.Location = New System.Drawing.Point(358, 0)
		Me.xrPageInfo1.Name = "xrPageInfo1"
		Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
		Me.xrPageInfo1.Size = New System.Drawing.Size(283, 33)
		Me.xrPageInfo1.StylePriority.UseFont = False
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
		Me.Version = "8.1"
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region
End Class
