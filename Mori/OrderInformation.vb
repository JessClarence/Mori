Public Module OrderInformation
    Public Sub GetOrders(OrdersList As DataGridView)
        Try
            Dim OrderData As New CustomerData
            Connect()
            query = "SELECT * FROM mori_laundry.create_order"
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

End Module
