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

Public Class frm_Main

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
            Panel_OldPassword.Visible = False
            Panel_NewPassword.Visible = False
            Panel_ConfirmPassword.Visible = False
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        If dlg_Open.ShowDialog = DialogResult.OK Then
            txt_FileName.Text = dlg_Open.FileName
        End If
    End Sub
#End Region

End Class
