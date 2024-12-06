<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(106, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(401, 25)
        Label1.TabIndex = 0
        Label1.Text = "feel free to contact us and follow on social media"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.download__6_
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(193, 103)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 60)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.download__7_
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(193, 186)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 56)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.scacascZ
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(193, 345)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 60)
        Button3.TabIndex = 3
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = My.Resources.Resources.scaca
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Location = New Point(193, 270)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 53)
        Button4.TabIndex = 4
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(193, 462)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 5
        Button5.Text = "back"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form16
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(553, 567)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form16"
        Text = "Form16"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
