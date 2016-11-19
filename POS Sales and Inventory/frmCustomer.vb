Imports System.Data.OleDB
Imports System.Security.Cryptography
Imports System.Text

Public Class frmCustomer
    Dim rdr As OleDbDataReader = Nothing
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"

    Private Sub auto()
        txtCustomerNo.Text = "SD-" & GetUniqueKey(6)

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
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If Len(Trim(B_name.Text)) = 0 Then
            MessageBox.Show("Please enter name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            B_name.Focus()
            Exit Sub
        End If

        If Len(Trim(B_Address.Text)) = 0 Then
            MessageBox.Show("Please enter address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            B_Address.Focus()
            Exit Sub
        End If
        If Len(Trim(B_City.Text)) = 0 Then
            MessageBox.Show("Please enter city", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            B_City.Focus()
            Exit Sub
        End If
        If Len(Trim(B_State.Text)) = 0 Then
            MessageBox.Show("Please select state", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            B_State.Focus()
            Exit Sub
        End If
        If Len(Trim(B_ZipCode.Text)) = 0 Then
            MessageBox.Show("Please enter zip/post code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            B_ZipCode.Focus()
            Exit Sub
        End If

        If Len(Trim(txtMobileNo.Text)) = 0 Then
            MessageBox.Show("Please enter mobile no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMobileNo.Focus()
            Exit Sub
        End If

        Try
            auto()
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select customerno from customer where customerno=@find"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "customerno"))
            cmd.Parameters("@find").Value = txtCustomerNo.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Customer ID Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else

                con = New OleDbConnection(cs)
                con.Open()

                Dim cb As String = "insert into customer(B_name,b_address,b_city,b_state,b_zipcode,customerNo,Phone,email,mobileno,notes,addedby) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11)"

                cmd = New OleDbCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 100, "b_name"))

                cmd.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 250, "b_address"))

                cmd.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 50, "b_city"))

                cmd.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 50, "b_state"))

                cmd.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 10, "b_zipcode"))

                cmd.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 20, "customerno"))

                cmd.Parameters.Add(New OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 15, "phone"))

                cmd.Parameters.Add(New OleDbParameter("@d8", System.Data.OleDb.OleDbType.VarChar, 150, "email"))

                cmd.Parameters.Add(New OleDbParameter("@d9", System.Data.OleDb.OleDbType.VarChar, 15, "mobileno"))

                cmd.Parameters.Add(New OleDbParameter("@d10", System.Data.OleDb.OleDbType.VarChar, 250, "notes"))
                cmd.Parameters.Add(New OleDbParameter("@d11", System.Data.OleDb.OleDbType.VarChar, 250, "addedby"))

                cmd.Parameters("@d1").Value = B_name.Text
                cmd.Parameters("@d2").Value = B_Address.Text
                cmd.Parameters("@d3").Value = B_City.Text
                cmd.Parameters("@d4").Value = B_State.Text
                cmd.Parameters("@d5").Value = B_ZipCode.Text
                cmd.Parameters("@d6").Value = txtCustomerNo.Text
                cmd.Parameters("@d7").Value = txtPhone.Text
                cmd.Parameters("@d8").Value = txtEmail.Text
                cmd.Parameters("@d9").Value = txtMobileNo.Text
                cmd.Parameters("@d10").Value = txtNotes.Text
                cmd.Parameters("@d11").Value = frmMain.tlName.Text

                cmd.ExecuteReader()
                MessageBox.Show("Successfully saved", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Public Sub clear()
        B_name.Text = ""

        B_Address.Text = ""
        B_City.Text = ""
        B_State.Text = ""
        B_ZipCode.Text = ""
        txtCustomerNo.Text = ""
        txtEmail.Text = ""
        txtMobileNo.Text = ""
        txtPhone.Text = ""
        txtNotes.Text = ""
    End Sub

    Private Sub frmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMain.Show()
        frmMain.TodayOrders()
        frmMain.ReorderStock()
    End Sub
    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        clear()
        Update_Record.Enabled = False
        Delete.Enabled = False
        Save.Enabled = True
        B_name.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.clear()
        frmCustomersRecord3.fillName()
        frmCustomersRecord3.DataGridView1.DataSource = Nothing
        frmCustomersRecord3.DataGridView2.DataSource = Nothing
        frmCustomersRecord3.txtName.Text = ""


        frmCustomersRecord3.ShowDialog()
    End Sub

    Private Sub Update_Record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Record.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()

            Dim cb As String = "update [customer] Set [b_name]= '" & B_name.Text & "',[b_address] = '" & B_Address.Text & "',[b_city]= '" & B_City.Text & "',[b_state]='" & B_State.Text & "',[b_zipcode]='" & B_ZipCode.Text & "',[Phone]='" & txtPhone.Text & "',[email]='" & txtEmail.Text & "',[mobileno]='" & txtMobileNo.Text & "',[notes]='" & txtNotes.Text & "' where [customerno]='" & txtCustomerNo.Text & "'"

            cmd = New OleDbCommand(cb)

            cmd.Connection = con

            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()

            Update_Record.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtFaxNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then

            e.Handled = True

        End If
    End Sub
    Private Sub delete_records()
        Try

            Dim RowsAffected As Integer = 0

            con = New OleDbConnection(cs)

            con.Open()
            Dim ct As String = "select CustomerNo from BillInfo where customerNo=@find"


            cmd = New OleDbCommand(ct)

            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "CustomerNo"))


            cmd.Parameters("@find").Value = txtCustomerNo.Text


            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()
                B_name.Focus()
                Update_Record.Enabled = False
                Delete.Enabled = False


                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)

            con.Open()
            Dim ct1 As String = "select CustomerNo from OrderInfo where customerNo=@find"


            cmd = New OleDbCommand(ct1)

            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "CustomerNo"))


            cmd.Parameters("@find").Value = txtCustomerNo.Text


            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()
                B_name.Focus()
                Update_Record.Enabled = False
                Delete.Enabled = False


                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)

            con.Open()


            Dim cq As String = "delete from customer where CustomerNo=@DELETE1;"


            cmd = New OleDbCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 30, "CustomerNo"))


            cmd.Parameters("@DELETE1").Value = Trim(txtCustomerNo.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()
                B_name.Focus()
                Update_Record.Enabled = False
                Delete.Enabled = False
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
                B_name.Focus()
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
            If MessageBox.Show("Do you really want to delete the record?", "Customer Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                delete_records()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtEmail.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtEmail.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtEmail.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub B_State_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_State.SelectedIndexChanged
        B_ZipCode.Focus()
    End Sub
End Class