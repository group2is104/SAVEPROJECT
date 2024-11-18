<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Dashboard
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
        RoundPanel1 = New RoundPanel()
        RoundPanel2 = New RoundPanel()
        RoundPanel3 = New RoundPanel()
        SuspendLayout()
        ' 
        ' RoundPanel1
        ' 
        RoundPanel1.BackColor = Color.FromArgb(CByte(221), CByte(123), CByte(123))
        RoundPanel1.CornerRadius = 20
        RoundPanel1.Location = New Point(25, 33)
        RoundPanel1.Name = "RoundPanel1"
        RoundPanel1.Size = New Size(200, 100)
        RoundPanel1.TabIndex = 0
        ' 
        ' RoundPanel2
        ' 
        RoundPanel2.BackColor = Color.FromArgb(CByte(221), CByte(123), CByte(123))
        RoundPanel2.CornerRadius = 20
        RoundPanel2.Location = New Point(284, 33)
        RoundPanel2.Name = "RoundPanel2"
        RoundPanel2.Size = New Size(200, 100)
        RoundPanel2.TabIndex = 1
        ' 
        ' RoundPanel3
        ' 
        RoundPanel3.BackColor = Color.FromArgb(CByte(221), CByte(123), CByte(123))
        RoundPanel3.CornerRadius = 20
        RoundPanel3.Location = New Point(558, 33)
        RoundPanel3.Name = "RoundPanel3"
        RoundPanel3.Size = New Size(200, 100)
        RoundPanel3.TabIndex = 1
        ' 
        ' frm_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RoundPanel3)
        Controls.Add(RoundPanel2)
        Controls.Add(RoundPanel1)
        Name = "frm_Dashboard"
        Text = "frm_Dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundPanel1 As RoundPanel
    Friend WithEvents RoundPanel2 As RoundPanel
    Friend WithEvents RoundPanel3 As RoundPanel
End Class
