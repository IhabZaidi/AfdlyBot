Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.ShowIcon = False
        Me.Hide()
        WebBrowser1.ScriptErrorsSuppressed = True 'ايقاف ايرور مسجات جافا سكربت
        WebBrowser1.Navigate("link here !")
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If WebBrowser1.ReadyState = WebBrowserReadyState.Complete _
            AndAlso WebBrowser1.Document.GetElementById("skip_ad_button").Id = "skip_ad_button" Then
                Timer1.Stop()

                WebBrowser1.Document.GetElementById("skip_ad_button").InvokeMember("click")
            End If
        Catch : End Try
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        WebBrowser1.Navigate("link here !")
        Timer3.Start()
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            If WebBrowser1.ReadyState = WebBrowserReadyState.Complete _
            AndAlso WebBrowser1.Document.GetElementById("skip_ad_button").Id = "skip_ad_button" Then
                Timer3.Stop()

                WebBrowser1.Document.GetElementById("skip_ad_button").InvokeMember("click")
            End If
        Catch : End Try
        Timer4.Start()
        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        WebBrowser1.Navigate("link here !")
        Timer5.Start()
        Timer4.Stop()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Try
            If WebBrowser1.ReadyState = WebBrowserReadyState.Complete _
            AndAlso WebBrowser1.Document.GetElementById("skip_ad_button").Id = "skip_ad_button" Then
                Timer5.Stop()

                WebBrowser1.Document.GetElementById("skip_ad_button").InvokeMember("click")
            End If
        Catch : End Try       
        Timer1.Start()
        Timer5.Stop()
    End Sub
End Class
