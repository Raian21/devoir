Public Class Form1
    Private Sub numeroProduit_TextChanged(sender As Object, e As EventArgs) Handles TextField_NumeroProduit.TextChanged

    End Sub

    Private Sub nomProduit_TextChanged(sender As Object, e As EventArgs) Handles TextField_NomProduit.TextChanged
    End Sub

    Private Sub prixProduit_TextChanged(sender As Object, e As EventArgs) Handles TextFieldPrixProduit.TextChanged
    End Sub

    Private Sub quantiteProduit_TextChanged(sender As Object, e As EventArgs) Handles TextFieldQteProduit.TextChanged
    End Sub

    Private Sub categorie_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub type_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub verifier_Click(sender As Object, e As EventArgs) Handles verifier.Click
        Dim errorNumProd As String
        Dim numProd As String = TextField_NumeroProduit.Text
        Dim errorNomProd As String
        Dim nomProd As String = TextField_NomProduit.Text
        Dim errorPrixProduct As String
        Dim prixProduct As String = TextFieldPrixProduit.Text
        Dim errorQteProd As String
        Dim qteProd As String = TextFieldQteProduit.Text
        Dim compteur As Integer
        Dim errorCompteur As String
        Dim compteurType As Integer
        Dim errorCompteurType As String



        'validation de numéro du produit
        If Not IsNumeric(numProd) Then
            errorNumProd = "votre numéro de produit n'est pas un nombre"
            labIdProduitError.Text = errorNumProd
        Else
            labIdProduitError.Text = ""
        End If

        'validation du nom du produit
        If nomProd.Length >= 50 Then
            errorNomProd = " le nom de votre produit est supérieur à 50"
            LabNomProduit.Text = errorNomProd
        Else
            LabNomProduit.Text = ""
        End If

        'vérification de l'intervalle du prix
        If Not IsNumeric(prixProduct) Then
            errorPrixProduct = "votre prix de produit n'est pas un nombre"
            LabPrixProduct.Text = errorPrixProduct
        Else
            LabPrixProduct.Text = ""

            If prixProduct < 100 Or prixProduct > 5000 Then
                errorPrixProduct = " votre prix n'est pas compris entre 100 et 5000"
                LabPrixProduct.Text = errorPrixProduct
            Else
                LabPrixProduct.Text = ""
            End If

        End If

        'vérification de la quantité de produit
        If Not IsNumeric(qteProd) Then
            errorQteProd = "votre quantité de produit n'est pas un nombre"
            LabQteProduct.Text = errorQteProd
        Else
            errorQteProd = ""
            LabQteProduct.Text = errorQteProd
            If qteProd <= 0 Then
                errorQteProd = " la quantité de votre produit ne peut pas être négatif"
                LabQteProduct.Text = errorQteProd
            Else
                errorQteProd = ""
                LabQteProduct.Text = errorQteProd
            End If
        End If

        If BasseGamme.Checked Then
            compteur = compteur + 1
        End If
        If MoyenneGamme.Checked Then
            compteur = compteur + 1
        End If
        If HauteGamme.Checked Then
            compteur = compteur + 1
        End If

        If compteur = 0 Then
            errorCompteur = "Choisissez une catégorie"
            LabCategorie.Text = errorCompteur
        ElseIf compteur = 1 Then
            errorCompteur = ""
            LabCategorie.Text = errorCompteur
        End If

        If Ancien.Checked Then
            compteurType = compteurType + 1
        End If
        If Nouveau.Checked Then
            compteurType = compteurType + 1
        End If

        If compteurType = 0 Then
            errorCompteurType = "Choisissez un type"
            LabType.Text = errorCompteurType
        ElseIf compteurType = 1 Then
            errorCompteurType = ""
            LabType.Text = errorCompteurType
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HauteGamme_CheckedChanged(sender As Object, e As EventArgs) Handles HauteGamme.CheckedChanged

    End Sub


End Class
