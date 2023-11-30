Imports System.Data.OleDb

Module Module1
    ' Access
    Public Access_con As OleDb.OleDbConnection
    Public Access_file As String
    Public txt_sql As String
    Public dadp_ac As OleDbDataAdapter
    Public dcmd_ac As OleDbCommand

    Public Function monac_bazis_mititeba() As Boolean
        Access_file = My_Get_Setting("", "", "path_access", "")
        Dim flg_imp As Boolean = False
    
        If Not My.Computer.FileSystem.FileExists(Access_file) Then
            MsgBox("მონაცემთა ბაზა არ მოინახა. პროგრამის მუშაობისთვის საჭიროა მისი შექმნა ან მიუთითეთ მისი მდებარეობა", , "გაფრთხილება")
            Dim FolderBrowserDialog21 As New Windows.Forms.FolderBrowserDialog
            FolderBrowserDialog21.ShowDialog()
            Dim txt1 As String = FolderBrowserDialog21.SelectedPath
            If Len(Trim(txt1)) > 0 Then
                Access_file = Trim(txt1 & "\zaza_baza.mdb")
                If Not My.Computer.FileSystem.FileExists(Access_file) Then
                    crt_baza(Access_file, "", 1)
                    My_Save_Setting("", "", "path_Access", Access_file)
                    flg_imp = True
                Else
                    My_Save_Setting("", "", "path_Access", Access_file)
                    'MsgBox("მონაცემთა ბაზა მითითებულია", , "")
                    flg_imp = True
                End If
            End If
        End If
        Access_con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Access_file)
        Try
            Access_con.Open()
            Access_con.Close()
            monac_bazis_mititeba = True
            Dim sr1 As String = baz_add_tbl()
        Catch ex As Exception
            monac_bazis_mititeba = False
        End Try
    End Function

    Public Function crt_baza(ByVal nm11 As String, ByVal dam_txt As String, ByVal par1 As Integer) As Boolean
        Dim ret_val1 As Boolean = False
        Select Case par1
            Case 1
                Dim cat
                cat = CreateObject("ADOX.Catalog")
                cat.Create( _
                    "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                    "Data Source=" & nm11 & ";")
                cat = Nothing
                MsgBox("მონაცემთა ბაზა შეიქმნა", , "")
            Case 2

                Access_con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dam_txt)
                Access_con.Open()
                Try
                    Dim txt_cmd1 As String = nm11
                    Dim cmd1 As OleDb.OleDbCommand
                    cmd1 = New OleDb.OleDbCommand(txt_cmd1, Access_con)
                    cmd1.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "შეცდომა")
                Finally
                    Access_con.Close()
                End Try
        End Select
        Return ret_val1
    End Function

    Private Function baz_add_tbl() As String
        baz_add_tbl = ""
        ' 2
        Access_con.Open()
        txt_sql = "SELECT id FROM tbl_instancia WHERE id<0"
        Try
            dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
            dcmd_ac.ExecuteNonQuery()
            baz_add_tbl &= "0"
        Catch ex As Exception
            Try
                txt_sql = "CREATE Table tbl_instancia (ID AutoIncrement,name_inst VARCHAR (100),primary key(ID))"
                dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
                dcmd_ac.ExecuteNonQuery()
                '
                dcmd_ac = New OleDb.OleDbCommand("INSERT INTO tbl_instancia (name_inst) VALUES ('შემოსავლები')", Access_con)
                dcmd_ac.ExecuteNonQuery()
                dcmd_ac = New OleDb.OleDbCommand("INSERT INTO tbl_instancia (name_inst) VALUES ('ენერგო პრო')", Access_con)
                dcmd_ac.ExecuteNonQuery()
                dcmd_ac = New OleDb.OleDbCommand("INSERT INTO tbl_instancia (name_inst) VALUES ('სასამართლო')", Access_con)
                dcmd_ac.ExecuteNonQuery()
                dcmd_ac = New OleDb.OleDbCommand("INSERT INTO tbl_instancia (name_inst) VALUES ('მერია')", Access_con)
                dcmd_ac.ExecuteNonQuery()
                dcmd_ac = New OleDb.OleDbCommand("INSERT INTO tbl_instancia (name_inst) VALUES ('წყალმომარაგება')", Access_con)
                dcmd_ac.ExecuteNonQuery()
                baz_add_tbl &= "1"
            Catch ex1 As Exception
                MsgBox(ex1.Message & vbCrLf & ex1.StackTrace)
                baz_add_tbl = "-"
                Exit Function
            End Try
        Finally
            Access_con.Close()
        End Try
        ' 2
        'txt_sql = "create table shemos1 (key_ch AUTOINCREMENT,key_sq int,key_kl varchar (12),name_kl VARCHAR (100),bar_kod VARCHAR(50),kuti double,name VARCHAR(150),date1 DATETIME,zd_nom VARCHAR(20),price double,raod double,ert VARCHAR(20),ert_kd int,key_inv1 int,key_inv2 int,key_inv0 int,dgg int,dgg_dg int,fqt1 int,aqc1 int,primary key(key_ch))"
        'txt_sql = "create table ERROR_CODES (ID1 long,TEXT1 varchar (250),TYPE1 long,primary key(ID1))"
        Access_con.Open()
        txt_sql = "SELECT id FROM tbl_status WHERE id<0"
        Try
            dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
            dcmd_ac.ExecuteNonQuery()
            baz_add_tbl &= "0"
        Catch ex As Exception
            Try
                txt_sql = "CREATE Table tbl_status (ID AutoIncrement,name_st VARCHAR (100),primary key(ID))"
                dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
                dcmd_ac.ExecuteNonQuery()
                '
                dcmd_ac = New OleDb.OleDbCommand("INSERT INTO tbl_status (name_st) VALUES ('სტატუსი 1')", Access_con)
                dcmd_ac.ExecuteNonQuery()
                baz_add_tbl &= "2"
            Catch ex1 As Exception
                MsgBox(ex1.Message & vbCrLf & ex1.StackTrace)
                baz_add_tbl = "-"
                Exit Function
            End Try
        Finally
            Access_con.Close()
        End Try
        ' 3
        Access_con.Open()
        txt_sql = "SELECT id FROM tbl_baza WHERE id<0"
        Try
            dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
            dcmd_ac.ExecuteNonQuery()
            baz_add_tbl &= "0"
        Catch ex As Exception
            Try
                ',primary key(ID)
                txt_sql = "CREATE Table tbl_baza (ID AutoIncrement,coment1 VARCHAR,key_inst int,key_st int,date_in datetime,date_out datetime,file_in varchar,file_out varchar,dlt1 bit DEFAULT 0)"
                dcmd_ac = New OleDb.OleDbCommand(txt_sql, Access_con)
                dcmd_ac.ExecuteNonQuery()
                baz_add_tbl &= "3"
            Catch ex1 As Exception
                MsgBox(ex1.Message & vbCrLf & ex1.StackTrace)
                baz_add_tbl = "-"
                Exit Function
            End Try
        Finally
            Access_con.Close()
        End Try
    End Function

    Public Function My_Save_Setting(ByVal mseqcia As String, ByVal mgankof As String, ByVal myKey As String, ByVal mValue As String) As Boolean
        If mseqcia = "" Then
            mseqcia = My.Application.Info.AssemblyName
        End If
        If mgankof = "" Then
            mgankof = "setting"
        End If
        Try
            Dim CU As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\MGS\" & mseqcia & "\" & mgankof)
            With CU
                .OpenSubKey("SOFTWARE\MGS\" & mseqcia & "\" & mgankof, True)
                .SetValue(myKey, mValue)
            End With
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function My_Get_Setting(ByVal mseqcia As String, ByVal mgankof As String, ByVal myKey As String, ByVal mValue As String) As String
        My_Get_Setting = mValue
        If mseqcia.Length = 0 Then
            mseqcia = My.Application.Info.AssemblyName
        End If
        If mgankof.Length = 0 Then
            mgankof = "setting"
        End If
        Try
            Dim CU As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\MGS\" & mseqcia & "\" & mgankof)
            With CU
                .OpenSubKey("SOFTWARE\MGS\" & mseqcia & "\" & mgankof, True)
                My_Get_Setting = .GetValue(myKey, mValue)
            End With
        Catch
        End Try
    End Function
End Module
