Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub vdetalle_Click(sender As Object, e As EventArgs) Handles vdetalle.Click
        Dim frm As New grpPago()
        frm.ShowDialog()
    End Sub
End Class
