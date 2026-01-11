<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscape
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEscape))
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lstGame = New System.Windows.Forms.ListBox()
        Me.btnFindCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblGameType = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCity
        '
        Me.cboCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Items.AddRange(New Object() {"Dallas", "Paris", "Singapore"})
        Me.cboCity.Location = New System.Drawing.Point(130, 82)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(196, 32)
        Me.cboCity.TabIndex = 0
        Me.cboCity.Text = "Select City Location:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Sienna
        Me.lblHeading.Location = New System.Drawing.Point(8, 31)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(442, 32)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Mystery Escape Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblLength)
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.lblGameType)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnFindCost)
        Me.Panel1.Controls.Add(Me.lstGame)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Controls.Add(Me.txtTeam)
        Me.Panel1.Controls.Add(Me.lblTeam)
        Me.Panel1.Controls.Add(Me.lblHeading)
        Me.Panel1.Controls.Add(Me.cboCity)
        Me.Panel1.Location = New System.Drawing.Point(400, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 453)
        Me.Panel1.TabIndex = 3
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(113, 142)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(176, 25)
        Me.lblTeam.TabIndex = 3
        Me.lblTeam.Text = "Number in Team:"
        Me.lblTeam.Visible = False
        '
        'txtTeam
        '
        Me.txtTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeam.Location = New System.Drawing.Point(309, 136)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(33, 31)
        Me.txtTeam.TabIndex = 4
        Me.txtTeam.Text = "88"
        Me.txtTeam.Visible = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(142, 192)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(171, 24)
        Me.lblSelect.TabIndex = 5
        Me.lblSelect.Text = "Select Game Type:"
        Me.lblSelect.Visible = False
        '
        'lstGame
        '
        Me.lstGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGame.FormattingEnabled = True
        Me.lstGame.ItemHeight = 24
        Me.lstGame.Location = New System.Drawing.Point(146, 228)
        Me.lstGame.Name = "lstGame"
        Me.lstGame.Size = New System.Drawing.Size(167, 76)
        Me.lstGame.TabIndex = 6
        Me.lstGame.Visible = False
        '
        'btnFindCost
        '
        Me.btnFindCost.BackColor = System.Drawing.Color.Sienna
        Me.btnFindCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindCost.ForeColor = System.Drawing.Color.Khaki
        Me.btnFindCost.Location = New System.Drawing.Point(50, 320)
        Me.btnFindCost.Name = "btnFindCost"
        Me.btnFindCost.Size = New System.Drawing.Size(139, 29)
        Me.btnFindCost.TabIndex = 7
        Me.btnFindCost.Text = "Find Team Cost"
        Me.btnFindCost.UseVisualStyleBackColor = False
        Me.btnFindCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Sienna
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Khaki
        Me.btnClear.Location = New System.Drawing.Point(266, 320)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 29)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'lblGameType
        '
        Me.lblGameType.AutoSize = True
        Me.lblGameType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameType.Location = New System.Drawing.Point(133, 368)
        Me.lblGameType.Name = "lblGameType"
        Me.lblGameType.Size = New System.Drawing.Size(180, 25)
        Me.lblGameType.TabIndex = 9
        Me.lblGameType.Text = "XXXXXXXXXXXX"
        Me.lblGameType.Visible = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(133, 393)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(180, 25)
        Me.lblCost.TabIndex = 10
        Me.lblCost.Text = "XXXXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(133, 418)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(180, 25)
        Me.lblLength.TabIndex = 11
        Me.lblLength.Text = "XXXXXXXXXXXX"
        Me.lblLength.Visible = False
        '
        'frmEscape
        '
        Me.AcceptButton = Me.btnFindCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(854, 451)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmEscape"
        Me.Text = "Mystery Escape"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboCity As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTeam As Label
    Friend WithEvents lstGame As ListBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents lblLength As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblGameType As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFindCost As Button
End Class
