<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextField_NumeroProduit = New System.Windows.Forms.TextBox()
        Me.TextField_NomProduit = New System.Windows.Forms.TextBox()
        Me.TextFieldPrixProduit = New System.Windows.Forms.TextBox()
        Me.TextFieldQteProduit = New System.Windows.Forms.TextBox()
        Me.verifier = New System.Windows.Forms.Button()
        Me.LabNomProduit = New System.Windows.Forms.Label()
        Me.labIdProduitError = New System.Windows.Forms.Label()
        Me.LabPrixProduct = New System.Windows.Forms.Label()
        Me.LabQteProduct = New System.Windows.Forms.Label()
        Me.LabCategorie = New System.Windows.Forms.Label()
        Me.LabType = New System.Windows.Forms.Label()
        Me.BasseGamme = New System.Windows.Forms.RadioButton()
        Me.MoyenneGamme = New System.Windows.Forms.RadioButton()
        Me.HauteGamme = New System.Windows.Forms.RadioButton()
        Me.Ancien = New System.Windows.Forms.RadioButton()
        Me.Nouveau = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Produit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom Produit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prix Produit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantité Produit"
        '
        'TextField_NumeroProduit
        '
        Me.TextField_NumeroProduit.Location = New System.Drawing.Point(143, 18)
        Me.TextField_NumeroProduit.Name = "TextField_NumeroProduit"
        Me.TextField_NumeroProduit.Size = New System.Drawing.Size(100, 23)
        Me.TextField_NumeroProduit.TabIndex = 6
        '
        'TextField_NomProduit
        '
        Me.TextField_NomProduit.Location = New System.Drawing.Point(143, 55)
        Me.TextField_NomProduit.Name = "TextField_NomProduit"
        Me.TextField_NomProduit.Size = New System.Drawing.Size(100, 23)
        Me.TextField_NomProduit.TabIndex = 7
        '
        'TextFieldPrixProduit
        '
        Me.TextFieldPrixProduit.Location = New System.Drawing.Point(143, 91)
        Me.TextFieldPrixProduit.Name = "TextFieldPrixProduit"
        Me.TextFieldPrixProduit.Size = New System.Drawing.Size(100, 23)
        Me.TextFieldPrixProduit.TabIndex = 8
        '
        'TextFieldQteProduit
        '
        Me.TextFieldQteProduit.Location = New System.Drawing.Point(143, 132)
        Me.TextFieldQteProduit.Name = "TextFieldQteProduit"
        Me.TextFieldQteProduit.Size = New System.Drawing.Size(100, 23)
        Me.TextFieldQteProduit.TabIndex = 9
        '
        'verifier
        '
        Me.verifier.Location = New System.Drawing.Point(205, 410)
        Me.verifier.Name = "verifier"
        Me.verifier.Size = New System.Drawing.Size(147, 62)
        Me.verifier.TabIndex = 12
        Me.verifier.Text = "Vérifier"
        Me.verifier.UseVisualStyleBackColor = True
        '
        'LabNomProduit
        '
        Me.LabNomProduit.AutoSize = True
        Me.LabNomProduit.ForeColor = System.Drawing.Color.Red
        Me.LabNomProduit.Location = New System.Drawing.Point(296, 60)
        Me.LabNomProduit.Name = "LabNomProduit"
        Me.LabNomProduit.Size = New System.Drawing.Size(0, 15)
        Me.LabNomProduit.TabIndex = 14
        '
        'labIdProduitError
        '
        Me.labIdProduitError.AutoSize = True
        Me.labIdProduitError.ForeColor = System.Drawing.Color.Red
        Me.labIdProduitError.Location = New System.Drawing.Point(296, 23)
        Me.labIdProduitError.Name = "labIdProduitError"
        Me.labIdProduitError.Size = New System.Drawing.Size(0, 15)
        Me.labIdProduitError.TabIndex = 15
        '
        'LabPrixProduct
        '
        Me.LabPrixProduct.AutoSize = True
        Me.LabPrixProduct.ForeColor = System.Drawing.Color.Red
        Me.LabPrixProduct.Location = New System.Drawing.Point(296, 94)
        Me.LabPrixProduct.Name = "LabPrixProduct"
        Me.LabPrixProduct.Size = New System.Drawing.Size(0, 15)
        Me.LabPrixProduct.TabIndex = 16
        '
        'LabQteProduct
        '
        Me.LabQteProduct.AutoSize = True
        Me.LabQteProduct.ForeColor = System.Drawing.Color.Red
        Me.LabQteProduct.Location = New System.Drawing.Point(296, 135)
        Me.LabQteProduct.Name = "LabQteProduct"
        Me.LabQteProduct.Size = New System.Drawing.Size(0, 15)
        Me.LabQteProduct.TabIndex = 17
        '
        'LabCategorie
        '
        Me.LabCategorie.AutoSize = True
        Me.LabCategorie.ForeColor = System.Drawing.Color.Red
        Me.LabCategorie.Location = New System.Drawing.Point(296, 237)
        Me.LabCategorie.Name = "LabCategorie"
        Me.LabCategorie.Size = New System.Drawing.Size(0, 15)
        Me.LabCategorie.TabIndex = 18
        '
        'LabType
        '
        Me.LabType.AutoSize = True
        Me.LabType.ForeColor = System.Drawing.Color.Red
        Me.LabType.Location = New System.Drawing.Point(296, 345)
        Me.LabType.Name = "LabType"
        Me.LabType.Size = New System.Drawing.Size(0, 15)
        Me.LabType.TabIndex = 19
        '
        'BasseGamme
        '
        Me.BasseGamme.AutoSize = True
        Me.BasseGamme.Location = New System.Drawing.Point(25, 29)
        Me.BasseGamme.Name = "BasseGamme"
        Me.BasseGamme.Size = New System.Drawing.Size(99, 19)
        Me.BasseGamme.TabIndex = 20
        Me.BasseGamme.TabStop = True
        Me.BasseGamme.Text = "Basse Gamme"
        Me.BasseGamme.UseVisualStyleBackColor = True
        '
        'MoyenneGamme
        '
        Me.MoyenneGamme.AutoSize = True
        Me.MoyenneGamme.Location = New System.Drawing.Point(25, 54)
        Me.MoyenneGamme.Name = "MoyenneGamme"
        Me.MoyenneGamme.Size = New System.Drawing.Size(120, 19)
        Me.MoyenneGamme.TabIndex = 21
        Me.MoyenneGamme.TabStop = True
        Me.MoyenneGamme.Text = "Moyenne Gamme"
        Me.MoyenneGamme.UseVisualStyleBackColor = True
        '
        'HauteGamme
        '
        Me.HauteGamme.AutoSize = True
        Me.HauteGamme.Location = New System.Drawing.Point(25, 79)
        Me.HauteGamme.Name = "HauteGamme"
        Me.HauteGamme.Size = New System.Drawing.Size(102, 19)
        Me.HauteGamme.TabIndex = 22
        Me.HauteGamme.TabStop = True
        Me.HauteGamme.Text = "Haute Gamme"
        Me.HauteGamme.UseVisualStyleBackColor = True
        '
        'Ancien
        '
        Me.Ancien.AutoSize = True
        Me.Ancien.Location = New System.Drawing.Point(25, 22)
        Me.Ancien.Name = "Ancien"
        Me.Ancien.Size = New System.Drawing.Size(62, 19)
        Me.Ancien.TabIndex = 23
        Me.Ancien.TabStop = True
        Me.Ancien.Text = "Ancien"
        Me.Ancien.UseVisualStyleBackColor = True
        '
        'Nouveau
        '
        Me.Nouveau.AutoSize = True
        Me.Nouveau.Location = New System.Drawing.Point(25, 47)
        Me.Nouveau.Name = "Nouveau"
        Me.Nouveau.Size = New System.Drawing.Size(73, 19)
        Me.Nouveau.TabIndex = 24
        Me.Nouveau.TabStop = True
        Me.Nouveau.Text = "Nouveau"
        Me.Nouveau.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MoyenneGamme)
        Me.GroupBox1.Controls.Add(Me.BasseGamme)
        Me.GroupBox1.Controls.Add(Me.HauteGamme)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 121)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catégories"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Ancien)
        Me.GroupBox2.Controls.Add(Me.Nouveau)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 76)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 511)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabType)
        Me.Controls.Add(Me.LabCategorie)
        Me.Controls.Add(Me.LabQteProduct)
        Me.Controls.Add(Me.LabPrixProduct)
        Me.Controls.Add(Me.labIdProduitError)
        Me.Controls.Add(Me.LabNomProduit)
        Me.Controls.Add(Me.verifier)
        Me.Controls.Add(Me.TextFieldQteProduit)
        Me.Controls.Add(Me.TextFieldPrixProduit)
        Me.Controls.Add(Me.TextField_NomProduit)
        Me.Controls.Add(Me.TextField_NumeroProduit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextField_NumeroProduit As TextBox
    Friend WithEvents TextField_NomProduit As TextBox
    Friend WithEvents TextFieldPrixProduit As TextBox
    Friend WithEvents TextFieldQteProduit As TextBox
    Friend WithEvents verifier As Button
    Friend WithEvents LabNomProduit As Label
    Friend WithEvents labIdProduitError As Label
    Friend WithEvents LabPrixProduct As Label
    Friend WithEvents LabQteProduct As Label
    Friend WithEvents LabCategorie As Label
    Friend WithEvents LabType As Label
    Friend WithEvents BasseGamme As RadioButton
    Friend WithEvents MoyenneGamme As RadioButton
    Friend WithEvents HauteGamme As RadioButton
    Friend WithEvents Ancien As RadioButton
    Friend WithEvents Nouveau As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
