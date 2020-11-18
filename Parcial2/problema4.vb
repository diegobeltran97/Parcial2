Public Class problema4



    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        Dim sumaPares As Integer = 0
        Dim sumaImpares As Integer = 0
        Dim number As Integer
        number = Convert.ToInt32(inputNumero.Text)

        If number Mod 2 = 0 Then
            paresList.Items.Add(inputNumero.Text)
        Else
            listImpares.Items.Add(inputNumero.Text)
        End If

        totalPares.Text = paresList.Items.Count()
        totalImpares.Text = listImpares.Items.Count()


        Dim n = paresList.Items.Count - 1
        For index As Integer = 0 To n
            sumaPares = sumaPares + CStr(paresList.Items(index))
        Next




        For index As Integer = 0 To listImpares.Items.Count - 1
            sumaImpares = sumaImpares + CStr(listImpares.Items(index))
        Next

        lblSumaPares.Text = sumaPares
        lblSumaImpares.Text = sumaImpares



        lblPromedioPares.Text = promedioN(sumaPares, paresList.Items.Count)
        lblPromedioImpares.Text = promedioN(sumaImpares, listImpares.Items.Count)



    End Sub
    Function promedioN(totalSuma, totalNumero)
        Dim promedio
        promedio = totalSuma / totalNumero

        Return promedio
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class


