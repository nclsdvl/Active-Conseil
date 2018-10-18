﻿Imports System.Data.SqlClient

Module Update
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

        Mycommand.Parameters.Add(New SqlParameter("@ID_Collab", SqlDbType.VarChar))
        Mycommand.Parameters("@ID_Collab").Value = CInt(chaineNom(2).Replace(")", "").Replace("(", "")) '   <--   RECUPERATION DE L'ID_COLLABORATEUR

        Mycommand.ExecuteScalar()
        maConnexion.Close()
    End Function


    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|
    '|------------------------------------------------               FONCTION UPDATE ADRESSE                   --------------------------------------------|
    '|-----------------------------------------------------------------------------------------------------------------------------------------------------|

    '------------------manque DATE-------------------


    Public Function Update_Collabo(CB_Collabo As ComboBox, TB_Nom As TextBox, TB_Prenom As TextBox, TB_Tel As TextBox)


        Dim monCollabo As String = CB_Collabo.SelectedItem
        Dim chaineNom() As String = Split(monCollabo)


        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)
        Dim Mycommand As New SqlCommand("Up_Adresse", maConnexion)
        Mycommand.CommandType = CommandType.StoredProcedure
        maConnexion.Open()

        Mycommand.Parameters.Add(New SqlParameter("@nom", SqlDbType.VarChar))
        Mycommand.Parameters("@nom").Value = TB_Nom.Text

        Mycommand.Parameters.Add(New SqlParameter("@prenom", SqlDbType.VarChar))
        Mycommand.Parameters("@prenom").Value = TB_Prenom.Text

        Mycommand.Parameters.Add(New SqlParameter("@tel", SqlDbType.VarChar)) 'PB TYPAGE?????????????????????????????
        Mycommand.Parameters("@tel").Value = TB_Tel.Text

        Mycommand.Parameters.Add(New SqlParameter("@ID_Collab", SqlDbType.Int))
        Mycommand.Parameters("@ID_Collab").Value = CInt(chaineNom(2).Replace(")", "").Replace("(", "")) '   <--   RECUPERATION DE L'ID_COLLABORATEUR

        Mycommand.ExecuteScalar()
        maConnexion.Close()

    End Function

End Module
