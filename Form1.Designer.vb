<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Iamag = New System.Windows.Forms.TextBox()
        Me.TextBox_Ibmag = New System.Windows.Forms.TextBox()
        Me.TextBox_Icmag = New System.Windows.Forms.TextBox()
        Me.TextBox_Iaph = New System.Windows.Forms.TextBox()
        Me.TextBox_Ibph = New System.Windows.Forms.TextBox()
        Me.TextBox_Icph = New System.Windows.Forms.TextBox()
        Me.TextBoxPPS = New System.Windows.Forms.TextBox()
        Me.TextBoxNPS = New System.Windows.Forms.TextBox()
        Me.TextBoxZPS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AngleTextBoxPPS = New System.Windows.Forms.TextBox()
        Me.AngleTextBoxNPS = New System.Windows.Forms.TextBox()
        Me.AngleTextBoxZPS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(242, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter magnitude for phase A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter magnitude for phase B:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter magnitude for phase C:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(309, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Enter phase angle for phase A (degrees):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Enter phase angle for phase B (degrees):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Enter phase angle for phase C (degrees):"
        '
        'TextBox_Iamag
        '
        Me.TextBox_Iamag.Location = New System.Drawing.Point(193, 34)
        Me.TextBox_Iamag.Name = "TextBox_Iamag"
        Me.TextBox_Iamag.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Iamag.TabIndex = 7
        '
        'TextBox_Ibmag
        '
        Me.TextBox_Ibmag.Location = New System.Drawing.Point(193, 81)
        Me.TextBox_Ibmag.Name = "TextBox_Ibmag"
        Me.TextBox_Ibmag.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Ibmag.TabIndex = 8
        '
        'TextBox_Icmag
        '
        Me.TextBox_Icmag.Location = New System.Drawing.Point(193, 133)
        Me.TextBox_Icmag.Name = "TextBox_Icmag"
        Me.TextBox_Icmag.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Icmag.TabIndex = 9
        '
        'TextBox_Iaph
        '
        Me.TextBox_Iaph.Location = New System.Drawing.Point(515, 34)
        Me.TextBox_Iaph.Name = "TextBox_Iaph"
        Me.TextBox_Iaph.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Iaph.TabIndex = 10
        '
        'TextBox_Ibph
        '
        Me.TextBox_Ibph.Location = New System.Drawing.Point(515, 85)
        Me.TextBox_Ibph.Name = "TextBox_Ibph"
        Me.TextBox_Ibph.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Ibph.TabIndex = 11
        '
        'TextBox_Icph
        '
        Me.TextBox_Icph.Location = New System.Drawing.Point(515, 129)
        Me.TextBox_Icph.Name = "TextBox_Icph"
        Me.TextBox_Icph.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Icph.TabIndex = 12
        '
        'TextBoxPPS
        '
        Me.TextBoxPPS.Location = New System.Drawing.Point(195, 197)
        Me.TextBoxPPS.Name = "TextBoxPPS"
        Me.TextBoxPPS.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPPS.TabIndex = 13
        '
        'TextBoxNPS
        '
        Me.TextBoxNPS.Location = New System.Drawing.Point(195, 244)
        Me.TextBoxNPS.Name = "TextBoxNPS"
        Me.TextBoxNPS.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNPS.TabIndex = 14
        '
        'TextBoxZPS
        '
        Me.TextBoxZPS.Location = New System.Drawing.Point(195, 296)
        Me.TextBoxZPS.Name = "TextBoxZPS"
        Me.TextBoxZPS.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxZPS.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(119, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "PPS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(119, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "NPS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(119, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "ZPS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(190, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(246, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Phase rotation is assumed to be ABC."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(221, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Magnitude"
        '
        'AngleTextBoxPPS
        '
        Me.AngleTextBoxPPS.Location = New System.Drawing.Point(336, 197)
        Me.AngleTextBoxPPS.Name = "AngleTextBoxPPS"
        Me.AngleTextBoxPPS.Size = New System.Drawing.Size(100, 20)
        Me.AngleTextBoxPPS.TabIndex = 21
        '
        'AngleTextBoxNPS
        '
        Me.AngleTextBoxNPS.Location = New System.Drawing.Point(336, 244)
        Me.AngleTextBoxNPS.Name = "AngleTextBoxNPS"
        Me.AngleTextBoxNPS.Size = New System.Drawing.Size(100, 20)
        Me.AngleTextBoxNPS.TabIndex = 22
        '
        'AngleTextBoxZPS
        '
        Me.AngleTextBoxZPS.Location = New System.Drawing.Point(336, 296)
        Me.AngleTextBoxZPS.Name = "AngleTextBoxZPS"
        Me.AngleTextBoxZPS.Size = New System.Drawing.Size(100, 20)
        Me.AngleTextBoxZPS.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(335, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Angle(in Degrees)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(625, 455)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.AngleTextBoxZPS)
        Me.Controls.Add(Me.AngleTextBoxNPS)
        Me.Controls.Add(Me.AngleTextBoxPPS)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxZPS)
        Me.Controls.Add(Me.TextBoxNPS)
        Me.Controls.Add(Me.TextBoxPPS)
        Me.Controls.Add(Me.TextBox_Icph)
        Me.Controls.Add(Me.TextBox_Ibph)
        Me.Controls.Add(Me.TextBox_Iaph)
        Me.Controls.Add(Me.TextBox_Icmag)
        Me.Controls.Add(Me.TextBox_Ibmag)
        Me.Controls.Add(Me.TextBox_Iamag)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "3 Phase Sequence Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Iamag As TextBox
    Friend WithEvents TextBox_Ibmag As TextBox
    Friend WithEvents TextBox_Icmag As TextBox
    Friend WithEvents TextBox_Iaph As TextBox
    Friend WithEvents TextBox_Ibph As TextBox
    Friend WithEvents TextBox_Icph As TextBox
    Friend WithEvents TextBoxPPS As TextBox
    Friend WithEvents TextBoxNPS As TextBox
    Friend WithEvents TextBoxZPS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents AngleTextBoxPPS As TextBox
    Friend WithEvents AngleTextBoxNPS As TextBox
    Friend WithEvents AngleTextBoxZPS As TextBox
    Friend WithEvents Label12 As Label
End Class
