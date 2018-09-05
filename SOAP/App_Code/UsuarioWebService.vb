Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports Modelo.Modelo
Imports System.Collections.Generic

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class UsuarioWebService
    Inherits System.Web.Services.WebService
    Public Property iusuario As IUsuariosCRUD
    <WebMethod()> _
    Public Function Fetch() As List(Of Usuario)
        Dim iusuario As IUsuariosCRUD
        Return iusuario.BuscarUsuarios("")
    End Function
    <WebMethod()> _
    Public Function Save(usuario As Usuario) As Boolean
        Try
            iusuario.Crear(usuario)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    <WebMethod()> _
    Public Function Actualizar(usuario As Usuario, usuarioModif As Usuario) As Boolean
        Try
            iusuario.Actualizar(usuario, usuarioModif)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class