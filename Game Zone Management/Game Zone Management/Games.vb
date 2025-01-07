Imports System.Data.SqlClient
Public Class Games

    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Tybca47\Documents\GameZoneDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Public Sub LoadDataInGridView()
        Dim cmd As New SqlCommand("select * from registration1", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        Me.Hide()
        Dim obj = New Registration
        obj.Show()
    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        Dim id As Integer
        Dim name As String
        Dim price As Integer


        id = txt_gid.Text
        name = txt_gname.Text
        price = txt_gprive.Text


        con.Open()
        Dim cmd As New SqlCommand("Insert into gamesTB values('" & id & "','" & name & "','" & price & "')", con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data inserted successfully")
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim id As Integer
        Dim name As String
        Dim price As Integer


        id = txt_gid.Text
        name = txt_gname.Text
        price = txt_gprive.Text


        con.Open()
        Dim cmd As New SqlCommand("Update gamesTB set g_name='" & name & "',g_price='" & price & "', where g_id='" & id & "' ", con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data updated successfully")
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        Dim name As String = Console.ReadLine
        name = txt_gname.Text
        con.Open()
        Dim cmd As New SqlCommand("Delete from gamesTB where name='" & name & "' ", con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data deleted successfully")
    End Sub

    Private Sub btn_pre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pre.Click
        Me.Hide()
        Dim obj = New Login_Form
        obj.Show()
    End Sub

    Private Sub Games_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataInGridView()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim ROW As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        txt_gid.Text = ROW.Cells(0).Value.ToString
        txt_gname.Text = ROW.Cells(1).Value.ToString
        txt_gprive.Text = ROW.Cells(2).Value.ToString
    End Sub
End Class