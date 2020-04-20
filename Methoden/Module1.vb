Module Module1

    'Methoden sind Programmteile, von denen jeder eine sehr spezielle und kleinteilige Aufgabe ausführt.
    ''Es wird unterschieden zwischen Prozeduren, welche keinen Rückgabewert besitzen und mit dem Stichwort
    ''SUB gekennzeichnet sind...
    Sub AddiereUndGibAus(a As Integer, b As Integer)
        Dim summe = a + b
        Console.WriteLine(summe)
    End Sub

    '...und Funktionen, die einen Rückgabewert besitzen und mit dem Stichwort FUNCTION markiert werden.
    ''Jede Methode besteht aus einem Kopf (einer Signatur) in welchem der Zugriff und die Methodenart
    ''definiert werden, ein Bezeichner für die Methode bestimmt wird und Übergabeparameter (und Rückgabe-
    ''wert bei Funktionen) definiert werden... 
    Function Addiere(a As Integer, b As Integer) As Integer
        '...und einem Körper, in welchem die Programmlogik hinterlegt wird.
        ''Mittels des RETURN-Befehls wird in Funktionen der Rückgabewert an den Aufrufer gesand und die
        ''Ausführung der Methode unterbrochen
        Dim summe = a + b
        Return summe
    End Function

    'Methoden, welche den gleichen Bezeichner haben aber unterschiedliche Übergabeparameter heißen 'ÜBERLADENE
    ''Methoden'. Eine Eindeutigkeit wird durch die verschiedenen Übergabeparameter erzielt. 
    Function Addiere(a As Double, b As Double) As Double
        Dim summe = a + b
        Return summe
    End Function

    'Mit dem OPTIONAL-Stichwort kann man Default-Werte für die Übergabeparameter definieren. Diese werden
    ''bei Nicht-Angabe der Parameter während des Methodenaufrufs eingesetzt.
    Function Addiere(a As Integer, b As Integer, c As Integer, Optional d As Integer = 0) As Integer
        Dim summe = a + b + c + d
        Return summe
    End Function

    Sub Main()

        'Prozeduraufruf
        AddiereUndGibAus(45, 78)
        AddiereUndGibAus(23, 78)
        AddiereUndGibAus(4556, 78)
        AddiereUndGibAus(-87, 78)

        'Funktionsaufruf (Addiere(int,int))
        Dim erg As Integer = Addiere(12, 89)

        'Funktionsaufruf (Addiere(double,double))
        Dim dblErg As Double = Addiere(12.3, 45.8)

        'Funktionsaufruf (Addiere mit optionalem Parameter)
        erg = Addiere(12, 12, 45)

        Console.ReadKey()

    End Sub

End Module
