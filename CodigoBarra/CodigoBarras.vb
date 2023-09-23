Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.IO
Public Class CodigoBarras
    Public Property ImgEAN As PictureBox
    Public Property Form As Form
    Public Property CodigoBarras As String
    Dim Mdl(2) As Object, MdlLeft As Object, oPen As Pen, codigoBarrasF As String, logitudCodigoBarras As Integer, Tamaño As Byte = 1,
        ColorPen As New Pen(Brushes.Black, Tamaño), TextSize As New System.Drawing.SizeF, CurrentX As Integer, CurrentY As Integer,
        TextoFont As New System.Drawing.Font("Microsoft Sans Serif", 8), linea_actual As Integer = 0,
       pagina As Integer = 1
    Sub New()
        Mdl(0) = New Object() {"0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011"}
        Mdl(1) = New Object() {"0100111", "0110011", "0011011", "0100001", "0011101", "0111001", "0000101", "0010001", "0001001", "0010111"}
        Mdl(2) = New Object() {"1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100"}
        MdlLeft = New Object() {"000000", "001011", "001101", "001110", "010011", "011001", "011100", "010101", "010110", "011010"}
    End Sub
    Public Sub Generarcodigo()
        Dim tipoCodBarras As Byte
        On Error GoTo cError
        Select Case Len(CodigoBarras)
            Case 0 To 6
                msgAviso("Introduzca 8 o 13 caracteres numéricos.", MsgBoxStyle.Exclamation)
                Exit Sub
            Case 7 To 11
                tipoCodBarras = 7
                logitudCodigoBarras = 8
            Case 12 To 20
                tipoCodBarras = 12
                logitudCodigoBarras = 13
        End Select
        codigoBarrasF = formarCodBarras(CodigoBarras.Remove(tipoCodBarras))
        CodigoBarras = codigoBarrasF
        dibujarCodigoBarras(ImgEAN.CreateGraphics)
cSalir:
        Exit Sub
