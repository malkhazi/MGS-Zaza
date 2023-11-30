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
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Bt_Save_pdf1 = New System.Windows.Forms.Button()
        Me.Chk_filis_chanacv = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.T_coment1 = New System.Windows.Forms.TextBox()
        Me.Cmb_instancia_add = New System.Windows.Forms.ComboBox()
        Me.Chk_dell_aft_move = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bt_Open_dir = New System.Windows.Forms.Button()
        Me.DTP_in = New System.Windows.Forms.DateTimePicker()
        Me.Bt_pdf2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bt_pdf1 = New System.Windows.Forms.Button()
        Me.T_addr_in = New System.Windows.Forms.TextBox()
        Me.Bt_Red = New System.Windows.Forms.Button()
        Me.Cmb_Stat_add = New System.Windows.Forms.ComboBox()
        Me.Bt_Add = New System.Windows.Forms.Button()
        Me.Bt_fnd1 = New System.Windows.Forms.Button()
        Me.Bt_fnd2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.T_addr_out = New System.Windows.Forms.TextBox()
        Me.DTP_out = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chk_dlt1 = New System.Windows.Forms.CheckBox()
        Me.Bt_Cham1 = New System.Windows.Forms.Button()
        Me.Chk_upas_cham = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Chk_dt_sab = New System.Windows.Forms.CheckBox()
        Me.Dtp_int_start = New System.Windows.Forms.DateTimePicker()
        Me.Chk_dt_sawk = New System.Windows.Forms.CheckBox()
        Me.Dtp_int_end = New System.Windows.Forms.DateTimePicker()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.bt_upd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_inst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coment1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stat1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dlt1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bt_Fltr_clear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_Stat_fl = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chk_date2 = New System.Windows.Forms.CheckBox()
        Me.Chk_date1 = New System.Windows.Forms.CheckBox()
        Me.Chk_Upasuxo = New System.Windows.Forms.CheckBox()
        Me.DTP_End_fl = New System.Windows.Forms.DateTimePicker()
        Me.DTP_start_fl = New System.Windows.Forms.DateTimePicker()
        Me.T_fltr1 = New System.Windows.Forms.TextBox()
        Me.Cmb_instancia_fl = New System.Windows.Forms.ComboBox()
        Me.T_ID = New System.Windows.Forms.TextBox()
        Me.T_file_out = New System.Windows.Forms.TextBox()
        Me.T_file_in = New System.Windows.Forms.TextBox()
        Me.BRW_01 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelchanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChanagdenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bt_Save_pdf2 = New System.Windows.Forms.Button()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(677, 514)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1096, 676)
        Me.SplitContainer1.SplitterDistance = 158
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Bt_Save_pdf2)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Bt_Save_pdf1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Chk_filis_chanacv)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer4.Panel1.Controls.Add(Me.T_coment1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Cmb_instancia_add)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Chk_dell_aft_move)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Bt_Open_dir)
        Me.SplitContainer4.Panel1.Controls.Add(Me.DTP_in)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Bt_pdf2)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Bt_pdf1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.T_addr_in)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Bt_Red)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Cmb_Stat_add)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Bt_Add)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Bt_fnd1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Bt_fnd2)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer4.Panel1.Controls.Add(Me.T_addr_out)
        Me.SplitContainer4.Panel1.Controls.Add(Me.DTP_out)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label6)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.SplitContainer4.Panel2.Controls.Add(Me.Chk_dlt1)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Bt_Cham1)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Chk_upas_cham)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Chk_dt_sab)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Dtp_int_start)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Chk_dt_sawk)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Dtp_int_end)
        Me.SplitContainer4.Size = New System.Drawing.Size(1096, 158)
        Me.SplitContainer4.SplitterDistance = 595
        Me.SplitContainer4.TabIndex = 33
        '
        'Bt_Save_pdf1
        '
        Me.Bt_Save_pdf1.BackgroundImage = Global.MGS_Zaza.My.Resources.Resources.drive_disk
        Me.Bt_Save_pdf1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Save_pdf1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Bt_Save_pdf1.Location = New System.Drawing.Point(559, 76)
        Me.Bt_Save_pdf1.Name = "Bt_Save_pdf1"
        Me.Bt_Save_pdf1.Size = New System.Drawing.Size(26, 23)
        Me.Bt_Save_pdf1.TabIndex = 30
        Me.Bt_Save_pdf1.UseVisualStyleBackColor = True
        '
        'Chk_filis_chanacv
        '
        Me.Chk_filis_chanacv.AutoSize = True
        Me.Chk_filis_chanacv.Location = New System.Drawing.Point(260, 3)
        Me.Chk_filis_chanacv.Name = "Chk_filis_chanacv"
        Me.Chk_filis_chanacv.Size = New System.Drawing.Size(198, 17)
        Me.Chk_filis_chanacv.TabIndex = 29
        Me.Chk_filis_chanacv.Text = "ჩავანაცვლო არსებული ფაილი"
        Me.Chk_filis_chanacv.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "კომენტარი"
        '
        'T_coment1
        '
        Me.T_coment1.Enabled = False
        Me.T_coment1.Location = New System.Drawing.Point(90, 25)
        Me.T_coment1.Name = "T_coment1"
        Me.T_coment1.Size = New System.Drawing.Size(463, 20)
        Me.T_coment1.TabIndex = 27
        '
        'Cmb_instancia_add
        '
        Me.Cmb_instancia_add.Enabled = False
        Me.Cmb_instancia_add.FormattingEnabled = True
        Me.Cmb_instancia_add.Location = New System.Drawing.Point(90, 51)
        Me.Cmb_instancia_add.Name = "Cmb_instancia_add"
        Me.Cmb_instancia_add.Size = New System.Drawing.Size(206, 21)
        Me.Cmb_instancia_add.TabIndex = 10
        '
        'Chk_dell_aft_move
        '
        Me.Chk_dell_aft_move.AutoSize = True
        Me.Chk_dell_aft_move.Location = New System.Drawing.Point(24, 3)
        Me.Chk_dell_aft_move.Name = "Chk_dell_aft_move"
        Me.Chk_dell_aft_move.Size = New System.Drawing.Size(223, 17)
        Me.Chk_dell_aft_move.TabIndex = 26
        Me.Chk_dell_aft_move.Text = "წავშალო ბაზაში დამატების შემდეგ"
        Me.Chk_dell_aft_move.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ინსტანცია"
        '
        'Bt_Open_dir
        '
        Me.Bt_Open_dir.BackgroundImage = Global.MGS_Zaza.My.Resources.Resources.folder
        Me.Bt_Open_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Open_dir.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Bt_Open_dir.Location = New System.Drawing.Point(527, 49)
        Me.Bt_Open_dir.Name = "Bt_Open_dir"
        Me.Bt_Open_dir.Size = New System.Drawing.Size(26, 23)
        Me.Bt_Open_dir.TabIndex = 25
        Me.Bt_Open_dir.UseVisualStyleBackColor = True
        '
        'DTP_in
        '
        Me.DTP_in.Enabled = False
        Me.DTP_in.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_in.Location = New System.Drawing.Point(90, 78)
        Me.DTP_in.Name = "DTP_in"
        Me.DTP_in.Size = New System.Drawing.Size(93, 20)
        Me.DTP_in.TabIndex = 12
        '
        'Bt_pdf2
        '
        Me.Bt_pdf2.BackgroundImage = Global.MGS_Zaza.My.Resources.Resources.pdficon_small_20
        Me.Bt_pdf2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_pdf2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Bt_pdf2.Location = New System.Drawing.Point(527, 102)
        Me.Bt_pdf2.Name = "Bt_pdf2"
        Me.Bt_pdf2.Size = New System.Drawing.Size(26, 23)
        Me.Bt_pdf2.TabIndex = 24
        Me.Bt_pdf2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "შემოსული"
        '
        'Bt_pdf1
        '
        Me.Bt_pdf1.BackgroundImage = Global.MGS_Zaza.My.Resources.Resources.pdficon_small_20
        Me.Bt_pdf1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_pdf1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Bt_pdf1.Location = New System.Drawing.Point(527, 76)
        Me.Bt_pdf1.Name = "Bt_pdf1"
        Me.Bt_pdf1.Size = New System.Drawing.Size(26, 23)
        Me.Bt_pdf1.TabIndex = 23
        Me.Bt_pdf1.UseVisualStyleBackColor = True
        '
        'T_addr_in
        '
        Me.T_addr_in.Enabled = False
        Me.T_addr_in.Location = New System.Drawing.Point(189, 78)
        Me.T_addr_in.Name = "T_addr_in"
        Me.T_addr_in.ReadOnly = True
        Me.T_addr_in.Size = New System.Drawing.Size(294, 20)
        Me.T_addr_in.TabIndex = 15
        '
        'Bt_Red
        '
        Me.Bt_Red.Location = New System.Drawing.Point(264, 130)
        Me.Bt_Red.Name = "Bt_Red"
        Me.Bt_Red.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Red.TabIndex = 22
        Me.Bt_Red.Text = "შეცვლა"
        Me.Bt_Red.UseVisualStyleBackColor = True
        '
        'Cmb_Stat_add
        '
        Me.Cmb_Stat_add.Enabled = False
        Me.Cmb_Stat_add.FormattingEnabled = True
        Me.Cmb_Stat_add.Location = New System.Drawing.Point(387, 51)
        Me.Cmb_Stat_add.Name = "Cmb_Stat_add"
        Me.Cmb_Stat_add.Size = New System.Drawing.Size(134, 21)
        Me.Cmb_Stat_add.TabIndex = 12
        '
        'Bt_Add
        '
        Me.Bt_Add.Location = New System.Drawing.Point(161, 130)
        Me.Bt_Add.Name = "Bt_Add"
        Me.Bt_Add.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Add.TabIndex = 21
        Me.Bt_Add.Text = "ახალი"
        Me.Bt_Add.UseVisualStyleBackColor = True
        '
        'Bt_fnd1
        '
        Me.Bt_fnd1.Enabled = False
        Me.Bt_fnd1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Bt_fnd1.Location = New System.Drawing.Point(489, 76)
        Me.Bt_fnd1.Name = "Bt_fnd1"
        Me.Bt_fnd1.Size = New System.Drawing.Size(32, 23)
        Me.Bt_fnd1.TabIndex = 16
        Me.Bt_fnd1.Text = "..."
        Me.Bt_fnd1.UseVisualStyleBackColor = True
        '
        'Bt_fnd2
        '
        Me.Bt_fnd2.Enabled = False
        Me.Bt_fnd2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Bt_fnd2.Location = New System.Drawing.Point(489, 102)
        Me.Bt_fnd2.Name = "Bt_fnd2"
        Me.Bt_fnd2.Size = New System.Drawing.Size(32, 23)
        Me.Bt_fnd2.TabIndex = 20
        Me.Bt_fnd2.Text = "..."
        Me.Bt_fnd2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "სტატუსი"
        '
        'T_addr_out
        '
        Me.T_addr_out.Enabled = False
        Me.T_addr_out.Location = New System.Drawing.Point(189, 104)
        Me.T_addr_out.Name = "T_addr_out"
        Me.T_addr_out.ReadOnly = True
        Me.T_addr_out.Size = New System.Drawing.Size(294, 20)
        Me.T_addr_out.TabIndex = 19
        '
        'DTP_out
        '
        Me.DTP_out.Enabled = False
        Me.DTP_out.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_out.Location = New System.Drawing.Point(90, 104)
        Me.DTP_out.Name = "DTP_out"
        Me.DTP_out.Size = New System.Drawing.Size(93, 20)
        Me.DTP_out.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "გასული"
        '
        'Chk_dlt1
        '
        Me.Chk_dlt1.AutoSize = True
        Me.Chk_dlt1.Location = New System.Drawing.Point(43, 103)
        Me.Chk_dlt1.Name = "Chk_dlt1"
        Me.Chk_dlt1.Size = New System.Drawing.Size(204, 17)
        Me.Chk_dlt1.TabIndex = 191
        Me.Chk_dlt1.Text = "წაშლილი ჩანაწერების გამოჩენა"
        Me.Chk_dlt1.UseVisualStyleBackColor = True
        '
        'Bt_Cham1
        '
        Me.Bt_Cham1.Enabled = False
        Me.Bt_Cham1.Font = New System.Drawing.Font("Sylfaen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Bt_Cham1.Image = Global.MGS_Zaza.My.Resources.Resources.update
        Me.Bt_Cham1.Location = New System.Drawing.Point(307, 52)
        Me.Bt_Cham1.Name = "Bt_Cham1"
        Me.Bt_Cham1.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Cham1.TabIndex = 190
        Me.Bt_Cham1.UseVisualStyleBackColor = True
        '
        'Chk_upas_cham
        '
        Me.Chk_upas_cham.AutoSize = True
        Me.Chk_upas_cham.Location = New System.Drawing.Point(43, 78)
        Me.Chk_upas_cham.Name = "Chk_upas_cham"
        Me.Chk_upas_cham.Size = New System.Drawing.Size(147, 17)
        Me.Chk_upas_cham.TabIndex = 34
        Me.Chk_upas_cham.Text = "+ უპასუხო ჩანაწერები"
        Me.Chk_upas_cham.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(59, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 25)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "ჩანაწერების შუალედი"
        '
        'Chk_dt_sab
        '
        Me.Chk_dt_sab.AutoSize = True
        Me.Chk_dt_sab.Location = New System.Drawing.Point(166, 55)
        Me.Chk_dt_sab.Name = "Chk_dt_sab"
        Me.Chk_dt_sab.Size = New System.Drawing.Size(15, 14)
        Me.Chk_dt_sab.TabIndex = 32
        Me.Chk_dt_sab.UseVisualStyleBackColor = True
        '
        'Dtp_int_start
        '
        Me.Dtp_int_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_int_start.Location = New System.Drawing.Point(64, 52)
        Me.Dtp_int_start.Name = "Dtp_int_start"
        Me.Dtp_int_start.Size = New System.Drawing.Size(93, 20)
        Me.Dtp_int_start.TabIndex = 29
        '
        'Chk_dt_sawk
        '
        Me.Chk_dt_sawk.AutoSize = True
        Me.Chk_dt_sawk.Location = New System.Drawing.Point(43, 55)
        Me.Chk_dt_sawk.Name = "Chk_dt_sawk"
        Me.Chk_dt_sawk.Size = New System.Drawing.Size(15, 14)
        Me.Chk_dt_sawk.TabIndex = 31
        Me.Chk_dt_sawk.UseVisualStyleBackColor = True
        '
        'Dtp_int_end
        '
        Me.Dtp_int_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_int_end.Location = New System.Drawing.Point(187, 52)
        Me.Dtp_int_end.Name = "Dtp_int_end"
        Me.Dtp_int_end.Size = New System.Drawing.Size(93, 20)
        Me.Dtp_int_end.TabIndex = 30
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.T_ID)
        Me.SplitContainer2.Panel2.Controls.Add(Me.T_file_out)
        Me.SplitContainer2.Panel2.Controls.Add(Me.T_file_in)
        Me.SplitContainer2.Panel2.Controls.Add(Me.AxAcroPDF1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1096, 514)
        Me.SplitContainer2.SplitterDistance = 415
        Me.SplitContainer2.TabIndex = 1
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.bt_upd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Bt_Fltr_clear)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Cmb_Stat_fl)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Chk_date2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Chk_date1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Chk_Upasuxo)
        Me.SplitContainer3.Panel2.Controls.Add(Me.DTP_End_fl)
        Me.SplitContainer3.Panel2.Controls.Add(Me.DTP_start_fl)
        Me.SplitContainer3.Panel2.Controls.Add(Me.T_fltr1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Cmb_instancia_fl)
        Me.SplitContainer3.Size = New System.Drawing.Size(415, 514)
        Me.SplitContainer3.SplitterDistance = 436
        Me.SplitContainer3.TabIndex = 1
        '
        'bt_upd
        '
        Me.bt_upd.Font = New System.Drawing.Font("Sylfaen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bt_upd.Image = CType(resources.GetObject("bt_upd.Image"), System.Drawing.Image)
        Me.bt_upd.Location = New System.Drawing.Point(161, 216)
        Me.bt_upd.Name = "bt_upd"
        Me.bt_upd.Size = New System.Drawing.Size(40, 40)
        Me.bt_upd.TabIndex = 191
        Me.bt_upd.UseVisualStyleBackColor = True
        Me.bt_upd.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_t, Me.name_inst, Me.coment1, Me.date_in, Me.date_out, Me.stat1, Me.dlt1})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(415, 436)
        Me.DataGridView1.TabIndex = 0
        '
        'ID_t
        '
        Me.ID_t.DataPropertyName = "ID"
        Me.ID_t.HeaderText = "ID"
        Me.ID_t.Name = "ID_t"
        Me.ID_t.ReadOnly = True
        Me.ID_t.Visible = False
        '
        'name_inst
        '
        Me.name_inst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.name_inst.DataPropertyName = "name_inst"
        Me.name_inst.HeaderText = "ინსტანცია"
        Me.name_inst.Name = "name_inst"
        Me.name_inst.ReadOnly = True
        '
        'coment1
        '
        Me.coment1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coment1.DataPropertyName = "coment1"
        Me.coment1.HeaderText = "კომენტარი"
        Me.coment1.Name = "coment1"
        Me.coment1.ReadOnly = True
        '
        'date_in
        '
        Me.date_in.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.date_in.DataPropertyName = "date_in"
        Me.date_in.HeaderText = "შემოს. თარ."
        Me.date_in.Name = "date_in"
        Me.date_in.ReadOnly = True
        '
        'date_out
        '
        Me.date_out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.date_out.DataPropertyName = "date_out"
        Me.date_out.HeaderText = "გასვ. თარ."
        Me.date_out.Name = "date_out"
        Me.date_out.ReadOnly = True
        '
        'stat1
        '
        Me.stat1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.stat1.DataPropertyName = "stat1"
        Me.stat1.HeaderText = "სტატუსი"
        Me.stat1.Name = "stat1"
        Me.stat1.ReadOnly = True
        Me.stat1.Visible = False
        '
        'dlt1
        '
        Me.dlt1.DataPropertyName = "dlt1"
        Me.dlt1.HeaderText = "dlt1"
        Me.dlt1.Name = "dlt1"
        Me.dlt1.ReadOnly = True
        Me.dlt1.Visible = False
        '
        'Bt_Fltr_clear
        '
        Me.Bt_Fltr_clear.BackgroundImage = Global.MGS_Zaza.My.Resources.Resources.cancel
        Me.Bt_Fltr_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Fltr_clear.Location = New System.Drawing.Point(385, 45)
        Me.Bt_Fltr_clear.Name = "Bt_Fltr_clear"
        Me.Bt_Fltr_clear.Size = New System.Drawing.Size(24, 23)
        Me.Bt_Fltr_clear.TabIndex = 11
        Me.Bt_Fltr_clear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "სტატუსი"
        '
        'Cmb_Stat_fl
        '
        Me.Cmb_Stat_fl.FormattingEnabled = True
        Me.Cmb_Stat_fl.Location = New System.Drawing.Point(275, 21)
        Me.Cmb_Stat_fl.Name = "Cmb_Stat_fl"
        Me.Cmb_Stat_fl.Size = New System.Drawing.Size(134, 21)
        Me.Cmb_Stat_fl.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ინსტანცია"
        '
        'Chk_date2
        '
        Me.Chk_date2.AutoSize = True
        Me.Chk_date2.Enabled = False
        Me.Chk_date2.Location = New System.Drawing.Point(254, 49)
        Me.Chk_date2.Name = "Chk_date2"
        Me.Chk_date2.Size = New System.Drawing.Size(15, 14)
        Me.Chk_date2.TabIndex = 8
        Me.Chk_date2.UseVisualStyleBackColor = True
        '
        'Chk_date1
        '
        Me.Chk_date1.AutoSize = True
        Me.Chk_date1.Location = New System.Drawing.Point(132, 48)
        Me.Chk_date1.Name = "Chk_date1"
        Me.Chk_date1.Size = New System.Drawing.Size(15, 14)
        Me.Chk_date1.TabIndex = 7
        Me.Chk_date1.UseVisualStyleBackColor = True
        '
        'Chk_Upasuxo
        '
        Me.Chk_Upasuxo.AutoSize = True
        Me.Chk_Upasuxo.Location = New System.Drawing.Point(12, 49)
        Me.Chk_Upasuxo.Name = "Chk_Upasuxo"
        Me.Chk_Upasuxo.Size = New System.Drawing.Size(110, 17)
        Me.Chk_Upasuxo.TabIndex = 5
        Me.Chk_Upasuxo.Text = "პასუხის გარეშე"
        Me.Chk_Upasuxo.UseVisualStyleBackColor = True
        '
        'DTP_End_fl
        '
        Me.DTP_End_fl.Enabled = False
        Me.DTP_End_fl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_End_fl.Location = New System.Drawing.Point(275, 46)
        Me.DTP_End_fl.Name = "DTP_End_fl"
        Me.DTP_End_fl.Size = New System.Drawing.Size(93, 20)
        Me.DTP_End_fl.TabIndex = 3
        '
        'DTP_start_fl
        '
        Me.DTP_start_fl.Enabled = False
        Me.DTP_start_fl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_start_fl.Location = New System.Drawing.Point(152, 46)
        Me.DTP_start_fl.Name = "DTP_start_fl"
        Me.DTP_start_fl.Size = New System.Drawing.Size(93, 20)
        Me.DTP_start_fl.TabIndex = 2
        '
        'T_fltr1
        '
        Me.T_fltr1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_fltr1.Dock = System.Windows.Forms.DockStyle.Top
        Me.T_fltr1.Location = New System.Drawing.Point(0, 0)
        Me.T_fltr1.Name = "T_fltr1"
        Me.T_fltr1.Size = New System.Drawing.Size(415, 20)
        Me.T_fltr1.TabIndex = 1
        '
        'Cmb_instancia_fl
        '
        Me.Cmb_instancia_fl.FormattingEnabled = True
        Me.Cmb_instancia_fl.Location = New System.Drawing.Point(72, 21)
        Me.Cmb_instancia_fl.Name = "Cmb_instancia_fl"
        Me.Cmb_instancia_fl.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_instancia_fl.TabIndex = 0
        '
        'T_ID
        '
        Me.T_ID.Enabled = False
        Me.T_ID.Location = New System.Drawing.Point(162, 147)
        Me.T_ID.Name = "T_ID"
        Me.T_ID.Size = New System.Drawing.Size(104, 20)
        Me.T_ID.TabIndex = 31
        Me.T_ID.Text = "0"
        Me.T_ID.Visible = False
        '
        'T_file_out
        '
        Me.T_file_out.Enabled = False
        Me.T_file_out.Location = New System.Drawing.Point(162, 121)
        Me.T_file_out.Name = "T_file_out"
        Me.T_file_out.Size = New System.Drawing.Size(104, 20)
        Me.T_file_out.TabIndex = 30
        Me.T_file_out.Visible = False
        '
        'T_file_in
        '
        Me.T_file_in.Enabled = False
        Me.T_file_in.Location = New System.Drawing.Point(162, 95)
        Me.T_file_in.Name = "T_file_in"
        Me.T_file_in.Size = New System.Drawing.Size(104, 20)
        Me.T_file_in.TabIndex = 29
        Me.T_file_in.Visible = False
        '
        'BRW_01
        '
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelchanToolStripMenuItem, Me.ChanagdenaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(193, 48)
        '
        'DelchanToolStripMenuItem
        '
        Me.DelchanToolStripMenuItem.Name = "DelchanToolStripMenuItem"
        Me.DelchanToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DelchanToolStripMenuItem.Text = "ჩანაწერის წაშლა"
        '
        'ChanagdenaToolStripMenuItem
        '
        Me.ChanagdenaToolStripMenuItem.Name = "ChanagdenaToolStripMenuItem"
        Me.ChanagdenaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ChanagdenaToolStripMenuItem.Text = "ჩანაწერის აღდგენა"
        '
        'Bt_Save_pdf2
        '
        Me.Bt_Save_pdf2.BackgroundImage = Global.MGS_Zaza.My.Resources.Resources.drive_disk
        Me.Bt_Save_pdf2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Save_pdf2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Bt_Save_pdf2.Location = New System.Drawing.Point(559, 102)
        Me.Bt_Save_pdf2.Name = "Bt_Save_pdf2"
        Me.Bt_Save_pdf2.Size = New System.Drawing.Size(26, 23)
        Me.Bt_Save_pdf2.TabIndex = 31
        Me.Bt_Save_pdf2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 676)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "MGS ZAZA"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Bt_Fltr_clear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Stat_fl As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chk_date2 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_date1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Upasuxo As System.Windows.Forms.CheckBox
    Friend WithEvents DTP_End_fl As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_start_fl As System.Windows.Forms.DateTimePicker
    Friend WithEvents T_fltr1 As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_instancia_fl As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cmb_instancia_add As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Bt_fnd1 As System.Windows.Forms.Button
    Friend WithEvents Cmb_Stat_add As System.Windows.Forms.ComboBox
    Friend WithEvents T_addr_in As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTP_in As System.Windows.Forms.DateTimePicker
    Friend WithEvents Bt_pdf1 As System.Windows.Forms.Button
    Friend WithEvents Bt_Red As System.Windows.Forms.Button
    Friend WithEvents Bt_Add As System.Windows.Forms.Button
    Friend WithEvents Bt_fnd2 As System.Windows.Forms.Button
    Friend WithEvents T_addr_out As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DTP_out As System.Windows.Forms.DateTimePicker
    Friend WithEvents Bt_Open_dir As System.Windows.Forms.Button
    Friend WithEvents Bt_pdf2 As System.Windows.Forms.Button
    Friend WithEvents Chk_dell_aft_move As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents T_coment1 As System.Windows.Forms.TextBox
    Friend WithEvents T_file_out As System.Windows.Forms.TextBox
    Friend WithEvents T_file_in As System.Windows.Forms.TextBox
    Friend WithEvents Chk_dt_sab As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_dt_sawk As System.Windows.Forms.CheckBox
    Friend WithEvents Dtp_int_end As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_int_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Chk_upas_cham As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Bt_Cham1 As System.Windows.Forms.Button
    Friend WithEvents bt_upd As System.Windows.Forms.Button
    Friend WithEvents BRW_01 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Chk_dlt1 As System.Windows.Forms.CheckBox
    Friend WithEvents T_ID As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelchanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChanagdenaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Chk_filis_chanacv As System.Windows.Forms.CheckBox
    Friend WithEvents ID_t As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_inst As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coment1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_in As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_out As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stat1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dlt1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bt_Save_pdf1 As System.Windows.Forms.Button
    Friend WithEvents Bt_Save_pdf2 As System.Windows.Forms.Button

End Class
