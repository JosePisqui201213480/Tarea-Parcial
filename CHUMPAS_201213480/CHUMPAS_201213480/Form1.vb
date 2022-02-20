Public Class Form1

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            MsgBox(" No has elegido tamaño ")
        End If
        If RadioButton4.Checked = False And RadioButton5.Checked = False And RadioButton6.Checked = False Then

            MsgBox(" No has elegido material ")
        End If

        If TextBox1.Text = "" Then
            MsgBox(" Ingrese una cantidad  ")
        End If



        Dim tamaño As String
        Dim material As String
        If RadioButton1.Checked Then
            tamaño = "small"
        ElseIf RadioButton2.Checked Then
            tamaño = "medium "
        ElseIf RadioButton3.Checked Then
            tamaño = "large "


        End If

        If RadioButton4.Checked Then
            tamaño = "algodon"
        ElseIf RadioButton5.Checked Then
            tamaño = "seda"
        Else
            tamaño = "lona"
        End If
        calcular(material, tamaño, Val(TextBox1.Text))
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
