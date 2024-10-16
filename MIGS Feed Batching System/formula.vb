Public Class formula
    Private _id As Integer
    Private _formulaName As String
    Private _silo1 As Double
    Private _silo2 As Double
    Private _silo3 As Double
    Private _silo4 As Double
    Private _silo5 As Double
    Private _silo6 As Double
    Private _silo7 As Double
    Private _silo8 As Double
    Private _molasses As Double
    Private _cocoOil As Double

    Public Sub New(id As Integer, formulaName As String, silo1 As Double, silo2 As Double, silo3 As Double, silo4 As Double, silo5 As Double, silo6 As Double, silo7 As Double, silo8 As Double, molasses As Double, cocoOil As Double)
        Me.Id = id
        Me.FormulaName = formulaName
        Me.Silo1 = silo1
        Me.Silo2 = silo2
        Me.Silo3 = silo3
        Me.Silo4 = silo4
        Me.Silo5 = silo5
        Me.Silo6 = silo6
        Me.Silo7 = silo7
        Me.Silo8 = silo8
        Me.Molasses = molasses
        Me.CocoOil = cocoOil
    End Sub



    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property FormulaName As String
        Get
            Return _formulaName
        End Get
        Set(value As String)
            _formulaName = value
        End Set
    End Property

    Public Property Silo1 As Double
        Get
            Return _silo1
        End Get
        Set(value As Double)
            _silo1 = value
        End Set
    End Property

    Public Property Silo2 As Double
        Get
            Return _silo2
        End Get
        Set(value As Double)
            _silo2 = value
        End Set
    End Property

    Public Property Silo3 As Double
        Get
            Return _silo3
        End Get
        Set(value As Double)
            _silo3 = value
        End Set
    End Property

    Public Property Silo4 As Double
        Get
            Return _silo4
        End Get
        Set(value As Double)
            _silo4 = value
        End Set
    End Property

    Public Property Silo5 As Double
        Get
            Return _silo5
        End Get
        Set(value As Double)
            _silo5 = value
        End Set
    End Property

    Public Property Silo6 As Double
        Get
            Return _silo6
        End Get
        Set(value As Double)
            _silo6 = value
        End Set
    End Property

    Public Property Silo7 As Double
        Get
            Return _silo7
        End Get
        Set(value As Double)
            _silo7 = value
        End Set
    End Property

    Public Property Silo8 As Double
        Get
            Return _silo8
        End Get
        Set(value As Double)
            _silo8 = value
        End Set
    End Property

    Public Property Molasses As Double
        Get
            Return _molasses
        End Get
        Set(value As Double)
            _molasses = value
        End Set
    End Property

    Public Property CocoOil As Double
        Get
            Return _cocoOil
        End Get
        Set(value As Double)
            _cocoOil = value
        End Set
    End Property
End Class
