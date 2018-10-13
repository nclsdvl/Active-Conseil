Public Class Choix

    Public maVariable As String
    Public profil As Integer

    Private Sub Label1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LB_Bonjour.Text = "Bienvenue " + maVariable.Replace(".", " ")
    End Sub

    Private Sub Button1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If profil = 3 Then
            BTN_Admin.Visible = False

        Else BTN_Admin.Visible = True
        End If
    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Close()
    End Sub

    Private Sub BTN_Client_Click(sender As Object, e As EventArgs) Handles BTN_Collabo.Click
        Client.Show()
    End Sub
End Class