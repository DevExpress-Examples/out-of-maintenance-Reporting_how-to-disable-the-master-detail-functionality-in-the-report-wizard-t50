Namespace UseStandardReportWizard
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xrDesignPanelListener1 As New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener()
            Dim xrDesignPanelListener2 As New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener()
            Dim xrDesignPanelListener3 As New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener()
            Dim xrDesignPanelListener4 As New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener()
            Dim xrDesignPanelListener5 As New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener()
            Dim xrDesignPanelListener6 As New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener()
            Dim xrDesignPanelListener7 As New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener()
            Dim barInfo1 As New DevExpress.XtraReports.UserDesigner.BarInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.reportDesigner1 = New DevExpress.XtraReports.UserDesigner.XRDesignMdiController(Me.components)
            Me.xrDesignBarManager1 = New DevExpress.XtraReports.UserDesigner.XRDesignBarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.designBar1 = New DevExpress.XtraReports.UserDesigner.DesignBar()
            Me.designBar2 = New DevExpress.XtraReports.UserDesigner.DesignBar()
            Me.designBar3 = New DevExpress.XtraReports.UserDesigner.DesignBar()
            Me.designBar4 = New DevExpress.XtraReports.UserDesigner.DesignBar()
            Me.designBar5 = New DevExpress.XtraReports.UserDesigner.DesignBar()
            Me.recentlyUsedItemsComboBox1 = New DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox()
            Me.designRepositoryItemComboBox1 = New DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox()
            Me.beiFontName = New DevExpress.XtraBars.BarEditItem()
            Me.beiFontSize = New DevExpress.XtraBars.BarEditItem()
            Me.bbiFontBold = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiFontItalic = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiFontUnderline = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiForeColor = New DevExpress.XtraReports.UserDesigner.CommandColorBarItem()
            Me.bbiBackColor = New DevExpress.XtraReports.UserDesigner.CommandColorBarItem()
            Me.bbiJustifyLeft = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiJustifyCenter = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiJustifyRight = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiJustifyJustify = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiAlignToGrid = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiAlignLeft = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiAlignVerticalCenters = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiAlignRight = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiAlignTop = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiAlignHorizontalCenters = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiAlignBottom = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiSizeToControlWidth = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiSizeToGrid = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiSizeToControlHeight = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiSizeToControl = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiHorizSpaceMakeEqual = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiHorizSpaceIncrease = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiHorizSpaceDecrease = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiHorizSpaceConcatenate = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiVertSpaceMakeEqual = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiVertSpaceIncrease = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiVertSpaceDecrease = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiVertSpaceConcatenate = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiCenterHorizontally = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiCenterVertically = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiBringToFront = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiSendToBack = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.commandBarItem1 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiOpenFile = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiSaveFile = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiCut = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiCopy = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiPaste = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiUndo = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiRedo = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bsiHint = New DevExpress.XtraBars.BarStaticItem()
            Me.msiFile = New DevExpress.XtraBars.BarSubItem()
            Me.msiEdit = New DevExpress.XtraBars.BarSubItem()
            Me.msiTabButtons = New DevExpress.XtraBars.BarSubItem()
            Me.barReportTabButtonsListItem1 = New DevExpress.XtraReports.UserDesigner.BarReportTabButtonsListItem()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.xrBarToolbarsListItem1 = New DevExpress.XtraReports.UserDesigner.XRBarToolbarsListItem()
            Me.barSubItem2 = New DevExpress.XtraBars.BarSubItem()
            Me.barDockPanelsListItem1 = New DevExpress.XtraReports.UserDesigner.BarDockPanelsListItem()
            Me.msiFormat = New DevExpress.XtraBars.BarSubItem()
            Me.msiFont = New DevExpress.XtraBars.BarSubItem()
            Me.msiJustify = New DevExpress.XtraBars.BarSubItem()
            Me.msiAlign = New DevExpress.XtraBars.BarSubItem()
            Me.msiSameSize = New DevExpress.XtraBars.BarSubItem()
            Me.msiHorizontalSpacing = New DevExpress.XtraBars.BarSubItem()
            Me.msiVerticalSpacing = New DevExpress.XtraBars.BarSubItem()
            Me.bsiCenter = New DevExpress.XtraBars.BarSubItem()
            Me.msiOrder = New DevExpress.XtraBars.BarSubItem()
            Me.commandBarItem2 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.commandBarItem3 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.commandBarItem4 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.commandBarItem5 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.commandBarItem6 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.commandBarItem7 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.msiWindow = New DevExpress.XtraBars.BarSubItem()
            Me.msiWindowInterface = New DevExpress.XtraReports.UserDesigner.CommandBarCheckItem()
            Me.commandBarItem8 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.commandBarItem9 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.commandBarItem10 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.msiWindows = New DevExpress.XtraBars.BarMdiChildrenListItem()
            Me.commandBarItem11 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.bbiZoomOut = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bbiZoom = New DevExpress.XtraReports.UserDesigner.XRZoomBarEditItem()
            Me.designRepositoryItemComboBox2 = New DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox()
            Me.bbiZoomIn = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.xrDesignDockManager1 = New DevExpress.XtraReports.UserDesigner.XRDesignDockManager(Me.components)
            Me.fieldListDockPanel1 = New DevExpress.XtraReports.UserDesigner.FieldListDockPanel()
            Me.fieldListDockPanel1_Container = New DevExpress.XtraReports.UserDesigner.DesignControlContainer()
            Me.propertyGridDockPanel1 = New DevExpress.XtraReports.UserDesigner.PropertyGridDockPanel()
            Me.propertyGridDockPanel1_Container = New DevExpress.XtraReports.UserDesigner.DesignControlContainer()
            Me.reportExplorerDockPanel1 = New DevExpress.XtraReports.UserDesigner.ReportExplorerDockPanel()
            Me.reportExplorerDockPanel1_Container = New DevExpress.XtraReports.UserDesigner.DesignControlContainer()
            Me.groupAndSortDockPanel1 = New DevExpress.XtraReports.UserDesigner.GroupAndSortDockPanel()
            Me.groupAndSortDockPanel1_Container = New DevExpress.XtraReports.UserDesigner.DesignControlContainer()
            Me.errorListDockPanel1 = New DevExpress.XtraReports.UserDesigner.ErrorListDockPanel()
            Me.errorListDockPanel1_Container = New DevExpress.XtraReports.UserDesigner.DesignControlContainer()
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.panelContainer2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.panelContainer3 = New DevExpress.XtraBars.Docking.DockPanel()
            DirectCast(Me.xrDesignBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.recentlyUsedItemsComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.designRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.designRepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrDesignDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.fieldListDockPanel1.SuspendLayout()
            Me.propertyGridDockPanel1.SuspendLayout()
            Me.reportExplorerDockPanel1.SuspendLayout()
            Me.groupAndSortDockPanel1.SuspendLayout()
            Me.errorListDockPanel1.SuspendLayout()
            Me.panelContainer1.SuspendLayout()
            Me.panelContainer2.SuspendLayout()
            Me.panelContainer3.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' reportDesigner1
            ' 
            Me.reportDesigner1.ContainerControl = Nothing
            xrDesignPanelListener1.DesignControl = Me.xrDesignBarManager1
            xrDesignPanelListener2.DesignControl = Me.xrDesignDockManager1
            xrDesignPanelListener3.DesignControl = Me.fieldListDockPanel1
            xrDesignPanelListener4.DesignControl = Me.propertyGridDockPanel1
            xrDesignPanelListener5.DesignControl = Me.reportExplorerDockPanel1
            xrDesignPanelListener6.DesignControl = Me.groupAndSortDockPanel1
            xrDesignPanelListener7.DesignControl = Me.errorListDockPanel1
            Me.reportDesigner1.DesignPanelListeners.AddRange(New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener() { xrDesignPanelListener1, xrDesignPanelListener2, xrDesignPanelListener3, xrDesignPanelListener4, xrDesignPanelListener5, xrDesignPanelListener6, xrDesignPanelListener7})
            Me.reportDesigner1.Form = Me
            ' 
            ' xrDesignBarManager1
            ' 
            barInfo1.Bar = Me.bar2
            barInfo1.ToolboxType = DevExpress.XtraReports.UserDesigner.ToolboxType.Standard
            Me.xrDesignBarManager1.BarInfos.AddRange(New DevExpress.XtraReports.UserDesigner.BarInfo() { barInfo1})
            Me.xrDesignBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.designBar1, Me.designBar2, Me.designBar3, Me.designBar4, Me.designBar5, Me.bar1, Me.bar2})
            Me.xrDesignBarManager1.DockControls.Add(Me.barDockControlTop)
            Me.xrDesignBarManager1.DockControls.Add(Me.barDockControlBottom)
            Me.xrDesignBarManager1.DockControls.Add(Me.barDockControlLeft)
            Me.xrDesignBarManager1.DockControls.Add(Me.barDockControlRight)
            Me.xrDesignBarManager1.DockManager = Me.xrDesignDockManager1
            Me.xrDesignBarManager1.FontNameBox = Me.recentlyUsedItemsComboBox1
            Me.xrDesignBarManager1.FontNameEdit = Me.beiFontName
            Me.xrDesignBarManager1.FontSizeBox = Me.designRepositoryItemComboBox1
            Me.xrDesignBarManager1.FontSizeEdit = Me.beiFontSize
            Me.xrDesignBarManager1.Form = Me
            Me.xrDesignBarManager1.FormattingToolbar = Me.designBar3
            Me.xrDesignBarManager1.HintStaticItem = Me.bsiHint
            Me.xrDesignBarManager1.ImageStream = (DirectCast(resources.GetObject("xrDesignBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.xrDesignBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.beiFontName, Me.beiFontSize, Me.bbiFontBold, Me.bbiFontItalic, Me.bbiFontUnderline, Me.bbiForeColor, Me.bbiBackColor, Me.bbiJustifyLeft, Me.bbiJustifyCenter, Me.bbiJustifyRight, Me.bbiJustifyJustify, Me.bbiAlignToGrid, Me.bbiAlignLeft, Me.bbiAlignVerticalCenters, Me.bbiAlignRight, Me.bbiAlignTop, Me.bbiAlignHorizontalCenters, Me.bbiAlignBottom, Me.bbiSizeToControlWidth, Me.bbiSizeToGrid, Me.bbiSizeToControlHeight, Me.bbiSizeToControl, Me.bbiHorizSpaceMakeEqual, Me.bbiHorizSpaceIncrease, Me.bbiHorizSpaceDecrease, Me.bbiHorizSpaceConcatenate, Me.bbiVertSpaceMakeEqual, Me.bbiVertSpaceIncrease, Me.bbiVertSpaceDecrease, Me.bbiVertSpaceConcatenate, Me.bbiCenterHorizontally, Me.bbiCenterVertically, Me.bbiBringToFront, Me.bbiSendToBack, Me.commandBarItem1, Me.bbiOpenFile, Me.bbiSaveFile, Me.bbiCut, Me.bbiCopy, Me.bbiPaste, Me.bbiUndo, Me.bbiRedo, Me.bsiHint, Me.msiFile, Me.msiEdit, Me.msiTabButtons, Me.barReportTabButtonsListItem1, Me.barSubItem1, Me.xrBarToolbarsListItem1, Me.barSubItem2, Me.barDockPanelsListItem1, Me.msiFormat, Me.msiFont, Me.msiJustify, Me.msiAlign, Me.msiSameSize, Me.msiHorizontalSpacing, Me.msiVerticalSpacing, Me.bsiCenter, Me.msiOrder, Me.commandBarItem2, Me.commandBarItem3, Me.commandBarItem4, Me.commandBarItem5, Me.commandBarItem6, Me.commandBarItem7, Me.msiWindow, Me.msiWindowInterface, Me.commandBarItem8, Me.commandBarItem9, Me.commandBarItem10, Me.msiWindows, Me.commandBarItem11, Me.bbiZoomOut, Me.bbiZoom, Me.bbiZoomIn})
            Me.xrDesignBarManager1.LayoutToolbar = Me.designBar4
            Me.xrDesignBarManager1.MainMenu = Me.designBar1
            Me.xrDesignBarManager1.MaxItemId = 76
            Me.xrDesignBarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.recentlyUsedItemsComboBox1, Me.designRepositoryItemComboBox1, Me.designRepositoryItemComboBox2})
            Me.xrDesignBarManager1.StatusBar = Me.designBar5
            Me.xrDesignBarManager1.Toolbar = Me.designBar2
            Me.xrDesignBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True
            Me.xrDesignBarManager1.Updates.AddRange(New String() { "Toolbox"})
            Me.xrDesignBarManager1.ZoomItem = Me.bbiZoom
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.xrDesignBarManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(952, 84)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 474)
            Me.barDockControlBottom.Manager = Me.xrDesignBarManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(952, 25)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 84)
            Me.barDockControlLeft.Manager = Me.xrDesignBarManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(29, 390)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(952, 84)
            Me.barDockControlRight.Manager = Me.xrDesignBarManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 390)
            ' 
            ' designBar1
            ' 
            Me.designBar1.BarName = "Main Menu"
            Me.designBar1.DockCol = 0
            Me.designBar1.DockRow = 0
            Me.designBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.designBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiFile), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiEdit), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiTabButtons), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiFormat), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiWindow) _
            })
            Me.designBar1.OptionsBar.MultiLine = True
            Me.designBar1.OptionsBar.UseWholeRow = True
            Me.designBar1.Text = "Main Menu"
            ' 
            ' designBar2
            ' 
            Me.designBar2.BarName = "Toolbar"
            Me.designBar2.DockCol = 0
            Me.designBar2.DockRow = 1
            Me.designBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.designBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiOpenFile), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSaveFile), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem7), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCut, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCopy), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPaste), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiUndo, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRedo) _
            })
            Me.designBar2.Text = "Toolbar"
            ' 
            ' designBar3
            ' 
            Me.designBar3.BarName = "Formatting Toolbar"
            Me.designBar3.DockCol = 1
            Me.designBar3.DockRow = 1
            Me.designBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.designBar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.beiFontName), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.beiFontSize), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFontBold), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFontItalic), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFontUnderline), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiForeColor, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiBackColor), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJustifyLeft, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJustifyCenter), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJustifyRight), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJustifyJustify) _
            })
            Me.designBar3.Text = "Formatting Toolbar"
            ' 
            ' designBar4
            ' 
            Me.designBar4.BarName = "Layout Toolbar"
            Me.designBar4.DockCol = 0
            Me.designBar4.DockRow = 2
            Me.designBar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.designBar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignToGrid), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignLeft, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignVerticalCenters), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignRight), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignTop, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignHorizontalCenters), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignBottom), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSizeToControlWidth, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSizeToGrid), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSizeToControlHeight), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSizeToControl), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHorizSpaceMakeEqual, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHorizSpaceIncrease), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHorizSpaceDecrease), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHorizSpaceConcatenate), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVertSpaceMakeEqual, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVertSpaceIncrease), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVertSpaceDecrease), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVertSpaceConcatenate), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCenterHorizontally, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCenterVertically), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiBringToFront, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSendToBack) _
            })
            Me.designBar4.Text = "Layout Toolbar"
            ' 
            ' designBar5
            ' 
            Me.designBar5.BarName = "Status Bar"
            Me.designBar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.designBar5.DockCol = 0
            Me.designBar5.DockRow = 0
            Me.designBar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.designBar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bsiHint)})
            Me.designBar5.OptionsBar.AllowQuickCustomization = False
            Me.designBar5.OptionsBar.DrawDragBorder = False
            Me.designBar5.OptionsBar.UseWholeRow = True
            Me.designBar5.Text = "Status Bar"
            ' 
            ' recentlyUsedItemsComboBox1
            ' 
            Me.recentlyUsedItemsComboBox1.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 11.25F)
            Me.recentlyUsedItemsComboBox1.AppearanceDropDown.Options.UseFont = True
            Me.recentlyUsedItemsComboBox1.AutoHeight = False
            Me.recentlyUsedItemsComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.recentlyUsedItemsComboBox1.DropDownRows = 12
            Me.recentlyUsedItemsComboBox1.Name = "recentlyUsedItemsComboBox1"
            ' 
            ' designRepositoryItemComboBox1
            ' 
            Me.designRepositoryItemComboBox1.AutoHeight = False
            Me.designRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.designRepositoryItemComboBox1.Name = "designRepositoryItemComboBox1"
            ' 
            ' beiFontName
            ' 
            Me.beiFontName.Caption = "Font Name"
            Me.beiFontName.Edit = Me.recentlyUsedItemsComboBox1
            Me.beiFontName.EditWidth = 120
            Me.beiFontName.Hint = "Font Name"
            Me.beiFontName.Id = 0
            Me.beiFontName.Name = "beiFontName"
            ' 
            ' beiFontSize
            ' 
            Me.beiFontSize.Caption = "Font Size"
            Me.beiFontSize.Edit = Me.designRepositoryItemComboBox1
            Me.beiFontSize.EditWidth = 55
            Me.beiFontSize.Hint = "Font Size"
            Me.beiFontSize.Id = 1
            Me.beiFontSize.Name = "beiFontSize"
            ' 
            ' bbiFontBold
            ' 
            Me.bbiFontBold.Caption = "&Bold"
            Me.bbiFontBold.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.FontBold
            Me.bbiFontBold.Enabled = False
            Me.bbiFontBold.Hint = "Make the font bold"
            Me.bbiFontBold.Id = 2
            Me.bbiFontBold.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
            Me.bbiFontBold.Name = "bbiFontBold"
            ' 
            ' bbiFontItalic
            ' 
            Me.bbiFontItalic.Caption = "&Italic"
            Me.bbiFontItalic.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.FontItalic
            Me.bbiFontItalic.Enabled = False
            Me.bbiFontItalic.Hint = "Make the font italic"
            Me.bbiFontItalic.Id = 3
            Me.bbiFontItalic.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
            Me.bbiFontItalic.Name = "bbiFontItalic"
            ' 
            ' bbiFontUnderline
            ' 
            Me.bbiFontUnderline.Caption = "&Underline"
            Me.bbiFontUnderline.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.FontUnderline
            Me.bbiFontUnderline.Enabled = False
            Me.bbiFontUnderline.Hint = "Underline the font"
            Me.bbiFontUnderline.Id = 4
            Me.bbiFontUnderline.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
            Me.bbiFontUnderline.Name = "bbiFontUnderline"
            ' 
            ' bbiForeColor
            ' 
            Me.bbiForeColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.bbiForeColor.Caption = "For&eground Color"
            Me.bbiForeColor.CloseSubMenuOnClick = False
            Me.bbiForeColor.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.ForeColor
            Me.bbiForeColor.Enabled = False
            Me.bbiForeColor.Hint = "Set the foreground color of the control"
            Me.bbiForeColor.Id = 5
            Me.bbiForeColor.Name = "bbiForeColor"
            ' 
            ' bbiBackColor
            ' 
            Me.bbiBackColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.bbiBackColor.Caption = "Bac&kground Color"
            Me.bbiBackColor.CloseSubMenuOnClick = False
            Me.bbiBackColor.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.BackColor
            Me.bbiBackColor.Enabled = False
            Me.bbiBackColor.Hint = "Set the background color of the control"
            Me.bbiBackColor.Id = 6
            Me.bbiBackColor.Name = "bbiBackColor"
            ' 
            ' bbiJustifyLeft
            ' 
            Me.bbiJustifyLeft.Caption = "&Left"
            Me.bbiJustifyLeft.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyLeft
            Me.bbiJustifyLeft.Enabled = False
            Me.bbiJustifyLeft.Hint = "Align the control's text to the left"
            Me.bbiJustifyLeft.Id = 7
            Me.bbiJustifyLeft.Name = "bbiJustifyLeft"
            ' 
            ' bbiJustifyCenter
            ' 
            Me.bbiJustifyCenter.Caption = "&Center"
            Me.bbiJustifyCenter.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyCenter
            Me.bbiJustifyCenter.Enabled = False
            Me.bbiJustifyCenter.Hint = "Align the control's text to the center"
            Me.bbiJustifyCenter.Id = 8
            Me.bbiJustifyCenter.Name = "bbiJustifyCenter"
            ' 
            ' bbiJustifyRight
            ' 
            Me.bbiJustifyRight.Caption = "&Rights"
            Me.bbiJustifyRight.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyRight
            Me.bbiJustifyRight.Enabled = False
            Me.bbiJustifyRight.Hint = "Align the control's text to the right"
            Me.bbiJustifyRight.Id = 9
            Me.bbiJustifyRight.Name = "bbiJustifyRight"
            ' 
            ' bbiJustifyJustify
            ' 
            Me.bbiJustifyJustify.Caption = "&Justify"
            Me.bbiJustifyJustify.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyJustify
            Me.bbiJustifyJustify.Enabled = False
            Me.bbiJustifyJustify.Hint = "Justify the control's text"
            Me.bbiJustifyJustify.Id = 10
            Me.bbiJustifyJustify.Name = "bbiJustifyJustify"
            ' 
            ' bbiAlignToGrid
            ' 
            Me.bbiAlignToGrid.Caption = "to &Grid"
            Me.bbiAlignToGrid.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignToGrid
            Me.bbiAlignToGrid.Enabled = False
            Me.bbiAlignToGrid.Hint = "Align the positions of the selected controls to the grid"
            Me.bbiAlignToGrid.Id = 11
            Me.bbiAlignToGrid.Name = "bbiAlignToGrid"
            ' 
            ' bbiAlignLeft
            ' 
            Me.bbiAlignLeft.Caption = "&Lefts"
            Me.bbiAlignLeft.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignLeft
            Me.bbiAlignLeft.Enabled = False
            Me.bbiAlignLeft.Hint = "Left align the selected controls"
            Me.bbiAlignLeft.Id = 12
            Me.bbiAlignLeft.Name = "bbiAlignLeft"
            ' 
            ' bbiAlignVerticalCenters
            ' 
            Me.bbiAlignVerticalCenters.Caption = "&Centers"
            Me.bbiAlignVerticalCenters.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignVerticalCenters
            Me.bbiAlignVerticalCenters.Enabled = False
            Me.bbiAlignVerticalCenters.Hint = "Align the centers of the selected controls vertically"
            Me.bbiAlignVerticalCenters.Id = 13
            Me.bbiAlignVerticalCenters.Name = "bbiAlignVerticalCenters"
            ' 
            ' bbiAlignRight
            ' 
            Me.bbiAlignRight.Caption = "&Rights"
            Me.bbiAlignRight.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignRight
            Me.bbiAlignRight.Enabled = False
            Me.bbiAlignRight.Hint = "Right align the selected controls"
            Me.bbiAlignRight.Id = 14
            Me.bbiAlignRight.Name = "bbiAlignRight"
            ' 
            ' bbiAlignTop
            ' 
            Me.bbiAlignTop.Caption = "&Tops"
            Me.bbiAlignTop.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignTop
            Me.bbiAlignTop.Enabled = False
            Me.bbiAlignTop.Hint = "Align the tops of the selected controls"
            Me.bbiAlignTop.Id = 15
            Me.bbiAlignTop.Name = "bbiAlignTop"
            ' 
            ' bbiAlignHorizontalCenters
            ' 
            Me.bbiAlignHorizontalCenters.Caption = "&Middles"
            Me.bbiAlignHorizontalCenters.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignHorizontalCenters
            Me.bbiAlignHorizontalCenters.Enabled = False
            Me.bbiAlignHorizontalCenters.Hint = "Align the centers of the selected controls horizontally"
            Me.bbiAlignHorizontalCenters.Id = 16
            Me.bbiAlignHorizontalCenters.Name = "bbiAlignHorizontalCenters"
            ' 
            ' bbiAlignBottom
            ' 
            Me.bbiAlignBottom.Caption = "&Bottoms"
            Me.bbiAlignBottom.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignBottom
            Me.bbiAlignBottom.Enabled = False
            Me.bbiAlignBottom.Hint = "Align the bottoms of the selected controls"
            Me.bbiAlignBottom.Id = 17
            Me.bbiAlignBottom.Name = "bbiAlignBottom"
            ' 
            ' bbiSizeToControlWidth
            ' 
            Me.bbiSizeToControlWidth.Caption = "&Width"
            Me.bbiSizeToControlWidth.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToControlWidth
            Me.bbiSizeToControlWidth.Enabled = False
            Me.bbiSizeToControlWidth.Hint = "Make the selected controls have the same width"
            Me.bbiSizeToControlWidth.Id = 18
            Me.bbiSizeToControlWidth.Name = "bbiSizeToControlWidth"
            ' 
            ' bbiSizeToGrid
            ' 
            Me.bbiSizeToGrid.Caption = "Size to Gri&d"
            Me.bbiSizeToGrid.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToGrid
            Me.bbiSizeToGrid.Enabled = False
            Me.bbiSizeToGrid.Hint = "Size the selected controls to the grid"
            Me.bbiSizeToGrid.Id = 19
            Me.bbiSizeToGrid.Name = "bbiSizeToGrid"
            ' 
            ' bbiSizeToControlHeight
            ' 
            Me.bbiSizeToControlHeight.Caption = "&Height"
            Me.bbiSizeToControlHeight.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToControlHeight
            Me.bbiSizeToControlHeight.Enabled = False
            Me.bbiSizeToControlHeight.Hint = "Make the selected controls have the same height"
            Me.bbiSizeToControlHeight.Id = 20
            Me.bbiSizeToControlHeight.Name = "bbiSizeToControlHeight"
            ' 
            ' bbiSizeToControl
            ' 
            Me.bbiSizeToControl.Caption = "&Both"
            Me.bbiSizeToControl.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToControl
            Me.bbiSizeToControl.Enabled = False
            Me.bbiSizeToControl.Hint = "Make the selected controls the same size"
            Me.bbiSizeToControl.Id = 21
            Me.bbiSizeToControl.Name = "bbiSizeToControl"
            ' 
            ' bbiHorizSpaceMakeEqual
            ' 
            Me.bbiHorizSpaceMakeEqual.Caption = "Make &Equal"
            Me.bbiHorizSpaceMakeEqual.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceMakeEqual
            Me.bbiHorizSpaceMakeEqual.Enabled = False
            Me.bbiHorizSpaceMakeEqual.Hint = "Make the spacing between the selected controls equal"
            Me.bbiHorizSpaceMakeEqual.Id = 22
            Me.bbiHorizSpaceMakeEqual.Name = "bbiHorizSpaceMakeEqual"
            ' 
            ' bbiHorizSpaceIncrease
            ' 
            Me.bbiHorizSpaceIncrease.Caption = "&Increase"
            Me.bbiHorizSpaceIncrease.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceIncrease
            Me.bbiHorizSpaceIncrease.Enabled = False
            Me.bbiHorizSpaceIncrease.Hint = "Increase the spacing between the selected controls"
            Me.bbiHorizSpaceIncrease.Id = 23
            Me.bbiHorizSpaceIncrease.Name = "bbiHorizSpaceIncrease"
            ' 
            ' bbiHorizSpaceDecrease
            ' 
            Me.bbiHorizSpaceDecrease.Caption = "&Decrease"
            Me.bbiHorizSpaceDecrease.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceDecrease
            Me.bbiHorizSpaceDecrease.Enabled = False
            Me.bbiHorizSpaceDecrease.Hint = "Decrease the spacing between the selected controls"
            Me.bbiHorizSpaceDecrease.Id = 24
            Me.bbiHorizSpaceDecrease.Name = "bbiHorizSpaceDecrease"
            ' 
            ' bbiHorizSpaceConcatenate
            ' 
            Me.bbiHorizSpaceConcatenate.Caption = "&Remove"
            Me.bbiHorizSpaceConcatenate.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceConcatenate
            Me.bbiHorizSpaceConcatenate.Enabled = False
            Me.bbiHorizSpaceConcatenate.Hint = "Remove the spacing between the selected controls"
            Me.bbiHorizSpaceConcatenate.Id = 25
            Me.bbiHorizSpaceConcatenate.Name = "bbiHorizSpaceConcatenate"
            ' 
            ' bbiVertSpaceMakeEqual
            ' 
            Me.bbiVertSpaceMakeEqual.Caption = "Make &Equal"
            Me.bbiVertSpaceMakeEqual.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceMakeEqual
            Me.bbiVertSpaceMakeEqual.Enabled = False
            Me.bbiVertSpaceMakeEqual.Hint = "Make the spacing between the selected controls equal"
            Me.bbiVertSpaceMakeEqual.Id = 26
            Me.bbiVertSpaceMakeEqual.Name = "bbiVertSpaceMakeEqual"
            ' 
            ' bbiVertSpaceIncrease
            ' 
            Me.bbiVertSpaceIncrease.Caption = "&Increase"
            Me.bbiVertSpaceIncrease.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceIncrease
            Me.bbiVertSpaceIncrease.Enabled = False
            Me.bbiVertSpaceIncrease.Hint = "Increase the spacing between the selected controls"
            Me.bbiVertSpaceIncrease.Id = 27
            Me.bbiVertSpaceIncrease.Name = "bbiVertSpaceIncrease"
            ' 
            ' bbiVertSpaceDecrease
            ' 
            Me.bbiVertSpaceDecrease.Caption = "&Decrease"
            Me.bbiVertSpaceDecrease.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceDecrease
            Me.bbiVertSpaceDecrease.Enabled = False
            Me.bbiVertSpaceDecrease.Hint = "Decrease the spacing between the selected controls"
            Me.bbiVertSpaceDecrease.Id = 28
            Me.bbiVertSpaceDecrease.Name = "bbiVertSpaceDecrease"
            ' 
            ' bbiVertSpaceConcatenate
            ' 
            Me.bbiVertSpaceConcatenate.Caption = "&Remove"
            Me.bbiVertSpaceConcatenate.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceConcatenate
            Me.bbiVertSpaceConcatenate.Enabled = False
            Me.bbiVertSpaceConcatenate.Hint = "Remove the spacing between the selected controls"
            Me.bbiVertSpaceConcatenate.Id = 29
            Me.bbiVertSpaceConcatenate.Name = "bbiVertSpaceConcatenate"
            ' 
            ' bbiCenterHorizontally
            ' 
            Me.bbiCenterHorizontally.Caption = "&Horizontally"
            Me.bbiCenterHorizontally.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.CenterHorizontally
            Me.bbiCenterHorizontally.Enabled = False
            Me.bbiCenterHorizontally.Hint = "Horizontally center the selected controls within a band"
            Me.bbiCenterHorizontally.Id = 30
            Me.bbiCenterHorizontally.Name = "bbiCenterHorizontally"
            ' 
            ' bbiCenterVertically
            ' 
            Me.bbiCenterVertically.Caption = "&Vertically"
            Me.bbiCenterVertically.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.CenterVertically
            Me.bbiCenterVertically.Enabled = False
            Me.bbiCenterVertically.Hint = "Vertically center the selected controls within a band"
            Me.bbiCenterVertically.Id = 31
            Me.bbiCenterVertically.Name = "bbiCenterVertically"
            ' 
            ' bbiBringToFront
            ' 
            Me.bbiBringToFront.Caption = "&Bring to Front"
            Me.bbiBringToFront.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.BringToFront
            Me.bbiBringToFront.Enabled = False
            Me.bbiBringToFront.Hint = "Bring the selected controls to the front"
            Me.bbiBringToFront.Id = 32
            Me.bbiBringToFront.Name = "bbiBringToFront"
            ' 
            ' bbiSendToBack
            ' 
            Me.bbiSendToBack.Caption = "&Send to Back"
            Me.bbiSendToBack.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SendToBack
            Me.bbiSendToBack.Enabled = False
            Me.bbiSendToBack.Hint = "Move the selected controls to the back"
            Me.bbiSendToBack.Id = 33
            Me.bbiSendToBack.Name = "bbiSendToBack"
            ' 
            ' commandBarItem1
            ' 
            Me.commandBarItem1.Caption = "&New"
            Me.commandBarItem1.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.NewReport
            Me.commandBarItem1.Hint = "Create a new blank report"
            Me.commandBarItem1.Id = 34
            Me.commandBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
            Me.commandBarItem1.Name = "commandBarItem1"
            ' 
            ' bbiOpenFile
            ' 
            Me.bbiOpenFile.Caption = "&Open..."
            Me.bbiOpenFile.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.OpenFile
            Me.bbiOpenFile.Hint = "Open a report"
            Me.bbiOpenFile.Id = 35
            Me.bbiOpenFile.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.bbiOpenFile.Name = "bbiOpenFile"
            ' 
            ' bbiSaveFile
            ' 
            Me.bbiSaveFile.Caption = "&Save"
            Me.bbiSaveFile.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SaveFile
            Me.bbiSaveFile.Enabled = False
            Me.bbiSaveFile.Hint = "Save the report"
            Me.bbiSaveFile.Id = 36
            Me.bbiSaveFile.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
            Me.bbiSaveFile.Name = "bbiSaveFile"
            ' 
            ' bbiCut
            ' 
            Me.bbiCut.Caption = "Cu&t"
            Me.bbiCut.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Cut
            Me.bbiCut.Enabled = False
            Me.bbiCut.Hint = "Delete the control and copy it to the clipboard"
            Me.bbiCut.Id = 37
            Me.bbiCut.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
            Me.bbiCut.Name = "bbiCut"
            ' 
            ' bbiCopy
            ' 
            Me.bbiCopy.Caption = "&Copy"
            Me.bbiCopy.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Copy
            Me.bbiCopy.Enabled = False
            Me.bbiCopy.Hint = "Copy the control to the clipboard"
            Me.bbiCopy.Id = 38
            Me.bbiCopy.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
            Me.bbiCopy.Name = "bbiCopy"
            ' 
            ' bbiPaste
            ' 
            Me.bbiPaste.Caption = "&Paste"
            Me.bbiPaste.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Paste
            Me.bbiPaste.Enabled = False
            Me.bbiPaste.Hint = "Add the control from the clipboard"
            Me.bbiPaste.Id = 39
            Me.bbiPaste.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
            Me.bbiPaste.Name = "bbiPaste"
            ' 
            ' bbiUndo
            ' 
            Me.bbiUndo.Caption = "&Undo"
            Me.bbiUndo.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Undo
            Me.bbiUndo.Enabled = False
            Me.bbiUndo.Hint = "Undo the last operation"
            Me.bbiUndo.Id = 40
            Me.bbiUndo.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
            Me.bbiUndo.Name = "bbiUndo"
            ' 
            ' bbiRedo
            ' 
            Me.bbiRedo.Caption = "&Redo"
            Me.bbiRedo.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Redo
            Me.bbiRedo.Enabled = False
            Me.bbiRedo.Hint = "Redo the last operation"
            Me.bbiRedo.Id = 41
            Me.bbiRedo.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
            Me.bbiRedo.Name = "bbiRedo"
            ' 
            ' bsiHint
            ' 
            Me.bsiHint.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
            Me.bsiHint.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.bsiHint.Id = 42
            Me.bsiHint.Name = "bsiHint"
            ' 
            ' msiFile
            ' 
            Me.msiFile.Caption = "&File"
            Me.msiFile.Id = 43
            Me.msiFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiOpenFile), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSaveFile, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem3), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem7), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem11), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem4, True) _
            })
            Me.msiFile.Name = "msiFile"
            ' 
            ' msiEdit
            ' 
            Me.msiEdit.Caption = "&Edit"
            Me.msiEdit.Id = 44
            Me.msiEdit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiUndo, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRedo), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCut, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCopy), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPaste), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem5), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem6, True) _
            })
            Me.msiEdit.Name = "msiEdit"
            ' 
            ' msiTabButtons
            ' 
            Me.msiTabButtons.Caption = "&View"
            Me.msiTabButtons.Id = 45
            Me.msiTabButtons.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barReportTabButtonsListItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem2, True) _
            })
            Me.msiTabButtons.Name = "msiTabButtons"
            ' 
            ' barReportTabButtonsListItem1
            ' 
            Me.barReportTabButtonsListItem1.Caption = "Tab Buttons"
            Me.barReportTabButtonsListItem1.Id = 46
            Me.barReportTabButtonsListItem1.Name = "barReportTabButtonsListItem1"
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "&Toolbars"
            Me.barSubItem1.Id = 47
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.xrBarToolbarsListItem1)})
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' xrBarToolbarsListItem1
            ' 
            Me.xrBarToolbarsListItem1.Caption = "&Toolbars"
            Me.xrBarToolbarsListItem1.Id = 48
            Me.xrBarToolbarsListItem1.Name = "xrBarToolbarsListItem1"
            ' 
            ' barSubItem2
            ' 
            Me.barSubItem2.Caption = "&Windows"
            Me.barSubItem2.Id = 49
            Me.barSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barDockPanelsListItem1)})
            Me.barSubItem2.Name = "barSubItem2"
            ' 
            ' barDockPanelsListItem1
            ' 
            Me.barDockPanelsListItem1.Caption = "&Windows"
            Me.barDockPanelsListItem1.Id = 50
            Me.barDockPanelsListItem1.Name = "barDockPanelsListItem1"
            Me.barDockPanelsListItem1.ShowCustomizationItem = False
            Me.barDockPanelsListItem1.ShowDockPanels = True
            Me.barDockPanelsListItem1.ShowToolbars = False
            ' 
            ' msiFormat
            ' 
            Me.msiFormat.Caption = "Fo&rmat"
            Me.msiFormat.Id = 51
            Me.msiFormat.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiForeColor), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiBackColor), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiFont, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiJustify), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiAlign, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiSameSize), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiHorizontalSpacing, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiVerticalSpacing), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bsiCenter, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiOrder, True) _
            })
            Me.msiFormat.Name = "msiFormat"
            ' 
            ' msiFont
            ' 
            Me.msiFont.Caption = "&Font"
            Me.msiFont.Id = 52
            Me.msiFont.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFontBold, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFontItalic), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFontUnderline) _
            })
            Me.msiFont.Name = "msiFont"
            ' 
            ' msiJustify
            ' 
            Me.msiJustify.Caption = "&Justify"
            Me.msiJustify.Id = 53
            Me.msiJustify.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJustifyLeft, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJustifyCenter), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJustifyRight), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiJustifyJustify) _
            })
            Me.msiJustify.Name = "msiJustify"
            ' 
            ' msiAlign
            ' 
            Me.msiAlign.Caption = "&Align"
            Me.msiAlign.Id = 54
            Me.msiAlign.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignLeft, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignVerticalCenters), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignRight), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignTop, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignHorizontalCenters), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignBottom), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAlignToGrid, True) _
            })
            Me.msiAlign.Name = "msiAlign"
            ' 
            ' msiSameSize
            ' 
            Me.msiSameSize.Caption = "&Make Same Size"
            Me.msiSameSize.Id = 55
            Me.msiSameSize.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSizeToControlWidth, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSizeToGrid), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSizeToControlHeight), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSizeToControl) _
            })
            Me.msiSameSize.Name = "msiSameSize"
            ' 
            ' msiHorizontalSpacing
            ' 
            Me.msiHorizontalSpacing.Caption = "&Horizontal Spacing"
            Me.msiHorizontalSpacing.Id = 56
            Me.msiHorizontalSpacing.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHorizSpaceMakeEqual, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHorizSpaceIncrease), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHorizSpaceDecrease), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHorizSpaceConcatenate) _
            })
            Me.msiHorizontalSpacing.Name = "msiHorizontalSpacing"
            ' 
            ' msiVerticalSpacing
            ' 
            Me.msiVerticalSpacing.Caption = "&Vertical Spacing"
            Me.msiVerticalSpacing.Id = 57
            Me.msiVerticalSpacing.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVertSpaceMakeEqual, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVertSpaceIncrease), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVertSpaceDecrease), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVertSpaceConcatenate) _
            })
            Me.msiVerticalSpacing.Name = "msiVerticalSpacing"
            ' 
            ' bsiCenter
            ' 
            Me.bsiCenter.Caption = "&Center in Form"
            Me.bsiCenter.Id = 58
            Me.bsiCenter.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCenterHorizontally, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCenterVertically) _
            })
            Me.bsiCenter.Name = "bsiCenter"
            ' 
            ' msiOrder
            ' 
            Me.msiOrder.Caption = "&Order"
            Me.msiOrder.Id = 59
            Me.msiOrder.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiBringToFront, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSendToBack) _
            })
            Me.msiOrder.Name = "msiOrder"
            ' 
            ' commandBarItem2
            ' 
            Me.commandBarItem2.Caption = "New via &Wizard..."
            Me.commandBarItem2.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.NewReportWizard
            Me.commandBarItem2.Hint = "Create a new report using the Wizard"
            Me.commandBarItem2.Id = 60
            Me.commandBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W))
            Me.commandBarItem2.Name = "commandBarItem2"
            ' 
            ' commandBarItem3
            ' 
            Me.commandBarItem3.Caption = "Save &As..."
            Me.commandBarItem3.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SaveFileAs
            Me.commandBarItem3.Enabled = False
            Me.commandBarItem3.Hint = "Save the report with a new name"
            Me.commandBarItem3.Id = 61
            Me.commandBarItem3.Name = "commandBarItem3"
            ' 
            ' commandBarItem4
            ' 
            Me.commandBarItem4.Caption = "E&xit"
            Me.commandBarItem4.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Exit
            Me.commandBarItem4.Hint = "Close the designer"
            Me.commandBarItem4.Id = 62
            Me.commandBarItem4.Name = "commandBarItem4"
            ' 
            ' commandBarItem5
            ' 
            Me.commandBarItem5.Caption = "&Delete"
            Me.commandBarItem5.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Delete
            Me.commandBarItem5.Enabled = False
            Me.commandBarItem5.Hint = "Delete the control"
            Me.commandBarItem5.Id = 63
            Me.commandBarItem5.Name = "commandBarItem5"
            ' 
            ' commandBarItem6
            ' 
            Me.commandBarItem6.Caption = "Select &All"
            Me.commandBarItem6.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SelectAll
            Me.commandBarItem6.Enabled = False
            Me.commandBarItem6.Hint = "Select all the controls in the document"
            Me.commandBarItem6.Id = 64
            Me.commandBarItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A))
            Me.commandBarItem6.Name = "commandBarItem6"
            ' 
            ' commandBarItem7
            ' 
            Me.commandBarItem7.Caption = "Save A&ll"
            Me.commandBarItem7.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SaveAll
            Me.commandBarItem7.Enabled = False
            Me.commandBarItem7.Hint = "Save all reports"
            Me.commandBarItem7.Id = 65
            Me.commandBarItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
            Me.commandBarItem7.Name = "commandBarItem7"
            ' 
            ' msiWindow
            ' 
            Me.msiWindow.Caption = "&Window"
            Me.msiWindow.Id = 66
            Me.msiWindow.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiWindowInterface, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem8), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem9), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem10), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.msiWindows, True) _
            })
            Me.msiWindow.Name = "msiWindow"
            ' 
            ' msiWindowInterface
            ' 
            Me.msiWindowInterface.BindableChecked = True
            Me.msiWindowInterface.Caption = "&Tabbed Interface"
            Me.msiWindowInterface.Checked = True
            Me.msiWindowInterface.CheckedCommand = DevExpress.XtraReports.UserDesigner.ReportCommand.ShowTabbedInterface
            Me.msiWindowInterface.Hint = "Switch between tabbed and window MDI layout modes"
            Me.msiWindowInterface.Id = 67
            Me.msiWindowInterface.Name = "msiWindowInterface"
            Me.msiWindowInterface.UncheckedCommand = DevExpress.XtraReports.UserDesigner.ReportCommand.ShowWindowInterface
            ' 
            ' commandBarItem8
            ' 
            Me.commandBarItem8.Caption = "&Cascade"
            Me.commandBarItem8.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.MdiCascade
            Me.commandBarItem8.Enabled = False
            Me.commandBarItem8.Hint = "Arrange all open documents cascaded, so that they overlap each other"
            Me.commandBarItem8.Id = 68
            Me.commandBarItem8.Name = "commandBarItem8"
            ' 
            ' commandBarItem9
            ' 
            Me.commandBarItem9.Caption = "Tile &Horizontal"
            Me.commandBarItem9.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.MdiTileHorizontal
            Me.commandBarItem9.Enabled = False
            Me.commandBarItem9.Hint = "Arrange all open documents from top to bottom"
            Me.commandBarItem9.Id = 69
            Me.commandBarItem9.Name = "commandBarItem9"
            ' 
            ' commandBarItem10
            ' 
            Me.commandBarItem10.Caption = "Tile &Vertical"
            Me.commandBarItem10.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.MdiTileVertical
            Me.commandBarItem10.Enabled = False
            Me.commandBarItem10.Hint = "Arrange all open documents from left to right"
            Me.commandBarItem10.Id = 70
            Me.commandBarItem10.Name = "commandBarItem10"
            ' 
            ' msiWindows
            ' 
            Me.msiWindows.Caption = "Windows"
            Me.msiWindows.Id = 71
            Me.msiWindows.Name = "msiWindows"
            ' 
            ' commandBarItem11
            ' 
            Me.commandBarItem11.Caption = "&Close"
            Me.commandBarItem11.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Close
            Me.commandBarItem11.Enabled = False
            Me.commandBarItem11.Hint = "Close the report"
            Me.commandBarItem11.Id = 72
            Me.commandBarItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4))
            Me.commandBarItem11.Name = "commandBarItem11"
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Zoom Toolbar"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 2
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiZoomOut), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiZoom), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiZoomIn) _
            })
            Me.bar1.Text = "Zoom Toolbar"
            ' 
            ' bbiZoomOut
            ' 
            Me.bbiZoomOut.Caption = "Zoom Out"
            Me.bbiZoomOut.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.ZoomOut
            Me.bbiZoomOut.Enabled = False
            Me.bbiZoomOut.Hint = "Zoom out the design surface"
            Me.bbiZoomOut.Id = 73
            Me.bbiZoomOut.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Subtract))
            Me.bbiZoomOut.Name = "bbiZoomOut"
            ' 
            ' bbiZoom
            ' 
            Me.bbiZoom.Caption = "Zoom"
            Me.bbiZoom.Edit = Me.designRepositoryItemComboBox2
            Me.bbiZoom.EditWidth = 70
            Me.bbiZoom.Enabled = False
            Me.bbiZoom.Hint = "Select or input the zoom factor"
            Me.bbiZoom.Id = 74
            Me.bbiZoom.Name = "bbiZoom"
            ' 
            ' designRepositoryItemComboBox2
            ' 
            Me.designRepositoryItemComboBox2.AutoComplete = False
            Me.designRepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.designRepositoryItemComboBox2.Name = "designRepositoryItemComboBox2"
            ' 
            ' bbiZoomIn
            ' 
            Me.bbiZoomIn.Caption = "Zoom In"
            Me.bbiZoomIn.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.ZoomIn
            Me.bbiZoomIn.Enabled = False
            Me.bbiZoomIn.Hint = "Zoom in the design surface"
            Me.bbiZoomIn.Id = 75
            Me.bbiZoomIn.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Add))
            Me.bbiZoomIn.Name = "bbiZoomIn"
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Toolbox"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Left
            Me.bar2.OptionsBar.AllowQuickCustomization = False
            Me.bar2.Text = "Standard Controls"
            ' 
            ' xrDesignDockManager1
            ' 
            Me.xrDesignDockManager1.Form = Me
            Me.xrDesignDockManager1.ImageStream = (DirectCast(resources.GetObject("xrDesignDockManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.xrDesignDockManager1.MenuManager = Me.xrDesignBarManager1
            Me.xrDesignDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1, Me.panelContainer3})
            Me.xrDesignDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' fieldListDockPanel1
            ' 
            Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
            Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.fieldListDockPanel1.ID = New System.Guid("faf69838-a93f-4114-83e8-d0d09cc5ce95")
            Me.fieldListDockPanel1.Location = New System.Drawing.Point(5, 23)
            Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
            Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.fieldListDockPanel1.Size = New System.Drawing.Size(241, 140)
            Me.fieldListDockPanel1.Text = "Field List"
            ' 
            ' fieldListDockPanel1_Container
            ' 
            Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(0, 0)
            Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
            Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(241, 140)
            Me.fieldListDockPanel1_Container.TabIndex = 0
            ' 
            ' propertyGridDockPanel1
            ' 
            Me.propertyGridDockPanel1.Controls.Add(Me.propertyGridDockPanel1_Container)
            Me.propertyGridDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.propertyGridDockPanel1.ID = New System.Guid("b38d12c3-cd06-4dec-b93d-63a0088e495a")
            Me.propertyGridDockPanel1.Location = New System.Drawing.Point(0, 195)
            Me.propertyGridDockPanel1.Name = "propertyGridDockPanel1"
            Me.propertyGridDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.propertyGridDockPanel1.Size = New System.Drawing.Size(250, 195)
            Me.propertyGridDockPanel1.Text = "Property Grid"
            ' 
            ' propertyGridDockPanel1_Container
            ' 
            Me.propertyGridDockPanel1_Container.Location = New System.Drawing.Point(5, 23)
            Me.propertyGridDockPanel1_Container.Name = "propertyGridDockPanel1_Container"
            Me.propertyGridDockPanel1_Container.Size = New System.Drawing.Size(241, 168)
            Me.propertyGridDockPanel1_Container.TabIndex = 0
            ' 
            ' reportExplorerDockPanel1
            ' 
            Me.reportExplorerDockPanel1.Controls.Add(Me.reportExplorerDockPanel1_Container)
            Me.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.reportExplorerDockPanel1.ID = New System.Guid("fb3ec6cc-3b9b-4b9c-91cf-cff78c1edbf1")
            Me.reportExplorerDockPanel1.Location = New System.Drawing.Point(5, 23)
            Me.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1"
            Me.reportExplorerDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.reportExplorerDockPanel1.Size = New System.Drawing.Size(241, 140)
            Me.reportExplorerDockPanel1.Text = "Report Explorer"
            ' 
            ' reportExplorerDockPanel1_Container
            ' 
            Me.reportExplorerDockPanel1_Container.Location = New System.Drawing.Point(0, 0)
            Me.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container"
            Me.reportExplorerDockPanel1_Container.Size = New System.Drawing.Size(241, 140)
            Me.reportExplorerDockPanel1_Container.TabIndex = 0
            ' 
            ' groupAndSortDockPanel1
            ' 
            Me.groupAndSortDockPanel1.Controls.Add(Me.groupAndSortDockPanel1_Container)
            Me.groupAndSortDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.groupAndSortDockPanel1.ID = New System.Guid("4bab159e-c495-4d67-87dc-f4e895da443e")
            Me.groupAndSortDockPanel1.Location = New System.Drawing.Point(4, 24)
            Me.groupAndSortDockPanel1.Name = "groupAndSortDockPanel1"
            Me.groupAndSortDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.groupAndSortDockPanel1.Size = New System.Drawing.Size(665, 145)
            Me.groupAndSortDockPanel1.Text = "Group and Sort"
            ' 
            ' groupAndSortDockPanel1_Container
            ' 
            Me.groupAndSortDockPanel1_Container.Location = New System.Drawing.Point(0, 0)
            Me.groupAndSortDockPanel1_Container.Name = "groupAndSortDockPanel1_Container"
            Me.groupAndSortDockPanel1_Container.Size = New System.Drawing.Size(665, 145)
            Me.groupAndSortDockPanel1_Container.TabIndex = 0
            ' 
            ' errorListDockPanel1
            ' 
            Me.errorListDockPanel1.Controls.Add(Me.errorListDockPanel1_Container)
            Me.errorListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.errorListDockPanel1.ID = New System.Guid("5a9a01fd-6e95-4e81-a8c4-ac63153d7488")
            Me.errorListDockPanel1.Location = New System.Drawing.Point(4, 24)
            Me.errorListDockPanel1.Name = "errorListDockPanel1"
            Me.errorListDockPanel1.OriginalSize = New System.Drawing.Size(200, 190)
            Me.errorListDockPanel1.Size = New System.Drawing.Size(665, 145)
            Me.errorListDockPanel1.Text = "Scripts Errors"
            ' 
            ' errorListDockPanel1_Container
            ' 
            Me.errorListDockPanel1_Container.Location = New System.Drawing.Point(0, 0)
            Me.errorListDockPanel1_Container.Name = "errorListDockPanel1_Container"
            Me.errorListDockPanel1_Container.Size = New System.Drawing.Size(665, 145)
            Me.errorListDockPanel1_Container.TabIndex = 0
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.Controls.Add(Me.panelContainer2)
            Me.panelContainer1.Controls.Add(Me.propertyGridDockPanel1)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.ID = New System.Guid("936f6a9b-6a79-4bc1-8038-436c11bff744")
            Me.panelContainer1.Location = New System.Drawing.Point(702, 84)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(250, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(250, 390)
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' panelContainer2
            ' 
            Me.panelContainer2.ActiveChild = Me.fieldListDockPanel1
            Me.panelContainer2.Controls.Add(Me.reportExplorerDockPanel1)
            Me.panelContainer2.Controls.Add(Me.fieldListDockPanel1)
            Me.panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.panelContainer2.ID = New System.Guid("e920715b-ae70-41db-b9f8-391d0ff9fcf4")
            Me.panelContainer2.Location = New System.Drawing.Point(0, 0)
            Me.panelContainer2.Name = "panelContainer2"
            Me.panelContainer2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer2.Size = New System.Drawing.Size(250, 195)
            Me.panelContainer2.Tabbed = True
            Me.panelContainer2.Text = "panelContainer2"
            ' 
            ' panelContainer3
            ' 
            Me.panelContainer3.ActiveChild = Me.errorListDockPanel1
            Me.panelContainer3.Controls.Add(Me.groupAndSortDockPanel1)
            Me.panelContainer3.Controls.Add(Me.errorListDockPanel1)
            Me.panelContainer3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.panelContainer3.ID = New System.Guid("ab66dd98-cdf7-4d69-8357-3f853ed18a53")
            Me.panelContainer3.Location = New System.Drawing.Point(29, 274)
            Me.panelContainer3.Name = "panelContainer3"
            Me.panelContainer3.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer3.Size = New System.Drawing.Size(673, 200)
            Me.panelContainer3.Tabbed = True
            Me.panelContainer3.Text = "panelContainer3"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(952, 499)
            Me.Controls.Add(Me.panelContainer3)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.xrDesignBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.recentlyUsedItemsComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.designRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.designRepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrDesignDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.fieldListDockPanel1.ResumeLayout(False)
            Me.propertyGridDockPanel1.ResumeLayout(False)
            Me.reportExplorerDockPanel1.ResumeLayout(False)
            Me.groupAndSortDockPanel1.ResumeLayout(False)
            Me.errorListDockPanel1.ResumeLayout(False)
            Me.panelContainer1.ResumeLayout(False)
            Me.panelContainer2.ResumeLayout(False)
            Me.panelContainer3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private reportDesigner1 As DevExpress.XtraReports.UserDesigner.XRDesignMdiController
        Private xrDesignBarManager1 As DevExpress.XtraReports.UserDesigner.XRDesignBarManager
        Private bar2 As DevExpress.XtraBars.Bar
        Private designBar1 As DevExpress.XtraReports.UserDesigner.DesignBar
        Private msiFile As DevExpress.XtraBars.BarSubItem
        Private commandBarItem1 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private commandBarItem2 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiOpenFile As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiSaveFile As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private commandBarItem3 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private commandBarItem7 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private commandBarItem11 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private commandBarItem4 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiEdit As DevExpress.XtraBars.BarSubItem
        Private bbiUndo As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiRedo As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiCut As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiCopy As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiPaste As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private commandBarItem5 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private commandBarItem6 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiTabButtons As DevExpress.XtraBars.BarSubItem
        Private barReportTabButtonsListItem1 As DevExpress.XtraReports.UserDesigner.BarReportTabButtonsListItem
        Private barSubItem1 As DevExpress.XtraBars.BarSubItem
        Private xrBarToolbarsListItem1 As DevExpress.XtraReports.UserDesigner.XRBarToolbarsListItem
        Private barSubItem2 As DevExpress.XtraBars.BarSubItem
        Private barDockPanelsListItem1 As DevExpress.XtraReports.UserDesigner.BarDockPanelsListItem
        Private msiFormat As DevExpress.XtraBars.BarSubItem
        Private bbiForeColor As DevExpress.XtraReports.UserDesigner.CommandColorBarItem
        Private bbiBackColor As DevExpress.XtraReports.UserDesigner.CommandColorBarItem
        Private msiFont As DevExpress.XtraBars.BarSubItem
        Private bbiFontBold As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiFontItalic As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiFontUnderline As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiJustify As DevExpress.XtraBars.BarSubItem
        Private bbiJustifyLeft As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiJustifyCenter As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiJustifyRight As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiJustifyJustify As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiAlign As DevExpress.XtraBars.BarSubItem
        Private bbiAlignLeft As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiAlignVerticalCenters As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiAlignRight As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiAlignTop As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiAlignHorizontalCenters As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiAlignBottom As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiAlignToGrid As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiSameSize As DevExpress.XtraBars.BarSubItem
        Private bbiSizeToControlWidth As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiSizeToGrid As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiSizeToControlHeight As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiSizeToControl As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiHorizontalSpacing As DevExpress.XtraBars.BarSubItem
        Private bbiHorizSpaceMakeEqual As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiHorizSpaceIncrease As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiHorizSpaceDecrease As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiHorizSpaceConcatenate As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiVerticalSpacing As DevExpress.XtraBars.BarSubItem
        Private bbiVertSpaceMakeEqual As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiVertSpaceIncrease As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiVertSpaceDecrease As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiVertSpaceConcatenate As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bsiCenter As DevExpress.XtraBars.BarSubItem
        Private bbiCenterHorizontally As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiCenterVertically As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiOrder As DevExpress.XtraBars.BarSubItem
        Private bbiBringToFront As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiSendToBack As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiWindow As DevExpress.XtraBars.BarSubItem
        Private msiWindowInterface As DevExpress.XtraReports.UserDesigner.CommandBarCheckItem
        Private commandBarItem8 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private commandBarItem9 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private commandBarItem10 As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private msiWindows As DevExpress.XtraBars.BarMdiChildrenListItem
        Private designBar2 As DevExpress.XtraReports.UserDesigner.DesignBar
        Private designBar3 As DevExpress.XtraReports.UserDesigner.DesignBar
        Private beiFontName As DevExpress.XtraBars.BarEditItem
        Private recentlyUsedItemsComboBox1 As DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox
        Private beiFontSize As DevExpress.XtraBars.BarEditItem
        Private designRepositoryItemComboBox1 As DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox
        Private designBar4 As DevExpress.XtraReports.UserDesigner.DesignBar
        Private designBar5 As DevExpress.XtraReports.UserDesigner.DesignBar
        Private bsiHint As DevExpress.XtraBars.BarStaticItem
        Private bar1 As DevExpress.XtraBars.Bar
        Private bbiZoomOut As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private bbiZoom As DevExpress.XtraReports.UserDesigner.XRZoomBarEditItem
        Private designRepositoryItemComboBox2 As DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox
        Private bbiZoomIn As DevExpress.XtraReports.UserDesigner.CommandBarItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private xrDesignDockManager1 As DevExpress.XtraReports.UserDesigner.XRDesignDockManager
        Private panelContainer3 As DevExpress.XtraBars.Docking.DockPanel
        Private errorListDockPanel1 As DevExpress.XtraReports.UserDesigner.ErrorListDockPanel
        Private errorListDockPanel1_Container As DevExpress.XtraReports.UserDesigner.DesignControlContainer
        Private groupAndSortDockPanel1 As DevExpress.XtraReports.UserDesigner.GroupAndSortDockPanel
        Private groupAndSortDockPanel1_Container As DevExpress.XtraReports.UserDesigner.DesignControlContainer
        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
        Private panelContainer2 As DevExpress.XtraBars.Docking.DockPanel
        Private fieldListDockPanel1 As DevExpress.XtraReports.UserDesigner.FieldListDockPanel
        Private fieldListDockPanel1_Container As DevExpress.XtraReports.UserDesigner.DesignControlContainer
        Private reportExplorerDockPanel1 As DevExpress.XtraReports.UserDesigner.ReportExplorerDockPanel
        Private reportExplorerDockPanel1_Container As DevExpress.XtraReports.UserDesigner.DesignControlContainer
        Private propertyGridDockPanel1 As DevExpress.XtraReports.UserDesigner.PropertyGridDockPanel
        Private propertyGridDockPanel1_Container As DevExpress.XtraReports.UserDesigner.DesignControlContainer
    End Class
End Namespace

