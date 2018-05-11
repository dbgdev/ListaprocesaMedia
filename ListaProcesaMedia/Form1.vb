Imports System.Data.SqlClient

Public Class Form1
    Private ds As DataSet
    '"server=192.168.108.233;user id=admateriales;password=Mariquita10;database=materiales_dev"
    Private cadenaConexion As String = "server=192.168.108.233;user id=admateriales;password=Mariquita10;database=materiales"
    Public Property LogLista As ObjectLog
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadGridviewBD()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LogLista = New ObjectLog("Prueba.txt", "C:\LOGS")
        LoadComboBoxBD()
        LoadGridviewBD()

    End Sub
    Private Sub LoadComboBoxBD()
        Try
            Dim comboSource As New Dictionary(Of String, String)()
            comboSource.Add("", "TODOS")
            comboSource.Add("-1", "Pendientes")
            comboSource.Add("1", "Visionados")

            ComboBox1.DataSource = New BindingSource(comboSource, Nothing)
            ComboBox1.DisplayMember = "Value"
            ComboBox1.ValueMember = "Key"
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

            ComboBox1.SelectionStart = 0

        Catch ex As Exception
            LogLista.WriteLog(ex.Message)
        End Try
        'CargaEstadosDalet()
    End Sub


    Private Sub LoadGridviewBD()
        LoadPendientesdeQCVisionado()
        'LoadArchivosprocesadosByEstadoDalet()
    End Sub

    Private Sub LoadPendientesdeQCVisionado()
        Using conn As New SqlConnection(cadenaConexion)
            conn.Open()
            Dim command As SqlCommand = conn.CreateCommand()

            Dim da As SqlDataAdapter
            Dim ds As DataSet

            command.CommandText = " SELECT *
                                    FROM dbo.fileprocessmetadata fp JOIN  dbo.materialProvysToDaletXML mat 
                                        ON fp.itemCode = mat.itemCode_materialProvys
                                    WHERE  fp.qcDalet =1 AND (fp.qcVisionados= @QCVisionados OR @QCVisionados='') AND fp.urlproxydalet<>'' "

            command.Parameters.AddWithValue("@QCVisionados", IIf(IsNothing(ComboBox1.SelectedItem.ToString), "", ComboBox1.SelectedValue.ToString))

            LogLista.WriteLog(command.CommandText)
            Try

                da = New SqlDataAdapter(command)
                ds = New DataSet()
                da.Fill(ds)

                DataGridView1.DataSource = ds.Tables(0)


                DataGridView1.Refresh()


            Catch ex As Exception
                LogLista.WriteLog(ex.Message)
            End Try

        End Using
    End Sub

    Private Sub LoadArchivosprocesadosByEstadoDalet()
        Using conn As New SqlConnection(cadenaConexion)
            conn.Open()
            Dim command As SqlCommand = conn.CreateCommand()

            Dim da As SqlDataAdapter
            Dim ds As DataSet

            command.CommandText = " SELECT id_fpMetaData, fileName_fpMetaData, date_fpMetaData, path_fpMetaData, error_cvmc, 
		estadoDalet, festadoDalet, urlproxydalet, categoryOriginal, 
		categoryDalet, qcDalet, itemCode, ObjectIdDalet, estadoProvys, festadoProvys, 
		qcVisionados, fqcVisionados, UsuarioVisionados, 
		qcTecnico, fqctecnico, usuarioTecnico 
                                    FROM dbo.fileprocessmetadata
                                    WHERE  ('' = @estadoDalet OR estadoDalet = @estadoDalet) "

            command.Parameters.AddWithValue("@estadoDalet", IIf(IsNothing(ComboBox1.SelectedItem.ToString), "", ComboBox1.SelectedValue.ToString))

            LogLista.WriteLog(command.CommandText)
            Try

                da = New SqlDataAdapter(command)
                ds = New DataSet()
                da.Fill(ds)

                DataGridView1.DataSource = ds.Tables(0)


                DataGridView1.Refresh()


            Catch ex As Exception
                LogLista.WriteLog(ex.Message)
            End Try

        End Using
    End Sub

    Private Sub CargaEstadosDalet()
        Using conn As New SqlConnection(cadenaConexion)
            conn.Open()
            Dim command As SqlCommand = conn.CreateCommand()
            Dim da As SqlDataAdapter
            Dim ds As DataSet

            command.CommandText = " SELECT '0' id_estadoDalet,'' nombre_estadoDalet
                                    UNION
                                    SELECT id_estadoDalet , nombre_estadoDalet FROM dbo.estadoDalet  "

            LogLista.WriteLog(command.CommandText)
            Try
                da = New SqlDataAdapter(command)
                ds = New DataSet()
                da.Fill(ds)

                ComboBox1.DataSource = ds.Tables(0)
                ComboBox1.DisplayMember = "nombre_estadoDalet"
                ComboBox1.ValueMember = "nombre_estadoDalet"
                ComboBox1.SelectionStart = 0

            Catch ex As Exception
                LogLista.WriteLog(ex.Message)
            End Try

        End Using
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.FileprocessmetadataTableAdapter.FillBy(Me.MaterialesDataSet.fileprocessmetadata)
        Catch ex As System.Exception
            LogLista.WriteLog(ex.Message)
        End Try

    End Sub


End Class
