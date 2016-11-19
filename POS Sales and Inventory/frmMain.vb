Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmMain
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable

    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"

    Public Sub TodayOrders()
        Try
            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (OrderNo) as [Order No],(OrderDate) as [Order Date],(OrderStatus) as [Order Status],(CustomerNo) as [Customer ID],(CustomerName) as [Customer Name],(TotalAmount)as [Total Amount] from Orderinfo where OrderStatus='Uncompleted' and OrderDate between #" & Today & "# And #" & Today & "# order by orderinfo.OrderNo,OrderDate", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "OrderInfo")

            DataGridView1.DataSource = myDataSet.Tables("Orderinfo").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReorderStock()
        Try

            con = New OleDbConnection(cs)

            con.Open()
            cmd = New OleDbCommand("SELECT (StockID)as [Stock ID],(StockDate)as [Entry Date],(ProductCode) as [Product Code],(ProductName) as [Product Name],(Category) as [Category],(Weight) as [Weight/Qty],(SupplierName) as [Supplier Name],(SupplierNo) as [Supplier ID],(ProductBy) as [Product Added By],(Cartons) as [Cartons],(Packets) as [Packets],(TotalPackets) as [Total Packets] from Stock where Cartons < 4 order by ProductName", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Stock")

            DataGridView2.DataSource = myDataSet.Tables("Stock").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Product_inventoryDataSet1.InventoryToReorder' table. You can move, or remove it, as needed.
        Me.InventoryToReorderTableAdapter.Fill(Me.Product_inventoryDataSet1.InventoryToReorder)
        'TODO: This line of code loads data into the 'Product_inventoryDataSet1.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.Product_inventoryDataSet1.Orders)

        Me.LayoutMdi(MdiLayout.TileVertical)


        TodayOrders()
        ReorderStock()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click

        frmOrder.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        frmLoginDetails.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        'Me.Hide()
        frmProduct.ShowDialog()
    End Sub

    Private Sub StockToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem2.Click
        frmStock.ShowDialog()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        frmSales.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        frmCustomer.ShowDialog()
    End Sub

    Private Sub SupplierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem1.Click
        frmSupplier.ShowDialog()
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        frmOrder.ShowDialog()

        frmOrder.clear()
    End Sub

    Private Sub btnNewPurchase_Click(sender As Object, e As EventArgs) Handles btnNewPurchase.Click
        frmProduct.ShowDialog()

        frmProduct.clear()
    End Sub
End Class