Imports System.IO
Module data_save
    Private title As String
    Private seq As String
    Private line As ArrayList
    Private path As String
    'TEXT 데이터를 문제와 답으로 나누어 LINE에 저장한다.
    Private Function ds_covertData(text As String)
        Dim data() As String = text.Split(vbCrLf)
        Dim i As Integer = 0
        Dim temp As String = ""
        line.Clear()
        line.Add(data(0))
        For i = 1 To data.Count - 1
            temp += Right(data(i), data(i).Count - 1)
            If (Not i = data.Count - 1) Then
                temp += seq
            End If
        Next
        For i = data.Count To 6
            If (Not i = data.Count - 1) Then
                temp += seq & "0"
            Else
                temp += "0"
            End If
        Next
        line.Add(temp)
        Return 0
    End Function

    '데이터를 파일에 추가한다.
    Private Function ds_file_save(data As String)
        If Not File.Exists(path & "\DATA.dat") Then
            Dim fs As FileStream = File.Create(path & "\DATA.dat")
            fs.Close()
        Else
            data = vbCrLf & data
        End If
        My.Computer.FileSystem.WriteAllText(path & "\DATA.dat", data, True)
        Return 1
    End Function

    Private Function ds_MakeDirectory(ByVal InPath As String) As Integer
        On Error Resume Next   '에러가 있으면 무시하고, 다음줄 코드를 실행  
        Dim check As Integer = 0
        Dim strTmp() As String
        Dim i As Integer, j As Integer
        Dim strDir As String = String.Empty
        InPath = Replace(InPath, "/", "\")
        strTmp = Split(InPath, "\")
        For i = 0 To UBound(strTmp)
            strDir = ""
            For j = 0 To i
                strDir = strDir & strTmp(j) & "\"
            Next
            If Dir(strDir, vbDirectory) = "" Then
                MkDir(strDir)
                check = 1
            End If
        Next i
        Return check
    End Function


    '데이터를 저장한다.
    Public Function ds_saveData(text As String, num As String, result As String, Optional img As Boolean = False)
        Dim data As String = ""
        Dim temp As String = ""
        ds_covertData(text)
        If img = True Then
            temp = "Picture\" & num & ".png"
        End If
        data = num & seq & line(0) & seq & result & seq & temp & seq & line(1)
        Return ds_file_save(data)
    End Function

    '시스템을 초기화한다.(data_save에 한해)
    Public Function ds_setExam(g_title As String, g_seq As String)
        path = Application.StartupPath
        title = g_title
        seq = g_seq
        line = New ArrayList()
        path += "\" & title
        Return ds_MakeDirectory(path & "\" & "Picture")
    End Function
End Module
