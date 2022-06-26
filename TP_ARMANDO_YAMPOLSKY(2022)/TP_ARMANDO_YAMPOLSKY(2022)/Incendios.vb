Imports System.Data.OleDb
Public Class Incendios
    Dim Cad As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\\Incendios.mdb"



    Public Sub New()
        'COMANDO.Connection = CONECTOR
        'COMANDO.CommandType = CommandType.Text
        'COMANDO.CommandText = "select * from incendios where provincia = 'Buenos Aires'"
        'ADAPTADOR.Fill(TABLA)

        'Dim VEC(1) As DataColumn
        'VEC(0) = TABLA.Columns("anio")
        'TABLA.PrimaryKey = VEC
    End Sub

    'Public Function TablaINC() As DataTable
    '    COMANDO.Connection = CONECTOR
    '    COMANDO.CommandType = CommandType.Text
    '    COMANDO.CommandText = "select * from incendios where anio = 1993"
    '    ADAPTADOR.Fill(TABLA)
    '    Return TABLA
    'End Function

    Function llenarGridView(ByVal Grid As DataGridView, provincia As String) As DataGridView
        Dim TABLA As New DataTable
        Dim CONECTOR As New OleDbConnection(Cad)
        Dim COMANDO As New OleDbCommand
        Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        COMANDO.CommandText = "select * from incendios where provincia = (?)"
        COMANDO.Parameters.AddWithValue("provincia", provincia)
        ADAPTADOR.Fill(TABLA)


        Grid.DataSource = TABLA

        Return Grid

    End Function

    Function llenarGridViewporNumeros(ByVal Grid As DataGridView, anio As Integer) As DataGridView
        Dim TABLA As New DataTable
        Dim CONECTOR As New OleDbConnection(Cad)
        Dim COMANDO As New OleDbCommand
        Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        COMANDO.CommandText = "select * from incendios where anio = (?)"
        COMANDO.Parameters.AddWithValue("anio", anio)
        ADAPTADOR.Fill(TABLA)


        Grid.DataSource = TABLA

        Return Grid

    End Function

    Public Sub graficarAnio(graf As DataVisualization.Charting.Chart, anio As Integer)
        Dim TABLA As New DataTable
        Dim CONECTOR As New OleDbConnection(Cad)
        Dim COMANDO As New OleDbCommand
        Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        COMANDO.CommandText = "select total_numero from incendios where anio = (?)"
        COMANDO.Parameters.AddWithValue("anio", anio)
        ADAPTADOR.Fill(TABLA)

        ' este procedimiento genera el gráfico de producción por localidad usando enlace a datos,
        ' se usa el método DataBindTable() para vincular una tabla temporal con el gráfico
        Dim NombreCultivo As String = ""

        graf.Series.Clear() ' limpiar el gráfico
        graf.Titles.Clear() ' se limpian los títulos

        'crear la tabla temporal y agregar las columnas necesarias para el gráfico

        'agregar los registros a la tabla temporal
        'For Each dr As DataRow In TABLA.Rows ' se recorre la tabla de Producción
        '    Dim drT = TABLA.NewRow ' se crea un nuevo registro vacío de la tabla temporal
        '    drT("total_numero") = dr("total_numero")
        '    TABLA.Rows.Add(drT) ' se agrega el registro nuevo a la tabla temporal
        'Next
        ' vincular el gráfico con la tabla temporal, se usa la propiedad DefaultView de la tabla
        graf.DataBindTable(TABLA.DefaultView) ' automáticamente se agrega la serie
        'agregar el título al eje Y
        ' titulo del eje X
        graf.Series(0).Name = "Incendios"
        graf.ChartAreas(0).AxisX.Title = "Incendios totales"
        ' titulo del gráfico
        graf.Titles.Add("Incendios año" & anio.ToString())
    End Sub


    Public Sub graficarProv(graf As DataVisualization.Charting.Chart, provincia As String)
        Dim I As Integer = 0
        Dim TABLA As New DataTable
        Dim CONECTOR As New OleDbConnection(Cad)
        Dim COMANDO As New OleDbCommand
        Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.Text
        COMANDO.CommandText = "select total_numero,anio from incendios where provincia = (?)"
        COMANDO.Parameters.AddWithValue("provincia", provincia)
        ADAPTADOR.Fill(TABLA)

        Dim tabla_totalnumero As New DataTable
        Dim NombreCultivo As String = ""

        graf.Series.Clear() ' limpiar el gráfico
        graf.Titles.Clear() ' se limpian los títulos

        tabla_totalnumero.Columns.Add("total_numero")
        For Each dr As DataRow In TABLA.Rows ' se recorre la tabla de Producción
            Dim drT = tabla_totalnumero.NewRow ' se crea un nuevo registro vacío de la tabla temporal
            drT("total_numero") = dr("total_numero")
            tabla_totalnumero.Rows.Add(drT) ' se agrega el registro nuevo a la tabla temporal
        Next
        graf.DataBindTable(tabla_totalnumero.DefaultView)

        graf.ChartAreas(0).AxisY.Title = "Incendios Totales"

        For Each dt As DataRow In TABLA.Rows

            graf.Series(0).Points(I).AxisLabel = dt("anio")
            I += 1

        Next
        graf.Series(0).Name = "Incendios"
        ' titulo del gráfico
        graf.Titles.Add(provincia.ToString())
    End Sub

End Class
