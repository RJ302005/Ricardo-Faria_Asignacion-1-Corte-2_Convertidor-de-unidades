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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Unid_label = New Label()
        convertlabel = New Label()
        input = New ComboBox()
        converter = New ComboBox()
        value = New Label()
        txtbx1 = New TextBox()
        TextBox1 = New TextBox()
        button1 = New Button()
        output = New TextBox()
        SuspendLayout()
        ' 
        ' Unid_label
        ' 
        resources.ApplyResources(Unid_label, "Unid_label")
        Unid_label.Name = "Unid_label"
        ' 
        ' convertlabel
        ' 
        resources.ApplyResources(convertlabel, "convertlabel")
        convertlabel.Name = "convertlabel"
        ' 
        ' input
        ' 
        resources.ApplyResources(input, "input")
        input.FormattingEnabled = True
        input.Items.AddRange(New Object() {resources.GetString("input.Items"), resources.GetString("input.Items1"), resources.GetString("input.Items2"), resources.GetString("input.Items3"), resources.GetString("input.Items4"), resources.GetString("input.Items5"), resources.GetString("input.Items6")})
        input.Name = "input"
        ' 
        ' converter
        ' 
        resources.ApplyResources(converter, "converter")
        converter.FormattingEnabled = True
        converter.Items.AddRange(New Object() {resources.GetString("converter.Items"), resources.GetString("converter.Items1"), resources.GetString("converter.Items2"), resources.GetString("converter.Items3"), resources.GetString("converter.Items4"), resources.GetString("converter.Items5"), resources.GetString("converter.Items6")})
        converter.Name = "converter"
        ' 
        ' value
        ' 
        resources.ApplyResources(value, "value")
        value.BackColor = SystemColors.Control
        value.Name = "value"
        ' 
        ' txtbx1
        ' 
        resources.ApplyResources(txtbx1, "txtbx1")
        txtbx1.Name = "txtbx1"
        ' 
        ' TextBox1
        ' 
        resources.ApplyResources(TextBox1, "TextBox1")
        TextBox1.Name = "TextBox1"
        ' 
        ' button1
        ' 
        resources.ApplyResources(button1, "button1")
        button1.Name = "button1"
        button1.UseVisualStyleBackColor = True
        ' 
        ' output
        ' 
        resources.ApplyResources(output, "output")
        output.Name = "output"
        output.ReadOnly = True
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(output)
        Controls.Add(button1)
        Controls.Add(TextBox1)
        Controls.Add(value)
        Controls.Add(converter)
        Controls.Add(input)
        Controls.Add(convertlabel)
        Controls.Add(Unid_label)
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents Unid_label As Label
    Friend WithEvents convertlabel As Label
    Friend WithEvents input As ComboBox
    Friend WithEvents converter As ComboBox
    Friend WithEvents value As Label
    Friend WithEvents valor As TextBox
    Private WithEvents txtbx1 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents button1 As Button
    Public WithEvents output As TextBox

End Class
