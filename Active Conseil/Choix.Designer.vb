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
        Me.BTN_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_Admin
        '
        Me.BTN_Admin.BackColor = System.Drawing.Color.Tan
        Me.BTN_Admin.Cursor = System.Windows.Forms.Cursors.Arrow
        resources.ApplyResources(Me.BTN_Admin, "BTN_Admin")
        Me.BTN_Admin.ForeColor = System.Drawing.Color.AliceBlue
        Me.BTN_Admin.Name = "BTN_Admin"
        Me.BTN_Admin.UseVisualStyleBackColor = False
        '
        'BTN_Client
        '
        Me.BTN_Client.BackColor = System.Drawing.Color.Bisque
        resources.ApplyResources(Me.BTN_Client, "BTN_Client")
        Me.BTN_Client.Name = "BTN_Client"
        Me.BTN_Client.UseVisualStyleBackColor = False
        '
        'BTN_Collabo
        '
        Me.BTN_Collabo.BackColor = System.Drawing.Color.Bisque
        resources.ApplyResources(Me.BTN_Collabo, "BTN_Collabo")
        Me.BTN_Collabo.Name = "BTN_Collabo"
        Me.BTN_Collabo.UseVisualStyleBackColor = False
        '
        'BTN_Projet
        '
        Me.BTN_Projet.BackColor = System.Drawing.Color.Bisque
        resources.ApplyResources(Me.BTN_Projet, "BTN_Projet")
        Me.BTN_Projet.Name = "BTN_Projet"
        Me.BTN_Projet.UseVisualStyleBackColor = False
        '
        'LB_Bonjour
        '
        resources.ApplyResources(Me.LB_Bonjour, "LB_Bonjour")
        Me.LB_Bonjour.ForeColor = System.Drawing.Color.Black
        Me.LB_Bonjour.Name = "LB_Bonjour"
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.Quitter, "Quitter")
        Me.Quitter.Name = "Quitter"
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'BTN_Back
        '
        resources.ApplyResources(Me.BTN_Back, "BTN_Back")
        Me.BTN_Back.Name = "BTN_Back"
        Me.BTN_Back.UseVisualStyleBackColor = True
        '
        'Choix
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.BTN_Back)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.LB_Bonjour)
        Me.Controls.Add(Me.BTN_Projet)
        Me.Controls.Add(Me.BTN_Collabo)
        Me.Controls.Add(Me.BTN_Client)
        Me.Controls.Add(Me.BTN_Admin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Choix"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_Admin As Button
    Friend WithEvents BTN_Client As Button
    Friend WithEvents BTN_Collabo As Button
    Friend WithEvents BTN_Projet As Button
    Friend WithEvents LB_Bonjour As Label
    Friend WithEvents Quitter As Button
    Friend WithEvents BTN_Back As Button
End Class
