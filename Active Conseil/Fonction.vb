Imports System.Data.SqlClient

Module Fonction



    Public Function Remplissage_CB_Collabo(nomForm) As ComboBox

        '--------------------------------------------------------------------REMPLISSAGE CBBOX-------------------------------------------

        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)

        Try
            Dim Mycommand As SqlCommand = maConnexion.CreateCommand()
            Mycommand.CommandText = "select NOM_COLLABORATEUR, PRENOM_COLLABORATEUR, ID_COLLABORATEUR from COLLABORATEUR order by NOM_COLLABORATEUR"
            maConnexion.Open()
            Dim myReader As SqlDataReader = Mycommand.ExecuteReader()
            nomForm.CB_Collabo.Items.Clear()
            Do While myReader.Read()
                Dim tmp_chaine As String
                tmp_chaine = myReader.GetString(0) + " " + myReader.GetString(1) + " (" + myReader.GetValue(2).ToString() + ")"
                nomForm.CB_Collabo.Items.Add(tmp_chaine)
            Loop
            myReader.Close()
            maConnexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return CB_Collabo

    End Function

End Module
