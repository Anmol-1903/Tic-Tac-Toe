Public Class Form1
    Dim turn As Integer
    Sub New()
        InitializeComponent()
        turn = 1
        Me.BackColor = Color.Red
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If turn Mod 2 = 1 Then
            Button1.Text = "X"
            turn += 1
            Me.BackColor = Color.Blue
            Button1.Enabled = False
        Else
            Button1.Text = "O"
            turn += 1
            Me.BackColor = Color.Red
            Button1.Enabled = False
        End If
        If Button1.Text = Button2.Text And Button1.Text = Button3.Text Then
            MsgBox("'" & Button1.Text & "' Wins")
        ElseIf Button1.Text = Button4.Text And Button1.Text = Button7.Text Then
            MsgBox("'" & Button1.Text & "' Wins")
        ElseIf Button1.Text = Button5.Text And Button1.Text = Button9.Text Then
            MsgBox("'" & Button1.Text & "' Wins")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If turn Mod 2 = 1 Then
            Button2.Text = "X"
            turn += 1
            Me.BackColor = Color.Blue
            Button2.Enabled = False
        Else
            Button2.Text = "O"
            turn += 1
            Me.BackColor = Color.Red
            Button2.Enabled = False
        End If
        If Button1.Text = Button2.Text And Button1.Text = Button3.Text Then
            MsgBox("'" & Button2.Text & "' Wins")
        ElseIf Button2.Text = Button5.Text And Button2.Text = Button8.Text Then
            MsgBox("'" & Button2.Text & "' Wins")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If turn Mod 2 = 1 Then
            Button3.Text = "X"
            turn += 1
            Me.BackColor = Color.Blue
            Button3.Enabled = False
        Else
            Button3.Text = "O"
            turn += 1
            Me.BackColor = Color.Red
            Button3.Enabled = False
        End If
        If Button1.Text = Button2.Text And Button1.Text = Button3.Text Then
            MsgBox("'" & Button3.Text & "' Wins")
        ElseIf Button3.Text = Button6.Text And Button3.Text = Button9.Text Then
            MsgBox("'" & Button3.Text & "' Wins")
        ElseIf Button3.Text = Button5.Text And Button3.Text = Button7.Text Then
            MsgBox("'" & Button3.Text & "' Wins")
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If turn Mod 2 = 1 Then
            Button4.Text = "X"
            turn += 1
            Me.BackColor = Color.Blue
            Button4.Enabled = False
        Else
            Button4.Text = "O"
            turn += 1
            Me.BackColor = Color.Red
            Button4.Enabled = False
        End If
        If Button4.Text = Button5.Text And Button4.Text = Button6.Text Then
            MsgBox("'" & Button4.Text & "' Wins")
        ElseIf Button1.Text = Button4.Text And Button1.Text = Button7.Text Then
            MsgBox("'" & Button4.Text & "' Wins")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If turn Mod 2 = 1 Then
            Button5.Text = "X"
            turn += 1
            Me.BackColor = Color.Blue
            Button5.Enabled = False
        Else
            Button5.Text = "O"
            turn += 1
            Me.BackColor = Color.Red
            Button5.Enabled = False
        End If
        If Button4.Text = Button5.Text And Button4.Text = Button6.Text Then
            MsgBox("'" & Button5.Text & "' Wins")
        ElseIf Button2.Text = Button5.Text And Button2.Text = Button8.Text Then
            MsgBox("'" & Button5.Text & "' Wins")
        ElseIf Button1.Text = Button5.Text And Button1.Text = Button9.Text Then
            MsgBox("'" & Button5.Text & "' Wins")
        ElseIf Button3.Text = Button5.Text And Button3.Text = Button7.Text Then
            MsgBox("'" & Button5.Text & "' Wins")
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If turn Mod 2 = 1 Then
            Button6.Text = "X"
            turn += 1
            Me.BackColor = Color.Blue
            Button6.Enabled = False
        Else
            Button6.Text = "O"
            turn += 1
            Me.BackColor = Color.Red
            Button6.Enabled = False
        End If
        If Button4.Text = Button5.Text And Button4.Text = Button6.Text Then
            MsgBox("'" & Button6.Text & "' Wins")
        ElseIf Button3.Text = Button6.Text And Button3.Text = Button9.Text Then
            MsgBox("'" & Button6.Text & "' Wins")
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If turn Mod 2 = 1 Then
            Button7.Text = "X"
            turn += 1
            Me.BackColor = Color.Blue
            Button7.Enabled = False
        Else
            Button7.Text = "O"
            turn += 1
            Me.BackColor = Color.Red
            Button7.Enabled = False
        End If
        If Button1.Text = Button4.Text And Button1.Text = Button7.Text Then
            MsgBox("'" & Button7.Text & "' Wins")
        ElseIf Button3.Text = Button5.Text And Button3.Text = Button7.Text Then
            MsgBox("'" & Button7.Text & "' Wins")
        ElseIf Button7.Text = Button8.Text And Button7.Text = Button9.Text Then
            MsgBox("'" & Button7.Text & "' Wins")
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If turn Mod 2 = 1 Then
            Button8.Text = "X"
            turn += 1
            Me.BackColor = Color.Blue
            Button8.Enabled = False
        Else
            Button8.Text = "O"
            turn += 1
            Me.BackColor = Color.Red
            Button8.Enabled = False
        End If
        If Button7.Text = Button8.Text And Button7.Text = Button9.Text Then
            MsgBox("'" & Button8.Text & "' Wins")
        ElseIf Button2.Text = Button5.Text And Button2.Text = Button8.Text Then
            MsgBox("'" & Button8.Text & "' Wins")
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If turn Mod 2 = 1 Then
            Button9.Text = "X"
            turn += 1
            Me.BackColor = Color.Blue
            Button9.Enabled = False
        Else
            Button9.Text = "O"
            turn += 1
            Me.BackColor = Color.Red
            Button9.Enabled = False
        End If
        If Button7.Text = Button8.Text And Button7.Text = Button9.Text Then
            MsgBox("'" & Button9.Text & "' Wins")
        ElseIf Button1.Text = Button5.Text And Button1.Text = Button9.Text Then
            MsgBox("'" & Button9.Text & "' Wins")
        ElseIf Button3.Text = Button6.Text And Button3.Text = Button9.Text Then
            MsgBox("'" & Button9.Text & "' Wins")
        End If
    End Sub
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        Button1.Text = " "
        Button2.Text = " "
        Button3.Text = " "
        Button4.Text = " "
        Button5.Text = " "
        Button6.Text = " "
        Button7.Text = " "
        Button8.Text = " "
        Button9.Text = " "
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        turn = 1
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If turn = 9 Then
            MsgBox("Draw")
        End If
    End Sub
End Class