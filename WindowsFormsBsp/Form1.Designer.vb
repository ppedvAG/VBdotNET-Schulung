<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WndMain
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
        Me.BtnKlickMich = New System.Windows.Forms.Button()
        Me.CbbAuswahl = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChbPruefung = New System.Windows.Forms.CheckBox()
        Me.ClbBeispiel = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnKlickMich
        '
        Me.BtnKlickMich.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnKlickMich.Location = New System.Drawing.Point(63, 51)
        Me.BtnKlickMich.Name = "BtnKlickMich"
        Me.BtnKlickMich.Size = New System.Drawing.Size(75, 48)
        Me.BtnKlickMich.TabIndex = 0
        Me.BtnKlickMich.Text = "Klick Mich"
        Me.BtnKlickMich.UseVisualStyleBackColor = True
        '
        'CbbAuswahl
        '
        Me.CbbAuswahl.FormattingEnabled = True
        Me.CbbAuswahl.Items.AddRange(New Object() {"Eintrag1", "Auswahl2", "Item3"})
        Me.CbbAuswahl.Location = New System.Drawing.Point(24, 121)
        Me.CbbAuswahl.Name = "CbbAuswahl"
        Me.CbbAuswahl.Size = New System.Drawing.Size(198, 21)
        Me.CbbAuswahl.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(24, 148)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(172, 82)
        Me.ListBox1.TabIndex = 2
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(27, 66)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(280, 355)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(27, 43)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(280, 332)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(266, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 127)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ChbPruefung
        '
        Me.ChbPruefung.AutoSize = True
        Me.ChbPruefung.Checked = True
        Me.ChbPruefung.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ChbPruefung.Location = New System.Drawing.Point(240, 65)
        Me.ChbPruefung.Name = "ChbPruefung"
        Me.ChbPruefung.Size = New System.Drawing.Size(81, 17)
        Me.ChbPruefung.TabIndex = 8
        Me.ChbPruefung.Text = "CheckBox1"
        Me.ChbPruefung.UseVisualStyleBackColor = True
        '
        'ClbBeispiel
        '
        Me.ClbBeispiel.FormattingEnabled = True
        Me.ClbBeispiel.Items.AddRange(New Object() {"Eintrag1", "Eintrag2"})
        Me.ClbBeispiel.Location = New System.Drawing.Point(28, 269)
        Me.ClbBeispiel.Name = "ClbBeispiel"
        Me.ClbBeispiel.Size = New System.Drawing.Size(167, 139)
        Me.ClbBeispiel.TabIndex = 9
        '
        'WndMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 450)
        Me.Controls.Add(Me.ClbBeispiel)
        Me.Controls.Add(Me.ChbPruefung)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CbbAuswahl)
        Me.Controls.Add(Me.BtnKlickMich)
        Me.Name = "WndMain"
        Me.Text = "Startfenster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnKlickMich As Button
    Friend WithEvents CbbAuswahl As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChbPruefung As CheckBox
    Friend WithEvents ClbBeispiel As CheckedListBox
End Class
