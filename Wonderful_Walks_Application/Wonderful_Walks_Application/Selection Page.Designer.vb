<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Selection_Page
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Selection_Page))
        Me.lblWalkingDuration = New System.Windows.Forms.Label()
        Me.cmbWalkingDuration = New System.Windows.Forms.ComboBox()
        Me.lblWalkLocation = New System.Windows.Forms.Label()
        Me.cmbWalkingLocation = New System.Windows.Forms.ComboBox()
        Me.lblAccommodation = New System.Windows.Forms.Label()
        Me.cmbAccommodation = New System.Windows.Forms.ComboBox()
        Me.lblLuggage = New System.Windows.Forms.Label()
        Me.cmbLuggage = New System.Windows.Forms.ComboBox()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.cmbFood = New System.Windows.Forms.ComboBox()
        Me.lblTitleBar = New System.Windows.Forms.Label()
        Me.btnDONE = New System.Windows.Forms.Button()
        Me.rdbSolarCharger = New System.Windows.Forms.RadioButton()
        Me.rdbWalkingPoles = New System.Windows.Forms.RadioButton()
        Me.rdbMosquitonet = New System.Windows.Forms.RadioButton()
        Me.rdb2_ManTent = New System.Windows.Forms.RadioButton()
        Me.rdb4_ManTent = New System.Windows.Forms.RadioButton()
        Me.grpbOptional = New System.Windows.Forms.GroupBox()
        Me.rdbNone = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckTotalPriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvailabletyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpbOptional.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWalkingDuration
        '
        Me.lblWalkingDuration.AutoSize = True
        Me.lblWalkingDuration.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWalkingDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWalkingDuration.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWalkingDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWalkingDuration.Location = New System.Drawing.Point(37, 77)
        Me.lblWalkingDuration.Name = "lblWalkingDuration"
        Me.lblWalkingDuration.Size = New System.Drawing.Size(167, 30)
        Me.lblWalkingDuration.TabIndex = 1
        Me.lblWalkingDuration.Text = "Walking Duration :"
        Me.lblWalkingDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbWalkingDuration
        '
        Me.cmbWalkingDuration.BackColor = System.Drawing.Color.SlateGray
        Me.cmbWalkingDuration.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWalkingDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbWalkingDuration.FormattingEnabled = True
        Me.cmbWalkingDuration.Location = New System.Drawing.Point(218, 77)
        Me.cmbWalkingDuration.Name = "cmbWalkingDuration"
        Me.cmbWalkingDuration.Size = New System.Drawing.Size(280, 33)
        Me.cmbWalkingDuration.TabIndex = 2
        '
        'lblWalkLocation
        '
        Me.lblWalkLocation.AutoSize = True
        Me.lblWalkLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWalkLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWalkLocation.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWalkLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWalkLocation.Location = New System.Drawing.Point(37, 136)
        Me.lblWalkLocation.Name = "lblWalkLocation"
        Me.lblWalkLocation.Size = New System.Drawing.Size(147, 30)
        Me.lblWalkLocation.TabIndex = 1
        Me.lblWalkLocation.Text = "Walk Location : "
        Me.lblWalkLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbWalkingLocation
        '
        Me.cmbWalkingLocation.BackColor = System.Drawing.Color.SlateGray
        Me.cmbWalkingLocation.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWalkingLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbWalkingLocation.FormattingEnabled = True
        Me.cmbWalkingLocation.Location = New System.Drawing.Point(218, 136)
        Me.cmbWalkingLocation.Name = "cmbWalkingLocation"
        Me.cmbWalkingLocation.Size = New System.Drawing.Size(280, 33)
        Me.cmbWalkingLocation.TabIndex = 2
        '
        'lblAccommodation
        '
        Me.lblAccommodation.AutoSize = True
        Me.lblAccommodation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAccommodation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccommodation.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccommodation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccommodation.Location = New System.Drawing.Point(37, 193)
        Me.lblAccommodation.Name = "lblAccommodation"
        Me.lblAccommodation.Size = New System.Drawing.Size(157, 30)
        Me.lblAccommodation.TabIndex = 1
        Me.lblAccommodation.Text = "Accommodation :"
        Me.lblAccommodation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbAccommodation
        '
        Me.cmbAccommodation.BackColor = System.Drawing.Color.SlateGray
        Me.cmbAccommodation.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccommodation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbAccommodation.FormattingEnabled = True
        Me.cmbAccommodation.Location = New System.Drawing.Point(218, 193)
        Me.cmbAccommodation.Name = "cmbAccommodation"
        Me.cmbAccommodation.Size = New System.Drawing.Size(280, 33)
        Me.cmbAccommodation.TabIndex = 2
        '
        'lblLuggage
        '
        Me.lblLuggage.AutoSize = True
        Me.lblLuggage.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLuggage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLuggage.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuggage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLuggage.Location = New System.Drawing.Point(37, 254)
        Me.lblLuggage.Name = "lblLuggage"
        Me.lblLuggage.Size = New System.Drawing.Size(95, 30)
        Me.lblLuggage.TabIndex = 1
        Me.lblLuggage.Text = "Luggage :"
        Me.lblLuggage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbLuggage
        '
        Me.cmbLuggage.BackColor = System.Drawing.Color.SlateGray
        Me.cmbLuggage.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLuggage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbLuggage.FormattingEnabled = True
        Me.cmbLuggage.Location = New System.Drawing.Point(218, 254)
        Me.cmbLuggage.Name = "cmbLuggage"
        Me.cmbLuggage.Size = New System.Drawing.Size(280, 33)
        Me.cmbLuggage.TabIndex = 2
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFood.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFood.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFood.Location = New System.Drawing.Point(37, 320)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(65, 30)
        Me.lblFood.TabIndex = 1
        Me.lblFood.Text = "Food :"
        Me.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbFood
        '
        Me.cmbFood.BackColor = System.Drawing.Color.SlateGray
        Me.cmbFood.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFood.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbFood.FormattingEnabled = True
        Me.cmbFood.Location = New System.Drawing.Point(218, 315)
        Me.cmbFood.Name = "cmbFood"
        Me.cmbFood.Size = New System.Drawing.Size(280, 33)
        Me.cmbFood.TabIndex = 2
        '
        'lblTitleBar
        '
        Me.lblTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitleBar.Font = New System.Drawing.Font("Roboto Condensed", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitleBar.Location = New System.Drawing.Point(37, 9)
        Me.lblTitleBar.Name = "lblTitleBar"
        Me.lblTitleBar.Size = New System.Drawing.Size(762, 49)
        Me.lblTitleBar.TabIndex = 1
        Me.lblTitleBar.Text = "Wonderful Walkes"
        Me.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDONE
        '
        Me.btnDONE.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDONE.Font = New System.Drawing.Font("Roboto Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDONE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDONE.Location = New System.Drawing.Point(352, 463)
        Me.btnDONE.Name = "btnDONE"
        Me.btnDONE.Size = New System.Drawing.Size(146, 47)
        Me.btnDONE.TabIndex = 0
        Me.btnDONE.Text = "&DONE"
        Me.btnDONE.UseVisualStyleBackColor = False
        '
        'rdbSolarCharger
        '
        Me.rdbSolarCharger.BackColor = System.Drawing.Color.LightSlateGray
        Me.rdbSolarCharger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdbSolarCharger.Location = New System.Drawing.Point(3, 34)
        Me.rdbSolarCharger.Name = "rdbSolarCharger"
        Me.rdbSolarCharger.Size = New System.Drawing.Size(271, 35)
        Me.rdbSolarCharger.TabIndex = 0
        Me.rdbSolarCharger.Text = "Solar charger : £5"
        Me.rdbSolarCharger.UseVisualStyleBackColor = False
        '
        'rdbWalkingPoles
        '
        Me.rdbWalkingPoles.AutoSize = True
        Me.rdbWalkingPoles.BackColor = System.Drawing.Color.LightSlateGray
        Me.rdbWalkingPoles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdbWalkingPoles.Location = New System.Drawing.Point(3, 75)
        Me.rdbWalkingPoles.Name = "rdbWalkingPoles"
        Me.rdbWalkingPoles.Size = New System.Drawing.Size(271, 32)
        Me.rdbWalkingPoles.TabIndex = 0
        Me.rdbWalkingPoles.Text = "Walking poles (pair) : £10"
        Me.rdbWalkingPoles.UseVisualStyleBackColor = False
        '
        'rdbMosquitonet
        '
        Me.rdbMosquitonet.BackColor = System.Drawing.Color.LightSlateGray
        Me.rdbMosquitonet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdbMosquitonet.Location = New System.Drawing.Point(4, 114)
        Me.rdbMosquitonet.Name = "rdbMosquitonet"
        Me.rdbMosquitonet.Size = New System.Drawing.Size(271, 32)
        Me.rdbMosquitonet.TabIndex = 0
        Me.rdbMosquitonet.Text = "Mosquito net : £5"
        Me.rdbMosquitonet.UseVisualStyleBackColor = False
        '
        'rdb2_ManTent
        '
        Me.rdb2_ManTent.BackColor = System.Drawing.Color.LightSlateGray
        Me.rdb2_ManTent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdb2_ManTent.Location = New System.Drawing.Point(4, 153)
        Me.rdb2_ManTent.Name = "rdb2_ManTent"
        Me.rdb2_ManTent.Size = New System.Drawing.Size(271, 32)
        Me.rdb2_ManTent.TabIndex = 0
        Me.rdb2_ManTent.Text = "2-man tent : £20"
        Me.rdb2_ManTent.UseVisualStyleBackColor = False
        '
        'rdb4_ManTent
        '
        Me.rdb4_ManTent.BackColor = System.Drawing.Color.LightSlateGray
        Me.rdb4_ManTent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdb4_ManTent.Location = New System.Drawing.Point(4, 191)
        Me.rdb4_ManTent.Name = "rdb4_ManTent"
        Me.rdb4_ManTent.Size = New System.Drawing.Size(271, 32)
        Me.rdb4_ManTent.TabIndex = 0
        Me.rdb4_ManTent.Text = "4-man tent : £30"
        Me.rdb4_ManTent.UseVisualStyleBackColor = False
        '
        'grpbOptional
        '
        Me.grpbOptional.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpbOptional.Controls.Add(Me.rdbNone)
        Me.grpbOptional.Controls.Add(Me.rdb4_ManTent)
        Me.grpbOptional.Controls.Add(Me.rdb2_ManTent)
        Me.grpbOptional.Controls.Add(Me.rdbMosquitonet)
        Me.grpbOptional.Controls.Add(Me.rdbWalkingPoles)
        Me.grpbOptional.Controls.Add(Me.rdbSolarCharger)
        Me.grpbOptional.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbOptional.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grpbOptional.Location = New System.Drawing.Point(519, 77)
        Me.grpbOptional.Name = "grpbOptional"
        Me.grpbOptional.Size = New System.Drawing.Size(280, 273)
        Me.grpbOptional.TabIndex = 4
        Me.grpbOptional.TabStop = False
        Me.grpbOptional.Text = "Additional Items"
        '
        'rdbNone
        '
        Me.rdbNone.BackColor = System.Drawing.Color.LightSlateGray
        Me.rdbNone.Checked = True
        Me.rdbNone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdbNone.Location = New System.Drawing.Point(4, 229)
        Me.rdbNone.Name = "rdbNone"
        Me.rdbNone.Size = New System.Drawing.Size(271, 32)
        Me.rdbNone.TabIndex = 0
        Me.rdbNone.TabStop = True
        Me.rdbNone.Text = "None"
        Me.rdbNone.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Roboto Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(343, 890)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&DONE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Roboto Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(318, 1323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 47)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "&DONE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(347, 944)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 30)
        Me.Label3.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckTotalPriceToolStripMenuItem, Me.AvailabletyToolStripMenuItem, Me.ResetSelectionToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 70)
        '
        'CheckTotalPriceToolStripMenuItem
        '
        Me.CheckTotalPriceToolStripMenuItem.Name = "CheckTotalPriceToolStripMenuItem"
        Me.CheckTotalPriceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CheckTotalPriceToolStripMenuItem.Text = "Check Total Price"
        '
        'AvailabletyToolStripMenuItem
        '
        Me.AvailabletyToolStripMenuItem.Name = "AvailabletyToolStripMenuItem"
        Me.AvailabletyToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AvailabletyToolStripMenuItem.Text = "Availablety"
        '
        'ResetSelectionToolStripMenuItem
        '
        Me.ResetSelectionToolStripMenuItem.Name = "ResetSelectionToolStripMenuItem"
        Me.ResetSelectionToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ResetSelectionToolStripMenuItem.Text = "Reset Selection"
        '
        'Selection_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(846, 547)
        Me.Controls.Add(Me.grpbOptional)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbFood)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.cmbLuggage)
        Me.Controls.Add(Me.lblLuggage)
        Me.Controls.Add(Me.cmbAccommodation)
        Me.Controls.Add(Me.lblAccommodation)
        Me.Controls.Add(Me.cmbWalkingLocation)
        Me.Controls.Add(Me.lblWalkLocation)
        Me.Controls.Add(Me.cmbWalkingDuration)
        Me.Controls.Add(Me.lblTitleBar)
        Me.Controls.Add(Me.lblWalkingDuration)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDONE)
        Me.MaximizeBox = False
        Me.Name = "Selection_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selection_Page"
        Me.grpbOptional.ResumeLayout(False)
        Me.grpbOptional.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWalkingDuration As Label
    Friend WithEvents cmbWalkingDuration As ComboBox
    Friend WithEvents lblWalkLocation As Label
    Friend WithEvents cmbWalkingLocation As ComboBox
    Friend WithEvents lblAccommodation As Label
    Friend WithEvents cmbAccommodation As ComboBox
    Friend WithEvents lblLuggage As Label
    Friend WithEvents cmbLuggage As ComboBox
    Friend WithEvents lblFood As Label
    Friend WithEvents cmbFood As ComboBox
    Friend WithEvents lblTitleBar As Label
    Friend WithEvents btnDONE As Button
    Friend WithEvents rdbSolarCharger As RadioButton
    Friend WithEvents rdbWalkingPoles As RadioButton
    Friend WithEvents rdbMosquitonet As RadioButton
    Friend WithEvents rdb2_ManTent As RadioButton
    Friend WithEvents rdb4_ManTent As RadioButton
    Friend WithEvents grpbOptional As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CheckTotalPriceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvailabletyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rdbNone As RadioButton
End Class
