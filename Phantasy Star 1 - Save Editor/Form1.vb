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

        '#############
        '### Alys ####
        '#############
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

        '#############
        '### Myau ####
        '#############
        MyauLevel.Value = bytes(Character.Myau(currentSave) + Character.Level)

        MyauCurrentHP.Value = bytes(Character.Myau(currentSave) + Character.CurrentHP)
        MyauMaxHP.Value = bytes(Character.Myau(currentSave) + Character.MaxHP)

        MyauCurrentTP.Value = bytes(Character.Myau(currentSave) + Character.CurrentTP)
        MyauMaxTP.Value = bytes(Character.Myau(currentSave) + Character.MaxTP)

        MyauAttack.Value = bytes(Character.Myau(currentSave) + Character.Attack)
        MyauDefense.Value = bytes(Character.Myau(currentSave) + Character.Defense)

        If (bytes(Character.Myau(currentSave) + Character.ActiveInParty) = 0) Then
            MyauActive.Checked = False
        Else
            MyauActive.Checked = True
        End If

        expHigh = bytes(Character.Myau(currentSave) + Character.ExpHigh)
        expLow = bytes(Character.Myau(currentSave) + Character.ExpLow)
        MyauEXP.Value = ((expHigh * 256) + expLow)

        '#############
        '### Odin ####
        '#############
        OdinLevel.Value = bytes(Character.Odin(currentSave) + Character.Level)

        OdinCurrentHP.Value = bytes(Character.Odin(currentSave) + Character.CurrentHP)
        OdinMaxHP.Value = bytes(Character.Odin(currentSave) + Character.MaxHP)

        OdinCurrentTP.Value = bytes(Character.Odin(currentSave) + Character.CurrentTP)
        OdinMaxTP.Value = bytes(Character.Odin(currentSave) + Character.MaxTP)

        OdinAttack.Value = bytes(Character.Odin(currentSave) + Character.Attack)
        OdinDefense.Value = bytes(Character.Odin(currentSave) + Character.Defense)

        If (bytes(Character.Odin(currentSave) + Character.ActiveInParty) = 0) Then
            OdinActive.Checked = False
        Else
            OdinActive.Checked = True
        End If

        expHigh = bytes(Character.Odin(currentSave) + Character.ExpHigh)
        expLow = bytes(Character.Odin(currentSave) + Character.ExpLow)
        OdinEXP.Value = ((expHigh * 256) + expLow)

        '#############
        '### Noah ####
        '#############
        NoahLevel.Value = bytes(Character.Noah(currentSave) + Character.Level)

        NoahCurrentHP.Value = bytes(Character.Noah(currentSave) + Character.CurrentHP)
        NoahMaxHP.Value = bytes(Character.Noah(currentSave) + Character.MaxHP)

        NoahCurrentTP.Value = bytes(Character.Noah(currentSave) + Character.CurrentTP)
        NoahMaxTP.Value = bytes(Character.Noah(currentSave) + Character.MaxTP)

        NoahAttack.Value = bytes(Character.Noah(currentSave) + Character.Attack)
        NoahDefense.Value = bytes(Character.Noah(currentSave) + Character.Defense)

        If (bytes(Character.Noah(currentSave) + Character.ActiveInParty) = 0) Then
            NoahActive.Checked = False
        Else
            NoahActive.Checked = True
        End If

        expHigh = bytes(Character.Noah(currentSave) + Character.ExpHigh)
        expLow = bytes(Character.Noah(currentSave) + Character.ExpLow)
        NoahEXP.Value = ((expHigh * 256) + expLow)


        file.Dispose()
        file.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        btnLoad.Enabled = vbFalse
        btnSave.Enabled = vbFalse

        Dim currentSave As Integer = 0

        Dim valueToWrite As Byte = vbNull
        Dim file As New FileStream("C:\Users\James\AppData\Roaming\RetroArch\saves\Phantasy Star 1.srm", FileMode.Open, FileAccess.Write)

        '#############
        '### Alis ####
        '#############

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

        'Set Active in Party
        file.Seek(Character.Alis(currentSave) + Character.ActiveInParty, SeekOrigin.Begin)
        If AlisActive.Checked = vbTrue Then
            file.WriteByte(Convert.ToByte(Hex(1), 16))
        Else
            file.WriteByte(Convert.ToByte(Hex(0), 16))
        End If

        TextBox1.Text = (AlisEXP.Value Mod 256) & " - " & (Int(AlisEXP.Value / 256))

        '#############
        '### Myau ####
        '#############
        file.Seek(Character.Myau(currentSave) + Character.Level, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(MyauLevel.Value), 16))

        file.Seek(Character.Myau(currentSave) + Character.CurrentHP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(MyauCurrentHP.Value), 16))

        file.Seek(Character.Myau(currentSave) + Character.MaxHP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(MyauMaxHP.Value), 16))

        file.Seek(Character.Myau(currentSave) + Character.CurrentTP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(MyauCurrentTP.Value), 16))

        file.Seek(Character.Myau(currentSave) + Character.MaxTP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(MyauMaxTP.Value), 16))

        file.Seek(Character.Myau(currentSave) + Character.Attack, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(MyauAttack.Value), 16))

        file.Seek(Character.Myau(currentSave) + Character.Defense, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(MyauDefense.Value), 16))

        'High byte for Experience.
        file.Seek(Character.Myau(currentSave) + Character.ExpHigh, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(Int(MyauEXP.Value / 256)), 16))

        'Low byte for Experience, cast to INT to round to nearest integer.
        file.Seek(Character.Myau(currentSave) + Character.ExpLow, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(MyauEXP.Value Mod 256), 16))

        'Set Active in Party
        file.Seek(Character.Myau(currentSave) + Character.ActiveInParty, SeekOrigin.Begin)
        If MyauActive.Checked = vbTrue Then
            file.WriteByte(Convert.ToByte(Hex(1), 16))
        Else
            file.WriteByte(Convert.ToByte(Hex(0), 16))
        End If

        '#############
        '### Odin ####
        '#############

        file.Seek(Character.Odin(currentSave) + Character.Level, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(OdinLevel.Value), 16))

        file.Seek(Character.Odin(currentSave) + Character.CurrentHP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(OdinCurrentHP.Value), 16))

        file.Seek(Character.Odin(currentSave) + Character.MaxHP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(OdinMaxHP.Value), 16))

        file.Seek(Character.Odin(currentSave) + Character.CurrentTP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(OdinCurrentTP.Value), 16))

        file.Seek(Character.Odin(currentSave) + Character.MaxTP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(OdinMaxTP.Value), 16))

        file.Seek(Character.Odin(currentSave) + Character.Attack, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(OdinAttack.Value), 16))

        file.Seek(Character.Odin(currentSave) + Character.Defense, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(OdinDefense.Value), 16))

        'High byte for Experience.
        file.Seek(Character.Odin(currentSave) + Character.ExpHigh, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(Int(OdinEXP.Value / 256)), 16))

        'Low byte for Experience, cast to INT to round to nearest integer.
        file.Seek(Character.Odin(currentSave) + Character.ExpLow, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(OdinEXP.Value Mod 256), 16))

        'Set Active in Party
        file.Seek(Character.Odin(currentSave) + Character.ActiveInParty, SeekOrigin.Begin)
        If OdinActive.Checked = vbTrue Then
            file.WriteByte(Convert.ToByte(Hex(1), 16))
        Else
            file.WriteByte(Convert.ToByte(Hex(0), 16))
        End If

        '#############
        '### Noah ####
        '#############

        file.Seek(Character.Noah(currentSave) + Character.Level, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(NoahLevel.Value), 16))

        file.Seek(Character.Noah(currentSave) + Character.CurrentHP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(NoahCurrentHP.Value), 16))

        file.Seek(Character.Noah(currentSave) + Character.MaxHP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(NoahMaxHP.Value), 16))

        file.Seek(Character.Noah(currentSave) + Character.CurrentTP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(NoahCurrentTP.Value), 16))

        file.Seek(Character.Noah(currentSave) + Character.MaxTP, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(NoahMaxTP.Value), 16))

        file.Seek(Character.Noah(currentSave) + Character.Attack, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(NoahAttack.Value), 16))

        file.Seek(Character.Noah(currentSave) + Character.Defense, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(NoahDefense.Value), 16))

        'High byte for Experience.
        file.Seek(Character.Noah(currentSave) + Character.ExpHigh, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(Int(NoahEXP.Value / 256)), 16))

        'Low byte for Experience, cast to INT to round to nearest integer.
        file.Seek(Character.Noah(currentSave) + Character.ExpLow, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(NoahEXP.Value Mod 256), 16))

        'Set Active in Party
        file.Seek(Character.Noah(currentSave) + Character.ActiveInParty, SeekOrigin.Begin)
        If NoahActive.Checked = vbTrue Then
            file.WriteByte(Convert.ToByte(Hex(1), 16))
        Else
            file.WriteByte(Convert.ToByte(Hex(0), 16))
        End If


        '#################
        '# Sanity Checks #
        '#################

        'Make sure at least one party member is active, and if not, make Alis active.
        If (AlisActive.Checked = vbFalse) And (MyauActive.Checked = vbFalse) And (OdinActive.Checked = vbFalse) And (NoahActive.Checked = vbFalse) Then
            MsgBox("There must be at least one Active party member.  Setting Alis to active.")
            file.Seek(Character.Alis(currentSave) + Character.ActiveInParty, SeekOrigin.Begin)
            file.WriteByte(Convert.ToByte(Hex(1), 16))
            'Update check mark visual without reloading save.
            AlisActive.Checked = vbTrue
        End If



        file.Dispose()
        file.Close()


        btnLoad.Enabled = vbTrue
        btnSave.Enabled = vbTrue

    End Sub
End Class
