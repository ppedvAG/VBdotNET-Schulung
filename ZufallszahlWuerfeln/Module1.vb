Module Module1

    Sub Main()

        Dim eingabe As Integer

        Dim generator As Random = New Random()

        Dim zufälligeZahl As Integer = generator.Next(1, 6)

        Do

            Console.Write("Bitte gib eine Zahl zwischen 1 und 5 ein: ")
            eingabe = Integer.Parse(Console.ReadLine())

            If eingabe > zufälligeZahl Then

                Console.WriteLine("Deine Zahl ist zu groß")

            ElseIf eingabe < zufälligeZahl Then

                Console.WriteLine("Deine Zahl ist zu klein")

            Else

                Console.WriteLine("Treffer. Du hast die richtige Zahl gefunden. Herzlichen Glückwunsch")

            End If

        Loop While eingabe <> zufälligeZahl


        Console.ReadKey()

    End Sub

End Module
