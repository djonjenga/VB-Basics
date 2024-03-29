Public Class ObjectDemonstrationsForm

    Private defaultImagePath As String = "C:\Users\NJENGA\Pictures\Saved Pictures\download.jpg"

    Private Sub btnLoadPicture_Click(sender As Object, e As EventArgs) Handles btnLoadPicture.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        If openFileDialog.ShowDialog() = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub RadioButtonFont_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGaramond.CheckedChanged, rdoMagneto.CheckedChanged, rdoTahoma.CheckedChanged

        Dim selectedFont As String = DirectCast(sender, RadioButton).Text
        txtSampleText.Font = New Font(selectedFont, txtSampleText.Font.Size, txtSampleText.Font.Style)
    End Sub

    Private Sub RadioButtonFontStyle_CheckedChanged(sender As Object, e As EventArgs) Handles rdoItalic.CheckedChanged, rdoBold.CheckedChanged, rdoItalic.CheckedChanged

        Dim currentFont As Font = txtSampleText.Font
        Dim newFontStyle As FontStyle

        If rdoItalic.Checked Then
            newFontStyle = FontStyle.Italic
        ElseIf rdoBold.Checked Then
            newFontStyle = FontStyle.Bold
        ElseIf rdoBoldItalic.Checked Then
            newFontStyle = FontStyle.Bold Or FontStyle.Italic
        Else
            newFontStyle = FontStyle.Regular
        End If

        txtSampleText.Font = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
    End Sub

    Private Sub RadioButtonFontColor_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGreen.CheckedChanged, rdoBlue.CheckedChanged, rdoRed.CheckedChanged

        Dim selectedColor As Color

        If rdoGreen.Checked Then
            selectedColor = Color.Green
        ElseIf rdoBlue.Checked Then
            selectedColor = Color.Blue
        ElseIf rdoRed.Checked Then
            selectedColor = Color.Red
        Else
            selectedColor = Color.Black
        End If

        txtSampleText.ForeColor = selectedColor
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub FormTwo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtSampleText.Text = "Sample Text"
        If System.IO.File.Exists(defaultImagePath) Then

            PictureBox1.Image = Image.FromFile(defaultImagePath)
        Else
            MessageBox.Show("Image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class

