﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblName = New System.Windows.Forms.Label()
        Me.TimerTimeAndDate = New System.Windows.Forms.Timer(Me.components)
        Me.ExplorerBar1 = New DevComponents.DotNetBar.ExplorerBar()
        Me.ExplorerBarGroupItemSchedule = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ButtonItemViewAssignedSched = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonAssignSched = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemAddSchedule = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemModifySubjects = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonRemoveSched = New DevComponents.DotNetBar.ButtonItem()
        Me.ExplorerBarGroupItemSubjectManagement = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ButtonItemViewSubjects = New DevComponents.DotNetBar.ButtonItem()
        Me.ExplorerBarGroupItemRoomList = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ExplorerBarGroupItemEmployee = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ButtonAddAccount = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemEditOrDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.ExplorerBarGroupItemPrinting = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ButtonPrintAssignedSched = New DevComponents.DotNetBar.ButtonItem()
        Me.ExplorerBarGroupItem2 = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ButtonItemSchoolYearSemester = New DevComponents.DotNetBar.ButtonItem()
        Me.ExplorerBarGroupItemLogout = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.GroupBoxContainer = New System.Windows.Forms.GroupBox()
        Me.lblNavigate = New System.Windows.Forms.Label()
        Me.lblSystemName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_SchoolYear = New System.Windows.Forms.Label()
        Me.lbl_Semester = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ControlViewSubjects1 = New SchedulingSystem.ControlViewSubjects()
        Me.ControlViewAssignedSchedule1 = New SchedulingSystem.ControlViewAssignedSchedule()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxContainer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.Green
        Me.lblName.Location = New System.Drawing.Point(9, 12)
        Me.lblName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(184, 22)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Welcome!, Group 3"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExplorerBar1
        '
        Me.ExplorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.ExplorerBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExplorerBar1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ExplorerBar1.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ExplorerBar1.BackStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.ExplorerBar1.BackStyle.BackColorGradientAngle = 90
        Me.ExplorerBar1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBar1.GroupImages = Nothing
        Me.ExplorerBar1.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ExplorerBarGroupItemSchedule, Me.ExplorerBarGroupItemSubjectManagement, Me.ExplorerBarGroupItemRoomList, Me.ExplorerBarGroupItemEmployee, Me.ExplorerBarGroupItemPrinting, Me.ExplorerBarGroupItem2, Me.ExplorerBarGroupItemLogout})
        Me.ExplorerBar1.Images = Nothing
        Me.ExplorerBar1.Location = New System.Drawing.Point(3, 87)
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.Size = New System.Drawing.Size(266, 504)
        Me.ExplorerBar1.TabIndex = 9
        Me.ExplorerBar1.Text = "ExplorerBar1"
        Me.ExplorerBar1.ThemeAware = True
        '
        'ExplorerBarGroupItemSchedule
        '
        '
        '
        '
        Me.ExplorerBarGroupItemSchedule.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItemSchedule.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemSchedule.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItemSchedule.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.ExpandForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.Image = Global.SchedulingSystem.My.Resources.Resources.clock1
        Me.ExplorerBarGroupItemSchedule.Name = "ExplorerBarGroupItemSchedule"
        Me.ExplorerBarGroupItemSchedule.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItemViewAssignedSched, Me.ButtonAssignSched, Me.ButtonItemAddSchedule, Me.ButtonItemModifySubjects, Me.ButtonRemoveSched})
        Me.ExplorerBarGroupItemSchedule.Text = "Schedule Management"
        '
        '
        '
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItemSchedule.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemSchedule.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemSchedule.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemSchedule.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSchedule.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSchedule.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ButtonItemViewAssignedSched
        '
        Me.ButtonItemViewAssignedSched.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemViewAssignedSched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonItemViewAssignedSched.HotFontUnderline = True
        Me.ButtonItemViewAssignedSched.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonItemViewAssignedSched.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItemViewAssignedSched.Name = "ButtonItemViewAssignedSched"
        Me.ButtonItemViewAssignedSched.Text = "View Assigned Schedules"
        '
        'ButtonAssignSched
        '
        Me.ButtonAssignSched.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonAssignSched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonAssignSched.HotFontUnderline = True
        Me.ButtonAssignSched.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonAssignSched.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonAssignSched.Name = "ButtonAssignSched"
        Me.ButtonAssignSched.Text = "Assign Schedule"
        '
        'ButtonItemAddSchedule
        '
        Me.ButtonItemAddSchedule.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemAddSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonItemAddSchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonItemAddSchedule.HotFontUnderline = True
        Me.ButtonItemAddSchedule.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonItemAddSchedule.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItemAddSchedule.Name = "ButtonItemAddSchedule"
        Me.ButtonItemAddSchedule.Text = "Add Schedule"
        '
        'ButtonItemModifySubjects
        '
        Me.ButtonItemModifySubjects.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemModifySubjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonItemModifySubjects.HotFontUnderline = True
        Me.ButtonItemModifySubjects.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonItemModifySubjects.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItemModifySubjects.Name = "ButtonItemModifySubjects"
        Me.ButtonItemModifySubjects.Text = "Modify Schedule"
        '
        'ButtonRemoveSched
        '
        Me.ButtonRemoveSched.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonRemoveSched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonRemoveSched.HotFontUnderline = True
        Me.ButtonRemoveSched.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonRemoveSched.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonRemoveSched.Name = "ButtonRemoveSched"
        Me.ButtonRemoveSched.Text = "Remove Schedule"
        '
        'ExplorerBarGroupItemSubjectManagement
        '
        '
        '
        '
        Me.ExplorerBarGroupItemSubjectManagement.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemSubjectManagement.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemSubjectManagement.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItemSubjectManagement.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemSubjectManagement.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemSubjectManagement.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItemSubjectManagement.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemSubjectManagement.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItemSubjectManagement.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemSubjectManagement.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItemSubjectManagement.Image = Global.SchedulingSystem.My.Resources.Resources.subject_icon
        Me.ExplorerBarGroupItemSubjectManagement.Name = "ExplorerBarGroupItemSubjectManagement"
        Me.ExplorerBarGroupItemSubjectManagement.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItemSubjectManagement.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItemViewSubjects})
        Me.ExplorerBarGroupItemSubjectManagement.Text = "Subject Management"
        '
        '
        '
        Me.ExplorerBarGroupItemSubjectManagement.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemSubjectManagement.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemSubjectManagement.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemSubjectManagement.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemSubjectManagement.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSubjectManagement.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSubjectManagement.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItemSubjectManagement.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemSubjectManagement.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemSubjectManagement.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemSubjectManagement.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemSubjectManagement.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSubjectManagement.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSubjectManagement.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ButtonItemViewSubjects
        '
        Me.ButtonItemViewSubjects.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemViewSubjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonItemViewSubjects.HotFontUnderline = True
        Me.ButtonItemViewSubjects.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonItemViewSubjects.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItemViewSubjects.Name = "ButtonItemViewSubjects"
        Me.ButtonItemViewSubjects.Text = "View Subjects"
        '
        'ExplorerBarGroupItemRoomList
        '
        '
        '
        '
        Me.ExplorerBarGroupItemRoomList.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemRoomList.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemRoomList.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItemRoomList.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemRoomList.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemRoomList.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItemRoomList.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemRoomList.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItemRoomList.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemRoomList.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItemRoomList.ExpandButtonVisible = False
        Me.ExplorerBarGroupItemRoomList.HeaderExpands = False
        Me.ExplorerBarGroupItemRoomList.Image = Global.SchedulingSystem.My.Resources.Resources.room_icon_small
        Me.ExplorerBarGroupItemRoomList.Name = "ExplorerBarGroupItemRoomList"
        Me.ExplorerBarGroupItemRoomList.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItemRoomList.Text = "Room Management"
        '
        '
        '
        Me.ExplorerBarGroupItemRoomList.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemRoomList.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemRoomList.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemRoomList.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemRoomList.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemRoomList.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemRoomList.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItemRoomList.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemRoomList.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemRoomList.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemRoomList.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemRoomList.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemRoomList.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemRoomList.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ExplorerBarGroupItemEmployee
        '
        '
        '
        '
        Me.ExplorerBarGroupItemEmployee.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemEmployee.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemEmployee.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItemEmployee.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemEmployee.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemEmployee.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItemEmployee.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemEmployee.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItemEmployee.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemEmployee.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItemEmployee.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExplorerBarGroupItemEmployee.ExpandForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ExplorerBarGroupItemEmployee.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExplorerBarGroupItemEmployee.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerBarGroupItemEmployee.Image = Global.SchedulingSystem.My.Resources.Resources.build9600
        Me.ExplorerBarGroupItemEmployee.Name = "ExplorerBarGroupItemEmployee"
        Me.ExplorerBarGroupItemEmployee.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonAddAccount, Me.ButtonItemEditOrDelete})
        Me.ExplorerBarGroupItemEmployee.Text = "Accounts"
        '
        '
        '
        Me.ExplorerBarGroupItemEmployee.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemEmployee.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemEmployee.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemEmployee.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemEmployee.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemEmployee.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemEmployee.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItemEmployee.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemEmployee.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemEmployee.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemEmployee.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemEmployee.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemEmployee.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemEmployee.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ButtonAddAccount
        '
        Me.ButtonAddAccount.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonAddAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonAddAccount.HotFontUnderline = True
        Me.ButtonAddAccount.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonAddAccount.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonAddAccount.Name = "ButtonAddAccount"
        Me.ButtonAddAccount.Text = "Add Account"
        '
        'ButtonItemEditOrDelete
        '
        Me.ButtonItemEditOrDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemEditOrDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonItemEditOrDelete.HotFontUnderline = True
        Me.ButtonItemEditOrDelete.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonItemEditOrDelete.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItemEditOrDelete.Name = "ButtonItemEditOrDelete"
        Me.ButtonItemEditOrDelete.Text = "Edit/Delete"
        '
        'ExplorerBarGroupItemPrinting
        '
        '
        '
        '
        Me.ExplorerBarGroupItemPrinting.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItemPrinting.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemPrinting.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItemPrinting.Image = Global.SchedulingSystem.My.Resources.Resources.Printer_small
        Me.ExplorerBarGroupItemPrinting.Name = "ExplorerBarGroupItemPrinting"
        Me.ExplorerBarGroupItemPrinting.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItemPrinting.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonPrintAssignedSched})
        Me.ExplorerBarGroupItemPrinting.Text = "Printing"
        '
        '
        '
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItemPrinting.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemPrinting.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemPrinting.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemPrinting.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemPrinting.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemPrinting.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemPrinting.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ButtonPrintAssignedSched
        '
        Me.ButtonPrintAssignedSched.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonPrintAssignedSched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonPrintAssignedSched.HotFontUnderline = True
        Me.ButtonPrintAssignedSched.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonPrintAssignedSched.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonPrintAssignedSched.Name = "ButtonPrintAssignedSched"
        Me.ButtonPrintAssignedSched.Text = "Print Assigned Schedules"
        '
        'ExplorerBarGroupItem2
        '
        '
        '
        '
        Me.ExplorerBarGroupItem2.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItem2.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem2.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItem2.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem2.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem2.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItem2.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem2.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItem2.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItem2.Image = Global.SchedulingSystem.My.Resources.Resources.gear
        Me.ExplorerBarGroupItem2.Name = "ExplorerBarGroupItem2"
        Me.ExplorerBarGroupItem2.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItemSchoolYearSemester})
        Me.ExplorerBarGroupItem2.Text = "Settings"
        '
        '
        '
        Me.ExplorerBarGroupItem2.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem2.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItem2.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem2.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem2.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem2.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem2.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItem2.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem2.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItem2.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem2.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem2.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem2.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ButtonItemSchoolYearSemester
        '
        Me.ButtonItemSchoolYearSemester.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemSchoolYearSemester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonItemSchoolYearSemester.HotFontUnderline = True
        Me.ButtonItemSchoolYearSemester.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonItemSchoolYearSemester.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItemSchoolYearSemester.Name = "ButtonItemSchoolYearSemester"
        Me.ButtonItemSchoolYearSemester.Text = "SchoolYear and Semester"
        '
        'ExplorerBarGroupItemLogout
        '
        '
        '
        '
        Me.ExplorerBarGroupItemLogout.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemLogout.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemLogout.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItemLogout.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemLogout.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemLogout.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItemLogout.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemLogout.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItemLogout.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemLogout.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItemLogout.ExpandButtonVisible = False
        Me.ExplorerBarGroupItemLogout.HeaderExpands = False
        Me.ExplorerBarGroupItemLogout.Image = Global.SchedulingSystem.My.Resources.Resources.logout
        Me.ExplorerBarGroupItemLogout.Name = "ExplorerBarGroupItemLogout"
        Me.ExplorerBarGroupItemLogout.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItemLogout.Text = "Logout"
        '
        '
        '
        Me.ExplorerBarGroupItemLogout.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemLogout.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemLogout.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemLogout.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemLogout.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemLogout.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemLogout.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItemLogout.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemLogout.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemLogout.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemLogout.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemLogout.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemLogout.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemLogout.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'GroupBoxContainer
        '
        Me.GroupBoxContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxContainer.Controls.Add(Me.lblNavigate)
        Me.GroupBoxContainer.Controls.Add(Me.ControlViewSubjects1)
        Me.GroupBoxContainer.Controls.Add(Me.ControlViewAssignedSchedule1)
        Me.GroupBoxContainer.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.GroupBoxContainer.Location = New System.Drawing.Point(274, 87)
        Me.GroupBoxContainer.Name = "GroupBoxContainer"
        Me.GroupBoxContainer.Size = New System.Drawing.Size(986, 491)
        Me.GroupBoxContainer.TabIndex = 12
        Me.GroupBoxContainer.TabStop = False
        Me.GroupBoxContainer.Text = "Assigned Schedules"
        '
        'lblNavigate
        '
        Me.lblNavigate.AutoSize = True
        Me.lblNavigate.Location = New System.Drawing.Point(84, 175)
        Me.lblNavigate.Name = "lblNavigate"
        Me.lblNavigate.Size = New System.Drawing.Size(302, 23)
        Me.lblNavigate.TabIndex = 2
        Me.lblNavigate.Text = "click an item to the right to start."
        '
        'lblSystemName
        '
        Me.lblSystemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSystemName.AutoSize = True
        Me.lblSystemName.Font = New System.Drawing.Font("Arial Black", 9.5!)
        Me.lblSystemName.Location = New System.Drawing.Point(600, 3)
        Me.lblSystemName.Name = "lblSystemName"
        Me.lblSystemName.Size = New System.Drawing.Size(242, 90)
        Me.lblSystemName.TabIndex = 13
        Me.lblSystemName.Text = "Centro Escolar University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Computer Educaton Department" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Faculty Workload" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sche" & _
            "duling System"
        Me.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SchedulingSystem.My.Resources.Resources.CEU_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(501, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lbl_SchoolYear
        '
        Me.lbl_SchoolYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SchoolYear.Location = New System.Drawing.Point(1169, 23)
        Me.lbl_SchoolYear.Name = "lbl_SchoolYear"
        Me.lbl_SchoolYear.Size = New System.Drawing.Size(85, 18)
        Me.lbl_SchoolYear.TabIndex = 14
        Me.lbl_SchoolYear.Text = "2015-2016"
        Me.lbl_SchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Semester
        '
        Me.lbl_Semester.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Semester.Location = New System.Drawing.Point(1169, 49)
        Me.lbl_Semester.Name = "lbl_Semester"
        Me.lbl_Semester.Size = New System.Drawing.Size(85, 18)
        Me.lbl_Semester.TabIndex = 15
        Me.lbl_Semester.Text = "2nd"
        Me.lbl_Semester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(1063, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "School Year:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(1063, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Semester:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ControlViewSubjects1
        '
        Me.ControlViewSubjects1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlViewSubjects1.Location = New System.Drawing.Point(3, 26)
        Me.ControlViewSubjects1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ControlViewSubjects1.Name = "ControlViewSubjects1"
        Me.ControlViewSubjects1.Size = New System.Drawing.Size(980, 462)
        Me.ControlViewSubjects1.TabIndex = 1
        '
        'ControlViewAssignedSchedule1
        '
        Me.ControlViewAssignedSchedule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlViewAssignedSchedule1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ControlViewAssignedSchedule1.Location = New System.Drawing.Point(3, 26)
        Me.ControlViewAssignedSchedule1.Margin = New System.Windows.Forms.Padding(4)
        Me.ControlViewAssignedSchedule1.Name = "ControlViewAssignedSchedule1"
        Me.ControlViewAssignedSchedule1.Size = New System.Drawing.Size(980, 462)
        Me.ControlViewAssignedSchedule1.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 590)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Semester)
        Me.Controls.Add(Me.lbl_SchoolYear)
        Me.Controls.Add(Me.lblSystemName)
        Me.Controls.Add(Me.GroupBoxContainer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExplorerBar1)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxContainer.ResumeLayout(False)
        Me.GroupBoxContainer.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents TimerTimeAndDate As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBoxContainer As System.Windows.Forms.GroupBox
    Private WithEvents ExplorerBar1 As DevComponents.DotNetBar.ExplorerBar
    Private WithEvents ExplorerBarGroupItemSchedule As DevComponents.DotNetBar.ExplorerBarGroupItem
    Private WithEvents ExplorerBarGroupItemEmployee As DevComponents.DotNetBar.ExplorerBarGroupItem
    Private WithEvents ButtonAssignSched As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonAddAccount As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonRemoveSched As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ExplorerBarGroupItemPrinting As DevComponents.DotNetBar.ExplorerBarGroupItem
    Private WithEvents ButtonPrintAssignedSched As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ExplorerBarGroupItem2 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Private WithEvents ButtonItemSchoolYearSemester As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItemViewAssignedSched As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ExplorerBarGroupItemLogout As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents lblSystemName As Label
    Private WithEvents ButtonItemEditOrDelete As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ExplorerBarGroupItemSubjectManagement As DevComponents.DotNetBar.ExplorerBarGroupItem
    Private WithEvents ButtonItemViewSubjects As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItemModifySubjects As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblNavigate As System.Windows.Forms.Label
    Friend WithEvents ControlViewSubjects1 As SchedulingSystem.ControlViewSubjects
    Friend WithEvents ControlViewAssignedSchedule1 As SchedulingSystem.ControlViewAssignedSchedule
    Friend WithEvents lbl_SchoolYear As System.Windows.Forms.Label
    Friend WithEvents lbl_Semester As System.Windows.Forms.Label
    Private WithEvents ButtonItemAddSchedule As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ExplorerBarGroupItemRoomList As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
