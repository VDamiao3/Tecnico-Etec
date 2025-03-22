<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.btsoma = New System.Windows.Forms.Button()
        Me.btnew = New System.Windows.Forms.Button()
        Me.btexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SOMAR 2 NUMEROS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1° NUMERO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2º NUMERO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RESULTADO:"
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.result.Location = New System.Drawing.Point(104, 149)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 13)
        Me.result.TabIndex = 4
        Me.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(107, 65)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(100, 20)
        Me.num1.TabIndex = 5
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(107, 105)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(100, 20)
        Me.num2.TabIndex = 6
        '
        'btsoma
        '
        Me.btsoma.Location = New System.Drawing.Point(19, 204)
        Me.btsoma.Name = "btsoma"
        Me.btsoma.Size = New System.Drawing.Size(75, 23)
        Me.btsoma.TabIndex = 7
        Me.btsoma.Text = "SOMAR"
        Me.btsoma.UseVisualStyleBackColor = True
        '
        'btnew
        '
        Me.btnew.Location = New System.Drawing.Point(107, 203)
        Me.btnew.Name = "btnew"
        Me.btnew.Size = New System.Drawing.Size(75, 23)
        Me.btnew.TabIndex = 8
        Me.btnew.Text = "NOVO"
        Me.btnew.UseVisualStyleBackColor = True
        '
        'btexit
        '
        Me.btexit.Location = New System.Drawing.Point(201, 203)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(75, 23)
        Me.btexit.TabIndex = 9
        Me.btexit.Text = "SAIR"
        Me.btexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 257)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btnew)
        Me.Controls.Add(Me.btsoma)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents result As System.Windows.Forms.Label
    Friend WithEvents num1 As System.Windows.Forms.TextBox
    Friend WithEvents num2 As System.Windows.Forms.TextBox
    Friend WithEvents btsoma As System.Windows.Forms.Button
    Friend WithEvents btnew As System.Windows.Forms.Button
    Friend WithEvents btexit As System.Windows.Forms.Button

End Class
