Module Module1
    'WERTEtyp-Objekte werden bei Zuweisung zu einer anderen Variablen oder bei Übergabe an eine Methode kopiert.
    ''Eine Veränderung der Kopie hat keine Auswirkungen auf das Original-Objekt.
    ''STRUCTUREs sind Klassen-ähnliche Konstrukte welche nicht, wie Klassen, als Referenztypen behandelt werden, sondern ein Wertetyp sind.
    Public Structure SPerson
        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Private _alter As Integer
        Public Property Alter() As Integer
            Get
                Return _alter
            End Get
            Set(ByVal value As Integer)
                _alter = value
            End Set
        End Property

        Public Sub New(name As String, alter As Integer)
            _name = name
            _alter = alter
        End Sub
    End Structure

    'Bei REFERENZtyp-Objekten, wie z.B. Klassenobjekten, wird bei einer Übergabe an eine Methode oder einer Zuweisung
    ''zu einer neuen Variablen die entsprechende Speicherstelle übergeben. D.h. eine Manipulation des Objekts macht sich
    ''bei beiden Variablen bemerkbar, da beide auf dasselbe Objekt zeigen
    Public Class CPerson
        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Private _alter As Integer
        Public Property Alter() As Integer
            Get
                Return _alter
            End Get
            Set(ByVal value As Integer)
                _alter = value
            End Set
        End Property

        Public Sub New(name As String, alter As Integer)
            _name = name
            _alter = alter
        End Sub
    End Class
    Sub Main()

        Dim Klassenperson As CPerson = New CPerson("Hannes", 30)
        Dim Structperson As SPerson = New SPerson("Anna", 30)

        Console.WriteLine(Klassenperson.Name + ": " + Klassenperson.Alter.ToString())
        Console.WriteLine(Structperson.Name + ": " + Structperson.Alter.ToString())

        Altern(Klassenperson)
        Altern(Structperson)

        Console.WriteLine(Klassenperson.Name + ": " + Klassenperson.Alter.ToString())
        Console.WriteLine(Structperson.Name + ": " + Structperson.Alter.ToString())

        WirklichAltern(Structperson)
        Console.WriteLine(Structperson.Name + ": " + Structperson.Alter.ToString())

        Console.ReadKey()

    End Sub

    Public Sub Altern(person As SPerson)
        person.Alter += 1
    End Sub

    Public Sub Altern(person As CPerson)
        person.Alter += 1
    End Sub


    'Mittels des BYREF-Stichworts können Wertetypen als Referenz an Methoden übergeben werden. D.h. die übergebene Speicherstelle selbst 
    ''/wird manipuliert und nicht, wie normalerweise bei Wertetypen, eine Kopie des Werts.
    Public Sub WirklichAltern(ByRef person As SPerson)
        person.Alter += 1
    End Sub

End Module

Public Structure SPerson
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _alter As Integer
    Public Property Alter() As Integer
        Get
            Return _alter
        End Get
        Set(ByVal value As Integer)
            _alter = value
        End Set
    End Property

    Public Sub New(name As String, alter As Integer)
        _name = name
        _alter = alter
    End Sub
End Structure

Public Class CPerson
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _alter As Integer
    Public Property Alter() As Integer
        Get
            Return _alter
        End Get
        Set(ByVal value As Integer)
            _alter = value
        End Set
    End Property

    Public Sub New(name As String, alter As Integer)
        _name = name
        _alter = alter
    End Sub
End Class

