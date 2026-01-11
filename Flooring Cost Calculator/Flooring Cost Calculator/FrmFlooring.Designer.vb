<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlooring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlooring))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSquareFeet = New System.Windows.Forms.Label()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.grpFloorType = New System.Windows.Forms.GroupBox()
        Me.RadTile = New System.Windows.Forms.RadioButton()
        Me.RadCarpet = New System.Windows.Forms.RadioButton()
        Me.RadHardwood = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picFlooring = New System.Windows.Forms.PictureBox()
        Me.grpFloorType.SuspendLayout()
        CType(Me.picFlooring, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(58, 25)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(288, 32)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Flooring Cost Calculator"
        '
        'lblSquareFeet
        '
        Me.lblSquareFeet.AutoSize = True
        Me.lblSquareFeet.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquareFeet.Location = New System.Drawing.Point(100, 77)
        Me.lblSquareFeet.Name = "lblSquareFeet"
        Me.lblSquareFeet.Size = New System.Drawing.Size(149, 25)
        Me.lblSquareFeet.TabIndex = 1
        Me.lblSquareFeet.Text = "Square Footage:"
        '
        'txtFootage
        '
        Me.txtFootage.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFootage.Location = New System.Drawing.Point(255, 77)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(65, 30)
        Me.txtFootage.TabIndex = 2
        Me.txtFootage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpFloorType
        '
        Me.grpFloorType.BackColor = System.Drawing.Color.White
        Me.grpFloorType.Controls.Add(Me.RadHardwood)
        Me.grpFloorType.Controls.Add(Me.RadCarpet)
        Me.grpFloorType.Controls.Add(Me.RadTile)
        Me.grpFloorType.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFloorType.Location = New System.Drawing.Point(115, 132)
        Me.grpFloorType.Name = "grpFloorType"
        Me.grpFloorType.Size = New System.Drawing.Size(175, 105)
        Me.grpFloorType.TabIndex = 3
        Me.grpFloorType.TabStop = False
        Me.grpFloorType.Text = "Flooring Type"
        '
        'RadTile
        '
        Me.RadTile.AutoSize = True
        Me.RadTile.Checked = True
        Me.RadTile.Location = New System.Drawing.Point(6, 20)
        Me.RadTile.Name = "RadTile"
        Me.RadTile.Size = New System.Drawing.Size(58, 27)
        Me.RadTile.TabIndex = 0
        Me.RadTile.TabStop = True
        Me.RadTile.Text = "Tile"
        Me.RadTile.UseVisualStyleBackColor = True
        '
        'RadCarpet
        '
        Me.RadCarpet.AutoSize = True
        Me.RadCarpet.Location = New System.Drawing.Point(6, 45)
        Me.RadCarpet.Name = "RadCarpet"
        Me.RadCarpet.Size = New System.Drawing.Size(80, 27)
        Me.RadCarpet.TabIndex = 1
        Me.RadCarpet.Text = "Carpet"
        Me.RadCarpet.UseVisualStyleBackColor = True
        '
        'RadHardwood
        '
        Me.RadHardwood.AutoSize = True
        Me.RadHardwood.Location = New System.Drawing.Point(6, 72)
        Me.RadHardwood.Name = "RadHardwood"
        Me.RadHardwood.Size = New System.Drawing.Size(110, 27)
        Me.RadHardwood.TabIndex = 2
        Me.RadHardwood.Text = "Hardwood"
        Me.RadHardwood.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(84, 266)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(136, 25)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost Estimate:"
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostEstimate.Location = New System.Drawing.Point(226, 266)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(94, 25)
        Me.lblCostEstimate.TabIndex = 5
        Me.lblCostEstimate.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.White
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(64, 318)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 30)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(230, 318)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 30)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'picFlooring
        '
        Me.picFlooring.Image = CType(resources.GetObject("picFlooring.Image"), System.Drawing.Image)
        Me.picFlooring.Location = New System.Drawing.Point(2, 371)
        Me.picFlooring.Name = "picFlooring"
        Me.picFlooring.Size = New System.Drawing.Size(400, 150)
        Me.picFlooring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlooring.TabIndex = 8
        Me.picFlooring.TabStop = False
        '
        'frmFlooring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(404, 521)
        Me.Controls.Add(Me.picFlooring)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpFloorType)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.lblSquareFeet)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmFlooring"
        Me.Text = "Flooring Cost"
        Me.grpFloorType.ResumeLayout(False)
        Me.grpFloorType.PerformLayout()
        CType(Me.picFlooring, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSquareFeet As Label
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents grpFloorType As GroupBox
    Friend WithEvents RadHardwood As RadioButton
    Friend WithEvents RadCarpet As RadioButton
    Friend WithEvents RadTile As RadioButton
    Friend WithEvents lblCost As Label
    Friend WithEvents lblCostEstimate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents picFlooring As PictureBox
End Class
