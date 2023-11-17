Public Class Form4
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Name = "Node0" Then
            RichTextBox1.Text = "Both the themes gallery and the quick styles gallery provide reset"
        End If
        If e.Node.Name = "Node1" Then
            RichTextBox1.Text = "To change the looks available in the quick style gallery, use the change current quick style set"
        End If
        If e.Node.Name = "Node2" Then
            RichTextBox1.Text = "To change the looks available in the quick style gallery, use the change current quick style set"
        End If

        If e.Node.Name = "Node3" Then
            RichTextBox1.Text = "To change the looks available in the quick style gallery, use the change current quick style set"
        End If

        If e.Node.Name = "Node4" Then
            RichTextBox1.Text = "To change the looks available in the quick style gallery, use the change current quick style set"
        End If

        If e.Node.Name = "Node5" Then
            RichTextBox1.Text = "To change the looks available in the quick style gallery, use the change current quick style set"
        End If
        If e.Node.Name = "Node6" Then
            Me.Hide()
        End If
    End Sub
End Class