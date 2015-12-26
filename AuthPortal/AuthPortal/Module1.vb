Module Module1

    Sub Main()
        If My.Computer.Network.IsAvailable = False Then
            Console.WriteLine("unable to find a network connection :(")
            Console.ReadKey()
            Exit Sub
        End If
        Console.WriteLine(Console.Title)
        Dim ProductList(5) As String
        Dim PLD As New Net.WebClient
        Dim PLDC As String = PLD.DownloadString("https://www.dropbox.com/s/thwhn6kmpixkjhr/PL.txt?dl=1")
        Console.WriteLine("//Message of the day\\")
        Dim MOTDD As New Net.WebClient
        Console.WriteLine(MOTDD.DownloadString("https://www.dropbox.com/s/kxwuksqv5jh5t1o/MOTD.txt?dl=1"))
        Console.WriteLine(vbNewLine)
        Dim IOW As IO.StreamWriter
        Dim IOR As IO.StreamReader
        Try
            If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp + "\Products.txt") Then
            Else
                IO.File.Create(My.Computer.FileSystem.SpecialDirectories.Temp + "\Products.txt")
                Console.WriteLine("restarting Application....")
                Shell("start " + Console.Title)

                Threading.Thread.Sleep(2000)
                Exit Sub
            End If

        Catch ex As Exception
            Console.WriteLine("unable to create list :(")
        End Try
        Try
            IOW = My.Computer.FileSystem.OpenTextFileWriter(My.Computer.FileSystem.SpecialDirectories.Temp + "\Products.txt", False)
            IOW.WriteLine(PLDC)
            IOW.Close()
        Catch
            Console.WriteLine("unable to create products list :(")
        End Try
        Try
            Console.WriteLine("Current Commands")
            IOR = My.Computer.FileSystem.OpenTextFileReader(My.Computer.FileSystem.SpecialDirectories.Temp + "\Products.txt")
            Do While IOR.Peek() <> -1
                Console.WriteLine(IOR.ReadLine)
            Loop
            IOR.Close()
        Catch
            Console.WriteLine("failed to read cmd")
        End Try

        Console.WriteLine("xor")
        Console.WriteLine("downloader")
        Console.WriteLine("===========================================")




        Console.WriteLine("type product name to access the product")
        Console.WriteLine("==Type update to check for a update==")
        Console.WriteLine("Type news for lastest news and change logs.")
        Console.WriteLine("<<+>>>>auth portal!<<<<+>>")


        Dim CLRL As String = Console.ReadLine.ToLower

        Select Case CLRL
            Case "-c"
                Console.Clear()
                Main()
            Case "mugger"
                Stage1()
            Case "hwid"
                HWIDF()
            Case "update"
                Update()
            Case "codedownload"
                SourceCodes1()
            Case "buy"
                Process.Start("http://hackforums.net/showthread.php?tid=5036073")
                Main()
            Case "news"
                ChangeLog()
            Case "xor"
                XorTool()
            Case "calc"
                calc()
            Case "downloader"
                Console.WriteLine("link to downloadable file....")
                Dim link As String = Console.ReadLine
                Console.WriteLine("file extension? exe,txt,pdf do not add a dot")
                Dim Exten As String = "." + Console.ReadLine
                Dim wc As New Net.WebClient
                Try
                    wc.DownloadFile(link, My.Computer.FileSystem.SpecialDirectories.Desktop + "\Consoledownload" + Exten)
                    Console.WriteLine("done.....")
                    Threading.Thread.Sleep(2500)
                Catch
                    Console.WriteLine("failed to download....")
                End Try

                Console.Clear()
                Main()
            Case "Cwallet"
            Case "buywithbtc"
                Console.WriteLine("")
            Case Else
                Console.WriteLine("Product does not exist.")
                Console.ReadKey()
                Console.Clear()
                Main()
        End Select



    End Sub


    Sub Stage1()
        Dim pt1, pt2 As String
        pt1 = Environment.UserName
        pt2 = My.Computer.GetType.GUID.ToString
        Dim UTF8E As New System.Text.UTF8Encoding
        Dim Sha256 As New Security.Cryptography.SHA256Managed
        Dim StrBytes As Byte() = UTF8E.GetBytes(pt1 + pt2)
        Dim StrBytes2 As Byte() = Sha256.ComputeHash(StrBytes)
        Dim ShaHWID As String = Convert.ToBase64String(StrBytes2)
        Dim wc1 As New Net.WebClient
        Dim list As String = wc1.DownloadString("https://www.dropbox.com/s/v6xm7b1cny5c3x5/HWID.txt?dl=1")
        If list.Contains(ShaHWID.Replace("=", "")) Then
            Console.WriteLine("verified user!")

        Else
            Console.WriteLine("HWID not found?, have you purchased this product?")
            Console.ReadLine()

        End If

    End Sub

    Sub HWIDF()
        Dim pt1, pt2 As String
        pt1 = Environment.UserName
        pt2 = My.Computer.GetType.GUID.ToString
        Dim UTF8E As New System.Text.UTF8Encoding
        Dim Sha256 As New Security.Cryptography.SHA256Managed
        Dim StrBytes As Byte() = UTF8E.GetBytes(pt1 + pt2)
        Dim StrBytes2 As Byte() = Sha256.ComputeHash(StrBytes)
        Dim ShaHWID As String = Convert.ToBase64String(StrBytes2)
        My.Computer.Clipboard.SetText(ShaHWID.Replace("=", ""))
        MsgBox("hwid copied to clip board")
        Console.Clear()
        Main()
    End Sub


   


    Function Update()
        Dim Temp As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim MainDrive As String = Environ("systemdrive") + "\"
        Console.WriteLine("checking for update | Current Version 1.0")
        Dim UPC As New Net.WebClient
        Dim Version As String = UPC.DownloadString("https://www.dropbox.com/s/hsfilxp20vtk30w/VersionInfo.txt?dl=1")
        If Version.Contains("1.0") Then
            Console.WriteLine("up to date | version 1.0 :D")
            Console.ReadKey()
            Console.Clear()
            Main()
        Else
            Console.WriteLine("Found " + Version + " Found!, download?, if not close the application now.")
            Console.ReadKey()
            Try
                Dim DLU As New Net.WebClient
                DLU.DownloadFile("https://www.dropbox.com/s/dtexuyj0c224ejg/HexMenu.exe?dl=1", Temp + "\HexMenu.exe")
                Console.WriteLine("update complete please close and start he new version!")
                Process.Start(Temp)
                Console.ReadKey()
            Catch
                Console.WriteLine("download update failed!")
                Console.ReadKey()
                Console.Clear()
                Main()
            End Try

        End If
        Return Version
    End Function


    Sub SourceCodes1()
        Dim pt1, pt2 As String
        pt1 = Environment.UserName
        pt2 = My.Computer.GetType.GUID.ToString
        Dim UTF8E As New System.Text.UTF8Encoding
        Dim Sha256 As New Security.Cryptography.SHA256Managed
        Dim StrBytes As Byte() = UTF8E.GetBytes(pt1 + pt2)
        Dim StrBytes2 As Byte() = Sha256.ComputeHash(StrBytes)
        Dim ShaHWID As String = Convert.ToBase64String(StrBytes2)
        Dim wc1 As New Net.WebClient
        Dim list As String = wc1.DownloadString("https://www.dropbox.com/s/v6xm7b1cny5c3x5/HWID.txt?dl=1")
        If list.Contains(ShaHWID.Replace("=", "")) Then
            Console.WriteLine("verified user!")
            downloadfiles()
        Else
            Console.WriteLine("HWID not found?, have you purchased this product?")
            Console.ReadLine()

        End If

    End Sub


    Sub downloadfiles()
        Dim Drive As String = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3)
        Try
            Console.WriteLine("downloading files.......")
            Dim dlsc As New Net.WebClient
            dlsc.DownloadFile("https://www.dropbox.com/s/6ec62ii2y807jp0/source.rar?dl=1", Drive + "\users\" + Environment.UserName + "\desktop\HexSource.zip")
            Console.WriteLine("download complete!")
            Threading.Thread.Sleep(3500)
            Console.Clear()
            Main()
        Catch
            Console.WriteLine("Failed.........")
            Threading.Thread.Sleep(5000)
            Console.Clear()
            Main()
        End Try

    End Sub


    Sub ChangeLog()
        Console.WriteLine("/====CURRENT NEWS====\")
        Dim ND As New Net.WebClient
        Dim News As String = ND.DownloadString("https://www.dropbox.com/s/1vlqu4d8hlz8ifm/NEWS.txt?dl=1")
        Console.WriteLine(News)
        Console.ReadKey()
        Console.Clear()
        Main()
    End Sub

    Sub XorTool()
        Dim KeyToUse As Integer
        Console.WriteLine("type your key")
        Try
            KeyToUse = CInt(Console.ReadLine)
        Catch
            Console.WriteLine("text is not a valid format....")
            Threading.Thread.Sleep(2500)
            Console.Clear()
            XorTool()
        End Try

        If KeyToUse > 255 Then
            Console.WriteLine("1 - 255 keys only")
            Console.ReadKey()
            Console.Clear()
            XorTool()

        Else
            Console.WriteLine("type your text")
            Dim MyText As String = Console.ReadLine
            Dim STB1 As New System.Text.StringBuilder(MyText)
            Dim STB2 As New System.Text.StringBuilder
            Dim Charz As Char
            For i As Integer = 0 To MyText.Length - 1
                Charz = STB1(i)
                Charz = Chr(Asc(Charz) Xor KeyToUse)
                STB2.Append(Charz)
                Console.WriteLine(STB2.ToString)
            Next
            Console.ReadKey()
            Console.Clear()
            Main()
        End If






    End Sub



    Function calc()
        Dim Calculatedinteger As Integer

        Console.WriteLine("Type your 1st digit!")
        Dim Calc1 As String = Console.ReadLine
        Console.WriteLine("type your 2nd digit!")
        Dim Calc2 As String = Console.ReadLine
        Console.WriteLine("type your math symbol")
        Dim CurrentMathSymbol As String = Console.ReadLine

        Select Case CurrentMathSymbol
            Case "+"
                Console.WriteLine(Calc1 + Calc2)
                Console.ReadKey()
                Main()
            Case "-"
                Console.WriteLine(Calc1 - Calc2)
                Console.ReadKey()
                Main()
            Case "\"
                Console.WriteLine(Calc1 \ Calc2)
                Console.ReadKey()
                Main()
            Case "*"
                Console.WriteLine(Calc1 * Calc2)
                Console.ReadKey()
                Main()
            Case Else
                Console.WriteLine("failed non math symbol detected or i was lazy and did not add a correct function to solve your math problem.")
                Console.ReadLine()
        End Select

        Console.WriteLine(CStr(Calculatedinteger))

        Return Calculatedinteger
    End Function



End Module
