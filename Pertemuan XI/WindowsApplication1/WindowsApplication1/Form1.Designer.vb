<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbPallet = New System.Windows.Forms.GroupBox()
        Me.nudUkuran = New System.Windows.Forms.NumericUpDown()
        Me.lblUkuran = New System.Windows.Forms.Label()
        Me.rbElipsIsi = New System.Windows.Forms.RadioButton()
        Me.rbKotakIsi = New System.Windows.Forms.RadioButton()
        Me.rbElips = New System.Windows.Forms.RadioButton()
        Me.rbKotak = New System.Windows.Forms.RadioButton()
        Me.rbGaris = New System.Windows.Forms.RadioButton()
        Me.rbBebas = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rsShapeIsian = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rsShapeTepi = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.gbWarna = New System.Windows.Forms.GroupBox()
        Me.btnGambarUlang = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rsPutih = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rsHitam = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rsBiru = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rsHijau = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rsKuning = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rsMerah = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.gbInput = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rbKotakIsiTepi = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.gbPallet.SuspendLayout()
        CType(Me.nudUkuran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbWarna.SuspendLayout()
        Me.gbInput.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(588, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'gbPallet
        '
        Me.gbPallet.Controls.Add(Me.rbKotakIsiTepi)
        Me.gbPallet.Controls.Add(Me.nudUkuran)
        Me.gbPallet.Controls.Add(Me.lblUkuran)
        Me.gbPallet.Controls.Add(Me.rbElipsIsi)
        Me.gbPallet.Controls.Add(Me.rbKotakIsi)
        Me.gbPallet.Controls.Add(Me.rbElips)
        Me.gbPallet.Controls.Add(Me.rbKotak)
        Me.gbPallet.Controls.Add(Me.rbGaris)
        Me.gbPallet.Controls.Add(Me.rbBebas)
        Me.gbPallet.Controls.Add(Me.ShapeContainer1)
        Me.gbPallet.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbPallet.Location = New System.Drawing.Point(0, 24)
        Me.gbPallet.Name = "gbPallet"
        Me.gbPallet.Size = New System.Drawing.Size(114, 427)
        Me.gbPallet.TabIndex = 1
        Me.gbPallet.TabStop = False
        Me.gbPallet.Text = "Tools"
        '
        'nudUkuran
        '
        Me.nudUkuran.Location = New System.Drawing.Point(12, 210)
        Me.nudUkuran.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudUkuran.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudUkuran.Name = "nudUkuran"
        Me.nudUkuran.Size = New System.Drawing.Size(90, 20)
        Me.nudUkuran.TabIndex = 7
        Me.nudUkuran.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblUkuran
        '
        Me.lblUkuran.AutoSize = True
        Me.lblUkuran.Location = New System.Drawing.Point(12, 194)
        Me.lblUkuran.Name = "lblUkuran"
        Me.lblUkuran.Size = New System.Drawing.Size(93, 13)
        Me.lblUkuran.TabIndex = 6
        Me.lblUkuran.Text = "Ukuran Garis Tepi"
        '
        'rbElipsIsi
        '
        Me.rbElipsIsi.AutoSize = True
        Me.rbElipsIsi.Location = New System.Drawing.Point(12, 135)
        Me.rbElipsIsi.Name = "rbElipsIsi"
        Me.rbElipsIsi.Size = New System.Drawing.Size(60, 17)
        Me.rbElipsIsi.TabIndex = 5
        Me.rbElipsIsi.TabStop = True
        Me.rbElipsIsi.Text = "Elips Isi"
        Me.rbElipsIsi.UseVisualStyleBackColor = True
        '
        'rbKotakIsi
        '
        Me.rbKotakIsi.AutoSize = True
        Me.rbKotakIsi.Location = New System.Drawing.Point(12, 112)
        Me.rbKotakIsi.Name = "rbKotakIsi"
        Me.rbKotakIsi.Size = New System.Drawing.Size(66, 17)
        Me.rbKotakIsi.TabIndex = 4
        Me.rbKotakIsi.TabStop = True
        Me.rbKotakIsi.Text = "Kotak Isi"
        Me.rbKotakIsi.UseVisualStyleBackColor = True
        '
        'rbElips
        '
        Me.rbElips.AutoSize = True
        Me.rbElips.Location = New System.Drawing.Point(12, 89)
        Me.rbElips.Name = "rbElips"
        Me.rbElips.Size = New System.Drawing.Size(47, 17)
        Me.rbElips.TabIndex = 3
        Me.rbElips.TabStop = True
        Me.rbElips.Text = "Elips"
        Me.rbElips.UseVisualStyleBackColor = True
        '
        'rbKotak
        '
        Me.rbKotak.AutoSize = True
        Me.rbKotak.Location = New System.Drawing.Point(12, 66)
        Me.rbKotak.Name = "rbKotak"
        Me.rbKotak.Size = New System.Drawing.Size(53, 17)
        Me.rbKotak.TabIndex = 2
        Me.rbKotak.TabStop = True
        Me.rbKotak.Text = "Kotak"
        Me.rbKotak.UseVisualStyleBackColor = True
        '
        'rbGaris
        '
        Me.rbGaris.AutoSize = True
        Me.rbGaris.Location = New System.Drawing.Point(12, 43)
        Me.rbGaris.Name = "rbGaris"
        Me.rbGaris.Size = New System.Drawing.Size(49, 17)
        Me.rbGaris.TabIndex = 1
        Me.rbGaris.TabStop = True
        Me.rbGaris.Text = "Garis"
        Me.rbGaris.UseVisualStyleBackColor = True
        '
        'rbBebas
        '
        Me.rbBebas.AutoSize = True
        Me.rbBebas.Location = New System.Drawing.Point(12, 19)
        Me.rbBebas.Name = "rbBebas"
        Me.rbBebas.Size = New System.Drawing.Size(55, 17)
        Me.rbBebas.TabIndex = 0
        Me.rbBebas.TabStop = True
        Me.rbBebas.Text = "Bebas"
        Me.rbBebas.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rsShapeIsian, Me.rsShapeTepi})
        Me.ShapeContainer1.Size = New System.Drawing.Size(108, 408)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'rsShapeIsian
        '
        Me.rsShapeIsian.FillColor = System.Drawing.Color.White
        Me.rsShapeIsian.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.rsShapeIsian.Location = New System.Drawing.Point(55, 229)
        Me.rsShapeIsian.Name = "rsShapeIsian"
        Me.rsShapeIsian.Size = New System.Drawing.Size(40, 40)
        '
        'rsShapeTepi
        '
        Me.rsShapeTepi.FillColor = System.Drawing.Color.Black
        Me.rsShapeTepi.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.rsShapeTepi.Location = New System.Drawing.Point(6, 228)
        Me.rsShapeTepi.Name = "rsShapeTepi"
        Me.rsShapeTepi.Size = New System.Drawing.Size(40, 40)
        '
        'gbWarna
        '
        Me.gbWarna.Controls.Add(Me.btnGambarUlang)
        Me.gbWarna.Controls.Add(Me.btnBersihkan)
        Me.gbWarna.Controls.Add(Me.btnUndo)
        Me.gbWarna.Controls.Add(Me.ShapeContainer2)
        Me.gbWarna.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbWarna.Location = New System.Drawing.Point(114, 351)
        Me.gbWarna.Name = "gbWarna"
        Me.gbWarna.Size = New System.Drawing.Size(474, 100)
        Me.gbWarna.TabIndex = 2
        Me.gbWarna.TabStop = False
        Me.gbWarna.Text = "Warna"
        '
        'btnGambarUlang
        '
        Me.btnGambarUlang.Location = New System.Drawing.Point(377, 65)
        Me.btnGambarUlang.Name = "btnGambarUlang"
        Me.btnGambarUlang.Size = New System.Drawing.Size(91, 23)
        Me.btnGambarUlang.TabIndex = 3
        Me.btnGambarUlang.Text = "Gambar Ulang"
        Me.btnGambarUlang.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(275, 65)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnBersihkan.TabIndex = 2
        Me.btnBersihkan.Text = "Clear"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(194, 65)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 1
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rsPutih, Me.rsHitam, Me.rsBiru, Me.rsHijau, Me.rsKuning, Me.rsMerah})
        Me.ShapeContainer2.Size = New System.Drawing.Size(468, 81)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'rsPutih
        '
        Me.rsPutih.FillColor = System.Drawing.Color.White
        Me.rsPutih.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.rsPutih.Location = New System.Drawing.Point(170, 3)
        Me.rsPutih.Name = "rsPutih"
        Me.rsPutih.Size = New System.Drawing.Size(25, 24)
        '
        'rsHitam
        '
        Me.rsHitam.FillColor = System.Drawing.Color.Black
        Me.rsHitam.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.rsHitam.Location = New System.Drawing.Point(140, 4)
        Me.rsHitam.Name = "rsHitam"
        Me.rsHitam.Size = New System.Drawing.Size(25, 24)
        '
        'rsBiru
        '
        Me.rsBiru.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rsBiru.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.rsBiru.Location = New System.Drawing.Point(108, 4)
        Me.rsBiru.Name = "rsBiru"
        Me.rsBiru.Size = New System.Drawing.Size(25, 24)
        '
        'rsHijau
        '
        Me.rsHijau.FillColor = System.Drawing.Color.Green
        Me.rsHijau.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.rsHijau.Location = New System.Drawing.Point(75, 4)
        Me.rsHijau.Name = "rsHijau"
        Me.rsHijau.Size = New System.Drawing.Size(25, 24)
        '
        'rsKuning
        '
        Me.rsKuning.FillColor = System.Drawing.Color.Yellow
        Me.rsKuning.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.rsKuning.Location = New System.Drawing.Point(43, 4)
        Me.rsKuning.Name = "rsKuning"
        Me.rsKuning.Size = New System.Drawing.Size(25, 24)
        '
        'rsMerah
        '
        Me.rsMerah.FillColor = System.Drawing.Color.Red
        Me.rsMerah.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.rsMerah.Location = New System.Drawing.Point(13, 4)
        Me.rsMerah.Name = "rsMerah"
        Me.rsMerah.Size = New System.Drawing.Size(25, 24)
        '
        'gbInput
        '
        Me.gbInput.Controls.Add(Me.TextBox1)
        Me.gbInput.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbInput.Location = New System.Drawing.Point(471, 24)
        Me.gbInput.Name = "gbInput"
        Me.gbInput.Size = New System.Drawing.Size(117, 327)
        Me.gbInput.TabIndex = 3
        Me.gbInput.TabStop = False
        Me.gbInput.Text = "Object"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 20)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(117, 301)
        Me.TextBox1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(115, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 317)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'rbKotakIsiTepi
        '
        Me.rbKotakIsiTepi.AutoSize = True
        Me.rbKotakIsiTepi.Location = New System.Drawing.Point(12, 158)
        Me.rbKotakIsiTepi.Name = "rbKotakIsiTepi"
        Me.rbKotakIsiTepi.Size = New System.Drawing.Size(90, 17)
        Me.rbKotakIsiTepi.TabIndex = 9
        Me.rbKotakIsiTepi.TabStop = True
        Me.rbKotakIsiTepi.Text = "Kotak Isi Tepi"
        Me.rbKotakIsiTepi.UseVisualStyleBackColor = True
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 451)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbInput)
        Me.Controls.Add(Me.gbWarna)
        Me.Controls.Add(Me.gbPallet)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbPallet.ResumeLayout(False)
        Me.gbPallet.PerformLayout()
        CType(Me.nudUkuran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbWarna.ResumeLayout(False)
        Me.gbInput.ResumeLayout(False)
        Me.gbInput.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbPallet As System.Windows.Forms.GroupBox
    Friend WithEvents rbKotak As System.Windows.Forms.RadioButton
    Friend WithEvents rbGaris As System.Windows.Forms.RadioButton
    Friend WithEvents rbBebas As System.Windows.Forms.RadioButton
    Friend WithEvents rbElipsIsi As System.Windows.Forms.RadioButton
    Friend WithEvents rbKotakIsi As System.Windows.Forms.RadioButton
    Friend WithEvents rbElips As System.Windows.Forms.RadioButton
    Friend WithEvents lblUkuran As System.Windows.Forms.Label
    Friend WithEvents nudUkuran As System.Windows.Forms.NumericUpDown
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rsShapeTepi As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rsShapeIsian As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents gbWarna As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rsPutih As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rsHitam As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rsBiru As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rsHijau As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rsKuning As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rsMerah As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnGambarUlang As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents gbInput As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rbKotakIsiTepi As System.Windows.Forms.RadioButton

End Class
