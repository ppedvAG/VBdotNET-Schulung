Imports Fahrzeugpark
Module Module1

    Sub Main()

#Region "Modul/Lab 04: Objektorientierte Programmierung"

        ''Deklaration der Fahrzeugvariablen und Initialisierung der Fahrzeugobjekte
        'Dim fz1 As Fahrzeug = New Fahrzeug("BMW", 270, 25000)
        'Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 260, 28000)

        ''Ausgabe der Name- und der MaxGescshwindifkeit-Properties von fz1 (über deren Getter)
        'Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit.ToString())

        ''Manipulation der Name-Property von fz1 (über deren Setter)
        'fz1.Name = "Mercedes"
        'Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit.ToString())

        ''Ausführen einer Methode von fz1
        'fz1.StarteMotor()
        'fz1.Beschleunige(80)

        ''Ausgabe der AktGeschwindigkeit-Properties
        'Console.WriteLine(fz1.AktGeschwindigkeit)
        'Console.WriteLine(fz2.AktGeschwindigkeit)

        ''Ausführen von Methoden von fz1
        'fz1.Beschleunige(300)

        ''Ausgabe der BeschreibeMich()-Methoden
        'Console.WriteLine(fz1.BeschreibeMich())
        'Console.WriteLine(fz2.BeschreibeMich())

#End Region

        Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)

        Console.WriteLine(pkw1.BeschreibeMich())

        pkw1.Hupen()

        Console.ReadKey()
    End Sub

End Module
