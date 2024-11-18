<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabPanel = New Panel()
        btn_JournalEntry = New RoundIconButton()
        btn_Account = New RoundIconButton()
        btn_Dashboard = New RoundIconButton()
        RoundIconButton1 = New RoundIconButton()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel1 = New Panel()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        IconButton8 = New FontAwesome.Sharp.IconButton()
        pnl_TabView = New Panel()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TabPanel.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        pnl_TabView.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabPanel
        ' 
        TabPanel.BackColor = Color.FromArgb(CByte(0), CByte(167), CByte(225))
        TabPanel.Controls.Add(btn_JournalEntry)
        TabPanel.Controls.Add(btn_Account)
        TabPanel.Controls.Add(btn_Dashboard)
        TabPanel.Controls.Add(RoundIconButton1)
        TabPanel.Controls.Add(Panel4)
        TabPanel.Controls.Add(Panel3)
        TabPanel.Controls.Add(Panel1)
        TabPanel.Dock = DockStyle.Left
        TabPanel.Location = New Point(0, 0)
        TabPanel.Name = "TabPanel"
        TabPanel.Size = New Size(218, 592)
        TabPanel.TabIndex = 9
        ' 
        ' btn_JournalEntry
        ' 
        btn_JournalEntry.BackColor = Color.FromArgb(CByte(0), CByte(167), CByte(225))
        btn_JournalEntry.CornerRadius = 20
        btn_JournalEntry.Dock = DockStyle.Top
        btn_JournalEntry.FlatAppearance.BorderSize = 0
        btn_JournalEntry.FlatStyle = FlatStyle.Flat
        btn_JournalEntry.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_JournalEntry.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        btn_JournalEntry.IconColor = Color.Black
        btn_JournalEntry.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_JournalEntry.IconSize = 36
        btn_JournalEntry.ImageAlign = ContentAlignment.MiddleLeft
        btn_JournalEntry.Location = New Point(0, 205)
        btn_JournalEntry.Name = "btn_JournalEntry"
        btn_JournalEntry.Padding = New Padding(10, 0, 0, 0)
        btn_JournalEntry.Size = New Size(218, 50)
        btn_JournalEntry.TabIndex = 38
        btn_JournalEntry.Text = "Tab2"
        btn_JournalEntry.TextAlign = ContentAlignment.MiddleLeft
        btn_JournalEntry.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_JournalEntry.UseVisualStyleBackColor = False
        ' 
        ' btn_Account
        ' 
        btn_Account.BackColor = Color.FromArgb(CByte(0), CByte(167), CByte(225))
        btn_Account.CornerRadius = 20
        btn_Account.Dock = DockStyle.Top
        btn_Account.FlatAppearance.BorderSize = 0
        btn_Account.FlatStyle = FlatStyle.Flat
        btn_Account.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Account.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        btn_Account.IconColor = Color.Black
        btn_Account.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_Account.IconSize = 36
        btn_Account.ImageAlign = ContentAlignment.MiddleLeft
        btn_Account.Location = New Point(0, 155)
        btn_Account.Name = "btn_Account"
        btn_Account.Padding = New Padding(10, 0, 0, 0)
        btn_Account.Size = New Size(218, 50)
        btn_Account.TabIndex = 35
        btn_Account.Text = "Tab1"
        btn_Account.TextAlign = ContentAlignment.MiddleLeft
        btn_Account.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Account.UseVisualStyleBackColor = False
        ' 
        ' btn_Dashboard
        ' 
        btn_Dashboard.BackColor = Color.FromArgb(CByte(0), CByte(167), CByte(225))
        btn_Dashboard.CornerRadius = 20
        btn_Dashboard.Dock = DockStyle.Top
        btn_Dashboard.FlatAppearance.BorderSize = 0
        btn_Dashboard.FlatStyle = FlatStyle.Flat
        btn_Dashboard.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        btn_Dashboard.IconColor = Color.Black
        btn_Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_Dashboard.IconSize = 36
        btn_Dashboard.ImageAlign = ContentAlignment.MiddleLeft
        btn_Dashboard.Location = New Point(0, 105)
        btn_Dashboard.Name = "btn_Dashboard"
        btn_Dashboard.Padding = New Padding(10, 0, 0, 0)
        btn_Dashboard.Size = New Size(218, 50)
        btn_Dashboard.TabIndex = 33
        btn_Dashboard.Text = "Dashboard"
        btn_Dashboard.TextAlign = ContentAlignment.MiddleLeft
        btn_Dashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' RoundIconButton1
        ' 
        RoundIconButton1.BackColor = Color.FromArgb(CByte(246), CByte(109), CByte(10))
        RoundIconButton1.CornerRadius = 20
        RoundIconButton1.Dock = DockStyle.Bottom
        RoundIconButton1.FlatAppearance.BorderSize = 0
        RoundIconButton1.FlatStyle = FlatStyle.Flat
        RoundIconButton1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        RoundIconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        RoundIconButton1.IconColor = Color.Black
        RoundIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        RoundIconButton1.IconSize = 36
        RoundIconButton1.ImageAlign = ContentAlignment.MiddleLeft
        RoundIconButton1.Location = New Point(0, 475)
        RoundIconButton1.Name = "RoundIconButton1"
        RoundIconButton1.Padding = New Padding(60, 0, 0, 0)
        RoundIconButton1.Size = New Size(218, 40)
        RoundIconButton1.TabIndex = 15
        RoundIconButton1.Text = "Back"
        RoundIconButton1.TextAlign = ContentAlignment.MiddleLeft
        RoundIconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        RoundIconButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(167), CByte(225))
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 73)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(218, 32)
        Panel4.TabIndex = 16
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 515)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(218, 77)
        Panel3.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(246), CByte(109), CByte(10))
        Panel1.Controls.Add(IconButton4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(218, 73)
        Panel1.TabIndex = 10
        ' 
        ' IconButton4
        ' 
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton4.ForeColor = Color.Black
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.Box
        IconButton4.IconColor = Color.Black
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.IconSize = 36
        IconButton4.ImageAlign = ContentAlignment.MiddleLeft
        IconButton4.Location = New Point(51, 12)
        IconButton4.Name = "IconButton4"
        IconButton4.Padding = New Padding(10, 0, 0, 0)
        IconButton4.Size = New Size(127, 50)
        IconButton4.TabIndex = 14
        IconButton4.Text = "Text"
        IconButton4.TextAlign = ContentAlignment.MiddleLeft
        IconButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(246), CByte(109), CByte(10))
        Panel2.Controls.Add(IconButton8)
        Panel2.Dock = DockStyle.Top
        Panel2.Enabled = False
        Panel2.Location = New Point(218, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(855, 73)
        Panel2.TabIndex = 10
        ' 
        ' IconButton8
        ' 
        IconButton8.Dock = DockStyle.Right
        IconButton8.FlatAppearance.BorderSize = 0
        IconButton8.FlatStyle = FlatStyle.Flat
        IconButton8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton8.ForeColor = Color.Black
        IconButton8.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        IconButton8.IconColor = Color.Black
        IconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton8.IconSize = 36
        IconButton8.ImageAlign = ContentAlignment.MiddleLeft
        IconButton8.Location = New Point(663, 0)
        IconButton8.Name = "IconButton8"
        IconButton8.Padding = New Padding(0, 0, 10, 0)
        IconButton8.RightToLeft = RightToLeft.Yes
        IconButton8.Size = New Size(192, 73)
        IconButton8.TabIndex = 13
        IconButton8.Text = "username"
        IconButton8.TextAlign = ContentAlignment.MiddleLeft
        IconButton8.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton8.UseVisualStyleBackColor = False
        ' 
        ' pnl_TabView
        ' 
        pnl_TabView.Controls.Add(IconButton1)
        pnl_TabView.Dock = DockStyle.Fill
        pnl_TabView.Location = New Point(218, 73)
        pnl_TabView.Name = "pnl_TabView"
        pnl_TabView.Size = New Size(855, 519)
        pnl_TabView.TabIndex = 11
        ' 
        ' IconButton1
        ' 
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton1.ForeColor = Color.Black
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Box
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 36
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(345, 194)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(10, 0, 0, 0)
        IconButton1.Size = New Size(127, 50)
        IconButton1.TabIndex = 15
        IconButton1.Text = "Text"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1073, 592)
        Controls.Add(pnl_TabView)
        Controls.Add(Panel2)
        Controls.Add(TabPanel)
        Name = "Form1"
        Text = "Template"
        TabPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        pnl_TabView.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabPanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents pnl_TabView As Panel
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents RoundIconButton1 As RoundIconButton
    Friend WithEvents btn_Dashboard As RoundIconButton
    Friend WithEvents btn_Account As RoundIconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_JournalEntry As RoundIconButton

End Class
