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
        Label2 = New Label()
        txtkalimat = New TextBox()
        txthasil = New TextBox()
        BtnLeft = New Button()
        BtnMid = New Button()
        BtnRight = New Button()
        BtnLower = New Button()
        BtnProper = New Button()
        BtnUpper = New Button()
        BtnLTrim = New Button()
        BtnLen = New Button()
        BtnTrim = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kalimat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 25)
        Label2.TabIndex = 1
        Label2.Text = "Hasil"
        ' 
        ' txtkalimat
        ' 
        txtkalimat.Location = New Point(116, 25)
        txtkalimat.Name = "txtkalimat"
        txtkalimat.Size = New Size(254, 31)
        txtkalimat.TabIndex = 2
        ' 
        ' txthasil
        ' 
        txthasil.Location = New Point(116, 78)
        txthasil.Name = "txthasil"
        txthasil.Size = New Size(254, 31)
        txthasil.TabIndex = 3
        ' 
        ' BtnLeft
        ' 
        BtnLeft.Location = New Point(31, 132)
        BtnLeft.Name = "BtnLeft"
        BtnLeft.Size = New Size(109, 47)
        BtnLeft.TabIndex = 4
        BtnLeft.Text = "Left"
        BtnLeft.UseVisualStyleBackColor = True
        ' 
        ' BtnMid
        ' 
        BtnMid.Location = New Point(146, 132)
        BtnMid.Name = "BtnMid"
        BtnMid.Size = New Size(109, 47)
        BtnMid.TabIndex = 5
        BtnMid.Text = "Mid"
        BtnMid.UseVisualStyleBackColor = True
        ' 
        ' BtnRight
        ' 
        BtnRight.Location = New Point(261, 132)
        BtnRight.Name = "BtnRight"
        BtnRight.Size = New Size(109, 47)
        BtnRight.TabIndex = 6
        BtnRight.Text = "Right"
        BtnRight.UseVisualStyleBackColor = True
        ' 
        ' BtnLower
        ' 
        BtnLower.Location = New Point(261, 185)
        BtnLower.Name = "BtnLower"
        BtnLower.Size = New Size(109, 47)
        BtnLower.TabIndex = 9
        BtnLower.Text = "Lower"
        BtnLower.UseVisualStyleBackColor = True
        ' 
        ' BtnProper
        ' 
        BtnProper.Location = New Point(146, 185)
        BtnProper.Name = "BtnProper"
        BtnProper.Size = New Size(109, 47)
        BtnProper.TabIndex = 8
        BtnProper.Text = "Proper"
        BtnProper.UseVisualStyleBackColor = True
        ' 
        ' BtnUpper
        ' 
        BtnUpper.Location = New Point(31, 185)
        BtnUpper.Name = "BtnUpper"
        BtnUpper.Size = New Size(109, 47)
        BtnUpper.TabIndex = 7
        BtnUpper.Text = "Upper"
        BtnUpper.UseVisualStyleBackColor = True
        ' 
        ' BtnLTrim
        ' 
        BtnLTrim.Location = New Point(261, 238)
        BtnLTrim.Name = "BtnLTrim"
        BtnLTrim.Size = New Size(109, 47)
        BtnLTrim.TabIndex = 12
        BtnLTrim.Text = "LTrim"
        BtnLTrim.UseVisualStyleBackColor = True
        ' 
        ' BtnLen
        ' 
        BtnLen.Location = New Point(146, 238)
        BtnLen.Name = "BtnLen"
        BtnLen.Size = New Size(109, 47)
        BtnLen.TabIndex = 11
        BtnLen.Text = "Len"
        BtnLen.UseVisualStyleBackColor = True
        ' 
        ' BtnTrim
        ' 
        BtnTrim.Location = New Point(31, 238)
        BtnTrim.Name = "BtnTrim"
        BtnTrim.Size = New Size(109, 47)
        BtnTrim.TabIndex = 10
        BtnTrim.Text = "Trim"
        BtnTrim.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnLTrim)
        Controls.Add(BtnLen)
        Controls.Add(BtnTrim)
        Controls.Add(BtnLower)
        Controls.Add(BtnProper)
        Controls.Add(BtnUpper)
        Controls.Add(BtnRight)
        Controls.Add(BtnMid)
        Controls.Add(BtnLeft)
        Controls.Add(txthasil)
        Controls.Add(txtkalimat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtkalimat As TextBox
    Friend WithEvents txthasil As TextBox
    Friend WithEvents BtnLeft As Button
    Friend WithEvents BtnMid As Button
    Friend WithEvents BtnRight As Button
    Friend WithEvents BtnLower As Button
    Friend WithEvents BtnProper As Button
    Friend WithEvents BtnUpper As Button
    Friend WithEvents BtnLTrim As Button
    Friend WithEvents BtnLen As Button
    Friend WithEvents BtnTrim As Button

End Class
