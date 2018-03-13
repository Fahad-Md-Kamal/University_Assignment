'''''''''''''''''''''''''''''' 00171328_Fahad_Md_Kamal_IFY_ITP_January_2018 '''''''''''''''''''''''''''''''

Public Class Payment_Confirmation_Page
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        '''''''''''''''''''''' Back Button Click Event Action ''''''''''''''''''''''''
        MessageBox.Show("Going back to the selection page")
        Home_Page.Show()
        Me.Close()

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        '''''''''''''''''''''' User name input Data validation '''''''''''''''
        If txtFullName.Text = "" Then
            ErrorProvider.SetError(txtFullName, "Please enter your full name.")
            Exit Sub
        ElseIf NumericCheck(txtFullName.Text) = True
            ErrorProvider.SetError(txtFullName, "Name cannot be in numbers.")
            Exit Sub
        ElseIf txtFullName.TextLength < 4 Or txtFullName.TextLength > 20
            ErrorProvider.SetError(txtFullName, "Please enter your full name in 4 to 10 charecters.")
            Exit Sub

        End If


        ''''''''''''''''''''''''' House Number input Data validation'''''''''''''''''''''''''''''''''''
        If txtHouseNumber.Text = "" Then
            ErrorProvider.SetError(txtHouseNumber, "Please enter your house number.")
            Exit Sub
        ElseIf txtHouseNumber.TextLength < 4 Or txtHouseNumber.TextLength > 20
            ErrorProvider.SetError(txtHouseNumber, "Please enter your house number in 4 to 10 charecters.")
            Exit Sub
        End If


        '''''''''''''''''''''''''' Street Name input Data validation ''''''''''''''''''''''''''''''''''''
        If txtStreetName.Text = "" Then
            ErrorProvider.SetError(txtStreetName, "Please enter your Street Name.")
            Exit Sub
        ElseIf txtStreetName.TextLength < 4 Or txtStreetName.TextLength > 20
            ErrorProvider.SetError(txtStreetName, "Please enter your Street Name in 4 to 10 charecters.")
            Exit Sub
        End If


        '''''''''''''''''''''''''''' Town Or City input Data validation '''''''''''''''''''''''''''''''''''''
        If txtlblTownOrCity.Text = "" Then
            ErrorProvider.SetError(txtlblTownOrCity, "Please enter your Town/ City name.")
            Exit Sub
        ElseIf txtlblTownOrCity.TextLength < 4 Or txtlblTownOrCity.TextLength > 20
            ErrorProvider.SetError(txtlblTownOrCity, "Please enter your Town/ City name in 4 to 10 charecters.")
            Exit Sub
        End If


        '''''''''''''''''''''''''' Post Code input Data validation '''''''''''''''''''''''''''''''''''''''''''
        If txtPostCode.Text = "" Then
            ErrorProvider.SetError(txtPostCode, "Please enter your Post Code.")
            Exit Sub
        ElseIf SpcChk(txtPostCode.Text) = True
            ErrorProvider.SetError(txtPostCode, " Post Code cannot have any space.")
            Exit Sub
        ElseIf AlphabeticCheck(txtPostCode.Text) = True
            ErrorProvider.SetError(txtPostCode, "Post Code must be in numbers.")
            Exit Sub
        ElseIf txtPostCode.TextLength < 4 Or txtPostCode.TextLength > 10
            ErrorProvider.SetError(txtPostCode, "Please enter your Post Code in 4 to 10 charecters.")
            Exit Sub
        End If


        ''''''''''''''''''''' Credit Card Number input Data validation ''''''''''''''''''''''''''
        If txtCardNumber.Text = "" Then
            ErrorProvider.SetError(txtCardNumber, "Please enter your Cedrit/ Debit Card Number.")
            Exit Sub
        ElseIf SpcChk(txtCardNumber.Text) = True
            ErrorProvider.SetError(txtCardNumber, "Cedrit/ Debit Card Number cannot have any space.")
            Exit Sub
        ElseIf AlphabeticCheck(txtCardNumber.Text) = True
            ErrorProvider.SetError(txtCardNumber, "Cedrit/ Debit Card Number cannot have any Alphabet.")
            Exit Sub
        ElseIf txtCardNumber.TextLength <> 16
            ErrorProvider.SetError(txtCardNumber, "Degits Cedrit/ Debit Card Number must be in 16 Degits.")
            Exit Sub
        End If


        '''''''''''''''''''''''''''''''''''''' Thank you messagebox and  button actions '''''''''''''''''''''''''''''''''''''''''
        Dim thnqmsgbx As DialogResult = MessageBox.Show("Thank you for the information" & vbCrLf & vbCrLf & "See You Soon !!", ">>>>>>>>>>  Thank you  <<<<<<<<<<", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If thnqmsgbx = DialogResult.OK Then
            Dim lastmsgbx As DialogResult = MessageBox.Show("Do you want to fill another ?", ">>>>>>>>>>  Thank you  <<<<<<<<<<", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)

            If lastmsgbx = DialogResult.Yes Then
                Home_Page.Show()
                Me.Close()

            ElseIf lastmsgbx = DialogResult.No
                Me.Close()


            End If
        End If

    End Sub

    Private Sub Payment_Confirmation_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Wonderful Walks"
    End Sub

    Private Sub ClearText(sender As Object, e As EventArgs) Handles txtFullName.TextChanged, txtHouseNumber.TextChanged, txtStreetName.TextChanged, txtlblTownOrCity.TextChanged, txtPostCode.TextChanged, txtCardNumber.TextChanged


        '''''''''''''''''''''''''''''''''''' Clearing Error provider icons '''''''''''''''''''''''''''''''''''
        ErrorProvider.Clear()


    End Sub

    Private Sub btn_EXIT_Click(sender As Object, e As EventArgs) Handles btn_EXIT.Click

        Home_Page.Close()
        Me.Close()

    End Sub
End Class