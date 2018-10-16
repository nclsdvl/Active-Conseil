<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabCollab = New System.Windows.Forms.TabPage()
        Me.TB_Fin = New System.Windows.Forms.TextBox()
        Me.TB_Embauche = New System.Windows.Forms.TextBox()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.BTN_Back = New System.Windows.Forms.Button()
        Me.BTN_Valider = New System.Windows.Forms.Button()
        Me.GB_Civilite = New System.Windows.Forms.GroupBox()
        Me.RB_Mr = New System.Windows.Forms.RadioButton()
        Me.RB_Mme = New System.Windows.Forms.RadioButton()
        Me.RB_Mlle = New System.Windows.Forms.RadioButton()
        Me.LB_Civilite = New System.Windows.Forms.Label()
        Me.TB_Tel = New System.Windows.Forms.TextBox()
        Me.TB_Prenom = New System.Windows.Forms.TextBox()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.TB_Ville = New System.Windows.Forms.TextBox()
        Me.TB_CP = New System.Windows.Forms.TextBox()
        Me.TB_CptAdresse = New System.Windows.Forms.TextBox()
        Me.TB_NumRue = New System.Windows.Forms.TextBox()
        Me.LB_Fin = New System.Windows.Forms.Label()
        Me.LB_Embauche = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_Prénom = New System.Windows.Forms.Label()
        Me.LB_Nom = New System.Windows.Forms.Label()
        Me.LB_Ville = New System.Windows.Forms.Label()
        Me.LB_Cplt_Adresse = New System.Windows.Forms.Label()
        Me.LB_CP = New System.Windows.Forms.Label()
        Me.LB_Rue = New System.Windows.Forms.Label()
        Me.CB_Collabo = New System.Windows.Forms.ComboBox()
        Me.RB_Ajout = New System.Windows.Forms.RadioButton()
        Me.RB_Consult = New System.Windows.Forms.RadioButton()
        Me.RB_Modif = New System.Windows.Forms.RadioButton()
        Me.TabClient = New System.Windows.Forms.TabPage()
        Me.TabProjet = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabCollab.SuspendLayout()
        Me.GB_Civilite.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1029, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabCollab)
        Me.TabControl1.Controls.Add(Me.TabClient)
        Me.TabControl1.Controls.Add(Me.TabProjet)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1033, 554)
        Me.TabControl1.TabIndex = 2
        '
        'TabCollab
        '
        Me.TabCollab.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabCollab.Controls.Add(Me.Label7)
        Me.TabCollab.Controls.Add(Me.Label6)
        Me.TabCollab.Controls.Add(Me.Label5)
        Me.TabCollab.Controls.Add(Me.Label4)
        Me.TabCollab.Controls.Add(Me.Label3)
        Me.TabCollab.Controls.Add(Me.Label2)
        Me.TabCollab.Controls.Add(Me.TB_Fin)
        Me.TabCollab.Controls.Add(Me.TB_Embauche)
        Me.TabCollab.Controls.Add(Me.Quitter)
        Me.TabCollab.Controls.Add(Me.BTN_Back)
        Me.TabCollab.Controls.Add(Me.BTN_Valider)
        Me.TabCollab.Controls.Add(Me.GB_Civilite)
        Me.TabCollab.Controls.Add(Me.TB_Tel)
        Me.TabCollab.Controls.Add(Me.TB_Prenom)
        Me.TabCollab.Controls.Add(Me.TB_Nom)
        Me.TabCollab.Controls.Add(Me.TB_Ville)
        Me.TabCollab.Controls.Add(Me.TB_CP)
        Me.TabCollab.Controls.Add(Me.TB_CptAdresse)
        Me.TabCollab.Controls.Add(Me.TB_NumRue)
        Me.TabCollab.Controls.Add(Me.LB_Fin)
        Me.TabCollab.Controls.Add(Me.LB_Embauche)
        Me.TabCollab.Controls.Add(Me.Label1)
        Me.TabCollab.Controls.Add(Me.LB_Prénom)
        Me.TabCollab.Controls.Add(Me.LB_Nom)
        Me.TabCollab.Controls.Add(Me.LB_Ville)
        Me.TabCollab.Controls.Add(Me.LB_Cplt_Adresse)
        Me.TabCollab.Controls.Add(Me.LB_CP)
        Me.TabCollab.Controls.Add(Me.LB_Rue)
        Me.TabCollab.Controls.Add(Me.CB_Collabo)
        Me.TabCollab.Controls.Add(Me.RB_Ajout)
        Me.TabCollab.Controls.Add(Me.RB_Consult)
        Me.TabCollab.Controls.Add(Me.RB_Modif)
        Me.TabCollab.Location = New System.Drawing.Point(4, 22)
        Me.TabCollab.Name = "TabCollab"
        Me.TabCollab.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCollab.Size = New System.Drawing.Size(1025, 528)
        Me.TabCollab.TabIndex = 0
        Me.TabCollab.Text = "COLLABORATEUR"
        '
        'TB_Fin
        '
        Me.TB_Fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Fin.Location = New System.Drawing.Point(170, 366)
        Me.TB_Fin.Name = "TB_Fin"
        Me.TB_Fin.Size = New System.Drawing.Size(200, 22)
        Me.TB_Fin.TabIndex = 32
        '
        'TB_Embauche
        '
        Me.TB_Embauche.Location = New System.Drawing.Point(170, 340)
        Me.TB_Embauche.Name = "TB_Embauche"
        Me.TB_Embauche.Size = New System.Drawing.Size(200, 20)
        Me.TB_Embauche.TabIndex = 31
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Quitter.Image = CType(resources.GetObject("Quitter.Image"), System.Drawing.Image)
        Me.Quitter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Quitter.Location = New System.Drawing.Point(970, 464)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(43, 43)
        Me.Quitter.TabIndex = 30
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'BTN_Back
        '
        Me.BTN_Back.BackgroundImage = CType(resources.GetObject("BTN_Back.BackgroundImage"), System.Drawing.Image)
        Me.BTN_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Back.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_Back.Location = New System.Drawing.Point(970, 15)
        Me.BTN_Back.Name = "BTN_Back"
        Me.BTN_Back.Size = New System.Drawing.Size(43, 43)
        Me.BTN_Back.TabIndex = 29
        Me.BTN_Back.UseVisualStyleBackColor = True
        '
        'BTN_Valider
        '
        Me.BTN_Valider.Location = New System.Drawing.Point(395, 422)
        Me.BTN_Valider.Name = "BTN_Valider"
        Me.BTN_Valider.Size = New System.Drawing.Size(221, 58)
        Me.BTN_Valider.TabIndex = 28
        Me.BTN_Valider.Text = "ENREGISTRER"
        Me.BTN_Valider.UseVisualStyleBackColor = True
        '
        'GB_Civilite
        '
        Me.GB_Civilite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GB_Civilite.Controls.Add(Me.RB_Mr)
        Me.GB_Civilite.Controls.Add(Me.RB_Mme)
        Me.GB_Civilite.Controls.Add(Me.RB_Mlle)
        Me.GB_Civilite.Controls.Add(Me.LB_Civilite)
        Me.GB_Civilite.Location = New System.Drawing.Point(317, 163)
        Me.GB_Civilite.Name = "GB_Civilite"
        Me.GB_Civilite.Size = New System.Drawing.Size(348, 37)
        Me.GB_Civilite.TabIndex = 27
        Me.GB_Civilite.TabStop = False
        '
        'RB_Mr
        '
        Me.RB_Mr.AutoSize = True
        Me.RB_Mr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Mr.Location = New System.Drawing.Point(94, 12)
        Me.RB_Mr.Name = "RB_Mr"
        Me.RB_Mr.Size = New System.Drawing.Size(40, 20)
        Me.RB_Mr.TabIndex = 23
        Me.RB_Mr.TabStop = True
        Me.RB_Mr.Text = "M."
        Me.RB_Mr.UseVisualStyleBackColor = True
        '
        'RB_Mme
        '
        Me.RB_Mme.AutoSize = True
        Me.RB_Mme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Mme.Location = New System.Drawing.Point(151, 12)
        Me.RB_Mme.Name = "RB_Mme"
        Me.RB_Mme.Size = New System.Drawing.Size(56, 20)
        Me.RB_Mme.TabIndex = 22
        Me.RB_Mme.TabStop = True
        Me.RB_Mme.Text = "Mme"
        Me.RB_Mme.UseVisualStyleBackColor = True
        '
        'RB_Mlle
        '
        Me.RB_Mlle.AutoSize = True
        Me.RB_Mlle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Mlle.Location = New System.Drawing.Point(232, 12)
        Me.RB_Mlle.Name = "RB_Mlle"
        Me.RB_Mlle.Size = New System.Drawing.Size(51, 20)
        Me.RB_Mlle.TabIndex = 24
        Me.RB_Mlle.TabStop = True
        Me.RB_Mlle.Text = "Mlle"
        Me.RB_Mlle.UseVisualStyleBackColor = True
        '
        'LB_Civilite
        '
        Me.LB_Civilite.AutoSize = True
        Me.LB_Civilite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Civilite.Location = New System.Drawing.Point(14, 11)
        Me.LB_Civilite.Name = "LB_Civilite"
        Me.LB_Civilite.Size = New System.Drawing.Size(61, 20)
        Me.LB_Civilite.TabIndex = 8
        Me.LB_Civilite.Text = "Civilité :"
        '
        'TB_Tel
        '
        Me.TB_Tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Tel.Location = New System.Drawing.Point(170, 314)
        Me.TB_Tel.Name = "TB_Tel"
        Me.TB_Tel.Size = New System.Drawing.Size(200, 22)
        Me.TB_Tel.TabIndex = 21
        '
        'TB_Prenom
        '
        Me.TB_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Prenom.Location = New System.Drawing.Point(170, 288)
        Me.TB_Prenom.Name = "TB_Prenom"
        Me.TB_Prenom.Size = New System.Drawing.Size(200, 22)
        Me.TB_Prenom.TabIndex = 20
        '
        'TB_Nom
        '
        Me.TB_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Nom.Location = New System.Drawing.Point(170, 259)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(200, 22)
        Me.TB_Nom.TabIndex = 19
        '
        'TB_Ville
        '
        Me.TB_Ville.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Ville.Location = New System.Drawing.Point(717, 342)
        Me.TB_Ville.Name = "TB_Ville"
        Me.TB_Ville.Size = New System.Drawing.Size(218, 22)
        Me.TB_Ville.TabIndex = 17
        '
        'TB_CP
        '
        Me.TB_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CP.Location = New System.Drawing.Point(717, 314)
        Me.TB_CP.Name = "TB_CP"
        Me.TB_CP.Size = New System.Drawing.Size(218, 22)
        Me.TB_CP.TabIndex = 16
        '
        'TB_CptAdresse
        '
        Me.TB_CptAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CptAdresse.Location = New System.Drawing.Point(717, 288)
        Me.TB_CptAdresse.Name = "TB_CptAdresse"
        Me.TB_CptAdresse.Size = New System.Drawing.Size(218, 22)
        Me.TB_CptAdresse.TabIndex = 15
        '
        'TB_NumRue
        '
        Me.TB_NumRue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NumRue.Location = New System.Drawing.Point(717, 259)
        Me.TB_NumRue.Name = "TB_NumRue"
        Me.TB_NumRue.Size = New System.Drawing.Size(218, 22)
        Me.TB_NumRue.TabIndex = 14
        '
        'LB_Fin
        '
        Me.LB_Fin.AutoSize = True
        Me.LB_Fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Fin.Location = New System.Drawing.Point(13, 366)
        Me.LB_Fin.Name = "LB_Fin"
        Me.LB_Fin.Size = New System.Drawing.Size(149, 20)
        Me.LB_Fin.TabIndex = 13
        Me.LB_Fin.Text = "Date de fin contrat :"
        '
        'LB_Embauche
        '
        Me.LB_Embauche.AutoSize = True
        Me.LB_Embauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Embauche.Location = New System.Drawing.Point(19, 340)
        Me.LB_Embauche.Name = "LB_Embauche"
        Me.LB_Embauche.Size = New System.Drawing.Size(143, 20)
        Me.LB_Embauche.TabIndex = 12
        Me.LB_Embauche.Text = "Date d'embauche :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Téléphone :"
        '
        'LB_Prénom
        '
        Me.LB_Prénom.AutoSize = True
        Me.LB_Prénom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Prénom.Location = New System.Drawing.Point(90, 285)
        Me.LB_Prénom.Name = "LB_Prénom"
        Me.LB_Prénom.Size = New System.Drawing.Size(72, 20)
        Me.LB_Prénom.TabIndex = 10
        Me.LB_Prénom.Text = "Prénom :"
        '
        'LB_Nom
        '
        Me.LB_Nom.AutoSize = True
        Me.LB_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Nom.Location = New System.Drawing.Point(112, 259)
        Me.LB_Nom.Name = "LB_Nom"
        Me.LB_Nom.Size = New System.Drawing.Size(50, 20)
        Me.LB_Nom.TabIndex = 9
        Me.LB_Nom.Text = "Nom :"
        '
        'LB_Ville
        '
        Me.LB_Ville.AutoSize = True
        Me.LB_Ville.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Ville.Location = New System.Drawing.Point(665, 338)
        Me.LB_Ville.Name = "LB_Ville"
        Me.LB_Ville.Size = New System.Drawing.Size(46, 20)
        Me.LB_Ville.TabIndex = 7
        Me.LB_Ville.Text = "Ville :"
        '
        'LB_Cplt_Adresse
        '
        Me.LB_Cplt_Adresse.AutoSize = True
        Me.LB_Cplt_Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Cplt_Adresse.Location = New System.Drawing.Point(531, 286)
        Me.LB_Cplt_Adresse.Name = "LB_Cplt_Adresse"
        Me.LB_Cplt_Adresse.Size = New System.Drawing.Size(180, 20)
        Me.LB_Cplt_Adresse.TabIndex = 6
        Me.LB_Cplt_Adresse.Text = "Complement d'adresse :"
        '
        'LB_CP
        '
        Me.LB_CP.AutoSize = True
        Me.LB_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_CP.Location = New System.Drawing.Point(608, 314)
        Me.LB_CP.Name = "LB_CP"
        Me.LB_CP.Size = New System.Drawing.Size(103, 20)
        Me.LB_CP.TabIndex = 5
        Me.LB_CP.Text = "Code Postal :"
        '
        'LB_Rue
        '
        Me.LB_Rue.AutoSize = True
        Me.LB_Rue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Rue.Location = New System.Drawing.Point(600, 259)
        Me.LB_Rue.Name = "LB_Rue"
        Me.LB_Rue.Size = New System.Drawing.Size(111, 20)
        Me.LB_Rue.TabIndex = 4
        Me.LB_Rue.Text = "Numéro, Rue :"
        '
        'CB_Collabo
        '
        Me.CB_Collabo.FormattingEnabled = True
        Me.CB_Collabo.Location = New System.Drawing.Point(381, 73)
        Me.CB_Collabo.Name = "CB_Collabo"
        Me.CB_Collabo.Size = New System.Drawing.Size(235, 21)
        Me.CB_Collabo.TabIndex = 3
        '
        'RB_Ajout
        '
        Me.RB_Ajout.AutoSize = True
        Me.RB_Ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Ajout.Location = New System.Drawing.Point(604, 15)
        Me.RB_Ajout.Name = "RB_Ajout"
        Me.RB_Ajout.Size = New System.Drawing.Size(75, 28)
        Me.RB_Ajout.TabIndex = 2
        Me.RB_Ajout.TabStop = True
        Me.RB_Ajout.Text = "Créer"
        Me.RB_Ajout.UseVisualStyleBackColor = True
        '
        'RB_Consult
        '
        Me.RB_Consult.AutoSize = True
        Me.RB_Consult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Consult.Location = New System.Drawing.Point(454, 15)
        Me.RB_Consult.Name = "RB_Consult"
        Me.RB_Consult.Size = New System.Drawing.Size(108, 28)
        Me.RB_Consult.TabIndex = 1
        Me.RB_Consult.TabStop = True
        Me.RB_Consult.Text = "Consulter"
        Me.RB_Consult.UseVisualStyleBackColor = True
        '
        'RB_Modif
        '
        Me.RB_Modif.AutoSize = True
        Me.RB_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Modif.Location = New System.Drawing.Point(317, 15)
        Me.RB_Modif.Name = "RB_Modif"
        Me.RB_Modif.Size = New System.Drawing.Size(95, 28)
        Me.RB_Modif.TabIndex = 0
        Me.RB_Modif.TabStop = True
        Me.RB_Modif.Text = "Modifier"
        Me.RB_Modif.UseVisualStyleBackColor = True
        '
        'TabClient
        '
        Me.TabClient.BackColor = System.Drawing.Color.Linen
        Me.TabClient.Location = New System.Drawing.Point(4, 22)
        Me.TabClient.Name = "TabClient"
        Me.TabClient.Padding = New System.Windows.Forms.Padding(3)
        Me.TabClient.Size = New System.Drawing.Size(1025, 528)
        Me.TabClient.TabIndex = 1
        Me.TabClient.Text = "CLIENT"
        '
        'TabProjet
        '
        Me.TabProjet.BackColor = System.Drawing.Color.LightGray
        Me.TabProjet.Location = New System.Drawing.Point(4, 22)
        Me.TabProjet.Name = "TabProjet"
        Me.TabProjet.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProjet.Size = New System.Drawing.Size(1025, 528)
        Me.TabProjet.TabIndex = 2
        Me.TabProjet.Text = "PROJET"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(376, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(376, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(376, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(941, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(941, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(941, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "*"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1029, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Admin"
        Me.Text = "ADMINISTRATION"
        Me.TabControl1.ResumeLayout(False)
        Me.TabCollab.ResumeLayout(False)
        Me.TabCollab.PerformLayout()
        Me.GB_Civilite.ResumeLayout(False)
        Me.GB_Civilite.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabCollab As TabPage
    Friend WithEvents TabClient As TabPage
    Friend WithEvents TabProjet As TabPage
    Friend WithEvents RB_Mlle As RadioButton
    Friend WithEvents RB_Mr As RadioButton
    Friend WithEvents RB_Mme As RadioButton
    Friend WithEvents TB_Tel As TextBox
    Friend WithEvents TB_Prenom As TextBox
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents TB_Ville As TextBox
    Friend WithEvents TB_CP As TextBox
    Friend WithEvents TB_CptAdresse As TextBox
    Friend WithEvents TB_NumRue As TextBox
    Friend WithEvents LB_Fin As Label
    Friend WithEvents LB_Embauche As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LB_Prénom As Label
    Friend WithEvents LB_Nom As Label
    Friend WithEvents LB_Civilite As Label
    Friend WithEvents LB_Ville As Label
    Friend WithEvents LB_Cplt_Adresse As Label
    Friend WithEvents LB_CP As Label
    Friend WithEvents LB_Rue As Label
    Friend WithEvents CB_Collabo As ComboBox
    Friend WithEvents RB_Ajout As RadioButton
    Friend WithEvents RB_Consult As RadioButton
    Friend WithEvents RB_Modif As RadioButton
    Friend WithEvents GB_Civilite As GroupBox
    Friend WithEvents BTN_Valider As Button
    Friend WithEvents BTN_Back As Button
    Friend WithEvents Quitter As Button
    Friend WithEvents TB_Fin As TextBox
    Friend WithEvents TB_Embauche As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
