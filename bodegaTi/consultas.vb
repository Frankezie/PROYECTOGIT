Imports System.Data.SqlClient






Module consultas

    Sub miconsulta(ByVal varsql As String)

        conexion.Close()
        ds.Tables.Clear()
        dt.Rows.Clear()
        dt.Columns.Clear()
        ds.Clear()
        conexion.Open()

        sc.Connection = conexion
        sc.CommandText = varsql
        da.SelectCommand = sc
        da.Fill(dt)
        ds.Tables.Add(dt)
        conexion.Close()

    End Sub

    Sub miconsulta1(ByVal varsql As String)

        conexion.Close()
        ds1.Tables.Clear()
        dt1.Rows.Clear()
        dt1.Columns.Clear()
        ds1.Clear()
        conexion.Open()

        sc1.Connection = conexion
        sc1.CommandText = varsql
        da1.SelectCommand = sc1
        da1.Fill(dt1)
        ds1.Tables.Add(dt1)
        conexion.Close()

    End Sub

    Sub miconsulta2(ByVal varsql As String)

        conexion.Close()
        ds2.Tables.Clear()
        dt2.Rows.Clear()
        dt2.Columns.Clear()
        ds2.Clear()
        conexion.Open()

        sc2.Connection = conexion
        sc2.CommandText = varsql
        da2.SelectCommand = sc2
        da2.Fill(dt2)
        ds2.Tables.Add(dt2)
        conexion.Close()

    End Sub

    Sub miconsulta3(ByVal varsql As String)

        conexion.Close()
        ds3.Tables.Clear()
        dt3.Rows.Clear()
        dt3.Columns.Clear()
        ds3.Clear()
        conexion.Open()

        sc3.Connection = conexion
        sc3.CommandText = varsql
        da3.SelectCommand = sc3
        da3.Fill(dt3)
        ds3.Tables.Add(dt3)
        conexion.Close()

    End Sub

    Sub miconsulta4(ByVal varsql As String)

        conexion.Close()
        ds4.Tables.Clear()
        dt4.Rows.Clear()
        dt4.Columns.Clear()
        ds4.Clear()
        conexion.Open()

        sc4.Connection = conexion
        sc4.CommandText = varsql
        da4.SelectCommand = sc4
        da4.Fill(dt4)
        ds4.Tables.Add(dt4)
        conexion.Close()

    End Sub
    Sub miconsulta5(ByVal varsql As String)

        conexion.Close()
        ds5.Tables.Clear()
        dt5.Rows.Clear()
        dt5.Columns.Clear()
        ds5.Clear()
        conexion.Open()

        sc5.Connection = conexion
        sc5.CommandText = varsql
        da5.SelectCommand = sc5
        da5.Fill(dt5)
        ds5.Tables.Add(dt5)
        conexion.Close()

    End Sub
    Sub miconsulta6(ByVal varsql As String)

        conexion.Close()
        ds6.Tables.Clear()
        dt6.Rows.Clear()
        dt6.Columns.Clear()
        ds6.Clear()
        conexion.Open()

        sc6.Connection = conexion
        sc6.CommandText = varsql
        da6.SelectCommand = sc6
        da6.Fill(dt6)
        ds6.Tables.Add(dt6)
        conexion.Close()

    End Sub
    Sub miconsulta7(ByVal varsql As String)

        conexion.Close()
        ds7.Tables.Clear()
        dt7.Rows.Clear()
        dt7.Columns.Clear()
        ds7.Clear()
        conexion.Open()

        sc7.Connection = conexion
        sc7.CommandText = varsql
        da7.SelectCommand = sc7
        da7.Fill(dt7)
        ds7.Tables.Add(dt7)
        conexion.Close()

    End Sub

    Sub miconsulta8(ByVal varsql As String)

        conexion.Close()
        ds8.Tables.Clear()
        dt8.Rows.Clear()
        dt8.Columns.Clear()
        ds8.Clear()
        conexion.Open()

        sc8.Connection = conexion
        sc8.CommandText = varsql
        da8.SelectCommand = sc8
        da8.Fill(dt8)
        ds8.Tables.Add(dt8)
        conexion.Close()

    End Sub
    Sub miconsulta9(ByVal varsql As String)

        conexion.Close()
        ds9.Tables.Clear()
        dt9.Rows.Clear()
        dt9.Columns.Clear()
        ds9.Clear()
        conexion.Open()

        sc9.Connection = conexion
        sc9.CommandText = varsql
        da9.SelectCommand = sc9
        da9.Fill(dt9)
        ds9.Tables.Add(dt9)
        conexion.Close()

    End Sub
    Sub miconsulta10(ByVal varsql As String)

        conexion.Close()
        ds10.Tables.Clear()
        dt10.Rows.Clear()
        dt10.Columns.Clear()
        ds10.Clear()
        conexion.Open()

        sc10.Connection = conexion
        sc10.CommandText = varsql
        da10.SelectCommand = sc10
        da10.Fill(dt10)
        ds10.Tables.Add(dt10)
        conexion.Close()

    End Sub
    Sub miconsulta11(ByVal varsql As String)

        conexion.Close()
        ds11.Tables.Clear()
        dt11.Rows.Clear()
        dt11.Columns.Clear()
        ds11.Clear()
        conexion.Open()

        sc11.Connection = conexion
        sc11.CommandText = varsql
        da11.SelectCommand = sc11
        da11.Fill(dt11)
        ds11.Tables.Add(dt11)
        conexion.Close()

    End Sub
    Sub miconsulta12(ByVal varsql As String)

        conexion.Close()
        ds12.Tables.Clear()
        dt12.Rows.Clear()
        dt12.Columns.Clear()
        ds12.Clear()
        conexion.Open()

        sc12.Connection = conexion
        sc12.CommandText = varsql
        da12.SelectCommand = sc12
        da12.Fill(dt12)
        ds12.Tables.Add(dt12)
        conexion.Close()

    End Sub
End Module
