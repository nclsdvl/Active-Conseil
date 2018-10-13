Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Page_Accueil

    Private Sub BTN_Valider_Click(sender As Object, e As EventArgs) Handles BTN_Valider.Click
        Dim maConnexion As New SqlConnection("Data Source=DESKTOP-KDV6P4O\SQLEXPRESS;Initial Catalog=Active_Final_Commun;Integrated Security=True")




        Dim maRequete1 As New SqlCommand()
        maRequete1.Connection = maConnexion
        maRequete1.CommandType = CommandType.StoredProcedure
        maRequete1.CommandText = "PS_Check_MDP"

        Dim valeurAjouter1 As SqlParameter = maRequete1.Parameters.Add("@Login", SqlDbType.VarChar)
        valeurAjouter1.Value = TB_Login.Text

        Dim valeurAjouter2 As SqlParameter = maRequete1.Parameters.Add("@MDP", SqlDbType.VarBinary)

        Dim md5 As New MD5CryptoServiceProvider()
        valeurAjouter2.Value = md5.ComputeHash(Encoding.GetEncoding(1252).GetBytes(TB_MDP.Text))


        Dim valeurAjouter3 As SqlParameter = maRequete1.Parameters.Add("@return_value", SqlDbType.Int)
        valeurAjouter3.Direction = ParameterDirection.ReturnValue

        Try
            maConnexion.Open()
            maRequete1.ExecuteNonQuery()


            If valeurAjouter3.Value = 0 Then
                MsgBox("Vous n'existez pas ... Désolé!")
            ElseIf valeurAjouter3.Value = -1 Then
                MsgBox("votre mot de passe est incorrect!")
            Else
                Choix.profil = valeurAjouter3.Value
                Choix.maVariable = TB_MDP.Text
                Me.Hide()
                Choix.Show()


            End If

            maConnexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Close()
    End Sub
End Class
