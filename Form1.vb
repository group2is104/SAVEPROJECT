Imports FontAwesome.Sharp

Public Class Form1
    Private currentBtn As IconButton
    Private currenChildForm As Form

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(0, 167, 225)
            currentBtn.ForeColor = Color.FromArgb(6, 32, 13)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(246, 109, 10)
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

        End If
    End Sub

    Private Sub OpenChildForm(childform As Form)
        If currenChildForm IsNot Nothing Then
            currenChildForm.Close()
        End If
        currenChildForm = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        pnl_TabView.Controls.Add(childform)
        pnl_TabView.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        ActivateButton(sender)
        OpenChildForm(New frm_Dashboard)
    End Sub

    Private Sub btn_Tab2_Click(sender As Object, e As EventArgs) Handles btn_Account.Click
        ActivateButton(sender)
        OpenChildForm(New fms_tab1)

    End Sub

    Private Sub btn_JournalEntry_Click(sender As Object, e As EventArgs) Handles btn_JournalEntry.Click
        ActivateButton(sender)
        'OpenChildForm(New frm_tab2)
        MsgBox("i chat ako kung paano ilalagay -leadprogrammer")
    End Sub

    Private Sub RoundIconButton1_Click(sender As Object, e As EventArgs) Handles RoundIconButton1.Click
        MsgBox("Ako mag lalagay nito -leadprogrammer")
    End Sub
End Class
