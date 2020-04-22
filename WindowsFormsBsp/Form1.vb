Public Class WndMain

    Public Sub New()

        ' Diese Methode initialisiert die im Designer definierten Objekte. Diese Methode sollte immer die erste Methode sein,
        ''welche der Konstruktor eines Forms aufruft
        InitializeComponent()

        CbbAuswahl.Items.Add("Element4")

    End Sub

    'Events, welche von GUI-Elementen unter bestimmten Umständen geworfen werden, sind spezielle Delegates.
    ''Methoden, welche durch diese Events ausgeführt werden sollen, können mittels des HANDLES-Stichworts an
    ''Events gebunden werden
    Private Sub BtnKlickMich_Click(sender As Object, e As EventArgs) Handles BtnKlickMich.Click

        BtnKlickMich.Left += 100

        If MessageBox.Show(CbbAuswahl.SelectedItem, "Ausgewähltes Element", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then

            Me.BackColor = Color.HotPink

        End If

        If ChbPruefung.Checked Then

            Dim neuesFenster As ZweitesFenster = New ZweitesFenster()

            neuesFenster.ShowDialog()

        End If


        Dim ausgabe As String = ""

        For index = 0 To ClbBeispiel.Items.Count - 1

            If ClbBeispiel.GetItemChecked(index) Then

                ausgabe = ausgabe + ClbBeispiel.Items(index) + vbNewLine

            End If

        Next

        MessageBox.Show(ausgabe)

    End Sub

End Class
