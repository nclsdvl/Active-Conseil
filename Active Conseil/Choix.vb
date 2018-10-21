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
        Dim confirmation As DialogResult = MessageBox.Show("Souhaitez-vous quitter l'application ?", "Quitter", MessageBoxButtons.YesNo)
        If confirmation = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub BTN_Collabo_Click(sender As Object, e As EventArgs) Handles BTN_Collabo.Click
        Collaborateur.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_Back_Click(sender As Object, e As EventArgs) Handles BTN_Back.Click
        Page_Accueil.Show()
        Me.Close()
    End Sub

    Private Sub BTN_Admin_Click(sender As Object, e As EventArgs) Handles BTN_Admin.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_Projet_Click(sender As Object, e As EventArgs) Handles BTN_Projet.Click
        Projet.Show()
        Me.Hide()
    End Sub
End Class