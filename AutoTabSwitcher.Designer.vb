<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.SecondsLabel = New System.Windows.Forms.Label()
        Me.NumberBox = New System.Windows.Forms.NumericUpDown()
        Me.BrowseFile1Button = New System.Windows.Forms.Button()
        Me.BrowseFile2Button = New System.Windows.Forms.Button()
        Me.BrowseFile1Textbox = New System.Windows.Forms.TextBox()
        Me.BrowseFile2TextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NumberBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(390, 331)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(486, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(390, 261)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 52)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'SecondsLabel
        '
        Me.SecondsLabel.AutoSize = True
        Me.SecondsLabel.Location = New System.Drawing.Point(12, 46)
        Me.SecondsLabel.Name = "SecondsLabel"
        Me.SecondsLabel.Size = New System.Drawing.Size(143, 13)
        Me.SecondsLabel.TabIndex = 4
        Me.SecondsLabel.Text = "Seconds Between Switching"
        '
        'NumberBox
        '
        Me.NumberBox.Location = New System.Drawing.Point(12, 62)
        Me.NumberBox.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumberBox.Name = "NumberBox"
        Me.NumberBox.Size = New System.Drawing.Size(140, 20)
        Me.NumberBox.TabIndex = 5
        Me.NumberBox.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'BrowseFile1Button
        '
        Me.BrowseFile1Button.Location = New System.Drawing.Point(12, 115)
        Me.BrowseFile1Button.Name = "BrowseFile1Button"
        Me.BrowseFile1Button.Size = New System.Drawing.Size(128, 31)
        Me.BrowseFile1Button.TabIndex = 6
        Me.BrowseFile1Button.Text = "Browse Application 1"
        Me.BrowseFile1Button.UseVisualStyleBackColor = True
        '
        'BrowseFile2Button
        '
        Me.BrowseFile2Button.Location = New System.Drawing.Point(12, 173)
        Me.BrowseFile2Button.Name = "BrowseFile2Button"
        Me.BrowseFile2Button.Size = New System.Drawing.Size(128, 31)
        Me.BrowseFile2Button.TabIndex = 7
        Me.BrowseFile2Button.Text = "Browse Application 2"
        Me.BrowseFile2Button.UseVisualStyleBackColor = True
        '
        'BrowseFile1Textbox
        '
        Me.BrowseFile1Textbox.Location = New System.Drawing.Point(146, 126)
        Me.BrowseFile1Textbox.Name = "BrowseFile1Textbox"
        Me.BrowseFile1Textbox.Size = New System.Drawing.Size(263, 20)
        Me.BrowseFile1Textbox.TabIndex = 8
        '
        'BrowseFile2TextBox
        '
        Me.BrowseFile2TextBox.Location = New System.Drawing.Point(146, 184)
        Me.BrowseFile2TextBox.Name = "BrowseFile2TextBox"
        Me.BrowseFile2TextBox.Size = New System.Drawing.Size(263, 20)
        Me.BrowseFile2TextBox.TabIndex = 9
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HowToToolStripMenuItem.Text = "How To"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 366)
        Me.Controls.Add(Me.BrowseFile2TextBox)
        Me.Controls.Add(Me.BrowseFile1Textbox)
        Me.Controls.Add(Me.BrowseFile2Button)
        Me.Controls.Add(Me.BrowseFile1Button)
        Me.Controls.Add(Me.NumberBox)
        Me.Controls.Add(Me.SecondsLabel)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.Text = "Auto Tab Switcher"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NumberBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartButton As Button
    Friend WithEvents SecondsLabel As Label
    Friend WithEvents NumberBox As NumericUpDown
    Friend WithEvents BrowseFile1Button As Button
    Friend WithEvents BrowseFile2Button As Button
    Friend WithEvents BrowseFile1Textbox As TextBox
    Friend WithEvents BrowseFile2TextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents HowToToolStripMenuItem As ToolStripMenuItem
End Class
