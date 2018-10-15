Option Explicit On
Imports System.Data.SqlClient

Public Class Collaborateur



    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Remplissage_CB_Collabo()


        '----------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub CB_Collabo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Collabo.SelectedIndexChanged

        'Dim maConnexion As New SqlConnection("Data Source=DESKTOP-KDV6P4O\SQLEXPRESS;Initial Catalog=Active_Final_Commun;Integrated Security=True")
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        '--------------------------------------------------------recup nom et prenom collabo-------------------------------------
        Dim monCollabo As String = CB_Collabo.SelectedItem

        Dim monNom() As String = Split(monCollabo)


        '----------------------------------------------recuperation tel collabo-------------------------------------------
        Dim Mycommand As SqlCommand = maConnexion.CreateCommand()
        Mycommand.CommandText = "select TELEPHONE_COLLABORATEUR as phone from COLLABORATEUR
                                    where NOM_COLLABORATEUR = '" & monNom(0) & "' 
                                    and PRENOM_COLLABORATEUR = '" & monNom(1) & "'"

        '-------------------------------------------Connexion-----------------------------------------------------
        maConnexion.Open()
        '-----------------------------------------------------------------------------------------------
        Dim Requete As String = Mycommand.ExecuteScalar
        Dim phone As String = Requete.ToString
        LB_Phone.Text = Mid(phone, 1, 2) & "-" & Mid(phone, 3, 2) & "-" & Mid(phone, 5, 2) & "-" & Mid(phone, 7, 2) & "-" & Mid(phone, 9, 2)

        '----------------------------------------------recuperation date embauche collabo-------------------------------------------
        Dim Mycommand2 As SqlCommand = maConnexion.CreateCommand()
        Mycommand2.CommandText = "select DATE_PREMIERE_EMBAUCHE as date from COLLABORATEUR
                                    where NOM_COLLABORATEUR = '" & monNom(0) & "' 
                                    and PRENOM_COLLABORATEUR = '" & monNom(1) & "'"

        Dim Requete2 As String
        If Mycommand2.ExecuteScalar Is DBNull.Value Then
            Requete2 = "Non Renseigné"
        Else Requete2 = Mycommand2.ExecuteScalar
        End If
        Dim dateE As String = Requete2.ToString
        LB_Embauche.Text = dateE
        '----------------------------------------------recuperation techno maitrisé par collabo-------------------------------------------
        Dim Mycommand3 As New SqlCommand()
        Mycommand3.Connection = maConnexion
        Mycommand3.CommandType = CommandType.StoredProcedure
        Mycommand3.CommandText = "PS_Liste_Techno_pour_un_Collaborateur"

        Dim valeurAjouter1 As SqlParameter = Mycommand3.Parameters.Add("@NomCollaborateur", SqlDbType.VarChar)
        valeurAjouter1.Value = monNom(0)

        Dim valeurAjouter2 As SqlParameter = Mycommand3.Parameters.Add("@PreNomCollaborateur", SqlDbType.VarChar)
        valeurAjouter2.Value = monNom(1)

        Dim myReader1 As SqlDataReader = Mycommand3.ExecuteReader()
        L_Techno.Items.Clear()
        Do While myReader1.Read()
            L_Techno.Items.Add(myReader1.GetString(0))
        Loop
        myReader1.Close()
        '--------------------------------------------Recup rue des collaborateurs-------------------------------------------------------

        Dim Mycommand4 As SqlCommand = maConnexion.CreateCommand()
        Mycommand4.CommandText = "Select RUE_ADRESSE1 from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & monNom(0) & "'and PRENOM_COLLABORATEUR = '" & monNom(1) & "'"

        Dim Requete4 As String = Mycommand4.ExecuteScalar
        Dim rue As String = Requete4.ToString
        LB_Rue.Text = rue
        '--------------------------------------------Recup CP + ville des collaborateurs-------------------------------------------------------
        'CP---------------------
        Dim Mycommand5 As SqlCommand = maConnexion.CreateCommand()
        Mycommand5.CommandText = "Select CP_ADRESSE from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & monNom(0) & "'and PRENOM_COLLABORATEUR = '" & monNom(1) & "'"

        Dim Requete5 As String = Mycommand5.ExecuteScalar
        Dim CP As String = Requete5.ToString

        'VILLE-----------------
        Dim Mycommand6 As SqlCommand = maConnexion.CreateCommand()
        Mycommand6.CommandText = "Select VILLE_ADRESSE from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & monNom(0) & "'and PRENOM_COLLABORATEUR = '" & monNom(1) & "'"

        Dim Requete6 As String = Mycommand6.ExecuteScalar
        Dim ville As String = Requete6.ToString

        LB_Ville.Text = CP & "  " & ville.ToUpper
        'COMPLEMENT-------------

        Dim Mycommand7 As SqlCommand = maConnexion.CreateCommand()
        Mycommand7.CommandText = "Select COMPLEMENT_ADRESSE2 from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & monNom(0) & "'and PRENOM_COLLABORATEUR = '" & monNom(1) & "'"

        Dim Requete7 As String

        If Mycommand7.ExecuteScalar Is DBNull.Value Then
            Requete7 = ""
        Else Requete7 = Mycommand7.ExecuteScalar
        End If
        Dim cplt As String = Requete7.ToString

        LB_complement.Text = cplt

        '--------------------------------------------Recup des projets par collabo------------------------------------------------------

        Dim Mycommand8 As New SqlCommand()
        Mycommand8.Connection = maConnexion
        Mycommand8.CommandType = CommandType.StoredProcedure
        Mycommand8.CommandText = "PS_Projet_Par_Collabo"

        Dim valeurAjouter3 As SqlParameter = Mycommand8.Parameters.Add("@NomCollaborateur", SqlDbType.VarChar)
        valeurAjouter3.Value = monNom(0)

        Dim valeurAjouter4 As SqlParameter = Mycommand8.Parameters.Add("@PreNomCollaborateur", SqlDbType.VarChar)
        valeurAjouter4.Value = monNom(1)

        Dim myReader2 As SqlDataReader = Mycommand8.ExecuteReader()
        L_Projet.Items.Clear()
        Do While myReader2.Read()
            L_Projet.Items.Add(myReader2.GetString(0))
        Loop
        myReader2.Close()

        '--------------------------------------------Recup des chefs de projets ------------------------------------------------------

        Dim Mycommand9 As SqlCommand = maConnexion.CreateCommand()
        Mycommand9.CommandText = "Select LIBELLE_LONG from PROJET, COLLABORATEUR
                                  where
                                  NOM_COLLABORATEUR = '" & monNom(0) & "'and PRENOM_COLLABORATEUR = '" & monNom(1) & "' and
                                  Collaborateur.ID_COLLABORATEUR = PROJET.ID_COLLABORATEUR"

        Dim myReader3 As SqlDataReader = Mycommand9.ExecuteReader()

        Do While myReader3.Read()

            L_Projet.Items.Add("*" & myReader3.GetString(0) & "*")
        Loop
        myReader3.Close()
    End Sub


    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Choix.Show()
        Me.Hide()
    End Sub
End Class