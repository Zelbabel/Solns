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
        txtnumber = New TextBox()
        number = New Label()
        btncheckNumber = New Button()
        SuspendLayout()
        ' 
        ' txtnumber
        ' 
        txtnumber.Location = New Point(319, 94)
        txtnumber.Name = "txtnumber"
        txtnumber.Size = New Size(239, 31)
        txtnumber.TabIndex = 0
        ' 
        ' number
        ' 
        number.AutoSize = True
        number.Location = New Point(178, 94)
        number.Name = "number"
        number.Size = New Size(122, 25)
        number.TabIndex = 1
        number.Text = "Enter Number"
        ' 
        ' btncheckNumber
        ' 
        btncheckNumber.Location = New Point(226, 179)
        btncheckNumber.Name = "btncheckNumber"
        btncheckNumber.Size = New Size(290, 52)
        btncheckNumber.TabIndex = 2
        btncheckNumber.Text = "Check Number"
        btncheckNumber.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btncheckNumber)
        Controls.Add(number)
        Controls.Add(txtnumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtnumber As TextBox
    Friend WithEvents number As Label
    Friend WithEvents btncheckNumber As Button

End Class
