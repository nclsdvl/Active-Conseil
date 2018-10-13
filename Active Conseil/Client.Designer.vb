<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Collabo = New System.Windows.Forms.ComboBox()
        Me.COLLABORATEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActiveFinalCommunDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Active_Final_CommunDataSet = New WindowsApp1.Active_Final_CommunDataSet()
        Me.UTILISATEURSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COLLABORATEURTableAdapter = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.UTILISATEURSTableAdapter = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.UTILISATEURSTableAdapter()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.CollaborateurTableAdapter1 = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.CollaborateurTableAdapter2 = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.CollaborateurTableAdapter3 = New WindowsApp1.Active_Final_CommunDataSetTableAdapters.COLLABORATEURTableAdapter()
        Me.ActiveFinalCommunDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.COLLABORATEURBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.COLLABORATEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UTILISATEURSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLLABORATEURBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telephone :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date d'embauche :"
        '
        'CB_Collabo
        '
        Me.CB_Collabo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CB_Collabo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.COLLABORATEURBindingSource, "NOM_COLLABORATEUR", True))
        Me.CB_Collabo.DataSource = Me.COLLABORATEURBindingSource1
        Me.CB_Collabo.DisplayMember = "NOM_COLLABORATEUR"
        Me.CB_Collabo.FormattingEnabled = True
        Me.CB_Collabo.Location = New System.Drawing.Point(332, 45)
        Me.CB_Collabo.Name = "CB_Collabo"
        Me.CB_Collabo.Size = New System.Drawing.Size(217, 21)
        Me.CB_Collabo.TabIndex = 8
        Me.CB_Collabo.ValueMember = "NOM_COLLABORATEUR"
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
        'COLLABORATEURBindingSource1
        '
        Me.COLLABORATEURBindingSource1.DataMember = "COLLABORATEUR"
        Me.COLLABORATEURBindingSource1.DataSource = Me.ActiveFinalCommunDataSetBindingSource
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(866, 536)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.CB_Collabo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Client"
        Me.Text = "Client"
        CType(Me.COLLABORATEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Active_Final_CommunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UTILISATEURSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveFinalCommunDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLLABORATEURBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
