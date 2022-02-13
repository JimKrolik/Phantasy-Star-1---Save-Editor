Public Class frmSave
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
    End Sub

    Public dungeonMap(256) As CheckBox

    Private Sub frmSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Create the 16x16 grid for the dungeon data.

        Dim top As Integer = 20
        Dim leftOffset As Integer = 6
        For i As Integer = 0 To 255
            dungeonMap(i) = New CheckBox
            dungeonMap(i).Height = 16
            dungeonMap(i).Width = 16
            dungeonMap(i).Top = top
            dungeonMap(i).Left = leftOffset
            dungeonMap(i).Text = ""
            dungeonMap(i).Appearance = Appearance.Button
            grpDungeon.Controls.Add(dungeonMap(i))

            leftOffset += 16

            'If we hit the end of the row, drop and start over.
            'I did it this way so I can maintain a zero based array index for aligning with other loops.
            If ((i + 1) Mod 16) = 0 Then
                top += 16
                leftOffset = 6
            End If

            'AddHandler dungeonMap(i).CheckedChanged, AddressOf dungeonMap_checkchanged


        Next
    End Sub
End Class