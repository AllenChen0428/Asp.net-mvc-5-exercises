Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim P01 As String = Request.Form("account number")
        Dim P02 As String = Request.Form("password")
        'Dim P03 As String = Request.Form("login01")

        Context.Response.Write(P01)
        Context.Response.Write(P02)
        'Context.Response.Write(P03)
        Context.Response.End()

    End Sub

End Class