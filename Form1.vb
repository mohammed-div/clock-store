Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Left < Me.Width Then
            Label1.Left += 9
        Else
            Label1.Left = -Label1.Width
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Panel1.BringToFront()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Panel7.BringToFront()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Panel3.BringToFront()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Panel4.BringToFront()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Panel5.BringToFront()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Panel6.BringToFront()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        Panel8.BringToFront()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)









    End Sub

    Private Sub PictureBox85_Click(sender As Object, e As EventArgs) Handles PictureBox85.Click
        Panel3.BringToFront()
    End Sub

    Private Sub PictureBox84_Click(sender As Object, e As EventArgs) Handles PictureBox84.Click
        Panel4.BringToFront()
    End Sub

    Private Sub PictureBox83_Click(sender As Object, e As EventArgs) Handles PictureBox83.Click
        Panel5.BringToFront()
    End Sub

    Private Sub PictureBox82_Click(sender As Object, e As EventArgs) Handles PictureBox82.Click
        Panel6.BringToFront()
    End Sub

    Private Sub PictureBox86_Click(sender As Object, e As EventArgs) Handles PictureBox86.Click
        Panel8.BringToFront()
    End Sub

    Private Sub GroupBox67_Enter(sender As Object, e As EventArgs) Handles GroupBox67.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel10.BringToFront()
        GroupBox73.Text = "رولكس"
        Label225.Text = "رولكس"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "36,000$"
        PictureBox87.Image = My.Resources.sr4
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوميغا"
        Label225.Text = "اوميغا"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "3,000$"
        PictureBox87.Image = My.Resources.aoo4
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "5,000$"
        PictureBox87.Image = My.Resources.k6
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوديمار بيغه"
        Label225.Text = "اوديمار بيغه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.o1
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغ"
        Label225.Text = "بريتلينغ"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "19,000$"
        PictureBox87.Image = My.Resources.b7
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغ"
        Label225.Text = "بريتيلنغ"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "8,000$"
        PictureBox87.Image = My.Resources.b4
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "19,000$"
        PictureBox87.Image = My.Resources.k7
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "8,000$"
        PictureBox87.Image = My.Resources.k4
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Panel10.BringToFront()
        GroupBox73.Text = "رولكس"
        Label225.Text = "رولكس"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.sr1
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Panel10.BringToFront()
        GroupBox73.Text = "رولكس"
        Label225.Text = "رولكس"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "3,000$"
        PictureBox87.Image = My.Resources.sr2
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Panel10.BringToFront()
        GroupBox73.Text = "رولكس"
        Label225.Text = "رولكس"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "5,000$"
        PictureBox87.Image = My.Resources.sr3
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Panel10.BringToFront()
        GroupBox73.Text = "رولكس"
        Label225.Text = "رولكس"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "36,000$"
        PictureBox87.Image = My.Resources.sr4
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Panel10.BringToFront()
        GroupBox73.Text = "رولكس"
        Label225.Text = "رولكس"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "20,500$"
        PictureBox87.Image = My.Resources.sr5
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Panel10.BringToFront()
        GroupBox73.Text = "رولكس"
        Label225.Text = "رولكس"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "19,500$"
        PictureBox87.Image = My.Resources.sr6
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Panel10.BringToFront()
        GroupBox73.Text = "رولكس"
        Label225.Text = "رولكس"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "8,500$"
        PictureBox87.Image = My.Resources.sr7
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Panel10.BringToFront()
        GroupBox73.Text = "رولكس"
        Label225.Text = "رولكس"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "13,500$"
        PictureBox87.Image = My.Resources.sr8
    End Sub

    Private Sub PictureBox70_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox69_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox68_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox67_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox66_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox65_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox64_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox63_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوميغا"
        Label225.Text = "اوميغا"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.aoo1
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوميغا"
        Label225.Text = "اوميغا"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "3,500$"
        PictureBox87.Image = My.Resources.aoo5
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوميغا"
        Label225.Text = "اوميغا"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "5,000$"
        PictureBox87.Image = My.Resources.aoo6
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوميغا"
        Label225.Text = "اوميغا"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "36,500$"
        PictureBox87.Image = My.Resources.aoo2
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوميغا"
        Label225.Text = "اوميغا"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "20,500$"
        PictureBox87.Image = My.Resources.aoo3
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوميغا"
        Label225.Text = "اوميغا"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "19,500$"
        PictureBox87.Image = My.Resources.aoo7
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوميغا"
        Label225.Text = "اوميغا"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "18,500$"
        PictureBox87.Image = My.Resources.aoo4
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوميغا"
        Label225.Text = "اوميغا"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.aoo8
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.k1
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "3,500$"
        PictureBox87.Image = My.Resources.k5
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "5,000$"
        PictureBox87.Image = My.Resources.k6
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "36,500$"
        PictureBox87.Image = My.Resources.k2
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "20,500$"
        PictureBox87.Image = My.Resources.k3
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "19,300$"
        PictureBox87.Image = My.Resources.k7
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "8,500$"
        PictureBox87.Image = My.Resources.k4
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        Panel10.BringToFront()
        GroupBox73.Text = "كارتييه"
        Label225.Text = "كارتييه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.k8
    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوديمار بيغيه"
        Label225.Text = "اوديمار بيغيه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.o1
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوديمار بيغيه"
        Label225.Text = "اوديمار بيغيه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "3,500$"
        PictureBox87.Image = My.Resources.o5
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوديمار بيغيه"
        Label225.Text = "اوديمار بيغيه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "8,000$"
        PictureBox87.Image = My.Resources.o6
    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs) Handles PictureBox50.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوديمار بيغيه"
        Label225.Text = "اوديمار بيغيه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "36,500$"
        PictureBox87.Image = My.Resources.o2
    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوديمار بيغيه"
        Label225.Text = "اوديمار بيغيه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "20,500$"
        PictureBox87.Image = My.Resources.o3
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوديمار بيغيه"
        Label225.Text = "اوديمار بيغيه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "19,300$"
        PictureBox87.Image = My.Resources.o7
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوديمار بيغيه"
        Label225.Text = "اوديمار بيغيه"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "8,500$"
        PictureBox87.Image = My.Resources.o4
    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        Panel10.BringToFront()
        GroupBox73.Text = "اوديمار بيغيه"
        Label225.Text = "اوديمار بيغيه"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.o8
    End Sub

    Private Sub PictureBox62_Click(sender As Object, e As EventArgs) Handles PictureBox62.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغه"
        Label225.Text = "بريتلينغ"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.b1
    End Sub

    Private Sub PictureBox61_Click(sender As Object, e As EventArgs) Handles PictureBox61.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغه"
        Label225.Text = "بريتلينغ"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "3,500$"
        PictureBox87.Image = My.Resources.b5
    End Sub

    Private Sub PictureBox60_Click(sender As Object, e As EventArgs) Handles PictureBox60.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغه"
        Label225.Text = "بريتلينغ"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "5,000$"
        PictureBox87.Image = My.Resources.b6
    End Sub

    Private Sub PictureBox59_Click(sender As Object, e As EventArgs) Handles PictureBox59.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغه"
        Label225.Text = "بريتلينغ"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "36,500$"
        PictureBox87.Image = My.Resources.b2
    End Sub

    Private Sub PictureBox58_Click(sender As Object, e As EventArgs) Handles PictureBox58.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغه"
        Label225.Text = "بريتلينغ"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "20,500$"
        PictureBox87.Image = My.Resources.b3
    End Sub

    Private Sub PictureBox57_Click(sender As Object, e As EventArgs) Handles PictureBox57.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغه"
        Label225.Text = "بريتلينغ"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "19,300$"
        PictureBox87.Image = My.Resources.b7
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغه"
        Label225.Text = "بريتلينغ"
        Label224.Text = "ساعه يد رجالية"
        Label223.Text = "8,500$"
        PictureBox87.Image = My.Resources.b4
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        Panel10.BringToFront()
        GroupBox73.Text = "بريتلينغه"
        Label225.Text = "بريتلينغ"
        Label224.Text = "ساعه يد نسائية"
        Label223.Text = "13,000$"
        PictureBox87.Image = My.Resources.b8
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        BunifuThinButton23.Visible = True
    End Sub

    Private Sub nbr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nbr.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub cvv_OnValueChanged(sender As Object, e As EventArgs) Handles cvv.OnValueChanged

    End Sub

    Private Sub cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cvv.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        If nbr.Text = "" And name1.Text = "" And cvv.Text = "" Then
            MessageBox.Show("اكمل متطلبات الادخال")
        Else
            MessageBox.Show("تم الشراء بنجاح")
            Panel1.BringToFront()
            Label1.Text = "شكرا لختيارك موقعنا"
        End If
    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Panel9.BringToFront()
        Label156.Text = Label223.Text
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        If p.Text = "" Then
            MessageBox.Show("البريد الالكتروني مطلوب ؟")
        Else
            MessageBox.Show("تم الارسال بنجاح")
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txt_name.Text = "" And txt_password.Text = "" Then
            MessageBox.Show("ادخل متطلبات الادخال")
        Else
            MessageBox.Show("تم تسجيل الدخول")
        End If
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Panel12.BringToFront()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel11.BringToFront()
    End Sub
End Class
