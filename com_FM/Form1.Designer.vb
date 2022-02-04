<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.disp = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(239, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(45, 19)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "38400"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(293, 9)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(43, 19)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "COMx"
        '
        'disp
        '
        Me.disp.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.disp.Location = New System.Drawing.Point(293, 49)
        Me.disp.Multiline = True
        Me.disp.Name = "disp"
        Me.disp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.disp.Size = New System.Drawing.Size(176, 212)
        Me.disp.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "接続"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(422, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(416, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 25)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "終了"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 270)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(221, 19)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "AT+CH="
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(239, 268)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 22)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "送信"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"AT+CHD", "AT+CHU", "AT+FRED", "AT+FREU", "AT+VOLD", "AT+VOLU", "AT+CH=01", "AT+FRE=800", "AT+VOL=16", "AT+VOL=00", "", "AT+SCAN", "AT+SCAND", "AT+SCANU", "AT+SCANSTOP", "AT+PAUS", "", "AT+RET", "AT+SNR_RSSI", "AT+CAMPUS=1", "AT+CAMPUS=0", "AT+BANK=00", "AT+BANK=01", "AT+CR"})
        Me.ListBox2.Location = New System.Drawing.Point(165, 49)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(122, 212)
        Me.ListBox2.TabIndex = 11
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 49)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(147, 212)
        Me.ListBox1.TabIndex = 12
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(293, 267)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 25)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "受信リスト更新"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "受信周波数選択"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "コマンド送信"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "応答"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "周波数"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 296)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.disp)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "FM_RADIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents disp As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
