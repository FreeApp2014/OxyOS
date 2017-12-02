<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TaskBar6 = New System.Windows.Forms.Button()
        Me.TaskBar5 = New System.Windows.Forms.Button()
        Me.TaskBar4 = New System.Windows.Forms.Button()
        Me.TaskBar3 = New System.Windows.Forms.Button()
        Me.TaskBar2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TaskBar1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuBGTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TitleUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShortcutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OxyWriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OxyPicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.TaskBar6)
        Me.Panel1.Controls.Add(Me.TaskBar5)
        Me.Panel1.Controls.Add(Me.TaskBar4)
        Me.Panel1.Controls.Add(Me.TaskBar3)
        Me.Panel1.Controls.Add(Me.TaskBar2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.TaskBar1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 693)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 40)
        Me.Panel1.TabIndex = 0
        '
        'TaskBar6
        '
        Me.TaskBar6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TaskBar6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskBar6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaskBar6.Location = New System.Drawing.Point(331, 1)
        Me.TaskBar6.Name = "TaskBar6"
        Me.TaskBar6.Size = New System.Drawing.Size(39, 39)
        Me.TaskBar6.TabIndex = 7
        Me.TaskBar6.UseVisualStyleBackColor = True
        Me.TaskBar6.Visible = False
        '
        'TaskBar5
        '
        Me.TaskBar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TaskBar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskBar5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaskBar5.Location = New System.Drawing.Point(286, 1)
        Me.TaskBar5.Name = "TaskBar5"
        Me.TaskBar5.Size = New System.Drawing.Size(39, 39)
        Me.TaskBar5.TabIndex = 6
        Me.TaskBar5.UseVisualStyleBackColor = True
        Me.TaskBar5.Visible = False
        '
        'TaskBar4
        '
        Me.TaskBar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TaskBar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskBar4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaskBar4.Location = New System.Drawing.Point(241, 1)
        Me.TaskBar4.Name = "TaskBar4"
        Me.TaskBar4.Size = New System.Drawing.Size(39, 39)
        Me.TaskBar4.TabIndex = 5
        Me.TaskBar4.UseVisualStyleBackColor = True
        Me.TaskBar4.Visible = False
        '
        'TaskBar3
        '
        Me.TaskBar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TaskBar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskBar3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaskBar3.Location = New System.Drawing.Point(196, 1)
        Me.TaskBar3.Name = "TaskBar3"
        Me.TaskBar3.Size = New System.Drawing.Size(39, 39)
        Me.TaskBar3.TabIndex = 4
        Me.TaskBar3.UseVisualStyleBackColor = True
        Me.TaskBar3.Visible = False
        '
        'TaskBar2
        '
        Me.TaskBar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TaskBar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskBar2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaskBar2.Location = New System.Drawing.Point(151, 1)
        Me.TaskBar2.Name = "TaskBar2"
        Me.TaskBar2.Size = New System.Drawing.Size(39, 39)
        Me.TaskBar2.TabIndex = 3
        Me.TaskBar2.UseVisualStyleBackColor = True
        Me.TaskBar2.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel5.Location = New System.Drawing.Point(96, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 40)
        Me.Panel5.TabIndex = 2
        '
        'TaskBar1
        '
        Me.TaskBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TaskBar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskBar1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaskBar1.Location = New System.Drawing.Point(106, 1)
        Me.TaskBar1.Name = "TaskBar1"
        Me.TaskBar1.Size = New System.Drawing.Size(39, 39)
        Me.TaskBar1.TabIndex = 1
        Me.TaskBar1.UseVisualStyleBackColor = True
        Me.TaskBar1.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(1, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1354, 18)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LightCyan
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(1157, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(197, 18)
        Me.Panel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OxyOS Desktop"
        '
        'MenuBGTimer
        '
        Me.MenuBGTimer.Interval = 13
        '
        'TimeUpdater
        '
        Me.TimeUpdater.Enabled = True
        Me.TimeUpdater.Interval = 500
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(17, 12)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.MonthCalendar1)
        Me.Panel4.Location = New System.Drawing.Point(1157, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(205, 186)
        Me.Panel4.TabIndex = 3
        Me.Panel4.Visible = False
        '
        'TitleUpdater
        '
        Me.TitleUpdater.Enabled = True
        Me.TitleUpdater.Interval = 500
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShortcutsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 26)
        '
        'ShortcutsToolStripMenuItem
        '
        Me.ShortcutsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileManagerToolStripMenuItem, Me.OxyWriteToolStripMenuItem, Me.OxyPicToolStripMenuItem, Me.TerminalToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ShortcutsToolStripMenuItem.Name = "ShortcutsToolStripMenuItem"
        Me.ShortcutsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ShortcutsToolStripMenuItem.Text = "Shortcuts"
        '
        'FileManagerToolStripMenuItem
        '
        Me.FileManagerToolStripMenuItem.CheckOnClick = True
        Me.FileManagerToolStripMenuItem.Name = "FileManagerToolStripMenuItem"
        Me.FileManagerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.FileManagerToolStripMenuItem.Text = "File Manager"
        '
        'OxyWriteToolStripMenuItem
        '
        Me.OxyWriteToolStripMenuItem.CheckOnClick = True
        Me.OxyWriteToolStripMenuItem.Name = "OxyWriteToolStripMenuItem"
        Me.OxyWriteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OxyWriteToolStripMenuItem.Text = "OxyWrite"
        '
        'OxyPicToolStripMenuItem
        '
        Me.OxyPicToolStripMenuItem.CheckOnClick = True
        Me.OxyPicToolStripMenuItem.Name = "OxyPicToolStripMenuItem"
        Me.OxyPicToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OxyPicToolStripMenuItem.Text = "OxyPic"
        '
        'TerminalToolStripMenuItem
        '
        Me.TerminalToolStripMenuItem.Name = "TerminalToolStripMenuItem"
        Me.TerminalToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TerminalToolStripMenuItem.Text = "Terminal"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OxyOS.My.Resources.Resources.CloudWallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Desktop"
        Me.Text = "Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuBGTimer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents TimeUpdater As Timer
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TitleUpdater As Timer
    Friend WithEvents TaskBar6 As Button
    Friend WithEvents TaskBar5 As Button
    Friend WithEvents TaskBar4 As Button
    Friend WithEvents TaskBar3 As Button
    Friend WithEvents TaskBar2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TaskBar1 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShortcutsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OxyWriteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OxyPicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerminalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
