<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page_Accueil))
        Me.TB_Login = New System.Windows.Forms.TextBox()
        Me.TB_MDP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_Valider = New System.Windows.Forms.Button()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_Login
        '
        Me.TB_Login.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TB_Login.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Login.Location = New System.Drawing.Point(91, 204)
        Me.TB_Login.Name = "TB_Login"
        Me.TB_Login.Size = New System.Drawing.Size(263, 31)
        Me.TB_Login.TabIndex = 0
        '
        'TB_MDP
        '
        Me.TB_MDP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TB_MDP.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MDP.Location = New System.Drawing.Point(490, 204)
        Me.TB_MDP.Name = "TB_MDP"
        Me.TB_MDP.Size = New System.Drawing.Size(263, 31)
        Me.TB_MDP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(548, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot De Passe :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(167, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(591, 57)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SOCIETE ACTIVE CONSEIL"
        '
        'BTN_Valider
        '
        Me.BTN_Valider.BackColor = System.Drawing.Color.Gainsboro
        Me.BTN_Valider.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Valider.Location = New System.Drawing.Point(311, 335)
        Me.BTN_Valider.Name = "BTN_Valider"
        Me.BTN_Valider.Size = New System.Drawing.Size(232, 62)
        Me.BTN_Valider.TabIndex = 5
        Me.BTN_Valider.Text = "Se Connecter"
        Me.BTN_Valider.UseVisualStyleBackColor = False
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Quitter.Image = CType(resources.GetObject("Quitter.Image"), System.Drawing.Image)
        Me.Quitter.Location = New System.Drawing.Point(832, 480)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(43, 43)
        Me.Quitter.TabIndex = 6
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'Page_Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(887, 535)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.BTN_Valider)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_MDP)
        Me.Controls.Add(Me.TB_Login)
        Me.Name = "Page_Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Login As TextBox
    Friend WithEvents TB_MDP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_Valider As Button
    Friend WithEvents Quitter As Button
End Class
