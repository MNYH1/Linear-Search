<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGen = New System.Windows.Forms.Button()
        Me.btnLinearSearch = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGen
        '
        Me.btnGen.Location = New System.Drawing.Point(20, 37)
        Me.btnGen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(97, 37)
        Me.btnGen.TabIndex = 0
        Me.btnGen.Text = "Generate"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'btnLinearSearch
        '
        Me.btnLinearSearch.Location = New System.Drawing.Point(20, 93)
        Me.btnLinearSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLinearSearch.Name = "btnLinearSearch"
        Me.btnLinearSearch.Size = New System.Drawing.Size(97, 37)
        Me.btnLinearSearch.TabIndex = 1
        Me.btnLinearSearch.Text = "Linear Search"
        Me.btnLinearSearch.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(20, 203)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(97, 37)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "End"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(20, 146)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 37)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear List"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(145, 40)
        Me.lstDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(139, 303)
        Me.lstDisplay.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 377)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnLinearSearch)
        Me.Controls.Add(Me.btnGen)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGen As Button
    Friend WithEvents btnLinearSearch As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstDisplay As ListBox
End Class
