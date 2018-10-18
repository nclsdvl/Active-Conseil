Option Explicit On
Imports System.Data.SqlClient

Public Class Collaborateur



    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Remplissage_CB_Collabo(Me.CB_Collabo)



    End Sub
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
    '|----------------------------------------------------RECUPERATION : TEL + DATE EMBAUCHE + RUE + CP VILLE----------------------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|

    Private Sub CB_Collabo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Collabo.SelectedIndexChanged


        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)

        Dim monCollabo As String = CB_Collabo.SelectedItem

        Dim monNom() As String = Split(monCollabo)

        Recup_Tel(Me.LB_Phone, Me.CB_Collabo)
        Recup_Date_Embau(Me.LB_Embauche, Me.CB_Collabo)
        Recup_Rue(Me.LB_Rue, Me.CB_Collabo)
        Recup_Ville_CP(Me.LB_Ville, Me.LB_complement, Me.CB_Collabo)




        '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
        '|-----------------------------------------------------recuperation techno maitrisé par collabo--------------------------------------------------------------------|
        '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|


        Dim Mycommand3 As New SqlCommand()
        Mycommand3.Connection = maConnexion
        Mycommand3.CommandType = CommandType.StoredProcedure
        Mycommand3.CommandText = "PS_Liste_Techno_pour_un_Collaborateur"
        maConnexion.Open()

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



        '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
        '|--------------------------------------------Recup rue des projet par collaborateurs------------------------------------------------------------------------------|
        '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|

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


        '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
        '|------------------------------------------------------------Recup des chefs de projets --------------------------------------------------------------------------|
        '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|


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
        maConnexion.Close()


    End Sub

    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
    '|-----------------------------------------------------------------------QUIT AND BACK-----------------------------------------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Choix.Show()
        Me.Hide()
    End Sub


End Class