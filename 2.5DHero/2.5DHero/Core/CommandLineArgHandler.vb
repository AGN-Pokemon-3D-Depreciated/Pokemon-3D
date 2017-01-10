Module CommandLineArgHandler

    Public ReadOnly Property ForceGraphics As Boolean
    Public ReadOnly Property NoSplash As Boolean

    Public Sub Initialize(ByVal args() As String)
        Dim additionalValue As String = Nothing

        If args.Length > 0 Then
            If args.Any(Function(arg As String)
                            Return arg = "-forcegraphics"
                        End Function) Then
                _ForceGraphics = True
            ElseIf args.Any(Function(arg As String)
                                Return arg = "-nosplash"
                            End Function) Then
                _NoSplash = True
            ElseIf args.Any(Function(arg As String)
                                If arg.ToUpper.StartsWith("MAP") Then
                                    additionalValue = arg.Remove(0, arg.IndexOf(":") + 1)
                                    Return True
                                Else
                                    Return False
                                End If
                            End Function) Then
                MapPreviewScreen.DetectMapPath(additionalValue)
            End If
        End If
    End Sub

End Module