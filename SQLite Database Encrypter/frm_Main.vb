'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Imports System.Data.SQLite

Public Class frm_Main

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_FileName.Text = My.Settings.Filename
    End Sub
#End Region

#Region "Radio Button Events"
    Private Sub rb_SetPassword_CheckedChanged(sender As Object, e As EventArgs) Handles rb_SetPassword.CheckedChanged
        If rb_SetPassword.Checked Then
            Panel_OldPassword.Visible = False
            Panel_NewPassword.Visible = True
            Panel_ConfirmPassword.Visible = True
        End If
    End Sub

    Private Sub rb_ChangePassword_CheckedChanged(sender As Object, e As EventArgs) Handles rb_ChangePassword.CheckedChanged
        If rb_ChangePassword.Checked Then
            Panel_OldPassword.Visible = True
            Panel_NewPassword.Visible = True
            Panel_ConfirmPassword.Visible = True
        End If
    End Sub

    Private Sub rb_RemovePassword_CheckedChanged(sender As Object, e As EventArgs) Handles rb_RemovePassword.CheckedChanged
        If rb_RemovePassword.Checked Then
            Panel_OldPassword.Visible = True
            Panel_NewPassword.Visible = False
            Panel_ConfirmPassword.Visible = False
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        If dlg_Open.ShowDialog = DialogResult.OK Then
            txt_FileName.Text = dlg_Open.FileName
            My.Settings.Filename = dlg_Open.FileName
            My.Settings.Save()
        End If
    End Sub

    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
        If CheckFields() Then
            Try
                Dim ConnectionString As String = String.Format("Data Source={0};{1}", txt_FileName.Text, If(rb_ChangePassword.Checked Or rb_RemovePassword.Checked, String.Format("Password={0};", txt_OldPassword.Text), ""))
                Using Connection As New SQLiteConnection(ConnectionString)
                    Connection.Open()
                    If rb_SetPassword.Checked Or rb_ChangePassword.Checked Then
                        Connection.ChangePassword(txt_NewPassword.Text)
                    ElseIf rb_RemovePassword.Checked Then
                        Connection.ChangePassword("")
                    End If
                End Using
                MsgBox("Process Completed.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub
#End Region

#Region "Functions"
    Private Function CheckFields() As Boolean
        If rb_SetPassword.Checked Then
            If String.IsNullOrEmpty(txt_NewPassword.Text) Then
                MsgBox("'New Password' can't be empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Return False
            End If
            If String.IsNullOrEmpty(txt_ConfirmPassword.Text) Then
                MsgBox("'Confirm Password' can't be empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Return False
            End If
            If txt_NewPassword.Text = txt_ConfirmPassword.Text Then
                MsgBox("Passwords not matching.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Return False
            End If
        ElseIf rb_ChangePassword.Checked Then
            If String.IsNullOrEmpty(txt_OldPassword.Text) Then
                MsgBox("'Old Password' can't be empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Return False
            End If
            If String.IsNullOrEmpty(txt_NewPassword.Text) Then
                MsgBox("'New Password' can't be empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Return False
            End If
            If String.IsNullOrEmpty(txt_ConfirmPassword.Text) Then
                MsgBox("'Confirm Password' can't be empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Return False
            End If
            If txt_NewPassword.Text = txt_OldPassword.Text Then
                MsgBox("Passwords not matching.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Return False
            End If
        ElseIf rb_RemovePassword.Checked Then
            If String.IsNullOrEmpty(txt_OldPassword.Text) Then
                MsgBox("'Old Password' can't be empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Return False
            End If
        End If
        If Not My.Computer.FileSystem.FileExists(txt_FileName.Text) Then
            MsgBox("Given file doesn't exist.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        Return True
    End Function

    Private Sub cb_ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ShowPassword.CheckedChanged
        txt_OldPassword.UseSystemPasswordChar = Not cb_ShowPassword.Checked
        txt_NewPassword.UseSystemPasswordChar = Not cb_ShowPassword.Checked
        txt_ConfirmPassword.UseSystemPasswordChar = Not cb_ShowPassword.Checked
    End Sub
#End Region

End Class
