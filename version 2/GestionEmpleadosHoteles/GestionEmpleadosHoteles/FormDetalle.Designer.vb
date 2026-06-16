<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grpPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitulo = New Label()
        Label2 = New Label()
        grpInformacion = New GroupBox()
        txtFicha = New TextBox()
        Label1 = New Label()
        txtSalarioBase = New TextBox()
        Label3 = New Label()
        txtExtra = New TextBox()
        GroupBox1 = New GroupBox()
        lblPagoMensual = New Label()
        btnGuardar = New Button()
        btnCancelar = New Button()
        grpInformacion.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(12, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(140, 15)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "DETALLE DEL EMPLEADO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 21)
        Label2.TabIndex = 1
        Label2.Text = "Informacion completa"
        ' 
        ' grpInformacion
        ' 
        grpInformacion.Controls.Add(txtFicha)
        grpInformacion.Location = New Point(38, 66)
        grpInformacion.Name = "grpInformacion"
        grpInformacion.Size = New Size(403, 100)
        grpInformacion.TabIndex = 2
        grpInformacion.TabStop = False
        grpInformacion.Text = "GroupBox1"
        ' 
        ' txtFicha
        ' 
        txtFicha.Location = New Point(6, 22)
        txtFicha.Multiline = True
        txtFicha.Name = "txtFicha"
        txtFicha.ReadOnly = True
        txtFicha.ScrollBars = ScrollBars.Vertical
        txtFicha.Size = New Size(391, 72)
        txtFicha.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 180)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 3
        Label1.Text = "Salario Base:"
        ' 
        ' txtSalarioBase
        ' 
        txtSalarioBase.Location = New Point(177, 172)
        txtSalarioBase.Name = "txtSalarioBase"
        txtSalarioBase.Size = New Size(155, 23)
        txtSalarioBase.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 15)
        Label3.TabIndex = 5
        Label3.Text = "Bono (%) / Horas Extra:"
        ' 
        ' txtExtra
        ' 
        txtExtra.Location = New Point(177, 218)
        txtExtra.Name = "txtExtra"
        txtExtra.Size = New Size(155, 23)
        txtExtra.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblPagoMensual)
        GroupBox1.Location = New Point(38, 270)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(403, 100)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pago Mensual Calculado"
        ' 
        ' lblPagoMensual
        ' 
        lblPagoMensual.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPagoMensual.Location = New Point(153, 36)
        lblPagoMensual.Name = "lblPagoMensual"
        lblPagoMensual.Size = New Size(100, 40)
        lblPagoMensual.TabIndex = 0
        lblPagoMensual.Text = "$0.00"
        lblPagoMensual.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnGuardar.Location = New Point(272, 390)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 34)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnCancelar.Location = New Point(366, 390)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 34)
        btnCancelar.TabIndex = 8
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' grpPago
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(466, 474)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(GroupBox1)
        Controls.Add(txtExtra)
        Controls.Add(Label3)
        Controls.Add(txtSalarioBase)
        Controls.Add(Label1)
        Controls.Add(grpInformacion)
        Controls.Add(Label2)
        Controls.Add(lblTitulo)
        Margin = New Padding(2)
        Name = "grpPago"
        Text = "6"
        grpInformacion.ResumeLayout(False)
        grpInformacion.PerformLayout()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpInformacion As GroupBox
    Friend WithEvents txtFicha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSalarioBase As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtExtra As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPagoMensual As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class
