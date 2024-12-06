<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        pictureBox2 = New PictureBox()
        pictureBox1 = New PictureBox()
        btn3 = New Button()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(160, 318)
        Button6.Name = "Button6"
        Button6.Size = New Size(112, 34)
        Button6.TabIndex = 42
        Button6.Text = "CONTACT"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(160, 241)
        Button5.Name = "Button5"
        Button5.Size = New Size(127, 34)
        Button5.TabIndex = 41
        Button5.Text = "BOOK NOW"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(160, 172)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 40
        Button4.Text = "PACKAGES"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(160, 99)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 39
        Button2.Text = "SERVICES"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(160, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 38
        Button1.Text = "ABOUT US"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' pictureBox2
        ' 
        pictureBox2.Dock = DockStyle.Fill
        pictureBox2.Image = My.Resources.Resources.dccac
        pictureBox2.Location = New Point(0, 0)
        pictureBox2.Name = "pictureBox2"
        pictureBox2.Size = New Size(524, 461)
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox2.TabIndex = 37
        pictureBox2.TabStop = False
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Dock = DockStyle.Fill
        pictureBox1.Location = New Point(0, 0)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(524, 461)
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox1.TabIndex = 36
        pictureBox1.TabStop = False
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(160, 392)
        btn3.Name = "btn3"
        btn3.Size = New Size(112, 34)
        btn3.TabIndex = 43
        btn3.Text = "EXIT"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(524, 461)
        Controls.Add(btn3)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(pictureBox2)
        Controls.Add(pictureBox1)
        Name = "Form3"
        Text = "Form3"
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents btn3 As Button
End Class
