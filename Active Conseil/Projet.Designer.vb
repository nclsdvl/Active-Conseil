﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Projet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Projet))
        Me.LB_Projet = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_Titre = New System.Windows.Forms.Label()
        Me.LB_Techno = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LB_Chef = New System.Windows.Forms.Label()
        Me.LB_Client = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LB_Cycle = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LB_Deb = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LB_Fin = New System.Windows.Forms.Label()
        Me.LB_Deb_Reel = New System.Windows.Forms.Label()
        Me.LB_Fin_Reel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LB_Secteur = New System.Windows.Forms.Label()
        Me.LB_Equipe = New System.Windows.Forms.Label()
        Me.LB_Nbr_Ligne = New System.Windows.Forms.Label()
        Me.LB_Collab = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LB_Doc = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LB_Resume = New System.Windows.Forms.Label()
        Me.BTN_Back = New System.Windows.Forms.Button()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LB_Projet
        '
        Me.LB_Projet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Projet.FormattingEnabled = True
        Me.LB_Projet.ItemHeight = 16
        Me.LB_Projet.Location = New System.Drawing.Point(27, 131)
        Me.LB_Projet.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.LB_Projet.Name = "LB_Projet"
        Me.LB_Projet.Size = New System.Drawing.Size(315, 164)
        Me.LB_Projet.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom du projet :"
        '
        'LB_Titre
        '
        Me.LB_Titre.AutoSize = True
        Me.LB_Titre.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Titre.Location = New System.Drawing.Point(599, 18)
        Me.LB_Titre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LB_Titre.Name = "LB_Titre"
        Me.LB_Titre.Size = New System.Drawing.Size(135, 34)
        Me.LB_Titre.TabIndex = 2
        Me.LB_Titre.Text = "PROJET"
        '
        'LB_Techno
        '
        Me.LB_Techno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Techno.FormattingEnabled = True
        Me.LB_Techno.ItemHeight = 16
        Me.LB_Techno.Location = New System.Drawing.Point(62, 372)
        Me.LB_Techno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LB_Techno.Name = "LB_Techno"
        Me.LB_Techno.Size = New System.Drawing.Size(224, 164)
        Me.LB_Techno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Client : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 172)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Chef de Projet : "
        '
        'LB_Chef
        '
        Me.LB_Chef.AutoSize = True
        Me.LB_Chef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Chef.Location = New System.Drawing.Point(563, 172)
        Me.LB_Chef.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_Chef.Name = "LB_Chef"
        Me.LB_Chef.Size = New System.Drawing.Size(0, 16)
        Me.LB_Chef.TabIndex = 7
        '
        'LB_Client
        '
        Me.LB_Client.AutoSize = True
        Me.LB_Client.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Client.Location = New System.Drawing.Point(563, 141)
        Me.LB_Client.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_Client.Name = "LB_Client"
        Me.LB_Client.Size = New System.Drawing.Size(0, 16)
        Me.LB_Client.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(504, 200)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cycle :"
        '
        'LB_Cycle
        '
        Me.LB_Cycle.AutoSize = True
        Me.LB_Cycle.Location = New System.Drawing.Point(563, 200)
        Me.LB_Cycle.Name = "LB_Cycle"
        Me.LB_Cycle.Size = New System.Drawing.Size(0, 16)
        Me.LB_Cycle.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(443, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date de début :"
        '
        'LB_Deb
        '
        Me.LB_Deb.AutoSize = True
        Me.LB_Deb.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LB_Deb.Location = New System.Drawing.Point(643, 234)
        Me.LB_Deb.Name = "LB_Deb"
        Me.LB_Deb.Size = New System.Drawing.Size(0, 13)
        Me.LB_Deb.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(461, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Date de Fin :"
        '
        'LB_Fin
        '
        Me.LB_Fin.AutoSize = True
        Me.LB_Fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LB_Fin.Location = New System.Drawing.Point(643, 269)
        Me.LB_Fin.Name = "LB_Fin"
        Me.LB_Fin.Size = New System.Drawing.Size(0, 13)
        Me.LB_Fin.TabIndex = 14
        '
        'LB_Deb_Reel
        '
        Me.LB_Deb_Reel.AutoSize = True
        Me.LB_Deb_Reel.Location = New System.Drawing.Point(563, 231)
        Me.LB_Deb_Reel.Name = "LB_Deb_Reel"
        Me.LB_Deb_Reel.Size = New System.Drawing.Size(0, 16)
        Me.LB_Deb_Reel.TabIndex = 15
        '
        'LB_Fin_Reel
        '
        Me.LB_Fin_Reel.AutoSize = True
        Me.LB_Fin_Reel.Location = New System.Drawing.Point(563, 266)
        Me.LB_Fin_Reel.Name = "LB_Fin_Reel"
        Me.LB_Fin_Reel.Size = New System.Drawing.Size(0, 16)
        Me.LB_Fin_Reel.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Téchnologies utilisées :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(804, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Taille max de l'équipe :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(833, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Nombre de lignes : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(905, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Secteur :"
        '
        'LB_Secteur
        '
        Me.LB_Secteur.AutoSize = True
        Me.LB_Secteur.Location = New System.Drawing.Point(1004, 172)
        Me.LB_Secteur.Name = "LB_Secteur"
        Me.LB_Secteur.Size = New System.Drawing.Size(0, 16)
        Me.LB_Secteur.TabIndex = 21
        '
        'LB_Equipe
        '
        Me.LB_Equipe.AutoSize = True
        Me.LB_Equipe.Location = New System.Drawing.Point(1004, 203)
        Me.LB_Equipe.Name = "LB_Equipe"
        Me.LB_Equipe.Size = New System.Drawing.Size(0, 16)
        Me.LB_Equipe.TabIndex = 22
        '
        'LB_Nbr_Ligne
        '
        Me.LB_Nbr_Ligne.AutoSize = True
        Me.LB_Nbr_Ligne.Location = New System.Drawing.Point(1004, 234)
        Me.LB_Nbr_Ligne.Name = "LB_Nbr_Ligne"
        Me.LB_Nbr_Ligne.Size = New System.Drawing.Size(0, 16)
        Me.LB_Nbr_Ligne.TabIndex = 23
        Me.LB_Nbr_Ligne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_Collab
        '
        Me.LB_Collab.FormattingEnabled = True
        Me.LB_Collab.ItemHeight = 16
        Me.LB_Collab.Location = New System.Drawing.Point(441, 372)
        Me.LB_Collab.Name = "LB_Collab"
        Me.LB_Collab.Size = New System.Drawing.Size(179, 164)
        Me.LB_Collab.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(469, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 18)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Collaborateurs :"
        '
        'LB_Doc
        '
        Me.LB_Doc.FormattingEnabled = True
        Me.LB_Doc.ItemHeight = 16
        Me.LB_Doc.Location = New System.Drawing.Point(778, 372)
        Me.LB_Doc.Name = "LB_Doc"
        Me.LB_Doc.Size = New System.Drawing.Size(236, 164)
        Me.LB_Doc.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(833, 337)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 18)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Documentation :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1031, 402)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Auteur : (pb BDD!!!!!!!)"
        '
        'LB_Resume
        '
        Me.LB_Resume.AutoSize = True
        Me.LB_Resume.Location = New System.Drawing.Point(1031, 458)
        Me.LB_Resume.Name = "LB_Resume"
        Me.LB_Resume.Size = New System.Drawing.Size(68, 16)
        Me.LB_Resume.TabIndex = 29
        Me.LB_Resume.Text = "Resumé : "
        '
        'BTN_Back
        '
        Me.BTN_Back.BackgroundImage = CType(resources.GetObject("BTN_Back.BackgroundImage"), System.Drawing.Image)
        Me.BTN_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Back.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_Back.Location = New System.Drawing.Point(1267, 12)
        Me.BTN_Back.Name = "BTN_Back"
        Me.BTN_Back.Size = New System.Drawing.Size(43, 43)
        Me.BTN_Back.TabIndex = 30
        Me.BTN_Back.UseVisualStyleBackColor = True
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Quitter.Image = CType(resources.GetObject("Quitter.Image"), System.Drawing.Image)
        Me.Quitter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Quitter.Location = New System.Drawing.Point(1267, 552)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(43, 43)
        Me.Quitter.TabIndex = 31
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'Projet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1322, 607)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.BTN_Back)
        Me.Controls.Add(Me.LB_Resume)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LB_Doc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LB_Collab)
        Me.Controls.Add(Me.LB_Nbr_Ligne)
        Me.Controls.Add(Me.LB_Equipe)
        Me.Controls.Add(Me.LB_Secteur)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LB_Fin_Reel)
        Me.Controls.Add(Me.LB_Deb_Reel)
        Me.Controls.Add(Me.LB_Fin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LB_Deb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LB_Cycle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LB_Client)
        Me.Controls.Add(Me.LB_Chef)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LB_Techno)
        Me.Controls.Add(Me.LB_Titre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB_Projet)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Projet"
        Me.Text = "Projet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_Projet As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LB_Titre As Label
    Friend WithEvents LB_Techno As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LB_Chef As Label
    Friend WithEvents LB_Client As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LB_Cycle As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LB_Deb As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LB_Fin As Label
    Friend WithEvents LB_Deb_Reel As Label
    Friend WithEvents LB_Fin_Reel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LB_Secteur As Label
    Friend WithEvents LB_Equipe As Label
    Friend WithEvents LB_Nbr_Ligne As Label
    Friend WithEvents LB_Collab As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LB_Doc As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LB_Resume As Label
    Friend WithEvents BTN_Back As Button
    Friend WithEvents Quitter As Button
End Class
