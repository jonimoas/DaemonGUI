Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
	Dim nfile As Short
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Kill("batch.bat")
		nfile = FreeFile
		FileOpen(nfile, CurDir() & "\batch.BAT", OpenMode.Append)
		PrintLine(nfile, "daemon.exe " & "-mount " & txtdrvno.Text & "," & Text1.Text & txtimgpath.Text & Text1.Text)
		FileClose(nfile)
		Shell("batch.bat")
	End Sub
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Kill("batch.bat")
		nfile = FreeFile
		FileOpen(nfile, CurDir() & "\batch.BAT", OpenMode.Append)
		PrintLine(nfile, "daemon.exe " & "-unmount " & txtdrvno.Text)
		FileClose(nfile)
		Shell("batch.bat")
	End Sub
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		On Error GoTo lol
		If CDbl(txtdrvno.Text) = 0 Then
			txtdrvno.Text = CStr(0)
		Else
			txtdrvno.Text = CStr(CDbl(txtdrvno.Text) - 1)
		End If
		Exit Sub
lol: 
	End Sub
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		On Error GoTo rr
		If CDbl(txtdrvno.Text) = 3 Then
			txtdrvno.Text = CStr(3)
		Else
			txtdrvno.Text = CStr(CDbl(txtdrvno.Text) + 1)
		End If
		Exit Sub
rr: 
		txtdrvno.Text = CStr(0)
	End Sub
	Private Sub Dir1_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dir1.Change
		File1.Path = Dir1.Path
	End Sub
	Private Sub Drive1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Drive1.SelectedIndexChanged
		Dir1.Path = Drive1.Drive
	End Sub
	Private Sub File1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles File1.SelectedIndexChanged
		txtimgpath.Text = Dir1.Path & "\" & File1.FileName
	End Sub
	Public Sub menu_dis_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menu_dis.Click
		Kill("batch.bat")
		nfile = FreeFile
		FileOpen(nfile, CurDir() & "\batch.BAT", OpenMode.Append)
		PrintLine(nfile, "daemon.exe -safedisc off" & vbNewLine & "daemon.exe -securom off" & vbNewLine & "daemon.exe -laserlok off" & vbNewLine & "daemon.exe -rmps off")
		FileClose(nfile)
		Shell("batch.bat")
	End Sub
	Public Sub menu_en_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menu_en.Click
		Kill("batch.bat")
		nfile = FreeFile
		FileOpen(nfile, CurDir() & "\batch.BAT", OpenMode.Append)
		PrintLine(nfile, "daemon.exe -safedisc on" & vbNewLine & "daemon.exe -securom on" & vbNewLine & "daemon.exe -laserlok on" & vbNewLine & "daemon.exe -rmps on")
		FileClose(nfile)
		Shell("batch.bat")
	End Sub
	Public Sub menu_exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menu_exit.Click
		Kill("batch.bat")
		nfile = FreeFile
		FileOpen(nfile, CurDir() & "\batch.BAT", OpenMode.Append)
		PrintLine(nfile, "empty batch file used for command execution of the front end, do not delete it")
		FileClose(nfile)
		End
	End Sub
	Public Sub menu_unmount_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menu_unmount.Click
		Kill("batch.bat")
		nfile = FreeFile
		FileOpen(nfile, CurDir() & "\batch.BAT", OpenMode.Append)
		PrintLine(nfile, "daemon.exe " & "-unmount 0" & vbNewLine & "daemon.exe " & "-unmount 1" & vbNewLine & "daemon.exe " & "-unmount 2" & vbNewLine & "daemon.exe " & "-unmount 0")
		FileClose(nfile)
		Shell("batch.bat")
	End Sub
End Class