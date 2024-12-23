<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer.
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnTest = New Button()
        TextBox_UN = New TextBox()
        clickLog = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox_Pass = New TextBox()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnTest.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTest.Location = New Point(30, 38)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(259, 40)
        btnTest.TabIndex = 0
        btnTest.Text = "CHECK CONNECTION"
        btnTest.UseVisualStyleBackColor = False
        ' 
        ' TextBox_UN
        ' 
        TextBox_UN.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_UN.Location = New Point(325, 133)
        TextBox_UN.Name = "TextBox_UN"
        TextBox_UN.Size = New Size(208, 26)
        TextBox_UN.TabIndex = 1
        ' 
        ' clickLog
        ' 
        clickLog.BackColor = SystemColors.MenuHighlight
        clickLog.FlatStyle = FlatStyle.System
        clickLog.Font = New Font("Times New Roman", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clickLog.Location = New Point(358, 255)
        clickLog.Name = "clickLog"
        clickLog.Size = New Size(153, 47)
        clickLog.TabIndex = 2
        clickLog.Text = "LOGIN"
        clickLog.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(168, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 21)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(177, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 21)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' TextBox_Pass
        ' 
        TextBox_Pass.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Pass.Location = New Point(325, 196)
        TextBox_Pass.Name = "TextBox_Pass"
        TextBox_Pass.PasswordChar = "*"c
        TextBox_Pass.Size = New Size(208, 26)
        TextBox_Pass.TabIndex = 5
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox_Pass)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(clickLog)
        Controls.Add(TextBox_UN)
        Controls.Add(btnTest)
        Name = "Form1"
        Text = "MYSQLDB DATA CONNECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTest As Button
    Friend WithEvents TextBox_UN As TextBox
    Friend WithEvents clickLog As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Pass As TextBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand

End Class
