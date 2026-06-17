Public Class Gerente
    Inherits Empleado

    Private _bonoPct As Integer

    Public Sub New(nombre As String, rfc As String, salarioBase As Decimal, departamento As String, bonoPct As Integer)
        MyBase.New(nombre, rfc, salarioBase, departamento)
        Me.BonoPct = bonoPct
    End Sub

    Public Property BonoPct As Integer
        Get
            Return _bonoPct
        End Get
        Set(value As Integer)
            If Not ModuloValidaciones.EsBonoValido(value) Then
                Throw New Exception("Bono inválido. Debe estar entre 5 y 40%.")
            End If

            _bonoPct = value
        End Set
    End Property

    Public Overrides Function CalcularPagoMensual() As Decimal
        Return SalarioBase + (SalarioBase * _bonoPct / 100D)
    End Function

    Public Overrides Function ObtenerFicha() As String
        Return MyBase.ObtenerFicha() & vbCrLf & $"Bono: {_bonoPct}%"
    End Function
End Class
