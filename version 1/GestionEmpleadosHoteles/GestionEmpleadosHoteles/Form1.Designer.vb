<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Nombre = New DataGridViewTextBoxColumn()
        RFC = New DataGridViewTextBoxColumn()
        Tipo = New DataGridViewTextBoxColumn()
        Departamento = New DataGridViewTextBoxColumn()
        Pago_Mensual = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(114, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "Ver Detalle"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(318, 274)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 34)
        Button2.TabIndex = 1
        Button2.Text = "Nuevo Gerente"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(552, 274)
        Button3.Name = "Button3"
        Button3.Size = New Size(158, 34)
        Button3.TabIndex = 2
        Button3.Text = "Nuevo Operario"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(342, 431)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 3
        Button4.Text = "Eliminar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Nombre, RFC, Tipo, Departamento, Pago_Mensual})
        DataGridView1.Location = New Point(5, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(798, 225)
        DataGridView1.TabIndex = 4
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 8
        Nombre.Name = "Nombre"
        Nombre.Width = 150
        ' 
        ' RFC
        ' 
        RFC.HeaderText = "RFC"
        RFC.MinimumWidth = 8
        RFC.Name = "RFC"
        RFC.Width = 150
        ' 
        ' Tipo
        ' 
        Tipo.HeaderText = "Tipo (Gerente/operatario)"
        Tipo.MinimumWidth = 8
        Tipo.Name = "Tipo"
        Tipo.Width = 150
        ' 
        ' Departamento
        ' 
        Departamento.HeaderText = "Departamento"
        Departamento.MinimumWidth = 8
        Departamento.Name = "Departamento"
        Departamento.Width = 150
        ' 
        ' Pago_Mensual
        ' 
        Pago_Mensual.HeaderText = "Pago Mensual"
        Pago_Mensual.MinimumWidth = 8
        Pago_Mensual.Name = "Pago_Mensual"
        Pago_Mensual.Width = 150
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(102, 436)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 25)
        Label1.TabIndex = 5
        Label1.Text = "Total Empleados: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(571, 436)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 25)
        Label2.TabIndex = 6
        Label2.Text = "Total Nomina: "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 564)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents RFC As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
    Friend WithEvents Pago_Mensual As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
