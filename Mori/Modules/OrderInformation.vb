Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Module OrderInformation
    Public Sub GetOrders(OrdersList As DataGridView)
        Try
            Dim OrderData As New CustomerData
            Connect()
            query = "SELECT * FROM mori_laundry.create_order WHERE payment = 'process'"
            With Command
                .Connection = conn
                .CommandText = query
                reader = .ExecuteReader
            End With
            OrdersList.Rows.Clear()
            While reader.Read
                With OrderData
                    .OrderNumber = reader.GetInt32("OrderNumber")
                    .CustomerName = reader.GetString("CustomerName")
                    .Address = reader.GetString("Address")
                    .ContactNum = reader.GetString("ContactNum")
                    .GarmentType = reader.GetString("GarmentType")
                    .Service = reader.GetString("Service")
                    .Kilogram = reader.GetDouble("Kilogram")
                    .SelfService = reader.GetString("SelfService")
                    .fabCon = reader.GetString("fabCon")
                    .FabConQty = reader.GetInt32("FabConQty")
                    .Powder = reader.GetString("Powder")
                    .PowderQty = reader.GetInt32("PowderQty")
                    .DateToPickUp = reader.GetDateTime("DateToPickUp").ToString("dd-MM-yyyy")
                    .TimeToPickUp = reader.GetString("TimeToPickUp")
                    .PMorAM = reader.GetString("PMorAM")
                    .Total = reader.GetInt16("Total")

                End With
                OrdersList.Rows.Add(OrderData.OrderNumber,
                                    OrderData.CustomerName,
                                    OrderData.Address,
                                    OrderData.ContactNum,
                                    OrderData.GarmentType,
                                    OrderData.Service,
                                    OrderData.Kilogram,
                                    OrderData.SelfService,
                                    OrderData.fabCon,
                                    OrderData.FabConQty,
                                    OrderData.Powder,
                                    OrderData.PowderQty,
                                    OrderData.DateToPickUp,
                                    OrderData.TimeToPickUp,
                                    OrderData.PMorAM,
                                    OrderData.Total)
            End While

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub GetProducts(OrdersList As DataGridView)
        Try
            Dim OrderData As New CustomerData
            Connect()
            query = "SELECT * FROM mori_laundry.product"
            With Command
                .Connection = conn
                .CommandText = query
                reader = .ExecuteReader
            End With
            OrdersList.Rows.Clear()
            While reader.Read
                With OrderData
                    .ProductID = reader("id").ToString()
                    .ProductName = reader("product").ToString()
                    .Type = reader("type").ToString()
                    .Amount = reader("amount").ToString()
                End With
                OrdersList.Rows.Add(OrderData.ProductID, OrderData.ProductName, OrderData.Type, OrderData.Amount)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function GetFabConProducts() As List(Of KeyValuePair(Of Integer, String))
        Dim fabConProducts As New List(Of KeyValuePair(Of Integer, String))()

        Try
            Connect() ' Assuming Connect() establishes the MySQL database connection
            Dim query As String = "SELECT product,amount FROM mori_laundry.product WHERE type = 'FabCon'"

            Using Command As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = Command.ExecuteReader()
                    While reader.Read()
                        Dim amount As Integer = DirectCast(reader("amount"), Integer)
                        Dim productName As String = DirectCast(reader("product"), String)
                        fabConProducts.Add(New KeyValuePair(Of Integer, String)(amount, productName))
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Return fabConProducts
    End Function

    Public Function GetPowderProducts() As List(Of KeyValuePair(Of Integer, String))
        Dim fabConProducts As New List(Of KeyValuePair(Of Integer, String))()

        Try
            Connect() ' Assuming Connect() establishes the MySQL database connection
            Dim query As String = "SELECT product,amount FROM mori_laundry.product WHERE type = 'Powder'"

            Using Command As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = Command.ExecuteReader()
                    While reader.Read()
                        Dim amount As Integer = DirectCast(reader("amount"), Integer)
                        Dim productName As String = DirectCast(reader("product"), String)
                        fabConProducts.Add(New KeyValuePair(Of Integer, String)(amount, productName))
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Return fabConProducts
    End Function




End Module
