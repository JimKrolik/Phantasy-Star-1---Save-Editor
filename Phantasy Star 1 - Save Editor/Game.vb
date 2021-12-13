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

End Class
