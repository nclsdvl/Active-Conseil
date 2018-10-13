Public Class Client
    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Active_Final_CommunDataSet.UTILISATEURS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.UTILISATEURSTableAdapter.Fill(Me.Active_Final_CommunDataSet.UTILISATEURS)
        'TODO: cette ligne de code charge les données dans la table 'Active_Final_CommunDataSet.COLLABORATEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.COLLABORATEURTableAdapter.Fill(Me.Active_Final_CommunDataSet.COLLABORATEUR)

    End Sub

    Private Sub CB_Collabo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Collabo.SelectedIndexChanged

    End Sub
End Class