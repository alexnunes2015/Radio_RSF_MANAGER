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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lst_Playlist = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Player1 = New System.Windows.Forms.Panel
        Me.cmb_plist = New System.Windows.Forms.ComboBox
        Me.hasPUBS = New System.Windows.Forms.CheckBox
        Me.AutoRemove = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.musicRandom = New System.Windows.Forms.CheckBox
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.fx_player = New AxWMPLib.AxWindowsMediaPlayer
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.fx12 = New System.Windows.Forms.Button
        Me.fx11 = New System.Windows.Forms.Button
        Me.fx10 = New System.Windows.Forms.Button
        Me.fx9 = New System.Windows.Forms.Button
        Me.fx8 = New System.Windows.Forms.Button
        Me.fx7 = New System.Windows.Forms.Button
        Me.fx6 = New System.Windows.Forms.Button
        Me.fx5 = New System.Windows.Forms.Button
        Me.fx4 = New System.Windows.Forms.Button
        Me.fx3 = New System.Windows.Forms.Button
        Me.fx2 = New System.Windows.Forms.Button
        Me.fx1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.fxd = New System.Windows.Forms.OpenFileDialog
        Me.ListSave = New System.Windows.Forms.Timer(Me.components)
        Me.AutoMix = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_programs = New System.Windows.Forms.Button
        Me.vozTimer = New System.Windows.Forms.Label
        Me.currentMusic = New System.Windows.Forms.Label
        Me.Clock = New System.Windows.Forms.Label
        Me.Relogio = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_current_bg = New System.Windows.Forms.Button
        Me.lst_bg = New System.Windows.Forms.ListBox
        Me.bgplayer = New AxWMPLib.AxWindowsMediaPlayer
        Me.label111 = New System.Windows.Forms.Label
        Me.bg_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Main = New System.Windows.Forms.Timer(Me.components)
        Me.programT = New System.Windows.Forms.Timer(Me.components)
        Me.btn_playNext = New System.Windows.Forms.Button
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.Player1.SuspendLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.fx_player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.bgplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_Playlist
        '
        Me.lst_Playlist.FormattingEnabled = True
        Me.lst_Playlist.Location = New System.Drawing.Point(3, 34)
        Me.lst_Playlist.Name = "lst_Playlist"
        Me.lst_Playlist.Size = New System.Drawing.Size(337, 199)
        Me.lst_Playlist.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(4, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Playlist:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Coral
        Me.Button1.Location = New System.Drawing.Point(7, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "New List"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DereferenceLinks = False
        Me.OpenFileDialog1.Filter = "Music Files|*.*"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        Me.OpenFileDialog1.Title = "Load files"
        '
        'Player1
        '
        Me.Player1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Player1.Controls.Add(Me.btn_playNext)
        Me.Player1.Controls.Add(Me.cmb_plist)
        Me.Player1.Controls.Add(Me.hasPUBS)
        Me.Player1.Controls.Add(Me.AutoRemove)
        Me.Player1.Controls.Add(Me.CheckBox2)
        Me.Player1.Controls.Add(Me.musicRandom)
        Me.Player1.Controls.Add(Me.wmp)
        Me.Player1.Controls.Add(Me.Button6)
        Me.Player1.Controls.Add(Me.Button5)
        Me.Player1.Controls.Add(Me.Button4)
        Me.Player1.Controls.Add(Me.Button3)
        Me.Player1.Controls.Add(Me.Button1)
        Me.Player1.Controls.Add(Me.lst_Playlist)
        Me.Player1.Controls.Add(Me.Label1)
        Me.Player1.Location = New System.Drawing.Point(12, 54)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(350, 343)
        Me.Player1.TabIndex = 4
        '
        'cmb_plist
        '
        Me.cmb_plist.FormattingEnabled = True
        Me.cmb_plist.Location = New System.Drawing.Point(51, 7)
        Me.cmb_plist.Name = "cmb_plist"
        Me.cmb_plist.Size = New System.Drawing.Size(289, 21)
        Me.cmb_plist.TabIndex = 136
        '
        'hasPUBS
        '
        Me.hasPUBS.AutoSize = True
        Me.hasPUBS.Checked = True
        Me.hasPUBS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hasPUBS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.hasPUBS.Location = New System.Drawing.Point(253, 244)
        Me.hasPUBS.Name = "hasPUBS"
        Me.hasPUBS.Size = New System.Drawing.Size(53, 17)
        Me.hasPUBS.TabIndex = 135
        Me.hasPUBS.Text = "PUBs"
        Me.hasPUBS.UseVisualStyleBackColor = True
        '
        'AutoRemove
        '
        Me.AutoRemove.AutoSize = True
        Me.AutoRemove.ForeColor = System.Drawing.Color.Red
        Me.AutoRemove.Location = New System.Drawing.Point(253, 271)
        Me.AutoRemove.Name = "AutoRemove"
        Me.AutoRemove.Size = New System.Drawing.Size(91, 17)
        Me.AutoRemove.TabIndex = 134
        Me.AutoRemove.Text = "Auto Remove"
        Me.AutoRemove.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CheckBox2.Location = New System.Drawing.Point(183, 270)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox2.TabIndex = 133
        Me.CheckBox2.Text = "Auto Mix"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'musicRandom
        '
        Me.musicRandom.AutoSize = True
        Me.musicRandom.Checked = True
        Me.musicRandom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.musicRandom.Enabled = False
        Me.musicRandom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.musicRandom.Location = New System.Drawing.Point(183, 244)
        Me.musicRandom.Name = "musicRandom"
        Me.musicRandom.Size = New System.Drawing.Size(66, 17)
        Me.musicRandom.TabIndex = 132
        Me.musicRandom.Text = "Random"
        Me.musicRandom.UseVisualStyleBackColor = True
        '
        'wmp
        '
        Me.wmp.AllowDrop = True
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(2, 297)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(348, 46)
        Me.wmp.TabIndex = 112
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.Location = New System.Drawing.Point(113, 243)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 23)
        Me.Button6.TabIndex = 131
        Me.Button6.Text = "Shuffle"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(64, 243)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 23)
        Me.Button5.TabIndex = 130
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(64, 268)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 24)
        Me.Button4.TabIndex = 129
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Coral
        Me.Button3.Location = New System.Drawing.Point(7, 243)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Add files"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.fx_player)
        Me.Panel1.Controls.Add(Me.Button16)
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.fx12)
        Me.Panel1.Controls.Add(Me.fx11)
        Me.Panel1.Controls.Add(Me.fx10)
        Me.Panel1.Controls.Add(Me.fx9)
        Me.Panel1.Controls.Add(Me.fx8)
        Me.Panel1.Controls.Add(Me.fx7)
        Me.Panel1.Controls.Add(Me.fx6)
        Me.Panel1.Controls.Add(Me.fx5)
        Me.Panel1.Controls.Add(Me.fx4)
        Me.Panel1.Controls.Add(Me.fx3)
        Me.Panel1.Controls.Add(Me.fx2)
        Me.Panel1.Controls.Add(Me.fx1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(368, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 343)
        Me.Panel1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(134, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 23)
        Me.Button2.TabIndex = 128
        Me.Button2.Text = "STOP"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'fx_player
        '
        Me.fx_player.Enabled = True
        Me.fx_player.Location = New System.Drawing.Point(182, 324)
        Me.fx_player.Name = "fx_player"
        Me.fx_player.OcxState = CType(resources.GetObject("fx_player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fx_player.Size = New System.Drawing.Size(13, 10)
        Me.fx_player.TabIndex = 127
        Me.fx_player.Visible = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button16.Location = New System.Drawing.Point(15, 311)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(113, 23)
        Me.Button16.TabIndex = 126
        Me.Button16.Text = "Set"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Coral
        Me.Button15.Location = New System.Drawing.Point(199, 311)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(89, 23)
        Me.Button15.TabIndex = 113
        Me.Button15.Text = "Clear"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'fx12
        '
        Me.fx12.Location = New System.Drawing.Point(201, 239)
        Me.fx12.Name = "fx12"
        Me.fx12.Size = New System.Drawing.Size(87, 66)
        Me.fx12.TabIndex = 125
        Me.fx12.Text = "(none)"
        Me.fx12.UseVisualStyleBackColor = True
        '
        'fx11
        '
        Me.fx11.Location = New System.Drawing.Point(108, 239)
        Me.fx11.Name = "fx11"
        Me.fx11.Size = New System.Drawing.Size(87, 66)
        Me.fx11.TabIndex = 124
        Me.fx11.Text = "(none)"
        Me.fx11.UseVisualStyleBackColor = True
        '
        'fx10
        '
        Me.fx10.Location = New System.Drawing.Point(15, 239)
        Me.fx10.Name = "fx10"
        Me.fx10.Size = New System.Drawing.Size(87, 66)
        Me.fx10.TabIndex = 123
        Me.fx10.Text = "(none)"
        Me.fx10.UseVisualStyleBackColor = True
        '
        'fx9
        '
        Me.fx9.Location = New System.Drawing.Point(199, 167)
        Me.fx9.Name = "fx9"
        Me.fx9.Size = New System.Drawing.Size(87, 66)
        Me.fx9.TabIndex = 122
        Me.fx9.Text = "(none)"
        Me.fx9.UseVisualStyleBackColor = True
        '
        'fx8
        '
        Me.fx8.Location = New System.Drawing.Point(106, 167)
        Me.fx8.Name = "fx8"
        Me.fx8.Size = New System.Drawing.Size(87, 66)
        Me.fx8.TabIndex = 121
        Me.fx8.Text = "(none)"
        Me.fx8.UseVisualStyleBackColor = True
        '
        'fx7
        '
        Me.fx7.Location = New System.Drawing.Point(13, 167)
        Me.fx7.Name = "fx7"
        Me.fx7.Size = New System.Drawing.Size(87, 66)
        Me.fx7.TabIndex = 120
        Me.fx7.Text = "(none)"
        Me.fx7.UseVisualStyleBackColor = True
        '
        'fx6
        '
        Me.fx6.Location = New System.Drawing.Point(199, 95)
        Me.fx6.Name = "fx6"
        Me.fx6.Size = New System.Drawing.Size(87, 66)
        Me.fx6.TabIndex = 119
        Me.fx6.Text = "(none)"
        Me.fx6.UseVisualStyleBackColor = True
        '
        'fx5
        '
        Me.fx5.Location = New System.Drawing.Point(106, 95)
        Me.fx5.Name = "fx5"
        Me.fx5.Size = New System.Drawing.Size(87, 66)
        Me.fx5.TabIndex = 118
        Me.fx5.Text = "(none)"
        Me.fx5.UseVisualStyleBackColor = True
        '
        'fx4
        '
        Me.fx4.Location = New System.Drawing.Point(13, 95)
        Me.fx4.Name = "fx4"
        Me.fx4.Size = New System.Drawing.Size(87, 66)
        Me.fx4.TabIndex = 117
        Me.fx4.Text = "(none)"
        Me.fx4.UseVisualStyleBackColor = True
        '
        'fx3
        '
        Me.fx3.Location = New System.Drawing.Point(199, 23)
        Me.fx3.Name = "fx3"
        Me.fx3.Size = New System.Drawing.Size(87, 66)
        Me.fx3.TabIndex = 116
        Me.fx3.Text = "(none)"
        Me.fx3.UseVisualStyleBackColor = True
        '
        'fx2
        '
        Me.fx2.Location = New System.Drawing.Point(106, 23)
        Me.fx2.Name = "fx2"
        Me.fx2.Size = New System.Drawing.Size(87, 66)
        Me.fx2.TabIndex = 115
        Me.fx2.Text = "(none)"
        Me.fx2.UseVisualStyleBackColor = True
        '
        'fx1
        '
        Me.fx1.Location = New System.Drawing.Point(13, 23)
        Me.fx1.Name = "fx1"
        Me.fx1.Size = New System.Drawing.Size(87, 66)
        Me.fx1.TabIndex = 114
        Me.fx1.Text = "(none)"
        Me.fx1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Sound FX:"
        '
        'fxd
        '
        Me.fxd.Filter = "Music Files|*.*"
        Me.fxd.Title = "Open FX"
        '
        'ListSave
        '
        Me.ListSave.Enabled = True
        Me.ListSave.Interval = 1200
        '
        'AutoMix
        '
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_programs)
        Me.Panel2.Controls.Add(Me.vozTimer)
        Me.Panel2.Controls.Add(Me.currentMusic)
        Me.Panel2.Controls.Add(Me.Clock)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1005, 39)
        Me.Panel2.TabIndex = 6
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.Location = New System.Drawing.Point(911, 13)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(61, 20)
        Me.NumericUpDown1.TabIndex = 6
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(819, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Number to PUBs"
        '
        'btn_programs
        '
        Me.btn_programs.BackColor = System.Drawing.Color.Blue
        Me.btn_programs.Location = New System.Drawing.Point(580, 9)
        Me.btn_programs.Name = "btn_programs"
        Me.btn_programs.Size = New System.Drawing.Size(75, 25)
        Me.btn_programs.TabIndex = 4
        Me.btn_programs.Text = "Programs"
        Me.btn_programs.UseVisualStyleBackColor = False
        '
        'vozTimer
        '
        Me.vozTimer.BackColor = System.Drawing.SystemColors.ControlText
        Me.vozTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.vozTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vozTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.vozTimer.Location = New System.Drawing.Point(428, 9)
        Me.vozTimer.Name = "vozTimer"
        Me.vozTimer.Size = New System.Drawing.Size(146, 26)
        Me.vozTimer.TabIndex = 2
        Me.vozTimer.Text = "5:00"
        Me.vozTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'currentMusic
        '
        Me.currentMusic.BackColor = System.Drawing.Color.Black
        Me.currentMusic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.currentMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentMusic.ForeColor = System.Drawing.SystemColors.Desktop
        Me.currentMusic.Location = New System.Drawing.Point(131, 9)
        Me.currentMusic.Name = "currentMusic"
        Me.currentMusic.Size = New System.Drawing.Size(291, 26)
        Me.currentMusic.TabIndex = 1
        Me.currentMusic.Text = "Parado"
        Me.currentMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Clock
        '
        Me.Clock.AutoSize = True
        Me.Clock.BackColor = System.Drawing.SystemColors.ControlText
        Me.Clock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Clock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Clock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clock.ForeColor = System.Drawing.Color.Green
        Me.Clock.Location = New System.Drawing.Point(14, 9)
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(106, 27)
        Me.Clock.TabIndex = 0
        Me.Clock.Text = "00:00:00"
        '
        'Relogio
        '
        Me.Relogio.Enabled = True
        Me.Relogio.Interval = 1000
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.btn_current_bg)
        Me.Panel3.Controls.Add(Me.lst_bg)
        Me.Panel3.Controls.Add(Me.bgplayer)
        Me.Panel3.Controls.Add(Me.label111)
        Me.Panel3.Location = New System.Drawing.Point(674, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 343)
        Me.Panel3.TabIndex = 129
        '
        'btn_current_bg
        '
        Me.btn_current_bg.Location = New System.Drawing.Point(179, 5)
        Me.btn_current_bg.Name = "btn_current_bg"
        Me.btn_current_bg.Size = New System.Drawing.Size(118, 23)
        Me.btn_current_bg.TabIndex = 129
        Me.btn_current_bg.Text = "Current Music"
        Me.btn_current_bg.UseVisualStyleBackColor = True
        '
        'lst_bg
        '
        Me.lst_bg.FormattingEnabled = True
        Me.lst_bg.Location = New System.Drawing.Point(7, 36)
        Me.lst_bg.Name = "lst_bg"
        Me.lst_bg.Size = New System.Drawing.Size(286, 251)
        Me.lst_bg.TabIndex = 128
        '
        'bgplayer
        '
        Me.bgplayer.Enabled = True
        Me.bgplayer.Location = New System.Drawing.Point(7, 288)
        Me.bgplayer.Name = "bgplayer"
        Me.bgplayer.OcxState = CType(resources.GetObject("bgplayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.bgplayer.Size = New System.Drawing.Size(289, 46)
        Me.bgplayer.TabIndex = 127
        '
        'label111
        '
        Me.label111.AutoSize = True
        Me.label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label111.ForeColor = System.Drawing.Color.White
        Me.label111.Location = New System.Drawing.Point(3, 5)
        Me.label111.Name = "label111"
        Me.label111.Size = New System.Drawing.Size(91, 20)
        Me.label111.TabIndex = 113
        Me.label111.Text = "BG Music:"
        '
        'bg_timer
        '
        Me.bg_timer.Enabled = True
        Me.bg_timer.Interval = 170000
        '
        'Main
        '
        Me.Main.Enabled = True
        '
        'programT
        '
        Me.programT.Enabled = True
        Me.programT.Interval = 6000
        '
        'btn_playNext
        '
        Me.btn_playNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_playNext.Location = New System.Drawing.Point(113, 268)
        Me.btn_playNext.Name = "btn_playNext"
        Me.btn_playNext.Size = New System.Drawing.Size(64, 23)
        Me.btn_playNext.TabIndex = 137
        Me.btn_playNext.Text = "Play Next"
        Me.btn_playNext.UseVisualStyleBackColor = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.RestoreDirectory = True
        Me.OpenFileDialog2.Title = "Next file to Play"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(981, 405)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Player1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RSF - Radio Manager"
        Me.Player1.ResumeLayout(False)
        Me.Player1.PerformLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.fx_player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.bgplayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lst_Playlist As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Player1 As System.Windows.Forms.Panel
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents fx12 As System.Windows.Forms.Button
    Friend WithEvents fx11 As System.Windows.Forms.Button
    Friend WithEvents fx10 As System.Windows.Forms.Button
    Friend WithEvents fx9 As System.Windows.Forms.Button
    Friend WithEvents fx8 As System.Windows.Forms.Button
    Friend WithEvents fx7 As System.Windows.Forms.Button
    Friend WithEvents fx6 As System.Windows.Forms.Button
    Friend WithEvents fx5 As System.Windows.Forms.Button
    Friend WithEvents fx4 As System.Windows.Forms.Button
    Friend WithEvents fx3 As System.Windows.Forms.Button
    Friend WithEvents fx2 As System.Windows.Forms.Button
    Friend WithEvents fx1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents fxd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fx_player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ListSave As System.Windows.Forms.Timer
    Friend WithEvents musicRandom As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents AutoMix As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Clock As System.Windows.Forms.Label
    Friend WithEvents Relogio As System.Windows.Forms.Timer
    Friend WithEvents AutoRemove As System.Windows.Forms.CheckBox
    Friend WithEvents currentMusic As System.Windows.Forms.Label
    Friend WithEvents vozTimer As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lst_bg As System.Windows.Forms.ListBox
    Friend WithEvents bgplayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents label111 As System.Windows.Forms.Label
    Friend WithEvents bg_timer As System.Windows.Forms.Timer
    Friend WithEvents hasPUBS As System.Windows.Forms.CheckBox
    Friend WithEvents Main As System.Windows.Forms.Timer
    Friend WithEvents btn_programs As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Public WithEvents cmb_plist As System.Windows.Forms.ComboBox
    Friend WithEvents programT As System.Windows.Forms.Timer
    Friend WithEvents btn_current_bg As System.Windows.Forms.Button
    Friend WithEvents btn_playNext As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog

End Class
