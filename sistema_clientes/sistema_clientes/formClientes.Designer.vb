<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formClientes))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.panelBusqueda = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModified = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Observaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.NombreCompleto = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNumeroUsuario = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.dataClientes = New System.Windows.Forms.DataGridView()
        Me.panelLateral = New System.Windows.Forms.Panel()
        Me.btnAgregar = New System.Windows.Forms.PictureBox()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PanelTitulo.SuspendLayout()
        Me.panelBusqueda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMain.SuspendLayout()
        Me.panelDatos.SuspendLayout()
        CType(Me.dataClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLateral.SuspendLayout()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Controls.Add(Me.Titulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(661, 38)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(610, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(51, 38)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(10, 6)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(227, 25)
        Me.Titulo.TabIndex = 1
        Me.Titulo.Text = "AGENDA DE CLIENTES"
        '
        'panelBusqueda
        '
        Me.panelBusqueda.BackColor = System.Drawing.Color.White
        Me.panelBusqueda.Controls.Add(Me.txtBuscar)
        Me.panelBusqueda.Controls.Add(Me.PictureBox1)
        Me.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBusqueda.Location = New System.Drawing.Point(0, 38)
        Me.panelBusqueda.Name = "panelBusqueda"
        Me.panelBusqueda.Size = New System.Drawing.Size(661, 31)
        Me.panelBusqueda.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(39, 3)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(346, 23)
        Me.txtBuscar.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.Controls.Add(Me.panelDatos)
        Me.panelMain.Controls.Add(Me.dataClientes)
        Me.panelMain.Controls.Add(Me.panelLateral)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 69)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(661, 311)
        Me.panelMain.TabIndex = 2
        '
        'panelDatos
        '
        Me.panelDatos.Controls.Add(Me.btnCancel)
        Me.panelDatos.Controls.Add(Me.btnModified)
        Me.panelDatos.Controls.Add(Me.btnSave)
        Me.panelDatos.Controls.Add(Me.Observaciones)
        Me.panelDatos.Controls.Add(Me.lblObservaciones)
        Me.panelDatos.Controls.Add(Me.Direccion)
        Me.panelDatos.Controls.Add(Me.lblDireccion)
        Me.panelDatos.Controls.Add(Me.Telefono)
        Me.panelDatos.Controls.Add(Me.lblTelefono)
        Me.panelDatos.Controls.Add(Me.NombreCompleto)
        Me.panelDatos.Controls.Add(Me.lblNombre)
        Me.panelDatos.Controls.Add(Me.txtNumeroUsuario)
        Me.panelDatos.Controls.Add(Me.lblId)
        Me.panelDatos.Location = New System.Drawing.Point(0, 0)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(661, 311)
        Me.panelDatos.TabIndex = 2
        Me.panelDatos.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(415, 274)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 34)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnModified
        '
        Me.btnModified.BackColor = System.Drawing.Color.Teal
        Me.btnModified.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModified.FlatAppearance.BorderSize = 0
        Me.btnModified.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModified.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModified.ForeColor = System.Drawing.Color.White
        Me.btnModified.Location = New System.Drawing.Point(294, 274)
        Me.btnModified.Name = "btnModified"
        Me.btnModified.Size = New System.Drawing.Size(91, 34)
        Me.btnModified.TabIndex = 11
        Me.btnModified.Text = "Modificar"
        Me.btnModified.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGreen
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.Location = New System.Drawing.Point(294, 274)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 34)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Observaciones
        '
        Me.Observaciones.Location = New System.Drawing.Point(209, 182)
        Me.Observaciones.Multiline = True
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Size = New System.Drawing.Size(353, 77)
        Me.Observaciones.TabIndex = 9
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(58, 181)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(113, 19)
        Me.lblObservaciones.TabIndex = 8
        Me.lblObservaciones.Text = "Observaciones"
        '
        'Direccion
        '
        Me.Direccion.Location = New System.Drawing.Point(209, 146)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(353, 20)
        Me.Direccion.TabIndex = 7
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(58, 145)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(75, 19)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Dirección"
        '
        'Telefono
        '
        Me.Telefono.Location = New System.Drawing.Point(209, 110)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(353, 20)
        Me.Telefono.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(58, 109)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Teléfono"
        '
        'NombreCompleto
        '
        Me.NombreCompleto.Location = New System.Drawing.Point(209, 73)
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.Size = New System.Drawing.Size(353, 20)
        Me.NombreCompleto.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(58, 72)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(137, 19)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre Completo"
        '
        'txtNumeroUsuario
        '
        Me.txtNumeroUsuario.Location = New System.Drawing.Point(209, 37)
        Me.txtNumeroUsuario.Name = "txtNumeroUsuario"
        Me.txtNumeroUsuario.Size = New System.Drawing.Size(353, 20)
        Me.txtNumeroUsuario.TabIndex = 1
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(58, 37)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(84, 19)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "N° Usuario"
        '
        'dataClientes
        '
        Me.dataClientes.AllowUserToAddRows = False
        Me.dataClientes.AllowUserToDeleteRows = False
        Me.dataClientes.AllowUserToResizeColumns = False
        Me.dataClientes.AllowUserToResizeRows = False
        Me.dataClientes.BackgroundColor = System.Drawing.Color.White
        Me.dataClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.Editar})
        Me.dataClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataClientes.GridColor = System.Drawing.Color.White
        Me.dataClientes.Location = New System.Drawing.Point(0, 0)
        Me.dataClientes.Name = "dataClientes"
        Me.dataClientes.ReadOnly = True
        Me.dataClientes.RowHeadersVisible = False
        Me.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataClientes.Size = New System.Drawing.Size(487, 311)
        Me.dataClientes.TabIndex = 1
        '
        'panelLateral
        '
        Me.panelLateral.Controls.Add(Me.btnAgregar)
        Me.panelLateral.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelLateral.Location = New System.Drawing.Point(487, 0)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(174, 311)
        Me.panelLateral.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(0, 73)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(174, 139)
        Me.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.TabStop = False
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Editar
        '
        Me.Editar.HeaderText = ""
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        '
        'formClientes
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 380)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.panelBusqueda)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.panelBusqueda.ResumeLayout(False)
        Me.panelBusqueda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMain.ResumeLayout(False)
        Me.panelDatos.ResumeLayout(False)
        Me.panelDatos.PerformLayout()
        CType(Me.dataClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLateral.ResumeLayout(False)
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Titulo As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents panelMain As Panel
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregar As PictureBox
    Friend WithEvents dataClientes As DataGridView
    Friend WithEvents panelDatos As Panel
    Friend WithEvents Observaciones As TextBox
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents Direccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Telefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents NombreCompleto As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNumeroUsuario As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnModified As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents Editar As DataGridViewImageColumn
End Class
