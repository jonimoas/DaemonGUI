<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents menu_unmount As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents menu_exit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents file As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents menu_en As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents menu_dis As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents emulation As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
	Public WithEvents Dir1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
	Public WithEvents Drive1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txtdrvno As System.Windows.Forms.TextBox
	Public WithEvents txtimgpath As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.file = New System.Windows.Forms.ToolStripMenuItem
		Me.menu_unmount = New System.Windows.Forms.ToolStripMenuItem
		Me.menu_exit = New System.Windows.Forms.ToolStripMenuItem
		Me.emulation = New System.Windows.Forms.ToolStripMenuItem
		Me.menu_en = New System.Windows.Forms.ToolStripMenuItem
		Me.menu_dis = New System.Windows.Forms.ToolStripMenuItem
		Me.Command5 = New System.Windows.Forms.Button
		Me.Command4 = New System.Windows.Forms.Button
		Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.Dir1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
		Me.Drive1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.txtdrvno = New System.Windows.Forms.TextBox
		Me.txtimgpath = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.MainMenu1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "DAEMON frontend by echo_03"
		Me.ClientSize = New System.Drawing.Size(560, 347)
		Me.Location = New System.Drawing.Point(379, 326)
		Me.ControlBox = False
		Me.Icon = CType(resources.GetObject("Form1.Icon"), System.Drawing.Icon)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("Form1.BackgroundImage"), System.Drawing.Image)
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form1"
		Me.file.Name = "file"
		Me.file.Text = "File"
		Me.file.Checked = False
		Me.file.Enabled = True
		Me.file.Visible = True
		Me.menu_unmount.Name = "menu_unmount"
		Me.menu_unmount.Text = "Unmount all drives"
		Me.menu_unmount.Checked = False
		Me.menu_unmount.Enabled = True
		Me.menu_unmount.Visible = True
		Me.menu_exit.Name = "menu_exit"
		Me.menu_exit.Text = "Exit"
		Me.menu_exit.Checked = False
		Me.menu_exit.Enabled = True
		Me.menu_exit.Visible = True
		Me.emulation.Name = "emulation"
		Me.emulation.Text = "Emulation"
		Me.emulation.Checked = False
		Me.emulation.Enabled = True
		Me.emulation.Visible = True
		Me.menu_en.Name = "menu_en"
		Me.menu_en.Text = "Enable all"
		Me.menu_en.Checked = False
		Me.menu_en.Enabled = True
		Me.menu_en.Visible = True
		Me.menu_dis.Name = "menu_dis"
		Me.menu_dis.Text = "Disable all"
		Me.menu_dis.Checked = False
		Me.menu_dis.Enabled = True
		Me.menu_dis.Visible = True
		Me.Command5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command5.Text = "next drive"
		Me.Command5.Size = New System.Drawing.Size(73, 25)
		Me.Command5.Location = New System.Drawing.Point(208, 88)
		Me.Command5.TabIndex = 11
		Me.Command5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.BackColor = System.Drawing.SystemColors.Control
		Me.Command5.CausesValidation = True
		Me.Command5.Enabled = True
		Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command5.TabStop = True
		Me.Command5.Name = "Command5"
		Me.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command4.Text = "previous drive"
		Me.Command4.Size = New System.Drawing.Size(73, 25)
		Me.Command4.Location = New System.Drawing.Point(128, 88)
		Me.Command4.TabIndex = 10
		Me.Command4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.BackColor = System.Drawing.SystemColors.Control
		Me.Command4.CausesValidation = True
		Me.Command4.Enabled = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.File1.Size = New System.Drawing.Size(369, 214)
		Me.File1.Location = New System.Drawing.Point(184, 128)
		Me.File1.TabIndex = 9
		Me.File1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.File1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.File1.Archive = True
		Me.File1.BackColor = System.Drawing.SystemColors.Window
		Me.File1.CausesValidation = True
		Me.File1.Enabled = True
		Me.File1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.File1.Hidden = False
		Me.File1.Cursor = System.Windows.Forms.Cursors.Default
		Me.File1.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.File1.Normal = True
		Me.File1.Pattern = "*.*"
		Me.File1.ReadOnly = True
		Me.File1.System = False
		Me.File1.TabStop = True
		Me.File1.TopIndex = 0
		Me.File1.Visible = True
		Me.File1.Name = "File1"
		Me.Dir1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Dir1.Size = New System.Drawing.Size(153, 201)
		Me.Dir1.Location = New System.Drawing.Point(8, 144)
		Me.Dir1.TabIndex = 8
		Me.Dir1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Dir1.BackColor = System.Drawing.SystemColors.Window
		Me.Dir1.CausesValidation = True
		Me.Dir1.Enabled = True
		Me.Dir1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Dir1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Dir1.TabStop = True
		Me.Dir1.Visible = True
		Me.Dir1.Name = "Dir1"
		Me.Drive1.Size = New System.Drawing.Size(153, 21)
		Me.Drive1.Location = New System.Drawing.Point(8, 120)
		Me.Drive1.TabIndex = 7
		Me.Drive1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Drive1.BackColor = System.Drawing.SystemColors.Window
		Me.Drive1.CausesValidation = True
		Me.Drive1.Enabled = True
		Me.Drive1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Drive1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Drive1.TabStop = True
		Me.Drive1.Visible = True
		Me.Drive1.Name = "Drive1"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(41, 33)
		Me.Text1.Location = New System.Drawing.Point(8, 400)
		Me.Text1.TabIndex = 6
		Me.Text1.Text = """"
		Me.Text1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "unmount"
		Me.Command2.Size = New System.Drawing.Size(73, 25)
		Me.Command2.Location = New System.Drawing.Point(416, 88)
		Me.Command2.TabIndex = 5
		Me.Command2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "mount"
		Me.Command1.Size = New System.Drawing.Size(73, 25)
		Me.Command1.Location = New System.Drawing.Point(336, 88)
		Me.Command1.TabIndex = 4
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.txtdrvno.AutoSize = False
		Me.txtdrvno.Size = New System.Drawing.Size(33, 25)
		Me.txtdrvno.Location = New System.Drawing.Point(80, 88)
		Me.txtdrvno.Maxlength = 1
		Me.txtdrvno.TabIndex = 2
		Me.txtdrvno.Text = "0"
		Me.txtdrvno.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtdrvno.AcceptsReturn = True
		Me.txtdrvno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtdrvno.BackColor = System.Drawing.SystemColors.Window
		Me.txtdrvno.CausesValidation = True
		Me.txtdrvno.Enabled = True
		Me.txtdrvno.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtdrvno.HideSelection = True
		Me.txtdrvno.ReadOnly = False
		Me.txtdrvno.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtdrvno.MultiLine = False
		Me.txtdrvno.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtdrvno.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtdrvno.TabStop = True
		Me.txtdrvno.Visible = True
		Me.txtdrvno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtdrvno.Name = "txtdrvno"
		Me.txtimgpath.AutoSize = False
		Me.txtimgpath.Size = New System.Drawing.Size(553, 25)
		Me.txtimgpath.Location = New System.Drawing.Point(8, 56)
		Me.txtimgpath.TabIndex = 1
		Me.txtimgpath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtimgpath.AcceptsReturn = True
		Me.txtimgpath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtimgpath.BackColor = System.Drawing.SystemColors.Window
		Me.txtimgpath.CausesValidation = True
		Me.txtimgpath.Enabled = True
		Me.txtimgpath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtimgpath.HideSelection = True
		Me.txtimgpath.ReadOnly = False
		Me.txtimgpath.Maxlength = 0
		Me.txtimgpath.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtimgpath.MultiLine = False
		Me.txtimgpath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtimgpath.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtimgpath.TabStop = True
		Me.txtimgpath.Visible = True
		Me.txtimgpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtimgpath.Name = "txtimgpath"
		Me.Label3.Text = "drive number"
		Me.Label3.Size = New System.Drawing.Size(73, 25)
		Me.Label3.Location = New System.Drawing.Point(8, 88)
		Me.Label3.TabIndex = 3
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.BackColor = System.Drawing.SystemColors.Window
		Me.Label2.Text = "image path and name"
		Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Label2.Size = New System.Drawing.Size(145, 25)
		Me.Label2.Location = New System.Drawing.Point(8, 32)
		Me.Label2.TabIndex = 0
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Controls.Add(Command5)
		Me.Controls.Add(Command4)
		Me.Controls.Add(File1)
		Me.Controls.Add(Dir1)
		Me.Controls.Add(Drive1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(txtdrvno)
		Me.Controls.Add(txtimgpath)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.file, Me.emulation})
		file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.menu_unmount, Me.menu_exit})
		emulation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.menu_en, Me.menu_dis})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class