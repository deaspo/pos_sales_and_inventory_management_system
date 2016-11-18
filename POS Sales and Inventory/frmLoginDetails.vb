Public Class frmLoginDetails
    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.Product_inventoryDataSet)

    End Sub

    Private Sub frmLoginDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Product_inventoryDataSet1.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter2.Fill(Me.Product_inventoryDataSet1.Employees)
        'TODO: This line of code loads data into the 'Product_inventoryDataSet.Employees' table. You can move, or remove it, as needed.


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit?!", "Warning", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Public Function selectedEmployee() As String
        Dim empRow As Integer = dgLoginDetails.CurrentRow.Index
        Dim empLogin As String = dgLoginDetails.Item(2, empRow).Value
        Return empLogin
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmLogin.logName(selectedEmployee)
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub dgLoginDetails_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLoginDetails.CellDoubleClick
        'activate login click
        btnLogin_Click(sender, e)
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.EmployeesTableAdapter2.FillBy(Me.Product_inventoryDataSet1.Employees)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class