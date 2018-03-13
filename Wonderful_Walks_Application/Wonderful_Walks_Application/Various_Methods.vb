''''''''''''''''''''''''''''''' 00171328_Fahad_Md_Kamal_IFY_ITP_January_2018 '''''''''''''''''''''''''''''''''''''

Module Various_Methods
    ''''''''''''''' Inside TexBox White Space checking ''''''''''''''''''''''''''' 
    Function SpcChk(ByVal str As String) As Boolean

        Dim oldStr, nwstr As String
        oldStr = str

        Dim chkresult As Boolean = False
        For Spce = 0 To oldStr.Length - 1
            nwstr = oldStr.Substring(Spce, 1)
            If nwstr = " " Then
                chkresult = True
            End If
        Next
        Return chkresult

    End Function



    ''''''''''''''' Inside TexBox Numeric data checking ''''''''''''''''''''''''''' 
    Function NumericCheck(ByVal str As String) As Boolean

        Dim oldStr, nwstr As String
        oldStr = str

        Dim chkresult As Boolean = False
        For Charecter = 0 To oldStr.Length - 1
            nwstr = oldStr.Substring(Charecter, 1)
            If IsNumeric(nwstr) Then
                chkresult = True
            End If
        Next
        Return chkresult

    End Function


    ''''''''''''''' Inside TexBox Alphabetic data checking ''''''''''''''''''''''''''' 
    Function AlphabeticCheck(ByVal str As String) As Boolean

        Dim oldStr, nwstr As String
        oldStr = str

        Dim chkresult As Boolean = False
        For Charecter = 0 To oldStr.Length - 1
            nwstr = oldStr.Substring(Charecter, 1)
            If Not IsNumeric(nwstr) Then
                chkresult = True
            End If
        Next
        Return chkresult

    End Function



End Module

