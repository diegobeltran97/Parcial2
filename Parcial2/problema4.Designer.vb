<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class problema4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.inputNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.paresList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listImpares = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalPares = New System.Windows.Forms.Label()
        Me.totalImpares = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSumaPares = New System.Windows.Forms.Label()
        Me.lblSumaImpares = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPromedioPares = New System.Windows.Forms.Label()
        Me.lblPromedioImpares = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'inputNumero
        '
        Me.inputNumero.Location = New System.Drawing.Point(151, 90)
        Me.inputNumero.Name = "inputNumero"
        Me.inputNumero.Size = New System.Drawing.Size(100, 20)
        Me.inputNumero.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero"
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(84, 147)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 2
        Me.Save.Text = "Guardar"
        Me.Save.UseVisualStyleBackColor = True
        '
        'paresList
        '
        Me.paresList.FormattingEnabled = True
        Me.paresList.Location = New System.Drawing.Point(424, 115)
        Me.paresList.Name = "paresList"
        Me.paresList.Size = New System.Drawing.Size(120, 121)
        Me.paresList.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pares"
        '
        'listImpares
        '
        Me.listImpares.FormattingEnabled = True
        Me.listImpares.Location = New System.Drawing.Point(615, 115)
        Me.listImpares.Name = "listImpares"
        Me.listImpares.Size = New System.Drawing.Size(120, 121)
        Me.listImpares.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(612, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Impares"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(380, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Numero de Pares"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(567, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero de Impares"
        '
        'totalPares
        '
        Me.totalPares.AutoSize = True
        Me.totalPares.Location = New System.Drawing.Point(488, 269)
        Me.totalPares.Name = "totalPares"
        Me.totalPares.Size = New System.Drawing.Size(13, 13)
        Me.totalPares.TabIndex = 10
        Me.totalPares.Text = "0"
        '
        'totalImpares
        '
        Me.totalImpares.AutoSize = True
        Me.totalImpares.Location = New System.Drawing.Point(699, 269)
        Me.totalImpares.Name = "totalImpares"
        Me.totalImpares.Size = New System.Drawing.Size(13, 13)
        Me.totalImpares.TabIndex = 11
        Me.totalImpares.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Suma de Pares"
        '
        'lblSumaPares
        '
        Me.lblSumaPares.AutoSize = True
        Me.lblSumaPares.Location = New System.Drawing.Point(488, 301)
        Me.lblSumaPares.Name = "lblSumaPares"
        Me.lblSumaPares.Size = New System.Drawing.Size(13, 13)
        Me.lblSumaPares.TabIndex = 13
        Me.lblSumaPares.Text = "0"
        '
        'lblSumaImpares
        '
        Me.lblSumaImpares.AutoSize = True
        Me.lblSumaImpares.Location = New System.Drawing.Point(699, 301)
        Me.lblSumaImpares.Name = "lblSumaImpares"
        Me.lblSumaImpares.Size = New System.Drawing.Size(13, 13)
        Me.lblSumaImpares.TabIndex = 14
        Me.lblSumaImpares.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(567, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Suma de Impares"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Promedio Pares"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(567, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Promedio Impares"
        '
        'lblPromedioPares
        '
        Me.lblPromedioPares.AutoSize = True
        Me.lblPromedioPares.Location = New System.Drawing.Point(488, 333)
        Me.lblPromedioPares.Name = "lblPromedioPares"
        Me.lblPromedioPares.Size = New System.Drawing.Size(13, 13)
        Me.lblPromedioPares.TabIndex = 18
        Me.lblPromedioPares.Text = "0"
        '
        'lblPromedioImpares
        '
        Me.lblPromedioImpares.AutoSize = True
        Me.lblPromedioImpares.Location = New System.Drawing.Point(699, 333)
        Me.lblPromedioImpares.Name = "lblPromedioImpares"
        Me.lblPromedioImpares.Size = New System.Drawing.Size(13, 13)
        Me.lblPromedioImpares.TabIndex = 19
        Me.lblPromedioImpares.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(649, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'problema4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPromedioImpares)
        Me.Controls.Add(Me.lblPromedioPares)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSumaImpares)
        Me.Controls.Add(Me.lblSumaPares)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.totalImpares)
        Me.Controls.Add(Me.totalPares)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.listImpares)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.paresList)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputNumero)
        Me.Name = "problema4"
        Me.Text = "problema4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputNumero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Save As Button
    Friend WithEvents paresList As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents listImpares As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents totalPares As Label
    Friend WithEvents totalImpares As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSumaPares As Label
    Friend WithEvents lblSumaImpares As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPromedioPares As Label
    Friend WithEvents lblPromedioImpares As Label
    Friend WithEvents Button1 As Button
End Class
