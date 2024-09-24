<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        userName = New Label()
        userAge = New Label()
        userColor = New Label()
        txtuserName = New TextBox()
        txtuserAge = New TextBox()
        txtuserColor = New TextBox()
        btnDisplay = New Button()
        SuspendLayout()
        ' 
        ' userName
        ' 
        userName.AutoSize = True
        userName.Location = New Point(121, 32)
        userName.Margin = New Padding(2, 0, 2, 0)
        userName.Name = "userName"
        userName.Size = New Size(39, 15)
        userName.TabIndex = 0
        userName.Text = "Name"
        ' 
        ' userAge
        ' 
        userAge.AutoSize = True
        userAge.Location = New Point(132, 71)
        userAge.Margin = New Padding(2, 0, 2, 0)
        userAge.Name = "userAge"
        userAge.Size = New Size(28, 15)
        userAge.TabIndex = 1
        userAge.Text = "Age"
        ' 
        ' userColor
        ' 
        userColor.AutoSize = True
        userColor.Location = New Point(121, 119)
        userColor.Margin = New Padding(2, 0, 2, 0)
        userColor.Name = "userColor"
        userColor.Size = New Size(43, 15)
        userColor.TabIndex = 2
        userColor.Text = "Colour"
        ' 
        ' txtuserName
        ' 
        txtuserName.Location = New Point(206, 28)
        txtuserName.Margin = New Padding(2, 2, 2, 2)
        txtuserName.Multiline = True
        txtuserName.Name = "txtuserName"
        txtuserName.Size = New Size(207, 31)
        txtuserName.TabIndex = 3
        ' 
        ' txtuserAge
        ' 
        txtuserAge.Location = New Point(203, 67)
        txtuserAge.Margin = New Padding(2, 2, 2, 2)
        txtuserAge.Multiline = True
        txtuserAge.Name = "txtuserAge"
        txtuserAge.Size = New Size(208, 31)
        txtuserAge.TabIndex = 4
        ' 
        ' txtuserColor
        ' 
        txtuserColor.Location = New Point(204, 116)
        txtuserColor.Margin = New Padding(2, 2, 2, 2)
        txtuserColor.Multiline = True
        txtuserColor.Name = "txtuserColor"
        txtuserColor.Size = New Size(203, 31)
        txtuserColor.TabIndex = 5
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(202, 181)
        btnDisplay.Margin = New Padding(2, 2, 2, 2)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(210, 57)
        btnDisplay.TabIndex = 6
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(631, 297)
        Controls.Add(btnDisplay)
        Controls.Add(txtuserColor)
        Controls.Add(txtuserAge)
        Controls.Add(txtuserName)
        Controls.Add(userColor)
        Controls.Add(userAge)
        Controls.Add(userName)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userName As Label
    Friend WithEvents userAge As Label
    Friend WithEvents userColor As Label
    Friend WithEvents txtuserName As TextBox
    Friend WithEvents txtuserAge As TextBox
    Friend WithEvents txtuserColor As TextBox
    Friend WithEvents btnDisplay As Button

End Class
