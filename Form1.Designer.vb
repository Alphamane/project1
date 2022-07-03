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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMemberToolStripMenuItem, Me.SearchStaffToolStripMenuItem, Me.SearchMemberToolStripMenuItem, Me.DeleteMemberToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 72)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewMemberToolStripMenuItem
        '
        Me.NewMemberToolStripMenuItem.Image = CType(resources.GetObject("NewMemberToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewMemberToolStripMenuItem.Name = "NewMemberToolStripMenuItem"
        Me.NewMemberToolStripMenuItem.Size = New System.Drawing.Size(123, 68)
        Me.NewMemberToolStripMenuItem.Text = "New member"
        '
        'SearchStaffToolStripMenuItem
        '
        Me.SearchStaffToolStripMenuItem.Image = CType(resources.GetObject("SearchStaffToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchStaffToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchStaffToolStripMenuItem.Name = "SearchStaffToolStripMenuItem"
        Me.SearchStaffToolStripMenuItem.Size = New System.Drawing.Size(100, 68)
        Me.SearchStaffToolStripMenuItem.Text = "New Staff"
        '
        'SearchMemberToolStripMenuItem
        '
        Me.SearchMemberToolStripMenuItem.Image = CType(resources.GetObject("SearchMemberToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchMemberToolStripMenuItem.Name = "SearchMemberToolStripMenuItem"
        Me.SearchMemberToolStripMenuItem.Size = New System.Drawing.Size(166, 68)
        Me.SearchMemberToolStripMenuItem.Text = "Search member"
        '
        'DeleteMemberToolStripMenuItem
        '
        Me.DeleteMemberToolStripMenuItem.Image = CType(resources.GetObject("DeleteMemberToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeleteMemberToolStripMenuItem.Name = "DeleteMemberToolStripMenuItem"
        Me.DeleteMemberToolStripMenuItem.Size = New System.Drawing.Size(148, 68)
        Me.DeleteMemberToolStripMenuItem.Text = "Delete member"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(85, 68)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(88, 68)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
