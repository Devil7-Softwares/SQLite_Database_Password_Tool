<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.rb_SetPassword = New System.Windows.Forms.RadioButton()
        Me.rb_ChangePassword = New System.Windows.Forms.RadioButton()
        Me.rb_RemovePassword = New System.Windows.Forms.RadioButton()
        Me.lbl_Filename = New System.Windows.Forms.Label()
        Me.txt_FileName = New System.Windows.Forms.TextBox()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.btn_Ok = New System.Windows.Forms.Button()
        Me.table_Options = New System.Windows.Forms.TableLayoutPanel()
        Me.table_Password = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_ConfirmPassword = New System.Windows.Forms.Panel()
        Me.txt_ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lbl_ConfirmPassword = New System.Windows.Forms.Label()
        Me.Panel_NewPassword = New System.Windows.Forms.Panel()
        Me.txt_NewPassword = New System.Windows.Forms.TextBox()
        Me.lbl_NewPassword = New System.Windows.Forms.Label()
        Me.Panel_OldPassword = New System.Windows.Forms.Panel()
        Me.txt_OldPassword = New System.Windows.Forms.TextBox()
        Me.lbl_OldPassword = New System.Windows.Forms.Label()
        Me.dlg_Open = New System.Windows.Forms.OpenFileDialog()
        Me.cb_ShowPassword = New System.Windows.Forms.CheckBox()
        Me.table_Options.SuspendLayout()
        Me.table_Password.SuspendLayout()
        Me.Panel_ConfirmPassword.SuspendLayout()
        Me.Panel_NewPassword.SuspendLayout()
        Me.Panel_OldPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'rb_SetPassword
        '
        Me.rb_SetPassword.AutoSize = True
        Me.rb_SetPassword.Checked = True
        Me.rb_SetPassword.Location = New System.Drawing.Point(3, 3)
        Me.rb_SetPassword.Name = "rb_SetPassword"
        Me.rb_SetPassword.Size = New System.Drawing.Size(90, 17)
        Me.rb_SetPassword.TabIndex = 0
        Me.rb_SetPassword.TabStop = True
        Me.rb_SetPassword.Text = "Set Password"
        Me.rb_SetPassword.UseVisualStyleBackColor = True
        '
        'rb_ChangePassword
        '
        Me.rb_ChangePassword.AutoSize = True
        Me.rb_ChangePassword.Location = New System.Drawing.Point(127, 3)
        Me.rb_ChangePassword.Name = "rb_ChangePassword"
        Me.rb_ChangePassword.Size = New System.Drawing.Size(111, 17)
        Me.rb_ChangePassword.TabIndex = 1
        Me.rb_ChangePassword.Text = "Change Password"
        Me.rb_ChangePassword.UseVisualStyleBackColor = True
        '
        'rb_RemovePassword
        '
        Me.rb_RemovePassword.AutoSize = True
        Me.rb_RemovePassword.Location = New System.Drawing.Point(251, 3)
        Me.rb_RemovePassword.Name = "rb_RemovePassword"
        Me.rb_RemovePassword.Size = New System.Drawing.Size(114, 17)
        Me.rb_RemovePassword.TabIndex = 2
        Me.rb_RemovePassword.Text = "Remove Password"
        Me.rb_RemovePassword.UseVisualStyleBackColor = True
        '
        'lbl_Filename
        '
        Me.lbl_Filename.AutoSize = True
        Me.lbl_Filename.Location = New System.Drawing.Point(60, 47)
        Me.lbl_Filename.Name = "lbl_Filename"
        Me.lbl_Filename.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Filename.TabIndex = 3
        Me.lbl_Filename.Text = "Filename :"
        '
        'txt_FileName
        '
        Me.txt_FileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FileName.Location = New System.Drawing.Point(121, 44)
        Me.txt_FileName.Name = "txt_FileName"
        Me.txt_FileName.Size = New System.Drawing.Size(372, 20)
        Me.txt_FileName.TabIndex = 4
        '
        'btn_Browse
        '
        Me.btn_Browse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Browse.Location = New System.Drawing.Point(499, 43)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(26, 23)
        Me.btn_Browse.TabIndex = 5
        Me.btn_Browse.Text = "..."
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'btn_Ok
        '
        Me.btn_Ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Ok.Location = New System.Drawing.Point(450, 173)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_Ok.TabIndex = 6
        Me.btn_Ok.Text = "OK"
        Me.btn_Ok.UseVisualStyleBackColor = True
        '
        'table_Options
        '
        Me.table_Options.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.table_Options.ColumnCount = 3
        Me.table_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_Options.Controls.Add(Me.rb_SetPassword, 0, 0)
        Me.table_Options.Controls.Add(Me.rb_ChangePassword, 1, 0)
        Me.table_Options.Controls.Add(Me.rb_RemovePassword, 2, 0)
        Me.table_Options.Location = New System.Drawing.Point(121, 12)
        Me.table_Options.Name = "table_Options"
        Me.table_Options.RowCount = 1
        Me.table_Options.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_Options.Size = New System.Drawing.Size(372, 26)
        Me.table_Options.TabIndex = 7
        '
        'table_Password
        '
        Me.table_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.table_Password.ColumnCount = 1
        Me.table_Password.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_Password.Controls.Add(Me.Panel_ConfirmPassword, 0, 2)
        Me.table_Password.Controls.Add(Me.Panel_NewPassword, 0, 1)
        Me.table_Password.Controls.Add(Me.Panel_OldPassword, 0, 0)
        Me.table_Password.Location = New System.Drawing.Point(12, 70)
        Me.table_Password.Name = "table_Password"
        Me.table_Password.RowCount = 3
        Me.table_Password.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Password.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Password.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Password.Size = New System.Drawing.Size(521, 96)
        Me.table_Password.TabIndex = 8
        '
        'Panel_ConfirmPassword
        '
        Me.Panel_ConfirmPassword.AutoSize = True
        Me.Panel_ConfirmPassword.Controls.Add(Me.txt_ConfirmPassword)
        Me.Panel_ConfirmPassword.Controls.Add(Me.lbl_ConfirmPassword)
        Me.Panel_ConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ConfirmPassword.Location = New System.Drawing.Point(3, 67)
        Me.Panel_ConfirmPassword.Name = "Panel_ConfirmPassword"
        Me.Panel_ConfirmPassword.Size = New System.Drawing.Size(515, 26)
        Me.Panel_ConfirmPassword.TabIndex = 11
        '
        'txt_ConfirmPassword
        '
        Me.txt_ConfirmPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ConfirmPassword.Location = New System.Drawing.Point(106, 3)
        Me.txt_ConfirmPassword.Name = "txt_ConfirmPassword"
        Me.txt_ConfirmPassword.Size = New System.Drawing.Size(404, 20)
        Me.txt_ConfirmPassword.TabIndex = 10
        Me.txt_ConfirmPassword.UseSystemPasswordChar = True
        '
        'lbl_ConfirmPassword
        '
        Me.lbl_ConfirmPassword.AutoSize = True
        Me.lbl_ConfirmPassword.Location = New System.Drawing.Point(3, 6)
        Me.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword"
        Me.lbl_ConfirmPassword.Size = New System.Drawing.Size(97, 13)
        Me.lbl_ConfirmPassword.TabIndex = 9
        Me.lbl_ConfirmPassword.Text = "Confirm Password :"
        '
        'Panel_NewPassword
        '
        Me.Panel_NewPassword.AutoSize = True
        Me.Panel_NewPassword.Controls.Add(Me.txt_NewPassword)
        Me.Panel_NewPassword.Controls.Add(Me.lbl_NewPassword)
        Me.Panel_NewPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_NewPassword.Location = New System.Drawing.Point(3, 35)
        Me.Panel_NewPassword.Name = "Panel_NewPassword"
        Me.Panel_NewPassword.Size = New System.Drawing.Size(515, 26)
        Me.Panel_NewPassword.TabIndex = 10
        '
        'txt_NewPassword
        '
        Me.txt_NewPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_NewPassword.Location = New System.Drawing.Point(106, 3)
        Me.txt_NewPassword.Name = "txt_NewPassword"
        Me.txt_NewPassword.Size = New System.Drawing.Size(404, 20)
        Me.txt_NewPassword.TabIndex = 10
        Me.txt_NewPassword.UseSystemPasswordChar = True
        '
        'lbl_NewPassword
        '
        Me.lbl_NewPassword.AutoSize = True
        Me.lbl_NewPassword.Location = New System.Drawing.Point(16, 6)
        Me.lbl_NewPassword.Name = "lbl_NewPassword"
        Me.lbl_NewPassword.Size = New System.Drawing.Size(84, 13)
        Me.lbl_NewPassword.TabIndex = 9
        Me.lbl_NewPassword.Text = "New Password :"
        '
        'Panel_OldPassword
        '
        Me.Panel_OldPassword.AutoSize = True
        Me.Panel_OldPassword.Controls.Add(Me.txt_OldPassword)
        Me.Panel_OldPassword.Controls.Add(Me.lbl_OldPassword)
        Me.Panel_OldPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_OldPassword.Location = New System.Drawing.Point(3, 3)
        Me.Panel_OldPassword.Name = "Panel_OldPassword"
        Me.Panel_OldPassword.Size = New System.Drawing.Size(515, 26)
        Me.Panel_OldPassword.TabIndex = 9
        Me.Panel_OldPassword.Visible = False
        '
        'txt_OldPassword
        '
        Me.txt_OldPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_OldPassword.Location = New System.Drawing.Point(106, 3)
        Me.txt_OldPassword.Name = "txt_OldPassword"
        Me.txt_OldPassword.Size = New System.Drawing.Size(404, 20)
        Me.txt_OldPassword.TabIndex = 10
        Me.txt_OldPassword.UseSystemPasswordChar = True
        '
        'lbl_OldPassword
        '
        Me.lbl_OldPassword.AutoSize = True
        Me.lbl_OldPassword.Location = New System.Drawing.Point(22, 6)
        Me.lbl_OldPassword.Name = "lbl_OldPassword"
        Me.lbl_OldPassword.Size = New System.Drawing.Size(78, 13)
        Me.lbl_OldPassword.TabIndex = 9
        Me.lbl_OldPassword.Text = "Old Password :"
        '
        'dlg_Open
        '
        Me.dlg_Open.Filter = "SQLite Database Files (*.db,*.sqlite,*.db3,*.sqlite3)|*.db;*.sqlite;*.db3;*.sqlit" &
    "e3|All Files|*"
        Me.dlg_Open.FilterIndex = 0
        '
        'cb_ShowPassword
        '
        Me.cb_ShowPassword.AutoSize = True
        Me.cb_ShowPassword.Location = New System.Drawing.Point(12, 177)
        Me.cb_ShowPassword.Name = "cb_ShowPassword"
        Me.cb_ShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.cb_ShowPassword.TabIndex = 9
        Me.cb_ShowPassword.Text = "Show Password"
        Me.cb_ShowPassword.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 208)
        Me.Controls.Add(Me.cb_ShowPassword)
        Me.Controls.Add(Me.table_Password)
        Me.Controls.Add(Me.table_Options)
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.txt_FileName)
        Me.Controls.Add(Me.lbl_Filename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQLite Database Encrypter"
        Me.table_Options.ResumeLayout(False)
        Me.table_Options.PerformLayout()
        Me.table_Password.ResumeLayout(False)
        Me.table_Password.PerformLayout()
        Me.Panel_ConfirmPassword.ResumeLayout(False)
        Me.Panel_ConfirmPassword.PerformLayout()
        Me.Panel_NewPassword.ResumeLayout(False)
        Me.Panel_NewPassword.PerformLayout()
        Me.Panel_OldPassword.ResumeLayout(False)
        Me.Panel_OldPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rb_SetPassword As RadioButton
    Friend WithEvents rb_ChangePassword As RadioButton
    Friend WithEvents rb_RemovePassword As RadioButton
    Friend WithEvents lbl_Filename As Label
    Friend WithEvents txt_FileName As TextBox
    Friend WithEvents btn_Browse As Button
    Friend WithEvents btn_Ok As Button
    Friend WithEvents table_Options As TableLayoutPanel
    Friend WithEvents table_Password As TableLayoutPanel
    Friend WithEvents Panel_OldPassword As Panel
    Friend WithEvents lbl_OldPassword As Label
    Friend WithEvents Panel_ConfirmPassword As Panel
    Friend WithEvents txt_ConfirmPassword As TextBox
    Friend WithEvents lbl_ConfirmPassword As Label
    Friend WithEvents Panel_NewPassword As Panel
    Friend WithEvents txt_NewPassword As TextBox
    Friend WithEvents lbl_NewPassword As Label
    Friend WithEvents txt_OldPassword As TextBox
    Friend WithEvents dlg_Open As OpenFileDialog
    Friend WithEvents cb_ShowPassword As CheckBox
End Class
