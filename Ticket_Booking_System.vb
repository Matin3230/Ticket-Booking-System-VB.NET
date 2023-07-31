
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        a.Show()
End Class

Imports System.Text.RegularExpressions
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As Integer = 0
        Dim a As Regex = New Regex("\S+@\S+\.+\S")
        If a.IsMatch(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "")
            f = f + 1
        Else
            ErrorProvider1.SetError(TextBox1, "Invalid Email Id")
        End If

        Dim b As Regex = New Regex("\d{8}")
        If b.IsMatch(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "")
            f = f + 1
        Else
            ErrorProvider1.SetError(TextBox2, "Invalid Password")
        End If
        If f = 2 Then
            MsgBox("Login Is Sucecssful...", )
            Me.Hide()
            Form10.Refresh()
            Form10.Show()
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

Public Class Form3
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Label2.Text = "Chhapaak"
        Label2.Hide()
        Form6.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Label2.Text = " The Tashkent Files"
        Label2.Hide()
        Form7.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Label2.Text = "Tanhaji"
        Label2.Hide()
        Form4.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Label2.Text = "Panga"
        Label2.Hide()
        Form5.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Label2.Text = "Street Dancer 3D"
        Label2.Hide()
        Form8.Show()
    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Label2.Text = "Kabir Singh"
        Label2.Hide()
        Form9.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a.Show()
        Me.Hide()
    End Sub

public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Hide()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class

Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Hide()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class


Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Hide()
        Me.Hide()
        Form2.Show()
    End Sub
 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
 End Class

Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Hide()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub
  End Class	

Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Hide()
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
Public Class Form9
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Hide()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class

Public Class Form10
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Text > DateAndTime.Now Then
            TextBox1.Text = DateTimePicker1.Text
        Else
            MsgBox("Invalid Date")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form11.Refresh()
        Form11.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox2.Text = ComboBox1.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class

Public Class Form11
    Dim a, b As Integer
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.SelectedItem = "Platinum Ticket" Then
            a = 180
        ElseIf ComboBox1.SelectedItem = "Gold Ticket" Then
            a = 150
        Else
            a = 120
        End If
        TextBox2.Text = (a * Val(TextBox1.Text))
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form12.Refresh()
        Form12.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form10.Show()
        Me.Hide()
    End Sub
End Class

Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = Form10.TextBox1.Text
        Me.TextBox2.Text = Form10.ComboBox1.Text
        Me.TextBox3.Text = Form11.TextBox1.Text
        Me.TextBox4.Text = Form11.TextBox2.Text
        Me.Label5.Text = Form3.Label2.Text
        Me.TextBox5.Text = a.Label2.Text
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MsgBox("Ticket Is Booked Successfully......")
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form11.Show()
        Me.Hide()
        Me.Refresh()
    End Sub
End Class

Public Class a
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Asha Multiplex"
        Label2.Hide()
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "Shivam Plaza"
        Label2.Hide()
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "The Annexe"
        Label2.Hide()
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = "My Cinema"
        Label2.Hide()
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Label2.Hide()
        MessageBox.Show("You can Select the ")
    End Sub
