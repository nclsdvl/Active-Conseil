Imports System.Data.SqlClient

Public Class Admin




    Private Sub TabCollab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Remplissage_CB_Collabo(CB_Collabo)

        CB_Collabo.Hide()
        GB_Civilite.Hide()
        TB_CP.Hide()
        TB_CptAdresse.Hide()
        TB_Nom.Hide()
        TB_NumRue.Hide()
        TB_Prenom.Hide()
        TB_Tel.Hide()
        TB_Ville.Hide()
        DTP_embauche.Hide()
        DTP_Fin.Hide()




    End Sub

    Private Sub RB_Modif_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Modif.CheckedChanged

        CB_Collabo.Show()
        GB_Civilite.Show()
        TB_CP.Show()
        TB_CptAdresse.Show()
        TB_Nom.Show()
        TB_NumRue.Show()
        TB_Prenom.Show()
        TB_Tel.Show()
        TB_Ville.Show()
        DTP_embauche.Show()
        DTP_Fin.Show()
        DTP_Fin.Format = DateTimePickerFormat.Custom
        DTP_Fin.CustomFormat = " "
        BTN_Valider.Show()

        GB_Civilite.Enabled = True
        GB_Civilite.Enabled = True
        TB_CP.Enabled = True
        TB_CptAdresse.Enabled = True
        TB_Nom.Enabled = True
        TB_NumRue.Enabled = True
        TB_Prenom.Enabled = True
        TB_Tel.Enabled = True
        TB_Ville.Enabled = True
        DTP_embauche.Enabled = True
        DTP_Fin.Enabled = True


        If CB_Collabo.SelectedIndex <> -1 Then

            Recup_Rue(Me.TB_NumRue, Me.CB_Collabo)
            Recup_Date_Embau(Me.DTP_embauche, Me.CB_Collabo)
            Recup_Tel(Me.TB_Tel, Me.CB_Collabo)
            Recup_Ville_CP(Me.TB_Ville, Me.TB_CptAdresse, Me.CB_Collabo)

        End If
    End Sub

    Private Sub RB_Ajout_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Ajout.CheckedChanged
        CB_Collabo.Hide()
        GB_Civilite.Show()
        TB_CP.Show()
        TB_CptAdresse.Show()
        TB_Nom.Show()
        TB_NumRue.Show()
        TB_Prenom.Show()
        TB_Tel.Show()
        TB_Ville.Show()
        DTP_embauche.Show()
        DTP_Fin.Show()
        BTN_Valider.Show()

        GB_Civilite.Enabled = True
        GB_Civilite.Enabled = True
        TB_CP.Enabled = True
        TB_CptAdresse.Enabled = True
        TB_Nom.Enabled = True
        TB_NumRue.Enabled = True
        TB_Prenom.Enabled = True
        TB_Tel.Enabled = True
        TB_Ville.Enabled = True
        DTP_embauche.Enabled = True
        DTP_Fin.Enabled = True
    End Sub

    Private Sub RB_Consult_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Consult.CheckedChanged
        CB_Collabo.Show()
        GB_Civilite.Show()
        TB_CP.Show()
        TB_CptAdresse.Show()
        TB_Nom.Show()
        TB_NumRue.Show()
        TB_Prenom.Show()
        TB_Tel.Show()
        TB_Ville.Show()
        BTN_Valider.Hide()

        GB_Civilite.Enabled = False
        GB_Civilite.Enabled = False
        TB_CP.Enabled = False
        TB_CptAdresse.Enabled = False
        TB_Nom.Enabled = False
        TB_NumRue.Enabled = False
        TB_Prenom.Enabled = False
        TB_Tel.Enabled = False
        TB_Ville.Enabled = False
        DTP_embauche.Enabled = False
        DTP_Fin.Enabled = False
    End Sub

    Private Sub BTN_Back_Click(sender As Object, e As EventArgs) Handles BTN_Back.Click
        Choix.Show()
        Me.Hide()

    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Close()
    End Sub

    Private Sub CB_Collabo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Collabo.SelectedIndexChanged


    End Sub
End Class