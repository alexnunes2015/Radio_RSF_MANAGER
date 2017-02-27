<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_programs
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
        Me.lst_programs = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.nm_hour = New System.Windows.Forms.NumericUpDown
        Me.nm_minute = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.ch = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_intro = New System.Windows.Forms.TextBox
        Me.btn_get_intro = New System.Windows.Forms.Button
        Me.gp_details = New System.Windows.Forms.GroupBox
        Me.btn_path = New System.Windows.Forms.Button
        Me.txt_path = New System.Windows.Forms.TextBox
        Me.btn_file = New System.Windows.Forms.Button
        Me.rd_folder = New System.Windows.Forms.RadioButton
        Me.txt_file = New System.Windows.Forms.TextBox
        Me.rd_file = New System.Windows.Forms.RadioButton
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_new = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.ch_plist = New System.Windows.Forms.CheckBox
        Me.gb_plist = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_plistCh = New System.Windows.Forms.ComboBox
        CType(Me.nm_hour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nm_minute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_details.SuspendLayout()
        Me.gb_plist.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_programs
        '
        Me.lst_programs.FormattingEnabled = True
        Me.lst_programs.Location = New System.Drawing.Point(6, 9)
        Me.lst_programs.Name = "lst_programs"
        Me.lst_programs.Size = New System.Drawing.Size(282, 290)
        Me.lst_programs.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(332, 12)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(287, 20)
        Me.txt_name.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hour:"
        '
        'nm_hour
        '
        Me.nm_hour.Location = New System.Drawing.Point(332, 42)
        Me.nm_hour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nm_hour.Name = "nm_hour"
        Me.nm_hour.Size = New System.Drawing.Size(55, 20)
        Me.nm_hour.TabIndex = 4
        Me.nm_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nm_minute
        '
        Me.nm_minute.Location = New System.Drawing.Point(442, 42)
        Me.nm_minute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nm_minute.Name = "nm_minute"
        Me.nm_minute.Size = New System.Drawing.Size(55, 20)
        Me.nm_minute.TabIndex = 6
        Me.nm_minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(397, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Minute:"
        '
        'ch
        '
        Me.ch.AutoSize = True
        Me.ch.Location = New System.Drawing.Point(529, 45)
        Me.ch.Name = "ch"
        Me.ch.Size = New System.Drawing.Size(90, 17)
        Me.ch.TabIndex = 8
        Me.ch.Text = "On Weekend"
        Me.ch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Intro Song:"
        '
        'txt_intro
        '
        Me.txt_intro.Location = New System.Drawing.Point(294, 91)
        Me.txt_intro.Name = "txt_intro"
        Me.txt_intro.Size = New System.Drawing.Size(244, 20)
        Me.txt_intro.TabIndex = 10
        '
        'btn_get_intro
        '
        Me.btn_get_intro.Location = New System.Drawing.Point(544, 91)
        Me.btn_get_intro.Name = "btn_get_intro"
        Me.btn_get_intro.Size = New System.Drawing.Size(75, 20)
        Me.btn_get_intro.TabIndex = 11
        Me.btn_get_intro.Text = "Get"
        Me.btn_get_intro.UseVisualStyleBackColor = True
        '
        'gp_details
        '
        Me.gp_details.Controls.Add(Me.btn_path)
        Me.gp_details.Controls.Add(Me.txt_path)
        Me.gp_details.Controls.Add(Me.btn_file)
        Me.gp_details.Controls.Add(Me.rd_folder)
        Me.gp_details.Controls.Add(Me.txt_file)
        Me.gp_details.Controls.Add(Me.rd_file)
        Me.gp_details.Location = New System.Drawing.Point(294, 143)
        Me.gp_details.Name = "gp_details"
        Me.gp_details.Size = New System.Drawing.Size(325, 144)
        Me.gp_details.TabIndex = 13
        Me.gp_details.TabStop = False
        Me.gp_details.Text = "Program:"
        '
        'btn_path
        '
        Me.btn_path.Enabled = False
        Me.btn_path.Location = New System.Drawing.Point(235, 109)
        Me.btn_path.Name = "btn_path"
        Me.btn_path.Size = New System.Drawing.Size(75, 20)
        Me.btn_path.TabIndex = 17
        Me.btn_path.Text = "Get"
        Me.btn_path.UseVisualStyleBackColor = True
        '
        'txt_path
        '
        Me.txt_path.Enabled = False
        Me.txt_path.Location = New System.Drawing.Point(17, 110)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(212, 20)
        Me.txt_path.TabIndex = 16
        '
        'btn_file
        '
        Me.btn_file.Location = New System.Drawing.Point(235, 41)
        Me.btn_file.Name = "btn_file"
        Me.btn_file.Size = New System.Drawing.Size(75, 20)
        Me.btn_file.TabIndex = 15
        Me.btn_file.Text = "Get"
        Me.btn_file.UseVisualStyleBackColor = True
        '
        'rd_folder
        '
        Me.rd_folder.AutoSize = True
        Me.rd_folder.Location = New System.Drawing.Point(17, 87)
        Me.rd_folder.Name = "rd_folder"
        Me.rd_folder.Size = New System.Drawing.Size(74, 17)
        Me.rd_folder.TabIndex = 1
        Me.rd_folder.Text = "Is a Folder"
        Me.rd_folder.UseVisualStyleBackColor = True
        '
        'txt_file
        '
        Me.txt_file.Location = New System.Drawing.Point(17, 42)
        Me.txt_file.Name = "txt_file"
        Me.txt_file.Size = New System.Drawing.Size(212, 20)
        Me.txt_file.TabIndex = 14
        '
        'rd_file
        '
        Me.rd_file.AutoSize = True
        Me.rd_file.Checked = True
        Me.rd_file.Location = New System.Drawing.Point(17, 19)
        Me.rd_file.Name = "rd_file"
        Me.rd_file.Size = New System.Drawing.Size(61, 17)
        Me.rd_file.TabIndex = 0
        Me.rd_file.TabStop = True
        Me.rd_file.Text = "Is a File"
        Me.rd_file.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(6, 305)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 14
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(87, 305)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 15
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Title = "Open File"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 900
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btn_new.Location = New System.Drawing.Point(544, 305)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 16
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(463, 305)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'ch_plist
        '
        Me.ch_plist.AutoSize = True
        Me.ch_plist.Location = New System.Drawing.Point(295, 118)
        Me.ch_plist.Name = "ch_plist"
        Me.ch_plist.Size = New System.Drawing.Size(125, 17)
        Me.ch_plist.TabIndex = 18
        Me.ch_plist.Text = "Is a PlayList Changer"
        Me.ch_plist.UseVisualStyleBackColor = True
        '
        'gb_plist
        '
        Me.gb_plist.Controls.Add(Me.cmb_plistCh)
        Me.gb_plist.Controls.Add(Me.Label5)
        Me.gb_plist.Location = New System.Drawing.Point(294, 143)
        Me.gb_plist.Name = "gb_plist"
        Me.gb_plist.Size = New System.Drawing.Size(325, 81)
        Me.gb_plist.TabIndex = 18
        Me.gb_plist.TabStop = False
        Me.gb_plist.Text = "PlayList Changer"
        Me.gb_plist.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "PlayList:"
        '
        'cmb_plistCh
        '
        Me.cmb_plistCh.FormattingEnabled = True
        Me.cmb_plistCh.Location = New System.Drawing.Point(17, 37)
        Me.cmb_plistCh.Name = "cmb_plistCh"
        Me.cmb_plistCh.Size = New System.Drawing.Size(293, 21)
        Me.cmb_plistCh.TabIndex = 20
        '
        'frm_programs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 340)
        Me.Controls.Add(Me.gb_plist)
        Me.Controls.Add(Me.ch_plist)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.gp_details)
        Me.Controls.Add(Me.btn_get_intro)
        Me.Controls.Add(Me.txt_intro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ch)
        Me.Controls.Add(Me.nm_minute)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nm_hour)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lst_programs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "frm_programs"
        Me.Text = "Programs"
        CType(Me.nm_hour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nm_minute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_details.ResumeLayout(False)
        Me.gp_details.PerformLayout()
        Me.gb_plist.ResumeLayout(False)
        Me.gb_plist.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_programs As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nm_hour As System.Windows.Forms.NumericUpDown
    Friend WithEvents nm_minute As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ch As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_intro As System.Windows.Forms.TextBox
    Friend WithEvents btn_get_intro As System.Windows.Forms.Button
    Friend WithEvents gp_details As System.Windows.Forms.GroupBox
    Friend WithEvents btn_path As System.Windows.Forms.Button
    Friend WithEvents txt_path As System.Windows.Forms.TextBox
    Friend WithEvents btn_file As System.Windows.Forms.Button
    Friend WithEvents rd_folder As System.Windows.Forms.RadioButton
    Friend WithEvents txt_file As System.Windows.Forms.TextBox
    Friend WithEvents rd_file As System.Windows.Forms.RadioButton
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents ch_plist As System.Windows.Forms.CheckBox
    Friend WithEvents gb_plist As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_plistCh As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
