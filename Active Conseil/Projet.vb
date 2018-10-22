Imports System.Data.SqlClient

Public Class Projet
    Dim Connexion As New SqlConnection(str_chaine_de_connexion)


    Private Sub LB_Projet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Try
            Connexion.Open()

            Dim Requete As String = "SELECT * from PROJET ORDER BY ID_PROJET"
            Dim Requete2 As String = "SELECT * FROM COLLABORATEUR"

            Dim Commande As New SqlCommand(Requete, Connexion)
            Dim Adaptateur As New SqlDataAdapter(Commande)
            Dim MonDataSet As New DataSet
            Try

                Adaptateur.Fill(MonDataSet, "PROJET")
                Adaptateur.Fill(MonDataSet, "COLLABO")
                For Each Ligne As DataRow In MonDataSet.Tables("PROJET").Rows()
                    LB_Projet.Items.Add(Ligne("ID_PROJET").ToString & " - " & Ligne("LIBELLE_LONG").ToString)
                Next

            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try




        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub LB_Projet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Projet.SelectedIndexChanged

        LB_Techno.Items.Clear()
        LB_Collab.Items.Clear()
        LB_Doc.Items.Clear()
        LB_Resume.Text = ""
        LB_Auteur.Text = ""
        LB_Date.Text = ""

        Dim Chaine_Projet() As String = Split(LB_Projet.SelectedItem)
        Dim ID_Projet As String = Chaine_Projet(0)

        '------------------------------------------      RECUP CHEF DE PROJET     -------------------------------------------

        Dim Requete_Chef As String = "SELECT NOM_COLLABORATEUR +' '+ PRENOM_COLLABORATEUR FROM COLLABORATEUR INNER JOIN PROJET ON COLLABORATEUR.ID_COLLABORATEUR = PROJET.ID_COLLABORATEUR where ID_PROJET = " + ID_Projet
        Dim Commande_Chef As New SqlCommand(Requete_Chef, Connexion)
        LB_Chef.Text = Commande_Chef.ExecuteScalar.ToString

        '---------------------------------------------     RECUP NOM CLIENT    -------------------------------------------

        Dim Requete_Client As String = "SELECT RAISON_SOCIALE FROM CLIENT INNER JOIN PROJET ON PROJET.ID_CLIENT = CLIENT.ID_CLIENT where ID_PROJET =" + ID_Projet
        Dim Commande_Client As New SqlCommand(Requete_Client, Connexion)
        LB_Client.Text = Commande_Client.ExecuteScalar.ToString.ToUpper.Replace("_", " ")

        '---------------------------------------------     REMPLISSAGE TECHNOLOGIES UTILISEES    -------------------------------------------

        Dim Mycommand As New SqlCommand("PS_Liste_Techno_Projet", Connexion)
        Mycommand.CommandType = CommandType.StoredProcedure
        Mycommand.Parameters.Add(New SqlParameter("@NumeroDuProjet", SqlDbType.VarChar))
        Mycommand.Parameters("@NumeroDuProjet").Value = ID_Projet
        Dim Adaptateur As New SqlDataAdapter(Mycommand)
        Dim MonDataSet As New DataSet
        Try
            Adaptateur.Fill(MonDataSet, "Techno_Par_Projet")
            For Each Ligne As DataRow In MonDataSet.Tables("Techno_Par_Projet").Rows()
                LB_Techno.Items.Add(Ligne("LIBELLE_TECHNOLOGIE").ToString)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        '---------------------------------------------     RECUP CYCLE DE VIE PROJET    -------------------------------------------

        Dim Requete_Cycle As String = "SELECT LIBELLE_CYCLE FROM CYCLE_DE_VIE INNER JOIN PROJET ON CYCLE_DE_VIE.ID_CYCLE = PROJET.ID_CYCLE where ID_PROJET = " + ID_Projet
        Dim Commande_Cycle As New SqlCommand(Requete_Cycle, Connexion)
        LB_Cycle.Text = Commande_Cycle.ExecuteScalar.ToString.ToUpper

        '---------------------------------------------     RECUP DATE PROJET    -------------------------------------------

        Dim Requete_Debut As String = "SELECT DATE_PREVISIONNELLE_DEBUT FROM PROJET where ID_PROJET = " + ID_Projet
        Dim Commande_Debut As New SqlCommand(Requete_Debut, Connexion)
        LB_Deb.Text = "(Prévue : " + Mid(Commande_Debut.ExecuteScalar.ToString.ToUpper, 1, 10) + " )"

        Dim Requete_Fin As String = "SELECT DATE_PREVISIONNELLE_FIN FROM PROJET where ID_PROJET = " + ID_Projet
        Dim Commande_Fin As New SqlCommand(Requete_Fin, Connexion)
        LB_Fin.Text = "(Prévue : " + Mid(Commande_Fin.ExecuteScalar.ToString.ToUpper, 1, 10) + " )"

        Dim Requete_Debut_reel As String = "SELECT DATE_REELLE_DEBUT FROM PROJET where ID_PROJET = " + ID_Projet
        Dim Commande_Debut_reel As New SqlCommand(Requete_Debut_reel, Connexion)
        LB_Deb_Reel.Text = Mid(Commande_Debut_reel.ExecuteScalar.ToString.ToUpper, 1, 10)

        Dim Requete_Fin_Reel As String = "SELECT DATE_REELLE_FIN FROM PROJET where ID_PROJET = " + ID_Projet
        Dim Commande_Fin_Reel As New SqlCommand(Requete_Fin_Reel, Connexion)
        LB_Fin_Reel.Text = Mid(Commande_Fin_Reel.ExecuteScalar.ToString.ToUpper, 1, 10)

        '---------------------------------------------     RECUP SECTEUR D'ACTIVITE DU PROJET    -------------------------------------------

        Dim Requete_Secteur As String = "select LIBELLE_SECTEURACTIVITE from SECTEUR_ACTIVITE
                                         inner Join A_POUR_SECTEUR on SECTEUR_ACTIVITE.ID_SECTEUR_ACTIVITE = A_POUR_SECTEUR.ID_SECTEUR_ACTIVITE
                                         inner Join PROJET on A_POUR_SECTEUR.ID_PROJET = PROJET.ID_PROJET
                                         where Projet.ID_PROJET = " + ID_Projet
        Dim Commande_Secteur As New SqlCommand(Requete_Secteur, Connexion)
        LB_Secteur.Text = Commande_Secteur.ExecuteScalar.ToString.ToUpper


        '---------------------------------------------     RECUP TAILLE EQUIPE    -------------------------------------------

        Dim Requete_Equipe As String = "SELECT TAILLE_MAXI_EQUIPE FROM PROJET where ID_PROJET = " + ID_Projet
        Dim Commande_Equipe As New SqlCommand(Requete_Equipe, Connexion)
        LB_Equipe.Text = Commande_Equipe.ExecuteScalar.ToString

        '---------------------------------------------     RECUP TAILLE EN LIGNE DE CODE    -------------------------------------------

        Dim Requete_Nbr_Ligne As String = "SELECT TAILLE_LIGNES_DE_CODE FROM PROJET where ID_PROJET = " + ID_Projet
        Dim Commande_Nbr_Ligne As New SqlCommand(Requete_Nbr_Ligne, Connexion)
        LB_Nbr_Ligne.Text = Commande_Nbr_Ligne.ExecuteScalar.ToString


        '---------------------------------------------     REMPLISSAGE DES COLLABO CONCERNE    -------------------------------------------

        Dim Mycommand1 As New SqlCommand("PS_COLLABO_PAR_PROJET", Connexion)
        Mycommand1.CommandType = CommandType.StoredProcedure
        Mycommand1.Parameters.Add(New SqlParameter("@ID_Projet", SqlDbType.Int))
        Mycommand1.Parameters("@ID_Projet").Value = ID_Projet
        Dim Adaptateur1 As New SqlDataAdapter(Mycommand1)
        Dim MonDataSet1 As New DataSet
        Try
            Adaptateur1.Fill(MonDataSet1, "Collabo_Par_Projet")
            For Each Ligne As DataRow In MonDataSet1.Tables("Collabo_Par_Projet").Rows()
                LB_Collab.Items.Add(Ligne("nom_collab").ToString)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try






        '---------------------------------------------     REMPLISSAGE DE LA DOCUMENTATION    -------------------------------------------

        Dim Mycommand2 As New SqlCommand("PS_DOC_PAR_PROJET", Connexion)
        Mycommand2.CommandType = CommandType.StoredProcedure
        Mycommand2.Parameters.Add(New SqlParameter("@ID_Projet", SqlDbType.Int))
        Mycommand2.Parameters("@ID_Projet").Value = ID_Projet
        Dim Adaptateur2 As New SqlDataAdapter(Mycommand2)
        Dim MonDataSet2 As New DataSet
        Try
            Adaptateur2.Fill(MonDataSet2, "Collab_Par_Projet")
            For Each Ligne1 As DataRow In MonDataSet2.Tables("Collab_Par_Projet").Rows()
                LB_Doc.Items.Add(Ligne1("TITRE_DOCUMENT").ToString)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try




    End Sub
    '---------------------------------------------     RECUPERATION DE L'AUTEUR DE LA DOC   -------------------------------------------

    Private Sub LB_Doc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Doc.SelectedIndexChanged
        LB_Resume.Text = ""
        LB_Auteur.Text = ""
        LB_Date.Text = ""

        '---------Recup de l'id_doc
        Dim ID_Nom_doc As String = LB_Doc.SelectedItem
        Dim Requete_ID_Doc As String = "SELECT ID_DOCUMENT FROM DOCUMENT WHERE TITRE_DOCUMENT = '" + ID_Nom_doc + "'"
        Dim Commande_ID_Doc As New SqlCommand(Requete_ID_Doc, Connexion)
        Dim ID_Document As String = Commande_ID_Doc.ExecuteScalar.ToString


        '---------Recup de l'auteur
        Dim Requete_Auteur_Doc As String = "select NOM_COLLABORATEUR +' '+ PRENOM_COLLABORATEUR from COLLABORATEUR
                                            join ECRIT on COLLABORATEUR.ID_COLLABORATEUR = ECRIT.ID_COLLABORATEUR
                                            join DOCUMENT on ECRIT.ID_DOCUMENT = DOCUMENT.ID_DOCUMENT
                                            where DOCUMENT.ID_DOCUMENT =  " + ID_Document
        Dim Commande_Auteur As New SqlCommand(Requete_Auteur_Doc, Connexion)
        LB_Auteur.Text = Commande_Auteur.ExecuteScalar.ToString

        '---------Recup du resumé
        Dim Requete_Resume As String = "SELECT RESUME_DOCUMENT FROM DOCUMENT WHERE TITRE_DOCUMENT = '" + ID_Nom_doc + "'"
        Dim Commande_resume As New SqlCommand(Requete_Resume, Connexion)
        LB_Resume.Text = Commande_resume.ExecuteScalar.ToString

        '--------Recup de la date de publication
        Dim Requete_Date As String = "SELECT DATE_DIFFUSION FROM DOCUMENT WHERE TITRE_DOCUMENT = '" + ID_Nom_doc + "'"
        Dim Commande_Date As New SqlCommand(Requete_Date, Connexion)
        LB_Date.Text = Mid(Commande_date.ExecuteScalar.ToString.ToUpper, 1, 10)


    End Sub


    '--------------------------------      RECUP DES INFOS ETAPES ET INTERVENTION A PARTIR DU COLLABO CHOISI       -------------------------

    Private Sub LB_Collab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Collab.SelectedIndexChanged

        '------Recup de l'id collabo
        Dim chaine_Nom() As String = Split(LB_Collab.SelectedItem)

        Dim Requete_ID_Collabo As String = "SELECT ID_COLLABORATEUR FROM COLLABORATEUR WHERE PRENOM_COLLABORATEUR = '" + chaine_Nom(1) + "' and NOM_COLLABORATEUR = '" + chaine_Nom(0) + "'"
        Dim Commande_ID_Collabo As New SqlCommand(Requete_ID_Collabo, Connexion)
        Dim ID_Collabo As Int16 = Commande_ID_Collabo.ExecuteScalar




    End Sub




    Private Sub BTN_Back_Click(sender As Object, e As EventArgs) Handles BTN_Back.Click
        Choix.Show()
        Me.Hide()
    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Close()
    End Sub
End Class