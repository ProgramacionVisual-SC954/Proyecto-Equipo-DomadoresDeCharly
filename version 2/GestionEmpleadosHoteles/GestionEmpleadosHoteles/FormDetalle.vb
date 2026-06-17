Public Class grpPago


    Private Sub txtFicha_TextChanged(sender As Object, e As EventArgs) Handles txtFicha.TextChanged

    End Sub

    Private Sub txtSalarioBase_TextChanged(sender As Object, e As EventArgs) Handles txtSalarioBase.TextChanged

    End Sub

    Private Sub txtExtra_TextChanged(sender As Object, e As EventArgs) Handles txtExtra.TextChanged

    End Sub

    Private Sub lblPagoMensual_Click(sender As Object, e As EventArgs) Handles lblPagoMensual.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim salario As Decimal
            If Not Decimal.TryParse(txtSalarioBase.Text, salario) Then
                Throw New Exception("Salario base inválido.")
            End If

            empleado.SalarioBase = salario

            If TypeOf empleado Is Gerente Then
                Dim bono As Integer
                If Not Integer.TryParse(txtExtra.Text, bono) Then
                    Throw New Exception("Bono inválido.")
                End If
                CType(empleado, Gerente).BonoPct = bono
            ElseIf TypeOf empleado Is Operario Then
                Dim horas As Integer
                If Not Integer.TryParse(txtExtra.Text, horas) Then
                    Throw New Exception("Horas extra inválidas.")
                End If
                CType(empleado, Operario).HorasExtra = horas
            End If

    End Sub
End Class