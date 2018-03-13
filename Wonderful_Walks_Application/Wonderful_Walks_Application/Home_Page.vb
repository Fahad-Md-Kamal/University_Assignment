'''''''''''''''''''''''''''''''''' 00171328_Fahad_Md_Kamal_IFY_ITP_January_2018 '''''''''''''''''''''''''''''''''''''''''

Public Class Home_Page
    '''''''''''''''''''''''''''''''''''''''''''''''' Declaring Golbal arrays '''''''''''''''''''''''''''''''''''''
    Dim PriceDuration() As Integer = {0, 0, 0, 0}
    Dim PriceLocation() As Integer = {0, 30, 20, 30}
    Dim PriceAccomodation() As Integer = {0, 40, 60, 10}
    Dim PriceLuggage() As Integer = {0, 0, 30}
    Dim PriceFood() As Integer = {0, 10, 20, 25, 30, 20}


    ''''''''''''''''''''''''''''''''''''''''' Declaring Additional Items Price Arrays ''''''''''''''''''''''''''''''''''''''''
    Dim PriceAdditional() As Integer = {5, 10, 5, 20, 30}


    '''''''''''''''''''''''''''''''''''''''''''''''' Declaring Group Stock ''''''''''''''''''''''''''''''''''''
    Dim Group3D As Integer = 16
    Dim Group5D As Integer = 16
    Dim Group10D As Integer = 16


    Private Sub Home_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ''''''''''''''''''''''''''''''''''''''' Form Name Change during form load event. '''''''''''''''''''''''''''''''
        Me.Text = ("Wonderful Walks")


        '''''''''''''''''''''''''''''''' Walking Duration options items adding to the ComboBox ''''''''''''''''''''''''''''''''''''
        cmbWalkingDuration.Items.Add("Select")
        cmbWalkingDuration.Items.Add("3 Days")
        cmbWalkingDuration.Items.Add("5 days")
        cmbWalkingDuration.Items.Add("10 days")

        cmbWalkingDuration.SelectedIndex = 0


        ''''''''''''''''''''''''''''''''''' Walking Location options items adding to the ComboBox ''''''''''''''''''''''''''''''''''''
        cmbWalkingLocation.Items.Add("Select")
        cmbWalkingLocation.Items.Add("Trossachs")
        cmbWalkingLocation.Items.Add("Great Glen")
        cmbWalkingLocation.Items.Add("West Highland Way")

        cmbWalkingLocation.SelectedIndex = 0


        '''''''''''''''''''''''''''''''''''''''''''' Accommodation options adding to the ComboBox ''''''''''''''''''''''''''''''''''''
        cmbAccommodationOptions.Items.Add("Select")
        cmbAccommodationOptions.Items.Add("Camping")
        cmbAccommodationOptions.Items.Add("Youth Hostel")
        cmbAccommodationOptions.Items.Add("Bed & Breakfast")

        cmbAccommodationOptions.SelectedIndex = 0


        ''''''''''''''''''''''''''''''''''''''''''' Luggage carry options items adding to the ComboBox ''''''''''''''''''''''''''''''''''''
        cmbLuggageCarry.Items.Add("Select")
        cmbLuggageCarry.Items.Add("Carry Own Luggage")
        cmbLuggageCarry.Items.Add("Transported Luggage")

        cmbLuggageCarry.SelectedIndex = 0


        '''''''''''''''''''''''''''''''''''''''''''' Food options items adding to the ComboBox ''''''''''''''''''''''''''''''''''''
        cmbFoodOption.Items.Add("Select")
        cmbFoodOption.Items.Add("Self-Catering")
        cmbFoodOption.Items.Add("Catered Vegetarian")
        cmbFoodOption.Items.Add("Catered Regular")
        cmbFoodOption.Items.Add("Catered Gluten Free")
        cmbFoodOption.Items.Add("Catered Lactose Free")

        cmbFoodOption.SelectedIndex = 0


        '''''''''''''''''''''''''''''''''''''''''' Adding additional Items to the checklistbox '''''''''''''''''''''''''''''''''''''''''''
        chklstAdditional_Items.Items.Add("Solar charger : £5")
        chklstAdditional_Items.Items.Add("Walking poles (pair) : £10")
        chklstAdditional_Items.Items.Add("Mosquito net : £5")
        chklstAdditional_Items.Items.Add("2-man tent : £20")
        chklstAdditional_Items.Items.Add("4-man tent : £30")

    End Sub


    Private Sub btnDONE_Click_1(sender As Object, e As EventArgs) Handles btnDONE.Click

        ''''''''''''''''''''''''''''''''''''''''''''' Declaring Veriable ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim MainOutput, AddOutput, MsgOutput As String
        Dim MainPrice, MainTotal, AddTotal, GrandTotal As Integer
        MainOutput = ""
        AddOutput = ""


        '''''''''''''''''''''''''''''''''''''''''''' Walking Duration selection actions '''''''''''''''''''''''''''''''''''''''''
        If cmbWalkingDuration.SelectedIndex < 1 Then
            MessageBox.Show("You have to select a Walking duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else MainOutput += "Selected duration :  " + cmbWalkingDuration.SelectedItem & vbCrLf
            MainPrice += PriceDuration(cmbWalkingDuration.SelectedIndex)
        End If


        '''''''''''''''''''''''''''''''''''''''''''' WalkingLocation selection actions ''''''''''''''''''''''''''''''''''''''
        If cmbWalkingLocation.SelectedIndex < 1 Then
            MessageBox.Show("You have to select a Walking Location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else MainOutput += "Selected Location :  " + cmbWalkingLocation.SelectedItem & vbCrLf
            MainPrice += PriceLocation(cmbWalkingLocation.SelectedIndex)
        End If


        '''''''''''''''''''''''''''''''''''''''''''''''''''''' Accommodation selection Actions ''''''''''''''''''''''''''''''''''''''''''''''''''''
        If cmbAccommodationOptions.SelectedIndex < 1 Then
            MessageBox.Show("You have to select an Accommodation Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else MainOutput += "Selected Accommodation Type :  " + cmbAccommodationOptions.SelectedItem & vbCrLf
            MainPrice += PriceAccomodation(cmbAccommodationOptions.SelectedIndex)
        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''' Luggage Carry selection Actions ''''''''''''''''''''''''''''''''''''''''''
        If cmbLuggageCarry.SelectedIndex < 1 Then
            MessageBox.Show("You have to select Luggage Carry Option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else MainOutput += "Selected Luggage Carry Option :  " + cmbLuggageCarry.SelectedItem & vbCrLf
            MainPrice += PriceLuggage(cmbLuggageCarry.SelectedIndex)
        End If


        '''''''''''''''''''''''''''''''''''''''''''''''''''''Food Option selection actions '''''''''''''''''''''''''''''''''''''''''''''
        If cmbFoodOption.SelectedIndex < 1 Then
            MessageBox.Show("You have to select Food Option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else MainOutput += "Selected Food Option :  " + cmbFoodOption.SelectedItem & vbCrLf
            MainPrice += PriceFood(cmbFoodOption.SelectedIndex)
        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''Group Stock Check''''''''''''''''''''''''''''''''''''''''''''''''''

        If cmbWalkingDuration.SelectedIndex = 1 Then
            Group3D = Group3D - 1
            If Group3D < 0 Then
                MessageBox.Show("Only 16 People are allowed in 3 days walking group ." & vbCrLf & vbCrLf & "Please select another group.", "Out of Stock!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If
        If cmbWalkingDuration.SelectedIndex = 2 Then
            Group5D = Group5D - 1
            If Group5D < 0 Then
                MessageBox.Show("Only 16 People are allowed in 5 days walking group ." & vbCrLf & vbCrLf & "Please select another group.", "Out of Stock!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If
        If cmbWalkingDuration.SelectedIndex = 3 Then
            Group10D = Group10D - 1
            If Group10D < 0 Then
                MessageBox.Show("Only 16 People are allowed in 10 days walking group ." & vbCrLf & vbCrLf & "Please select another group.", "Out of Stock!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If


        '''''''''''''''''''''''''''''''''' Additional Items Output '''''''''''''''''''''''''''''''''''''''''
        For Each AdtItm In chklstAdditional_Items.CheckedItems
            AddOutput += AdtItm & vbCrLf
        Next
        For Each CbxChk In chklstAdditional_Items.CheckedIndices
            AddTotal += PriceAdditional(CbxChk)
        Next


        ''''''''''''''''''''''''''''''''''''' Mathmetical Terms ''''''''''''''''''''''''''''''''''''''''''''
        MainTotal += MainPrice
        GrandTotal = MainTotal + AddTotal

        ''''''''''''''''''''''''''''' Output Formet ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        MsgOutput = MainOutput & vbCrLf & vbCrLf & AddOutput & vbCrLf & "Total Cost :  " & GrandTotal & " £"


        ''''''''''''''''''''''''''''''''' Confirmation MessegeBox & its button click actions '''''''''''''''''''''''''''''
        Dim proment As DialogResult = MessageBox.Show(MsgOutput & vbCrLf & vbCrLf & "Do you want to pay for the Items that you've selected ?", "Summary Of Choices", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If proment = DialogResult.Yes Then
            MessageBox.Show("Let's Go To The Final Form...!!", ">>>>>>>>>>>  Thank You  <<<<<<<<<<<", MessageBoxButtons.OK, MessageBoxIcon.None)
            Payment_Confirmation_Page.Show()
            Me.Close()

        End If
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''' Exit button click action '''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btnEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        MessageBox.Show("Thanks for visiting Wonderful Walks.", "Good Bye...!!")
        Payment_Confirmation_Page.Close()
        Me.Close()
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''' Walking Duration Price List '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub PB_WD_Click(sender As Object, e As EventArgs) Handles PB_WD.Click
        MessageBox.Show("There is no Cost for Walking.", "GOOD NEWS ", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub


    ''''''''''''''''''''''''''''''''''' Walking Location Price List '''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub PB_WL_Click(sender As Object, e As EventArgs) Handles PB_WL.Click

        Dim WLOtp As String
        WLOtp = "Walking Location : Trossachs = 30 £ " & vbCrLf & "Walking Location : Great Glen = 20 £ " & vbCrLf & "Walking Location : West Highland Way = 30 £ "
        MessageBox.Show(WLOtp, "Walking Location Price List", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    '''''''''''''''''''''''''''''''''''''' Accommodation Type Price list ''''''''''''''''''''''''''''''''''
    Private Sub PB_ACC_Click(sender As Object, e As EventArgs) Handles PB_ACC.Click

        Dim ACP As String
        ACP = "Accommodation Type : Camping = 40 £ " & vbCrLf & "Accommodation Type : Youth Hostel = 60 £ " & vbCrLf & "Accommodation Type : Bed & Breakfast = 10 £ "
        MessageBox.Show(ACP, "Accommodation Type Price List", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    '''''''''''''''''''''''''''''''''''' Luggage Carry Price List '''''''''''''''''''''''''''''
    Private Sub PB_Lug_Click(sender As Object, e As EventArgs) Handles PB_Lug.Click
        Dim LC As String
        LC = "Carry Own Luggage : Free Of Cost " & vbCrLf & "Transported Luggage : 60 £ "
        MessageBox.Show(LC, "Luggage Carry Price List", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    '''''''''''''''''''''''''''''''''''' Food Option Price List '''''''''''''''''''''''''''''''''
    Private Sub PB_Food_Click(sender As Object, e As EventArgs) Handles PB_Food.Click
        Dim ACP As String
        ACP = "Food Option : Self-Catering = 10 £ " & vbCrLf & "Food Option : Catered Vegetarian = 20 £ " & vbCrLf & "Food Option : Catered Regular = 25 £ " & vbCrLf & "Food Option : Catered Gluten Free = 30 £ " & vbCrLf & "Food Option : Catered Lactose Free = 20 £ "
        MessageBox.Show(ACP, "Food Option Price List", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PB_ResetAll_Click(sender As Object, e As EventArgs) Handles PB_ResetAll.Click
        For Each cmbx As Control In Me.Controls
            If TypeOf cmbx Is ComboBox Then
                cmbx.Text = "Select"
            End If
        Next
    End Sub
End Class
