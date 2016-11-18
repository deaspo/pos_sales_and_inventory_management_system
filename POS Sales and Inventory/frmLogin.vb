Imports System.Data.OleDb
Public Class frmLogin
    Public Sub logName(userName As String)
        'preloads the user name
        txtUsername.Text = userName
    End Sub

    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Product_inventoryDataSet)

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Product_inventoryDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.Product_inventoryDataSet.Employees)
        txtPassword.Focus()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmLoginDetails.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Len(Trim(txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If
        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If

        'Establish sql connections
        Try
            Dim con As OleDbConnection
            Dim dbCommand As OleDbCommand
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\product_inventory.accdb")
            dbCommand = New OleDbCommand("SELECT Login, Password FROM Employees WHERE Login = @username AND Password = @userpassword", con)

            Dim uName As New OleDbParameter("@username", SqlDbType.VarChar)

            Dim uPassword As New OleDbParameter("@UserPassword", SqlDbType.VarChar)

            uName.Value = txtUsername.Text

            uPassword.Value = txtPassword.Text

            dbCommand.Parameters.Add(uName)

            dbCommand.Parameters.Add(uPassword)

            dbCommand.Connection.Open()

            Dim reader As OleDbDataReader = dbCommand.ExecuteReader(CommandBehavior.CloseConnection)

            Dim Login As Object = 0

            If reader.HasRows Then

                reader.Read()

                Login = reader(Login)

            End If

            If Login = Nothing Then

                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                txtPassword.Clear()
                txtPassword.Focus()

            Else

                pbLogging.Visible = True
                pbLogging.Maximum = 5000
                pbLogging.Minimum = 0
                pbLogging.Value = 4
                pbLogging.Step = 1

                For i = 0 To 5000
                    pbLogging.PerformStep()
                Next

                frmMain.tlName.Text = txtUsername.Text
                Me.Hide()

                frmMain.Show()

            End If
            dbCommand.Dispose()
            con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
