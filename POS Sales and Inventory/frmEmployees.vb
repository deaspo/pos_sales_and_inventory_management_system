Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmEmployees
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SI_DB.accdb;Persist Security Info=False;"


    Private Sub Registration_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMain.Show()
        frmMain.ReorderStock()
        frmMain.TodayOrders()
    End Sub
    Sub fillcombo()

        Try

            Dim CN As New OleDbConnection(cs)

            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (Login) FROM Employees", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            UserName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                UserName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillcombo()
        Update_record.Enabled = False
        Delete.Enabled = False
    End Sub

    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        UserName.Text = ""
        Password.Text = ""
        txtName.Text = ""
        txtEmail.Text = ""
        cboLevel.Text = ""
        Save.Enabled = True
        Update_record.Enabled = False
        Delete.Enabled = False
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If Len(Trim(UserName.Text)) = 0 Then
            MessageBox.Show("Please enter login name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserName.Focus()
            Exit Sub
        End If
        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Password.Focus()
            Exit Sub
        End If
        If Len(Trim(txtName.Text)) = 0 Then
            MessageBox.Show("Please enter name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Exit Sub
        End If
        If Len(Trim(cboLevel.Text)) = 0 Then
            MessageBox.Show("Please select level.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboLevel.Focus()
            Exit Sub
        End If

        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct1 As String = "select login from Employees where login= '" & UserName.Text & "'"

            cmd = New OleDbCommand(ct1)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Employee already exists" & vbCrLf & "You can not make duplicate entry" & vbCrLf & "for that employee" & vbCrLf & "please update their details", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If


            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select login from Employees where login=@find"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 250, "login"))
            cmd.Parameters("@find").Value = UserName.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Employee already exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else
                con = New OleDbConnection(cs)
                con.Open()

                Dim cb As String = "insert into Emp(Email,FullName,Login,Password,Level) VALUES (@d1,@d2,@d3,@d4,@d5)"

                cmd = New OleDbCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 250, "email"))
                cmd.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 250, "fullname"))


                cmd.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 250, "login"))

                cmd.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 250, "password"))

                cmd.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 250, "level"))



                cmd.Parameters("@d1").Value = txtEmail.Text
                cmd.Parameters("@d2").Value = txtName.Text
                cmd.Parameters("@d3").Value = UserName.Text
                cmd.Parameters("@d4").Value = Password.Text

                cmd.Parameters("@d5").Value = cboLevel.Text


                cmd.ExecuteReader()

                MessageBox.Show("Successfully registered", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)



                Save.Enabled = False

                fillcombo()
                con.Close()
            End If
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Private Sub delete_records()
        Try



            Dim RowsAffected As Integer = 0

            con = New OleDbConnection(cs)

            con.Open()


            Dim cq As String = "delete from employees where login=@DELETE1;"


            cmd = New OleDbCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 30, "login"))


            cmd.Parameters("@DELETE1").Value = Trim(UserName.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MsgBox("sorry no record deleted")
                UserName.Text = ""
                Password.Text = ""
                txtEmail.Text = ""
                txtName.Text = ""
                cboLevel.Text = ""

                cmd.ExecuteReader()
                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Update_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_record.Click
        Try

            If UserName.Text = "" Then
                MessageBox.Show("Please select user name", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()

            Dim cb As String = "update employees set password='" & Password.Text & "',fullname='" & txtName.Text & "',level='" & cboLevel.Text & "'email='" & txtEmail.Text & "' where username='" & UserName.Text & "'"

            cmd = New OleDbCommand(cb)

            cmd.Connection = con


            cmd.ExecuteReader()

            MessageBox.Show("Successfully Updated", "Employee details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Update_record.Enabled = False

            fillcombo()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try

            If UserName.Text = "" Then
                MessageBox.Show("Please select Employee login name", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If UserName.Items.Count > 0 Then
                If MsgBox("Do you really want to remove this employee?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    delete_records()

                    Delete.Enabled = False
                    Update_record.Enabled = False
                    fillcombo()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'space accepted
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then

            e.Handled = False
        End If
    End Sub

    Private Sub DSE_ID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserName.SelectedIndexChanged
        Try
            Delete.Enabled = True
            Update_record.Enabled = True

            con = New OleDbConnection(cs)

            con.Open()


            Dim ct As String = "select * from employees where login=@find"


            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "login"))
            cmd.Parameters("@find").Value = Trim(UserName.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then


                Password.Text = Trim(rdr.GetString(3))
                txtName.Text = Trim(rdr.GetString(1))
                txtEmail.Text = Trim(rdr.GetString(0))
                cboLevel.Text = Trim(rdr.GetString(4))


            End If


            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class