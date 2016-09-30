Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Height, Base, Hypotenuse, Perimeter, Area, Sqrd, distance As Double

        If triangleType.SelectedIndex = -1 Then
            ' No triangle type is selected
            MessageBox.Show("Select a triangle type.")
        ElseIf triangleSide.SelectedIndex = -1 Then
            ' No triangle side is selected
            MessageBox.Show("Select a triangle side.")
        End If

        ' Solving for hypotenuse
        If triangleType.SelectedIndex = 0 And triangleSide.SelectedIndex = 0 Then
            Height = Convert.ToInt32(txtHeight.Text)
            Base = Convert.ToInt32(txtBase.Text)

            Hypotenuse = (Height * Height) + (Base * Base)
            Sqrd = Math.Sqrt(Hypotenuse)

            txtHypotenuse.Text = CStr(Sqrd)

            Perimeter = CDbl(txtBase.Text) + CDbl(txtHeight.Text) + CDbl(txtHypotenuse.Text)
            lblPerimeter.Text = CDbl(Perimeter)

            Area = (Base * Height) / 2
            lblArea.Text = CDbl(Area)
        End If

        ' Solving for base
        If triangleType.SelectedIndex = 0 And triangleSide.SelectedIndex = 1 Then
            Height = Convert.ToInt32(txtHeight.Text)
            Hypotenuse = Convert.ToInt32(txtHypotenuse.Text)

            Base = (Hypotenuse * Hypotenuse) - (Height * Height)
            Sqrd = Math.Sqrt(Base)

            txtBase.Text = CStr(Sqrd)

            Perimeter = CDbl(txtBase.Text) + CDbl(txtHeight.Text) + CDbl(txtHypotenuse.Text)
            lblPerimeter.Text = CDbl(Perimeter)

            Area = (Base * Height) / 2
            lblArea.Text = CDbl(Area)
        End If

        ' Solving for height
        If triangleType.SelectedIndex = 0 And triangleSide.SelectedIndex = 2 Then
            Base = Convert.ToInt32(txtBase.Text)
            Hypotenuse = Convert.ToInt32(txtHypotenuse.Text)

            Height = (Hypotenuse * Hypotenuse) - (Base * Base)
            Sqrd = Math.Sqrt(Height)

            txtHeight.Text = CStr(Sqrd)

            Perimeter = CDbl(txtBase.Text) + CDbl(txtHeight.Text) + CDbl(txtHypotenuse.Text)
            lblPerimeter.Text = CDbl(Perimeter)

            Area = (Base * Height) / 2
            lblArea.Text = CDbl(Area)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHypotenuse.Clear()
        txtBase.Clear()
        txtHeight.Clear()
        lblPerimeter.Text = ("")
        lblArea.Text = ("")
        triangleType.SelectedIndex = -1
        triangleSide.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
