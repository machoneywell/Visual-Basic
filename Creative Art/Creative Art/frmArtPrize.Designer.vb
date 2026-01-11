<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArtPrize
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
        Dim Art_IDLabel As System.Windows.Forms.Label
        Dim Artist_NameLabel As System.Windows.Forms.Label
        Dim Art_TitleLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim CollectionLabel As System.Windows.Forms.Label
        Dim Retail_PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArtPrize))
        Me.picArt = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ArtDataSet = New Creative_Art.ArtDataSet()
        Me.ArtistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtistTableAdapter = New Creative_Art.ArtDataSetTableAdapters.ArtistTableAdapter()
        Me.TableAdapterManager = New Creative_Art.ArtDataSetTableAdapters.TableAdapterManager()
        Me.ArtistBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ArtistBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Art_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Art_TitleTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.CollectionTextBox = New System.Windows.Forms.TextBox()
        Me.Retail_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.ArtistTableAdapter1 = New Creative_Art.ArtDataSetTableAdapters.ArtistTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ArtistBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtistBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtistBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Art_IDLabel = New System.Windows.Forms.Label()
        Artist_NameLabel = New System.Windows.Forms.Label()
        Art_TitleLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        CollectionLabel = New System.Windows.Forms.Label()
        Retail_PriceLabel = New System.Windows.Forms.Label()
        CType(Me.picArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArtistBindingNavigator.SuspendLayout()
        CType(Me.ArtistBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Art_IDLabel
        '
        Art_IDLabel.AutoSize = True
        Art_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Art_IDLabel.Location = New System.Drawing.Point(110, 491)
        Art_IDLabel.Name = "Art_IDLabel"
        Art_IDLabel.Size = New System.Drawing.Size(99, 31)
        Art_IDLabel.TabIndex = 3
        Art_IDLabel.Text = "Art ID:"
        '
        'Artist_NameLabel
        '
        Artist_NameLabel.AutoSize = True
        Artist_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Artist_NameLabel.Location = New System.Drawing.Point(761, 494)
        Artist_NameLabel.Name = "Artist_NameLabel"
        Artist_NameLabel.Size = New System.Drawing.Size(176, 31)
        Artist_NameLabel.TabIndex = 5
        Artist_NameLabel.Text = "Artist Name:"
        '
        'Art_TitleLabel
        '
        Art_TitleLabel.AutoSize = True
        Art_TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Art_TitleLabel.Location = New System.Drawing.Point(110, 597)
        Art_TitleLabel.Name = "Art_TitleLabel"
        Art_TitleLabel.Size = New System.Drawing.Size(126, 31)
        Art_TitleLabel.TabIndex = 7
        Art_TitleLabel.Text = "Art Title:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(761, 594)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(134, 31)
        LocationLabel.TabIndex = 9
        LocationLabel.Text = "Location:"
        '
        'CollectionLabel
        '
        CollectionLabel.AutoSize = True
        CollectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CollectionLabel.Location = New System.Drawing.Point(110, 695)
        CollectionLabel.Name = "CollectionLabel"
        CollectionLabel.Size = New System.Drawing.Size(153, 31)
        CollectionLabel.TabIndex = 11
        CollectionLabel.Text = "Collection:"
        '
        'Retail_PriceLabel
        '
        Retail_PriceLabel.AutoSize = True
        Retail_PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Retail_PriceLabel.Location = New System.Drawing.Point(761, 688)
        Retail_PriceLabel.Name = "Retail_PriceLabel"
        Retail_PriceLabel.Size = New System.Drawing.Size(174, 31)
        Retail_PriceLabel.TabIndex = 13
        Retail_PriceLabel.Text = "Retail Price:"
        '
        'picArt
        '
        Me.picArt.Image = CType(resources.GetObject("picArt.Image"), System.Drawing.Image)
        Me.picArt.Location = New System.Drawing.Point(0, 42)
        Me.picArt.Name = "picArt"
        Me.picArt.Size = New System.Drawing.Size(631, 370)
        Me.picArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArt.TabIndex = 0
        Me.picArt.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Script MT Bold", 40.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblTitle.Location = New System.Drawing.Point(786, 100)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(450, 258)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Art Prize" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finalists"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ArtDataSet
        '
        Me.ArtDataSet.DataSetName = "ArtDataSet"
        Me.ArtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArtistBindingSource
        '
        Me.ArtistBindingSource.DataMember = "Artist"
        Me.ArtistBindingSource.DataSource = Me.ArtDataSet
        '
        'ArtistTableAdapter
        '
        Me.ArtistTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtistTableAdapter = Me.ArtistTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Creative_Art.ArtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArtistBindingNavigator
        '
        Me.ArtistBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ArtistBindingNavigator.BindingSource = Me.ArtistBindingSource
        Me.ArtistBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ArtistBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ArtistBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ArtistBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ArtistBindingNavigatorSaveItem})
        Me.ArtistBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ArtistBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ArtistBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ArtistBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ArtistBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ArtistBindingNavigator.Name = "ArtistBindingNavigator"
        Me.ArtistBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ArtistBindingNavigator.Size = New System.Drawing.Size(1375, 39)
        Me.ArtistBindingNavigator.TabIndex = 2
        Me.ArtistBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(71, 36)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 39)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ArtistBindingNavigatorSaveItem
        '
        Me.ArtistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ArtistBindingNavigatorSaveItem.Image = CType(resources.GetObject("ArtistBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ArtistBindingNavigatorSaveItem.Name = "ArtistBindingNavigatorSaveItem"
        Me.ArtistBindingNavigatorSaveItem.Size = New System.Drawing.Size(36, 36)
        Me.ArtistBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Art_IDTextBox
        '
        Me.Art_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Art ID", True))
        Me.Art_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Art_IDTextBox.Location = New System.Drawing.Point(283, 497)
        Me.Art_IDTextBox.Name = "Art_IDTextBox"
        Me.Art_IDTextBox.Size = New System.Drawing.Size(309, 38)
        Me.Art_IDTextBox.TabIndex = 4
        '
        'Art_TitleTextBox
        '
        Me.Art_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Art Title", True))
        Me.Art_TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Art_TitleTextBox.Location = New System.Drawing.Point(283, 594)
        Me.Art_TitleTextBox.Name = "Art_TitleTextBox"
        Me.Art_TitleTextBox.Size = New System.Drawing.Size(309, 38)
        Me.Art_TitleTextBox.TabIndex = 8
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(962, 587)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(321, 38)
        Me.LocationTextBox.TabIndex = 10
        '
        'CollectionTextBox
        '
        Me.CollectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Collection", True))
        Me.CollectionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollectionTextBox.Location = New System.Drawing.Point(283, 692)
        Me.CollectionTextBox.Name = "CollectionTextBox"
        Me.CollectionTextBox.Size = New System.Drawing.Size(309, 38)
        Me.CollectionTextBox.TabIndex = 12
        '
        'Retail_PriceTextBox
        '
        Me.Retail_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Retail Price", True))
        Me.Retail_PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retail_PriceTextBox.Location = New System.Drawing.Point(962, 688)
        Me.Retail_PriceTextBox.Name = "Retail_PriceTextBox"
        Me.Retail_PriceTextBox.Size = New System.Drawing.Size(321, 38)
        Me.Retail_PriceTextBox.TabIndex = 14
        '
        'btnPrice
        '
        Me.btnPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrice.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrice.Location = New System.Drawing.Point(494, 792)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(401, 64)
        Me.btnPrice.TabIndex = 15
        Me.btnPrice.Text = "Total Retail Value"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(437, 914)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(500, 37)
        Me.lblTotalCost.TabIndex = 16
        Me.lblTotalCost.Text = "XXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblTotalCost.Visible = False
        '
        'ArtistTableAdapter1
        '
        Me.ArtistTableAdapter1.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ArtistBindingSource2
        Me.ComboBox1.DisplayMember = "Artist Name"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(962, 489)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(321, 39)
        Me.ComboBox1.TabIndex = 17
        '
        'ArtistBindingSource3
        '
        Me.ArtistBindingSource3.DataMember = "Artist"
        Me.ArtistBindingSource3.DataSource = Me.ArtDataSet
        '
        'ArtistBindingSource2
        '
        Me.ArtistBindingSource2.DataMember = "Artist"
        Me.ArtistBindingSource2.DataSource = Me.ArtDataSet
        '
        'ArtistBindingSource1
        '
        Me.ArtistBindingSource1.DataMember = "Artist"
        Me.ArtistBindingSource1.DataSource = Me.ArtDataSet
        '
        'frmArtPrize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1375, 993)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Retail_PriceLabel)
        Me.Controls.Add(Me.Retail_PriceTextBox)
        Me.Controls.Add(CollectionLabel)
        Me.Controls.Add(Me.CollectionTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Art_TitleLabel)
        Me.Controls.Add(Me.Art_TitleTextBox)
        Me.Controls.Add(Artist_NameLabel)
        Me.Controls.Add(Art_IDLabel)
        Me.Controls.Add(Me.Art_IDTextBox)
        Me.Controls.Add(Me.ArtistBindingNavigator)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picArt)
        Me.Name = "frmArtPrize"
        Me.Text = "Creative Art Commission - Art Prize Competition"
        CType(Me.picArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArtistBindingNavigator.ResumeLayout(False)
        Me.ArtistBindingNavigator.PerformLayout()
        CType(Me.ArtistBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picArt As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents ArtDataSet As ArtDataSet
    Friend WithEvents ArtistBindingSource As BindingSource
    Friend WithEvents ArtistTableAdapter As ArtDataSetTableAdapters.ArtistTableAdapter
    Friend WithEvents TableAdapterManager As ArtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArtistBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ArtistBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Art_IDTextBox As TextBox
    Friend WithEvents Art_TitleTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents CollectionTextBox As TextBox
    Friend WithEvents Retail_PriceTextBox As TextBox
    Friend WithEvents btnPrice As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents ArtistTableAdapter1 As ArtDataSetTableAdapters.ArtistTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ArtistBindingSource1 As BindingSource
    Friend WithEvents ArtistBindingSource3 As BindingSource
    Friend WithEvents ArtistBindingSource2 As BindingSource
End Class
