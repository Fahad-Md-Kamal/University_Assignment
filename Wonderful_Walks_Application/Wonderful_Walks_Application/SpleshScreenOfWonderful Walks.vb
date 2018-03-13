'00171328_Fahad_Md_Kamal_IFY_ITP_January_2018

Public Class SpleshScreenOfWonderful_Walks

    Private Sub SpleshScreenOfWonderful_Walks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Starting Timer
        tmr_1.Start()
    End Sub

    Private Sub tmr_1_Tick(sender As Object, e As EventArgs) Handles tmr_1.Tick
        'Increamenting Progress Bar
        ProgBar.Value += 1


        'Showing the Progress bars parcentage on lable.

        If ProgBar.Value = 8 Then
            lblCmpnyName.Text = "Welcome To"
        End If
        If ProgBar.Value = 50 Then
            lblCmpnyName.Text = "Wonderful Walks"
        End If
        If ProgBar.Value = 60 Then
            lblScottishHighlands.Text = "Scottish Highlands"
        End If
        If ProgBar.Value = 60 Then
            lblDvlpr.Text = "Developer"
        End If
        If ProgBar.Value = 80 Then
            lblDvlpr.Text = "00171328_Fahad_Md_Kamal_IFY_ITP_January_2018"
        End If


        If ProgBar.Value = 100 Then
            'stopping the timer
            tmr_1.Stop()
            'Selection Page Show UP
            Home_Page.Show()
            'Closing the Splash screen
            Me.Close()
        End If


        lbl_Percentage.Text = ProgBar.Value


    End Sub


End Class