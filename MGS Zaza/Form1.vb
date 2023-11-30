Imports System.Globalization
Imports System.IO

Public Class Form1
    Private cDt_stat_add As DataTable
    Private cDt_stat_fl As DataTable
    Private cDt_inst_add As DataTable
    Private cDt_inst_fl As DataTable
    Private cDt_baza As DataTable
    Private cDv_baza As DataView
    Private cFli_rw_indx1 As Integer = -1


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.AppIcon
        '
        Dim myCI As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("ka-GE")
        Dim myCIclone As System.Globalization.CultureInfo = myCI.Clone()
        myCIclone.NumberFormat.NumberDecimalSeparator = "."
        myCIclone.NumberFormat.NumberGroupSeparator = " "
        myCIclone.NumberFormat.CurrencyDecimalSeparator = "."
        myCIclone.NumberFormat.CurrencyGroupSeparator = " "
        myCIclone.NumberFormat.PercentDecimalSeparator = "."
        myCIclone.NumberFormat.PercentGroupSeparator = " "

        Dim a1 As NumberFormatInfo = myCIclone.NumberFormat
        Application.CurrentCulture = myCIclone
        'myCIclone.DateTimeFormat.AMDesignator = "AM"
        myCIclone.DateTimeFormat.LongTimePattern = "HH:mm:ss"
        myCIclone.DateTimeFormat.DateSeparator = "."
        myCIclone.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy"
        myCIclone.NumberFormat.CurrencySymbol = "Lari"
        myCIclone.NumberFormat.NumberDecimalDigits = 2
        myCIclone.NumberFormat.CurrencyDecimalSeparator = "."
        myCIclone.NumberFormat.NumberDecimalSeparator = "."
        Application.CurrentCulture = myCIclone
        '
        Me.Chk_dt_sawk.Checked = CBool(My_Get_Setting("", "", "Chk_dt_sawk", "False"))
        Me.Chk_dt_sab.Checked = CBool(My_Get_Setting("", "", "Chk_dt_sab", "False"))
        If Me.Chk_dt_sawk.Checked Then
            Me.Dtp_int_start.Value = CDate(My_Get_Setting("", "", "Dtp_int_start", DateTime.Now.ToString("yyyy-MM-dd")))
        End If
        'Me.Chk_dlt1.Checked = CBool(My_Save_Setting("", "", "Chk_dlt1", "False"))
        Me.Chk_upas_cham.Checked = CBool(My_Get_Setting("", "", "Chk_upas_cham", "False"))
        '
        If Not monac_bazis_mititeba() Then
            Me.Close()
            Return
        End If
        cDt_baza = New DataTable
        cDv_baza = cDt_baza.DefaultView
        Me.Chk_dell_aft_move.Checked = CBool(My_Get_Setting("", "", "Chk_dell_aft_move", "False"))
        Me.Chk_filis_chanacv.Checked = CBool(My_Get_Setting("", "", "Chk_filis_chanacv", "False"))
        load_sawk()
        cham_1()
    End Sub

    Private Sub load_data()
        Me.DataGridView1.DataSource = Nothing
        Access_con.Open()
        Try
            dadp_ac = New OleDb.OleDbDataAdapter("SELECT id,name_st FROM tbl_status ORDER BY name_st", Access_con)
            dadp_ac.Fill(cDt_stat_add)
            cDt_stat_add.Clear()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "შეცდომა")
        Finally
            Access_con.Close()
        End Try
        Me.DataGridView1.DataSource = cDv_baza
    End Sub

    Private Sub load_sawk()
        Me.Cmb_Stat_fl.DataSource = Nothing
        Me.Cmb_Stat_add.DataSource = cDt_stat_add
        Me.Cmb_instancia_add.DataSource = cDt_inst_add
        Me.Cmb_instancia_fl.DataSource = cDt_inst_fl
        cDt_stat_add = New DataTable
        cDt_stat_fl = New DataTable
        cDt_inst_add = New DataTable
        cDt_inst_fl = New DataTable
        Access_con.Open()
        Try
            dadp_ac = New OleDb.OleDbDataAdapter("SELECT id,name_st FROM tbl_status ORDER BY name_st", Access_con)
            dadp_ac.Fill(cDt_stat_add)
            cDt_stat_add.Clear()
            Dim dr1 As DataRow = cDt_stat_add.NewRow
            dr1("ID") = 0
            dr1("name_st") = ""
            cDt_stat_add.Rows.Add(dr1)
            dadp_ac.Fill(cDt_stat_add)
            cDt_stat_fl = cDt_stat_add.Clone
            Dim dr2 As DataRow = cDt_stat_fl.NewRow
            dr2("ID") = 0
            dr2("name_st") = ""
            cDt_stat_fl.Rows.Add(dr2)
            dadp_ac.Fill(cDt_stat_fl)
            dadp_ac = New OleDb.OleDbDataAdapter("SELECT id,name_inst FROM tbl_instancia ORDER BY name_inst", Access_con)
            dadp_ac.Fill(cDt_inst_add)
            cDt_inst_add.Clear()
            Dim dr3 As DataRow = cDt_inst_add.NewRow
            dr3("ID") = 0
            dr3("name_inst") = ""
            cDt_inst_add.Rows.Add(dr3)
            cDt_inst_fl = cDt_inst_add.Clone
            dadp_ac.Fill(cDt_inst_add)
            Dim dr4 As DataRow = cDt_inst_fl.NewRow
            dr4("ID") = 0
            dr4("name_inst") = ""
            cDt_inst_fl.Rows.Add(dr4)
            dadp_ac.Fill(cDt_inst_fl)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "შეცდომა")
        Finally
            Access_con.Close()
        End Try
        Me.Cmb_Stat_fl.DataSource = cDt_stat_fl
        Me.Cmb_Stat_fl.DisplayMember = "name_st"
        Me.Cmb_Stat_fl.ValueMember = "id"
        Me.Cmb_Stat_add.DataSource = cDt_stat_add
        Me.Cmb_Stat_add.DisplayMember = "name_st"
        Me.Cmb_Stat_add.ValueMember = "id"
        Me.Cmb_instancia_add.DataSource = cDt_inst_add
        Me.Cmb_instancia_add.DisplayMember = "name_inst"
        Me.Cmb_instancia_add.ValueMember = "id"
        Me.Cmb_instancia_fl.DataSource = cDt_inst_fl
        Me.Cmb_instancia_fl.DisplayMember = "name_inst"
        Me.Cmb_instancia_fl.ValueMember = "id"
    End Sub

    Private Sub Bt_pdf1_Click(sender As System.Object, e As System.EventArgs) Handles Bt_pdf1.Click
        If Me.T_file_in.Text.Trim.Length > 0 Then
            Me.AxAcroPDF1.src = Me.T_file_in.Text.Trim
        Else
            Me.AxAcroPDF1.src = Nothing
        End If
    End Sub

    Private Function del_file1() As Boolean
        If CInt(Me.T_ID.Text) > 0 Then
            Access_con.Open()
            Try
                txt_sql = "UPDATE tbl_baza SET dlt1=1 WHERE id=" & Me.T_ID.Text
                dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
                dcmd_ac.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "შეცდომა")
            Finally
                Access_con.Close()
            End Try
        Else
            MsgBox("გაურკვეველი შეცდომა", , "შეცდომა")
            Return False
        End If
        Return True
    End Function

    Private Function My_copy_File(ByVal fl_start1 As String, fl_end1 As String, ByVal pFlg_copy_move As Boolean, ByVal pFlg1 As Boolean)
        Try
            'Me.Chk_dell_aft_move.Checked
            If pFlg_copy_move Then
                My.Computer.FileSystem.MoveFile(fl_start1, _
                            fl_end1, _
                            pFlg1)
            Else
                My.Computer.FileSystem.CopyFile(fl_start1, _
                          fl_end1, _
                          pFlg1)
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, , "შეცდომა")
            Return True
        End Try
    End Function

    Private Function ind_daang_shem() As Integer
        Dim dr_name1 As String = mk_dr1(Me.DTP_in.Value)
        Dim fl_i() As String = Directory.GetFiles(dr_name1, "Shemosuli *.pdf")
        Dim fl_indx1 As Integer = 0
        Dim crnt1 As Integer = 0
        For Each fl1 As String In fl_i
            Dim a22 As String = Path.GetFileName(fl1)
            Dim cr_ind2 As String = Path.GetFileName(fl1).Substring(10, 4)
            If IsNumeric(cr_ind2) Then
                crnt1 = CInt(cr_ind2)
                If fl_indx1 < crnt1 Then
                    fl_indx1 = crnt1
                End If
            End If
        Next
        Return fl_indx1 + 1
    End Function

    Private Function shem1() As Boolean
        Dim ind_fl1 As Integer = 0
        If Me.T_coment1.Text.Trim.Length = 0 Then
            MsgBox("კომენტარი აუცილებელია!", , "აუცილებელი პირობა")
            Me.T_coment1.Focus()
            Return False
        End If
        If Me.Cmb_instancia_add.SelectedIndex < 1 Then
            MsgBox("ინსტანციის მითითება აუცილებელია!", , "აუცილებელი პირობა")
            Me.Cmb_instancia_add.Focus()
            Return False
        End If
        If CInt(Me.T_ID.Text) = 0 Then
            If Me.T_addr_in.Text.Trim.Length = 0 Then
                MsgBox("მიუთითედ შემომავალი კორესპონდეციის ფაილი!", , "აუცილებელი პირობა")
                Me.Bt_fnd1.Focus()
                Return False
            End If
        Else
            If Me.T_addr_in.Text.Trim.Length > 0 And Me.T_file_in.Text.Trim.Length > 0 Then
                If MsgBox("ჩავანაცვლო შემომავალი კორესპონდეციის ფაილი!", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo + MsgBoxStyle.Information, "აუცილებელი პირობა") = MsgBoxResult.No Then
                    Me.Bt_fnd1.Focus()
                    Return False
                End If
            End If
            If Me.T_addr_out.Text.Trim.Length > 0 And Me.T_file_out.Text.Trim.Length > 0 Then
                If MsgBox("ჩავანაცვლო გამავალი კორესპონდეციის ფაილი!", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo + MsgBoxStyle.Information, "აუცილებელი პირობა") = MsgBoxResult.No Then
                    Me.Bt_fnd2.Focus()
                    Return False
                End If
            End If
        End If

        Dim rd_in11 As Integer = DateDiff(DateInterval.Day, CDate(DateTime.Now.ToString("yyyy-MM-dd")), CDate(Me.DTP_in.Value.ToString("yyyy-MM-dd")))
        Dim rd_out11 As Integer = DateDiff(DateInterval.Day, CDate(DateTime.Now.ToString("yyyy-MM-dd")), CDate(Me.DTP_out.Value.ToString("yyyy-MM-dd")))
        If rd_in11 > 0 Then
            MsgBox("შემომავალი კორესპონდეციის თარიღი მეტია მიმდინარეზე!", , "აუცილებელი პირობა")
            Me.DTP_in.Focus()
            Return False
        ElseIf rd_in11 < -6 Then
            If MsgBox(String.Format("შემომავალი კორესპონდეციის თარიღი ნაკლებია მიმდინარეზე {0} დღით! გავაგრძელო?", -rd_in11), _
                      MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "გაფრთხილება") = MsgBoxResult.No Then
                Me.DTP_in.Focus()
                Return False
            End If
        End If
        If rd_out11 > 0 Then
            MsgBox("გამავალი კორესპონდეციის თარიღი მეტია მიმდინარეზე!", , "აუცილებელი პირობა")
            Me.DTP_out.Focus()
            Return False
        ElseIf rd_out11 < -6 Then
            If MsgBox(String.Format("გამავალი კორესპონდეციის თარიღი ნაკლებია მიმდინარეზე {0} დღით! გავაგრძელო?", -rd_in11), _
                          MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "გაფრთხილება") = MsgBoxResult.No Then
                Me.DTP_out.Focus()
                Return False
            End If
        End If

        If Me.T_file_in.Text.Trim.Length > 0 And Me.T_addr_in.Text.Trim.Length > 0 And Me.Chk_filis_chanacv.Checked Then
            If My_copy_File(Me.T_addr_in.Text.Trim, Me.T_file_in.Text, Me.Chk_dell_aft_move.Checked, True) Then
                Return False
            End If
        ElseIf Me.T_addr_in.Text.Trim.Length > 0 Then
            If Me.T_file_in.Text.Trim.Length > 0 And (Not Me.Chk_filis_chanacv.Checked) Then
                If del_file1() Then
                    Me.T_ID.Text = "0"
                    ind_fl1 = ind_daang_shem()
                    Me.T_file_in.Text = mk_dr1(Me.DTP_in.Value) & "\" & String.Format("Shemosuli {0}.pdf", (ind_fl1).ToString("0000"))
                Else
                    Return False
                End If
                Dim out_fl2_1 As String = mk_dr1(Me.DTP_in.Value) & "\" & String.Format("Gasuli {0}.pdf", (ind_fl1).ToString("0000"))
                If My_copy_File(Me.T_addr_in.Text.Trim, Me.T_file_in.Text, Me.Chk_dell_aft_move.Checked, False) Then
                    Return False
                End If
                If Me.T_addr_out.Text.Trim.Length = 0 And Me.T_file_out.Text.Trim.Length > 0 Then
                    If My_copy_File(Me.T_file_out.Text.Trim, out_fl2_1, Me.Chk_dell_aft_move.Checked, False) Then
                        Return False
                    End If
                    Me.T_file_out.Text = out_fl2_1
                End If
            Else
                ind_fl1 = ind_daang_shem()
                Me.T_file_in.Text = mk_dr1(Me.DTP_in.Value) & "\" & String.Format("Shemosuli {0}.pdf", (ind_fl1).ToString("0000"))
                If My_copy_File(Me.T_addr_in.Text.Trim, Me.T_file_in.Text, Me.Chk_dell_aft_move.Checked, True) Then
                    Return False
                End If
            End If
        End If
        If Me.T_file_out.Text.Trim.Length > 0 And Me.T_addr_out.Text.Trim.Length > 0 And Me.Chk_filis_chanacv.Checked Then
            If My_copy_File(Me.T_addr_out.Text.Trim, Me.T_file_out.Text, Me.Chk_dell_aft_move.Checked, True) Then
                Return False
            End If
        ElseIf Me.T_addr_out.Text.Trim.Length > 0 Then
            ind_fl1 = CInt(Path.GetFileName(Me.T_file_in.Text.Trim).Substring(10, 4))
            Me.T_file_out.Text = mk_dr1(Me.DTP_in.Value) & "\" & String.Format("Gasuli {0}.pdf", ind_fl1.ToString("0000"))
            'Me.T_file_out.Text = mk_dr1(Me.DTP_in.Value) & "\" & String.Format("Shemosuli {0}.pdf", (ind_fl1).ToString("0000"))
            If My_copy_File(Me.T_addr_out.Text.Trim, Me.T_file_out.Text, Me.Chk_dell_aft_move.Checked, True) Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Function mk_dr1(ByVal pDt_in1 As DateTime) As String
        Dim dr_0 As String = Path.GetDirectoryName(Access_file)
        Dim txt_dry1 As String = dr_0 & "\" & pDt_in1.Year
        Dim txt_drm1 As String = txt_dry1 & "\" & pDt_in1.Month.ToString("00")
        Dim txt_drd1 As String = txt_drm1 & "\" & pDt_in1.Day.ToString("00")
        If Not Directory.Exists(txt_dry1) Then
            System.IO.Directory.CreateDirectory(txt_dry1)
        End If
        If Not Directory.Exists(txt_drm1) Then
            System.IO.Directory.CreateDirectory(txt_drm1)
        End If
        If Not Directory.Exists(txt_drd1) Then
            System.IO.Directory.CreateDirectory(txt_drd1)
        End If
        Return txt_drd1
    End Function

    Private Sub Bt_Add_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Add.Click
        If Me.Bt_Add.Text = "ახალი" Then
            Clear1()
            vele_enb1(True)
        Else
            If shem1() Then
                Access_con.Open()
                Try
                    If CInt(Me.T_ID.Text) > 0 Then
                        txt_sql = String.Format("UPDATE tbl_baza SET coment1='{1}',key_inst={2},key_st={3} WHERE id={0}", _
                                             Me.T_ID.Text, Me.T_coment1.Text.Trim, Me.Cmb_instancia_add.SelectedValue, Me.Cmb_Stat_add.SelectedValue)
                        dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
                        dcmd_ac.ExecuteNonQuery()
                        If Me.T_addr_out.Text.Trim.Length > 0 Then
                            txt_sql = String.Format("UPDATE tbl_baza SET date_in='{1}',file_in='{2}' WHERE id={0}", _
                                                    Me.T_ID.Text, Me.DTP_in.Value.ToString("yyyy-MM-dd"), Me.T_file_in.Text.Trim)
                            dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
                            dcmd_ac.ExecuteNonQuery()
                        End If
                        If Me.T_addr_out.Text.Trim.Length > 0 Then
                            txt_sql = String.Format("UPDATE tbl_baza SET date_out='{1}',file_out='{2}' WHERE id={0}", _
                                                    Me.T_ID.Text, Me.DTP_out.Value.ToString("yyyy-MM-dd"), Me.T_file_out.Text.Trim)
                            dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
                            dcmd_ac.ExecuteNonQuery()
                        End If
                    Else
                        If Me.T_addr_out.Text.Trim.Length > 0 Then
                            txt_sql = String.Format("INSERT INTO tbl_baza (coment1,key_inst,key_st,date_in,date_out,file_in,file_out) " & _
                                                    "VALUES ('{0}',{1},{2},'{3}','{4}','{5}','{6}')", _
                                                    Me.T_coment1.Text.Trim, Me.Cmb_instancia_add.SelectedValue, Me.Cmb_Stat_add.SelectedValue, _
                                                    Me.DTP_in.Value.ToString("yyyy-MM-dd"), Me.DTP_out.Value.ToString("yyyy-MM-dd"), _
                                                    Me.T_file_in.Text.Trim, Me.T_file_out.Text.Trim)
                        Else
                            txt_sql = String.Format("INSERT INTO tbl_baza (coment1,key_inst,key_st,date_in,file_in) " & _
                                                    "VALUES ('{0}',{1},{2},'{3}','{4}')", _
                                                    Me.T_coment1.Text.Trim, Me.Cmb_instancia_add.SelectedValue, Me.Cmb_Stat_add.SelectedValue, _
                                                    Me.DTP_in.Value.ToString("yyyy-MM-dd"), Me.T_file_in.Text.Trim)
                        End If
                        dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
                        dcmd_ac.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "შეცდომა")
                    Return
                Finally
                    Access_con.Close()
                End Try
                Clear1()
                cham_1()
                vele_enb1(False)
            End If
        End If
    End Sub

    Private Sub vele_enb1(ByVal pFlg_enb1 As Boolean)
        Me.DTP_in.Enabled = pFlg_enb1
        Me.DTP_out.Enabled = pFlg_enb1
        Me.T_addr_in.Enabled = pFlg_enb1
        Me.T_addr_out.Enabled = pFlg_enb1
        Me.T_coment1.Enabled = pFlg_enb1
        Me.Cmb_Stat_add.Enabled = pFlg_enb1
        Me.Cmb_instancia_add.Enabled = pFlg_enb1
        Me.Bt_fnd1.Enabled = pFlg_enb1
        Me.Bt_fnd2.Enabled = pFlg_enb1
        Me.Bt_pdf1.Enabled = Not pFlg_enb1
        Me.Bt_pdf2.Enabled = Not pFlg_enb1
        Me.Bt_Save_pdf1.Enabled = Not pFlg_enb1
        Me.Bt_Save_pdf2.Enabled = Not pFlg_enb1
        Me.Bt_Open_dir.Enabled = Not pFlg_enb1
        If pFlg_enb1 Then
            Me.Bt_Add.Text = "შენახვა"
            Me.Bt_Red.Text = "გუქმება"
        Else
            Me.DataGridView1.Enabled = True
            Me.Bt_Add.Text = "ახალი"
            Me.Bt_Red.Text = "შეცვლა"
        End If
    End Sub

    Private Sub Clear1()
        Me.DataGridView1.Enabled = False
        Me.DTP_in.Value = DateTime.Now
        Me.DTP_out.Value = DateTime.Now
        Me.T_ID.Text = "0"
        Me.T_file_in.Text = ""
        Me.T_file_out.Text = ""
        Me.T_addr_in.Text = ""
        Me.T_addr_out.Text = ""
        Me.T_addr_in.BackColor = Control.DefaultBackColor
        Me.T_addr_out.BackColor = Control.DefaultBackColor
        Me.T_coment1.Text = ""
        Me.Cmb_Stat_add.SelectedValue = 0
        Me.Cmb_instancia_add.SelectedValue = 0
        Me.DTP_in.Value = DateTime.Now
        Me.DTP_out.Value = DateTime.Now
    End Sub

    Private Sub Bt_Fltr_clear_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Fltr_clear.Click
        Me.Cmb_instancia_fl.SelectedIndex = 0
        Me.Cmb_Stat_fl.SelectedIndex = 0
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Try
            If Me.DataGridView1.Rows(e.RowIndex).Cells("dlt1").Value <> 0 Then
                Me.DataGridView1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            Else
                Me.DataGridView1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Try
            cFli_rw_indx1 = e.RowIndex
            velebi1(cFli_rw_indx1)
        Catch ex As Exception
            cFli_rw_indx1 = -1
        End Try
    End Sub

    Private Sub velebi1(ByVal pRw_inx1 As Integer)
        Me.T_addr_in.Text = ""
        Me.T_addr_out.Text = ""
        Try
            Dim cr_id As Long = Me.DataGridView1.Rows(pRw_inx1).Cells("ID_t").Value
            Dim sl_rw1() As DataRow = cDt_baza.Select("ID=" & cr_id)
            Me.DTP_in.Value = DateTime.Now
            Me.DTP_out.Value = DateTime.Now
            Me.Cmb_instancia_add.SelectedValue = 0
            Me.Cmb_Stat_add.SelectedValue = 0
            Me.T_coment1.Text = ""
            Me.T_addr_out.BackColor = Control.DefaultBackColor

            If sl_rw1.Count = 1 Then
                Me.T_ID.Text = sl_rw1(0)("id")
                Me.Cmb_instancia_add.SelectedValue = sl_rw1(0)("key_inst")
                Try
                    Me.Cmb_Stat_add.SelectedValue = sl_rw1(0)("key_st")
                Catch ex As Exception
                    Me.Cmb_Stat_add.SelectedValue = 0
                End Try
                Me.DTP_in.Value = sl_rw1(0)("date_in")
                If Not IsDBNull(sl_rw1(0)("date_out")) Then
                    Me.DTP_out.Value = sl_rw1(0)("date_out")
                End If
                Me.T_coment1.Text = sl_rw1(0)("coment1")
                Me.T_file_in.Text = sl_rw1(0)("file_in")
                Me.T_addr_in.BackColor = Color.GreenYellow

                If IsDBNull(sl_rw1(0)("file_out")) Then
                    Me.T_file_out.Text = ""
                    Me.T_addr_out.BackColor = Control.DefaultBackColor
                Else
                    Me.T_file_out.Text = sl_rw1(0)("file_out")
                    Me.T_addr_out.BackColor = Color.GreenYellow
                End If
            End If
        Catch ex As Exception
            Me.T_ID.Text = 0
            Me.DTP_in.Value = DateTime.Now
            Me.DTP_out.Value = DateTime.Now
            Me.Cmb_instancia_add.SelectedValue = 0
            Me.Cmb_Stat_add.SelectedValue = 0
            Me.T_coment1.Text = ""
            Me.T_addr_out.BackColor = Control.DefaultBackColor
        End Try
    End Sub

    Private Sub Chk_dell_aft_move_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_dell_aft_move.CheckedChanged
        My_Save_Setting("", "", "Chk_dell_aft_move", Me.Chk_dell_aft_move.Checked.ToString)
    End Sub

    Private Sub Bt_fnd1_Click(sender As System.Object, e As System.EventArgs) Handles Bt_fnd1.Click
        Dim opfl1 As New OpenFileDialog
        opfl1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        opfl1.Title = "მიუთითედ შემოსული კორესპონდეციის ფაილი"
        opfl1.Filter = "PDF Files|*.pdf"
        opfl1.Multiselect = False
        opfl1.RestoreDirectory = True
        If opfl1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.AxAcroPDF1.src = opfl1.FileName
            Me.T_addr_in.Text = opfl1.FileName
        End If
    End Sub

    Private Sub Bt_Open_dir_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Open_dir.Click
        If Me.T_file_in.Text.Trim.Length > 0 Then

        End If
    End Sub

    Private Sub Bt_Cham1_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Cham1.Click
        Dim a44 = DateDiff(DateInterval.Day, CDate(DateTime.Now.ToString("yyyy-MM-dd")), CDate(Me.Dtp_int_start.Value.ToString("yyyy-MM-dd")))
        cham_1()
    End Sub

    Private Sub cham_1()
        Me.Bt_Cham1.Enabled = False
        My_Save_Setting("", "", "Chk_dt_sawk", Me.Chk_dt_sawk.Checked.ToString)
        My_Save_Setting("", "", "Chk_dt_sab", Me.Chk_dt_sab.Checked.ToString)
        If Me.Chk_dt_sawk.Checked Then
            My_Save_Setting("", "", "Dtp_int_start", Me.Dtp_int_start.Value.ToString("yyyy-MM-dd"))
        End If
        My_Save_Setting("", "", "Chk_dlt1", Me.Chk_dlt1.Checked.ToString)
        My_Save_Setting("", "", "Chk_upas_cham", Me.Chk_upas_cham.Checked.ToString)
        Me.SplitContainer4.Panel1.Enabled = False
        Me.SplitContainer1.Panel2.Enabled = False
        Dim pr_txt1() As String = {"", "", ""}
        If Me.Chk_dt_sawk.Checked And Me.Chk_dt_sab.Checked Then
            pr_txt1(0) = String.Format(" AND (date_in BETWEEN '{0}' AND '{1}')", Me.Dtp_int_start.Value.ToString("yyyy-MM-dd"), Me.Dtp_int_end.Value.ToString("yyyy-MM-dd"))
        ElseIf Me.Chk_dt_sawk.Checked Then
            pr_txt1(0) = String.Format(" AND (date_in='{0}')", Me.Dtp_int_start.Value.ToString("yyyy-MM-dd"))
        End If
        If Me.Chk_upas_cham.Checked Then
            pr_txt1(1) = " AND LEN(TRIM(IIF(ISNULL(file_out),'',file_out)))>0"
        End If
        If Me.Chk_dlt1.Checked Then
            pr_txt1(2) = "1=1"
        Else
            pr_txt1(2) = "dlt1=0"
        End If
        Me.DataGridView1.DataSource = Nothing
        Me.bt_upd.Visible = True
        Me.DataGridView1.DataSource = ""
        Me.BRW_01.RunWorkerAsync(pr_txt1)
    End Sub

    Private Sub BRW_01_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BRW_01.DoWork
        Dim cp_1() As String = e.Argument
        Try
            cDt_baza.Clear()
        Catch
        End Try
        Access_con.Open()
        Try
            'txt_sql = String.Format("SELECT a.*,Nz(b.name_st,'') name_st FROM (SELECT a.*,Nz(b.name_inst,'') name_inst FROM (" & _
            '                  "SELECT * FROM tbl_baza WHERE {0}{1}{2}) a " & _
            '                  "LEFT JOIN tbl_instancia b ON a.key_inst=b.id) a LEFT JOIN tbl_status b ON a.key_st=b.id", _
            '                  cp_1(2), cp_1(0), cp_1(1))
            txt_sql = String.Format("SELECT a.*,b.name_st FROM (SELECT a.*,b.name_inst FROM (" & _
                              "SELECT * FROM tbl_baza WHERE {0}{1}{2}) a " & _
                              "LEFT JOIN tbl_instancia b ON a.key_inst=b.id) a LEFT JOIN tbl_status b ON a.key_st=b.id ORDER BY a.id DESC", _
                              cp_1(2), cp_1(0), cp_1(1))
            dadp_ac = New OleDb.OleDbDataAdapter(txt_sql, Access_con)
            dadp_ac.Fill(cDt_baza)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "შეცდომა")
        Finally
            Access_con.Close()
        End Try
    End Sub

    Private Sub BRW_01_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BRW_01.RunWorkerCompleted
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.DataSource = cDv_baza
        Me.bt_upd.Visible = False
        Me.Bt_Cham1.Enabled = True
        Me.SplitContainer4.Panel1.Enabled = True
        Me.SplitContainer1.Panel2.Enabled = True
    End Sub

    Private Sub Bt_Red_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Red.Click
        If Me.Bt_Red.Text = "შეცვლა" Then
            If CInt(Me.T_ID.Text) > 0 Then
                vele_enb1(True)
            Else
                MsgBox("ჩანაწერის შეცვლამდე აირჩიეთ ჩანაწერი!", , "გაფრთხილება!")
            End If
        Else
            vele_enb1(False)
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedCells.Count > 0 Then
            cFli_rw_indx1 = Me.DataGridView1.SelectedCells(0).RowIndex
            velebi1(cFli_rw_indx1)
        End If
    End Sub

    Private Sub ChanagdenaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChanagdenaToolStripMenuItem.Click
        If CInt(Me.T_ID.Text) > 0 Then
            Dim dl_vl1 As Integer = Me.DataGridView1.Rows(cFli_rw_indx1).Cells("dlt1").Value
            If dl_vl1 = 0 Then
                MsgBox("ჩანაწერი არ საჭიროებს აღდენას!", , "შეტყობინება")
                Return
            End If
            Access_con.Open()
            Try
                dcmd_ac = New OleDb.OleDbCommand("UPDATE tbl_status SET dlt1=0 WHERE id=" & Me.T_ID.Text, Access_con)
                dcmd_ac.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "შეცდომა")
            Finally
                Access_con.Close()
            End Try
            cham_1()
        End If
    End Sub

    Private Sub DelchanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DelchanToolStripMenuItem.Click
        If CInt(Me.T_ID.Text) > 0 Then
            Dim dl_vl1 As Integer = Me.DataGridView1.Rows(cFli_rw_indx1).Cells("dlt1").Value
            If dl_vl1 = 1 Then
                MsgBox("ჩანაწერი უკვე წაშლილია!", , "შეტყობინება")
                Return
            End If
            Access_con.Open()
            Try
                dcmd_ac = New OleDb.OleDbCommand("UPDATE tbl_status SET dlt1=1 WHERE id=" & Me.T_ID.Text, Access_con)
                dcmd_ac.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "შეცდომა")
            Finally
                Access_con.Close()
            End Try
            cham_1()
        End If
    End Sub

    Private Sub Chk_filis_chanacv_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_filis_chanacv.CheckedChanged
        My_Save_Setting("", "", "Chk_filis_chanacv", Me.Chk_filis_chanacv.Checked.ToString)
    End Sub

    Private Sub Bt_fnd2_Click(sender As System.Object, e As System.EventArgs) Handles Bt_fnd2.Click
        Dim opfl1 As New OpenFileDialog
        opfl1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        opfl1.Title = "მიუთითედ გასული კორესპონდეციის ფაილი"
        opfl1.Filter = "PDF Files|*.pdf"
        opfl1.Multiselect = False
        opfl1.RestoreDirectory = True
        If opfl1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.AxAcroPDF1.src = opfl1.FileName
            Me.T_addr_out.Text = opfl1.FileName
        End If
    End Sub

    Private Sub Bt_pdf2_Click(sender As System.Object, e As System.EventArgs) Handles Bt_pdf2.Click
        If Me.T_file_out.Text.Trim.Length > 0 Then
            Me.AxAcroPDF1.src = Me.T_file_out.Text.Trim
        Else
            Me.AxAcroPDF1.src = Nothing
        End If
    End Sub

    Private Sub Bt_Save_pdf1_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Save_pdf1.Click
        If Me.T_file_in.Text.Trim.Length > 0 Then
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Title = "შემოსული კორესპონდეციის ფაილის შენახვა"
            SaveFileDialog1.Filter = "PDF Files|*.pdf"
            SaveFileDialog1.RestoreDirectory = True
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(Me.T_file_in.Text.Trim, _
                      SaveFileDialog1.FileName, _
                      True)
            End If
        End If
    End Sub

    Private Sub Bt_Save_pdf2_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Save_pdf2.Click
        If Me.T_file_out.Text.Trim.Length > 0 Then
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Title = "გასული კორესპონდეციის ფაილის შენახვა"
            SaveFileDialog1.Filter = "PDF Files|*.pdf"
            SaveFileDialog1.RestoreDirectory = True
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(Me.T_file_out.Text.Trim, _
                      SaveFileDialog1.FileName, _
                      True)
            End If
        End If
    End Sub

    Private Sub Cmb_instancia_fl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_instancia_fl.SelectedIndexChanged
        filt_ck()
    End Sub

    Private Sub Cmb_Stat_fl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_Stat_fl.SelectedIndexChanged
        filt_ck()
    End Sub

    Private Sub DTP_start_fl_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DTP_start_fl.ValueChanged
        filt_ck()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DTP_End_fl.ValueChanged
        filt_ck()
    End Sub

    Private Sub Chk_date1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_date1.CheckedChanged
        Me.DTP_start_fl.Enabled = Me.Chk_date1.Checked
        Me.Chk_date2.Enabled = Me.Chk_date1.Checked
        Me.DTP_End_fl.Enabled = Me.Chk_date1.Checked And Me.Chk_date2.Checked
        filt_ck()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_date2.CheckedChanged
        Me.DTP_End_fl.Enabled = Me.Chk_date1.Checked And Me.Chk_date2.Checked
        filt_ck()
    End Sub

    Private Sub Chk_Upasuxo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_Upasuxo.CheckedChanged
        filt_ck()
    End Sub

    Private Sub T_fltr1_TextChanged(sender As System.Object, e As System.EventArgs) Handles T_fltr1.TextChanged
        filt_ck()
    End Sub

    Private Sub filt_ck()
        Dim rv_flt5 As String = ""
        Try
            Dim fil_ad As String = ""
            Dim flt2() As String = Me.T_fltr1.Text.Trim.Split(" ")
            For Each stxt1 As String In flt2
                If stxt1.Trim.Length > 0 Then
                    rv_flt5 &= fil_ad & String.Format("(filtri LIKE '%{0}%')", stxt1)
                    fil_ad = " AND "
                End If
            Next
        Catch ex As Exception
            rv_flt5 = ""
        End Try
        Try
            If Me.Cmb_instancia_fl.SelectedValue > 0 Then
                rv_flt5 = IIf(rv_flt5.Trim.Length > 0, "(" & rv_flt5 & ") AND ", "") & "key_inst=" & Me.Cmb_instancia_fl.SelectedValue.ToString
            End If
        Catch ex As Exception
        End Try
        Try
            If Me.Cmb_Stat_fl.SelectedValue > 0 Then
                rv_flt5 = IIf(rv_flt5.Trim.Length > 0, "(" & rv_flt5 & ") AND ", "") & "key_st=" & Me.Cmb_Stat_fl.SelectedValue.ToString
            End If
        Catch ex As Exception
        End Try
        If Me.Chk_Upasuxo.Checked Then
            rv_flt5 = IIf(rv_flt5.Trim.Length > 0, "(" & rv_flt5 & ") AND ", "") & "LEN(TRIM(file_out))>0"
        End If
        If Me.Chk_date1.Checked And (Not Me.Chk_date2.Checked) Then
            rv_flt5 = IIf(rv_flt5.Trim.Length > 0, "(" & rv_flt5 & ") AND ", "") & String.Format("date_in=#{0}#", Me.DTP_start_fl.Value.ToString("yyyy-MM-dd"))
        ElseIf Me.Chk_date1.Checked And Me.Chk_date2.Checked Then
            'between
            rv_flt5 = IIf(rv_flt5.Trim.Length > 0, "(" & rv_flt5 & ") AND ", "") & String.Format("(date_in>=#{0}# AND date_in#{1}#)", _
                                            Me.DTP_start_fl.Value.ToString("yyyy-MM-dd"), Me.DTP_End_fl.Value.ToString("yyyy-MM-dd"))
        End If
        cDv_baza.RowFilter = rv_flt5
    End Sub
End Class
