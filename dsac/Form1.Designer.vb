<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SlNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmDtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidDtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GentsGymBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsacdataDataSet1 = New dsac.dsacdataDataSet()
        Me.DsacdataDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager1 = New dsac.dsacdataDataSetTableAdapters.TableAdapterManager()
        Me.GentsGymTableAdapter1 = New dsac.dsacdataDataSetTableAdapters.GentsGymTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GentsGymBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsacdataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsacdataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SlNoDataGridViewTextBoxColumn, Me.MnoDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.AddrDataGridViewTextBoxColumn, Me.GnameDataGridViewTextBoxColumn, Me.MobNoDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AdmDtDataGridViewTextBoxColumn, Me.ValidDtDataGridViewTextBoxColumn, Me.BnoDataGridViewTextBoxColumn, Me.AmtDataGridViewTextBoxColumn, Me.PhotoDataGridViewTextBoxColumn, Me.RemksDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GentsGymBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(437, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(864, 494)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.SearchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1301, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 23)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sl No. "
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.dsac.My.MySettings.Default, "slnovgg", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NumericUpDown1.Location = New System.Drawing.Point(218, 37)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(213, 23)
        Me.NumericUpDown1.TabIndex = 3
        Me.NumericUpDown1.Value = Global.dsac.My.MySettings.Default.slnovgg
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Member No. "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(218, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 23)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(218, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(213, 23)
        Me.TextBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Member Name "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(218, 115)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(213, 55)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(218, 173)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(213, 23)
        Me.TextBox4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Guardian / Father Name"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(218, 199)
        Me.TextBox5.MaxLength = 10
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(213, 23)
        Me.TextBox5.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Mobile No. "
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(218, 225)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(213, 23)
        Me.NumericUpDown2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Age"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Admission Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(218, 251)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(213, 23)
        Me.DateTimePicker1.TabIndex = 5
        Me.DateTimePicker1.Value = New Date(2022, 5, 11, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(218, 277)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(213, 23)
        Me.DateTimePicker2.TabIndex = 5
        Me.DateTimePicker2.Value = New Date(2022, 5, 11, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(150, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Valid Date"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(218, 303)
        Me.TextBox6.MaxLength = 4
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(213, 23)
        Me.TextBox6.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(164, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Bill No."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(158, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Amount"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(235, 329)
        Me.TextBox7.MaxLength = 55
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(196, 23)
        Me.TextBox7.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(215, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Rs. "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(171, 359)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Photo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Choose Photo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image Files|*.jpg|*.png|*.asf|*.bmp|*gif"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(164, 384)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Remarks"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(218, 381)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(213, 55)
        Me.TextBox8.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(13, 454)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(101, 454)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 34)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(189, 454)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(242, 34)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Delete Selected Row"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 496)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 15)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "© 2022"
        '
        'SlNoDataGridViewTextBoxColumn
        '
        Me.SlNoDataGridViewTextBoxColumn.DataPropertyName = "SlNo"
        Me.SlNoDataGridViewTextBoxColumn.HeaderText = "Sl No."
        Me.SlNoDataGridViewTextBoxColumn.Name = "SlNoDataGridViewTextBoxColumn"
        '
        'MnoDataGridViewTextBoxColumn
        '
        Me.MnoDataGridViewTextBoxColumn.DataPropertyName = "Mno"
        Me.MnoDataGridViewTextBoxColumn.HeaderText = "Member No."
        Me.MnoDataGridViewTextBoxColumn.Name = "MnoDataGridViewTextBoxColumn"
        '
        'MnameDataGridViewTextBoxColumn
        '
        Me.MnameDataGridViewTextBoxColumn.DataPropertyName = "Mname"
        Me.MnameDataGridViewTextBoxColumn.HeaderText = "Member Name"
        Me.MnameDataGridViewTextBoxColumn.Name = "MnameDataGridViewTextBoxColumn"
        '
        'AddrDataGridViewTextBoxColumn
        '
        Me.AddrDataGridViewTextBoxColumn.DataPropertyName = "Addr"
        Me.AddrDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddrDataGridViewTextBoxColumn.Name = "AddrDataGridViewTextBoxColumn"
        '
        'GnameDataGridViewTextBoxColumn
        '
        Me.GnameDataGridViewTextBoxColumn.DataPropertyName = "Gname"
        Me.GnameDataGridViewTextBoxColumn.HeaderText = "Guardian / Father Name"
        Me.GnameDataGridViewTextBoxColumn.Name = "GnameDataGridViewTextBoxColumn"
        '
        'MobNoDataGridViewTextBoxColumn
        '
        Me.MobNoDataGridViewTextBoxColumn.DataPropertyName = "MobNo"
        Me.MobNoDataGridViewTextBoxColumn.HeaderText = "Mobile No."
        Me.MobNoDataGridViewTextBoxColumn.Name = "MobNoDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'AdmDtDataGridViewTextBoxColumn
        '
        Me.AdmDtDataGridViewTextBoxColumn.DataPropertyName = "AdmDt"
        Me.AdmDtDataGridViewTextBoxColumn.HeaderText = "Admission Date"
        Me.AdmDtDataGridViewTextBoxColumn.Name = "AdmDtDataGridViewTextBoxColumn"
        '
        'ValidDtDataGridViewTextBoxColumn
        '
        Me.ValidDtDataGridViewTextBoxColumn.DataPropertyName = "ValidDt"
        Me.ValidDtDataGridViewTextBoxColumn.HeaderText = "Valid Date"
        Me.ValidDtDataGridViewTextBoxColumn.Name = "ValidDtDataGridViewTextBoxColumn"
        '
        'BnoDataGridViewTextBoxColumn
        '
        Me.BnoDataGridViewTextBoxColumn.DataPropertyName = "Bno"
        Me.BnoDataGridViewTextBoxColumn.HeaderText = "Bill No."
        Me.BnoDataGridViewTextBoxColumn.MaxInputLength = 4
        Me.BnoDataGridViewTextBoxColumn.Name = "BnoDataGridViewTextBoxColumn"
        '
        'AmtDataGridViewTextBoxColumn
        '
        Me.AmtDataGridViewTextBoxColumn.DataPropertyName = "Amt"
        Me.AmtDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmtDataGridViewTextBoxColumn.Name = "AmtDataGridViewTextBoxColumn"
        '
        'PhotoDataGridViewTextBoxColumn
        '
        Me.PhotoDataGridViewTextBoxColumn.DataPropertyName = "Photo"
        Me.PhotoDataGridViewTextBoxColumn.HeaderText = "Photo"
        Me.PhotoDataGridViewTextBoxColumn.Name = "PhotoDataGridViewTextBoxColumn"
        '
        'RemksDataGridViewTextBoxColumn
        '
        Me.RemksDataGridViewTextBoxColumn.DataPropertyName = "Remks"
        Me.RemksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemksDataGridViewTextBoxColumn.Name = "RemksDataGridViewTextBoxColumn"
        '
        'GentsGymBindingSource
        '
        Me.GentsGymBindingSource.DataMember = "GentsGym"
        Me.GentsGymBindingSource.DataSource = Me.DsacdataDataSet1
        '
        'DsacdataDataSet1
        '
        Me.DsacdataDataSet1.DataSetName = "dsacdataDataSet"
        Me.DsacdataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsacdataDataSet1BindingSource
        '
        Me.DsacdataDataSet1BindingSource.DataSource = Me.DsacdataDataSet1
        Me.DsacdataDataSet1BindingSource.Position = 0
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.GentsGymTableAdapter = Me.GentsGymTableAdapter1
        Me.TableAdapterManager1.LadiesGymTableAdapter = Nothing
        Me.TableAdapterManager1.SwimmingTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = dsac.dsacdataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GentsGymTableAdapter1
        '
        Me.GentsGymTableAdapter1.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(405, 355)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 23)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 521)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deshbandhu Swimming & Athletic Club : Gym Section (Gents)"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GentsGymBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsacdataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsacdataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsacdataDataSet1BindingSource As BindingSource
    Friend WithEvents DsacdataDataSet1 As dsacdataDataSet
    Friend WithEvents TableAdapterManager1 As dsacdataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GentsGymTableAdapter1 As dsacdataDataSetTableAdapters.GentsGymTableAdapter
    Friend WithEvents GentsGymBindingSource As BindingSource
    Friend WithEvents RemksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValidDtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdmDtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SlNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
