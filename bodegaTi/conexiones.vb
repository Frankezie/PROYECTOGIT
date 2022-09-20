
Imports System.Data.SqlClient

Module conexiones
    Friend conexion As New SqlConnection(My.Settings.conexion)
    Friend rut_usuario As String = ""
    Friend usuario As String = ""
    Friend tipo_usuario As String = ""
    Friend areas As String = ""



    Friend login As Integer = 0
    Friend fecha As Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Friend f As Date = DateTime.Now.ToString

    'Friend formulario_despacho As New Form_ingreso_despacho
    Friend sc As New SqlCommand



    Friend da As New SqlDataAdapter
    Friend ds As New DataSet()
    Friend dt As New DataTable

    Friend sc1 As New SqlCommand
    Friend da1 As New SqlDataAdapter
    Friend ds1 As New DataSet()
    Friend dt1 As New DataTable

    Friend sc2 As New SqlCommand
    Friend da2 As New SqlDataAdapter
    Friend ds2 As New DataSet()
    Friend dt2 As New DataTable

    Friend sc3 As New SqlCommand
    Friend da3 As New SqlDataAdapter
    Friend ds3 As New DataSet()
    Friend dt3 As New DataTable

    Friend sc4 As New SqlCommand
    Friend da4 As New SqlDataAdapter
    Friend ds4 As New DataSet()
    Friend dt4 As New DataTable

    Friend sc5 As New SqlCommand
    Friend da5 As New SqlDataAdapter
    Friend ds5 As New DataSet()
    Friend dt5 As New DataTable

    Friend sc6 As New SqlCommand
    Friend da6 As New SqlDataAdapter
    Friend ds6 As New DataSet()
    Friend dt6 As New DataTable

    Friend sc7 As New SqlCommand
    Friend da7 As New SqlDataAdapter
    Friend ds7 As New DataSet()
    Friend dt7 As New DataTable

    Friend sc8 As New SqlCommand
    Friend da8 As New SqlDataAdapter
    Friend ds8 As New DataSet()
    Friend dt8 As New DataTable

    Friend sc9 As New SqlCommand
    Friend da9 As New SqlDataAdapter
    Friend ds9 As New DataSet()
    Friend dt9 As New DataTable

    Friend sc10 As New SqlCommand
    Friend da10 As New SqlDataAdapter
    Friend ds10 As New DataSet()
    Friend dt10 As New DataTable

    Friend sc11 As New SqlCommand
    Friend da11 As New SqlDataAdapter
    Friend ds11 As New DataSet()
    Friend dt11 As New DataTable

    Friend sc12 As New SqlCommand
    Friend da12 As New SqlDataAdapter
    Friend ds12 As New DataSet()
    Friend dt12 As New DataTable
End Module
