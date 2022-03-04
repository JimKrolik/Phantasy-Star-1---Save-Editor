Public Class frmSave
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
    End Sub

    Public dungeonMap(256) As CheckBox
    Public currentDungeonMap(256) As CheckBox

    Private Sub frmSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Create the 16x16 grids for the current and updated save maps.

        Dim top As Integer = 20
        Dim leftOffset As Integer = 6
        For i As Integer = 0 To 255
            currentDungeonMap(i) = New CheckBox
            currentDungeonMap(i).Height = 16
            currentDungeonMap(i).Width = 16
            currentDungeonMap(i).Top = top
            currentDungeonMap(i).Left = leftOffset
            currentDungeonMap(i).Text = ""
            currentDungeonMap(i).Appearance = Appearance.Button
            grpCurrentDungeon.Controls.Add(currentDungeonMap(i))

            leftOffset += 16

            'If we hit the end of the row, drop and start over.
            'I did it this way so I can maintain a zero based array index for aligning with other loops.
            If ((i + 1) Mod 16) = 0 Then
                top += 16
                leftOffset = 6
            End If

            'Create handler to respond to events.
            AddHandler currentDungeonMap(i).CheckedChanged, AddressOf currentDungeonMap_checkchanged
        Next

        'Load the data for the new dungeon, copying the current save as a reference point.
        top = 20
        leftOffset = 6
        For i As Integer = 0 To 255
            dungeonMap(i) = New CheckBox
            dungeonMap(i).Height = 16
            dungeonMap(i).Width = 16
            dungeonMap(i).Top = top
            dungeonMap(i).Left = leftOffset
            dungeonMap(i).Text = ""
            dungeonMap(i).Appearance = Appearance.Button
            grpNewDungeon.Controls.Add(dungeonMap(i))

            leftOffset += 16

            'If we hit the end of the row, drop and start over.
            'I did it this way so I can maintain a zero based array index for aligning with other loops.
            If ((i + 1) Mod 16) = 0 Then
                top += 16
                leftOffset = 6
            End If

            'Create handler to respond to events.
            AddHandler dungeonMap(i).CheckedChanged, AddressOf dungeonMap_checkchanged
        Next
    End Sub

    Sub dungeonMap_checkchanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub currentDungeonMap_checkchanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(currentDungeonMap(Index).Name)

    End Sub


    Private Sub cmbDungeonSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDungeonSelector.SelectedIndexChanged

        Dim myChar As Char

        'Load the new dungeon
        For i = 0 To 255
            'Read each bit of the dungeon data string and feed it into the load function for form data.
            myChar = Game.DungeonLayout(cmbDungeonSelector.SelectedIndex).Chars(i)
            Game.updateDungeonLayout(i, myChar)
        Next

    End Sub
End Class