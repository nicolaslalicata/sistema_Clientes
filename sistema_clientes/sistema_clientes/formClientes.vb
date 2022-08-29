Imports System.Data.SqlClient
Public Class formClientes
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnModified.Click
        Dim cmd As New SqlCommand
        If txtNumeroUsuario.Text <> "" And NombreCompleto.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("Editar_Cliente", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idClientes", txtNumeroUsuario.Text)
                cmd.Parameters.AddWithValue("@Nombre", NombreCompleto.Text.ToString)
                cmd.Parameters.AddWithValue("@Direccion", Direccion.Text.ToString)
                cmd.Parameters.AddWithValue("@Telefono", Telefono.Text)
                cmd.Parameters.AddWithValue("@Observaciones", Observaciones.Text.ToString)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()
                panelDatos.Visible = False
                panelBusqueda.Visible = True
                Limpiar()
                Mostrar()
            Catch ex As Exception
            End Try
        Else
            MsgBox("El campo Nombre Completo es obligatorio", vbInformation + vbOKOnly, "Sistema de Registro")
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        panelDatos.Visible = True
        panelBusqueda.Visible = False
        btnModified.Visible = False
        btnSave.Enabled = True
        btnModified.Enabled = False
        btnCerrar.Enabled = True
        btnSave.Visible = True
        txtNumeroUsuario.Enabled = True
        txtNumeroUsuario.Focus()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Limpiar()
        btnSave.Enabled = True
        btnModified.Enabled = True
        panelDatos.Visible = False
        panelBusqueda.Visible = True
    End Sub
    Private Sub Limpiar()
        txtNumeroUsuario.Clear()
        NombreCompleto.Clear()
        Telefono.Clear()
        Direccion.Clear()
        Observaciones.Clear()
        txtNumeroUsuario.Focus()
    End Sub
    Private Sub dataClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataClientes.CellContentClick
        'Verificar si se ha dado Click sobre la columna de Editar
        If e.ColumnIndex = dataClientes.Columns.Item("Editar").Index Then
            Dim edited As DialogResult
            edited = MsgBox("El registro será editado. ¿Seguro quiere editar este registro?", vbQuestion + vbOKCancel, "Sistema de Registro")
            If edited = DialogResult.OK Then
                panelDatos.Visible = True
                btnModified.Visible = True
                btnModified.Enabled = True
                txtNumeroUsuario.Enabled = False
                btnSave.Visible = False
                Try
                    txtNumeroUsuario.Text = dataClientes.SelectedCells.Item(2).Value
                    NombreCompleto.Text = dataClientes.SelectedCells.Item(3).Value
                    Telefono.Text = dataClientes.SelectedCells.Item(4).Value
                    Direccion.Text = dataClientes.SelectedCells.Item(5).Value
                    Observaciones.Text = dataClientes.SelectedCells.Item(6).Value
                    btnSave.Visible = False
                    panelBusqueda.Visible = False
                Catch ex As Exception
                End Try
            Else
                MsgBox("Edición de cliente cancelada", vbInformation + vbOKOnly, "Sistema de Registro")
            End If
        End If
        'Verificar si se ha dado Click sobre la columna de Eliminar
        If e.ColumnIndex = dataClientes.Columns.Item("Eliminar").Index Then
            Dim result As DialogResult
            result = MsgBox("El registro será borrado del sistema. ¿Desea eliminar este registro?", vbQuestion + vbOKCancel, "Sistema de Registro")
            If result = DialogResult.OK Then
                Dim cmd As SqlCommand
                Try
                    Abrir_Conexion()
                    cmd = New SqlCommand("Eliminar_Cliente", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@IdClientes", dataClientes.SelectedCells.Item(2).Value)
                    cmd.ExecuteNonQuery()
                    Cerrar_Conexion()
                    Mostrar()
                Catch ex As Exception
                End Try
            Else
                MsgBox("Eliminación de cliente cancelada", vbInformation + vbOKOnly, "Sistema de Registro")
            End If
        End If
    End Sub
    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Mostrar_Cliente", conexion)
            da.Fill(dt)
            dataClientes.DataSource = dt
            Cerrar_Conexion()
            'Cambiar ancho de las columnas (encabezados)
            dataClientes.Columns(0).Width = 35
            dataClientes.Columns(1).Width = 35
            dataClientes.Columns(2).Width = 120
            dataClientes.Columns(3).Width = 150
            dataClientes.Columns(4).Width = 100
            dataClientes.Columns(5).Width = 180
            dataClientes.Columns(6).Width = 200
            'Cambiar ancho de los encabezados
            dataClientes.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Roboto", 8, FontStyle.Regular Or FontStyle.Bold)
            dataClientes.ColumnHeadersDefaultCellStyle = estilo
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New SqlCommand
        If txtNumeroUsuario.Text <> "" And NombreCompleto.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("Insertar_Clientes", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@idClientes", txtNumeroUsuario.Text)
                cmd.Parameters.AddWithValue("@Nombre", NombreCompleto.Text.ToString)
                cmd.Parameters.AddWithValue("@Direccion", Direccion.Text.ToString)
                cmd.Parameters.AddWithValue("@Telefono", Telefono.Text)
                cmd.Parameters.AddWithValue("@Observaciones", Observaciones.Text.ToString)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()
                panelDatos.Visible = False
                panelBusqueda.Visible = True
                Limpiar()
                Mostrar()

            Catch ex As Exception
            End Try
        Else
            MsgBox("Los campos N° Usuario y Nombre Completo son obligatorios", vbInformation + vbOKOnly, "Sistema de Registro")
        End If
    End Sub
    Sub Buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Buscar_Clientes", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Busqueda", txtBuscar.Text)
            da.Fill(dt)
            dataClientes.DataSource = dt
            Cerrar_Conexion()
            'Cambiar ancho de las columnas (encabezados)
            dataClientes.Columns(0).Width = 35
            dataClientes.Columns(1).Width = 35
            dataClientes.Columns(2).Width = 120
            dataClientes.Columns(3).Width = 150
            dataClientes.Columns(4).Width = 100
            dataClientes.Columns(5).Width = 180
            dataClientes.Columns(6).Width = 200
            'Cambiar ancho de los encabezados
            dataClientes.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Roboto", 8, FontStyle.Regular Or FontStyle.Bold)
            dataClientes.ColumnHeadersDefaultCellStyle = estilo
        Catch ex As Exception
        End Try
    End Sub
    Private Sub formClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mostrar()
    End Sub
    Private Sub dataClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataClientes.CellContentDoubleClick
        panelDatos.Visible = True
        btnModified.Visible = True
        btnModified.Enabled = True
        txtNumeroUsuario.Enabled = False
        btnSave.Visible = False
        panelBusqueda.Visible = False
        Try
            txtNumeroUsuario.Text = dataClientes.SelectedCells.Item(2).Value
            NombreCompleto.Text = dataClientes.SelectedCells.Item(3).Value
            Telefono.Text = dataClientes.SelectedCells.Item(4).Value
            Direccion.Text = dataClientes.SelectedCells.Item(5).Value
            Observaciones.Text = dataClientes.SelectedCells.Item(6).Value
            btnSave.Visible = False
        Catch ex As Exception
        End Try
    End Sub
End Class
