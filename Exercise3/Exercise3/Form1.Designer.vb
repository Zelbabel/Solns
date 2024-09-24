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
        btnforLoop = New Button()
        lblenterNumber = New Label()
        txtnumber = New TextBox()
        btnCount = New Button()
        SuspendLayout()
        ' 
        ' btnforLoop
        ' 
        btnforLoop.Location = New Point(95, 97)
        btnforLoop.Name = "btnforLoop"
        btnforLoop.Size = New Size(181, 50)
        btnforLoop.TabIndex = 0
        btnforLoop.Text = "For Loop"
        btnforLoop.UseVisualStyleBackColor = True
        ' 
        ' lblenterNumber
        ' 
        lblenterNumber.AutoSize = True
        lblenterNumber.Location = New Point(461, 78)
        lblenterNumber.Name = "lblenterNumber"
        lblenterNumber.Size = New Size(122, 25)
        lblenterNumber.TabIndex = 1
        lblenterNumber.Text = "Enter Number"
        ' 
        ' txtnumber
        ' 
        txtnumber.Location = New Point(431, 107)
        txtnumber.Name = "txtnumber"
        txtnumber.Size = New Size(230, 31)
        txtnumber.TabIndex = 2
        ' 
        ' btnCount
        ' 
        btnCount.Location = New Point(447, 161)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(200, 38)
        btnCount.TabIndex = 3
        btnCount.Text = "Loop Number"
        btnCount.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCount)
        Controls.Add(txtnumber)
        Controls.Add(lblenterNumber)
        Controls.Add(btnforLoop)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnforLoop As Button
    Friend WithEvents lblenterNumber As Label
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents btnCount As Button

End Class
