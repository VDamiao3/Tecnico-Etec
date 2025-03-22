Imports Aforge.Video.DirectShow
Imports BarcodeLib.BarcodeReader
Public Class Leitura_Qr


    Private disoisitivos As FilterInfoCollection
    Private fonteVideo As VideoCaptureDevice



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Start()
        fonteVideo = New VideoCaptureDevice(disoisitivos(ComboBox1.SelectedIndex).MonikerString)
        VideoSourcePlayer1.VideoSource = fonteVideo
        VideoSourcePlayer1.Start()


    End Sub

    Private Sub Leitura_Qr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disoisitivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each x As FilterInfo In disoisitivos
            ComboBox1.Items.Add(x.Name)
        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If VideoSourcePlayer1.GetCurrentVideoFrame() IsNot Nothing Then
            Dim img As New Bitmap(VideoSourcePlayer1.GetCurrentVideoFrame)
            Dim resultados As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)
            img.Dispose()
            If resultados IsNot Nothing AndAlso resultados.Count > 0 Then
                ListBox1.Items.Add(resultados(0))
            End If

        End If
    End Sub

    Private Sub VideoSourcePlayer1_Click(sender As Object, e As EventArgs) Handles VideoSourcePlayer1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        VideoSourcePlayer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Close()
    End Sub
End Class