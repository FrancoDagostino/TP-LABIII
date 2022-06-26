<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBProvincias = New System.Windows.Forms.ComboBox()
        Me.NUDAnio = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GRILLA = New System.Windows.Forms.DataGridView()
        Me.ChartINC = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUDAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartINC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CBProvincias)
        Me.GroupBox1.Controls.Add(Me.NUDAnio)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(525, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(525, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CBProvincias
        '
        Me.CBProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProvincias.Enabled = False
        Me.CBProvincias.FormattingEnabled = True
        Me.CBProvincias.Location = New System.Drawing.Point(104, 76)
        Me.CBProvincias.Name = "CBProvincias"
        Me.CBProvincias.Size = New System.Drawing.Size(170, 21)
        Me.CBProvincias.TabIndex = 3
        '
        'NUDAnio
        '
        Me.NUDAnio.Enabled = False
        Me.NUDAnio.Location = New System.Drawing.Point(104, 20)
        Me.NUDAnio.Name = "NUDAnio"
        Me.NUDAnio.Size = New System.Drawing.Size(73, 20)
        Me.NUDAnio.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 76)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Por provincia"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Por año"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GRILLA
        '
        Me.GRILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRILLA.Location = New System.Drawing.Point(13, 137)
        Me.GRILLA.Name = "GRILLA"
        Me.GRILLA.Size = New System.Drawing.Size(642, 203)
        Me.GRILLA.TabIndex = 1
        '
        'ChartINC
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartINC.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartINC.Legends.Add(Legend2)
        Me.ChartINC.Location = New System.Drawing.Point(13, 358)
        Me.ChartINC.Name = "ChartINC"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartINC.Series.Add(Series2)
        Me.ChartINC.Size = New System.Drawing.Size(640, 287)
        Me.ChartINC.TabIndex = 2
        Me.ChartINC.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 657)
        Me.Controls.Add(Me.ChartINC)
        Me.Controls.Add(Me.GRILLA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUDAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartINC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CBProvincias As ComboBox
    Friend WithEvents NUDAnio As NumericUpDown
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GRILLA As DataGridView
    Friend WithEvents ChartINC As DataVisualization.Charting.Chart
End Class
