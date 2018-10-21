Imports System.Data.SqlClient

Module Fonction_Update_Insert

    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    '|------------------------------------------------               FONCTION UPDATE ADRESSE                   --------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    Public Function Update_Adresse(CB_Collabo As ComboBox, TB_CP As TextBox, TB_CptAdresse As TextBox, TB_NumRue As TextBox, TB_Ville As TextBox)


        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)


        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand As New SqlCommand("Up_Adresse", maConnexion)
        Mycommand.CommandType = CommandType.StoredProcedure
        maConnexion.Open()

        Mycommand.Parameters.Add(New SqlParameter("@CP", SqlDbType.Int, 5))
        Mycommand.Parameters("@CP").Value = CInt(TB_CP.Text)

        Mycommand.Parameters.Add(New SqlParameter("@Complt", SqlDbType.VarChar))
        Mycommand.Parameters("@Complt").Value = TB_CptAdresse.Text

        Mycommand.Parameters.Add(New SqlParameter("@Rue", SqlDbType.VarChar))
        Mycommand.Parameters("@Rue").Value = TB_NumRue.Text

        Mycommand.Parameters.Add(New SqlParameter("@Ville", SqlDbType.VarChar))
        Mycommand.Parameters("@Ville").Value = TB_Ville.Text

        Mycommand.Parameters.Add(New SqlParameter("@ID_Collab", SqlDbType.Int))
        Mycommand.Parameters("@ID_Collab").Value = CInt(chaineNom(2).Replace(")", "").Replace("(", "")) '   <--   RECUPERATION DE L'ID_COLLABORATEUR

        Mycommand.ExecuteScalar()
        maConnexion.Close()
    End Function



    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    '|------------------------------------------------               FONCTION UPDATE COLLABORATEUR               ------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|

    Public Function Update_Collabo(CB_Collabo As ComboBox, TB_Nom As TextBox, TB_Prenom As TextBox, TB_Tel As TextBox, TB_Embauche As TextBox, TB_Fin As TextBox, RB_Mr As RadioButton, RB_Mme As RadioButton, RB_Mlle As RadioButton)


        Dim monCollabo As String = CB_Collabo.SelectedItem.ToString

        Dim chaineNom() As String = Split(monCollabo)


        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand As New SqlCommand("Update_Collabo", maConnexion)
        Mycommand.CommandType = CommandType.StoredProcedure
        maConnexion.Open()

        Mycommand.Parameters.Add(New SqlParameter("@nom", SqlDbType.VarChar))
        Mycommand.Parameters("@nom").Value = TB_Nom.Text

        Mycommand.Parameters.Add(New SqlParameter("@prenom", SqlDbType.VarChar))
        Mycommand.Parameters("@prenom").Value = TB_Prenom.Text

        Mycommand.Parameters.Add(New SqlParameter("@embauche", SqlDbType.VarChar))
        Mycommand.Parameters("@embauche").Value = TB_Embauche.Text

        Mycommand.Parameters.Add(New SqlParameter("@fin", SqlDbType.VarChar))
        Mycommand.Parameters("@fin").Value = TB_Fin.Text

        Mycommand.Parameters.Add(New SqlParameter("@tel", SqlDbType.VarChar))
        Mycommand.Parameters("@tel").Value = TB_Tel.Text.Replace("-", "").Replace("/", "")

        Mycommand.Parameters.Add(New SqlParameter("@etat_civil", SqlDbType.VarChar))
        If RB_Mr.Checked = True Then
            Mycommand.Parameters("@etat_civil").Value = "MR"
        ElseIf RB_Mlle.Checked = True Then
            Mycommand.Parameters("@etat_civil").Value = "MLE"
        Else
            Mycommand.Parameters("@etat_civil").Value = "MME"
        End If

        Mycommand.Parameters.Add(New SqlParameter("@ID_Collab", SqlDbType.Int))
        Mycommand.Parameters("@ID_Collab").Value = CInt(chaineNom(2).Replace(")", "").Replace("(", "")) '   <--   RECUPERATION DE L'ID_COLLABORATEUR

        Mycommand.ExecuteScalar()
        maConnexion.Close()



    End Function



    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    '|------------------------------         FONCTION VERIFICATION SI PLUSIEURS COLLABO HABITENT LA MEME ADRESSE                ---------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    Public Function Check_Double_Adresse(CB_Collabo As ComboBox)

        Dim monCollabo As String = CB_Collabo.SelectedItem.ToString
        Dim chaineNom() As String = Split(monCollabo)


        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand As New SqlCommand("PS_Check_Double_Adresse", maConnexion)
        Mycommand.CommandType = CommandType.StoredProcedure
        maConnexion.Open()

        Mycommand.Parameters.Add(New SqlParameter("@ID_Collabo", SqlDbType.Int))
        Mycommand.Parameters("@ID_Collabo").Value = CInt(chaineNom(2).Replace(")", "").Replace("(", "")) '   <--   RECUPERATION DE L'ID_COLLABORATEUR

        Dim valeurAjouter3 As SqlParameter = Mycommand.Parameters.Add("@return_value", SqlDbType.Int)
        valeurAjouter3.Direction = ParameterDirection.ReturnValue

        Mycommand.ExecuteNonQuery()
        maConnexion.Close()

        Return valeurAjouter3.Value

    End Function



    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    '|------------------------------------------------           FONCTION INSERT INTO ADRESSE   (POLYMORPHE)        ---------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|

    '-------------------ARGUMENT (CB, TB_CP, TB_CptAdresse, TB_NumRue, TB_Ville)
    Public Function Create_Adresse(CB_Collabo As ComboBox, TB_CP As TextBox, TB_CptAdresse As TextBox, TB_NumRue As TextBox, TB_Ville As TextBox)


        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)


        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand As New SqlCommand("Creation_Adresse", maConnexion)
        Mycommand.CommandType = CommandType.StoredProcedure
        maConnexion.Open()

        Mycommand.Parameters.Add(New SqlParameter("@CP", SqlDbType.Int, 5))
        Mycommand.Parameters("@CP").Value = CInt(TB_CP.Text)

        Mycommand.Parameters.Add(New SqlParameter("@Complt", SqlDbType.VarChar))
        Mycommand.Parameters("@Complt").Value = TB_CptAdresse.Text

        Mycommand.Parameters.Add(New SqlParameter("@Rue", SqlDbType.VarChar))
        Mycommand.Parameters("@Rue").Value = TB_NumRue.Text

        Mycommand.Parameters.Add(New SqlParameter("@Ville", SqlDbType.VarChar))
        Mycommand.Parameters("@Ville").Value = TB_Ville.Text

        Mycommand.Parameters.Add(New SqlParameter("@ID_Collab", SqlDbType.Int))
        Mycommand.Parameters("@ID_Collab").Value = CInt(chaineNom(2).Replace(")", "").Replace("(", "")) '   <--   RECUPERATION DE L'ID_COLLABORATEUR

        Dim valeurAjouter3 As SqlParameter = Mycommand.Parameters.Add("@return_value", SqlDbType.Int)
        valeurAjouter3.Direction = ParameterDirection.ReturnValue


        Mycommand.ExecuteNonQuery()
        maConnexion.Close()
        Return valeurAjouter3.Value

    End Function

    '-------------------ARGUMENT (TB_CP, TB_CptAdresse, TB_NumRue, TB_Ville)
    Public Function Create_Adresse(TB_CP As TextBox, TB_CptAdresse As TextBox, TB_NumRue As TextBox, TB_Ville As TextBox)


        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand As New SqlCommand("PS_Creation_Adresse_sans_collabo", maConnexion)
        Mycommand.CommandType = CommandType.StoredProcedure
        maConnexion.Open()

        Mycommand.Parameters.Add(New SqlParameter("@CP", SqlDbType.Int, 5))
        Mycommand.Parameters("@CP").Value = CInt(TB_CP.Text)

        Mycommand.Parameters.Add(New SqlParameter("@Complt", SqlDbType.VarChar))
        Mycommand.Parameters("@Complt").Value = TB_CptAdresse.Text

        Mycommand.Parameters.Add(New SqlParameter("@Rue", SqlDbType.VarChar))
        Mycommand.Parameters("@Rue").Value = TB_NumRue.Text

        Mycommand.Parameters.Add(New SqlParameter("@Ville", SqlDbType.VarChar))
        Mycommand.Parameters("@Ville").Value = TB_Ville.Text


        Dim valeurAjouter3 As SqlParameter = Mycommand.Parameters.Add("@return_value", SqlDbType.Int)
        valeurAjouter3.Direction = ParameterDirection.ReturnValue


        Mycommand.ExecuteNonQuery()
        maConnexion.Close()
        Return valeurAjouter3.Value

    End Function


    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    '|----------------------------------------               FONCTION AFFECTATION ID_ADRESSE A COLLABORATEUR                -------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    Public Function Affectation_ID_Adresse(CB_Collabo As ComboBox, ID_Adresse As Int16)

        Dim monCollabo As String = CB_Collabo.SelectedItem.ToString
        Dim chaineNom() As String = Split(monCollabo)


        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand As New SqlCommand("PS_Affecation_ID_Adresse", maConnexion)
        Mycommand.CommandType = CommandType.StoredProcedure
        maConnexion.Open()

        Mycommand.Parameters.Add(New SqlParameter("@ID_Collab", SqlDbType.Int))
        Mycommand.Parameters("@ID_Collab").Value = CInt(chaineNom(2).Replace(")", "").Replace("(", "")) '   <--   RECUPERATION DE L'ID_COLLABORATEUR

        Mycommand.Parameters.Add(New SqlParameter("@ID_Adresse", SqlDbType.Int))
        Mycommand.Parameters("@ID_Adresse").Value = ID_Adresse

        Mycommand.ExecuteScalar()
        maConnexion.Close()



    End Function



    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    '|----------------------------------------               FONCTION INSERT INTO COLLABORATEUR                --------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|

    '-------------A Voir DATETIME--------
    Public Function Create_Collabo(TB_Nom As TextBox, TB_Prenom As TextBox, TB_Tel As TextBox, ID_Adresse As Int16, RB_Mr As RadioButton, TB_Embauche As TextBox, TB_Fin As TextBox, RB_Mme As RadioButton, RB_Mlle As RadioButton)


        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand As New SqlCommand("PS_Creation_Collabo", maConnexion)
        Mycommand.CommandType = CommandType.StoredProcedure
        maConnexion.Open()

        Mycommand.Parameters.Add(New SqlParameter("@nom", SqlDbType.VarChar))
        Mycommand.Parameters("@nom").Value = TB_Nom.Text

        Mycommand.Parameters.Add(New SqlParameter("@prenom", SqlDbType.VarChar))
        Mycommand.Parameters("@prenom").Value = TB_Prenom.Text

        Mycommand.Parameters.Add(New SqlParameter("@embauche", SqlDbType.VarChar))
        Mycommand.Parameters("@embauche").Value = TB_Embauche.Text

        Mycommand.Parameters.Add(New SqlParameter("@fin", SqlDbType.VarChar))
        Mycommand.Parameters("@fin").Value = TB_Fin.Text

        Mycommand.Parameters.Add(New SqlParameter("@tel", SqlDbType.VarChar))
        Mycommand.Parameters("@tel").Value = TB_Tel.Text.Replace("-", "").Replace("/", "")


        'Mycommand.Parameters.Add(New SqlParameter("@embauche", SqlDbType.DateTime)) 'A MODIF
        'If TB_Embauche.Modified = True Then
        '    Mycommand.Parameters("@embauche").Value = DateTime.ParseExact(TB_Embauche.Text, "yyyyMMdd", Nothing)
        'Else
        '    Mycommand.Parameters("@embauche").Value = ""
        'End If


        'Mycommand.Parameters.Add(New SqlParameter("@fin", SqlDbType.DateTime)) 'A MODIF
        'If TB_Fin.Modified = True Then
        '    Mycommand.Parameters("@fin").Value = DateTime.ParseExact(TB_Fin.Text, "yyyyMMdd", Nothing)
        'Else
        '    Mycommand.Parameters("@fin").Value = ""
        'End If


        Mycommand.Parameters.Add(New SqlParameter("@sexe", SqlDbType.VarChar))
        If RB_Mr.Checked = True Then
            Mycommand.Parameters("@sexe").Value = "H"
        Else
            Mycommand.Parameters("@sexe").Value = "F"
        End If


        Mycommand.Parameters.Add(New SqlParameter("@etat_civil", SqlDbType.VarChar))
        If RB_Mr.Checked = True Then
            Mycommand.Parameters("@etat_civil").Value = "MR"
        ElseIf RB_Mlle.Checked = True Then
            Mycommand.Parameters("@etat_civil").Value = "MLE"
        Else
            Mycommand.Parameters("@etat_civil").Value = "MME"
        End If


        Mycommand.Parameters.Add(New SqlParameter("@ID_Adresse", SqlDbType.Int))
        Mycommand.Parameters("@ID_Adresse").Value = ID_Adresse


        Mycommand.ExecuteScalar()
        maConnexion.Close()


    End Function

End Module
