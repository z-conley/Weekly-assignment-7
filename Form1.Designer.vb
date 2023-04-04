<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmkaraoke
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Lblkaraoke = New System.Windows.Forms.Label()
        Me.CboChoices = New System.Windows.Forms.ComboBox()
        Me.Btntotal = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Lblhourly = New System.Windows.Forms.Label()
        Me.Txthours = New System.Windows.Forms.TextBox()
        Me.Lblcostdisplay = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lblkaraoke
        '
        Me.Lblkaraoke.AutoSize = True
        Me.Lblkaraoke.BackColor = System.Drawing.Color.Black
        Me.Lblkaraoke.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblkaraoke.ForeColor = System.Drawing.Color.White
        Me.Lblkaraoke.Location = New System.Drawing.Point(411, 40)
        Me.Lblkaraoke.Name = "Lblkaraoke"
        Me.Lblkaraoke.Size = New System.Drawing.Size(306, 36)
        Me.Lblkaraoke.TabIndex = 0
        Me.Lblkaraoke.Text = "Karaoke Music night"
        '
        'CboChoices
        '
        Me.CboChoices.BackColor = System.Drawing.Color.Black
        Me.CboChoices.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboChoices.ForeColor = System.Drawing.Color.White
        Me.CboChoices.FormattingEnabled = True
        Me.CboChoices.Items.AddRange(New Object() {"Number of songs($2.99 per song)", "Private karaoke room($8.99 an hour)"})
        Me.CboChoices.Location = New System.Drawing.Point(379, 101)
        Me.CboChoices.Name = "CboChoices"
        Me.CboChoices.Size = New System.Drawing.Size(371, 27)
        Me.CboChoices.TabIndex = 1
        Me.CboChoices.Text = "Select an option:"
        '
        'Btntotal
        '
        Me.Btntotal.BackColor = System.Drawing.Color.Black
        Me.Btntotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntotal.ForeColor = System.Drawing.Color.White
        Me.Btntotal.Location = New System.Drawing.Point(373, 375)
        Me.Btntotal.Name = "Btntotal"
        Me.Btntotal.Size = New System.Drawing.Size(164, 43)
        Me.Btntotal.TabIndex = 2
        Me.Btntotal.Text = "Total cost"
        Me.Btntotal.UseVisualStyleBackColor = False
        '
        'Btnclear
        '
        Me.Btnclear.BackColor = System.Drawing.Color.Black
        Me.Btnclear.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.ForeColor = System.Drawing.Color.White
        Me.Btnclear.Location = New System.Drawing.Point(580, 374)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(164, 43)
        Me.Btnclear.TabIndex = 3
        Me.Btnclear.Text = "Clear form"
        Me.Btnclear.UseVisualStyleBackColor = False
        '
        'Lblhourly
        '
        Me.Lblhourly.BackColor = System.Drawing.Color.Black
        Me.Lblhourly.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblhourly.ForeColor = System.Drawing.Color.White
        Me.Lblhourly.Location = New System.Drawing.Point(385, 197)
        Me.Lblhourly.Name = "Lblhourly"
        Me.Lblhourly.Size = New System.Drawing.Size(359, 33)
        Me.Lblhourly.TabIndex = 4
        '
        'Txthours
        '
        Me.Txthours.BackColor = System.Drawing.Color.Black
        Me.Txthours.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txthours.ForeColor = System.Drawing.Color.White
        Me.Txthours.Location = New System.Drawing.Point(532, 259)
        Me.Txthours.Name = "Txthours"
        Me.Txthours.Size = New System.Drawing.Size(42, 29)
        Me.Txthours.TabIndex = 5
        Me.Txthours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lblcostdisplay
        '
        Me.Lblcostdisplay.BackColor = System.Drawing.Color.Black
        Me.Lblcostdisplay.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcostdisplay.ForeColor = System.Drawing.Color.White
        Me.Lblcostdisplay.Location = New System.Drawing.Point(373, 454)
        Me.Lblcostdisplay.Name = "Lblcostdisplay"
        Me.Lblcostdisplay.Size = New System.Drawing.Size(371, 35)
        Me.Lblcostdisplay.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(339, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(462, 503)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Frmkaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Weekly_assignment_7.My.Resources.Resources.karaoke
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.Lblcostdisplay)
        Me.Controls.Add(Me.Lblhourly)
        Me.Controls.Add(Me.Lblkaraoke)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btntotal)
        Me.Controls.Add(Me.Txthours)
        Me.Controls.Add(Me.CboChoices)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Name = "Frmkaraoke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaoke night"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblkaraoke As Label
    Friend WithEvents CboChoices As ComboBox
    Friend WithEvents Btntotal As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents Lblhourly As Label
    Friend WithEvents Txthours As TextBox
    Friend WithEvents Lblcostdisplay As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
