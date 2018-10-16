Public Class Admin



    '------------------------------CHARGEMENT DE LA COMBOBOX AU CHARGEMENT DE LA PAGE + PREPARATION DE LA PAGE ------------------------------------------------------------------

    Private Sub TabCollab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Remplissage_CB_Collabo(CB_Collabo)

        '--------------MASQUAGE DES ITEMS
        CB_Collabo.Hide()
        GB_Civilite.Hide()
        TB_CP.Hide()
        TB_CptAdresse.Hide()
        TB_Nom.Hide()
        TB_NumRue.Hide()
        TB_Prenom.Hide()
        TB_Tel.Hide()
        TB_Ville.Hide()
        TB_Embauche.Hide()
        TB_Fin.Hide()

    End Sub


    '------------------------------------------RADIOBOX EN POSITION : MODIFIER LES INFOS D'UN COLLABO ------------------------------------------------


    Private Sub RB_Modif_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Modif.CheckedChanged


        '--------------AFFICHAGE DES ITEMS
        CB_Collabo.Show()
        GB_Civilite.Show()
        TB_CP.Show()
        TB_CptAdresse.Show()
        TB_Nom.Show()
        TB_NumRue.Show()
        TB_Prenom.Show()
        TB_Tel.Show()
        TB_Ville.Show()
        TB_Embauche.Show()
        TB_Fin.Show()
        BTN_Valider.Show()

        '-------------ACTIVATION DES ITEMS
        GB_Civilite.Enabled = True
        GB_Civilite.Enabled = True
        TB_CP.Enabled = True
        TB_CptAdresse.Enabled = True
        TB_Nom.Enabled = True
        TB_NumRue.Enabled = True
        TB_Prenom.Enabled = True
        TB_Tel.Enabled = True
        TB_Ville.Enabled = True
        TB_Embauche.Enabled = True
        TB_Fin.Enabled = True


    End Sub

    '------------------------------------------RADIOBOX EN POSITION : CREER NOUVEAU COLLABO ------------------------------------------------

    Private Sub RB_Ajout_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Ajout.CheckedChanged

        '--------------NETTOYAGE DES ITEMS
        TB_CP.Clear()
        TB_CptAdresse.Clear()
        TB_Nom.Clear()
        TB_NumRue.Clear()
        TB_Prenom.Clear()
        TB_Tel.Clear()
        TB_Ville.Clear()
        TB_Embauche.Clear()
        TB_Fin.Clear()
        BTN_Valider.Show()

        '--------------AFFICHAGE DES ITEMS
        CB_Collabo.Hide()
        GB_Civilite.Show()
        TB_CP.Show()
        TB_CptAdresse.Show()
        TB_Nom.Show()
        TB_NumRue.Show()
        TB_Prenom.Show()
        TB_Tel.Show()
        TB_Ville.Show()
        TB_Embauche.Show()
        TB_Fin.Show()
        BTN_Valider.Show()


        '-------------ACTIVATION DES ITEMS
        GB_Civilite.Enabled = True
        GB_Civilite.Enabled = True
        TB_CP.Enabled = True
        TB_CptAdresse.Enabled = True
        TB_Nom.Enabled = True
        TB_NumRue.Enabled = True
        TB_Prenom.Enabled = True
        TB_Tel.Enabled = True
        TB_Ville.Enabled = True
        TB_Embauche.Enabled = True
        TB_Fin.Enabled = True


    End Sub


    '------------------------------------------RADIOBOX EN POSITION : CONSULTER LES INFOS D'UN COLLABO ------------------------------------------------


    Private Sub RB_Consult_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Consult.CheckedChanged

        '-------------AFFICCHAGE DES ITEMS
        CB_Collabo.Show()
        GB_Civilite.Show()
        TB_CP.Show()
        TB_CptAdresse.Show()
        TB_Nom.Show()
        TB_NumRue.Show()
        TB_Prenom.Show()
        TB_Tel.Show()
        TB_Ville.Show()
        BTN_Valider.Hide()

        '-------------DESACTIVATION DES ITEMS

        GB_Civilite.Enabled = False
        GB_Civilite.Enabled = False
        TB_CP.Enabled = False
        TB_CptAdresse.Enabled = False
        TB_Nom.Enabled = False
        TB_NumRue.Enabled = False
        TB_Prenom.Enabled = False
        TB_Tel.Enabled = False
        TB_Ville.Enabled = False
        TB_Embauche.Enabled = False
        TB_Fin.Enabled = False


    End Sub


    '---------------------------LANCEMENT DES FONCTIONS DE RECUP2RATION DES DONNEES LORS DE LA MODIF DU COLLABO CHOISI (COMBOBOX)-----------------------


    Private Sub CB_Collabo_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles CB_Collabo.SelectedIndexChanged

        Dim monCollabo As String = CB_Collabo.SelectedItem


        Recup_Rue(Me.TB_NumRue, Me.CB_Collabo)
        Recup_Date_Embau(Me.TB_Embauche, Me.CB_Collabo)
        Recup_Tel(Me.TB_Tel, Me.CB_Collabo)
        Recup_Ville_CP(Me.TB_Ville, Me.TB_CptAdresse, Me.TB_CP, Me.CB_Collabo)
        Recup_Nom_Prenom(Me.TB_Nom, Me.TB_Prenom, Me.CB_Collabo)
        Recup_Civilite(Me.RB_Mr, Me.RB_Mme, Me.RB_Mlle, Me.CB_Collabo)


    End Sub



    '---------------------------------------FONCTION RETOUR ET FERMETURE DE L'APPLI-------------------------------

    Private Sub BTN_Back_Click(sender As Object, e As EventArgs) Handles BTN_Back.Click
        Choix.Show()
        Me.Hide()

    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Close()
    End Sub

    Private Sub BTN_Valider_Click(sender As Object, e As EventArgs) Handles BTN_Valider.Click

        If RB_Modif.Checked Then

            If CB_Collabo.Text = "" Then
                MessageBox.Show("Vous devez choisir un collaborateur pour pouvoir le modifier!")
            Else
                Dim result As Integer = MessageBox.Show("Souhaitez-vous Vraiment modifier les informations concernant : " + Chr(10) + TB_Nom.Text + " " + TB_Prenom.Text, "ATTENTION", MessageBoxButtons.YesNo)


                If result = DialogResult.No Then
                    MessageBox.Show("NNNOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO")

                ElseIf result = DialogResult.Yes Then
                    MessageBox.Show("OOOOOOOHHHH YYYYYYYYEEEEEEEEEESSSSSSSSS") '------------------->   ICI FONCTION UPDATE COLLABORATEUR
                End If
            End If

        ElseIf RB_Ajout.Checked Then

            If (TB_CP.Text = "" Or TB_Nom.Text = "" Or TB_NumRue.Text = "" Or TB_Prenom.Text = "" Or TB_Tel.Text = "" Or TB_Ville.Text = "") Then
                MsgBox("Certaines informations obligatoires sont manquante" + Chr(10) + "Merci de verifier les *")

            Else MsgBox("On va enregistrer!" + Chr(10) + "Tous les champs obligatoires sont remplis!" + Chr(10) + Chr(10) + "FELICITATION!!!!!!!!!!!!!!!!!!!") '--------------->    ICI FONCTION INSERT INTO
            End If

        Else MsgBox("Vous devez choisir une action (modifier, creer, ou consulter)")
        End If
    End Sub
End Class