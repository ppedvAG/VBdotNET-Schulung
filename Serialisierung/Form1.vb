Imports System.IO
Imports Fahrzeugpark
Imports Newtonsoft.Json

Public Class Form1
    'Click()-Methoden der Buttons
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ErzeugeFz()
        ZeigeFz()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SpeichereFz()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LadeFz()
        ZeigeFz()
    End Sub

    'Deklaration und Initialisierung der benötigten Objekte
    Private fzList As List(Of Fahrzeug) = New List(Of Fahrzeug)

    'Methode zum Hinzufügen eines Fahrzeugs in die Liste
    Private Sub ErzeugeFz()
        fzList.Add(New PKW("BMW", 25000, 250, 5))
    End Sub

    'Methode zum Anzeigen der Fahrzeuge in der GUI
    Private Sub ZeigeFz()
        lblOutput.Text = String.Empty
        For Each fz In fzList
            lblOutput.Text += fz.Name + vbNewLine
        Next
    End Sub

    Private Sub SpeichereFz()
        'vgl auch Modul10_LadenUndSpeichern.btnSave_Click()
        Dim writer As StreamWriter = Nothing

        Try
            'Erstellen der Settings (damit der Objekt-Typ gespeichert wird)
            Dim settings = New JsonSerializerSettings()
            settings.TypeNameHandling = TypeNameHandling.Objects

            writer = New StreamWriter("fzliste.txt")

            'Schleife zum Durchlaufen der FahrzeugListe
            For Each fz In fzList
                'Umwandlung (Serialisierung) der Fahrzeuge in Strings unter Berücksichtigung der settings
                Dim fzString = JsonConvert.SerializeObject(fz, settings)
                'Abspeichern der Strings in der gewählten Datei
                writer.WriteLine(fzString)
            Next

            MessageBox.Show("Erfolgreich")
        Catch ex As Exception
            MessageBox.Show("Fehlgeschlagen")

        Finally
            writer?.Close()
        End Try

    End Sub

    Private Sub LadeFz()
        'vgl. SpeichereFz()
        Dim reader As StreamReader = Nothing

        Try
            Dim settings = New JsonSerializerSettings()
            settings.TypeNameHandling = TypeNameHandling.Objects

            reader = New StreamReader("fzliste.txt")

            fzList.Clear()

            While Not reader.EndOfStream
                Dim fzString = reader.ReadLine()

                Dim fz As Fahrzeug = JsonConvert.DeserializeObject(Of Fahrzeug)(fzString, settings)

                fzList.Add(fz)
            End While

            MessageBox.Show("Erfolgreich")
        Catch ex As Exception
            MessageBox.Show("Fehlgeschlagen")

        Finally
            reader?.Close()
        End Try
    End Sub

End Class
