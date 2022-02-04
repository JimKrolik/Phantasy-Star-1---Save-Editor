Imports Microsoft.VisualBasic

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

        chest(0) = Form1.CH001            'Palma      Camineet            Compass
        chest(1) = Form1.CH002            'Palma      Medusa Cave         --need to check    
        chest(2) = Form1.CH003            'Palma      Medusa Cave         --need to check
        chest(3) = Form1.CH004            'Palma      Dr. Luveno Cave     Empty
        chest(4) = Form1.CH005            'Palma      Camineet            Dungeon Key
        chest(5) = Form1.CH006            'Palma      Camineet            50 MST
        chest(6) = Form1.CH007            'Palma      Dr. Mad Cave        30 MST
        chest(7) = Form1.CH008            'Palma      Dr. Mad Cave        20 MST
        chest(8) = Form1.CH009            'Palma      Medusa Tower        Empty (L0)
        chest(9) = Form1.CH010            'Palma      Medusa Tower        Burger (L0, E)
        chest(10) = Form1.CH011           'Palma      Medusa Tower        10 MST (L0)
        chest(11) = Form1.CH012           'Palma      Medusa Tower        Burger, Basement, South
        chest(12) = Form1.dummy
        chest(13) = Form1.CH014           'Palma      Medusa Tower        Escaper (L0)
        chest(14) = Form1.CH015           'Palma      Medusa Tower        Flash (L0)
        chest(15) = Form1.CH016           'Palma      Medusa Tower        20 MST
        chest(16) = Form1.CH017           'Palma      Medusa Tower        Cola (L1) 
        chest(17) = Form1.dummy
        chest(18) = Form1.CH019           'Palma      Mesusa Tower        Empty (L1)
        chest(19) = Form1.CH020           'Palma      Medusa Tower        10 MST (L2)
        chest(20) = Form1.CH021           'Palma      Medusa Tower        5 MST (L2)
        chest(21) = Form1.dummy
        chest(22) = Form1.dummy
        chest(23) = Form1.dummy
        chest(24) = Form1.dummy
        chest(25) = Form1.CH026           'Palma      Medusa Tower        35 MST (L3)
        chest(26) = Form1.dummy
        chest(27) = Form1.dummy
        chest(28) = Form1.dummy
        chest(29) = Form1.dummy
        chest(30) = Form1.dummy
        chest(31) = Form1.dummy
        chest(32) = Form1.dummy
        chest(33) = Form1.dummy
        chest(34) = Form1.dummy
        chest(35) = Form1.dummy
        chest(36) = Form1.dummy
        chest(37) = Form1.dummy
        chest(38) = Form1.dummy
        chest(39) = Form1.dummy
        chest(40) = Form1.dummy
        chest(41) = Form1.dummy
        chest(42) = Form1.dummy
        chest(43) = Form1.dummy
        chest(44) = Form1.dummy
        chest(45) = Form1.dummy
        chest(46) = Form1.dummy
        chest(47) = Form1.dummy
        chest(48) = Form1.dummy
        chest(49) = Form1.dummy
        chest(50) = Form1.dummy
        chest(51) = Form1.dummy
        chest(52) = Form1.dummy
        chest(53) = Form1.dummy
        chest(54) = Form1.dummy
        chest(55) = Form1.dummy
        chest(56) = Form1.dummy
        chest(57) = Form1.dummy
        chest(58) = Form1.dummy
        chest(59) = Form1.dummy
        chest(60) = Form1.dummy
        chest(61) = Form1.dummy
        chest(62) = Form1.dummy

        chest(62) = Form1.CH063           'Palma      Scion Cave      Cola (Level 4)
        chest(63) = Form1.CH064           'Palma      Scion Cave      Empty (Level 4)
        chest(64) = Form1.CH065           'Palma      Naula Cave      Flash
        chest(65) = Form1.CH066           'Palma      Scion Cave      Flash (Level 4)
        chest(66) = Form1.CH067           'Palma      Scion Cave      Burger (Level 4)
        chest(67) = Form1.CH068           'Palma      Naula Cave      10 MST
        chest(68) = Form1.CH069           'Palma      Scion Cave      50 MST
        chest(69) = Form1.CH070           'Palma      Scion Cave      20 MST (level 4, near stairs)
        chest(70) = Form1.CH071           'Palma      Scion Cave      20 MST (level 3, behind door)

        'chest(71) = CH72
        chest(71) = Form1.dummy

        chest(72) = Form1.CH073           'Palma      Scion Cave      Empty (level 2, between traps)
        chest(73) = Form1.CH074           'Palma      Scion Cave      Cola (level 2)

        'chest(74) = CH75
        chest(74) = Form1.dummy

        chest(75) = Form1.CH076           'Palma      Naula Cave      Short Sword
        chest(76) = Form1.CH077           'Palma      Scion Cave      20 MST (level 2)
        chest(77) = Form1.CH078           'Palma      Scion Cave      Empty (Level 2, near stairs)
        chest(78) = Form1.CH079           'Palma      Scion Cave      Cola (Level 1)
        chest(79) = Form1.CH080           'Palma      Scion Cave      20 MST (Level 1)
        chest(80) = Form1.CH081           'Palma      Scion Cave      Empty (Level 1, near stairs)
        chest(81) = Form1.CH082           'Palma      Scion Cave      Empty (Level 1, near entrance)

        'chest(82) = CH83
        chest(82) = Form1.dummy

        chest(83) = Form1.CH084           'Palma      Abion Island    100 MST
        chest(84) = Form1.CH085           'Palma      Abion Island    Empty
        chest(85) = Form1.CH086           'Palma      Abion Island    Flash
        chest(86) = Form1.CH087           'Palma      Abion Island    Escaper
        chest(87) = Form1.CH088           'Palma      Island Tower    20 MST (Level 1)

        chest(88) = Form1.dummy

        chest(89) = Form1.CH090           'Palma      Island Tower    Empty (Level 2)
        chest(90) = Form1.CH091           'Palma      Island Tower    Burger (Level 3 - East Side)
        chest(91) = Form1.CH092           'Palma      Island Tower    Trap (Level 3 - East Side)
        chest(92) = Form1.CH093           'Palma      Island Tower    100 MST (Level 3)
        chest(93) = Form1.CH094           'Palma      Island Tower    1 MST (Level 3)
        chest(94) = Form1.CH095           'Palma      Island Tower    Burger (Level 3 - West side)
        chest(95) = Form1.CH096           'Palma      Island Tower    Empty (Level 3 - West side)
        chest(96) = Form1.CH097           'Palma      Island Tower    Trap (Level 4)
        chest(97) = Form1.CH098           'Palma      Island Tower    20 MST (Level 4)
        chest(98) = Form1.CH099           'Palma      Island Tower    Burger (Level 4)
        chest(99) = Form1.CH100           'Palma      Island Tower    Empty (Level 4)
        chest(100) = Form1.CH101          'Palma      Island Tower    Burger (Level 5)
        chest(101) = Form1.CH102          'Motavia    Noah Cave       2000 MST
        chest(102) = Form1.CH103          'Motavia    Noah Cave       Flash (Level 2 - NW Corner)
        chest(103) = Form1.CH104          'Motavia    Noah Cave       Burger (Level 2 - SW Corner)
        chest(104) = Form1.CH105          'Motavia    Noah Cave       Burger (Level 2 - S)
        chest(105) = Form1.CH106          'Motavia    Noah Cave       Flash (Level 2 - N)
        chest(106) = Form1.CH107          'Motavia    Noah Cave       50 MST
        chest(107) = Form1.CH108          'Motavia    Noah Cave       Cola (Level 1)
        chest(108) = Form1.CH109          'Motavia    Noah Cave       20 MST
        chest(109) = Form1.CH110          'Motavia    Tajima Cave     500 MST (Level 3 - NW Corner)
        chest(110) = Form1.CH111          'Motavia    Tajima Cave     Empty (Level 3, E)
        chest(111) = Form1.CH112          'Motavia    Tajima Cave     Empty (Level 3, W)
        chest(112) = Form1.CH113          'Motavia    Tajima Cave     Titan Sword
        chest(113) = Form1.CH114          'Motavia    Tajima Cave     Empty (Level 3, SE Corner)
        chest(114) = Form1.CH115          'Motavia    Tajima Cave     500 MST (Level 3 - South)
        chest(115) = Form1.CH116          'Motavia    Tajima Cave     Flash (Level 2)
        chest(116) = Form1.CH117          'Motavia    Tajima Cave     Empty (Level 2)
        chest(117) = Form1.CH118          'Motavia    Tajima Cave     Burger (Level 2)
        chest(118) = Form1.CH119          'Motavia    Tajima Cave     3000 MST
        chest(119) = Form1.CH120          'Motavia    Tajima Cave     White Mantle
        chest(120) = Form1.CH121          'Motavia    Tajima Cave     Wood Cane
        chest(121) = Form1.CH122          'Motavia    Tajima Cave     Cola
        chest(122) = Form1.CH123          'Motavia    Casba Cave      100 MST (West)
        chest(123) = Form1.CH124          'Motavia    Casba Cave      Empty
        chest(124) = Form1.CH125          'Motavia    Casba Cave      100 MST (East)

        chest(125) = Form1.dummy
        chest(126) = Form1.dummy

        chest(127) = Form1.CH128          'Dezolis    Skure           500 MST

        'Re-call the function to visually check the box if the flag is active.
        chest(checkBoxNum).Checked = isItChecked

    End Sub

    Public Shared Sub loadDungeonLayout(position As Integer, type As Char)
        'Map our checkboxes into an array 
        Dim dungeonPosition(16) As Button

        'Load the buttons into the array and set.
        dungeonPosition(0) = Form1.btnDungeon0
        dungeonPosition(1) = Form1.btnDungeon1
        dungeonPosition(2) = Form1.btnDungeon2
        dungeonPosition(3) = Form1.btnDungeon3
        dungeonPosition(4) = Form1.btnDungeon4
        dungeonPosition(5) = Form1.btnDungeon5
        dungeonPosition(6) = Form1.btnDungeon6
        dungeonPosition(7) = Form1.btnDungeon7
        dungeonPosition(8) = Form1.btnDungeon8
        dungeonPosition(9) = Form1.btnDungeon9
        dungeonPosition(10) = Form1.btnDungeon10
        dungeonPosition(11) = Form1.btnDungeon11
        dungeonPosition(12) = Form1.btnDungeon12
        dungeonPosition(13) = Form1.btnDungeon13
        dungeonPosition(14) = Form1.btnDungeon14
        dungeonPosition(15) = Form1.btnDungeon15
        dungeonPosition(16) = Form1.btnDungeon16

        If (type = "0") Then 'Empty Space
            dungeonPosition(position).BackColor = Color.White
        ElseIf (type = "1") Then 'Wall
            dungeonPosition(position).BackColor = Color.Black
        ElseIf (type = "2") Then 'Floor Up

        ElseIf (type = "3") Then 'Floor Down

        ElseIf (type = "4") Then 'Regular Door

        End If

    End Sub

End Class
