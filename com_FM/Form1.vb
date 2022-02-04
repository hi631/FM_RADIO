Option Explicit On
Imports System.IO.Ports

Public Class Form1
    Dim comopn = 0
    Private Sub com_set(mode)
        If mode = 1 Then
            Try
                SerialPort1.PortName = TextBox2.Text
                SerialPort1.BaudRate = TextBox1.Text
                SerialPort1.Open()
                Button1.Text = "切断"
                TextBox2.BackColor = Color.LightGreen
                ListBox1.BackColor = Color.LightGreen
                comopn = 1
            Catch
                Button1.Text = "接続"
                TextBox2.BackColor = Color.LightPink
                ListBox1.BackColor = Color.LightPink
                comopn = 0
            End Try
        End If
        If mode = 0 Then
            SerialPort1.Close()
            Button1.Text = "接続"
            TextBox2.BackColor = Color.White
            ListBox1.BackColor = Color.White
            comopn = 0
        End If
    End Sub
    Private Sub swrite(smsg)
        Try
            SerialPort1.Write(smsg)
        Catch
            com_set(1)
        End Try
    End Sub

    Private Sub disp_fre(msg)
        Label1.Text = Mid(msg, 1, 2) + "." + Mid(msg, 3, 1) + " MHz"
    End Sub
    Private Sub get_def()
        Dim lp, rddt, fpos, ftxt
        If comopn = 1 Then
            disp.Clear()
            swrite("AT+RET")
            For lp = 1 To 10
                System.Threading.Thread.Sleep(100)
                Application.DoEvents()
                rddt = disp.Text
                If InStr(rddt, "PLAY") Then
                    fpos = InStr(rddt, "FRE=")
                    ftxt = Mid(rddt, fpos + 4, 3)
                    disp_fre(ftxt)
                    Exit For
                End If
            Next lp
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If comopn = 0 Then
            com_set(1)
        Else
            com_set(0)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        disp.Clear()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        com_set(0)
        End
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getfile()
        com_set(1)
        get_def()
    End Sub


    Private Delegate Sub Delegate_RcvDataToTextBox1(data As String)
    Private Sub RcvDataToTextBox1(data As String)
        disp.AppendText(data)
        While disp.Lines.Length > 100
            disp.Text = disp.Text.Remove(0, disp.Text.IndexOf("\r\n") + 2)
        End While
        disp.SelectionStart = disp.Text.Length
        disp.Focus()
        disp.ScrollToCaret()
    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            '受信データを読み込む.
            Dim data As String
            data = SerialPort1.ReadExisting()
            'SerialPort2.Write(data)

            '受信したデータをテキストボックスに書き込む.
            Dim args(0) As Object
            args(0) = data
            Invoke(New Delegate_RcvDataToTextBox1(AddressOf Me.RcvDataToTextBox1), args)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        swrite(TextBox3.Text)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim cmd = Me.ListBox2.SelectedItem
        TextBox3.Text = cmd
        swrite(cmd)
    End Sub
    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim sel, fre
        sel = Me.ListBox1.SelectedItem
        fre = Mid(sel, 4, 2) + Mid(sel, 7, 1)
        disp_fre(fre)
        TextBox3.Text = "AT+FRE=" + fre
        swrite(TextBox3.Text)
    End Sub

    Private Sub getfile()
        Application.DoEvents()
        Try
            Using st As New System.IO.StreamReader(Application.StartupPath & "\scandt.txt", System.Text.Encoding.Default)
                TextBox2.Text = st.ReadLine ' COM.No
                TextBox1.Text = st.ReadLine ' Speed
                Do Until st.Peek = -1
                    ListBox1.Items.Add(st.ReadLine)
                Loop
            End Using
        Catch
            MessageBox.Show("scandt.txt が見つかりません" + vbCrLf + "AT+SCANを実行後に" + vbCrLf + "リスト更新してください",
                "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim scandt = disp.Text
        Dim scanres, fdt, ndt
        Dim sbeg, send, fchk, nchk
        sbeg = 1 : send = InStr(scandt, "SCAN OK")
        If (send > 0) Then
            ListBox1.Items.Clear()
            While sbeg < send
                fchk = InStr(sbeg, scandt, "FRE=")
                nchk = InStr(sbeg, scandt, "CH=")
                If fchk <> 0 And fchk < send Then
                    fdt = Mid(scandt, fchk + 4, 3)
                    ndt = Mid(scandt, nchk + 3, 2)
                    scanres = ndt + " " + Mid(fdt, 1, 2) + "." + Mid(fdt, 3, 1) + " MHz"
                    ListBox1.Items.Add(scanres)
                    sbeg = nchk + 6
                Else
                    sbeg = send + 1
                End If
            End While

            Using st As New System.IO.StreamWriter(Application.StartupPath & "\scandt.txt", False, System.Text.Encoding.Default)
                st.WriteLine(TextBox2.Text) ' COM.No
                st.WriteLine(TextBox1.Text) ' Speed
                For i As Integer = 0 To ListBox1.Items.Count - 1
                    st.WriteLine(ListBox1.Items(i).ToString())
                Next
            End Using
        Else
            MessageBox.Show("SCAN OK が見つかりません" + vbCrLf + "AT+SCANを実行し下さい",
                "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ListBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseWheel
        If e.Delta > 0 Then
            swrite("AT+VOLD")
        Else
            swrite("AT+VOLU")
        End If
    End Sub

End Class
