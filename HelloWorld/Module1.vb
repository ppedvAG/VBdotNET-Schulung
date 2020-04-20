'MODULE sind grundlegende Programmeinheiten, von welchen sich keine Instanzen erstellen lassen. Sie beinhalten nur ausführbaren Code
''der einer bestimmten Aufgabe zugeordnet ist.
Module Module1

    'Die Main()-Methode ist der Einstiegspunkt in jedes .NET-Programm. Hier startet das Programm.
    Sub Main()

        'Deklaration einer String-Variablen
        Dim meinString As String
        'Initialisierung der String-Variablen
        meinString = "Hello World"

        'Ausgabe der String-Variablen in der Konsole
        Console.WriteLine(meinString)
        'Ausgabe eines String-Literals in der Konsole
        Console.WriteLine("Mein Name ist Klaas")


        'Deklaration und Initialisierung weiterer Variablen (hier: in einer Zeile)
        Dim Alter As Integer = 31
        Dim Stadt As String = "Berlin"


        'String-Formatierungen
        ''"traditionelle" Verknüpfung durch +-Operatoren (Nicht-Strings müssen explizit umgewandelt werden
        Console.WriteLine("Ich wohne in " + Stadt + " und bin " + Alter.ToString() + " Jahre alt.")
        Dim kombinierterString As String = "Ich wohne in " + Stadt + " und bin " + Alter.ToString() + " Jahre alt."
        ''Indexschreibweise -> Null-basierte Indizes werden durch angegebene Variablen ausgetauscht
        Console.WriteLine("Ich wohne in {0} und bin {1} Jahre alt.", Stadt, Alter)
        ''$-Schreibweise -> Variablen werden direkt im String plaziert
        Console.WriteLine($"Ich wohne in {Stadt} und bin {Alter} Jahre alt.")
        kombinierterString = $"Ich wohne in {Stadt} und bin {Alter} Jahre alt."


        'Formatierung durch Konstanten
        ''vbNewLine -> erzwingt Zeilenumbruch
        ''vbTab -> erzwingt horizontalen Tabulator
        Console.WriteLine($"Dies ist ein {vbNewLine}Zeilenumbruch und dies{vbTab} ein horizontaler Tabulator.")
        'Deklaration und Initialisierung einer eigenen Konstanten
        Const PI As Integer = 3.14


        'Speichern einer Benutzereingabe (String) in einer Variablen
        Dim inputString As String = Console.ReadLine()
        'Ausgabe des Strings
        Console.WriteLine("Du hast eingegeben: " + inputString)

        Console.WriteLine("Bitte gib eine ganze Zahl ein: ")
        inputString = Console.ReadLine()
        'Parsen (Umwandlung) des Strings in einen Integer
        Dim zahl As Integer = Integer.Parse(inputString)
        'Verdopplung des eingegebenen Werts
        zahl = zahl * 2
        'Ausgabe
        Console.WriteLine("Das Doppelte deiner Eingabe ist: " + zahl.ToString())

        'Programmpause
        Console.ReadKey()

    End Sub

End Module
