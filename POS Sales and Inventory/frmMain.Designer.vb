<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tlLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnNewOrder = New CloudToolkitN6.CloudButton()
        Me.btnNewPurchase = New CloudToolkitN6.CloudButton()
        Me.lblTodaysOrders = New CloudToolkitN6.CloudLabel()
        Me.lblInventoryToReorder = New CloudToolkitN6.CloudLabel()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TargetLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordpadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloudDigitalClock1 = New CloudToolkitN6.CloudDigitalClock()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OrdersBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_inventoryDataSet1 = New POS_Sales_and_Inventory.product_inventoryDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.InventoryToReorderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetailsTableAdapter = New POS_Sales_and_Inventory.product_inventoryDataSetTableAdapters.OrderDetailsTableAdapter()
        Me.OrdersBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_inventoryDataSet = New POS_Sales_and_Inventory.product_inventoryDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New POS_Sales_and_Inventory.product_inventoryDataSetTableAdapters.OrdersTableAdapter()
        Me.InventoryToReorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryToReorderTableAdapter = New POS_Sales_and_Inventory.product_inventoryDataSetTableAdapters.InventoryToReorderTableAdapter()
        Me.OrdersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_inventoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryToReorderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryToReorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlLabel, Me.tlName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 926)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(989, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tlLabel
        '
        Me.tlLabel.Name = "tlLabel"
        Me.tlLabel.Size = New System.Drawing.Size(77, 17)
        Me.tlLabel.Text = "Logged in as:"
        '
        'tlName
        '
        Me.tlName.Name = "tlName"
        Me.tlName.Size = New System.Drawing.Size(0, 17)
        '
        'btnNewOrder
        '
        Me.btnNewOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnNewOrder.ButtonText = "New Order"
        Me.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewOrder.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.btnNewOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnNewOrder.Icon = Nothing
        Me.btnNewOrder.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.btnNewOrder.IconSpacingX = 5
        Me.btnNewOrder.IconSpacingY = 5
        Me.btnNewOrder.IconTransparency = 0!
        Me.btnNewOrder.Location = New System.Drawing.Point(14, 104)
        Me.btnNewOrder.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.btnNewOrder.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.btnNewOrder.Size = New System.Drawing.Size(101, 35)
        Me.btnNewOrder.TabIndex = 0
        Me.btnNewOrder.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.btnNewOrder.TextSpacingX = 5
        Me.btnNewOrder.TextSpacingY = 5
        '
        'btnNewPurchase
        '
        Me.btnNewPurchase.BackColor = System.Drawing.Color.Transparent
        Me.btnNewPurchase.ButtonText = "New Product"
        Me.btnNewPurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewPurchase.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.btnNewPurchase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnNewPurchase.Icon = Nothing
        Me.btnNewPurchase.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.btnNewPurchase.IconSpacingX = 5
        Me.btnNewPurchase.IconSpacingY = 5
        Me.btnNewPurchase.IconTransparency = 0!
        Me.btnNewPurchase.Location = New System.Drawing.Point(426, 104)
        Me.btnNewPurchase.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.btnNewPurchase.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.btnNewPurchase.Name = "btnNewPurchase"
        Me.btnNewPurchase.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.btnNewPurchase.Size = New System.Drawing.Size(103, 35)
        Me.btnNewPurchase.TabIndex = 1
        Me.btnNewPurchase.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.btnNewPurchase.TextSpacingX = 5
        Me.btnNewPurchase.TextSpacingY = 5
        '
        'lblTodaysOrders
        '
        Me.lblTodaysOrders.AutoSize = True
        Me.lblTodaysOrders.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTodaysOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblTodaysOrders.Location = New System.Drawing.Point(12, 155)
        Me.lblTodaysOrders.Name = "lblTodaysOrders"
        Me.lblTodaysOrders.Size = New System.Drawing.Size(76, 13)
        Me.lblTodaysOrders.TabIndex = 2
        Me.lblTodaysOrders.Text = "Todays Orders"
        '
        'lblInventoryToReorder
        '
        Me.lblInventoryToReorder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInventoryToReorder.AutoSize = True
        Me.lblInventoryToReorder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblInventoryToReorder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblInventoryToReorder.Location = New System.Drawing.Point(12, 438)
        Me.lblInventoryToReorder.Name = "lblInventoryToReorder"
        Me.lblInventoryToReorder.Size = New System.Drawing.Size(108, 13)
        Me.lblInventoryToReorder.TabIndex = 5
        Me.lblInventoryToReorder.Text = "Inventory To Reorder"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReorderLevelDataGridViewTextBoxColumn
        '
        Me.ReorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel"
        Me.ReorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel"
        Me.ReorderLevelDataGridViewTextBoxColumn.Name = "ReorderLevelDataGridViewTextBoxColumn"
        Me.ReorderLevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TargetLevelDataGridViewTextBoxColumn
        '
        Me.TargetLevelDataGridViewTextBoxColumn.DataPropertyName = "TargetLevel"
        Me.TargetLevelDataGridViewTextBoxColumn.HeaderText = "TargetLevel"
        Me.TargetLevelDataGridViewTextBoxColumn.Name = "TargetLevelDataGridViewTextBoxColumn"
        Me.TargetLevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReorderQuantityDataGridViewTextBoxColumn
        '
        Me.ReorderQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReorderQuantity"
        Me.ReorderQuantityDataGridViewTextBoxColumn.HeaderText = "ReorderQuantity"
        Me.ReorderQuantityDataGridViewTextBoxColumn.Name = "ReorderQuantityDataGridViewTextBoxColumn"
        Me.ReorderQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.PurchasesToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ManageToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(989, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'PurchasesToolStripMenuItem
        '
        Me.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem"
        Me.PurchasesToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.PurchasesToolStripMenuItem.Text = "Purchases"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesToolStripMenuItem, Me.LoginDetailsToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ManageToolStripMenuItem.Text = "Employees"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmployeesToolStripMenuItem.Text = "Registration"
        '
        'LoginDetailsToolStripMenuItem
        '
        Me.LoginDetailsToolStripMenuItem.Name = "LoginDetailsToolStripMenuItem"
        Me.LoginDetailsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginDetailsToolStripMenuItem.Text = "Login Details"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.NotepadToolStripMenuItem, Me.TaskManagerToolStripMenuItem, Me.MSWordToolStripMenuItem, Me.SystemInfoToolStripMenuItem, Me.WordpadToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Image = CType(resources.GetObject("CalculatorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Image = CType(resources.GetObject("NotepadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Image = CType(resources.GetObject("TaskManagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'MSWordToolStripMenuItem
        '
        Me.MSWordToolStripMenuItem.Image = CType(resources.GetObject("MSWordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MSWordToolStripMenuItem.Name = "MSWordToolStripMenuItem"
        Me.MSWordToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MSWordToolStripMenuItem.Text = "MS Word"
        '
        'SystemInfoToolStripMenuItem
        '
        Me.SystemInfoToolStripMenuItem.Image = CType(resources.GetObject("SystemInfoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SystemInfoToolStripMenuItem.Name = "SystemInfoToolStripMenuItem"
        Me.SystemInfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SystemInfoToolStripMenuItem.Text = "System Info"
        '
        'WordpadToolStripMenuItem
        '
        Me.WordpadToolStripMenuItem.Image = CType(resources.GetObject("WordpadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WordpadToolStripMenuItem.Name = "WordpadToolStripMenuItem"
        Me.WordpadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WordpadToolStripMenuItem.Text = "Wordpad"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.SupplierToolStripMenuItem1, Me.ProductToolStripMenuItem, Me.StockToolStripMenuItem2, Me.OrderToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(989, 77)
        Me.MenuStrip2.TabIndex = 4
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerToolStripMenuItem.Image = CType(resources.GetObject("CustomerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CustomerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(102, 73)
        Me.CustomerToolStripMenuItem.Text = "Customers"
        Me.CustomerToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SupplierToolStripMenuItem1
        '
        Me.SupplierToolStripMenuItem1.Image = Global.POS_Sales_and_Inventory.My.Resources.Resources.packages1
        Me.SupplierToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SupplierToolStripMenuItem1.Name = "SupplierToolStripMenuItem1"
        Me.SupplierToolStripMenuItem1.Size = New System.Drawing.Size(117, 73)
        Me.SupplierToolStripMenuItem1.Text = "Suppliers"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductToolStripMenuItem.Image = CType(resources.GetObject("ProductToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(86, 73)
        Me.ProductToolStripMenuItem.Text = "Products"
        Me.ProductToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StockToolStripMenuItem2
        '
        Me.StockToolStripMenuItem2.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StockToolStripMenuItem2.Name = "StockToolStripMenuItem2"
        Me.StockToolStripMenuItem2.Size = New System.Drawing.Size(62, 73)
        Me.StockToolStripMenuItem2.Text = "Stock"
        Me.StockToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderToolStripMenuItem.Image = CType(resources.GetObject("OrderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OrderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(73, 73)
        Me.OrderToolStripMenuItem.Text = "Orders"
        Me.OrderToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceToolStripMenuItem.Image = CType(resources.GetObject("InvoiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InvoiceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(81, 73)
        Me.InvoiceToolStripMenuItem.Text = "Invoices"
        Me.InvoiceToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(70, 73)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CloudDigitalClock1
        '
        Me.CloudDigitalClock1.BackColor = System.Drawing.Color.Transparent
        Me.CloudDigitalClock1.ColorLower_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.CloudDigitalClock1.ColorLower_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CloudDigitalClock1.ColorUpper_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.CloudDigitalClock1.ColorUpper_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CloudDigitalClock1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloudDigitalClock1.DateColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.DateFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CloudDigitalClock1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloudDigitalClock1.DrawDate = True
        Me.CloudDigitalClock1.Location = New System.Drawing.Point(0, 831)
        Me.CloudDigitalClock1.Name = "CloudDigitalClock1"
        Me.CloudDigitalClock1.NumberColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.NumberFont = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CloudDigitalClock1.Size = New System.Drawing.Size(989, 95)
        Me.CloudDigitalClock1.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(974, 230)
        Me.DataGridView1.TabIndex = 8
        '
        'OrdersBindingSource4
        '
        Me.OrdersBindingSource4.DataMember = "Orders"
        Me.OrdersBindingSource4.DataSource = Me.Product_inventoryDataSet1
        '
        'Product_inventoryDataSet1
        '
        Me.Product_inventoryDataSet1.DataSetName = "product_inventoryDataSet"
        Me.Product_inventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(15, 468)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(974, 281)
        Me.DataGridView2.TabIndex = 9
        '
        'InventoryToReorderBindingSource1
        '
        Me.InventoryToReorderBindingSource1.DataMember = "InventoryToReorder"
        Me.InventoryToReorderBindingSource1.DataSource = Me.Product_inventoryDataSet1
        '
        'OrderDetailsTableAdapter
        '
        Me.OrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'OrdersBindingSource3
        '
        Me.OrdersBindingSource3.DataMember = "Orders"
        Me.OrdersBindingSource3.DataSource = Me.Product_inventoryDataSet
        '
        'Product_inventoryDataSet
        '
        Me.Product_inventoryDataSet.DataSetName = "product_inventoryDataSet"
        Me.Product_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.Product_inventoryDataSet
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'InventoryToReorderBindingSource
        '
        Me.InventoryToReorderBindingSource.DataMember = "InventoryToReorder"
        Me.InventoryToReorderBindingSource.DataSource = Me.Product_inventoryDataSet
        '
        'InventoryToReorderTableAdapter
        '
        Me.InventoryToReorderTableAdapter.ClearBeforeFill = True
        '
        'OrdersBindingSource2
        '
        Me.OrdersBindingSource2.DataMember = "Orders"
        Me.OrdersBindingSource2.DataSource = Me.Product_inventoryDataSet
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 948)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CloudDigitalClock1)
        Me.Controls.Add(Me.lblInventoryToReorder)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblTodaysOrders)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnNewPurchase)
        Me.Controls.Add(Me.btnNewOrder)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Main Window"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_inventoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryToReorderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryToReorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tlLabel As ToolStripStatusLabel
    Friend WithEvents tlName As ToolStripStatusLabel
    Friend WithEvents lblInventoryToReorder As CloudToolkitN6.CloudLabel
    Friend WithEvents lblTodaysOrders As CloudToolkitN6.CloudLabel
    Friend WithEvents btnNewPurchase As CloudToolkitN6.CloudButton
    Friend WithEvents btnNewOrder As CloudToolkitN6.CloudButton
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReorderLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TargetLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReorderQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderDetailsTableAdapter As product_inventoryDataSetTableAdapters.OrderDetailsTableAdapter
    Friend WithEvents OrdersBindingSource1 As BindingSource
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloudDigitalClock1 As CloudToolkitN6.CloudDigitalClock
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Product_inventoryDataSet As product_inventoryDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As product_inventoryDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents InventoryToReorderBindingSource As BindingSource
    Friend WithEvents InventoryToReorderTableAdapter As product_inventoryDataSetTableAdapters.InventoryToReorderTableAdapter
    Friend WithEvents OrdersBindingSource2 As BindingSource
    Friend WithEvents OrdersBindingSource3 As BindingSource
    Friend WithEvents Product_inventoryDataSet1 As product_inventoryDataSet
    Friend WithEvents OrdersBindingSource4 As BindingSource
    Friend WithEvents InventoryToReorderBindingSource1 As BindingSource
    Friend WithEvents SupplierToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MSWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordpadToolStripMenuItem As ToolStripMenuItem
End Class
