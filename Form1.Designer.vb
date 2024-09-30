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
        Label1 = New Label()
        lblentermarks = New Label()
        lblgrade = New Label()
        txtentermarks = New TextBox()
        txtgrade = New TextBox()
        btnevaluate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(226, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 15)
        Label1.TabIndex = 0
        Label1.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' lblentermarks
        ' 
        lblentermarks.AutoSize = True
        lblentermarks.Location = New Point(103, 103)
        lblentermarks.Name = "lblentermarks"
        lblentermarks.Size = New Size(72, 15)
        lblentermarks.TabIndex = 1
        lblentermarks.Text = "Enter Marks "
        ' 
        ' lblgrade
        ' 
        lblgrade.AutoSize = True
        lblgrade.Location = New Point(103, 173)
        lblgrade.Name = "lblgrade"
        lblgrade.Size = New Size(38, 15)
        lblgrade.TabIndex = 2
        lblgrade.Text = "Grade"
        ' 
        ' txtentermarks
        ' 
        txtentermarks.Location = New Point(304, 95)
        txtentermarks.Name = "txtentermarks"
        txtentermarks.Size = New Size(227, 23)
        txtentermarks.TabIndex = 3
        ' 
        ' txtgrade
        ' 
        txtgrade.Location = New Point(304, 173)
        txtgrade.Name = "txtgrade"
        txtgrade.Size = New Size(227, 23)
        txtgrade.TabIndex = 4
        ' 
        ' btnevaluate
        ' 
        btnevaluate.Location = New Point(241, 238)
        btnevaluate.Name = "btnevaluate"
        btnevaluate.Size = New Size(155, 22)
        btnevaluate.TabIndex = 5
        btnevaluate.Text = "Evaluate"
        btnevaluate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(653, 322)
        Controls.Add(btnevaluate)
        Controls.Add(txtgrade)
        Controls.Add(txtentermarks)
        Controls.Add(lblgrade)
        Controls.Add(lblentermarks)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Grade Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblentermarks As Label
    Friend WithEvents lblgrade As Label
    Friend WithEvents txtentermarks As TextBox
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents btnevaluate As Button

End Class
