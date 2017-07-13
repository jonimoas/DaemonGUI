VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "DAEMON frontend by echo_03"
   ClientHeight    =   4845
   ClientLeft      =   5685
   ClientTop       =   4890
   ClientWidth     =   8400
   ControlBox      =   0   'False
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   Picture         =   "Form1.frx":014A
   ScaleHeight     =   4845
   ScaleWidth      =   8400
   Begin VB.CommandButton Command5 
      Caption         =   "next drive"
      Height          =   375
      Left            =   3120
      TabIndex        =   11
      Top             =   960
      Width           =   1095
   End
   Begin VB.CommandButton Command4 
      Caption         =   "previous drive"
      Height          =   375
      Left            =   1920
      TabIndex        =   10
      Top             =   960
      Width           =   1095
   End
   Begin VB.FileListBox File1 
      Height          =   3210
      Left            =   2760
      TabIndex        =   9
      Top             =   1560
      Width           =   5535
   End
   Begin VB.DirListBox Dir1 
      Appearance      =   0  'Flat
      Height          =   3015
      Left            =   120
      TabIndex        =   8
      Top             =   1800
      Width           =   2295
   End
   Begin VB.DriveListBox Drive1 
      Appearance      =   0  'Flat
      Height          =   315
      Left            =   120
      TabIndex        =   7
      Top             =   1440
      Width           =   2295
   End
   Begin VB.TextBox Text1 
      Height          =   495
      Left            =   120
      TabIndex        =   6
      Text            =   """"
      Top             =   5640
      Width           =   615
   End
   Begin VB.CommandButton Command2 
      Caption         =   "unmount"
      Height          =   375
      Left            =   6240
      TabIndex        =   5
      Top             =   960
      Width           =   1095
   End
   Begin VB.CommandButton Command1 
      Caption         =   "mount"
      Height          =   375
      Left            =   5040
      TabIndex        =   4
      Top             =   960
      Width           =   1095
   End
   Begin VB.TextBox txtdrvno 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1032
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Left            =   1200
      MaxLength       =   1
      TabIndex        =   2
      Text            =   "0"
      Top             =   960
      Width           =   495
   End
   Begin VB.TextBox txtimgpath 
      Appearance      =   0  'Flat
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   480
      Width           =   8295
   End
   Begin VB.Label Label3 
      Caption         =   "drive number"
      Height          =   375
      Left            =   120
      TabIndex        =   3
      Top             =   960
      Width           =   1095
   End
   Begin VB.Label Label2 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      Caption         =   "image path and name"
      ForeColor       =   &H80000008&
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2175
   End
   Begin VB.Menu file 
      Caption         =   "File"
      Begin VB.Menu menu_unmount 
         Caption         =   "Unmount all drives"
      End
      Begin VB.Menu menu_exit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu emulation 
      Caption         =   "Emulation"
      Begin VB.Menu menu_en 
         Caption         =   "Enable all"
      End
      Begin VB.Menu menu_dis 
         Caption         =   "Disable all"
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim nfile As Integer
Private Sub Command1_Click()
Kill "batch.bat"
nfile = FreeFile
Open CurDir + "\batch.BAT" For Append As nfile
Print #nfile, "daemon.exe " + "-mount " + txtdrvno.Text + "," + Text1.Text + txtimgpath.Text + Text1.Text
Close #nfile
Shell "batch.bat"
End Sub
Private Sub Command2_Click()
Kill "batch.bat"
nfile = FreeFile
Open CurDir + "\batch.BAT" For Append As nfile
Print #nfile, "daemon.exe " + "-unmount " + txtdrvno.Text
Close #nfile
Shell "batch.bat"
End Sub
Private Sub Command4_Click()
On Error GoTo lol
If txtdrvno.Text = 0 Then
    txtdrvno.Text = 0
    Else
    txtdrvno.Text = txtdrvno.Text - 1
End If
Exit Sub
lol:
End Sub
Private Sub Command5_Click()
On Error GoTo rr
If txtdrvno.Text = 3 Then
    txtdrvno.Text = 3
    Else
    txtdrvno.Text = txtdrvno.Text + 1
End If
Exit Sub
rr:
txtdrvno.Text = 0
End Sub
Private Sub Dir1_Change()
File1.Path = Dir1.Path
End Sub
Private Sub Drive1_Change()
Dir1.Path = Drive1.Drive
End Sub
Private Sub File1_Click()
txtimgpath.Text = Dir1.Path + "\" + File1.FileName
End Sub
Private Sub menu_dis_Click()
Kill "batch.bat"
nfile = FreeFile
Open CurDir + "\batch.BAT" For Append As nfile
Print #nfile, "daemon.exe -safedisc off" + vbNewLine + "daemon.exe -securom off" + vbNewLine + "daemon.exe -laserlok off" + vbNewLine + "daemon.exe -rmps off"
Close #nfile
Shell "batch.bat"
End Sub
Private Sub menu_en_Click()
Kill "batch.bat"
nfile = FreeFile
Open CurDir + "\batch.BAT" For Append As nfile
Print #nfile, "daemon.exe -safedisc on" + vbNewLine + "daemon.exe -securom on" + vbNewLine + "daemon.exe -laserlok on" + vbNewLine + "daemon.exe -rmps on"
Close #nfile
Shell "batch.bat"
End Sub
Private Sub menu_exit_Click()
Kill "batch.bat"
nfile = FreeFile
Open CurDir + "\batch.BAT" For Append As nfile
Print #nfile, "empty batch file used for command execution of the front end, do not delete it"
Close #nfile
End
End Sub
Private Sub menu_unmount_Click()
Kill "batch.bat"
nfile = FreeFile
Open CurDir + "\batch.BAT" For Append As nfile
Print #nfile, "daemon.exe " + "-unmount 0" + vbNewLine + "daemon.exe " + "-unmount 1" + vbNewLine + "daemon.exe " + "-unmount 2" + vbNewLine + "daemon.exe " + "-unmount 0"
Close #nfile
Shell "batch.bat"
End Sub
