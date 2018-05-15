<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EstadoDaletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesDataSet = New ListaProcesaMedia.MaterialesDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DatefpMetaDataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitolEmissioSeriematerialProvysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitolEmissioCapitolmaterialProvysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitolOriginalSeriematerialProvysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrlproxydaletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QcDaletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.QcVisionadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.QcTecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PendientesVisualizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesDataSetAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesDataSetAll = New ListaProcesaMedia.MaterialesDataSetAll()
        Me.FileprocessmetadataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FileprocessmetadataTableAdapter = New ListaProcesaMedia.MaterialesDataSetTableAdapters.fileprocessmetadataTableAdapter()
        Me.EstadoDaletTableAdapter = New ListaProcesaMedia.MaterialesDataSetTableAdapters.estadoDaletTableAdapter()
        Me.MaterialesDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pendientes_VisualizacionTableAdapter = New ListaProcesaMedia.MaterialesDataSetAllTableAdapters.pendientes_VisualizacionTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.EstadoDaletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PendientesVisualizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesDataSetAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesDataSetAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileprocessmetadataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.CausesValidation = False
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBox1.DataSource = Me.EstadoDaletBindingSource
        Me.ComboBox1.DisplayMember = "nombre_estadoDalet"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "id_estadoDalet"
        '
        'EstadoDaletBindingSource
        '
        Me.EstadoDaletBindingSource.DataMember = "estadoDalet"
        Me.EstadoDaletBindingSource.DataSource = Me.MaterialesDataSetBindingSource
        '
        'MaterialesDataSetBindingSource
        '
        Me.MaterialesDataSetBindingSource.DataSource = Me.MaterialesDataSet
        Me.MaterialesDataSetBindingSource.Position = 0
        '
        'MaterialesDataSet
        '
        Me.MaterialesDataSet.DataSetName = "MaterialesDataSet"
        Me.MaterialesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DatefpMetaDataDataGridViewTextBoxColumn, Me.ItemCodeDataGridViewTextBoxColumn, Me.TitolEmissioSeriematerialProvysDataGridViewTextBoxColumn, Me.TitolEmissioCapitolmaterialProvysDataGridViewTextBoxColumn, Me.TitolOriginalSeriematerialProvysDataGridViewTextBoxColumn, Me.UrlproxydaletDataGridViewTextBoxColumn, Me.QcDaletDataGridViewTextBoxColumn, Me.QcVisionadosDataGridViewTextBoxColumn, Me.QcTecnicoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PendientesVisualizacionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1325, 342)
        Me.DataGridView1.TabIndex = 1
        '
        'DatefpMetaDataDataGridViewTextBoxColumn
        '
        Me.DatefpMetaDataDataGridViewTextBoxColumn.DataPropertyName = "date_fpMetaData"
        Me.DatefpMetaDataDataGridViewTextBoxColumn.HeaderText = "date_fpMetaData"
        Me.DatefpMetaDataDataGridViewTextBoxColumn.Name = "DatefpMetaDataDataGridViewTextBoxColumn"
        Me.DatefpMetaDataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "itemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "itemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        Me.ItemCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitolEmissioSeriematerialProvysDataGridViewTextBoxColumn
        '
        Me.TitolEmissioSeriematerialProvysDataGridViewTextBoxColumn.DataPropertyName = "titolEmissioSerie_materialProvys"
        Me.TitolEmissioSeriematerialProvysDataGridViewTextBoxColumn.HeaderText = "titolEmissioSerie_materialProvys"
        Me.TitolEmissioSeriematerialProvysDataGridViewTextBoxColumn.Name = "TitolEmissioSeriematerialProvysDataGridViewTextBoxColumn"
        Me.TitolEmissioSeriematerialProvysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitolEmissioCapitolmaterialProvysDataGridViewTextBoxColumn
        '
        Me.TitolEmissioCapitolmaterialProvysDataGridViewTextBoxColumn.DataPropertyName = "titolEmissioCapitol_materialProvys"
        Me.TitolEmissioCapitolmaterialProvysDataGridViewTextBoxColumn.HeaderText = "titolEmissioCapitol_materialProvys"
        Me.TitolEmissioCapitolmaterialProvysDataGridViewTextBoxColumn.Name = "TitolEmissioCapitolmaterialProvysDataGridViewTextBoxColumn"
        Me.TitolEmissioCapitolmaterialProvysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitolOriginalSeriematerialProvysDataGridViewTextBoxColumn
        '
        Me.TitolOriginalSeriematerialProvysDataGridViewTextBoxColumn.DataPropertyName = "titolOriginalSerie_materialProvys"
        Me.TitolOriginalSeriematerialProvysDataGridViewTextBoxColumn.HeaderText = "titolOriginalSerie_materialProvys"
        Me.TitolOriginalSeriematerialProvysDataGridViewTextBoxColumn.Name = "TitolOriginalSeriematerialProvysDataGridViewTextBoxColumn"
        Me.TitolOriginalSeriematerialProvysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UrlproxydaletDataGridViewTextBoxColumn
        '
        Me.UrlproxydaletDataGridViewTextBoxColumn.DataPropertyName = "urlproxydalet"
        Me.UrlproxydaletDataGridViewTextBoxColumn.HeaderText = "urlproxydalet"
        Me.UrlproxydaletDataGridViewTextBoxColumn.Name = "UrlproxydaletDataGridViewTextBoxColumn"
        Me.UrlproxydaletDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QcDaletDataGridViewTextBoxColumn
        '
        Me.QcDaletDataGridViewTextBoxColumn.DataPropertyName = "qcDalet"
        Me.QcDaletDataGridViewTextBoxColumn.HeaderText = "qcDalet"
        Me.QcDaletDataGridViewTextBoxColumn.Name = "QcDaletDataGridViewTextBoxColumn"
        Me.QcDaletDataGridViewTextBoxColumn.ReadOnly = True
        Me.QcDaletDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QcDaletDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'QcVisionadosDataGridViewTextBoxColumn
        '
        Me.QcVisionadosDataGridViewTextBoxColumn.DataPropertyName = "qcVisionados"
        Me.QcVisionadosDataGridViewTextBoxColumn.HeaderText = "qcVisionados"
        Me.QcVisionadosDataGridViewTextBoxColumn.Name = "QcVisionadosDataGridViewTextBoxColumn"
        Me.QcVisionadosDataGridViewTextBoxColumn.ReadOnly = True
        Me.QcVisionadosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QcVisionadosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'QcTecnicoDataGridViewTextBoxColumn
        '
        Me.QcTecnicoDataGridViewTextBoxColumn.DataPropertyName = "qcTecnico"
        Me.QcTecnicoDataGridViewTextBoxColumn.HeaderText = "qcTecnico"
        Me.QcTecnicoDataGridViewTextBoxColumn.Name = "QcTecnicoDataGridViewTextBoxColumn"
        Me.QcTecnicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.QcTecnicoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QcTecnicoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PendientesVisualizacionBindingSource
        '
        Me.PendientesVisualizacionBindingSource.DataMember = "pendientes_Visualizacion"
        Me.PendientesVisualizacionBindingSource.DataSource = Me.MaterialesDataSetAllBindingSource
        '
        'MaterialesDataSetAllBindingSource
        '
        Me.MaterialesDataSetAllBindingSource.DataSource = Me.MaterialesDataSetAll
        Me.MaterialesDataSetAllBindingSource.Position = 0
        '
        'MaterialesDataSetAll
        '
        Me.MaterialesDataSetAll.DataSetName = "MaterialesDataSetAll"
        Me.MaterialesDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FileprocessmetadataBindingSource
        '
        Me.FileprocessmetadataBindingSource.DataMember = "fileprocessmetadata"
        Me.FileprocessmetadataBindingSource.DataSource = Me.MaterialesDataSetBindingSource
        '
        'FileprocessmetadataTableAdapter
        '
        Me.FileprocessmetadataTableAdapter.ClearBeforeFill = True
        '
        'EstadoDaletTableAdapter
        '
        Me.EstadoDaletTableAdapter.ClearBeforeFill = True
        '
        'MaterialesDataSetBindingSource1
        '
        Me.MaterialesDataSetBindingSource1.DataSource = Me.MaterialesDataSet
        Me.MaterialesDataSetBindingSource1.Position = 0
        '
        'Pendientes_VisualizacionTableAdapter
        '
        Me.Pendientes_VisualizacionTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(279, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(515, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "QC Estados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(512, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 443)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Resultados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 443)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(746, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(847, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Launch"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1418, 518)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EstadoDaletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PendientesVisualizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesDataSetAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesDataSetAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileprocessmetadataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MaterialesDataSetBindingSource As BindingSource
    Friend WithEvents MaterialesDataSet As MaterialesDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FileprocessmetadataBindingSource As BindingSource
    Friend WithEvents FileprocessmetadataTableAdapter As MaterialesDataSetTableAdapters.fileprocessmetadataTableAdapter
    Friend WithEvents EstadoDaletBindingSource As BindingSource
    Friend WithEvents EstadoDaletTableAdapter As MaterialesDataSetTableAdapters.estadoDaletTableAdapter
    Friend WithEvents MaterialesDataSetAllBindingSource As BindingSource
    Friend WithEvents MaterialesDataSetAll As MaterialesDataSetAll
    Friend WithEvents MaterialesDataSetBindingSource1 As BindingSource
    Friend WithEvents PendientesVisualizacionBindingSource As BindingSource
    Friend WithEvents Pendientes_VisualizacionTableAdapter As MaterialesDataSetAllTableAdapters.pendientes_VisualizacionTableAdapter
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DatefpMetaDataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitolEmissioSeriematerialProvysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitolEmissioCapitolmaterialProvysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitolOriginalSeriematerialProvysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UrlproxydaletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QcDaletDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents QcVisionadosDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents QcTecnicoDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
