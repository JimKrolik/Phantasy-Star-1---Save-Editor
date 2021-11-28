Imports System.IO
'Imports Character


Public Class Form1
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        btnSave.Enabled = vbTrue

        Dim currentSave As Integer = 0

        Dim expHigh As Integer = 0
        Dim expLow As Integer = 0

        Dim file As New FileStream("C:\Users\James\AppData\Roaming\RetroArch\saves\Phantasy Star 1.srm", FileMode.Open)

        Dim binaryReader As New BinaryReader(file)

        Dim bytes() As Byte = binaryReader.ReadBytes(8186)     'The length of a Phantasy Star 1 save file is fixed at 8186 bytes.

        AlisLevel.Value = bytes(Character.Alis(currentSave) + Character.Level)

        AlisCurrentHP.Value = bytes(Character.Alis(currentSave) + Character.CurrentHP)
        AlisMaxHP.Value = bytes(Character.Alis(currentSave) + Character.MaxHP)

        AlisCurrentTP.Value = bytes(Character.Alis(currentSave) + Character.CurrentTP)
        AlisMaxTP.Value = bytes(Character.Alis(currentSave) + Character.MaxTP)

        AlisAttack.Value = bytes(Character.Alis(currentSave) + Character.Attack)
        AlisDefense.Value = bytes(Character.Alis(currentSave) + Character.Defense)

        If (bytes(Character.Alis(currentSave) + Character.ActiveInParty) = 0) Then
            AlisActive.Checked = False
        Else
            AlisActive.Checked = True
        End If

        expHigh = bytes(Character.Alis(currentSave) + Character.ExpHigh)
        expLow = bytes(Character.Alis(currentSave) + Character.ExpLow)
        AlisEXP.Value = ((expHigh * 256) + expLow)



        file.Dispose()
        file.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        btnLoad.Enabled = vbFalse
        btnSave.Enabled = vbFalse

        Dim currentSave As Integer = 0

        Dim valueToWrite As Byte = vbNull
        Dim file As New FileStream("C:\Users\James\AppData\Roaming\RetroArch\saves\Phantasy Star 1.srm", FileMode.Open, FileAccess.Write)

        'Alis
        'Level
        file.Seek(Character.Alis(currentSave) + Character.Level, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(AlisLevel.Value), 16))

        file.Seek(Character.Alis(currentSave) + Character.CurrentHP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(AlisCurrentHP.Value), 16))

        file.Seek(Character.Alis(currentSave) + Character.MaxHP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(AlisMaxHP.Value), 16))

        file.Seek(Character.Alis(currentSave) + Character.CurrentTP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(AlisCurrentTP.Value), 16))

        file.Seek(Character.Alis(currentSave) + Character.MaxTP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(AlisMaxTP.Value), 16))

        file.Seek(Character.Alis(currentSave) + Character.Attack, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(AlisAttack.Value), 16))

        file.Seek(Character.Alis(currentSave) + Character.Defense, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(AlisDefense.Value), 16))

        'High byte for Experience.
        file.Seek(Character.Alis(currentSave) + Character.ExpHigh, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(Int(AlisEXP.Value / 256)), 16))

        'Low byte for Experience, cast to INT to round to nearest integer.
        file.Seek(Character.Alis(currentSave) + Character.ExpLow, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(AlisEXP.Value Mod 256), 16))

        TextBox1.Text = (AlisEXP.Value Mod 256) & " - " & (Int(AlisEXP.Value / 256))

        file.Dispose()
        file.Close()


        btnLoad.Enabled = vbTrue
        btnSave.Enabled = vbTrue

    End Sub
End Class
