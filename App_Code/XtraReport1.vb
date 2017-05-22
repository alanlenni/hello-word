Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private WithEvents xrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Private WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupFooterBand2 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupFooterBand3 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand4 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupFooterBand4 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Private WithEvents xrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "XtraReport1.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.XtraReport1.ResourceManager
        Dim tableQuery1 As DevExpress.DataAccess.Sql.TableQuery = New DevExpress.DataAccess.Sql.TableQuery()
        Dim tableInfo1 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
        Dim columnInfo1 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo2 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo3 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo4 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo5 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo6 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo7 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo8 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo9 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo10 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo11 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo12 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo13 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo14 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo15 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo16 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim columnInfo17 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim xrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.xrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupHeaderBand3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupFooterBand3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.xrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupHeaderBand4 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupFooterBand4 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.xrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.xrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.xrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel36, Me.xrLabel37, Me.xrLabel38, Me.xrLabel39, Me.xrLabel40, Me.xrLabel41, Me.xrLabel42, Me.xrLabel43, Me.xrLabel44, Me.xrLabel45, Me.xrLabel46})
        Me.Detail.HeightF = 29.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 14.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'sqlDataSource1
        '
        Me.sqlDataSource1.ConnectionName = "localhost\sqlexpress_DBSociConnection"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        tableQuery1.Name = "vw_gs_movcn_xdt_tot"
        tableInfo1.Name = "vw_gs_movcn_xdt_tot"
        columnInfo1.Name = "dteserc"
        columnInfo2.Name = "movcndt"
        columnInfo3.Name = "soc_cod"
        columnInfo4.Name = "movcntp"
        columnInfo5.Name = "movcntppag"
        columnInfo6.Name = "movcndesc"
        columnInfo7.Name = "movcnval"
        columnInfo8.Name = "movcnliq"
        columnInfo9.Name = "movcnra"
        columnInfo10.Name = "movcntppagdesc"
        columnInfo11.Name = "keyId"
        columnInfo12.Name = "movcnnr"
        columnInfo13.Name = "ritdesc"
        columnInfo14.Name = "movcn_CausRit"
        columnInfo15.Name = "dtcod"
        columnInfo16.Name = "clcognom"
        columnInfo17.Name = "clnome"
        tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11, columnInfo12, columnInfo13, columnInfo14, columnInfo15, columnInfo16, columnInfo17})
        tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {tableInfo1})
        Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {tableQuery1})
        Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
        '
        'pageHeaderBand1
        '
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrLabel2, Me.xrLabel3, Me.xrLabel4, Me.xrLabel5, Me.xrLabel6, Me.xrLabel7, Me.xrLabel8, Me.xrLabel9, Me.xrLabel10, Me.xrLabel11, Me.xrLabel12, Me.xrLabel13, Me.xrLabel14, Me.xrLabel15, Me.xrLine1, Me.xrLine2})
        Me.pageHeaderBand1.HeightF = 45.0!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        '
        'xrLabel1
        '
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 7.0!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(37.7388382!, 36.0!)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.Text = "movcndt"
        '
        'xrLabel2
        '
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(43.7388382!, 7.0!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(66.9330368!, 36.0!)
        Me.xrLabel2.StyleName = "FieldCaption"
        Me.xrLabel2.Text = "soc clcodcausrit"
        '
        'xrLabel3
        '
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(110.671898!, 7.0!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(51.9799118!, 36.0!)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.Text = "movcntppag"
        '
        'xrLabel4
        '
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(162.651794!, 7.0!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(38.4508896!, 36.0!)
        Me.xrLabel4.StyleName = "FieldCaption"
        Me.xrLabel4.Text = "movcnnr"
        '
        'xrLabel5
        '
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(201.102707!, 7.0!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(42.0111618!, 36.0!)
        Me.xrLabel5.StyleName = "FieldCaption"
        Me.xrLabel5.Text = "clcognom"
        '
        'xrLabel6
        '
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(243.113907!, 7.0!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(32.0424118!, 36.0!)
        Me.xrLabel6.StyleName = "FieldCaption"
        Me.xrLabel6.Text = "clnome"
        '
        'xrLabel7
        '
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(275.156311!, 7.0!)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(31.3303604!, 36.0!)
        Me.xrLabel7.StyleName = "FieldCaption"
        Me.xrLabel7.Text = "dteserc"
        '
        'xrLabel8
        '
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(306.486603!, 7.0!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(28.4821396!, 36.0!)
        Me.xrLabel8.StyleName = "FieldCaption"
        Me.xrLabel8.Text = "key Id"
        '
        'xrLabel9
        '
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(334.968811!, 7.0!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(47.7075882!, 36.0!)
        Me.xrLabel9.StyleName = "FieldCaption"
        Me.xrLabel9.Text = "movcndesc"
        '
        'xrLabel10
        '
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(382.676392!, 7.0!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(40.587059!, 36.0!)
        Me.xrLabel10.StyleName = "FieldCaption"
        Me.xrLabel10.Text = "movcnliq"
        '
        'xrLabel11
        '
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(423.263397!, 7.0!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(37.7388382!, 36.0!)
        Me.xrLabel11.StyleName = "FieldCaption"
        Me.xrLabel11.Text = "movcnra"
        '
        'xrLabel12
        '
        Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(461.002289!, 7.0!)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel12.SizeF = New System.Drawing.SizeF(37.7388382!, 36.0!)
        Me.xrLabel12.StyleName = "FieldCaption"
        Me.xrLabel12.Text = "movcntp"
        '
        'xrLabel13
        '
        Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(498.741089!, 7.0!)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel13.SizeF = New System.Drawing.SizeF(69.78125!, 36.0!)
        Me.xrLabel13.StyleName = "FieldCaption"
        Me.xrLabel13.Text = "movcntppagdesc"
        '
        'xrLabel14
        '
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(568.522278!, 7.0!)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(42.0111618!, 36.0!)
        Me.xrLabel14.StyleName = "FieldCaption"
        Me.xrLabel14.Text = "movcnval"
        '
        'xrLabel15
        '
        Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(610.533508!, 7.0!)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel15.SizeF = New System.Drawing.SizeF(33.4664917!, 36.0!)
        Me.xrLabel15.StyleName = "FieldCaption"
        Me.xrLabel15.Text = "soc cod"
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 5.0!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
        '
        'xrLine2
        '
        Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 43.0!)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel16})
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("movcndt", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.HeightF = 23.0!
        Me.groupHeaderBand1.Level = 3
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StyleName = "DataField"
        '
        'xrLabel16
        '
        Me.xrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcndt")})
        Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 0.0!)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel16.SizeF = New System.Drawing.SizeF(37.7388382!, 23.0!)
        Me.xrLabel16.Text = "xrLabel16"
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel17, Me.xrLabel18, Me.xrLabel19, Me.xrLabel20})
        Me.groupFooterBand1.HeightF = 30.0!
        Me.groupFooterBand1.Level = 3
        Me.groupFooterBand1.Name = "groupFooterBand1"
        '
        'xrLabel17
        '
        Me.xrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnliq", "{0:C2}")})
        Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(382.676392!, 6.0!)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel17.SizeF = New System.Drawing.SizeF(40.587059!, 18.0!)
        Me.xrLabel17.StyleName = "FieldCaption"
        xrSummary1.FormatString = "{0:C2}"
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel17.Summary = xrSummary1
        Me.xrLabel17.Text = "xrLabel17"
        '
        'xrLabel18
        '
        Me.xrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnra", "{0:C2}")})
        Me.xrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(423.263397!, 6.0!)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel18.SizeF = New System.Drawing.SizeF(37.7388382!, 18.0!)
        Me.xrLabel18.StyleName = "FieldCaption"
        xrSummary2.FormatString = "{0:C2}"
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel18.Summary = xrSummary2
        Me.xrLabel18.Text = "xrLabel18"
        '
        'xrLabel19
        '
        Me.xrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnval", "{0:C2}")})
        Me.xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(568.522278!, 6.0!)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel19.SizeF = New System.Drawing.SizeF(42.0111618!, 18.0!)
        Me.xrLabel19.StyleName = "FieldCaption"
        xrSummary3.FormatString = "{0:C2}"
        xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel19.Summary = xrSummary3
        Me.xrLabel19.Text = "xrLabel19"
        '
        'xrLabel20
        '
        Me.xrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrLabel20.Name = "xrLabel20"
        Me.xrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel20.SizeF = New System.Drawing.SizeF(195.102707!, 18.0!)
        Me.xrLabel20.StyleName = "FieldCaption"
        Me.xrLabel20.Text = "Sum"
        '
        'groupHeaderBand2
        '
        Me.groupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel21})
        Me.groupHeaderBand2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("soc_clcodcausrit", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand2.HeightF = 23.0!
        Me.groupHeaderBand2.Level = 2
        Me.groupHeaderBand2.Name = "groupHeaderBand2"
        Me.groupHeaderBand2.StyleName = "DataField"
        '
        'xrLabel21
        '
        Me.xrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.soc_clcodcausrit")})
        Me.xrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(43.7388382!, 0.0!)
        Me.xrLabel21.Name = "xrLabel21"
        Me.xrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel21.SizeF = New System.Drawing.SizeF(66.9330368!, 23.0!)
        Me.xrLabel21.Text = "xrLabel21"
        '
        'groupFooterBand2
        '
        Me.groupFooterBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel22, Me.xrLabel23, Me.xrLabel24, Me.xrLabel25})
        Me.groupFooterBand2.HeightF = 30.0!
        Me.groupFooterBand2.Level = 2
        Me.groupFooterBand2.Name = "groupFooterBand2"
        '
        'xrLabel22
        '
        Me.xrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnliq", "{0:C2}")})
        Me.xrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(382.676392!, 6.0!)
        Me.xrLabel22.Name = "xrLabel22"
        Me.xrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel22.SizeF = New System.Drawing.SizeF(40.587059!, 18.0!)
        Me.xrLabel22.StyleName = "FieldCaption"
        xrSummary4.FormatString = "{0:C2}"
        xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel22.Summary = xrSummary4
        Me.xrLabel22.Text = "xrLabel22"
        '
        'xrLabel23
        '
        Me.xrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnra", "{0:C2}")})
        Me.xrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(423.263397!, 6.0!)
        Me.xrLabel23.Name = "xrLabel23"
        Me.xrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel23.SizeF = New System.Drawing.SizeF(37.7388382!, 18.0!)
        Me.xrLabel23.StyleName = "FieldCaption"
        xrSummary5.FormatString = "{0:C2}"
        xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel23.Summary = xrSummary5
        Me.xrLabel23.Text = "xrLabel23"
        '
        'xrLabel24
        '
        Me.xrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnval", "{0:C2}")})
        Me.xrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(568.522278!, 6.0!)
        Me.xrLabel24.Name = "xrLabel24"
        Me.xrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel24.SizeF = New System.Drawing.SizeF(42.0111618!, 18.0!)
        Me.xrLabel24.StyleName = "FieldCaption"
        xrSummary6.FormatString = "{0:C2}"
        xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel24.Summary = xrSummary6
        Me.xrLabel24.Text = "xrLabel24"
        '
        'xrLabel25
        '
        Me.xrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(43.7388382!, 6.0!)
        Me.xrLabel25.Name = "xrLabel25"
        Me.xrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel25.SizeF = New System.Drawing.SizeF(157.3638!, 18.0!)
        Me.xrLabel25.StyleName = "FieldCaption"
        Me.xrLabel25.Text = "Sum"
        '
        'groupHeaderBand3
        '
        Me.groupHeaderBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel26})
        Me.groupHeaderBand3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("movcntppag", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand3.HeightF = 23.0!
        Me.groupHeaderBand3.Level = 1
        Me.groupHeaderBand3.Name = "groupHeaderBand3"
        Me.groupHeaderBand3.StyleName = "DataField"
        '
        'xrLabel26
        '
        Me.xrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcntppag")})
        Me.xrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(110.671898!, 0.0!)
        Me.xrLabel26.Name = "xrLabel26"
        Me.xrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel26.SizeF = New System.Drawing.SizeF(51.9799118!, 23.0!)
        Me.xrLabel26.Text = "xrLabel26"
        '
        'groupFooterBand3
        '
        Me.groupFooterBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel27, Me.xrLabel28, Me.xrLabel29, Me.xrLabel30})
        Me.groupFooterBand3.HeightF = 30.0!
        Me.groupFooterBand3.Level = 1
        Me.groupFooterBand3.Name = "groupFooterBand3"
        '
        'xrLabel27
        '
        Me.xrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnliq", "{0:C2}")})
        Me.xrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(382.676392!, 6.0!)
        Me.xrLabel27.Name = "xrLabel27"
        Me.xrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel27.SizeF = New System.Drawing.SizeF(40.587059!, 18.0!)
        Me.xrLabel27.StyleName = "FieldCaption"
        xrSummary7.FormatString = "{0:C2}"
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel27.Summary = xrSummary7
        Me.xrLabel27.Text = "xrLabel27"
        '
        'xrLabel28
        '
        Me.xrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnra", "{0:C2}")})
        Me.xrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(423.263397!, 6.0!)
        Me.xrLabel28.Name = "xrLabel28"
        Me.xrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel28.SizeF = New System.Drawing.SizeF(37.7388382!, 18.0!)
        Me.xrLabel28.StyleName = "FieldCaption"
        xrSummary8.FormatString = "{0:C2}"
        xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel28.Summary = xrSummary8
        Me.xrLabel28.Text = "xrLabel28"
        '
        'xrLabel29
        '
        Me.xrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnval", "{0:C2}")})
        Me.xrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(568.522278!, 6.0!)
        Me.xrLabel29.Name = "xrLabel29"
        Me.xrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel29.SizeF = New System.Drawing.SizeF(42.0111618!, 18.0!)
        Me.xrLabel29.StyleName = "FieldCaption"
        xrSummary9.FormatString = "{0:C2}"
        xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel29.Summary = xrSummary9
        Me.xrLabel29.Text = "xrLabel29"
        '
        'xrLabel30
        '
        Me.xrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(110.671898!, 6.0!)
        Me.xrLabel30.Name = "xrLabel30"
        Me.xrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel30.SizeF = New System.Drawing.SizeF(90.4308167!, 18.0!)
        Me.xrLabel30.StyleName = "FieldCaption"
        Me.xrLabel30.Text = "Sum"
        '
        'groupHeaderBand4
        '
        Me.groupHeaderBand4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel31})
        Me.groupHeaderBand4.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("movcnnr", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand4.HeightF = 23.0!
        Me.groupHeaderBand4.Name = "groupHeaderBand4"
        Me.groupHeaderBand4.StyleName = "DataField"
        '
        'xrLabel31
        '
        Me.xrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnnr")})
        Me.xrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(162.651794!, 0.0!)
        Me.xrLabel31.Name = "xrLabel31"
        Me.xrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel31.SizeF = New System.Drawing.SizeF(38.4508896!, 23.0!)
        Me.xrLabel31.Text = "xrLabel31"
        '
        'groupFooterBand4
        '
        Me.groupFooterBand4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel32, Me.xrLabel33, Me.xrLabel34, Me.xrLabel35})
        Me.groupFooterBand4.HeightF = 30.0!
        Me.groupFooterBand4.Name = "groupFooterBand4"
        '
        'xrLabel32
        '
        Me.xrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnliq", "{0:C2}")})
        Me.xrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(382.676392!, 6.0!)
        Me.xrLabel32.Name = "xrLabel32"
        Me.xrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel32.SizeF = New System.Drawing.SizeF(40.587059!, 18.0!)
        Me.xrLabel32.StyleName = "FieldCaption"
        xrSummary10.FormatString = "{0:C2}"
        xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel32.Summary = xrSummary10
        Me.xrLabel32.Text = "xrLabel32"
        '
        'xrLabel33
        '
        Me.xrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnra", "{0:C2}")})
        Me.xrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(423.263397!, 6.0!)
        Me.xrLabel33.Name = "xrLabel33"
        Me.xrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel33.SizeF = New System.Drawing.SizeF(37.7388382!, 18.0!)
        Me.xrLabel33.StyleName = "FieldCaption"
        xrSummary11.FormatString = "{0:C2}"
        xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel33.Summary = xrSummary11
        Me.xrLabel33.Text = "xrLabel33"
        '
        'xrLabel34
        '
        Me.xrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnval", "{0:C2}")})
        Me.xrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(568.522278!, 6.0!)
        Me.xrLabel34.Name = "xrLabel34"
        Me.xrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel34.SizeF = New System.Drawing.SizeF(42.0111618!, 18.0!)
        Me.xrLabel34.StyleName = "FieldCaption"
        xrSummary12.FormatString = "{0:C2}"
        xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel34.Summary = xrSummary12
        Me.xrLabel34.Text = "xrLabel34"
        '
        'xrLabel35
        '
        Me.xrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(162.651794!, 6.0!)
        Me.xrLabel35.Name = "xrLabel35"
        Me.xrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel35.SizeF = New System.Drawing.SizeF(38.450901!, 18.0!)
        Me.xrLabel35.StyleName = "FieldCaption"
        Me.xrLabel35.Text = "Sum"
        '
        'xrLabel36
        '
        Me.xrLabel36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.clcognom")})
        Me.xrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(201.102707!, 0.0!)
        Me.xrLabel36.Name = "xrLabel36"
        Me.xrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel36.SizeF = New System.Drawing.SizeF(42.0111618!, 17.0!)
        Me.xrLabel36.Text = "xrLabel36"
        '
        'xrLabel37
        '
        Me.xrLabel37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.clnome")})
        Me.xrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(243.113907!, 0.0!)
        Me.xrLabel37.Name = "xrLabel37"
        Me.xrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel37.SizeF = New System.Drawing.SizeF(32.0424118!, 17.0!)
        Me.xrLabel37.Text = "xrLabel37"
        '
        'xrLabel38
        '
        Me.xrLabel38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.dteserc")})
        Me.xrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(275.156311!, 0.0!)
        Me.xrLabel38.Name = "xrLabel38"
        Me.xrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel38.SizeF = New System.Drawing.SizeF(31.3303604!, 17.0!)
        Me.xrLabel38.Text = "xrLabel38"
        '
        'xrLabel39
        '
        Me.xrLabel39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.keyId")})
        Me.xrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(306.486603!, 0.0!)
        Me.xrLabel39.Name = "xrLabel39"
        Me.xrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel39.SizeF = New System.Drawing.SizeF(28.4821396!, 17.0!)
        Me.xrLabel39.Text = "xrLabel39"
        '
        'xrLabel40
        '
        Me.xrLabel40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcndesc")})
        Me.xrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(334.968811!, 0.0!)
        Me.xrLabel40.Name = "xrLabel40"
        Me.xrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel40.SizeF = New System.Drawing.SizeF(47.7075882!, 17.0!)
        Me.xrLabel40.Text = "xrLabel40"
        '
        'xrLabel41
        '
        Me.xrLabel41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnliq", "{0:C2}")})
        Me.xrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(382.676392!, 0.0!)
        Me.xrLabel41.Name = "xrLabel41"
        Me.xrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel41.SizeF = New System.Drawing.SizeF(40.587059!, 17.0!)
        Me.xrLabel41.Text = "xrLabel41"
        '
        'xrLabel42
        '
        Me.xrLabel42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnra", "{0:C2}")})
        Me.xrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(423.263397!, 0.0!)
        Me.xrLabel42.Name = "xrLabel42"
        Me.xrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel42.SizeF = New System.Drawing.SizeF(37.7388382!, 17.0!)
        Me.xrLabel42.Text = "xrLabel42"
        '
        'xrLabel43
        '
        Me.xrLabel43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcntp")})
        Me.xrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(461.002289!, 0.0!)
        Me.xrLabel43.Name = "xrLabel43"
        Me.xrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel43.SizeF = New System.Drawing.SizeF(37.7388382!, 17.0!)
        Me.xrLabel43.Text = "xrLabel43"
        '
        'xrLabel44
        '
        Me.xrLabel44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcntppagdesc")})
        Me.xrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(498.741089!, 0.0!)
        Me.xrLabel44.Name = "xrLabel44"
        Me.xrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel44.SizeF = New System.Drawing.SizeF(69.78125!, 17.0!)
        Me.xrLabel44.Text = "xrLabel44"
        '
        'xrLabel45
        '
        Me.xrLabel45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnval", "{0:C2}")})
        Me.xrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(568.522278!, 0.0!)
        Me.xrLabel45.Name = "xrLabel45"
        Me.xrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel45.SizeF = New System.Drawing.SizeF(42.0111618!, 17.0!)
        Me.xrLabel45.Text = "xrLabel45"
        '
        'xrLabel46
        '
        Me.xrLabel46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.soc_cod")})
        Me.xrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(610.533508!, 0.0!)
        Me.xrLabel46.Name = "xrLabel46"
        Me.xrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel46.SizeF = New System.Drawing.SizeF(33.4664917!, 17.0!)
        Me.xrLabel46.Text = "xrLabel46"
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.HeightF = 29.0!
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0!, 6.0!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel47, Me.xrLine3})
        Me.reportHeaderBand1.HeightF = 53.0!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel47
        '
        Me.xrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 2.0!)
        Me.xrLabel47.Name = "xrLabel47"
        Me.xrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel47.SizeF = New System.Drawing.SizeF(638.0!, 35.0!)
        Me.xrLabel47.StyleName = "Title"
        Me.xrLabel47.Text = "x"
        '
        'xrLine3
        '
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel48, Me.xrLabel49, Me.xrLabel50, Me.xrLabel51})
        Me.reportFooterBand1.HeightF = 30.0!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        '
        'xrLabel48
        '
        Me.xrLabel48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnliq", "{0:C2}")})
        Me.xrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(382.676392!, 6.0!)
        Me.xrLabel48.Name = "xrLabel48"
        Me.xrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel48.SizeF = New System.Drawing.SizeF(40.587059!, 18.0!)
        Me.xrLabel48.StyleName = "FieldCaption"
        xrSummary13.FormatString = "{0:C2}"
        xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.xrLabel48.Summary = xrSummary13
        Me.xrLabel48.Text = "xrLabel48"
        '
        'xrLabel49
        '
        Me.xrLabel49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnra", "{0:C2}")})
        Me.xrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(423.263397!, 6.0!)
        Me.xrLabel49.Name = "xrLabel49"
        Me.xrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel49.SizeF = New System.Drawing.SizeF(37.7388382!, 18.0!)
        Me.xrLabel49.StyleName = "FieldCaption"
        xrSummary14.FormatString = "{0:C2}"
        xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.xrLabel49.Summary = xrSummary14
        Me.xrLabel49.Text = "xrLabel49"
        '
        'xrLabel50
        '
        Me.xrLabel50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vw_gs_movcn_xdt_tot.movcnval", "{0:C2}")})
        Me.xrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(568.522278!, 6.0!)
        Me.xrLabel50.Name = "xrLabel50"
        Me.xrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel50.SizeF = New System.Drawing.SizeF(42.0111618!, 18.0!)
        Me.xrLabel50.StyleName = "FieldCaption"
        xrSummary15.FormatString = "{0:C2}"
        xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.xrLabel50.Summary = xrSummary15
        Me.xrLabel50.Text = "xrLabel50"
        '
        'xrLabel51
        '
        Me.xrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrLabel51.Name = "xrLabel51"
        Me.xrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel51.SizeF = New System.Drawing.SizeF(195.102707!, 18.0!)
        Me.xrLabel51.StyleName = "FieldCaption"
        Me.xrLabel51.Text = "Grand Total"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 21.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.groupFooterBand1, Me.groupHeaderBand2, Me.groupFooterBand2, Me.groupHeaderBand3, Me.groupFooterBand3, Me.groupHeaderBand4, Me.groupFooterBand4, Me.pageFooterBand1, Me.reportHeaderBand1, Me.reportFooterBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
        Me.DataMember = "vw_gs_movcn_xdt_tot"
        Me.DataSource = Me.sqlDataSource1
        Me.Margins = New System.Drawing.Printing.Margins(69, 73, 20, 14)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "14.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class