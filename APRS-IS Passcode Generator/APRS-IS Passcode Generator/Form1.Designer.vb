<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LabelCallsign = New System.Windows.Forms.Label()
        Me.LabelPasscode = New System.Windows.Forms.Label()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.TextBoxCallsign = New System.Windows.Forms.TextBox()
        Me.LinkLabelWeb = New System.Windows.Forms.LinkLabel()
        Me.TextBoxPasscode = New System.Windows.Forms.TextBox()
        Me.GroupBoxGenerator = New System.Windows.Forms.GroupBox()
        Me.GroupBoxGenerator.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCallsign
        '
        Me.LabelCallsign.AutoSize = True
        Me.LabelCallsign.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCallsign.Location = New System.Drawing.Point(13, 22)
        Me.LabelCallsign.Name = "LabelCallsign"
        Me.LabelCallsign.Size = New System.Drawing.Size(64, 18)
        Me.LabelCallsign.TabIndex = 3
        Me.LabelCallsign.Text = "Callsign:"
        '
        'LabelPasscode
        '
        Me.LabelPasscode.AutoSize = True
        Me.LabelPasscode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPasscode.Location = New System.Drawing.Point(13, 55)
        Me.LabelPasscode.Name = "LabelPasscode"
        Me.LabelPasscode.Size = New System.Drawing.Size(79, 18)
        Me.LabelPasscode.TabIndex = 4
        Me.LabelPasscode.Text = "Passcode:"
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerate.Location = New System.Drawing.Point(16, 87)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(261, 32)
        Me.ButtonGenerate.TabIndex = 1
        Me.ButtonGenerate.Text = "Generate APRS-IS Passcode"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'TextBoxCallsign
        '
        Me.TextBoxCallsign.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCallsign.Location = New System.Drawing.Point(112, 19)
        Me.TextBoxCallsign.Name = "TextBoxCallsign"
        Me.TextBoxCallsign.Size = New System.Drawing.Size(165, 24)
        Me.TextBoxCallsign.TabIndex = 0
        '
        'LinkLabelWeb
        '
        Me.LinkLabelWeb.AutoSize = True
        Me.LinkLabelWeb.Location = New System.Drawing.Point(269, 146)
        Me.LinkLabelWeb.Name = "LinkLabelWeb"
        Me.LinkLabelWeb.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabelWeb.TabIndex = 5
        Me.LinkLabelWeb.TabStop = True
        Me.LinkLabelWeb.Text = "About"
        '
        'TextBoxPasscode
        '
        Me.TextBoxPasscode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPasscode.Location = New System.Drawing.Point(112, 55)
        Me.TextBoxPasscode.Name = "TextBoxPasscode"
        Me.TextBoxPasscode.ReadOnly = True
        Me.TextBoxPasscode.Size = New System.Drawing.Size(165, 26)
        Me.TextBoxPasscode.TabIndex = 6
        '
        'GroupBoxGenerator
        '
        Me.GroupBoxGenerator.Controls.Add(Me.LabelPasscode)
        Me.GroupBoxGenerator.Controls.Add(Me.LabelCallsign)
        Me.GroupBoxGenerator.Controls.Add(Me.ButtonGenerate)
        Me.GroupBoxGenerator.Controls.Add(Me.TextBoxCallsign)
        Me.GroupBoxGenerator.Controls.Add(Me.TextBoxPasscode)
        Me.GroupBoxGenerator.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxGenerator.Name = "GroupBoxGenerator"
        Me.GroupBoxGenerator.Size = New System.Drawing.Size(292, 131)
        Me.GroupBoxGenerator.TabIndex = 7
        Me.GroupBoxGenerator.TabStop = False
        Me.GroupBoxGenerator.Text = "Generator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(316, 168)
        Me.Controls.Add(Me.GroupBoxGenerator)
        Me.Controls.Add(Me.LinkLabelWeb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "APRS-IS Passcode Generator"
        Me.GroupBoxGenerator.ResumeLayout(False)
        Me.GroupBoxGenerator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCallsign As Label
    Friend WithEvents LabelPasscode As Label
    Friend WithEvents ButtonGenerate As Button
    Friend WithEvents TextBoxCallsign As TextBox
    Friend WithEvents LinkLabelWeb As LinkLabel
    Friend WithEvents TextBoxPasscode As TextBox
    Friend WithEvents GroupBoxGenerator As GroupBox
End Class
