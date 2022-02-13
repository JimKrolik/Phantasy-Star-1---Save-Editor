﻿Imports Microsoft.VisualBasic

Public Class Game

    Public Shared MesetaOffset As Integer() = {1504, 0, 0, 0, 0}
    Public Shared TransferRecallOffset As Integer() = {1047, 0, 0, 0, 0}
    Public Shared ChestOffset As Integer() = {1792, 0, 0, 0, 0}             'block ends, presumably at 1983 for save 1

    Public Shared RecallLocation() As String = {
        "Alis House",   '00
        "Camineet",
        "Gothic",
        "Loar",
        "Paseo",
        "Uzo",
        "Casba",
        "Twin Town",
        "Skure"
    }

    Public Shared LocationActiveDungeon() As String = {
        }

    Public Shared LocationDungeonDirection() As String = {
        }

    Public Shared DungeonName() As String = {
        "Medusa Cave, Gothic Tunnel, Baya Malay Passage",
        "Triada Prison",
        "Camineet",
        "Abion Warehouse",
        "Medusa Tower Basement",
        "Medusa Tower 1st Floor",
        "Medusa Tower 2nd Floor",
        "Medusa Tower 3rd Floor",
        "Medusa Tower 4th Floor",
        "Medusa Tower 5th Floor",
        "Baya Malay Tower Basement 3",
        "Medusa Tower 6th Floor",
        "Baya Malay Tower Basement 2",
        "Medusa Tower 7th Floor",
        "Baya Malay Tower Basement",
        "Baya Malay Tower 1st Floor",
        "Baya Malay Tower 2nd Floor",
        "Baya Malay Tower 3rd Floor",
        "Baya Malay Tower 4th Floor",
        "Baya Malay Tower 5th Floor"
    }

    Public Shared DungeonLayout() As String = {
        "11111111111111111111A000010111A1111111110101110110000081010111011011111100011101101800010101C0011010110101A111011010000001118101101111111111010110000000000001011011011111010101101100001101010110000110000101011011000011010101100811118001A1A11111111111111111",
        "1111111111111111111111181111111111111110111111111111D1151111111111110110111111111100000000050811110110111011111111511D111D1111111101111D1111D11111000110111101111101000000000111118110111011111111011D1115111111110111111011111111C11111181111111111111111111111",
        "11111111111111111A00001800000001111110111111010111111011118101011000000050010101101110111111010110181018040001A1151010111111111110100000500001111010111111110001100000000001110111111111110111011000005000010001101111111111010110000000000001A11111111111111111",
        " ",
        "1111111111111111100811111111181110111111111110111011121000000011100110101101101111011010118112111100001011011111100111000101111111011101000000111100000101111011110111110100001110000000001101111011101010113111101110101D1111111000811C111111111111111111111111"
    }

    Public Shared Sub checkChests(checkBoxNum As Integer, isItChecked As Boolean)
        'Map our checkboxes into an array 
        Dim chest(200) As CheckBox


        chest(0) = frmChests.CH001            'Palma      Camineet            Compass
        chest(1) = frmChests.CH002            'Palma      Medusa Cave         --need to check    
        chest(2) = frmChests.CH003            'Palma      Medusa Cave         --need to check
        chest(3) = frmChests.CH004            'Palma      Dr. Luveno Cave     Empty
        chest(4) = frmChests.CH005            'Palma      Camineet            Dungeon Key
        chest(5) = frmChests.CH006            'Palma      Camineet            50 MST
        chest(6) = frmChests.CH007            'Palma      Dr. Mad Cave        30 MST
        chest(7) = frmChests.CH008            'Palma      Dr. Mad Cave        20 MST
        chest(8) = frmChests.CH009            'Palma      Medusa Tower        Empty (L0)
        chest(9) = frmChests.CH010            'Palma      Medusa Tower        Burger (L0, E)
        chest(10) = frmChests.CH011           'Palma      Medusa Tower        10 MST (L0)
        chest(11) = frmChests.CH012           'Palma      Medusa Tower        Burger, Basement, South
        chest(12) = frmChests.dummy
        chest(13) = frmChests.CH014           'Palma      Medusa Tower        Escaper (L0)
        chest(14) = frmChests.CH015           'Palma      Medusa Tower        Flash (L0)
        chest(15) = frmChests.CH016           'Palma      Medusa Tower        20 MST
        chest(16) = frmChests.CH017           'Palma      Medusa Tower        Cola (L1) 
        chest(17) = frmChests.dummy
        chest(18) = frmChests.CH019           'Palma      Mesusa Tower        Empty (L1)
        chest(19) = frmChests.CH020           'Palma      Medusa Tower        10 MST (L2)
        chest(20) = frmChests.CH021           'Palma      Medusa Tower        5 MST (L2)
        chest(21) = frmChests.dummy
        chest(22) = frmChests.CH023           'Palma      Medusa Tower        Burger (L2)
        chest(23) = frmChests.dummy
        chest(24) = frmChests.dummy
        chest(25) = frmChests.CH026           'Palma      Medusa Tower        35 MST (L3)
        chest(26) = frmChests.dummy
        chest(27) = frmChests.dummy
        chest(28) = frmChests.dummy
        chest(29) = frmChests.dummy
        chest(30) = frmChests.dummy
        chest(31) = frmChests.dummy
        chest(32) = frmChests.dummy
        chest(33) = frmChests.dummy
        chest(34) = frmChests.dummy
        chest(35) = frmChests.dummy
        chest(36) = frmChests.dummy
        chest(37) = frmChests.dummy
        chest(38) = frmChests.dummy
        chest(39) = frmChests.dummy
        chest(40) = frmChests.dummy
        chest(41) = frmChests.dummy
        chest(42) = frmChests.dummy
        chest(43) = frmChests.dummy
        chest(44) = frmChests.dummy
        chest(45) = frmChests.dummy
        chest(46) = frmChests.dummy
        chest(47) = frmChests.dummy
        chest(48) = frmChests.dummy
        chest(49) = frmChests.dummy
        chest(50) = frmChests.dummy
        chest(51) = frmChests.dummy
        chest(52) = frmChests.dummy
        chest(53) = frmChests.dummy
        chest(54) = frmChests.dummy
        chest(55) = frmChests.dummy
        chest(56) = frmChests.dummy
        chest(57) = frmChests.dummy
        chest(58) = frmChests.dummy
        chest(59) = frmChests.dummy
        chest(60) = frmChests.dummy
        chest(61) = frmChests.dummy
        chest(62) = frmChests.dummy

        chest(62) = frmChests.CH063           'Palma      Scion Cave      Cola (Level 4)
        chest(63) = frmChests.CH064           'Palma      Scion Cave      Empty (Level 4)
        chest(64) = frmChests.CH065           'Palma      Naula Cave      Flash
        chest(65) = frmChests.CH066           'Palma      Scion Cave      Flash (Level 4)
        chest(66) = frmChests.CH067           'Palma      Scion Cave      Burger (Level 4)
        chest(67) = frmChests.CH068           'Palma      Naula Cave      10 MST
        chest(68) = frmChests.CH069           'Palma      Scion Cave      50 MST
        chest(69) = frmChests.CH070           'Palma      Scion Cave      20 MST (level 4, near stairs)
        chest(70) = frmChests.CH071           'Palma      Scion Cave      20 MST (level 3, behind door)

        'chest(71) = CH72
        chest(71) = frmChests.dummy

        chest(72) = frmChests.CH073           'Palma      Scion Cave      Empty (level 2, between traps)
        chest(73) = frmChests.CH074           'Palma      Scion Cave      Cola (level 2)

        'chest(74) = CH75
        chest(74) = frmChests.dummy

        chest(75) = frmChests.CH076           'Palma      Naula Cave      Short Sword
        chest(76) = frmChests.CH077           'Palma      Scion Cave      20 MST (level 2)
        chest(77) = frmChests.CH078           'Palma      Scion Cave      Empty (Level 2, near stairs)
        chest(78) = frmChests.CH079           'Palma      Scion Cave      Cola (Level 1)
        chest(79) = frmChests.CH080           'Palma      Scion Cave      20 MST (Level 1)
        chest(80) = frmChests.CH081           'Palma      Scion Cave      Empty (Level 1, near stairs)
        chest(81) = frmChests.CH082           'Palma      Scion Cave      Empty (Level 1, near entrance)

        'chest(82) = CH83
        chest(82) = frmChests.dummy

        chest(83) = frmChests.CH084           'Palma      Abion Island    100 MST
        chest(84) = frmChests.CH085           'Palma      Abion Island    Empty
        chest(85) = frmChests.CH086           'Palma      Abion Island    Flash
        chest(86) = frmChests.CH087           'Palma      Abion Island    Escaper
        chest(87) = frmChests.CH088           'Palma      Island Tower    20 MST (Level 1)

        chest(88) = frmChests.dummy

        chest(89) = frmChests.CH090           'Palma      Island Tower    Empty (Level 2)
        chest(90) = frmChests.CH091           'Palma      Island Tower    Burger (Level 3 - East Side)
        chest(91) = frmChests.CH092           'Palma      Island Tower    Trap (Level 3 - East Side)
        chest(92) = frmChests.CH093           'Palma      Island Tower    100 MST (Level 3)
        chest(93) = frmChests.CH094           'Palma      Island Tower    1 MST (Level 3)
        chest(94) = frmChests.CH095           'Palma      Island Tower    Burger (Level 3 - West side)
        chest(95) = frmChests.CH096           'Palma      Island Tower    Empty (Level 3 - West side)
        chest(96) = frmChests.CH097           'Palma      Island Tower    Trap (Level 4)
        chest(97) = frmChests.CH098           'Palma      Island Tower    20 MST (Level 4)
        chest(98) = frmChests.CH099           'Palma      Island Tower    Burger (Level 4)
        chest(99) = frmChests.CH100           'Palma      Island Tower    Empty (Level 4)
        chest(100) = frmChests.CH101          'Palma      Island Tower    Burger (Level 5)
        chest(101) = frmChests.CH102          'Motavia    Noah Cave       2000 MST
        chest(102) = frmChests.CH103          'Motavia    Noah Cave       Flash (Level 2 - NW Corner)
        chest(103) = frmChests.CH104          'Motavia    Noah Cave       Burger (Level 2 - SW Corner)
        chest(104) = frmChests.CH105          'Motavia    Noah Cave       Burger (Level 2 - S)
        chest(105) = frmChests.CH106          'Motavia    Noah Cave       Flash (Level 2 - N)
        chest(106) = frmChests.CH107          'Motavia    Noah Cave       50 MST
        chest(107) = frmChests.CH108          'Motavia    Noah Cave       Cola (Level 1)
        chest(108) = frmChests.CH109          'Motavia    Noah Cave       20 MST
        chest(109) = frmChests.CH110          'Motavia    Tajima Cave     500 MST (Level 3 - NW Corner)
        chest(110) = frmChests.CH111          'Motavia    Tajima Cave     Empty (Level 3, E)
        chest(111) = frmChests.CH112          'Motavia    Tajima Cave     Empty (Level 3, W)
        chest(112) = frmChests.CH113          'Motavia    Tajima Cave     Titan Sword
        chest(113) = frmChests.CH114          'Motavia    Tajima Cave     Empty (Level 3, SE Corner)
        chest(114) = frmChests.CH115          'Motavia    Tajima Cave     500 MST (Level 3 - South)
        chest(115) = frmChests.CH116          'Motavia    Tajima Cave     Flash (Level 2)
        chest(116) = frmChests.CH117          'Motavia    Tajima Cave     Empty (Level 2)
        chest(117) = frmChests.CH118          'Motavia    Tajima Cave     Burger (Level 2)
        chest(118) = frmChests.CH119          'Motavia    Tajima Cave     3000 MST
        chest(119) = frmChests.CH120          'Motavia    Tajima Cave     White Mantle
        chest(120) = frmChests.CH121          'Motavia    Tajima Cave     Wood Cane
        chest(121) = frmChests.CH122          'Motavia    Tajima Cave     Cola
        chest(122) = frmChests.CH123          'Motavia    Casba Cave      100 MST (West)
        chest(123) = frmChests.CH124          'Motavia    Casba Cave      Empty
        chest(124) = frmChests.CH125          'Motavia    Casba Cave      100 MST (East)

        chest(125) = frmChests.dummy
        chest(126) = frmChests.dummy

        chest(127) = frmChests.CH128          'Dezolis    Skure           500 MST

        'Re-call the function to visually check the box if the flag is active.
        chest(checkBoxNum).Checked = isItChecked

    End Sub

    Public Shared Sub loadDungeonLayout(position As Integer, type As Char)

        If (type = "0") Then 'Empty Space
            frmSave.dungeonMap(position).BackColor = Color.White

        ElseIf (type = "1") Then 'Wall
            frmSave.dungeonMap(position).BackColor = Color.Black
            frmSave.dungeonMap(position).Enabled = False

        ElseIf (type = "2") Then 'Floor Up
            frmSave.dungeonMap(position).BackColor = Color.Lime

        ElseIf (type = "3") Then 'Floor Down
            frmSave.dungeonMap(position).BackColor = Color.Green

        ElseIf (type = "4") Then 'Regular Door
            frmSave.dungeonMap(position).BackColor = Color.Yellow
        End If

    End Sub

End Class
