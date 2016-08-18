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
        Me.btnSchwuchtel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSchwuchtel
        '
        Me.btnSchwuchtel.Location = New System.Drawing.Point(200, 100)
        Me.btnSchwuchtel.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnSchwuchtel.Name = "btnSchwuchtel"
        Me.btnSchwuchtel.Size = New System.Drawing.Size(525, 361)
        Me.btnSchwuchtel.TabIndex = 1
        Me.btnSchwuchtel.Text = "Traust du dich, den Schwuchtel-Eid zu machen? Schaffst du es, den Türsteher mit r" &
    "ichtigen Antworten auszutricksen? Antworte niemals falsch!"
        Me.btnSchwuchtel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.btnSchwuchtel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSchwuchtel As Button
End Class
