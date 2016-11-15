Imports System.IO

Public Class Form1
    Dim bgFiles As New ArrayList
    Dim MusicListFiles As New ArrayList
    Public Plist As New ArrayList
    Dim fxSetMod As Boolean = False
    Dim fxFiles As New ArrayList
    Dim currentIndexMusic As Integer = 0
    Dim faltaMinutos As Integer = 4
    Dim faltaSegundos As Integer = 59
    Dim blinkAlert As Boolean = False
    Dim filesBusy As Boolean = True
    Dim sayHour As Boolean = False
    Dim nToPUB As Integer = 0
    Dim LastSong As String
    Dim nextSong As String

    '' Programas
    Dim programfile As String
    Dim inProgram As Integer = 0
    Dim theProgramFile As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListSave.Enabled = False
        OpenFileDialog1.ShowDialog()
        lst_Playlist.Items.Clear()
        MusicListFiles.Clear()

        Dim file As String
        For Each file In OpenFileDialog1.FileNames
            MusicListFiles.Add(file)
            lst_Playlist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

        Dim fileName = InputBox("Name of Playlist", "New Playlist")

        Dim file1 As System.IO.StreamWriter
        file1 = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\plist\" & fileName & ".lst", False)
        For Each dirFile In MusicListFiles
            file1.WriteLine(dirFile)
        Next
        file1.Close()

        cmb_plist.Items.Clear()
        Plist.Clear()
        cmb_plist.Text = fileName
        My.Settings.currentPath = Application.StartupPath & "\plist\" & fileName & ".lst"
        For Each _File In System.IO.Directory.GetFiles(Application.StartupPath & "\plist\")
            cmb_plist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(_File))
            Plist.Add(_File)
        Next
        ListSave.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListSave.Enabled = False
        OpenFileDialog1.ShowDialog()

        Dim file As String
        For Each file In OpenFileDialog1.FileNames
            MusicListFiles.Add(file)
            lst_Playlist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        ListSave.Enabled = True
    End Sub


    Private Sub lst_Playlist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_Playlist.DoubleClick
        Dim currentFile As String
        currentIndexMusic = lst_Playlist.SelectedIndex
        If lst_Playlist.SelectedIndex <> -1 Then
            currentFile = MusicListFiles(lst_Playlist.SelectedIndex)
            wmp.URL = currentFile
            nToPUB = 0
            currentMusic.Text = System.IO.Path.GetFileNameWithoutExtension(currentFile)
            If AutoRemove.Checked Then
                MusicListFiles.RemoveAt(lst_Playlist.SelectedIndex)
                lst_Playlist.Items.RemoveAt(lst_Playlist.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        fxSetMod = True
        fx1.ForeColor = Color.Red
        fx2.ForeColor = Color.Red
        fx3.ForeColor = Color.Red
        fx4.ForeColor = Color.Red
        fx5.ForeColor = Color.Red
        fx6.ForeColor = Color.Red
        fx7.ForeColor = Color.Red
        fx8.ForeColor = Color.Red
        fx9.ForeColor = Color.Red
        fx10.ForeColor = Color.Red
        fx11.ForeColor = Color.Red
        fx12.ForeColor = Color.Red

    End Sub

    Private Sub fx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx1.Click

        If fx1.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(0) = fxd.FileName
            fx1.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(0) = fxd.FileName
                fx1.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(0)
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        NumericUpDown1.Value = My.Settings.Pubs
        If My.Settings.currentPath = "" Then
            OpenFileDialog1.ShowDialog()
            lst_Playlist.Items.Clear()
            MusicListFiles.Clear()

            Dim file As String
            For Each file In OpenFileDialog1.FileNames
                MusicListFiles.Add(file)
                lst_Playlist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
            Next


            Dim file1 As System.IO.StreamWriter
            Dim TMP = InputBox("Name of Playlist", "New Playlist")
            file1 = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\plist\" & TMP & ".lst", False)
            For Each dirFile In MusicListFiles
                file1.WriteLine(dirFile)
            Next
            file1.Close()

            cmb_plist.Items.Clear()
            Plist.Clear()
            For Each _File In System.IO.Directory.GetFiles(Application.StartupPath & "\plist\")
                If System.IO.Path.GetExtension(_File) = ".lst" Then
                    cmb_plist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(_File))
                    Plist.Add(_File)
                End If
            Next

            My.Settings.currentPath = Application.StartupPath & "\plist\" & TMP & ".lst"
            My.Settings.Save()
            cmb_plist.Text = TMP
        Else
            cmb_plist.Text = System.IO.Path.GetFileNameWithoutExtension(My.Settings.currentPath)
        End If

        bgplayer.settings.setMode("loop", True)
        bgFiles.Clear()
        lst_bg.Items.Clear()
        cmb_plist.Items.Clear()
        Plist.Clear()
        For Each _File In System.IO.Directory.GetFiles(Application.StartupPath & "\plist\")
            If System.IO.Path.GetExtension(_File) = ".lst" Then
                cmb_plist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(_File))
                Plist.Add(_File)
            End If
        Next

        For Each File In System.IO.Directory.GetFiles(Application.StartupPath & "\bg_music\")
            bgFiles.Add(File)
            lst_bg.Items.Add(System.IO.Path.GetFileNameWithoutExtension(File))
        Next

        If System.IO.File.Exists(Application.StartupPath & "\fxlist.lst") Then
            Dim sr As StreamReader = New StreamReader(Application.StartupPath & "\fxlist.lst")
            Do While sr.Peek() >= 0
                fxFiles.Add(sr.ReadLine())
            Loop
            sr.Close()
            Dim srq As StreamReader = New StreamReader(Application.StartupPath & "\fxlist.lst")
            Dim Line = srq.ReadLine()
            If Line <> "" Then
                fx1.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx2.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx3.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx4.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx5.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx6.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx7.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx8.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx9.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx10.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx11.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If
            Line = srq.ReadLine()
            If Line <> "" Then
                fx12.Text = System.IO.Path.GetFileNameWithoutExtension(Line)
            End If

            srq.Close()
        Else
            For index As Integer = 1 To 12
                fxFiles.Add("")
            Next
        End If

        If System.IO.File.Exists(My.Settings.currentPath) Then
            Dim sr As StreamReader = New StreamReader(My.Settings.currentPath)
            Do While sr.Peek() >= 0
                Dim dFile As String
                dFile = sr.ReadLine()
                MusicListFiles.Add(dFile)
                lst_Playlist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dFile))
            Loop
            sr.Close()
        End If
        filesBusy = False
        wmp.settings.volume = 110
        bgplayer.settings.volume = 0


    End Sub

    Private Sub fx2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx2.Click
        If fx2.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(1) = fxd.FileName
            fx2.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(1) = fxd.FileName
                fx2.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(1)
            End If
        End If
    End Sub

    Private Sub fx3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx3.Click
        If fx3.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(2) = fxd.FileName
            fx3.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(2) = fxd.FileName
                fx3.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(2)
            End If
        End If
    End Sub

    Private Sub fx4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx4.Click
        If fx4.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(3) = fxd.FileName
            fx4.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(3) = fxd.FileName
                fx4.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(3)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        fx_player.URL = Nothing
    End Sub

    Private Sub fx5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx5.Click
        If fx5.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(4) = fxd.FileName
            fx5.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(4) = fxd.FileName
                fx5.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(4)
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lst_Playlist.Items.Clear()
        MusicListFiles.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim index As Integer
        index = lst_Playlist.SelectedIndex
        lst_Playlist.Items.RemoveAt(index)
        MusicListFiles.RemoveAt(index)
    End Sub

    Private Sub fx6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx6.Click
        If fx6.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(5) = fxd.FileName
            fx6.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(5) = fxd.FileName
                fx6.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(5)
            End If
        End If
    End Sub

    Private Sub fx7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx7.Click
        If fx7.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(6) = fxd.FileName
            fx7.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(6) = fxd.FileName
                fx7.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(6)
            End If
        End If
    End Sub

    Private Sub fx8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx8.Click
        If fx8.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(7) = fxd.FileName
            fx8.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(7) = fxd.FileName
                fx8.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(7)
            End If
        End If
    End Sub

    Private Sub fx9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx9.Click
        If fx9.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(8) = fxd.FileName
            fx9.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(8) = fxd.FileName
                fx9.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(8)
            End If
        End If
    End Sub

    Private Sub fx10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx10.Click
        If fx10.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(9) = fxd.FileName
            fx10.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(9) = fxd.FileName
                fx10.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(9)
            End If
        End If
    End Sub

    Private Sub fx11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx11.Click
        If fx11.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(10) = fxd.FileName
            fx11.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(10) = fxd.FileName
                fx11.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(10)
            End If
        End If
    End Sub

    Private Sub fx12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fx12.Click
        If fx12.Text = "(none)" Then
            fxd.ShowDialog()
            fxFiles(11) = fxd.FileName
            fx12.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
        Else
            If fxSetMod Then
                fxd.ShowDialog()
                fxFiles(11) = fxd.FileName
                fx12.Text = System.IO.Path.GetFileNameWithoutExtension(fxd.FileName)
                fx1.ForeColor = Color.Black
                fx2.ForeColor = Color.Black
                fx3.ForeColor = Color.Black
                fx4.ForeColor = Color.Black
                fx5.ForeColor = Color.Black
                fx6.ForeColor = Color.Black
                fx7.ForeColor = Color.Black
                fx8.ForeColor = Color.Black
                fx9.ForeColor = Color.Black
                fx10.ForeColor = Color.Black
                fx11.ForeColor = Color.Black
                fx12.ForeColor = Color.Black
                fxSetMod = False
            Else
                fx_player.URL = fxFiles(11)
            End If
        End If
    End Sub

    Private Sub ShuffleItems()
        Dim Random As New System.Random
        Dim ArrayList As New System.Collections.ArrayList(MusicListFiles)
        MusicListFiles.Clear()
        lst_Playlist.Items.Clear()
        While ArrayList.Count > 0
            Dim Index As System.Int32 = Random.Next(0, ArrayList.Count)
            MusicListFiles.Add(ArrayList(Index))
            ArrayList.RemoveAt(Index)
        End While

        For Each item In MusicListFiles
            lst_Playlist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(item))
        Next
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            musicRandom.Enabled = True
            AutoMix.Enabled = True
            btn_programs.Enabled = False
            hasPUBS.Enabled = True
            programT.Enabled = True
        Else
            musicRandom.Enabled = False
            AutoMix.Enabled = False
            btn_programs.Enabled = True
            hasPUBS.Enabled = False
            programT.Enabled = False
        End If
    End Sub

    Private Sub ListSave_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListSave.Tick
        My.Settings.Save()
        If Not filesBusy Then
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(My.Settings.currentPath, False)
            For Each dirFile In MusicListFiles
                file.WriteLine(dirFile)
            Next
            file.Close()

            Dim file1 As System.IO.StreamWriter
            file1 = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\fxlist.lst", False)
            For Each dirFile In fxFiles
                file1.WriteLine(dirFile)
            Next
            file1.Close()
        End If
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ShuffleItems()
    End Sub

    Private Sub AutoMix_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoMix.Tick
        bgplayer.settings.volume = 0
        If programfile <> Nothing Then
            Dim sr As StreamReader = New StreamReader(programfile)

            Dim H = sr.ReadLine()
            Dim M = sr.ReadLine()
            Dim W = sr.ReadLine()

            Dim Intro = sr.ReadLine()
            Dim PF = sr.ReadLine()

            Dim programInRun As String

            Try
                Dim sra As StreamReader = New StreamReader(PF)
                sra.Close()
                programInRun = PF
            Catch ex As Exception
                Dim Random As New System.Random
                Dim Index As System.Int32 = Random.Next(0, System.IO.Directory.GetFiles(PF).Count)
                Dim dirList As New ArrayList

                For Each File In System.IO.Directory.GetFiles(PF)
                    dirList.Add(File)
                Next
                programInRun = dirList(Index)

            End Try
            Dim acurrentPlayerState As Integer = wmp.playState
            If acurrentPlayerState = 1 Or acurrentPlayerState = 0 Then
                If inProgram = 2 Then
                    theProgramFile = Nothing
                    programfile = Nothing
                    inProgram = -1
                    nToPUB = 0
                End If
                If inProgram = 1 Then
                    wmp.URL = programInRun
                    wmp.settings.volume = 110
                    wmp.Ctlcontrols.play()
                    currentMusic.Text = System.IO.Path.GetFileNameWithoutExtension(programfile)
                    inProgram = 2
                End If
                If inProgram = 0 Then
                    wmp.URL = Intro
                    wmp.settings.volume = 110
                    wmp.Ctlcontrols.play()
                    currentMusic.Text = System.IO.Path.GetFileNameWithoutExtension(programfile)
                    inProgram = 1
                End If
            Else
                wmp.settings.volume = wmp.settings.volume + 3
            End If
        Else
            Dim currentPlayerState As Integer = wmp.playState
            If currentPlayerState = 1 Or currentPlayerState = 0 Then
                If sayHour Then
                    Dim ResourceFilePath = Application.StartupPath
                    wmp.settings.volume = 110
                    wmp.URL = ResourceFilePath & "\clock\" & System.DateTime.Now.Hour & ".wav"
                    wmp.Ctlcontrols.play()
                    sayHour = False
                Else
                    If nToPUB < My.Settings.Pubs Then
                        wmp.settings.volume = 0
                        If nextSong = Nothing Then
                            If musicRandom.Checked Then
                                Dim rand As New Random()
                                Dim number = rand.Next(1, MusicListFiles.Count)
                                If musicRandom.Checked Then
                                    If System.IO.Path.GetExtension(MusicListFiles(number)).ToLower() = ".wav" Or System.IO.Path.GetExtension(MusicListFiles(number)).ToLower() = ".wma" Or System.IO.Path.GetExtension(MusicListFiles(number)).ToLower() = ".mp3" Then
                                        wmp.URL = MusicListFiles(number)
                                        lst_Playlist.SelectedIndex = number
                                        wmp.Ctlcontrols.play()
                                    End If
                                    nToPUB = nToPUB + 1
                                    currentMusic.Text = System.IO.Path.GetFileNameWithoutExtension(MusicListFiles(number))
                                    If AutoRemove.Checked Then
                                        lst_Playlist.Items.RemoveAt(number)
                                        MusicListFiles.RemoveAt(number)
                                    End If
                                End If
                            Else
                                If System.IO.Path.GetExtension(MusicListFiles(currentIndexMusic)).ToLower() = ".wav" Or System.IO.Path.GetExtension(MusicListFiles(currentIndexMusic)).ToLower() = ".wma" Or System.IO.Path.GetExtension(MusicListFiles(currentIndexMusic)).ToLower() = ".mp3" Then
                                    wmp.URL = MusicListFiles(currentIndexMusic)
                                    wmp.Ctlcontrols.play()
                                End If
                                nToPUB = nToPUB + 1
                                currentMusic.Text = System.IO.Path.GetFileNameWithoutExtension(currentIndexMusic)
                                If AutoRemove.Checked Then
                                    lst_Playlist.Items.RemoveAt(currentIndexMusic)
                                    MusicListFiles.RemoveAt(currentIndexMusic)
                                End If
                                currentIndexMusic = currentIndexMusic + 2
                                If currentIndexMusic > MusicListFiles.Count Then
                                    currentIndexMusic = 0
                                End If
                            End If
                        Else
                            nToPUB = nToPUB + 1
                            wmp.URL = nextSong
                            currentMusic.Text = System.IO.Path.GetFileNameWithoutExtension(nextSong)
                            wmp.Ctlcontrols.play()
                            nextSong = Nothing
                        End If
                    Else
                        If hasPUBS.Checked Then
                            Dim Random As New System.Random
                            Dim Index As System.Int32 = Random.Next(0, (System.IO.Directory.GetFiles(Application.StartupPath & "\pubs\").Count - 1) + 5)
                            Dim dirList As New ArrayList

                            For Each File In System.IO.Directory.GetFiles(Application.StartupPath & "\pubs\")
                                dirList.Add(File)
                            Next

                            If Index >= System.IO.Directory.GetFiles(Application.StartupPath & "\pubs\").Count - 1 Then
                                If File.Exists(My.Settings.currentPath + ".mp3") Then
                                    wmp.URL = My.Settings.currentPath + ".mp3"
                                Else
                                    wmp.URL = dirList(0)
                                End If
                            Else
                                wmp.URL = dirList(Index)
                            End If
                            wmp.Ctlcontrols.play()
                        End If
                        nToPUB = 0
                    End If
                    End If
            Else
                wmp.settings.volume = wmp.settings.volume + 3
            End If

        End If

    End Sub

    Private Sub Relogio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Relogio.Tick
        Dim Hora As Integer = System.DateTime.Now.Hour
        Dim Minuto As Integer = System.DateTime.Now.Minute
        Dim Segundo As Integer = System.DateTime.Now.Second

        If Minuto = 0 And Segundo = 0 Then
            If CheckBox2.Checked Then
                sayHour = True
            End If
        End If

        Dim sHora = Convert.ToString(Hora)
        Dim sMinuto = Convert.ToString(Minuto)
        Dim sSegundo = Convert.ToString(Segundo)

        If Hora < 10 Then
            sHora = "0" & sHora
        End If
        If Minuto < 10 Then
            sMinuto = "0" & sMinuto
        End If
        If Segundo < 10 Then
            sSegundo = "0" & sSegundo
        End If

        Clock.Text = sHora & ":" & sMinuto & ":" & sSegundo

        Dim currentPlayerState As Integer = wmp.playState
        If currentPlayerState = 1 Or currentPlayerState = 0 Then
            faltaSegundos = faltaSegundos - 1
            If faltaSegundos < 10 Then
                vozTimer.Text = faltaMinutos & ":0" & faltaSegundos
            Else
                vozTimer.Text = faltaMinutos & ":" & faltaSegundos
            End If

            If faltaMinutos = 5 Then
                vozTimer.ForeColor = Color.Blue
            End If
            If faltaMinutos = 3 Then
                vozTimer.ForeColor = Color.Green
            End If
            If faltaMinutos = 2 Then
                vozTimer.ForeColor = Color.Yellow
            End If
            If (faltaMinutos = 2 And faltaSegundos < 30) Or (faltaMinutos = 1 And faltaSegundos > 30) Then
                vozTimer.ForeColor = Color.Orange
            End If
            If (faltaMinutos = 1 And faltaSegundos <= 30) Or (faltaMinutos = 0 And faltaSegundos > 50) Then
                vozTimer.ForeColor = Color.OrangeRed
            End If
            If faltaMinutos = 0 And faltaSegundos <= 50 Then
                If blinkAlert = False Then
                    vozTimer.ForeColor = Color.Red
                Else
                    vozTimer.ForeColor = Color.Black
                End If
            End If

            If faltaSegundos = 0 And faltaMinutos = 0 Then
                If blinkAlert Then
                    Player1.BackColor = Color.FromArgb(CInt(64), CInt(64), CInt(64))
                    blinkAlert = False
                Else
                    Player1.BackColor = Color.Red
                    blinkAlert = True
                End If
                faltaSegundos = 1
                faltaMinutos = 0
            End If

            If faltaSegundos = 0 And faltaMinutos > 0 Then
                faltaMinutos = faltaMinutos - 1
                faltaSegundos = 60
            End If
            If bgplayer.settings.volume < 5 Then
                bgplayer.settings.volume = bgplayer.settings.volume + 1
            End If
            fx_player.settings.volume = 80
        Else
            vozTimer.Text = "5:00"
            faltaMinutos = 4
            faltaSegundos = 59
            vozTimer.ForeColor = Color.CadetBlue
            blinkAlert = False
            Player1.BackColor = Color.FromArgb(CInt(64), CInt(64), CInt(64))
            bgplayer.settings.volume = 0
            fx_player.settings.volume = 0
        End If
    End Sub

    Private Sub bg_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bg_timer.Tick
        bgFiles.Clear()
        lst_bg.Items.Clear()
        For Each File In System.IO.Directory.GetFiles(Application.StartupPath & "\bg_music\")
            bgFiles.Add(File)
            lst_bg.Items.Add(System.IO.Path.GetFileNameWithoutExtension(File))
        Next

        cmb_plist.Items.Clear()
        Plist.Clear()
        For Each _File In System.IO.Directory.GetFiles(Application.StartupPath & "\plist\")
            If System.IO.Path.GetExtension(_File) = ".lst" Then
                cmb_plist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(_File))
                Plist.Add(_File)
            End If
        Next

    End Sub

    Private Sub lst_bg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_bg.DoubleClick
        bgplayer.URL = bgFiles(lst_bg.SelectedIndex)
        bgplayer.Ctlcontrols.play()
    End Sub

    Private Sub Main_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main.Tick
        'Musica em Reproducao
        If LastSong <> currentMusic.Text Then
            Dim fileM As System.IO.StreamWriter
            fileM = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\actual_music.txt", False)
            fileM.WriteLine(currentMusic.Text)
            fileM.Close()
            LastSong = currentMusic.Text
        End If
    End Sub

    Private Sub cmb_plist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_plist.SelectedIndexChanged
        My.Settings.currentPath = Plist(cmb_plist.SelectedIndex)
        My.Settings.Save()
        MusicListFiles.Clear()
        lst_Playlist.Items.Clear()
        If System.IO.File.Exists(My.Settings.currentPath) Then
            Dim sr As StreamReader = New StreamReader(My.Settings.currentPath)
            Do While sr.Peek() >= 0
                Dim dFile As String
                dFile = sr.ReadLine()
                MusicListFiles.Add(dFile)
                lst_Playlist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dFile))
            Loop
            sr.Close()
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        My.Settings.Pubs = NumericUpDown1.Value
        My.Settings.Save()
    End Sub

    Private Sub btn_programs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_programs.Click
        frm_programs.Show()
    End Sub


    Private Sub programT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles programT.Tick
        If programfile = Nothing Then
            Try
                '' Programas
                For Each _File In System.IO.Directory.GetFiles(Application.StartupPath & "\programs\")
                    Dim sr As StreamReader = New StreamReader(_File)
                    Dim txt_name = System.IO.Path.GetFileNameWithoutExtension(_File)
                    Dim firstLine = sr.ReadLine()
                    If firstLine = "##PLAYLIST##" Then
                        Dim listPath = sr.ReadLine()
                        Dim nm_hour = sr.ReadLine()
                        Dim nm_minute = sr.ReadLine()

                        If nm_hour = Date.Now.Hour And nm_minute = Date.Now.Minute Then
                            If My.Settings.currentPath <> listPath Then
                                My.Settings.currentPath = listPath
                                My.Settings.Save()
                                cmb_plist.Text = System.IO.Path.GetFileNameWithoutExtension(listPath)
                                MusicListFiles.Clear()
                                lst_Playlist.Items.Clear()
                                If System.IO.File.Exists(My.Settings.currentPath) Then
                                    Dim srs As StreamReader = New StreamReader(My.Settings.currentPath)
                                    Do While srs.Peek() >= 0
                                        Dim dFile As String
                                        dFile = srs.ReadLine()
                                        MusicListFiles.Add(dFile)
                                        lst_Playlist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dFile))
                                    Loop
                                    srs.Close()
                                End If
                            End If
                        End If

                    Else
                        Dim nm_hour = Val(firstLine)
                        Dim nm_minute = Val(sr.ReadLine())

                        Dim HasProgram As Boolean = False
                        If nm_hour = Date.Now.Hour Then
                            If nm_minute = Date.Now.Minute Then
                                Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
                                If sr.ReadLine() = "0" Then
                                    If (Weekday(todaysdate) >= 2 And Weekday(todaysdate) <= 6) Then
                                        HasProgram = True
                                    End If
                                Else
                                    If (Weekday(todaysdate) = 1 Or Weekday(todaysdate) = 7) Then
                                        HasProgram = True
                                    End If
                                End If
                            End If
                        End If
                        sr.Close()
                        If HasProgram Then
                            programfile = _File
                            inProgram = 0
                        End If
                    End If

                Next
                '' //////////
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btn_current_bg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_current_bg.Click
        bgplayer.URL = MusicListFiles(lst_Playlist.SelectedIndex)
        bgplayer.Ctlcontrols.play()
    End Sub

    Private Sub btn_playNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_playNext.Click
        OpenFileDialog2.ShowDialog()
        nextSong = OpenFileDialog2.FileName
    End Sub
End Class