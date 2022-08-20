Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d, f, total, count As Integer
        a = 100
        b = 120
        c = 130
        d = 140
        f = 150
        If CheckBox1.Checked Then
            total += a
            count += 1

        End If
        ' If CheckBox2.Checked Then
        total += c
            count += 1
        End If
        'If CheckBox3.Checked Then
        total += d
            count += 1
        End If
        'If CheckBox4.Checked Then
        total += f
            count += 1
        End If
        'If CheckBox5.Checked Then
        total += a
            count += 1
        End If
        'If CheckBox6.Checked Then
        total += b
            count += 1
        End If
        'If CheckBox7.Checked Then
        total += c
            count += 1
        End If
        'If CheckBox8.Checked Then
        total += d
            count += 1
        End If
        'If CheckBox9.Checked Then
        total += f
            count += 1
        End If
        'If CheckBox10.Checked Then
        total += a
            count += 1
        End If

        TextBox1.Text = total
        Label2.Text = count

        'If RadioButton1.Checked = True Then
        TextBox1.Text = Val(TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
        'TextBox1.Text = Val(TextBox1.Text) + 50
        End If

        Dim g As Integer
        If Val(ListBox1.SelectedItems.Count) Then
            ListBox1.Text = g
        End If
        'TextBox2.Text = ListBox1.SelectedItem * Val(TextBox1.Text)

        DataGridView1.Rows(0).Cells(3).Value = Val(TextBox2.Text)
        ' DataGridView1.Rows(0).Cells(2).Value = ListBox1.SelectedItems
        If RadioButton1.Checked = True Then
            ' DataGridView1.Rows(0).Cells(1).Value = "1/2ปอนด์"
        ElseIf RadioButton2.Checked = True Then
            ' DataGridView1.Rows(0).Cells(1).Value = "1ปอนด์"
        End If
        'DataGridView1.Rows(0).Cells(0).Value = Val(Label2.Text)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
