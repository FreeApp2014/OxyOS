﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PV_LoadUrl
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 30)
        Me.Panel3.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(214, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Load from URL"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel6.Location = New System.Drawing.Point(12, 91)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(218, 2)
        Me.Panel6.TabIndex = 25
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox4.Location = New System.Drawing.Point(12, 71)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(218, 20)
        Me.TextBox4.TabIndex = 24
        Me.TextBox4.Text = "URL"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(78, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(8, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "URL"
        Me.Label6.Visible = False
        '
        'PV_LoadUrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 143)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PV_LoadUrl"
        Me.Text = "PV_LoadUrl"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
End Class
