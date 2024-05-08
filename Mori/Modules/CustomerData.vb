Imports Google.Protobuf.WellKnownTypes
Imports ZstdSharp.Unsafe
Public Class CustomerData
    Private _OrderNumber As Integer
    Public Property OrderNumber() As Integer
        Get
            Return _OrderNumber
        End Get
        Set(ByVal value As Integer)
            _OrderNumber = value
        End Set
    End Property
    Private _CustomerName As String
    Public Property CustomerName() As String
        Get
            Return _CustomerName
        End Get
        Set(ByVal value As String)
            _CustomerName = value
        End Set
    End Property
    Private _Address As String
    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            _Address = value
        End Set
    End Property
    Private _ContactNum As String
    Public Property ContactNum() As String
        Get
            Return _ContactNum
        End Get
        Set(ByVal value As String)
            _ContactNum = value
        End Set
    End Property
    Private _GarmentType As String
    Public Property GarmentType() As String
        Get
            Return _GarmentType
        End Get
        Set(ByVal value As String)
            _GarmentType = value
        End Set
    End Property
    Private _Service As String
    Public Property Service() As String
        Get
            Return _Service
        End Get
        Set(ByVal value As String)
            _Service = value
        End Set
    End Property
    Private _Kilogram As Double
    Public Property Kilogram() As Double
        Get
            Return _Kilogram
        End Get
        Set(ByVal value As Double)
            _Kilogram = value
        End Set
    End Property
    Private _SelfService As String
    Public Property SelfService() As String
        Get
            Return _SelfService
        End Get
        Set(ByVal value As String)
            _SelfService = value
        End Set
    End Property
    Private _fabCon As String
    Public Property fabCon() As String
        Get
            Return _fabCon
        End Get
        Set(ByVal value As String)
            _fabCon = value
        End Set
    End Property
    Private _FabConQty As Integer
    Public Property FabConQty() As Integer
        Get
            Return _FabConQty
        End Get
        Set(ByVal value As Integer)
            _FabConQty = value
        End Set
    End Property

    Private _Powder As String
    Public Property Powder() As String
        Get
            Return _Powder
        End Get
        Set(ByVal value As String)
            _Powder = value
        End Set
    End Property
    Private _PowderQty As Integer
    Public Property PowderQty() As Integer
        Get
            Return _PowderQty
        End Get
        Set(ByVal value As Integer)
            _PowderQty = value
        End Set
    End Property
    Private _DateToPickUp As Date
    Public Property DateToPickUp() As Date
        Get
            Return _DateToPickUp
        End Get
        Set(ByVal value As Date)
            _DateToPickUp = value
        End Set
    End Property
    Private _TimeToPickUp As String
    Public Property TimeToPickUp() As String
        Get
            Return _TimeToPickUp
        End Get
        Set(ByVal value As String)
            _TimeToPickUp = value
        End Set
    End Property
    Private _PMorAm As String
    Public Property PMorAM() As String
        Get
            Return _PMorAm
        End Get
        Set(ByVal value As String)
            _PMorAm = value
        End Set
    End Property
    Private _Total As String
    Public Property Total() As Integer
        Get
            Return _Total
        End Get
        Set(ByVal value As Integer)
            _Total = value
        End Set
    End Property

    'Product'
    Private _ProductName As String
    Public Property ProductName() As String
        Get
            Return _ProductName
        End Get
        Set(ByVal value As String)
            _ProductName = value
        End Set
    End Property

    Private _Type As String
    Public Property Type() As String
        Get
            Return _Type
        End Get
        Set(ByVal value As String)
            _Type = value
        End Set
    End Property

    Private _Amount As Integer
    Public Property Amount() As Integer
        Get
            Return _Amount
        End Get
        Set(ByVal value As Integer)
            _Amount = value
        End Set
    End Property

    Private _ProductID As String
    Public Property ProductID() As String
        Get
            Return _ProductID
        End Get
        Set(ByVal value As String)
            _ProductID = value
        End Set
    End Property
End Class









