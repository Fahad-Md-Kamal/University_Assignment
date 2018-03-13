<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Page))
        Me.cmbFoodOption = New System.Windows.Forms.ComboBox()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.cmbLuggageCarry = New System.Windows.Forms.ComboBox()
        Me.lblLuggage = New System.Windows.Forms.Label()
        Me.cmbAccommodationOptions = New System.Windows.Forms.ComboBox()
        Me.lblAccommodation = New System.Windows.Forms.Label()
        Me.cmbWalkingLocation = New System.Windows.Forms.ComboBox()
        Me.lblWalkLocation = New System.Windows.Forms.Label()
        Me.cmbWalkingDuration = New System.Windows.Forms.ComboBox()
        Me.lblTitleBar = New System.Windows.Forms.Label()
        Me.lblWalkingDuration = New System.Windows.Forms.Label()
        Me.btnDONE = New System.Windows.Forms.Button()
        Me.PB_WD = New System.Windows.Forms.PictureBox()
        Me.chklstAdditional_Items = New System.Windows.Forms.CheckedListBox()
        Me.lblAdditionalItems = New System.Windows.Forms.Label()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.PB_WL = New System.Windows.Forms.PictureBox()
        Me.PB_ACC = New System.Windows.Forms.PictureBox()
        Me.PB_Lug = New System.Windows.Forms.PictureBox()
        Me.PB_Food = New System.Windows.Forms.PictureBox()
        Me.PB_ResetAll = New System.Windows.Forms.PictureBox()
        Me.lblResetAll = New System.Windows.Forms.Label()
        CType(Me.PB_WD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_WL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ACC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Lug, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Food, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ResetAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbFoodOption
        '
        Me.cmbFoodOption.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmbFoodOption.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFoodOption.ForeColor = System.Drawing.Color.FloralWhite
        Me.cmbFoodOption.FormattingEnabled = True
        Me.cmbFoodOption.Location = New System.Drawing.Point(21, 329)
        Me.cmbFoodOption.Name = "cmbFoodOption"
        Me.cmbFoodOption.Size = New System.Drawing.Size(273, 27)
        Me.cmbFoodOption.TabIndex = 12
        '
        'lblFood
        '
        Me.lblFood.BackColor = System.Drawing.Color.Transparent
        Me.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFood.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFood.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFood.Location = New System.Drawing.Point(21, 296)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(274, 30)
        Me.lblFood.TabIndex = 6
        Me.lblFood.Text = "Food"
        Me.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbLuggageCarry
        '
        Me.cmbLuggageCarry.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmbLuggageCarry.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLuggageCarry.ForeColor = System.Drawing.Color.FloralWhite
        Me.cmbLuggageCarry.FormattingEnabled = True
        Me.cmbLuggageCarry.Location = New System.Drawing.Point(21, 216)
        Me.cmbLuggageCarry.Name = "cmbLuggageCarry"
        Me.cmbLuggageCarry.Size = New System.Drawing.Size(273, 27)
        Me.cmbLuggageCarry.TabIndex = 13
        '
        'lblLuggage
        '
        Me.lblLuggage.BackColor = System.Drawing.Color.Transparent
        Me.lblLuggage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLuggage.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuggage.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblLuggage.Location = New System.Drawing.Point(21, 180)
        Me.lblLuggage.Name = "lblLuggage"
        Me.lblLuggage.Size = New System.Drawing.Size(274, 30)
        Me.lblLuggage.TabIndex = 7
        Me.lblLuggage.Text = "Luggage"
        Me.lblLuggage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbAccommodationOptions
        '
        Me.cmbAccommodationOptions.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmbAccommodationOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccommodationOptions.ForeColor = System.Drawing.Color.FloralWhite
        Me.cmbAccommodationOptions.FormattingEnabled = True
        Me.cmbAccommodationOptions.Location = New System.Drawing.Point(691, 106)
        Me.cmbAccommodationOptions.Name = "cmbAccommodationOptions"
        Me.cmbAccommodationOptions.Size = New System.Drawing.Size(273, 27)
        Me.cmbAccommodationOptions.TabIndex = 14
        '
        'lblAccommodation
        '
        Me.lblAccommodation.BackColor = System.Drawing.Color.Transparent
        Me.lblAccommodation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccommodation.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccommodation.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblAccommodation.Location = New System.Drawing.Point(691, 73)
        Me.lblAccommodation.Name = "lblAccommodation"
        Me.lblAccommodation.Size = New System.Drawing.Size(274, 30)
        Me.lblAccommodation.TabIndex = 8
        Me.lblAccommodation.Text = "Accommodation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAccommodation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbWalkingLocation
        '
        Me.cmbWalkingLocation.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmbWalkingLocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWalkingLocation.ForeColor = System.Drawing.Color.FloralWhite
        Me.cmbWalkingLocation.FormattingEnabled = True
        Me.cmbWalkingLocation.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.cmbWalkingLocation.Location = New System.Drawing.Point(341, 106)
        Me.cmbWalkingLocation.Name = "cmbWalkingLocation"
        Me.cmbWalkingLocation.Size = New System.Drawing.Size(273, 27)
        Me.cmbWalkingLocation.TabIndex = 15
        '
        'lblWalkLocation
        '
        Me.lblWalkLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblWalkLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWalkLocation.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWalkLocation.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblWalkLocation.Location = New System.Drawing.Point(341, 73)
        Me.lblWalkLocation.Name = "lblWalkLocation"
        Me.lblWalkLocation.Size = New System.Drawing.Size(274, 30)
        Me.lblWalkLocation.TabIndex = 9
        Me.lblWalkLocation.Text = "Walk Location "
        Me.lblWalkLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbWalkingDuration
        '
        Me.cmbWalkingDuration.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmbWalkingDuration.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWalkingDuration.ForeColor = System.Drawing.Color.FloralWhite
        Me.cmbWalkingDuration.FormattingEnabled = True
        Me.cmbWalkingDuration.Location = New System.Drawing.Point(21, 106)
        Me.cmbWalkingDuration.Name = "cmbWalkingDuration"
        Me.cmbWalkingDuration.Size = New System.Drawing.Size(273, 27)
        Me.cmbWalkingDuration.TabIndex = 16
        '
        'lblTitleBar
        '
        Me.lblTitleBar.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitleBar.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleBar.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitleBar.Location = New System.Drawing.Point(21, 11)
        Me.lblTitleBar.Name = "lblTitleBar"
        Me.lblTitleBar.Size = New System.Drawing.Size(945, 62)
        Me.lblTitleBar.TabIndex = 10
        Me.lblTitleBar.Text = "Wonderful Walks"
        Me.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWalkingDuration
        '
        Me.lblWalkingDuration.BackColor = System.Drawing.Color.Transparent
        Me.lblWalkingDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWalkingDuration.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWalkingDuration.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblWalkingDuration.Location = New System.Drawing.Point(21, 73)
        Me.lblWalkingDuration.Name = "lblWalkingDuration"
        Me.lblWalkingDuration.Size = New System.Drawing.Size(274, 30)
        Me.lblWalkingDuration.TabIndex = 11
        Me.lblWalkingDuration.Text = "Walking Duration"
        Me.lblWalkingDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDONE
        '
        Me.btnDONE.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDONE.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDONE.ForeColor = System.Drawing.Color.White
        Me.btnDONE.Image = CType(resources.GetObject("btnDONE.Image"), System.Drawing.Image)
        Me.btnDONE.Location = New System.Drawing.Point(523, 471)
        Me.btnDONE.Name = "btnDONE"
        Me.btnDONE.Size = New System.Drawing.Size(92, 38)
        Me.btnDONE.TabIndex = 5
        Me.btnDONE.Text = "&DONE"
        Me.btnDONE.UseVisualStyleBackColor = False
        '
        'PB_WD
        '
        Me.PB_WD.BackColor = System.Drawing.Color.Transparent
        Me.PB_WD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_WD.Image = CType(resources.GetObject("PB_WD.Image"), System.Drawing.Image)
        Me.PB_WD.Location = New System.Drawing.Point(260, 73)
        Me.PB_WD.Name = "PB_WD"
        Me.PB_WD.Size = New System.Drawing.Size(34, 27)
        Me.PB_WD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_WD.TabIndex = 19
        Me.PB_WD.TabStop = False
        '
        'chklstAdditional_Items
        '
        Me.chklstAdditional_Items.BackColor = System.Drawing.Color.MidnightBlue
        Me.chklstAdditional_Items.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstAdditional_Items.ForeColor = System.Drawing.Color.FloralWhite
        Me.chklstAdditional_Items.FormattingEnabled = True
        Me.chklstAdditional_Items.Location = New System.Drawing.Point(691, 193)
        Me.chklstAdditional_Items.Name = "chklstAdditional_Items"
        Me.chklstAdditional_Items.Size = New System.Drawing.Size(273, 130)
        Me.chklstAdditional_Items.TabIndex = 20
        '
        'lblAdditionalItems
        '
        Me.lblAdditionalItems.BackColor = System.Drawing.Color.Transparent
        Me.lblAdditionalItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdditionalItems.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalItems.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblAdditionalItems.Location = New System.Drawing.Point(691, 150)
        Me.lblAdditionalItems.Name = "lblAdditionalItems"
        Me.lblAdditionalItems.Size = New System.Drawing.Size(274, 33)
        Me.lblAdditionalItems.TabIndex = 11
        Me.lblAdditionalItems.Text = "Additional Items"
        Me.lblAdditionalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEXIT
        '
        Me.btnEXIT.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEXIT.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXIT.ForeColor = System.Drawing.Color.White
        Me.btnEXIT.Image = CType(resources.GetObject("btnEXIT.Image"), System.Drawing.Image)
        Me.btnEXIT.Location = New System.Drawing.Point(341, 471)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(102, 38)
        Me.btnEXIT.TabIndex = 5
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = False
        '
        'PB_WL
        '
        Me.PB_WL.BackColor = System.Drawing.Color.Transparent
        Me.PB_WL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_WL.Image = CType(resources.GetObject("PB_WL.Image"), System.Drawing.Image)
        Me.PB_WL.Location = New System.Drawing.Point(581, 74)
        Me.PB_WL.Name = "PB_WL"
        Me.PB_WL.Size = New System.Drawing.Size(34, 27)
        Me.PB_WL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_WL.TabIndex = 19
        Me.PB_WL.TabStop = False
        '
        'PB_ACC
        '
        Me.PB_ACC.BackColor = System.Drawing.Color.Transparent
        Me.PB_ACC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_ACC.Image = CType(resources.GetObject("PB_ACC.Image"), System.Drawing.Image)
        Me.PB_ACC.Location = New System.Drawing.Point(931, 74)
        Me.PB_ACC.Name = "PB_ACC"
        Me.PB_ACC.Size = New System.Drawing.Size(34, 27)
        Me.PB_ACC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_ACC.TabIndex = 19
        Me.PB_ACC.TabStop = False
        '
        'PB_Lug
        '
        Me.PB_Lug.BackColor = System.Drawing.Color.Transparent
        Me.PB_Lug.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_Lug.Image = CType(resources.GetObject("PB_Lug.Image"), System.Drawing.Image)
        Me.PB_Lug.Location = New System.Drawing.Point(260, 180)
        Me.PB_Lug.Name = "PB_Lug"
        Me.PB_Lug.Size = New System.Drawing.Size(34, 27)
        Me.PB_Lug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Lug.TabIndex = 19
        Me.PB_Lug.TabStop = False
        '
        'PB_Food
        '
        Me.PB_Food.BackColor = System.Drawing.Color.Transparent
        Me.PB_Food.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_Food.Image = CType(resources.GetObject("PB_Food.Image"), System.Drawing.Image)
        Me.PB_Food.Location = New System.Drawing.Point(260, 296)
        Me.PB_Food.Name = "PB_Food"
        Me.PB_Food.Size = New System.Drawing.Size(34, 27)
        Me.PB_Food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Food.TabIndex = 19
        Me.PB_Food.TabStop = False
        '
        'PB_ResetAll
        '
        Me.PB_ResetAll.BackColor = System.Drawing.Color.Transparent
        Me.PB_ResetAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_ResetAll.Image = CType(resources.GetObject("PB_ResetAll.Image"), System.Drawing.Image)
        Me.PB_ResetAll.Location = New System.Drawing.Point(778, 342)
        Me.PB_ResetAll.Name = "PB_ResetAll"
        Me.PB_ResetAll.Size = New System.Drawing.Size(136, 83)
        Me.PB_ResetAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_ResetAll.TabIndex = 19
        Me.PB_ResetAll.TabStop = False
        '
        'lblResetAll
        '
        Me.lblResetAll.BackColor = System.Drawing.Color.Transparent
        Me.lblResetAll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResetAll.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblResetAll.Location = New System.Drawing.Point(808, 367)
        Me.lblResetAll.Name = "lblResetAll"
        Me.lblResetAll.Size = New System.Drawing.Size(73, 29)
        Me.lblResetAll.TabIndex = 11
        Me.lblResetAll.Text = "Reset"
        Me.lblResetAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(988, 538)
        Me.Controls.Add(Me.lblResetAll)
        Me.Controls.Add(Me.chklstAdditional_Items)
        Me.Controls.Add(Me.PB_Lug)
        Me.Controls.Add(Me.PB_ResetAll)
        Me.Controls.Add(Me.PB_Food)
        Me.Controls.Add(Me.PB_ACC)
        Me.Controls.Add(Me.PB_WL)
        Me.Controls.Add(Me.PB_WD)
        Me.Controls.Add(Me.cmbFoodOption)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.cmbLuggageCarry)
        Me.Controls.Add(Me.lblLuggage)
        Me.Controls.Add(Me.cmbAccommodationOptions)
        Me.Controls.Add(Me.lblAccommodation)
        Me.Controls.Add(Me.cmbWalkingLocation)
        Me.Controls.Add(Me.lblWalkLocation)
        Me.Controls.Add(Me.cmbWalkingDuration)
        Me.Controls.Add(Me.lblTitleBar)
        Me.Controls.Add(Me.lblAdditionalItems)
        Me.Controls.Add(Me.lblWalkingDuration)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.btnDONE)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Home_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selection_Page"
        CType(Me.PB_WD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_WL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ACC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Lug, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Food, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ResetAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbFoodOption As ComboBox
    Friend WithEvents lblFood As Label
    Friend WithEvents cmbLuggageCarry As ComboBox
    Friend WithEvents lblLuggage As Label
    Friend WithEvents cmbAccommodationOptions As ComboBox
    Friend WithEvents lblAccommodation As Label
    Friend WithEvents cmbWalkingLocation As ComboBox
    Friend WithEvents lblWalkLocation As Label
    Friend WithEvents cmbWalkingDuration As ComboBox
    Friend WithEvents lblTitleBar As Label
    Friend WithEvents lblWalkingDuration As Label
    Friend WithEvents btnDONE As Button
    Friend WithEvents PB_WD As PictureBox
    Friend WithEvents chklstAdditional_Items As CheckedListBox
    Friend WithEvents lblAdditionalItems As Label
    Friend WithEvents btnEXIT As Button
    Friend WithEvents PB_WL As PictureBox
    Friend WithEvents PB_ACC As PictureBox
    Friend WithEvents PB_Lug As PictureBox
    Friend WithEvents PB_Food As PictureBox
    Friend WithEvents PB_ResetAll As PictureBox
    Friend WithEvents lblResetAll As Label
End Class
