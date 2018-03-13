<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpleshScreenOfWonderful_Walks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpleshScreenOfWonderful_Walks))
        Me.tmr_1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCmpnyName = New System.Windows.Forms.Label()
        Me.lblScottishHighlands = New System.Windows.Forms.Label()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.lblDvlpr = New System.Windows.Forms.Label()
        Me.ProgBar = New CircularProgressBar.CircularProgressBar()
        Me.lbl_Percentage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmr_1
        '
        Me.tmr_1.Interval = 50
        '
        'lblCmpnyName
        '
        Me.lblCmpnyName.BackColor = System.Drawing.Color.Transparent
        Me.lblCmpnyName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 60.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmpnyName.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblCmpnyName.Location = New System.Drawing.Point(48, 20)
        Me.lblCmpnyName.Name = "lblCmpnyName"
        Me.lblCmpnyName.Size = New System.Drawing.Size(734, 102)
        Me.lblCmpnyName.TabIndex = 2
        Me.lblCmpnyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScottishHighlands
        '
        Me.lblScottishHighlands.BackColor = System.Drawing.Color.Transparent
        Me.lblScottishHighlands.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScottishHighlands.ForeColor = System.Drawing.Color.Honeydew
        Me.lblScottishHighlands.Location = New System.Drawing.Point(167, 139)
        Me.lblScottishHighlands.Name = "lblScottishHighlands"
        Me.lblScottishHighlands.Size = New System.Drawing.Size(356, 53)
        Me.lblScottishHighlands.TabIndex = 3
        Me.lblScottishHighlands.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.BackColor = System.Drawing.Color.Transparent
        Me.lblDeveloper.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeveloper.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDeveloper.Location = New System.Drawing.Point(448, 450)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(0, 25)
        Me.lblDeveloper.TabIndex = 4
        '
        'lblDvlpr
        '
        Me.lblDvlpr.BackColor = System.Drawing.Color.Transparent
        Me.lblDvlpr.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDvlpr.ForeColor = System.Drawing.Color.Silver
        Me.lblDvlpr.Location = New System.Drawing.Point(275, 433)
        Me.lblDvlpr.Name = "lblDvlpr"
        Me.lblDvlpr.Size = New System.Drawing.Size(384, 23)
        Me.lblDvlpr.TabIndex = 1
        Me.lblDvlpr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgBar
        '
        Me.ProgBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.ProgBar.AnimationSpeed = 1000
        Me.ProgBar.BackColor = System.Drawing.Color.Transparent
        Me.ProgBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.ProgBar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProgBar.InnerColor = System.Drawing.Color.Transparent
        Me.ProgBar.InnerMargin = 5
        Me.ProgBar.InnerWidth = -1
        Me.ProgBar.Location = New System.Drawing.Point(421, 341)
        Me.ProgBar.MarqueeAnimationSpeed = 2000
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.OuterColor = System.Drawing.Color.WhiteSmoke
        Me.ProgBar.OuterMargin = -10
        Me.ProgBar.OuterWidth = 10
        Me.ProgBar.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.ProgBar.ProgressWidth = 8
        Me.ProgBar.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.ProgBar.Size = New System.Drawing.Size(102, 89)
        Me.ProgBar.StartAngle = 1000
        Me.ProgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgBar.SubscriptColor = System.Drawing.Color.White
        Me.ProgBar.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.ProgBar.SubscriptText = ".23"
        Me.ProgBar.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgBar.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.ProgBar.SuperscriptText = "%"
        Me.ProgBar.TabIndex = 5
        Me.ProgBar.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.ProgBar.Value = 5
        '
        'lbl_Percentage
        '
        Me.lbl_Percentage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Percentage.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentage.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_Percentage.Location = New System.Drawing.Point(449, 370)
        Me.lbl_Percentage.Name = "lbl_Percentage"
        Me.lbl_Percentage.Size = New System.Drawing.Size(46, 32)
        Me.lbl_Percentage.TabIndex = 6
        Me.lbl_Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpleshScreenOfWonderful_Walks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(901, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Percentage)
        Me.Controls.Add(Me.lblDeveloper)
        Me.Controls.Add(Me.lblScottishHighlands)
        Me.Controls.Add(Me.lblCmpnyName)
        Me.Controls.Add(Me.lblDvlpr)
        Me.Controls.Add(Me.ProgBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SpleshScreenOfWonderful_Walks"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpleshPageOfWonderful_Walks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr_1 As Timer
    Friend WithEvents lblCmpnyName As Label
    Friend WithEvents lblScottishHighlands As Label
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents lblDvlpr As Label
    Friend WithEvents ProgBar As CircularProgressBar.CircularProgressBar
    Friend WithEvents lbl_Percentage As Label
End Class
