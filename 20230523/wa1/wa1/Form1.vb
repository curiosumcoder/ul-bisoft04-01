Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NorthwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
        Me.CustomersTableAdapter.Fill(Me.NorthwindDataSet.Customers)

    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click

        ' Me.CustomersTableAdapter.Update(Me.NorthwindDataSet.Customers)

        Dim hoyEsMartes As Boolean
        hoyEsMartes = True
        hoyEsMartes = False

        Dim noHayCambios As Boolean = Me.NorthwindDataSet.Customers.GetChanges() Is Nothing
        Dim hayCambios As Boolean = Not noHayCambios

        If Not Me.NorthwindDataSet.Customers.GetChanges() Is Nothing Then
            Me.CustomersTableAdapter.Update(Me.NorthwindDataSet.Customers)
            MessageBox.Show("Changes have been applied!",
                            "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            MessageBox.Show("No changes to be applied!",
                            "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
    End Sub
End Class
