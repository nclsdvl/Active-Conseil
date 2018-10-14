<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Collaborateur
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Collaborateur))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Collabo = New System.Windows.Forms.ComboBox()
        Me.COLLABORATEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActiveFinalCommunDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Active_Final_CommunDataSet = New WindowsApp1.Active_Final_CommunDataSet()
        Me.COLLABORATEURBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UTILISATEURSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COLLABORATEURTableAdapter = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.UTILISATEURSTableAdapter = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.UTILISATEURSTableAdapter()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.CollaborateurTableAdapter1 = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.CollaborateurTableAdapter2 = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.CollaborateurTableAdapter3 = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.ActiveFinalCommunDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LB_Phone = New System.Windows.Forms.Label()
        Me.LB_Embauche = New System.Windows.Forms.Label()
        Me.LB_Techno = New System.Windows.Forms.Label()
        Me.L_Techno = New System.Windows.Forms.ListBox()
        Me.LB_Adresse = New System.Windows.Forms.Label()
        Me.LB_Rue = New System.Windows.Forms.Label()
        Me.LB_Ville = New System.Windows.Forms.Label()
        Me.LB_complement = New System.Windows.Forms.Label()
        Me.L_Projet = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.COLLABORATEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLLABORATEURBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UTILISATEURSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telephone :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date d'embauche :"
        '
        'CB_Collabo
        '
        Me.CB_Collabo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CB_Collabo.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Collabo.FormattingEnabled = True
        Me.CB_Collabo.Location = New System.Drawing.Point(322, 62)
        Me.CB_Collabo.Name = "CB_Collabo"
        Me.CB_Collabo.Size = New System.Drawing.Size(217, 22)
        Me.CB_Collabo.TabIndex = 8
        '
        'COLLABORATEURBindingSource
        '
        Me.COLLABORATEURBindingSource.DataMember = "COLLABORATEUR"
        Me.COLLABORATEURBindingSource.DataSource = Me.ActiveFinalCommunDataSetBindingSource
        '
        'ActiveFinalCommunDataSetBindingSource
        '
        Me.ActiveFinalCommunDataSetBindingSource.DataSource = Me.Active_Final_CommunDataSet
        Me.ActiveFinalCommunDataSetBindingSource.Position = 0
        '
        'Active_Final_CommunDataSet
        '
        Me.Active_Final_CommunDataSet.DataSetName = "Active_Final_CommunDataSet"
        Me.Active_Final_CommunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COLLABORATEURBindingSource1
        '
        Me.COLLABORATEURBindingSource1.DataMember = "COLLABORATEUR"
        Me.COLLABORATEURBindingSource1.DataSource = Me.ActiveFinalCommunDataSetBindingSource
        '
        'UTILISATEURSBindingSource
        '
        Me.UTILISATEURSBindingSource.DataMember = "UTILISATEURS"
        Me.UTILISATEURSBindingSource.DataSource = Me.ActiveFinalCommunDataSetBindingSource
        '
        'COLLABORATEURTableAdapter
        '
        Me.COLLABORATEURTableAdapter.ClearBeforeFill = True
        '
        'UTILISATEURSTableAdapter
        '
        Me.UTILISATEURSTableAdapter.ClearBeforeFill = True
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Quitter.Image = CType(resources.GetObject("Quitter.Image"), System.Drawing.Image)
        Me.Quitter.Location = New System.Drawing.Point(811, 481)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(43, 43)
        Me.Quitter.TabIndex = 9
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'CollaborateurTableAdapter1
        '
        Me.CollaborateurTableAdapter1.ClearBeforeFill = True
        '
        'CollaborateurTableAdapter2
        '
        Me.CollaborateurTableAdapter2.ClearBeforeFill = True
        '
        'CollaborateurTableAdapter3
        '
        Me.CollaborateurTableAdapter3.ClearBeforeFill = True
        '
        'ActiveFinalCommunDataSetBindingSource1
        '
        Me.ActiveFinalCommunDataSetBindingSource1.DataSource = Me.Active_Final_CommunDataSet
        Me.ActiveFinalCommunDataSetBindingSource1.Position = 0
        '
        'LB_Phone
        '
        Me.LB_Phone.AutoSize = True
        Me.LB_Phone.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Phone.Location = New System.Drawing.Point(184, 152)
        Me.LB_Phone.Name = "LB_Phone"
        Me.LB_Phone.Size = New System.Drawing.Size(0, 17)
        Me.LB_Phone.TabIndex = 10
        '
        'LB_Embauche
        '
        Me.LB_Embauche.AutoSize = True
        Me.LB_Embauche.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Embauche.Location = New System.Drawing.Point(184, 208)
        Me.LB_Embauche.Name = "LB_Embauche"
        Me.LB_Embauche.Size = New System.Drawing.Size(0, 17)
        Me.LB_Embauche.TabIndex = 11
        '
        'LB_Techno
        '
        Me.LB_Techno.AutoSize = True
        Me.LB_Techno.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Techno.Location = New System.Drawing.Point(87, 296)
        Me.LB_Techno.Name = "LB_Techno"
        Me.LB_Techno.Size = New System.Drawing.Size(186, 18)
        Me.LB_Techno.TabIndex = 12
        Me.LB_Techno.Text = "Technologies Maitrisées :"
        '
        'L_Techno
        '
        Me.L_Techno.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.L_Techno.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Techno.FormattingEnabled = True
        Me.L_Techno.ItemHeight = 17
        Me.L_Techno.Location = New System.Drawing.Point(90, 333)
        Me.L_Techno.Name = "L_Techno"
        Me.L_Techno.Size = New System.Drawing.Size(174, 191)
        Me.L_Techno.TabIndex = 13
        '
        'LB_Adresse
        '
        Me.LB_Adresse.AutoSize = True
        Me.LB_Adresse.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Adresse.Location = New System.Drawing.Point(409, 151)
        Me.LB_Adresse.Name = "LB_Adresse"
        Me.LB_Adresse.Size = New System.Drawing.Size(83, 18)
        Me.LB_Adresse.TabIndex = 14
        Me.LB_Adresse.Text = "Adresse :"
        '
        'LB_Rue
        '
        Me.LB_Rue.AutoSize = True
        Me.LB_Rue.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Rue.Location = New System.Drawing.Point(498, 153)
        Me.LB_Rue.Name = "LB_Rue"
        Me.LB_Rue.Size = New System.Drawing.Size(0, 17)
        Me.LB_Rue.TabIndex = 15
        '
        'LB_Ville
        '
        Me.LB_Ville.AutoSize = True
        Me.LB_Ville.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Ville.Location = New System.Drawing.Point(498, 187)
        Me.LB_Ville.Name = "LB_Ville"
        Me.LB_Ville.Size = New System.Drawing.Size(0, 17)
        Me.LB_Ville.TabIndex = 16
        '
        'LB_complement
        '
        Me.LB_complement.AutoSize = True
        Me.LB_complement.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_complement.Location = New System.Drawing.Point(498, 170)
        Me.LB_complement.Name = "LB_complement"
        Me.LB_complement.Size = New System.Drawing.Size(0, 17)
        Me.LB_complement.TabIndex = 17
        '
        'L_Projet
        '
        Me.L_Projet.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.L_Projet.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Projet.FormattingEnabled = True
        Me.L_Projet.ItemHeight = 14
        Me.L_Projet.Location = New System.Drawing.Point(354, 333)
        Me.L_Projet.Name = "L_Projet"
        Me.L_Projet.Size = New System.Drawing.Size(425, 186)
        Me.L_Projet.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(524, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Projets :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(470, 522)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "* En tant que chef de projet"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(293, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Veuillez choisir un collaborateur :"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(811, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 47)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Collaborateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(866, 536)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.L_Projet)
        Me.Controls.Add(Me.LB_complement)
        Me.Controls.Add(Me.LB_Ville)
        Me.Controls.Add(Me.LB_Rue)
        Me.Controls.Add(Me.LB_Adresse)
        Me.Controls.Add(Me.L_Techno)
        Me.Controls.Add(Me.LB_Techno)
        Me.Controls.Add(Me.LB_Embauche)
        Me.Controls.Add(Me.LB_Phone)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.CB_Collabo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Collaborateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collaborateur"
        CType(Me.COLLABORATEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLLABORATEURBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UTILISATEURSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_Collabo As ComboBox
    Friend WithEvents ActiveFinalCommunDataSetBindingSource As BindingSource
    Friend WithEvents Active_Final_CommunDataSet As Active_Final_CommunDataSet
    Friend WithEvents COLLABORATEURBindingSource As BindingSource
    Friend WithEvents COLLABORATEURTableAdapter As Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter
    Friend WithEvents UTILISATEURSBindingSource As BindingSource
    Friend WithEvents UTILISATEURSTableAdapter As Active_Final_CommunDataSetTableAdapters.UTILISATEURSTableAdapter
    Friend WithEvents Quitter As Button
    Friend WithEvents CollaborateurTableAdapter1 As Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter
    Friend WithEvents CollaborateurTableAdapter2 As Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter
    Friend WithEvents CollaborateurTableAdapter3 As Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter
    Friend WithEvents COLLABORATEURBindingSource1 As BindingSource
    Friend WithEvents ActiveFinalCommunDataSetBindingSource1 As BindingSource
    Friend WithEvents LB_Phone As Label
    Friend WithEvents LB_Embauche As Label
    Friend WithEvents LB_Techno As Label
    Friend WithEvents L_Techno As ListBox
    Friend WithEvents LB_Adresse As Label
    Friend WithEvents LB_Rue As Label
    Friend WithEvents LB_Ville As Label
    Friend WithEvents LB_complement As Label
    Friend WithEvents L_Projet As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
