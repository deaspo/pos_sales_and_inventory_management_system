Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Public Class frmSupplier
    Dim rdr As OleDbDataReader = Nothing
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"

    Private Sub auto()
        txtSupplierNo.Text = "SP-" & GetUniqueKey(6)

    End Sub
    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function


    Public Sub clear()
        txtSupplierName.Clear()
        txtSupplierNo.Clear()

        frmSuppliersRecord1.ShowDialog()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If Len(Trim(txtSupplierName.Text)) = 0 Then
            MessageBox.Show("Please enter name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSupplierName.Focus()
            Exit Sub
        End If

        Try
            auto()


            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select supplierno from suppliers where supplierno=@find"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "supplierno"))
            cmd.Parameters("@find").Value = txtSupplierNo.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Supplier ID Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else

                con = New OleDbConnection(cs)
                con.Open()

                Dim cb As String = "insert into suppliers(suppliername,supplierno,addedby) VALUES (@d1,@d2,@d3)"

                cmd = New OleDbCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 100, "suppliername"))

                cmd.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 50, "supplierno"))

                cmd.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 50, "addedby"))

                cmd.Parameters("@d1").Value = txtSupplierName.Text
                cmd.Parameters("@d2").Value = txtSupplierNo.Text
                cmd.Parameters("@d3").Value = frmMain.tlName.Text

                cmd.ExecuteReader()
                MessageBox.Show("Successfully saved", "Supplier Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Save.Enabled = False
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSupplier_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub NewRecord_Click(sender As Object, e As EventArgs) Handles NewRecord.Click
        clear()
        Update_Record.Enabled = False
        Delete.Enabled = False
        Save.Enabled = True
        txtSupplierName.Focus()
    End Sub

    Private Sub btnSelectSupplier_Click(sender As Object, e As EventArgs) Handles btnSelectSupplier.Click
        Me.clear()
        frmSuppliersRecord2.fillName()
        frmSuppliersRecord2.DataGridView1.DataSource = Nothing
        frmSuppliersRecord2.DataGridView2.DataSource = Nothing
        frmSuppliersRecord2.txtName.Text = ""


        frmSuppliersRecord2.ShowDialog()
    End Sub

    Private Sub Update_Record_Click(sender As Object, e As EventArgs) Handles Update_Record.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()

            Dim cb As String = "update [suppliers] Set [suppliername]= '" & txtSupplierName.Text & "',[supplierno] = '" & txtSupplierNo.Text & "' where [supplierno]='" & txtSupplierNo.Text & "'"

            cmd = New OleDbCommand(cb)

            cmd.Connection = con

            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Supplier Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()

            Update_Record.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub delete_records()
        Try

            Dim RowsAffected As Integer = 0

            con = New OleDbConnection(cs)

            con.Open()
            Dim ct As String = "select SupplierNo from Suppliers where supplierNo=@find"


            cmd = New OleDbCommand(ct)

            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "SupplierNo"))


            cmd.Parameters("@find").Value = txtSupplierNo.Text


            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()
                txtSupplierName.Focus()
                Update_Record.Enabled = False
                Delete.Enabled = False


                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)

            con.Open()
            Dim ct1 As String = "select SupplierNo from Product where supplierNo=@find"


            cmd = New OleDbCommand(ct1)

            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "SupplierNo"))


            cmd.Parameters("@find").Value = txtSupplierNo.Text


            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()
                txtSupplierName.Focus()
                Update_Record.Enabled = False
                Delete.Enabled = False


                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)

            con.Open()


            Dim cq As String = "delete from suppliers where SupplierNo=@DELETE1;"


            cmd = New OleDbCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 30, "SupplierNo"))


            cmd.Parameters("@DELETE1").Value = Trim(txtSupplierNo.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()
                txtSupplierName.Focus()
                Update_Record.Enabled = False
                Delete.Enabled = False
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
                txtSupplierName.Focus()
                Update_Record.Enabled = False
                Delete.Enabled = False



                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Supplierr Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                delete_records()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class