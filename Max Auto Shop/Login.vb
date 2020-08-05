Imports System.Data.SqlClient
Public Class frmLogin

    Private con As SqlConnection
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\franc\Documents\Visual Studio 2017\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Dim user As String = ""

        Try
            cmd.CommandText = "SELECT TOP 1 username from dbo.usuarios where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
            cmd.Connection = con
            'Open the connection.
            con.Open()
            reader = cmd.ExecuteReader()

            While reader.Read
                user = reader.Item(0)
            End While
            reader.Close()

            If user IsNot "" Then
                lblMessage.Visible = False
                Me.Hide()
                frmMain.Show()
            Else
                lblMessage.Visible = True
                lblMessage.Text = "Usuario o Contraseña Invalidos"

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class
