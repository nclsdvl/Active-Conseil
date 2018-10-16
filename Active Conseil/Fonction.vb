Imports System.Data.SqlClient

Module Fonction_Recuperation_Donnees


    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
    '|--------------------------------------------------------------------REMPLISSAGE CBBOX COLLABORATEURS ------------------------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|


    Public Function Remplissage_CB_Collabo(nomForm As ComboBox)

        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)

        Try
            Dim Mycommand As SqlCommand = maConnexion.CreateCommand()
            Mycommand.CommandText = "select NOM_COLLABORATEUR, PRENOM_COLLABORATEUR, ID_COLLABORATEUR from COLLABORATEUR order by NOM_COLLABORATEUR"
            maConnexion.Open()
            Dim myReader As SqlDataReader = Mycommand.ExecuteReader()
            nomForm.Items.Clear()
            Do While myReader.Read()
                Dim tmp_chaine As String
                tmp_chaine = myReader.GetString(0) + " " + myReader.GetString(1) + " (" + myReader.GetValue(2).ToString() + ")"
                nomForm.Items.Add(tmp_chaine)
            Loop
            myReader.Close()
            maConnexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
    '|-------------------------------------------RECUPERATION ET AFFECTATION DU NOM ET PRENOM COLLABORATEUR  ----------------------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|

    Public Function Recup_Nom_Prenom(TB_Nom As TextBox, TB_Prenom As TextBox, CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem

        Dim chaineNom() As String = Split(monCollabo)

        TB_Nom.Text = chaineNom(0)
        TB_Prenom.Text = chaineNom(1)

    End Function

    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
    '|-------------------------------------------RECUPERATION ET AFFECTATION DU TELEPHONE COLLABORATEUR (POLYMORPHE) --------------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|


    '--------------------------------------------ARGUMENT (LB, CB)------------------------------------------

    Public Function Recup_Tel(LB_Phone As Label, CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem

        Dim chaineNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)

        Dim Mycommand As SqlCommand = maConnexion.CreateCommand()
        Mycommand.CommandText = "select TELEPHONE_COLLABORATEUR as phone from COLLABORATEUR
                                    where NOM_COLLABORATEUR = '" & chaineNom(0) & "' 
                                    and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"

        maConnexion.Open()

        Dim Requete As String = Mycommand.ExecuteScalar
        Dim phone As String = Requete.ToString
        LB_Phone.Text = Mid(phone, 1, 2) & "-" & Mid(phone, 3, 2) & "-" & Mid(phone, 5, 2) & "-" & Mid(phone, 7, 2) & "-" & Mid(phone, 9, 2)
        maConnexion.Close()

    End Function

    '--------------------------------------------ARGUMENT (TB, CB)----------------------------------------------

    Public Function Recup_Tel(TB_Tel As TextBox, CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem

        Dim chaineNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)

        Dim Mycommand As SqlCommand = maConnexion.CreateCommand()
        Mycommand.CommandText = "select TELEPHONE_COLLABORATEUR as phone from COLLABORATEUR
                                    where NOM_COLLABORATEUR = '" & chaineNom(0) & "' 
                                    and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"

        maConnexion.Open()

        Dim Requete As String = Mycommand.ExecuteScalar
        Dim phone As String = Requete.ToString
        TB_Tel.Text = Mid(phone, 1, 2) & "-" & Mid(phone, 3, 2) & "-" & Mid(phone, 5, 2) & "-" & Mid(phone, 7, 2) & "-" & Mid(phone, 9, 2)
        maConnexion.Close()

    End Function

    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
    '|-------------------------------------------RECUPERATION ET AFFECTATION DE DATE EMBAUCHE COLLABORATEUR (POLYMORPHE) ----------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|


    '-----------------------------------------------ARGUMENT (LB, CB)-----------------------------------------------------------------


    Public Function Recup_Date_Embau(LB_Embauche As Label, CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand2 As SqlCommand = maConnexion.CreateCommand()
        Mycommand2.CommandText = "select DATE_PREMIERE_EMBAUCHE as date from COLLABORATEUR
                                    where NOM_COLLABORATEUR = '" & chaineNom(0) & "' 
                                    and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"
        maConnexion.Open()
        Dim Requete2 As String
        If Mycommand2.ExecuteScalar Is DBNull.Value Then
            Requete2 = "Non Renseigné"
        Else Requete2 = Mycommand2.ExecuteScalar
        End If
        Dim dateE As String = Requete2.ToString
        LB_Embauche.Text = dateE
        maConnexion.Close()

    End Function


    '-----------------------------------------------------ARGUMENT (TB, CB)-----------------------------------------------------------------


    Public Function Recup_Date_Embau(TB_embauche As TextBox, CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand2 As SqlCommand = maConnexion.CreateCommand()
        Mycommand2.CommandText = "select DATE_PREMIERE_EMBAUCHE as date from COLLABORATEUR
                                    where NOM_COLLABORATEUR = '" & chaineNom(0) & "' 
                                    and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"
        maConnexion.Open()
        Dim Requete2 As String
        If Mycommand2.ExecuteScalar Is DBNull.Value Then
            Requete2 = "00/00/0000"
        Else Requete2 = Mycommand2.ExecuteScalar
        End If
        Dim dateE As String = Requete2.ToString
        TB_embauche.Text = dateE
        maConnexion.Close()

    End Function

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------RECUPERATION ET AFFECTATION DE NUM ET RUE DE L'ADRESSE (POLYMORPHE) --------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------


    '------------------------------------------------ARGUMENT (LB, CB)----------------------------------------------------------------------------------------


    Public Function Recup_Rue(LB_Rue As Label, CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand4 As SqlCommand = maConnexion.CreateCommand()
        Mycommand4.CommandText = "Select RUE_ADRESSE1 from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & chaineNom(0) & "'and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"
        maConnexion.Open()
        Dim Requete4 As String = Mycommand4.ExecuteScalar
        Dim rue As String = Requete4.ToString
        LB_Rue.Text = rue.ToUpper
        maConnexion.Close()

    End Function


    '-------------------------------------------------------------ARGUMENT (TB, CB)------------------------------------------------------------


    Public Function Recup_Rue(TB_NumRue As TextBox, CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand4 As SqlCommand = maConnexion.CreateCommand()
        Mycommand4.CommandText = "Select RUE_ADRESSE1 from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & chaineNom(0) & "'and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"
        maConnexion.Open()
        Dim Requete4 As String = Mycommand4.ExecuteScalar
        Dim rue As String = Requete4.ToString
        TB_NumRue.Text = rue.ToUpper
        maConnexion.Close()

    End Function



    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------RECUPERATION ET AFFECTATION DU COMPLEMENT + CODE POSTAL + VILLE DE L'ADRESSE (POLYMORPHE) -------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------


    '------------------------------------------------------ARGUMENT (LB, LB, CB)---------------------------------------------------

    Public Function Recup_Ville_CP(LB_Ville As Label, LB_complement As Label, CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)

        maConnexion.Open()

        '-- CODE POSTAL --

        Dim Mycommand5 As SqlCommand = maConnexion.CreateCommand()
        Mycommand5.CommandText = "Select CP_ADRESSE from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & chaineNom(0) & "'and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"

        Dim Requete5 As String = Mycommand5.ExecuteScalar
        Dim CP As String = Requete5.ToString

        '-- VILLE --

        Dim Mycommand6 As SqlCommand = maConnexion.CreateCommand()
        Mycommand6.CommandText = "Select VILLE_ADRESSE from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & chaineNom(0) & "'and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"

        Dim Requete6 As String = Mycommand6.ExecuteScalar
        Dim ville As String = Requete6.ToString

        LB_Ville.Text = CP & "  " & ville.ToUpper

        '-- COMPLEMENT --

        Dim Mycommand7 As SqlCommand = maConnexion.CreateCommand()
        Mycommand7.CommandText = "Select COMPLEMENT_ADRESSE2 from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & chaineNom(0) & "'and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"

        Dim Requete7 As String

        If Mycommand7.ExecuteScalar Is DBNull.Value Then
            Requete7 = ""
        Else Requete7 = Mycommand7.ExecuteScalar
        End If
        Dim cplt As String = Requete7.ToString

        LB_complement.Text = cplt.ToUpper
        maConnexion.Close()
    End Function



    '---------------------------------------------------ARGUMENT (TB, TB, CB)--------------------------------------



    Public Function Recup_Ville_CP(TB_Ville As TextBox, TB_CptAdresse As TextBox, TB_CP As TextBox, CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)

        maConnexion.Open()

        'CODE POSTAL -----------------

        Dim Mycommand5 As SqlCommand = maConnexion.CreateCommand()
        Mycommand5.CommandText = "Select CP_ADRESSE from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & chaineNom(0) & "'and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"

        Dim Requete5 As String = Mycommand5.ExecuteScalar
        Dim CP As String = Requete5.ToString
        TB_CP.Text = CP

        'VILLE-----------------

        Dim Mycommand6 As SqlCommand = maConnexion.CreateCommand()
        Mycommand6.CommandText = "Select VILLE_ADRESSE from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & chaineNom(0) & "'and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"

        Dim Requete6 As String = Mycommand6.ExecuteScalar
        Dim ville As String = Requete6.ToString

        TB_Ville.Text = ville.ToUpper

        'COMPLEMENT ADRESSE--------

        Dim Mycommand7 As SqlCommand = maConnexion.CreateCommand()
        Mycommand7.CommandText = "Select COMPLEMENT_ADRESSE2 from ADRESSE, COLLABORATEUR
                                  where
                                  Collaborateur.ID_ADRESSE = ADRESSE.ID_ADRESSE And
                                  NOM_COLLABORATEUR = '" & chaineNom(0) & "'and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"

        Dim Requete7 As String

        If Mycommand7.ExecuteScalar Is DBNull.Value Then
            Requete7 = ""
        Else Requete7 = Mycommand7.ExecuteScalar
        End If
        Dim cplt As String = Requete7.ToString

        TB_CptAdresse.Text = cplt
        maConnexion.Close()

    End Function


    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
    '|------------------------------------------------FONCTION RECUPERATION ET AFFECTATION ETAT CIVIL COLLABORATEUR----------------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|


    Public Function Recup_Civilite(RB_Mr As RadioButton, RB_Mme As RadioButton, RB_Mlle As RadioButton, CB_Collabo As ComboBox)


        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand10 As SqlCommand = maConnexion.CreateCommand()
        Mycommand10.CommandText = "Select 
                                        ETAT_CIVIL_COLLABORATEUR 
                                  from 
                                        COLLABORATEUR
                                  where
                                        NOM_COLLABORATEUR = '" & chaineNom(0) & "'and PRENOM_COLLABORATEUR = '" & chaineNom(1) & "'"
        maConnexion.Open()
        Dim Requete10 As String = Mycommand10.ExecuteScalar
        Dim civilite As String = Requete10.ToString
        If civilite = "MR" Then
            RB_Mr.Checked = True
        ElseIf civilite = "MME" Then
            RB_Mme.Checked = True
        ElseIf civilite = "MLE" Then
            RB_Mlle.Checked = True
        Else MsgBox("Etat civil inconnu?????????")
        End If
        maConnexion.Close()

    End Function
End Module
