Imports System.Data.SqlClient

Module Fonction



    Public Function Remplissage_CB_Collabo(nomForm As ComboBox)

        '--------------------------------------------------------------------REMPLISSAGE CBBOX-------------------------------------------

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


    Public Function Recup_Tel(monNom, monPrenom)

        Dim monCollabo As String = CB_Collabo.SelectedItem

        Dim monNom() As String = Split(monCollabo)
        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)

        Dim Mycommand As SqlCommand = maConnexion.CreateCommand()
        Mycommand.CommandText = "select TELEPHONE_COLLABORATEUR as phone from COLLABORATEUR
                                    where NOM_COLLABORATEUR = '" & monNom(0) & "' 
                                    and PRENOM_COLLABORATEUR = '" & monNom(1) & "'"

        maConnexion.Open()
        '-----------------------------------------------------------------------------------------------
        Dim Requete As String = Mycommand.ExecuteScalar
        Dim phone As String = Requete.ToString
        LB_Phone.Text = Mid(phone, 1, 2) & "-" & Mid(phone, 3, 2) & "-" & Mid(phone, 5, 2) & "-" & Mid(phone, 7, 2) & "-" & Mid(phone, 9, 2)

    End Function

End Module
