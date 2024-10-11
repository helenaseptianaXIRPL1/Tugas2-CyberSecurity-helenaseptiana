Imports System.IO

Public Class Form1
    ' Deklarasi folderBrowser sebagai variabel kelas
    Private folderBrowser As New FolderBrowserDialog()

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

    Private currentFilePath As String = String.Empty
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Text Files|*.txt"
        If openFile.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = File.ReadAllText(openFile.FileName)
        End If

        currentFilePath = openFile.FileName
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveFile As New SaveFileDialog()
        saveFile.Filter = "Text Files|*.txt"
        If saveFile.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(saveFile.FileName, TextBox1.Text)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem.Click
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            Dim selectedFolder As String = folderBrowser.SelectedPath
            DisplayFilesInListBox(selectedFolder)
        End If
    End Sub

    Private Sub DisplayFilesInListBox(folderPath As String)
        ListBox1.Items.Clear()

        Try
            Dim files As String() = Directory.GetFiles(folderPath)

            For Each file As String In files
                ListBox1.Items.Add(Path.GetFileName(file))
            Next
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat membaca folder: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem IsNot Nothing Then
            ' Mendapatkan nama file yang dipilih
            Dim selectedFile As String = ListBox1.SelectedItem.ToString()

            ' Mendapatkan path folder yang saat ini dipilih
            Dim folderPath As String = folderBrowser.SelectedPath

            ' Menggabungkan folder path dan nama file untuk mendapatkan path lengkap
            Dim fullPath As String = Path.Combine(folderPath, selectedFile)

            ' Membaca isi file dan menampilkannya di TextBox1
            If File.Exists(fullPath) Then
                TextBox1.Text = File.ReadAllText(fullPath)
            Else
                MessageBox.Show("File tidak ditemukan: " & fullPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        If String.IsNullOrEmpty(currentFilePath) Then
            ' Jika tidak ada nama file yang sudah disimpan, gunakan SaveFileDialog
            Dim saveFile As New SaveFileDialog()
            saveFile.Filter = "Text Files|*.txt"

            If saveFile.ShowDialog() = DialogResult.OK Then
                Try
                    ' Menyimpan isi TextBox1 ke dalam file yang dipilih
                    File.WriteAllText(saveFile.FileName, TextBox1.Text)
                    currentFilePath = saveFile.FileName ' Simpan path file
                    MessageBox.Show("File berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan saat menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            ' Jika sudah ada nama file, simpan langsung tanpa dialog
            Try
                File.WriteAllText(currentFilePath, TextBox1.Text)
                MessageBox.Show("File berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class


