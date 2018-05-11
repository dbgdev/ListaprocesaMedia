<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EstadoDaletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesDataSet = New ListaProcesaMedia.MaterialesDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdfpMetaDataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNamefpMetaDataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatefpMetaDataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathfpMetaDataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorcvmcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDaletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FestadoDaletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrlproxydaletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryOriginalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDaletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QcDaletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjectIdDaletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoProvysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FestadoProvysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QcVisionadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FqcVisionadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioVisionadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QcTecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FqctecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioTecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoDalet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileprocessmetadataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FileprocessmetadataTableAdapter = New ListaProcesaMedia.MaterialesDataSetTableAdapters.fileprocessmetadataTableAdapter()
        Me.EstadoDaletTableAdapter = New ListaProcesaMedia.MaterialesDataSetTableAdapters.estadoDaletTableAdapter()
        CType(Me.EstadoDaletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileprocessmetadataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdfpMetaDataDataGridViewTextBoxColumn, Me.FileNamefpMetaDataDataGridViewTextBoxColumn, Me.DatefpMetaDataDataGridViewTextBoxColumn, Me.PathfpMetaDataDataGridViewTextBoxColumn, Me.ErrorcvmcDataGridViewTextBoxColumn, Me.EstadoDaletDataGridViewTextBoxColumn, Me.FestadoDaletDataGridViewTextBoxColumn, Me.UrlproxydaletDataGridViewTextBoxColumn, Me.CategoryOriginalDataGridViewTextBoxColumn, Me.CategoryDaletDataGridViewTextBoxColumn, Me.QcDaletDataGridViewTextBoxColumn, Me.ItemCodeDataGridViewTextBoxColumn, Me.ObjectIdDaletDataGridViewTextBoxColumn, Me.EstadoProvysDataGridViewTextBoxColumn, Me.FestadoProvysDataGridViewTextBoxColumn, Me.QcVisionadosDataGridViewTextBoxColumn, Me.FqcVisionadosDataGridViewTextBoxColumn, Me.UsuarioVisionadosDataGridViewTextBoxColumn, Me.QcTecnicoDataGridViewTextBoxColumn, Me.FqctecnicoDataGridViewTextBoxColumn, Me.UsuarioTecnicoDataGridViewTextBoxColumn, Me.estadoDalet, Me.Column1})
        Me.DataGridView1.DataSource = Me.FileprocessmetadataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1325, 342)
        Me.DataGridView1.TabIndex = 1
        '
        'IdfpMetaDataDataGridViewTextBoxColumn
        '
        Me.IdfpMetaDataDataGridViewTextBoxColumn.DataPropertyName = "id_fpMetaData"
        Me.IdfpMetaDataDataGridViewTextBoxColumn.HeaderText = "id_fpMetaData"
        Me.IdfpMetaDataDataGridViewTextBoxColumn.Name = "IdfpMetaDataDataGridViewTextBoxColumn"
        Me.IdfpMetaDataDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdfpMetaDataDataGridViewTextBoxColumn.Visible = False
        '
        'FileNamefpMetaDataDataGridViewTextBoxColumn
        '
        Me.FileNamefpMetaDataDataGridViewTextBoxColumn.DataPropertyName = "fileName_fpMetaData"
        Me.FileNamefpMetaDataDataGridViewTextBoxColumn.HeaderText = "Fitxer"
        Me.FileNamefpMetaDataDataGridViewTextBoxColumn.Name = "FileNamefpMetaDataDataGridViewTextBoxColumn"
        Me.FileNamefpMetaDataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatefpMetaDataDataGridViewTextBoxColumn
        '
        Me.DatefpMetaDataDataGridViewTextBoxColumn.DataPropertyName = "date_fpMetaData"
        Me.DatefpMetaDataDataGridViewTextBoxColumn.HeaderText = "Data fitxer"
        Me.DatefpMetaDataDataGridViewTextBoxColumn.Name = "DatefpMetaDataDataGridViewTextBoxColumn"
        Me.DatefpMetaDataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PathfpMetaDataDataGridViewTextBoxColumn
        '
        Me.PathfpMetaDataDataGridViewTextBoxColumn.DataPropertyName = "path_fpMetaData"
        Me.PathfpMetaDataDataGridViewTextBoxColumn.HeaderText = "path_fpMetaData"
        Me.PathfpMetaDataDataGridViewTextBoxColumn.Name = "PathfpMetaDataDataGridViewTextBoxColumn"
        Me.PathfpMetaDataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ErrorcvmcDataGridViewTextBoxColumn
        '
        Me.ErrorcvmcDataGridViewTextBoxColumn.DataPropertyName = "error_cvmc"
        Me.ErrorcvmcDataGridViewTextBoxColumn.HeaderText = "error_cvmc"
        Me.ErrorcvmcDataGridViewTextBoxColumn.Name = "ErrorcvmcDataGridViewTextBoxColumn"
        Me.ErrorcvmcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDaletDataGridViewTextBoxColumn
        '
        Me.EstadoDaletDataGridViewTextBoxColumn.DataPropertyName = "estadoDalet"
        Me.EstadoDaletDataGridViewTextBoxColumn.HeaderText = "estadoDalet"
        Me.EstadoDaletDataGridViewTextBoxColumn.Name = "EstadoDaletDataGridViewTextBoxColumn"
        Me.EstadoDaletDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FestadoDaletDataGridViewTextBoxColumn
        '
        Me.FestadoDaletDataGridViewTextBoxColumn.DataPropertyName = "festadoDalet"
        Me.FestadoDaletDataGridViewTextBoxColumn.HeaderText = "festadoDalet"
        Me.FestadoDaletDataGridViewTextBoxColumn.Name = "FestadoDaletDataGridViewTextBoxColumn"
        Me.FestadoDaletDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UrlproxydaletDataGridViewTextBoxColumn
        '
        Me.UrlproxydaletDataGridViewTextBoxColumn.DataPropertyName = "urlproxydalet"
        Me.UrlproxydaletDataGridViewTextBoxColumn.HeaderText = "urlproxydalet"
        Me.UrlproxydaletDataGridViewTextBoxColumn.Name = "UrlproxydaletDataGridViewTextBoxColumn"
        Me.UrlproxydaletDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryOriginalDataGridViewTextBoxColumn
        '
        Me.CategoryOriginalDataGridViewTextBoxColumn.DataPropertyName = "categoryOriginal"
        Me.CategoryOriginalDataGridViewTextBoxColumn.HeaderText = "categoryOriginal"
        Me.CategoryOriginalDataGridViewTextBoxColumn.Name = "CategoryOriginalDataGridViewTextBoxColumn"
        Me.CategoryOriginalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDaletDataGridViewTextBoxColumn
        '
        Me.CategoryDaletDataGridViewTextBoxColumn.DataPropertyName = "categoryDalet"
        Me.CategoryDaletDataGridViewTextBoxColumn.HeaderText = "categoryDalet"
        Me.CategoryDaletDataGridViewTextBoxColumn.Name = "CategoryDaletDataGridViewTextBoxColumn"
        Me.CategoryDaletDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QcDaletDataGridViewTextBoxColumn
        '
        Me.QcDaletDataGridViewTextBoxColumn.DataPropertyName = "qcDalet"
        Me.QcDaletDataGridViewTextBoxColumn.HeaderText = "qcDalet"
        Me.QcDaletDataGridViewTextBoxColumn.Name = "QcDaletDataGridViewTextBoxColumn"
        Me.QcDaletDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "itemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "itemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        Me.ItemCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObjectIdDaletDataGridViewTextBoxColumn
        '
        Me.ObjectIdDaletDataGridViewTextBoxColumn.DataPropertyName = "ObjectIdDalet"
        Me.ObjectIdDaletDataGridViewTextBoxColumn.HeaderText = "ObjectIdDalet"
        Me.ObjectIdDaletDataGridViewTextBoxColumn.Name = "ObjectIdDaletDataGridViewTextBoxColumn"
        Me.ObjectIdDaletDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoProvysDataGridViewTextBoxColumn
        '
        Me.EstadoProvysDataGridViewTextBoxColumn.DataPropertyName = "estadoProvys"
        Me.EstadoProvysDataGridViewTextBoxColumn.HeaderText = "estadoProvys"
        Me.EstadoProvysDataGridViewTextBoxColumn.Name = "EstadoProvysDataGridViewTextBoxColumn"
        Me.EstadoProvysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FestadoProvysDataGridViewTextBoxColumn
        '
        Me.FestadoProvysDataGridViewTextBoxColumn.DataPropertyName = "festadoProvys"
        Me.FestadoProvysDataGridViewTextBoxColumn.HeaderText = "festadoProvys"
        Me.FestadoProvysDataGridViewTextBoxColumn.Name = "FestadoProvysDataGridViewTextBoxColumn"
        Me.FestadoProvysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QcVisionadosDataGridViewTextBoxColumn
        '
        Me.QcVisionadosDataGridViewTextBoxColumn.DataPropertyName = "qcVisionados"
        Me.QcVisionadosDataGridViewTextBoxColumn.HeaderText = "qcVisionados"
        Me.QcVisionadosDataGridViewTextBoxColumn.Name = "QcVisionadosDataGridViewTextBoxColumn"
        Me.QcVisionadosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FqcVisionadosDataGridViewTextBoxColumn
        '
        Me.FqcVisionadosDataGridViewTextBoxColumn.DataPropertyName = "fqcVisionados"
        Me.FqcVisionadosDataGridViewTextBoxColumn.HeaderText = "fqcVisionados"
        Me.FqcVisionadosDataGridViewTextBoxColumn.Name = "FqcVisionadosDataGridViewTextBoxColumn"
        Me.FqcVisionadosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioVisionadosDataGridViewTextBoxColumn
        '
        Me.UsuarioVisionadosDataGridViewTextBoxColumn.DataPropertyName = "UsuarioVisionados"
        Me.UsuarioVisionadosDataGridViewTextBoxColumn.HeaderText = "UsuarioVisionados"
        Me.UsuarioVisionadosDataGridViewTextBoxColumn.Name = "UsuarioVisionadosDataGridViewTextBoxColumn"
        Me.UsuarioVisionadosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QcTecnicoDataGridViewTextBoxColumn
        '
        Me.QcTecnicoDataGridViewTextBoxColumn.DataPropertyName = "qcTecnico"
        Me.QcTecnicoDataGridViewTextBoxColumn.HeaderText = "qcTecnico"
        Me.QcTecnicoDataGridViewTextBoxColumn.Name = "QcTecnicoDataGridViewTextBoxColumn"
        Me.QcTecnicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FqctecnicoDataGridViewTextBoxColumn
        '
        Me.FqctecnicoDataGridViewTextBoxColumn.DataPropertyName = "fqctecnico"
        Me.FqctecnicoDataGridViewTextBoxColumn.HeaderText = "fqctecnico"
        Me.FqctecnicoDataGridViewTextBoxColumn.Name = "FqctecnicoDataGridViewTextBoxColumn"
        Me.FqctecnicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioTecnicoDataGridViewTextBoxColumn
        '
        Me.UsuarioTecnicoDataGridViewTextBoxColumn.DataPropertyName = "usuarioTecnico"
        Me.UsuarioTecnicoDataGridViewTextBoxColumn.HeaderText = "usuarioTecnico"
        Me.UsuarioTecnicoDataGridViewTextBoxColumn.Name = "UsuarioTecnicoDataGridViewTextBoxColumn"
        Me.UsuarioTecnicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'estadoDalet
        '
        Me.estadoDalet.DataPropertyName = "estadoDalet"
        Me.estadoDalet.HeaderText = "estadoDalet"
        Me.estadoDalet.Name = "estadoDalet"
        Me.estadoDalet.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_fpMetaData"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1418, 518)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EstadoDaletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileprocessmetadataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MaterialesDataSetBindingSource As BindingSource
    Friend WithEvents MaterialesDataSet As MaterialesDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FileprocessmetadataBindingSource As BindingSource
    Friend WithEvents FileprocessmetadataTableAdapter As MaterialesDataSetTableAdapters.fileprocessmetadataTableAdapter
    Friend WithEvents EstadoDaletBindingSource As BindingSource
    Friend WithEvents EstadoDaletTableAdapter As MaterialesDataSetTableAdapters.estadoDaletTableAdapter
    Friend WithEvents IdfpMetaDataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileNamefpMetaDataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatefpMetaDataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PathfpMetaDataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ErrorcvmcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDaletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FestadoDaletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UrlproxydaletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryOriginalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDaletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QcDaletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObjectIdDaletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoProvysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FestadoProvysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QcVisionadosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FqcVisionadosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioVisionadosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QcTecnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FqctecnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioTecnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents estadoDalet As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
