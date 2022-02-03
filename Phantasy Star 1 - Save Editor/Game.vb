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

    Public Shared Dungeon() As String = {
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

End Class
