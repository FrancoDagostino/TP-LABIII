Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Form1
    Dim objPROV As New Provincias
    Dim objINC As New Incendios
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objPROV.LlenarCombo(CBProvincias)
        NUDAnio.Maximum = 2022
        NUDAnio.Minimum = 1993

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = False Then
            objINC.llenarGridView(GRILLA, CBProvincias.Text.ToString())
            objINC.graficarProv(ChartINC, CBProvincias.Text.ToString())
        Else
            objINC.llenarGridViewporNumeros(GRILLA, NUDAnio.Value)
            objINC.graficarAnio(ChartINC, NUDAnio.Value)

        End If

































        'Dim SER As Series
        'If RadioButton1.Checked Then
        '    Dim Nanio As Integer = NUDAnio.Value
        '    Dim TV As DataTable = objINC.TablaINC
        '    GRILLA.Rows.Clear()
        '    ' Try
        '    'GRILLA.Rows.Clear()
        '    ChartINC.Series.Clear()
        '    For Each fila As DataRow In TV.Rows
        '            SER = ChartINC.Series.Add(fila("anio"))
        '            Dim can As Long = 0
        '            If fila("anio") = Nanio Then
        '                GRILLA.Rows.Add(fila("anio"), fila("provincia"), fila("total_numero"), fila("negligencia_numero"), fila("intencional_numero"), fila("natural_numero"), fila("desconocida_numero"))
        '                can = can + fila("total_numero")

        '            End If
        '            SER.Points.AddXY(fila("provincia"), can)
        '        Next
        '        ChartINC.Titles.Clear()
        '        ChartINC.Titles.Add("Cantidad de incendios en el año")
        '    'Catch ex As Exception
        '    ' MessageBox.Show("Incgrese los datos correctos", "ERROR")
        '    ' End Try

        'End If

        'If RadioButton2.Checked Then
        '    Dim Prov As Integer = CBProvincias.SelectedValue
        '    Dim Provincia As String = ""
        '    Dim TV As DataTable = objINC.TablaINC
        '    Dim TP As DataTable = objPROV.TablaPRO
        '    GRILLA.Rows.Clear()
        '    Try
        '        ' GRILLA.Rows.Clear()

        '        For Each fila As DataRow In TP.Rows
        '            If fila("numero") = Prov Then
        '                For Each fil As DataRow In TV.Rows
        '                    'If fila("provincia") = fil("provincia") Then
        '                    '    Provincia = fila("provincia")
        '                    'End If
        '                    GRILLA.Rows.Add(fil("anio"), fila("provincia"), fil("total_numero"), fil("negligencia_numero"), fil("intencional_numero"), fil("natural_numero"), fil("desconocida_numero"))
        '                Next
        '            End If
        '        Next
        '    Catch ex As Exception
        '        MessageBox.Show("Incgrese los datos correctos", "ERROR")
        '    End Try
        'End If


        'Dim TINC As DataTable = objINC.TablaINC
        'For Each RINC As DataRow In TINC.Rows

        'Next
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            NUDAnio.Enabled = True
            CBProvincias.Enabled = False
        Else
            NUDAnio.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            CBProvincias.Enabled = True
            NUDAnio.Enabled = False
        Else
            CBProvincias.Enabled = False
        End If
    End Sub

End Class
