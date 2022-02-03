Imports System.IO
'Imports Character


Public Class Form1
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        btnSave.Enabled = True
        btnInventoryAdd.Enabled = True
        btnInventoryDelete.Enabled = True

        Dim currentSave As Integer = 0

        Dim expHigh As Integer = 0
        Dim expLow As Integer = 0
        Dim mstLow As Integer = 0
        Dim mstHigh As Integer = 0

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

        '#################
        '### Inventory ###
        '#################

        lstInventory.Items.Clear()
        For i = Items.InventoryOffset(currentSave) To (Items.InventoryOffset(currentSave) + 31)

            If (bytes(i) = 0) Then
                Exit For
            End If
            lstInventory.Items.Add(Items.Name(bytes(i)))

        Next

        '###########################
        '### Inventory Drop Down ###
        '###########################

        cmbItems.Items.Clear()
        For i = 1 To 62
            cmbItems.Items.Add(Items.Name(i))
        Next
        cmbItems.SelectedIndex = 0

        '########################
        '### Recall Drop Down ###
        '########################

        cmbRecall.Items.Clear()
        For i = 0 To 8
            cmbRecall.Items.Add(Game.RecallLocation(i))
        Next

        cmbRecall.SelectedIndex = bytes(Game.TransferRecallOffset(currentSave))


        '##############
        '### Meseta ###
        '##############

        mstLow = bytes(Game.MesetaOffset(currentSave))
        mstHigh = bytes(Game.MesetaOffset(currentSave) + 1)
        Meseta.Value = ((mstHigh * 256) + mstLow)

        '##############
        '### Chests ###
        '##############

        For i = 0 To 127
            If bytes(Game.ChestOffset(currentSave) + i) = 0 Then
                checkChests(i, False)
            Else
                checkChests(i, True)
            End If

        Next

        '#####################
        '### Form Controls ###
        '#####################

        If lstInventory.Items.Count >= 32 Then
            btnInventoryAdd.Enabled = False
        End If


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

        '##################
        '# Save Inventory #
        '##################

        'Clear existing inventory items in case of change
        For i = Items.InventoryOffset(currentSave) To (Items.InventoryOffset(currentSave) + 31)
            file.Seek(i, SeekOrigin.Begin)
            file.WriteByte(Convert.ToByte(Hex(0), 16))
        Next

        'Clear the inventory count.
        file.Seek(Items.InventoryOffset(currentSave) + 34, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(0), 16))

        'Save inventory
        For i = 0 To lstInventory.Items.Count - 1
            file.Seek(Items.InventoryOffset(currentSave) + i, SeekOrigin.Begin)
            file.WriteByte(Convert.ToByte(Hex(cmbItems.FindString(lstInventory.Items(i)) + 1), 16))
        Next

        'Update the inventory count.
        file.Seek(Items.InventoryOffset(currentSave) + 34, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(lstInventory.Items.Count), 16))

        '########################
        '### Recall Drop Down ###
        '########################

        file.Seek(Game.TransferRecallOffset(currentSave), SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(cmbRecall.SelectedIndex), 16))

        '##########
        '# Meseta #
        '##########

        'High byte for Meseta
        file.Seek(Game.MesetaOffset(currentSave) + 1, SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(Int(Meseta.Value / 256)), 16))

        'Low byte for Meseta
        file.Seek(Game.MesetaOffset(currentSave), SeekOrigin.Begin)
        file.WriteByte(Convert.ToByte(Hex(Int(Meseta.Value Mod 256)), 16))




        '#################
        '# Sanity Checks #
        '#################

        'Make sure at least one party member is active, and if not, make Alis active.
        If (AlisActive.Checked = vbFalse) And (MyauActive.Checked = vbFalse) And (OdinActive.Checked = vbFalse) And (NoahActive.Checked = vbFalse) Then
            MsgBox("There must be at least one Active party member.  Setting Alis to active.")
            file.Seek(Character.Alis(currentSave) + Character.ActiveInParty, SeekOrigin.Begin)
            file.WriteByte(Convert.ToByte(Hex(1), 16))
            'Update check mark visual without reloading save.
            AlisActive.Checked = True
        End If




        file.Dispose()
        file.Close()


        btnLoad.Enabled = True
        btnSave.Enabled = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Disable inventory buttons
        btnInventoryAdd.Enabled = False
        btnInventoryDelete.Enabled = False

    End Sub

    Public Sub checkChests(checkBoxNum As Integer, isItChecked As Boolean)
        'Map our checkboxes into an array 
        Dim chest(200) As CheckBox

        chest(0) = CH001            'Palma      Camineet            Compass
        chest(1) = CH002            'Palma      Medusa Cave         --need to check    
        chest(2) = CH003            'Palma      Medusa Cave         --need to check
        chest(3) = CH004            'Palma      Dr. Luveno Cave     Empty
        chest(4) = CH005            'Palma      Camineet            Dungeon Key
        chest(5) = CH006            'Palma      Camineet            50 MST
        chest(6) = CH007            'Palma      Dr. Mad Cave        30 MST
        chest(7) = CH008            'Palma      Dr. Mad Cave        20 MST
        chest(8) = CH009            'Palma      Medusa Tower        Empty (L0)
        chest(9) = CH010            'Palma      Medusa Tower        Burger (L0, E)
        chest(10) = CH011           'Palma      Medusa Tower        10 MST (L0)
        chest(11) = CH012           'Palma      Medusa Tower        Burger, Basement, South
        chest(12) = dummy
        chest(13) = CH014           'Palma      Medusa Tower        Escaper (L0)
        chest(14) = CH015           'Palma      Medusa Tower        Flash (L0)
        chest(15) = CH016           'Palma      Medusa Tower        20 MST
        chest(16) = CH017           'Palma      Medusa Tower        Cola (L1) 
        chest(17) = dummy
        chest(18) = CH019           'Palma      Mesusa Tower        Empty (L1)
        chest(19) = dummy
        chest(20) = dummy
        chest(21) = dummy
        chest(22) = dummy
        chest(23) = dummy
        chest(24) = dummy
        chest(25) = dummy
        chest(26) = dummy
        chest(27) = dummy
        chest(28) = dummy
        chest(29) = dummy
        chest(30) = dummy
        chest(31) = dummy
        chest(32) = dummy
        chest(33) = dummy
        chest(34) = dummy
        chest(35) = dummy
        chest(36) = dummy
        chest(37) = dummy
        chest(38) = dummy
        chest(39) = dummy
        chest(40) = dummy
        chest(41) = dummy
        chest(42) = dummy
        chest(43) = dummy
        chest(44) = dummy
        chest(45) = dummy
        chest(46) = dummy
        chest(47) = dummy
        chest(48) = dummy
        chest(49) = dummy
        chest(50) = dummy
        chest(51) = dummy
        chest(52) = dummy
        chest(53) = dummy
        chest(54) = dummy
        chest(55) = dummy
        chest(56) = dummy
        chest(57) = dummy
        chest(58) = dummy
        chest(59) = dummy
        chest(60) = dummy
        chest(61) = dummy
        chest(62) = dummy

        chest(62) = CH063           'Palma      Scion Cave      Cola (Level 4)
        chest(63) = CH064           'Palma      Scion Cave      Empty (Level 4)
        chest(64) = CH065           'Palma      Naula Cave      Flash
        chest(65) = CH066           'Palma      Scion Cave      Flash (Level 4)
        chest(66) = CH067           'Palma      Scion Cave      Burger (Level 4)
        chest(67) = CH068           'Palma      Naula Cave      10 MST
        chest(68) = CH069           'Palma      Scion Cave      50 MST
        chest(69) = CH070           'Palma      Scion Cave      20 MST (level 4, near stairs)
        chest(70) = CH071           'Palma      Scion Cave      20 MST (level 3, behind door)

        'chest(71) = CH72
        chest(71) = dummy

        chest(72) = CH073           'Palma      Scion Cave      Empty (level 2, between traps)
        chest(73) = CH074           'Palma      Scion Cave      Cola (level 2)

        'chest(74) = CH75
        chest(74) = dummy

        chest(75) = CH076           'Palma      Naula Cave      Short Sword
        chest(76) = CH077           'Palma      Scion Cave      20 MST (level 2)
        chest(77) = CH078           'Palma      Scion Cave      Empty (Level 2, near stairs)
        chest(78) = CH079           'Palma      Scion Cave      Cola (Level 1)
        chest(79) = CH080           'Palma      Scion Cave      20 MST (Level 1)
        chest(80) = CH081           'Palma      Scion Cave      Empty (Level 1, near stairs)
        chest(81) = CH082           'Palma      Scion Cave      Empty (Level 1, near entrance)

        'chest(82) = CH83
        chest(82) = dummy

        chest(83) = CH084           'Palma      Abion Island    100 MST
        chest(84) = CH085           'Palma      Abion Island    Empty
        chest(85) = CH086           'Palma      Abion Island    Flash
        chest(86) = CH087           'Palma      Abion Island    Escaper
        chest(87) = CH088           'Palma      Island Tower    20 MST (Level 1)

        chest(88) = dummy

        chest(89) = CH090           'Palma      Island Tower    Empty (Level 2)
        chest(90) = CH091           'Palma      Island Tower    Burger (Level 3 - East Side)
        chest(91) = CH092           'Palma      Island Tower    Trap (Level 3 - East Side)
        chest(92) = CH093           'Palma      Island Tower    100 MST (Level 3)
        chest(93) = CH094           'Palma      Island Tower    1 MST (Level 3)
        chest(94) = CH095           'Palma      Island Tower    Burger (Level 3 - West side)
        chest(95) = CH096           'Palma      Island Tower    Empty (Level 3 - West side)
        chest(96) = CH097           'Palma      Island Tower    Trap (Level 4)
        chest(97) = CH098           'Palma      Island Tower    20 MST (Level 4)
        chest(98) = CH099           'Palma      Island Tower    Burger (Level 4)
        chest(99) = CH100           'Palma      Island Tower    Empty (Level 4)
        chest(100) = CH101          'Palma      Island Tower    Burger (Level 5)
        chest(101) = CH102          'Motavia    Noah Cave       2000 MST
        chest(102) = CH103          'Motavia    Noah Cave       Flash (Level 2 - NW Corner)
        chest(103) = CH104          'Motavia    Noah Cave       Burger (Level 2 - SW Corner)
        chest(104) = CH105          'Motavia    Noah Cave       Burger (Level 2 - S)
        chest(105) = CH106          'Motavia    Noah Cave       Flash (Level 2 - N)
        chest(106) = CH107          'Motavia    Noah Cave       50 MST
        chest(107) = CH108          'Motavia    Noah Cave       Cola (Level 1)
        chest(108) = CH109          'Motavia    Noah Cave       20 MST
        chest(109) = CH110          'Motavia    Tajima Cave     500 MST (Level 3 - NW Corner)
        chest(110) = CH111          'Motavia    Tajima Cave     Empty (Level 3, E)
        chest(111) = CH112          'Motavia    Tajima Cave     Empty (Level 3, W)
        chest(112) = CH113          'Motavia    Tajima Cave     Titan Sword
        chest(113) = CH114          'Motavia    Tajima Cave     Empty (Level 3, SE Corner)
        chest(114) = CH115          'Motavia    Tajima Cave     500 MST (Level 3 - South)
        chest(115) = CH116          'Motavia    Tajima Cave     Flash (Level 2)
        chest(116) = CH117          'Motavia    Tajima Cave     Empty (Level 2)
        chest(117) = CH118          'Motavia    Tajima Cave     Burger (Level 2)
        chest(118) = CH119          'Motavia    Tajima Cave     3000 MST
        chest(119) = CH120          'Motavia    Tajima Cave     White Mantle
        chest(120) = CH121          'Motavia    Tajima Cave     Wood Cane
        chest(121) = CH122          'Motavia    Tajima Cave     Cola
        chest(122) = CH123          'Motavia    Casba Cave      100 MST (West)
        chest(123) = CH124          'Motavia    Casba Cave      Empty
        chest(124) = CH125          'Motavia    Casba Cave      100 MST (East)

        chest(125) = dummy
        chest(126) = dummy

        chest(127) = CH128          'Dezolis    Skure           500 MST

        'Re-call the function to visually check the box if the flag is active.
        chest(checkBoxNum).Checked = isItChecked

    End Sub

    Private Sub btnInventoryDelete_Click(sender As Object, e As EventArgs) Handles btnInventoryDelete.Click
        lstInventory.Items.Remove(lstInventory.SelectedItem)

        'Disable Delete button if inventory is empty
        If lstInventory.Items.Count <= 0 Then
            btnInventoryDelete.Enabled = False
        End If

        'Re-enable the add button if the inventory is not maxed out.
        If lstInventory.Items.Count < 32 Then
            btnInventoryAdd.Enabled = True
        End If
    End Sub

    Private Sub btnInventoryAdd_Click(sender As Object, e As EventArgs) Handles btnInventoryAdd.Click
        lstInventory.Items.Add(Items.Name(cmbItems.SelectedIndex + 1)) 'Offset the 0 base

        'Disable Add button if the inventory is maxed out.
        If lstInventory.Items.Count >= 32 Then
            btnInventoryAdd.Enabled = False
        End If
    End Sub

End Class
