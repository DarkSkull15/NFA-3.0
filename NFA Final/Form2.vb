Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "ADMIN" Or TextBox1.Text = "admin" Then
            Me.Hide()
            MainForm.Deleteq2()
        Else
            TextBox1.Focus()
            TextBox1.Text = ""
            TextBox1.BackColor = Color.IndianRed

        End If
    End Sub

    Private Sub OvalShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.Click
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub
End Class