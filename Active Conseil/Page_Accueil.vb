Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Page_Accueil

    Private Sub Page_Accueil_shown(sender As Object, e As EventArgs) Handles MyBase.Load
        For x As Double = 0 To 1 Step 0.1
            Me.Opacity = x
            System.Threading.Thread.Sleep(50)
            Application.DoEvents()
        Next
    End Sub

    Private Sub Page_Accueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For x As Double = 1 To 0 Step -0.1
            Me.Opacity = x
            System.Threading.Thread.Sleep(50)
            Application.DoEvents()
        Next
    End Sub




    Private Sub BTN_Valider_Click(sender As Object, e As EventArgs) Handles BTN_Valider.Click

        Dim i_choix As Integer
        i_choix = InputBox("1 pour AFPA, 2 pour home : ", "quelle connexion?")

        If i_choix = 1 Then
            str_chaine_de_connexion = str_Chaine_de_Connexion_AFPA
        Else
            str_chaine_de_connexion = str_Chaine_de_Connexion_HOME
        End If

        Dim maConnexion As New SqlConnection(str_chaine_de_connexion)





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
                Choix.Show()
                Me.Hide()


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
