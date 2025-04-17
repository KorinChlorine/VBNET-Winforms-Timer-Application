<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button2 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button2.BackColor = Color.Black
        Button2.BackgroundImage = My.Resources.Resources.Polygon_1
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(89, 139)
        Button2.Name = "Button2"
        Button2.Size = New Size(62, 47)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Digital-7 Mono", 60F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Lime
        Label1.Location = New Point(2, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 80)
        Label1.TabIndex = 9
        Label1.Text = "00:00:00"
        ' 
        ' Button3
        ' 
        Button3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button3.BackColor = Color.Black
        Button3.BackgroundImage = My.Resources.Resources.Restart
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(194, 131)
        Button3.Name = "Button3"
        Button3.Size = New Size(60, 63)
        Button3.TabIndex = 11
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-16, -8)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(370, 49)
        Panel1.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button1.BackColor = Color.Black
        Button1.BackgroundImage = My.Resources.Resources.Vector
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(330, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(24, 24)
        Button1.TabIndex = 13
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(347, 222)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(Button2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        ShowIcon = False
        Text = "Timer"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button

End Class
