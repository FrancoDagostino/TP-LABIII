Imports System.Data.OleDb
Public Class Provincias
    Dim Cad As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\\Incendios.mdb"
    Dim CONECTOR As New OleDbConnection(Cad)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Provincias"
        ADAPTADOR.Fill(TABLA)

        Dim VEC(1) As DataColumn
        VEC(0) = TABLA.Columns("numero")
        TABLA.PrimaryKey = VEC
    End Sub


    Public Sub LlenarCombo(ByVal Combo As ComboBox)
        Combo.DisplayMember = "provincia"
        Combo.ValueMember = "numero"
        Combo.DataSource = TABLA
    End Sub

    Public Function TablaPRO() As DataTable
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Provincias"
        ADAPTADOR.Fill(TABLA)
        Return TABLA
    End Function




End Class
