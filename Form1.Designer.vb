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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChọnChươngTrìnhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TínhTọaĐộĐiểmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiaMảnhBảnĐồToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChuyểnĐổiTọaĐộToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CàiĐặtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChọnChươngTrìnhToolStripMenuItem, Me.CàiĐặtToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChọnChươngTrìnhToolStripMenuItem
        '
        Me.ChọnChươngTrìnhToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TínhTọaĐộĐiểmToolStripMenuItem, Me.ChiaMảnhBảnĐồToolStripMenuItem, Me.ChuyểnĐổiTọaĐộToolStripMenuItem})
        Me.ChọnChươngTrìnhToolStripMenuItem.Name = "ChọnChươngTrìnhToolStripMenuItem"
        Me.ChọnChươngTrìnhToolStripMenuItem.Size = New System.Drawing.Size(181, 29)
        Me.ChọnChươngTrìnhToolStripMenuItem.Text = "Chọn Chương Trình"
        '
        'TínhTọaĐộĐiểmToolStripMenuItem
        '
        Me.TínhTọaĐộĐiểmToolStripMenuItem.Name = "TínhTọaĐộĐiểmToolStripMenuItem"
        Me.TínhTọaĐộĐiểmToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.TínhTọaĐộĐiểmToolStripMenuItem.Text = "Tính Tọa Độ Điểm "
        '
        'ChiaMảnhBảnĐồToolStripMenuItem
        '
        Me.ChiaMảnhBảnĐồToolStripMenuItem.Name = "ChiaMảnhBảnĐồToolStripMenuItem"
        Me.ChiaMảnhBảnĐồToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.ChiaMảnhBảnĐồToolStripMenuItem.Text = "Chia Mảnh Bản Đồ "
        '
        'ChuyểnĐổiTọaĐộToolStripMenuItem
        '
        Me.ChuyểnĐổiTọaĐộToolStripMenuItem.Name = "ChuyểnĐổiTọaĐộToolStripMenuItem"
        Me.ChuyểnĐổiTọaĐộToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.ChuyểnĐổiTọaĐộToolStripMenuItem.Text = "Chuyển Đổi Tọa Độ"
        '
        'CàiĐặtToolStripMenuItem
        '
        Me.CàiĐặtToolStripMenuItem.Name = "CàiĐặtToolStripMenuItem"
        Me.CàiĐặtToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.CàiĐặtToolStripMenuItem.Text = "Cài  Đặt "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(537, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "copy right by Nguyen Tang Khai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(550, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CHÀO MỪNG BẠN ĐẾN VỚI CHƯƠNG TRÌNH TÍNH TOÁN TRẮC ĐỊA 2026"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "chuong trinh trac dia"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChọnChươngTrìnhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TínhTọaĐộĐiểmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiaMảnhBảnĐồToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChuyểnĐổiTọaĐộToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CàiĐặtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
