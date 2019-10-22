Imports System.IO
Module data_save
    Private title As String '문제집 이름
    Private seq As String   '문제집 구분 식별자
    Private Question As ArrayList   '문제
    Private QueNum As String '문제 문항 식별자
    'TEXT 데이터를 문제와 답으로 나누어 LINE에 저장한다.
    'LIST(0) = TITLE , LIST(1) = 문항
    Private Function ds_covertData(text As String)
        Dim line() As String = text.Replace(vbLf, "").Split(vbCrLf)
        Dim temp As String = ""
        Dim num As String = Left(QueNum, 1)
        Dim i As Integer = 0
        Question.Clear()
        Do
            temp += line(i) & " "
            i += 1
        Loop While (Not ucase(Left(line(i), 2)) = num & ".")
        Question.Add(temp)
        temp = ""
        temp += line(i)
        num = dc_NumPlus(num)
        For i = i + 1 To line.Count - 1
            Dim check_list_temp As String = UCase(Left(line(i), num.Count + 1))
            If check_list_temp = num & "." Then
                temp += seq & line(i)
                num = dc_NumPlus(num)
            Else
                temp += "\n" & line(i)
            End If
        Next
        Question.Add(temp)
        Return 0
    End Function

    '데이터를 파일에 추가한다.
    Private Function ds_file_save(data As String)
        Dim path As String = Application.StartupPath & "\" & title
        If Not File.Exists(Path & "\DATA.dat") Then
            Dim fs As FileStream = File.Create(Path & "\DATA.dat")
            fs.Close()
        Else
            data = vbCrLf & data
        End If
        My.Computer.FileSystem.WriteAllText(Path & "\DATA.dat", data, True)
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
        data = num & seq & Question(0) & seq & result & seq & temp & seq & Question(1)
        Return ds_file_save(data)
    End Function

    '시스템을 초기화한다.(data_save에 한해)
    Public Function ds_setExam(g_title As String, g_seq As String, g_quenum As String)
        Dim path As String
        path = Application.StartupPath
        title = g_title
        seq = g_seq
        QueNum = g_quenum
        Question = New ArrayList()
        path += "\" & title
        Return ds_MakeDirectory(path & "\" & "Picture")
    End Function
End Module
