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
        btnSave = New Button()
        btnRemove = New Button()
        Label1 = New Label()
        txtDescription = New TextBox()
        lstvData = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        lstItems = New ListBox()
        CreteFileBtn = New Button()
        lblCount = New Label()
        LblTotal = New Label()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 14F)
        btnSave.Location = New Point(452, 49)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(130, 47)
        btnSave.TabIndex = 0
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Segoe UI", 14F)
        btnRemove.Location = New Point(603, 49)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(145, 47)
        btnRemove.TabIndex = 1
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(48, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 28)
        Label1.TabIndex = 2
        Label1.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(166, 48)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(179, 34)
        txtDescription.TabIndex = 1
        ' 
        ' lstvData
        ' 
        lstvData.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        lstvData.Font = New Font("Segoe UI", 15F)
        lstvData.Location = New Point(321, 102)
        lstvData.Name = "lstvData"
        lstvData.Size = New Size(467, 261)
        lstvData.TabIndex = 4
        lstvData.UseCompatibleStateImageBehavior = False
        lstvData.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 120
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Description"
        ColumnHeader2.Width = 120
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "PIRCE"
        ColumnHeader3.Width = 120
        ' 
        ' lstItems
        ' 
        lstItems.FormattingEnabled = True
        lstItems.ItemHeight = 15
        lstItems.Location = New Point(12, 102)
        lstItems.Name = "lstItems"
        lstItems.Size = New Size(260, 244)
        lstItems.TabIndex = 5
        ' 
        ' CreteFileBtn
        ' 
        CreteFileBtn.Font = New Font("Segoe UI", 14F)
        CreteFileBtn.Location = New Point(48, 380)
        CreteFileBtn.Name = "CreteFileBtn"
        CreteFileBtn.Size = New Size(157, 47)
        CreteFileBtn.TabIndex = 6
        CreteFileBtn.Text = "Create File Exel"
        CreteFileBtn.UseVisualStyleBackColor = True
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Font = New Font("Segoe UI", 13F)
        lblCount.Location = New Point(378, 396)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(0, 25)
        lblCount.TabIndex = 7
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Font = New Font("Segoe UI", 13F)
        LblTotal.Location = New Point(685, 393)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(0, 25)
        LblTotal.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LblTotal)
        Controls.Add(lblCount)
        Controls.Add(CreteFileBtn)
        Controls.Add(lstItems)
        Controls.Add(lstvData)
        Controls.Add(txtDescription)
        Controls.Add(Label1)
        Controls.Add(btnRemove)
        Controls.Add(btnSave)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lstvData As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents lstItems As ListBox
    Friend WithEvents CreteFileBtn As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents LblTotal As Label

End Class
