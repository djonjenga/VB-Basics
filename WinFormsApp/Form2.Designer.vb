<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemonstrationsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        txtSampleText = New TextBox()
        GroupBox2 = New GroupBox()
        rdoTahoma = New RadioButton()
        rdoMagneto = New RadioButton()
        rdoGaramond = New RadioButton()
        GroupBox3 = New GroupBox()
        rdoBoldItalic = New RadioButton()
        rdoBold = New RadioButton()
        rdoItalic = New RadioButton()
        GroupBox4 = New GroupBox()
        rdoRed = New RadioButton()
        rdoBlue = New RadioButton()
        rdoGreen = New RadioButton()
        PictureBox1 = New PictureBox()
        btnLoadPicture = New Button()
        btnExit = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtSampleText)
        GroupBox1.Location = New Point(12, 105)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(289, 91)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Text"
        ' 
        ' txtSampleText
        ' 
        txtSampleText.Location = New Point(50, 41)
        txtSampleText.Name = "txtSampleText"
        txtSampleText.Size = New Size(150, 31)
        txtSampleText.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rdoTahoma)
        GroupBox2.Controls.Add(rdoMagneto)
        GroupBox2.Controls.Add(rdoGaramond)
        GroupBox2.Location = New Point(321, 105)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(467, 91)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' rdoTahoma
        ' 
        rdoTahoma.AutoSize = True
        rdoTahoma.Location = New Point(311, 34)
        rdoTahoma.Name = "rdoTahoma"
        rdoTahoma.Size = New Size(99, 29)
        rdoTahoma.TabIndex = 2
        rdoTahoma.TabStop = True
        rdoTahoma.Text = "Tahoma"
        rdoTahoma.UseVisualStyleBackColor = True
        ' 
        ' rdoMagneto
        ' 
        rdoMagneto.AutoSize = True
        rdoMagneto.Location = New Point(158, 32)
        rdoMagneto.Name = "rdoMagneto"
        rdoMagneto.Size = New Size(109, 29)
        rdoMagneto.TabIndex = 1
        rdoMagneto.TabStop = True
        rdoMagneto.Text = "Magneto"
        rdoMagneto.UseVisualStyleBackColor = True
        ' 
        ' rdoGaramond
        ' 
        rdoGaramond.AutoSize = True
        rdoGaramond.Location = New Point(6, 32)
        rdoGaramond.Name = "rdoGaramond"
        rdoGaramond.Size = New Size(121, 29)
        rdoGaramond.TabIndex = 0
        rdoGaramond.TabStop = True
        rdoGaramond.Text = "Garamond"
        rdoGaramond.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rdoBoldItalic)
        GroupBox3.Controls.Add(rdoBold)
        GroupBox3.Controls.Add(rdoItalic)
        GroupBox3.Location = New Point(390, 202)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(181, 251)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' rdoBoldItalic
        ' 
        rdoBoldItalic.AutoSize = True
        rdoBoldItalic.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdoBoldItalic.Location = New Point(24, 189)
        rdoBoldItalic.Name = "rdoBoldItalic"
        rdoBoldItalic.Size = New Size(125, 29)
        rdoBoldItalic.TabIndex = 2
        rdoBoldItalic.Text = "Bold Italic"
        rdoBoldItalic.UseVisualStyleBackColor = True
        ' 
        ' rdoBold
        ' 
        rdoBold.AutoSize = True
        rdoBold.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdoBold.Location = New Point(24, 125)
        rdoBold.Name = "rdoBold"
        rdoBold.Size = New Size(76, 29)
        rdoBold.TabIndex = 1
        rdoBold.Text = "Bold"
        rdoBold.UseVisualStyleBackColor = True
        ' 
        ' rdoItalic
        ' 
        rdoItalic.AutoSize = True
        rdoItalic.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdoItalic.Location = New Point(24, 61)
        rdoItalic.Name = "rdoItalic"
        rdoItalic.Size = New Size(76, 29)
        rdoItalic.TabIndex = 0
        rdoItalic.Text = "Italic"
        rdoItalic.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(rdoRed)
        GroupBox4.Controls.Add(rdoBlue)
        GroupBox4.Controls.Add(rdoGreen)
        GroupBox4.Location = New Point(594, 202)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(194, 251)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Color"
        ' 
        ' rdoRed
        ' 
        rdoRed.AutoSize = True
        rdoRed.Location = New Point(22, 185)
        rdoRed.Name = "rdoRed"
        rdoRed.Size = New Size(67, 29)
        rdoRed.TabIndex = 2
        rdoRed.TabStop = True
        rdoRed.Text = "Red"
        rdoRed.UseVisualStyleBackColor = True
        ' 
        ' rdoBlue
        ' 
        rdoBlue.AutoSize = True
        rdoBlue.Location = New Point(22, 123)
        rdoBlue.Name = "rdoBlue"
        rdoBlue.Size = New Size(70, 29)
        rdoBlue.TabIndex = 1
        rdoBlue.TabStop = True
        rdoBlue.Text = "Blue"
        rdoBlue.UseVisualStyleBackColor = True
        ' 
        ' rdoGreen
        ' 
        rdoGreen.AutoSize = True
        rdoGreen.Location = New Point(22, 61)
        rdoGreen.Name = "rdoGreen"
        rdoGreen.Size = New Size(83, 29)
        rdoGreen.TabIndex = 0
        rdoGreen.TabStop = True
        rdoGreen.Text = "Green"
        rdoGreen.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 233)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(299, 220)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btnLoadPicture
        ' 
        btnLoadPicture.Location = New Point(48, 482)
        btnLoadPicture.Name = "btnLoadPicture"
        btnLoadPicture.Size = New Size(207, 34)
        btnLoadPicture.TabIndex = 5
        btnLoadPicture.Text = "Load Picture"
        btnLoadPicture.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(632, 482)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-3, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(804, 86)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(243, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 38)
        Label1.TabIndex = 0
        Label1.Text = "Object Demonstrations"
        ' 
        ' ObjectDemonstrationsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 528)
        Controls.Add(Panel1)
        Controls.Add(btnExit)
        Controls.Add(btnLoadPicture)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ObjectDemonstrationsForm"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLoadPicture As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtSampleText As TextBox
    Friend WithEvents rdoMagneto As RadioButton
    Friend WithEvents rdoGaramond As RadioButton

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMagneto.CheckedChanged

    End Sub

    Friend WithEvents rdoTahoma As RadioButton
    Friend WithEvents rdoBoldItalic As RadioButton
    Friend WithEvents rdoBold As RadioButton
    Friend WithEvents rdoItalic As RadioButton
    Friend WithEvents rdoRed As RadioButton
    Friend WithEvents rdoBlue As RadioButton
    Friend WithEvents rdoGreen As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
