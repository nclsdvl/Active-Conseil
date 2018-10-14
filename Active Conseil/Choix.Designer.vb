<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choix))
        Me.BTN_Admin = New System.Windows.Forms.Button()
        Me.BTN_Client = New System.Windows.Forms.Button()
        Me.BTN_Collabo = New System.Windows.Forms.Button()
        Me.BTN_Projet = New System.Windows.Forms.Button()
        Me.LB_Bonjour = New System.Windows.Forms.Label()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_Admin
        '
        Me.BTN_Admin.BackColor = System.Drawing.Color.Tan
        Me.BTN_Admin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BTN_Admin.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Admin.ForeColor = System.Drawing.Color.AliceBlue
        Me.BTN_Admin.Location = New System.Drawing.Point(351, 169)
        Me.BTN_Admin.Name = "BTN_Admin"
        Me.BTN_Admin.Size = New System.Drawing.Size(152, 59)
        Me.BTN_Admin.TabIndex = 0
        Me.BTN_Admin.Text = "Administration"
        Me.BTN_Admin.UseVisualStyleBackColor = False
        '
        'BTN_Client
        '
        Me.BTN_Client.BackColor = System.Drawing.Color.Bisque
        Me.BTN_Client.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Client.Location = New System.Drawing.Point(178, 256)
        Me.BTN_Client.Name = "BTN_Client"
        Me.BTN_Client.Size = New System.Drawing.Size(144, 60)
        Me.BTN_Client.TabIndex = 1
        Me.BTN_Client.Text = "Client"
        Me.BTN_Client.UseVisualStyleBackColor = False
        '
        'BTN_Collabo
        '
        Me.BTN_Collabo.BackColor = System.Drawing.Color.Bisque
        Me.BTN_Collabo.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Collabo.Location = New System.Drawing.Point(351, 256)
        Me.BTN_Collabo.Name = "BTN_Collabo"
        Me.BTN_Collabo.Size = New System.Drawing.Size(152, 60)
        Me.BTN_Collabo.TabIndex = 2
        Me.BTN_Collabo.Text = "Collaborateur"
        Me.BTN_Collabo.UseVisualStyleBackColor = False
        '
        'BTN_Projet
        '
        Me.BTN_Projet.BackColor = System.Drawing.Color.Bisque
        Me.BTN_Projet.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Projet.Location = New System.Drawing.Point(533, 256)
        Me.BTN_Projet.Name = "BTN_Projet"
        Me.BTN_Projet.Size = New System.Drawing.Size(152, 60)
        Me.BTN_Projet.TabIndex = 3
        Me.BTN_Projet.Text = "Projet"
        Me.BTN_Projet.UseVisualStyleBackColor = False
        '
        'LB_Bonjour
        '
        Me.LB_Bonjour.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Bonjour.ForeColor = System.Drawing.Color.Black
        Me.LB_Bonjour.Location = New System.Drawing.Point(-11, 39)
        Me.LB_Bonjour.Name = "LB_Bonjour"
        Me.LB_Bonjour.Size = New System.Drawing.Size(881, 38)
        Me.LB_Bonjour.TabIndex = 4
        Me.LB_Bonjour.Text = "Label1"
        Me.LB_Bonjour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Quitter.Image = CType(resources.GetObject("Quitter.Image"), System.Drawing.Image)
        Me.Quitter.Location = New System.Drawing.Point(810, 483)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(43, 43)
        Me.Quitter.TabIndex = 7
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'Choix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(865, 538)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.LB_Bonjour)
        Me.Controls.Add(Me.BTN_Projet)
        Me.Controls.Add(Me.BTN_Collabo)
        Me.Controls.Add(Me.BTN_Client)
        Me.Controls.Add(Me.BTN_Admin)
        Me.Name = "Choix"
        Me.Text = "Choix"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_Admin As Button
    Friend WithEvents BTN_Client As Button
    Friend WithEvents BTN_Collabo As Button
    Friend WithEvents BTN_Projet As Button
    Friend WithEvents LB_Bonjour As Label
    Friend WithEvents Quitter As Button
End Class
