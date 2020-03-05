Module Module1
    Public Sub displayform(ByVal frm As Form, ByVal pnl As Panel)
        frm.Width = pnl.Width
        frm.Height = pnl.Height
        frm.TopLevel = False
        frm.Parent = pnl
        frm.Show()
        frm.BringToFront()
    End Sub
End Module
