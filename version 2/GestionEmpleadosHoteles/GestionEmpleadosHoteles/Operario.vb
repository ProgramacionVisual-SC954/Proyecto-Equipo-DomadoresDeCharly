Public Class Operario
    Inherits Empleado

    Private _horasExtra As Integer
    Private Const PagoPorHoraExtra As Decimal = 50D

    Public Sub New(nombre As String, rfc As String, salarioBase As Decimal, departamento As String, horasExtra As Integer)
        MyBase.New(nombre, rfc, salarioBase, departamento)
        Me.HorasExtra = horasExtra
    End Sub

    Public Property HorasExtra As Integer
        Get
            Return _horasExtra
        End Get
        Set(value As Integer)
            If value < 0 Or value > 1000 Then
                Throw New Exception("Horas extra inválidas.")
            End If

            _horasExtra = value
        End Set
    End Property

    Public Overrides Function CalcularPagoMensual() As Decimal
        Return SalarioBase + (_horasExtra * PagoPorHoraExtra)
    End Function

    Public Overrides Function ObtenerFicha() As String
        Return MyBase.ObtenerFicha() & vbCrLf & $"Horas Extra: {_horasExtra}"
    End Function
End Class
