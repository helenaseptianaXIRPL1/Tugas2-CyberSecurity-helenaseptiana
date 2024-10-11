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
        TextBox1 = New TextBox()
        BrowseDirectoryToolStripMenuItem = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        OpenFolderToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem1 = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        CutToolStripMenuItem = New ToolStripMenuItem()
        ListBox1 = New ListBox()
        BrowseDirectoryToolStripMenuItem.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Right
        TextBox1.Location = New Point(234, 24)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(355, 331)
        TextBox1.TabIndex = 0
        ' 
        ' BrowseDirectoryToolStripMenuItem
        ' 
        BrowseDirectoryToolStripMenuItem.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem})
        BrowseDirectoryToolStripMenuItem.Location = New Point(0, 0)
        BrowseDirectoryToolStripMenuItem.Name = "BrowseDirectoryToolStripMenuItem"
        BrowseDirectoryToolStripMenuItem.Size = New Size(589, 24)
        BrowseDirectoryToolStripMenuItem.TabIndex = 1
        BrowseDirectoryToolStripMenuItem.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, OpenFolderToolStripMenuItem, SaveToolStripMenuItem1, SaveAsToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(180, 22)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(180, 22)
        OpenToolStripMenuItem.Text = "Open File"
        ' 
        ' OpenFolderToolStripMenuItem
        ' 
        OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        OpenFolderToolStripMenuItem.Size = New Size(180, 22)
        OpenFolderToolStripMenuItem.Text = "Open Folder"
        ' 
        ' SaveToolStripMenuItem1
        ' 
        SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        SaveToolStripMenuItem1.Size = New Size(180, 22)
        SaveToolStripMenuItem1.Text = "Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(180, 22)
        SaveAsToolStripMenuItem.Text = "Save As"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopyToolStripMenuItem, PasteToolStripMenuItem, CutToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(102, 22)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(102, 22)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(102, 22)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(0, 25)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(228, 334)
        ListBox1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(589, 355)
        Controls.Add(ListBox1)
        Controls.Add(TextBox1)
        Controls.Add(BrowseDirectoryToolStripMenuItem)
        MainMenuStrip = BrowseDirectoryToolStripMenuItem
        Name = "Form1"
        Text = "Form1"
        BrowseDirectoryToolStripMenuItem.ResumeLayout(False)
        BrowseDirectoryToolStripMenuItem.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BrowseDirectoryToolStripMenuItem As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem

End Class