cError:
        Select Case Err.Number
            Case 13 : msgAviso("Introduzca sólo números.", MsgBoxStyle.Critical)
            Case Else : msgAviso("Se ha producido un error al intentar " & "generar el código de barras: " & Err.Number.ToString + (" ") + (Err.Description), MsgBoxStyle.Critical)
        End Select
        GoTo cSalir
    End Sub
    Private Function FormarCodBarras(ByVal codBarrasOr As String) As String
        FormarCodBarras = codBarrasOr & comprobarDigitoControl(codBarrasOr)
    End Function
    Private Function ComprobarDigitoControl(ByVal codigoBarras As String) As Byte
        Dim digito, calTotal As Byte
        Dim codTmp As String
        Dim bPal, numC As Byte
        Select Case Len(codigoBarras)
            Case 7, 12
                codTmp = Right("0000000000000000" & codigoBarras, 17)
                bPal = 3
                For numC = 1 To 17
                    calTotal = calTotal + Val(Mid(codTmp, numC, 1)) * bPal
                    bPal = 4 - bPal
                Next
                digito = calTotal Mod 10
                digito = IIf(digito = 0, 0, 10 - digito)
        End Select
        ComprobarDigitoControl = digito
    End Function
    Private Sub msgAviso(ByVal textoAviso As String, style As MsgBoxStyle)
        MsgBox(textoAviso, MsgBoxStyle.Exclamation, My.Application.Info.Title)
    End Sub
    Private Function medIn(ByVal vTextoTmp As Object, ByVal vPosicion As Object) As Object
        medIn = CShort(Mid(vTextoTmp, vPosicion, 1))
    End Function
    Public Sub Guardar(rutaNombreFichEAN As String)
        If logitudCodigoBarras = 0 Then
            msgAviso("No hay código de barras EAN para guardar.", MsgBoxStyle.Exclamation)
        End If
        If Dir(rutaNombreFichEAN) <> "" Then
            Kill(rutaNombreFichEAN)
        End If
        CopiarPictureBox()
        guardarImagen(rutaNombreFichEAN)
    End Sub

    Public Sub DibujarCodigoBarras(ByVal Objeto As Object)
        Dim digCentral As Byte
        Dim lposX, lCurNum, lPrimerNum As Integer
        Dim i, j, iMod As Short

        digCentral = IIf(logitudCodigoBarras = 8, 5, 8)
        Objeto.Clear(Color.White)
        lposX = 11
        For i = 1 To logitudCodigoBarras
            lCurNum = CInt(Mid(codigoBarrasF, i, 1))
            If i = 1 Then
                GuardBar(lposX, Objeto)
                lPrimerNum = lCurNum

                CurrentX = 2
                CurrentY = 66
                Objeto.DrawString(IIf(logitudCodigoBarras = 8, "<", lPrimerNum), TextoFont, Brushes.Black, CurrentX, CurrentY)
            End If
            If i <> 1 Or logitudCodigoBarras = 8 Then
                If i < digCentral Then
                    Select Case logitudCodigoBarras
                        Case 8
                            iMod = 0
                        Case 13
                            iMod = medIn(MdlLeft(lPrimerNum), i - 1)
                    End Select
                Else
                    iMod = 2
                End If
            End If

            If i = digCentral Then
                lposX = lposX + 2
                GuardBar(lposX, Objeto)
                lposX = lposX + 1
            End If

            If i <> 1 Then
                For j = 1 To 7
                    If medIn(Mdl(iMod)(lCurNum), j) = 1 Then
                        dibujarLinea(lposX, 0, Objeto)
                    End If

                    lposX = lposX + 1
                Next j

                CurrentX = lposX - 8
                CurrentY = 66

                If i >= digCentral Then
                    CurrentX = CurrentX - 1
                End If
                Objeto.DrawString(lCurNum, TextoFont, Brushes.Black, CurrentX, CurrentY)

            End If
        Next i

        CurrentX = lposX + 8
        CurrentY = 66

        GuardBar(lposX, Objeto)
        If logitudCodigoBarras = 8 Then
            CurrentX = lposX - 2
            Objeto.DrawString(">", TextoFont, Brushes.Black, CurrentX, CurrentY)

        End If
    End Sub
    Private Sub GuardBar(ByRef posX As Integer, ByVal Objeto As Object)
        dibujarLinea(posX, 6, Objeto)
        dibujarLinea(posX + 2, 6, Objeto)
        posX = posX + 3
    End Sub
    Private Sub DibujarLinea(ByRef posX As Integer, ByRef bExten As Byte, ByVal Objeto As Object)
        Objeto.DrawLine(ColorPen, posX, 5, posX, 66 + bExten)
    End Sub
    Private Sub CopiarVentana()
        Dim gr As Graphics = Form.CreateGraphics
        ' Tamaño de lo que queremos copiar
        Dim fSize As Size = Form.Size
        ' Creamos el bitmap con el área que vamos a capturar
        ' En este caso, con el tamaño del formulario actual
        Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)
        ' Un objeto Graphics a partir del bitmap
        Dim gr2 As Graphics = Graphics.FromImage(bm)
        ' Copiar el área de la pantalla que ocupa el formulario
        gr2.CopyFromScreen(Form.Location.X, Form.Location.Y, 0, 0, fSize)
        ' Asignamos la imagen al PictureBox
        Me.ImgEAN.Image = bm
    End Sub
    Private Sub CopiarPantalla()
        Dim gr As Graphics = Form.CreateGraphics
        ' Tamaño de lo que queremos copiar
        ' En este caso el tamaño de la ventana principal
        Dim fSize As Size = Screen.PrimaryScreen.Bounds.Size
        ' Creamos el bitmap con el área que vamos a capturar
        Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)
        ' Un objeto Graphics a partir del bitmap
        Dim gr2 As Graphics = Graphics.FromImage(bm)
        ' Copiar todo el área de la pantalla
        gr2.CopyFromScreen(0, 0, 0, 0, fSize)

        ' Asignamos la imagen al PictureBox
        Me.ImgEAN.Image = bm
    End Sub
    Private Sub guardarImagen(ByVal txtnombre As String)
        ' Dim txtnombre As String = "imagen.bmp"
        If String.IsNullOrEmpty(txtnombre) Then
            MessageBox.Show("Debes indicar el nombre del fichero",
                            "Guardar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        ' Usar el formato según la extensión
        Dim ext As String = Path.GetExtension(txtnombre).ToLower()
        Select Case ext
            Case ".jpg"
                Me.ImgEAN.Image.Save(txtnombre, ImageFormat.Jpeg)
            Case ".png"
                Me.ImgEAN.Image.Save(txtnombre, ImageFormat.Png)
            Case ".gif"
                Me.ImgEAN.Image.Save(txtnombre, ImageFormat.Gif)
            Case ".bmp"
                Me.ImgEAN.Image.Save(txtnombre, ImageFormat.Bmp)
            Case ".tif"
                Me.ImgEAN.Image.Save(txtnombre, ImageFormat.Tiff)
            Case Else
                Me.ImgEAN.Image.Save(txtnombre)
        End Select
    End Sub
    Private Sub CopiarPictureBox()
        Dim gr As Graphics = Form.CreateGraphics
        ' Tamaño de lo que queremos copiar
        Dim fSize As Size = ImgEAN.Size
        ' Creamos el bitmap con el área que vamos a capturar
        ' En este caso, con el tamaño del formulario actual
        Dim bm As New Bitmap(fSize.Width - 10, fSize.Height - 10, gr)
        ' Un objeto Graphics a partir del bitmap
        Dim gr2 As Graphics = Graphics.FromImage(bm)
        ' Copiar el área de la pantalla que ocupa el formulario
        gr2.CopyFromScreen(Form.Location.X + ImgEAN.Location.X + 5, Form.Location.Y + ImgEAN.Location.Y + 30, 0, 0, fSize)
        ' Asignamos la imagen al PictureBox
        Me.ImgEAN.Image = bm
    End Sub
End Class
