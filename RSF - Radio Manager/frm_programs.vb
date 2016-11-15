Imports System.IO

Public Class frm_programs
    Dim listPrograms As New ArrayList
    Dim currentFile As String
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub rd_file_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_file.CheckedChanged
        If rd_file.Checked Then
            txt_file.Enabled = True
            txt_path.Enabled = False
            btn_file.Enabled = True
            btn_path.Enabled = False
        Else
            txt_file.Enabled = False
            txt_path.Enabled = True
            btn_file.Enabled = False
            btn_path.Enabled = True
        End If
    End Sub

    Private Sub btn_get_intro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_get_intro.Click
        OpenFileDialog1.ShowDialog()
        txt_intro.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file.Click
        OpenFileDialog1.ShowDialog()
        txt_file.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_path_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_path.Click
        FolderBrowserDialog1.ShowDialog()
        txt_path.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If txt_name.Text <> "" Then
            btn_save.Enabled = True
        Else
            btn_save.Enabled = False
        End If
    End Sub

    Private Sub frm_programs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lst_programs.Items.Clear()
        listPrograms.Clear()
        For Each _File In System.IO.Directory.GetFiles(Application.StartupPath & "\programs\")
            lst_programs.Items.Add(System.IO.Path.GetFileNameWithoutExtension(_File))
            listPrograms.Add(_File)
        Next
        For Each item In Form1.cmb_plist.Items
            cmb_plistCh.Items.Add(item)
        Next
    End Sub

    Private Sub lst_programs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_programs.SelectedIndexChanged
        Try
            CleanFields()
            Dim tmp1 As String = listPrograms(lst_programs.SelectedIndex)
            If System.IO.File.Exists(tmp1) Then
                currentFile = tmp1
                Dim sr As StreamReader = New StreamReader(tmp1)
                txt_name.Text = System.IO.Path.GetFileNameWithoutExtension(tmp1)
                Dim firtLine = sr.ReadLine()
                If firtLine = "##PLAYLIST##" Then
                    ch_plist.Checked = True
                    cmb_plistCh.Text = System.IO.Path.GetFileNameWithoutExtension(sr.ReadLine())
                    nm_hour.Value = Val(sr.ReadLine())
                    nm_minute.Value = Val(sr.ReadLine())
                    If sr.ReadLine() = "0" Then
                        ch.Checked = False
                    Else
                        ch.Checked = True
                    End If
                    txt_intro.Text = sr.ReadLine()
                Else
                    ch_plist.Checked = False
                    nm_hour.Value = Val(firtLine)
                    nm_minute.Value = Val(sr.ReadLine())
                    If sr.ReadLine() = "0" Then
                        ch.Checked = False
                    Else
                        ch.Checked = True
                    End If
                    txt_intro.Text = sr.ReadLine()
                    Dim tmp = sr.ReadLine()
                    Try
                        Dim sra As StreamReader = New StreamReader(tmp)
                        sra.Close()
                        txt_file.Text = tmp
                        rd_file.Checked = True
                        rd_folder.Checked = False
                    Catch ex As Exception
                        rd_file.Checked = False
                        txt_path.Text = tmp
                        rd_file.Checked = False
                        rd_folder.Checked = True
                    End Try
                End If
                sr.Close()
            End If
        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If MsgBox("Delete this program?" & vbNewLine & System.IO.Path.GetFileNameWithoutExtension(currentFile), MsgBoxStyle.YesNo, "Delete program") = MsgBoxResult.Yes Then
            File.Delete(currentFile)
            currentFile = ""
        End If
        lst_programs.Items.Clear()
        listPrograms.Clear()
        For Each _File In System.IO.Directory.GetFiles(Application.StartupPath & "\programs\")
            lst_programs.Items.Add(System.IO.Path.GetFileNameWithoutExtension(_File))
            listPrograms.Add(_File)
        Next
        MsgBox("Program is removed!", MsgBoxStyle.Information, "Program Remove")
        CleanFields()
    End Sub

    Private Sub CleanFields()
        currentFile = ""
        txt_file.Text = ""
        txt_intro.Text = ""
        txt_name.Text = ""
        txt_path.Text = ""
        rd_file.Checked = True
        ch.Checked = False
        nm_hour.Value = 0
        nm_minute.Value = 0
        ch_plist.Checked = False
    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        CleanFields()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            If ch_plist.Checked Then
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\programs\" & txt_name.Text, False)
                file.WriteLine("##PLAYLIST##")
                file.WriteLine(Form1.Plist(cmb_plistCh.SelectedIndex))
                file.WriteLine(nm_hour.Value)
                file.WriteLine(nm_minute.Value)
                If ch.Checked Then
                    file.WriteLine("1")
                Else
                    file.WriteLine("0")
                End If
                file.WriteLine(txt_intro.Text)
                file.Close()
                lst_programs.Items.Clear()
                listPrograms.Clear()
                For Each _File In System.IO.Directory.GetFiles(Application.StartupPath & "\programs\")
                    lst_programs.Items.Add(System.IO.Path.GetFileNameWithoutExtension(_File))
                    listPrograms.Add(_File)
                Next
                MsgBox("Program " & txt_name.Text & " is saved!", MsgBoxStyle.Information, "Program")
            Else
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\programs\" & txt_name.Text, False)
                file.WriteLine(nm_hour.Value)
                file.WriteLine(nm_minute.Value)
                If ch.Checked Then
                    file.WriteLine("1")
                Else
                    file.WriteLine("0")
                End If
                file.WriteLine(txt_intro.Text)
                If rd_file.Checked Then
                    file.WriteLine(txt_file.Text)
                Else
                    file.WriteLine(txt_path.Text)
                End If
                file.Close()
                lst_programs.Items.Clear()
                listPrograms.Clear()
                For Each _File In System.IO.Directory.GetFiles(Application.StartupPath & "\programs\")
                    lst_programs.Items.Add(System.IO.Path.GetFileNameWithoutExtension(_File))
                    listPrograms.Add(_File)
                Next
                MsgBox("Program " & txt_name.Text & " is saved!", MsgBoxStyle.Information, "Program")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ch_plist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_plist.CheckedChanged
        If ch_plist.Checked Then
            ch.Enabled = False
            btn_get_intro.Enabled = False
            txt_intro.Enabled = False
            gp_details.Visible = False
            gb_plist.Visible = True
        Else
            ch.Enabled = True
            btn_get_intro.Enabled = True
            txt_intro.Enabled = True
            gp_details.Visible = True
            gb_plist.Visible = False
        End If
    End Sub
End Class