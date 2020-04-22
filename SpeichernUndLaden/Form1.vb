Imports System.IO

Public Class Form1
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'Deklaration des StreamWriters außerhalb des Try-Blocks
        Dim writer As StreamWriter = Nothing

        'Start des Try-Blocks
        Try
            'Deklaration und Initialisierung des Speichern-Dialogfensters
            Dim saveDialog = New SaveFileDialog()

            'Setzen der Properties des Dialogfensters
            saveDialog.FileName = "abgespeicherterText.txt"
            saveDialog.InitialDirectory = "C:\"
            saveDialog.Filter = "Textdatei|*.txt|MeineDateiEndung|*.mda|Alle Dateien|*.*"

            'Anzeigen des Dialogfensters und Abfrage der Benutzerwahl
            If saveDialog.ShowDialog() = DialogResult.OK Then

                'Initialisierung des StreamWriters im Try-Block mit Übergabe des gewählten Speicherorts
                writer = New StreamWriter(saveDialog.FileName)

                'Abspeichern der Strings in der gewählten Datei
                writer.WriteLine(TbxInput.Text)

                'Ausgabe einer Erfolgsmeldung
                MessageBox.Show("Speichern erfolgreich")

            End If
        Catch ex As Exception
            'Ausgabe einer Misserfolgsmeldung
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally
            'Schließen der Verbindung im Finally-Block, damit andere Programme Zugriff auf die Datei haben
            '' ? <- Nullprüfung der Variable writer (wenn Null, dann wird die Methode nicht aufgerufen)
            writer?.Close()

        End Try
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        ''vgl. auch btnSave_Click()
        Dim reader As StreamReader = Nothing

        Try
            Dim openDialog = New OpenFileDialog()

            openDialog.FileName = "abgespeicherterText.txt"
            openDialog.InitialDirectory = "C:\"
            openDialog.Filter = "Textdatei|*.txt|MeineDateiEndung|*.mda|Alle Dateien|*.*"

            If openDialog.ShowDialog() = DialogResult.OK Then
                TbxInput.Text = String.Empty
                TbxInput.Clear()

                reader = New StreamReader(openDialog.FileName)

                'Schleife zum Durchlaufen der Datei
                While Not reader.EndOfStream
                    'Auslesen einer Textzeile aus der Datei
                    TbxInput.Text += reader.ReadLine()
                End While

                MessageBox.Show("Laden erfolgreich")
            End If
        Catch ex As Exception
            MessageBox.Show("Laden fehlgeschlagen")

        Finally
            reader?.Close()
        End Try

    End Sub
End Class
