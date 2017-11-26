Imports System.Drawing
Imports System.Drawing.Drawing2D
    
Public Class frmUtama

    Dim modegambar As String
    Dim warnatepi As Color = Color.Black
    Dim warnaisian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnatepi, 3)
    Dim isian As New System.Drawing.SolidBrush(warnaisian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap
    'Dim value As Integer = nudUkuran.Value

    Private Sub frmUtama_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round
    End Sub

    Private Sub RadioFree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBebas.CheckedChanged
        modegambar = "bebas"
    End Sub

    Private Sub RadioLine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGaris.CheckedChanged
        modegambar = "garis"
    End Sub

    Private Sub RadioRectangle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbKotak.CheckedChanged
        modegambar = "kotak"
    End Sub

    Private Sub RadioCircle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbElips.CheckedChanged
        modegambar = "elips"
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbKotakIsi.CheckedChanged
        modegambar = "kotakisi"
    End Sub

    Private Sub RadioElipsIsi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbElipsIsi.CheckedChanged
        modegambar = "elipsisi"
    End Sub

    Private Sub rbKotakIsiTepi_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbKotakIsiTepi.CheckedChanged
        modegambar = "kotakisitepi"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudUkuran.ValueChanged
        tepi.Width = nudUkuran.Value()
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnatepi
        'tepi.Width = value
        isian.Color = warnaisian
        titik = e.Location
        dipencet = True
    End Sub    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modegambar
            Case "bebas"
                If dipencet Then
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, titik, e.Location)

                    End Using
                    PictureBox1.Invalidate()
                    TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
                    TextBox1.AppendText("o garis " + titik.X.ToString + " " +
                   titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
                    titik = e.Location
                End If
        End Select
    End Sub    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Select Case modegambar
            Case "garis"
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawLine(tepi, titik, e.Location)
                End Using
            Case "kotak"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
            Case "elips"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
            Case "kotakisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect)
                End Using
            Case "elipsisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillEllipse(isian, rect)
                End Using
            Case "kotakisitepi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
                Dim rect2 As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect2)
                End Using
        End Select
        PictureBox1.Invalidate()
        dipencet = False
        If (titik.X <> e.X And titik.Y <> e.Y) Then
            TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " +
           warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
            TextBox1.AppendText("o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & vbNewLine)
            TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " +
           titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString + " " + CStr(tepi.Width) & vbNewLine)
        End If
    End Sub    Private Sub Warna1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rsMerah.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = rsMerah.FillColor
            rsShapeTepi.FillColor = warnatepi
        Else
            warnaisian = rsMerah.FillColor
            rsShapeIsian.FillColor = warnaisian
        End If
    End Sub

    Private Sub Warna2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rsKuning.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = rsKuning.FillColor
            rsShapeTepi.FillColor = warnatepi
        Else
            warnaisian = rsKuning.FillColor
            rsShapeIsian.FillColor = warnaisian
        End If
    End Sub

    Private Sub Warna3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rsHijau.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = rsHijau.FillColor
            rsShapeTepi.FillColor = warnatepi
        Else
            warnaisian = rsHijau.FillColor
            rsShapeIsian.FillColor = warnaisian
        End If
    End Sub

    Private Sub Warna4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rsBiru.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = rsBiru.FillColor
            rsShapeTepi.FillColor = warnatepi
        Else
            warnaisian = rsBiru.FillColor
            rsShapeIsian.FillColor = warnaisian
        End If
    End Sub

    Private Sub Warna5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rsHitam.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = rsHitam.FillColor
            rsShapeTepi.FillColor = warnatepi
        Else
            warnaisian = rsHitam.FillColor
            rsShapeIsian.FillColor = warnaisian
        End If
    End Sub

    Private Sub Warna6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rsPutih.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = rsPutih.FillColor
            rsShapeTepi.FillColor = warnatepi
        Else
            warnaisian = rsPutih.FillColor
            rsShapeIsian.FillColor = warnaisian
        End If
    End Sub    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub    Private Sub gbrUlang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGambarUlang.Click
        If TextBox1.Lines.Length >= 3 Then
            btnBersihkan.PerformClick()
            Dim a As Integer = TextBox1.Lines.Count
            For i As Integer = 0 To a
                Dim teksbaris As String = TextBox1.Lines(i)
                Dim pecah() As String
                pecah = teksbaris.Split(" "c)
                On Error Resume Next
                pecah(1) = pecah(1).Trim(" "c)
                tepi.Width = pecah(6)
                Select Case pecah(1)
                    Case "warnatepi"
                        warnatepi = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)),
                       CByte(pecah(4)))
                        tepi.Color = warnatepi
                    Case "warnaisian"
                        warnaisian = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)),
                       CByte(pecah(4)))
                        isian.Color = warnaisian
                    Case "garis"
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            g.DrawLine(tepi, CInt(pecah(2)), CInt(pecah(3)),
                           CInt(pecah(4)), CInt(pecah(5)))
                        End Using
                    Case "kotak"
                        Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                       CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            g.DrawRectangle(tepi, rect)
                        End Using
                    Case "elips"
                        Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                       CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            g.DrawEllipse(tepi, rect)
                        End Using
                    Case "kotakisi"
                        Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                       CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            g.FillRectangle(isian, rect)
                        End Using
                    Case "elipsisi"
                        Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                       CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            g.FillEllipse(isian, rect)
                        End Using
                End Select
            Next
            PictureBox1.Invalidate()
        End If
    End Sub    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndo.Click
        If TextBox1.Lines.Length <= 3 Then
            TextBox1.Clear()
        Else
            Dim num As Integer = TextBox1.Lines.Length
            Dim newList As List(Of String) = TextBox1.Lines.ToList
            newList.RemoveAt(num - 1)
            newList.RemoveAt(num - 2)
            newList.RemoveAt(num - 3)
            newList.RemoveAt(num - 4)
            TextBox1.Lines = newList.ToArray
        End If

    End Sub
End Class
