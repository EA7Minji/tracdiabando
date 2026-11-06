<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chiamanhbando_khai
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxX_Khai = New System.Windows.Forms.TextBox()
        Me.TextBoxY_Khai = New System.Windows.Forms.TextBox()
        Me.TextBoxKQ_Khai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChiaManh_Khai = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxTL_Khai = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập Tọa độ điểm:"
        '
        'TextBoxX_Khai
        '
        Me.TextBoxX_Khai.Location = New System.Drawing.Point(288, 93)
        Me.TextBoxX_Khai.Name = "TextBoxX_Khai"
        Me.TextBoxX_Khai.Size = New System.Drawing.Size(136, 26)
        Me.TextBoxX_Khai.TabIndex = 1
        '
        'TextBoxY_Khai
        '
        Me.TextBoxY_Khai.Location = New System.Drawing.Point(485, 93)
        Me.TextBoxY_Khai.Name = "TextBoxY_Khai"
        Me.TextBoxY_Khai.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxY_Khai.TabIndex = 2
        '
        'TextBoxKQ_Khai
        '
        Me.TextBoxKQ_Khai.Location = New System.Drawing.Point(300, 295)
        Me.TextBoxKQ_Khai.Name = "TextBoxKQ_Khai"
        Me.TextBoxKQ_Khai.Size = New System.Drawing.Size(217, 26)
        Me.TextBoxKQ_Khai.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kết Quả"
        '
        'ChiaManh_Khai
        '
        Me.ChiaManh_Khai.Location = New System.Drawing.Point(483, 168)
        Me.ChiaManh_Khai.Name = "ChiaManh_Khai"
        Me.ChiaManh_Khai.Size = New System.Drawing.Size(102, 46)
        Me.ChiaManh_Khai.TabIndex = 5
        Me.ChiaManh_Khai.Text = "Chia Mảnh"
        Me.ChiaManh_Khai.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tọa độ X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(499, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tọa độ Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(140, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Chọn tỉ lệ:"
        '
        'ComboBoxTL_Khai
        '
        Me.ComboBoxTL_Khai.AutoCompleteCustomSource.AddRange(New String() {"5000", "2000", "1000", "500", "200"})
        Me.ComboBoxTL_Khai.FormattingEnabled = True
        Me.ComboBoxTL_Khai.Items.AddRange(New Object() {"1/10.000", "1/5.000", "1/2.000", "1/1.000", "1/500", "1/200"})
        Me.ComboBoxTL_Khai.Location = New System.Drawing.Point(288, 178)
        Me.ComboBoxTL_Khai.Name = "ComboBoxTL_Khai"
        Me.ComboBoxTL_Khai.Size = New System.Drawing.Size(134, 28)
        Me.ComboBoxTL_Khai.TabIndex = 9
        '
        'chiamanhbando_khai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 511)
        Me.Controls.Add(Me.ComboBoxTL_Khai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChiaManh_Khai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxKQ_Khai)
        Me.Controls.Add(Me.TextBoxY_Khai)
        Me.Controls.Add(Me.TextBoxX_Khai)
        Me.Controls.Add(Me.Label1)
        Me.Name = "chiamanhbando_khai"
        Me.Text = "chiamanhbando_khai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxX_Khai As TextBox
    Friend WithEvents TextBoxY_Khai As TextBox
    Friend WithEvents TextBoxKQ_Khai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChiaManh_Khai As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxTL_Khai As ComboBox
End Class
