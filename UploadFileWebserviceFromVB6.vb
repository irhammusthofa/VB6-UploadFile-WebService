
Public Function UpLoadData(strFilename As String, strTargetURL As String, Optional namaFile As String) As String
Dim oHttp As XMLHTTP
Dim strBody As String
Dim aPostData() As Byte
Dim oSignature As String
Dim strResponse As String
Dim nFile As Long
Dim strText As String

On Error GoTo ErrorHandler

nFile = FreeFile
Open strFilename For Binary As #nFile
strText = String(LOF(nFile), " ")
Get #nFile, , strText
Close #nFile

Set oHttp = New XMLHTTP
If namaFile = "" Then
    namaFile = getFilename(strFilename)
End If
oHttp.Open "POST", strTargetURL, False
oHttp.setRequestHeader "Content-Type", "multipart/form-data, boundary=AaB03x"
strBody = _
   "--AaB03x" & vbCrLf & _
   "Content-Disposition: form-data; name=""filename""" & vbCrLf & vbCrLf & _
   namaFile & vbCrLf 
   
strBody = strBody & "--AaB03x" & vbCrLf & _
   "Content-Disposition: attachment; name=""gambar""; filename=""" & strFilename & """" & vbCrLf & _
   "Content-Type: text/plain" & vbCrLf & vbCrLf & _
   strText & vbCrLf & _
   "--AaB03x--"

aPostData = StrConv(strBody, vbFromUnicode)
oHttp.send aPostData

strResponse = oHttp.responseText
UpLoadData = strResponse


GoTo LastSub
On Error GoTo 0
Exit Function

ErrorHandler:
MsgBox "Error : (" & Err.number & ") " & Err.Description, vbExclamation, App.Title
UpLoadData = "ERROR UPLOAD"
GoTo LastSub
Exit Function

LastSub:
On Error Resume Next
Set oHttp = Nothing
On Error GoTo 0
End Function
