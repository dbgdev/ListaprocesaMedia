Imports System.Configuration

Imports System.Data.SqlClient

Public Class DBStrings
    Private DBString

    Private SQLItemCodeWithoutMedia As String = " SELECT itemCode_materialProvys FROM materialProvysToDaletXML WHERE itemCode_materialProvys NOT IN (SELECT itemCode FROM fileprocessmetadata) AND itemCode_materialProvys <> '' "

    Private SQLItemCodesWithQCVisionPending As String = " SELECT itemCode_materialProvys FROM fileprocessmetadata  LEFT JOIN materialProvysToDaletXML ON fileprocessmetadata.itemCode = materialProvysToDaletXML.itemCode_materialProvys WHERE fileprocessmetadata.qcDalet = 0 AND fileprocessmetadata.itemCode = materialProvysToDaletXML.itemCode_materialProvys "

    Private SQLItemCodesWithQCTecnicPending As String = " SELECT fileName_fpMetaData FROM fileprocessmetadata, materialProvysToDaletXML WHERE fileprocessmetadata.qcDalet = 1 AND fileprocessmetadata.qcVisionados = 1 AND fileprocessmetadata.fileName_fpMetaData = materialProvysToDaletXML.itemCode_materialProvys "



    Public Sub New()

        Me.DBString = GetDbString()

        CheckConcectionDb(DBString)

    End Sub



    Private Sub CheckConcectionDb(dBString As Object)

        Try

            Using sqlConn As New SqlConnection(dBString)

                sqlConn.Open()

            End Using

        Catch e1 As SqlException

            Throw New Exception(e1.Message)

        Catch e2 As Exception

            Throw New Exception(e2.Message)

        End Try

    End Sub



    Private Function GetDbString() As String
        Dim cadenaCompleta As String = String.Empty
        Try
            'Version obsoleta-->ConfigurationSettings.AppSettings.Get("serverDB")
            Dim serverDB As String = ConfigurationManager.AppSettings.Get("serverDB")

            Dim userDB As String = ConfigurationManager.AppSettings.Get("userDB")

            Dim passwordDB As String = ConfigurationManager.AppSettings.Get("passwordDB")

            Dim databaseDB As String = ConfigurationManager.AppSettings.Get("databaseDB")

            cadenaCompleta = "server=" + serverDB + ";user id=" + userDB + ";password=" + passwordDB + ";database=" + databaseDB

        Catch ex As Exception

            Console.WriteLine(ex.Message)

        End Try

        Return cadenaCompleta


    End Function



    Friend Function GetItemCodesWithoutMedia()

        Return GetItemCodesMaterial(SQLItemCodeWithoutMedia)

    End Function



    Friend Function GetItemCodesWithQCVisionPending()

        Return GetItemCodes(SQLItemCodesWithQCVisionPending)

    End Function



    Friend Function GetItemCodesWithQCTecnicPending()

        Return GetItemCodes(SQLItemCodesWithQCTecnicPending)

    End Function



    Friend Function GetItemCodesWithTranscodeError()

        Return GetTranscodeError()

    End Function



    Private Function GetItemCodesMaterial(SQLString As String) As List(Of String)

        Dim resultOK As Boolean = False

        Dim comandString As String = String.Empty

        Dim itemCodesList As List(Of String) = New List(Of String)

        Using conn As New SqlConnection(DBString)

            Dim command As SqlCommand = New SqlCommand(SQLString, conn)

            conn.Open()

            Dim reader As SqlDataReader = command.ExecuteReader()

            Try

                If reader.HasRows Then

                    While (reader.Read())

                        itemCodesList.Add(reader.GetString(reader.GetOrdinal("itemCode_materialProvys")))

                    End While

                End If

                reader.Close()

                If itemCodesList.Count() < 0 Then

                    Console.WriteLine("No hay ningun itemCode sin media")

                Else

                    Return itemCodesList

                End If

            Catch ex As Exception

                Console.WriteLine(ex.Message)

            End Try

        End Using

    End Function



    Private Function GetItemCodes(SQLString As String) As List(Of String)

        Dim resultOK As Boolean = False

        Dim comandString As String = String.Empty

        Dim itemCodesList As List(Of String) = New List(Of String)

        Using conn As New SqlConnection(DBString)

            Dim command As SqlCommand = New SqlCommand(SQLString, conn)

            conn.Open()

            Dim reader As SqlDataReader = command.ExecuteReader()

            Try

                If reader.HasRows Then

                    While (reader.Read())

                        itemCodesList.Add(reader.GetString(reader.GetOrdinal("itemCode")))

                    End While

                End If

                reader.Close()

                If itemCodesList.Count() < 0 Then

                    Console.WriteLine("No hay ningun itemCode sin media")

                Else

                    Return itemCodesList

                End If

            Catch ex As Exception

                Console.WriteLine(ex.Message)

            End Try

        End Using

    End Function



    Private Function GetTranscodeError() As List(Of String)

        Dim resultOK As Boolean = False

        Dim comandString As String = String.Empty

        Dim itemCodesList As List(Of String) = New List(Of String)

        Using conn As New SqlConnection(DBString)

            Dim command As SqlCommand = New SqlCommand("SELECT itemCode FROM fileprocessmetadata WHERE estadoDalet = 'Transcode Failed'", conn)

            conn.Open()

            Dim reader As SqlDataReader = command.ExecuteReader()

            Try

                If reader.HasRows Then

                    While (reader.Read())

                        itemCodesList.Add(reader.GetString(reader.GetOrdinal("itemCode")))

                    End While

                End If

                reader.Close()

                If itemCodesList.Count() < 0 Then

                    Console.WriteLine("No hay ningun item con error de Transcodificacion")

                Else

                    Return itemCodesList

                End If

            Catch ex As Exception

                Console.WriteLine(ex.Message)

            End Try

        End Using

    End Function
End Class
