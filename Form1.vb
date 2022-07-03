Public Class Form1
    Private Sub NewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewMemberToolStripMenuItem.Click
        NewMember.Show()

    End Sub

    Private Sub SearchStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchStaffToolStripMenuItem.Click
        NewStaff.show()
    End Sub

    Private Sub SearchMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchMemberToolStripMenuItem.Click
        Searchmember.Show()
    End Sub

    Private Sub DeleteMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMemberToolStripMenuItem.Click
        Deletemember.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
    End Sub

End Class