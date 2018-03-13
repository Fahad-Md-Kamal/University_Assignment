<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment_Confirmation_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment_Confirmation_Page))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblhousenumber = New System.Windows.Forms.Label()
        Me.txtHouseNumber = New System.Windows.Forms.TextBox()
        Me.lblstreetName = New System.Windows.Forms.Label()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.lblTownOrCity = New System.Windows.Forms.Label()
        Me.txtlblTownOrCity = New System.Windows.Forms.TextBox()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lblTitleBar = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_EXIT = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Transparent
        Me.btnSubmit.Image = CType(resources.GetObject("btnSubmit.Image"), System.Drawing.Image)
        Me.btnSubmit.Location = New System.Drawing.Point(607, 489)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(106, 46)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblhousenumber
        '
        Me.lblhousenumber.BackColor = System.Drawing.Color.Transparent
        Me.lblhousenumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblhousenumber.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhousenumber.ForeColor = System.Drawing.SystemColors.Window
        Me.lblhousenumber.Image = CType(resources.GetObject("lblhousenumber.Image"), System.Drawing.Image)
        Me.lblhousenumber.Location = New System.Drawing.Point(70, 142)
        Me.lblhousenumber.Name = "lblhousenumber"
        Me.lblhousenumber.Size = New System.Drawing.Size(258, 33)
        Me.lblhousenumber.TabIndex = 2
        Me.lblhousenumber.Text = "House Number :"
        Me.lblhousenumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtHouseNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNumber.ForeColor = System.Drawing.Color.Maroon
        Me.txtHouseNumber.Location = New System.Drawing.Point(70, 178)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(258, 26)
        Me.txtHouseNumber.TabIndex = 3
        '
        'lblstreetName
        '
        Me.lblstreetName.BackColor = System.Drawing.Color.Transparent
        Me.lblstreetName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstreetName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstreetName.ForeColor = System.Drawing.SystemColors.Window
        Me.lblstreetName.Image = CType(resources.GetObject("lblstreetName.Image"), System.Drawing.Image)
        Me.lblstreetName.Location = New System.Drawing.Point(70, 220)
        Me.lblstreetName.Name = "lblstreetName"
        Me.lblstreetName.Size = New System.Drawing.Size(258, 31)
        Me.lblstreetName.TabIndex = 2
        Me.lblstreetName.Text = "Street Name :"
        Me.lblstreetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStreetName
        '
        Me.txtStreetName.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtStreetName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetName.ForeColor = System.Drawing.Color.Maroon
        Me.txtStreetName.Location = New System.Drawing.Point(70, 255)
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.Size = New System.Drawing.Size(258, 26)
        Me.txtStreetName.TabIndex = 3
        '
        'lblTownOrCity
        '
        Me.lblTownOrCity.BackColor = System.Drawing.Color.Transparent
        Me.lblTownOrCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTownOrCity.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownOrCity.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTownOrCity.Image = CType(resources.GetObject("lblTownOrCity.Image"), System.Drawing.Image)
        Me.lblTownOrCity.Location = New System.Drawing.Point(70, 297)
        Me.lblTownOrCity.Name = "lblTownOrCity"
        Me.lblTownOrCity.Size = New System.Drawing.Size(258, 31)
        Me.lblTownOrCity.TabIndex = 2
        Me.lblTownOrCity.Text = "Town/ City :"
        Me.lblTownOrCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlblTownOrCity
        '
        Me.txtlblTownOrCity.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtlblTownOrCity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlblTownOrCity.ForeColor = System.Drawing.Color.Maroon
        Me.txtlblTownOrCity.Location = New System.Drawing.Point(70, 333)
        Me.txtlblTownOrCity.Name = "txtlblTownOrCity"
        Me.txtlblTownOrCity.Size = New System.Drawing.Size(258, 26)
        Me.txtlblTownOrCity.TabIndex = 3
        '
        'lblPostCode
        '
        Me.lblPostCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPostCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPostCode.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostCode.ForeColor = System.Drawing.SystemColors.Window
        Me.lblPostCode.Image = CType(resources.GetObject("lblPostCode.Image"), System.Drawing.Image)
        Me.lblPostCode.Location = New System.Drawing.Point(70, 379)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(258, 33)
        Me.lblPostCode.TabIndex = 2
        Me.lblPostCode.Text = "Post Code :"
        Me.lblPostCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPostCode
        '
        Me.txtPostCode.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPostCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostCode.ForeColor = System.Drawing.Color.Maroon
        Me.txtPostCode.Location = New System.Drawing.Point(70, 415)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(258, 26)
        Me.txtPostCode.TabIndex = 3
        '
        'lblCardNumber
        '
        Me.lblCardNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCardNumber.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.ForeColor = System.Drawing.SystemColors.Window
        Me.lblCardNumber.Image = CType(resources.GetObject("lblCardNumber.Image"), System.Drawing.Image)
        Me.lblCardNumber.Location = New System.Drawing.Point(70, 469)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(258, 34)
        Me.lblCardNumber.TabIndex = 2
        Me.lblCardNumber.Text = "Credit/ Debit Card :"
        Me.lblCardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCardNumber
        '
        Me.txtCardNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtCardNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.ForeColor = System.Drawing.Color.Maroon
        Me.txtCardNumber.Location = New System.Drawing.Point(70, 506)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(258, 26)
        Me.txtCardNumber.TabIndex = 3
        '
        'lblTitleBar
        '
        Me.lblTitleBar.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitleBar.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleBar.ForeColor = System.Drawing.Color.White
        Me.lblTitleBar.Image = CType(resources.GetObject("lblTitleBar.Image"), System.Drawing.Image)
        Me.lblTitleBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitleBar.Location = New System.Drawing.Point(70, 9)
        Me.lblTitleBar.Name = "lblTitleBar"
        Me.lblTitleBar.Size = New System.Drawing.Size(432, 41)
        Me.lblTitleBar.TabIndex = 2
        Me.lblTitleBar.Text = "Personal Information"
        Me.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Transparent
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(392, 489)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(110, 46)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFullName.Image = CType(resources.GetObject("lblFullName.Image"), System.Drawing.Image)
        Me.lblFullName.Location = New System.Drawing.Point(70, 64)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(258, 33)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.Text = "Full Name :"
        Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtFullName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.Maroon
        Me.txtFullName.Location = New System.Drawing.Point(70, 100)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(258, 26)
        Me.txtFullName.TabIndex = 3
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'btn_EXIT
        '
        Me.btn_EXIT.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_EXIT.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EXIT.ForeColor = System.Drawing.Color.White
        Me.btn_EXIT.Image = CType(resources.GetObject("btn_EXIT.Image"), System.Drawing.Image)
        Me.btn_EXIT.Location = New System.Drawing.Point(814, 489)
        Me.btn_EXIT.Name = "btn_EXIT"
        Me.btn_EXIT.Size = New System.Drawing.Size(110, 46)
        Me.btn_EXIT.TabIndex = 0
        Me.btn_EXIT.Text = "EXIT"
        Me.btn_EXIT.UseVisualStyleBackColor = False
        '
        'Payment_Confirmation_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(973, 590)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.lblTitleBar)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.lblPostCode)
        Me.Controls.Add(Me.txtlblTownOrCity)
        Me.Controls.Add(Me.lblTownOrCity)
        Me.Controls.Add(Me.txtStreetName)
        Me.Controls.Add(Me.lblstreetName)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtHouseNumber)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblhousenumber)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btn_EXIT)
        Me.Controls.Add(Me.btnSubmit)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Payment_Confirmation_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Information_Form"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblhousenumber As Label
    Friend WithEvents txtHouseNumber As TextBox
    Friend WithEvents lblstreetName As Label
    Friend WithEvents txtStreetName As TextBox
    Friend WithEvents lblTownOrCity As Label
    Friend WithEvents txtlblTownOrCity As TextBox
    Friend WithEvents lblPostCode As Label
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblTitleBar As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents btn_EXIT As Button
End Class
