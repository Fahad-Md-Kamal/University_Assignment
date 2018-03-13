Public Class Selection_Page
    'Golbal Veriable
    Dim PDuration() As Integer = {0, 30, 40, 50}
    Dim PLocation() As Integer = {0, 30, 20, 30}
    Dim PAccomodation() As Integer = {0, 40, 60, 70}
    Dim PLuggage() As Integer = {0, 0, 30}
    Dim PFood() As Integer = {0, 10, 20, 25, 30, 20}
    Dim G3D As Integer = 16
    Dim G5D As Integer = 16
    Dim G10D As Integer = 16





    Private Sub Selection_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form Name Change
        Me.Text = ("Wonderful Walks")

        'Walking Duration
        cmbWalkingDuration.Items.Add("Select")
        cmbWalkingDuration.Items.Add("3 Days")
        cmbWalkingDuration.Items.Add("5 days")
        cmbWalkingDuration.Items.Add("10 days")
        'Pre-selected Index
        cmbWalkingDuration.SelectedIndex = 1


        'Walking Location 
        cmbWalkingLocation.Items.Add("Select")
        cmbWalkingLocation.Items.Add("Trossachs")
        cmbWalkingLocation.Items.Add("Great Glen")
        cmbWalkingLocation.Items.Add("West Highland Way")
        'Pre-selected Index
        cmbWalkingLocation.SelectedIndex = 1


        'Accommodation
        cmbAccommodation.Items.Add("Select")
        cmbAccommodation.Items.Add("Camping")
        cmbAccommodation.Items.Add("Youth Hostel")
        cmbAccommodation.Items.Add("Bed & Breakfast")
        'Pre-selected Index
        cmbAccommodation.SelectedIndex = 1


        'Luggage
        cmbLuggage.Items.Add("Select")
        cmbLuggage.Items.Add("Carry Own Luggage")
        cmbLuggage.Items.Add("Transported Luggage")
        'Pre-selected Index
        cmbLuggage.SelectedIndex = 1


        'Food
        cmbFood.Items.Add("Select")
        cmbFood.Items.Add("Self-Catering")
        cmbFood.Items.Add("Catered Vegetarian")
        cmbFood.Items.Add("Catered Regular")
        cmbFood.Items.Add("Catered Gluten Free")
        cmbFood.Items.Add("Catered Lactose Free")
        'Pre-selected Index
        cmbFood.SelectedIndex = 1



    End Sub








    Private Sub btnDONE_Click_1(sender As Object, e As EventArgs) Handles btnDONE.Click, CheckTotalPriceToolStripMenuItem.Click




        Dim MOutput, OptOutput, Output As String
        Dim MPrice, MTotal, OptPrice, OptTotal, GTotal As Integer


        'Walking Duration
        If cmbWalkingDuration.SelectedIndex < 1 Then
            MessageBox.Show("You have to select a Walking duration.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else MOutput += "Selected duration :  " + cmbWalkingDuration.SelectedItem & vbCrLf
            MPrice += PDuration(cmbWalkingDuration.SelectedIndex)
        End If


        'WalkingLocation
        If cmbWalkingLocation.SelectedIndex < 1 Then
            MessageBox.Show("You have to select a Walking Location.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else MOutput += "Selected Location :  " + cmbWalkingLocation.SelectedItem & vbCrLf
            MPrice += PLocation(cmbWalkingLocation.SelectedIndex)
        End If


        'Accommodation
        If cmbAccommodation.SelectedIndex < 1 Then
            MessageBox.Show("You have to select an Accommodation Type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else MOutput += "Selected Accommodation Type :  " + cmbAccommodation.SelectedItem & vbCrLf
            MPrice += PAccomodation(cmbAccommodation.SelectedIndex)
        End If


        'Luggage Carry
        If cmbLuggage.SelectedIndex < 1 Then
            MessageBox.Show("You have to select Luggage Carry Option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else MOutput += "Selected Luggage Carry Option :  " + cmbLuggage.SelectedItem & vbCrLf
            MPrice += PLuggage(cmbLuggage.SelectedIndex)
        End If


        'Food Option
        If cmbFood.SelectedIndex < 1 Then
            MessageBox.Show("You have to select Food Option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else MOutput += "Selected Food Option :  " + cmbFood.SelectedItem & vbCrLf
            MPrice += PFood(cmbFood.SelectedIndex)
        End If




        'Optional Items
        If rdbSolarCharger.Checked Then
            OptOutput += rdbSolarCharger.Text & vbCrLf
            OptPrice = 5
        ElseIf rdbWalkingPoles.Checked
            OptOutput += rdbWalkingPoles.Text & vbCrLf
            OptPrice += 10
        ElseIf rdbMosquitonet.Checked
            OptOutput += rdbMosquitonet.Text & vbCrLf
            OptPrice += 5
        ElseIf rdb2_ManTent.Checked
            OptOutput += rdb2_ManTent.Text & vbCrLf
            OptPrice += 20
        ElseIf rdb4_ManTent.Checked
            OptOutput += rdb4_ManTent.Text & vbCrLf
            OptPrice += 30
        Else
            OptOutput += "Not selected." & vbCrLf
        End If




        'Mathemetical Terms
        OptTotal += OptPrice
        MTotal += MPrice
        GTotal = MTotal + OptTotal







        'Group Member Count''''''''''''''''''''''''''''''''''''''''''''''''''
        If cmbWalkingDuration.SelectedIndex = 1 Then
            G3D = G3D - 1
            If G3D < 1 Then
                MessageBox.Show("Only 16 People are allowed in 3 days walking group ." & vbCrLf & vbCrLf & "Please select another group.", "NOT MORE THAN 16....!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If

        If cmbWalkingDuration.SelectedIndex = 2 Then
            G5D = G5D - 1
            If G5D < 1 Then
                MessageBox.Show("Only 16 People are allowed in 5 days walking group ." & vbCrLf & vbCrLf & "Please select another group.", "NOT MORE THAN 16....!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If

        If cmbWalkingDuration.SelectedIndex = 3 Then
            G10D = G10D - 1
            If G10D < 1 Then
                MessageBox.Show("Only 16 People are allowed in 10 days walking group ." & vbCrLf & vbCrLf & "Please select another group.", "NOT MORE THAN 16....!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



        'Mathemetical Terms
        OptTotal += OptPrice
        MTotal += MPrice
        GTotal = MTotal + OptTotal
        'Output
        Output = MOutput & vbCrLf & vbCrLf & "Additional Items : " & vbCrLf & OptOutput & vbCrLf & "TOTAL COST :  " & GTotal & " £"


        'Confirmation MessegeBox
        Dim pment As DialogResult = MessageBox.Show(Output & vbCrLf & vbCrLf & "Do you want to pay for the Items that you've selected ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If pment = DialogResult.Yes Then
            MessageBox.Show("Please complete the next form to confirm your order.", "Thank You !", MessageBoxButtons.OK, MessageBoxIcon.Information)


            'Show the personal information page
            Personal_Information_Form.Show()
            Me.Close()

        End If








    End Sub

    Private Sub ResetSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSelectionToolStripMenuItem.Click
        For Each control As Control In Me.Controls


            If TypeOf control Is ComboBox Then
                control.Text = "select"
            End If

            If TypeOf control Is RadioButton Then
                control.Text = " "
            End If


        Next


    End Sub





    Private Sub btnDONE_MouseHover(sender As Object, e As EventArgs) Handles btnDONE.MouseHover
        ContextMenuStrip1.Show(btnDONE, 1, btnDONE.Height)



    End Sub





    Private Sub CheckTotalPriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckTotalPriceToolStripMenuItem.Click

    End Sub









    Private Sub AvailabletyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailabletyToolStripMenuItem.Click



        'Group Member Count''''''''''''''''''''''''''''''''''''''''''''''''''
        If cmbWalkingDuration.SelectedIndex = 1 Then
            G3D = G3D - 1
            If G3D < 1 Then
                MessageBox.Show("Only 16 People are allowed in 3 days walking group ." & vbCrLf & vbCrLf & "Please select another group.", "NOT MORE THAN 16....!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If

        If cmbWalkingDuration.SelectedIndex = 2 Then
            G5D = G5D - 1
            If G5D < 1 Then
                MessageBox.Show("Only 16 People are allowed in 5 days walking group ." & vbCrLf & vbCrLf & "Please select another group.", "NOT MORE THAN 16....!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If

        If cmbWalkingDuration.SelectedIndex = 3 Then
            G10D = G10D - 1
            If G10D < 1 Then
                MessageBox.Show("Only 16 People are allowed in 10 days walking group ." & vbCrLf & vbCrLf & "Please select another group.", "NOT MORE THAN 16....!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub





End Class
