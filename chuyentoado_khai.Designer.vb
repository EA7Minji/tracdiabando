<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chuyentoado_khai
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
        Me.TextBoxFile_Khai = New System.Windows.Forms.TextBox()
        Me.ButtonNhapFile_Khai = New System.Windows.Forms.Button()
        Me.OpenFileDialog_Khai = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog_Khai = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonXuat_Khai = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxFile_Khai
        '
        Me.TextBoxFile_Khai.Location = New System.Drawing.Point(205, 95)
        Me.TextBoxFile_Khai.Name = "TextBoxFile_Khai"
        Me.TextBoxFile_Khai.Size = New System.Drawing.Size(181, 26)
        Me.TextBoxFile_Khai.TabIndex = 0
        '
        'ButtonNhapFile_Khai
        '
        Me.ButtonNhapFile_Khai.Location = New System.Drawing.Point(444, 92)
        Me.ButtonNhapFile_Khai.Name = "ButtonNhapFile_Khai"
        Me.ButtonNhapFile_Khai.Size = New System.Drawing.Size(134, 33)
        Me.ButtonNhapFile_Khai.TabIndex = 1
        Me.ButtonNhapFile_Khai.Text = "nhập file"
        Me.ButtonNhapFile_Khai.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_Khai
        '
        Me.OpenFileDialog_Khai.FileName = "OpenFileDialog1"
        '
        'ButtonXuat_Khai
        '
        Me.ButtonXuat_Khai.Location = New System.Drawing.Point(332, 240)
        Me.ButtonXuat_Khai.Name = "ButtonXuat_Khai"
        Me.ButtonXuat_Khai.Size = New System.Drawing.Size(75, 34)
        Me.ButtonXuat_Khai.TabIndex = 2
        Me.ButtonXuat_Khai.Text = "Xuất"
        Me.ButtonXuat_Khai.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(205, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 26)
        Me.TextBox1.TabIndex = 3
        '
        'chuyentoado_khai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonXuat_Khai)
        Me.Controls.Add(Me.ButtonNhapFile_Khai)
        Me.Controls.Add(Me.TextBoxFile_Khai)
        Me.Name = "chuyentoado_khai"
        Me.Text = "chuyentoado_khai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxFile_Khai As TextBox
    Friend WithEvents ButtonNhapFile_Khai As Button
    Friend WithEvents OpenFileDialog_Khai As OpenFileDialog
    Friend WithEvents SaveFileDialog_Khai As SaveFileDialog
    Friend WithEvents ButtonXuat_Khai As Button
    Friend WithEvents TextBox1 As TextBox
End Class
