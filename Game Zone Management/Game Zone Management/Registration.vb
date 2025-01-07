Imports System.Data.SqlClient
Public Class Registration

    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Tybca47\Documents\GameZoneDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Public Sub LoadDataInGridView()
        Dim cmd As New SqlCommand("select * from registration1", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub


    Private Sub btn_submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit.Click
        Dim name As String
        Dim mno As Integer
        Dim email As String
        Dim gender As String
        Dim bdate As String


        name = txt_name.Text
        mno = txt_mno.Text
        email = txt_email.Text
        gender = cmbx_gender.Text
        bdate = DateTimePicker1.Text

        con.Open()
        Dim cmd As New SqlCommand("Insert into registration1 values('" & name & "','" & mno & "','" & email & "','" & gender & "','" & bdate & "')", con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data inserted successfully")

    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        Dim Name As String = Console.ReadLine
        Name = txt_name.Text
        con.Open()
        Dim cmd As New SqlCommand("Delete from registration1 where name='" & Name & "' ", con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data deleted successfully")

        ' LoadDataInGridView()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim name As String
        Dim mno As Integer
        Dim email As String
        Dim gender As String
        Dim bdate As String


        name = txt_name.Text
        mno = txt_mno.Text
        email = txt_email.Text
        gender = cmbx_gender.Text
        bdate = DateTimePicker1.Text

        con.Open()
        Dim cmd As New SqlCommand("Update registration1 set mno='" & mno & "',email='" & email & "',gender='" & gender & "',bdate='" & bdate & "' where name='" & name & "' ", con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data updated successfully")


    End Sub
    Public Sub clear()
        txt_name.Text = ""
        txt_mno.Text = ""
        txt_email.Text = ""
        cmbx_gender.Text = ""

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        clear()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim ROW As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        txt_name.Text = ROW.Cells(0).Value.ToString
        txt_mno.Text = ROW.Cells(1).Value.ToString
        txt_email.Text = ROW.Cells(2).Value.ToString
        cmbx_gender.Text = ROW.Cells(3).Value.ToString
        DateTimePicker1.Text = ROW.Cells(4).Value.ToString
    End Sub


    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataInGridView()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Dim obj = New Package
        obj.Show()
    End Sub

    Private Sub txt_mno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mno.Leave
        Dim mno As String = txt_mno.Text
        If mno.Length <> 10 Then
            MsgBox("Mobile Number must be 10 digits")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        Me.Hide()
        Dim obj = New Games
        obj.Show()
    End Sub
End Class
