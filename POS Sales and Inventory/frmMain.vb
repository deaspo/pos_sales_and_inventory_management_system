Imports System.ComponentModel

Public Class frmMain
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
        frmCustomer.showdialog
    End Sub

    Private Sub SupplierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem1.Click
        frmSupplier.ShowDialog()
    End Sub
End Class