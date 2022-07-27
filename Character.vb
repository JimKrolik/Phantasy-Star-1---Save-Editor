Imports Microsoft.VisualBasic

Public Class Character

    Public Shared Rolf As Integer() = {0, 0, 0, 0}  'Rolf Save 1 starts at 0
    Public Shared Nei As Intger() = {128, 0, 0, 0}
    Public Shared Rudo As Integer() = {256, 0, 0, 0}
    Public Shared Amy As Integer() = {384, 0, 0, 0}


    'unknown 01, 03  Maybe job?

    Public Const CurrentHPHigh As Integer = 5
    Public Const CurrentHPLow As Integer = 7
    Public Const MaxHPHigh As Integer = 9
    Public Const MaxHPLow As Integer = 11
    Public Const CurrentTPHigh As Integer = 13
    Public Const CurrentTPLow As Integer = 15
    Public Const MaxTPHigh As Integer = 17
    Public Const MaxTPLow As Integer = 19

    Public Const Level As Integer = 23

    Public Const EXP4 As Integer = 25
    Public Const EXP3 As Integer = 27
    Public Const EXP256 As Integer = 29
    Public Const EXP1 As Integer = 31

    Public Const StrengthHigh As Integer = 33
    Public Const StrengthLow As Integer = 35

    Public Const MentalHigh As Integer = 37
    Public Const MentalLow As Integer = 39

    Public Const AgilityHigh As Integer = 41
    Public Const AgilityLow As Integer = 43

    Public Const LuckHigh As Integer = 45
    Public Const LuckLow As Integer = 47

    Public Const DexterityHigh As Integer = 49
    Public Const DexterityLow As Integer = 51

    Public Const UnknownHigh As Integer = 53
    Public Const UnknownLow As Integer = 55

    Public Const AttackHigh As Integer = 57
    Public Const AttackLow As Integer = 59

    Public Const DefenseHigh As Integer = 61
    Public Const DefenseLow As Integer = 63

    Public Const unknown3 As Integer = 65

    Public Const LeftHand As Integer = 67
    Public Const RightHand As Integer = 69
    Public Const Body As Integer = 71
    Public Const Legs As Integer = 73

    Public Const Unknown4 As Integer = 75
    Public Const unknown5 As Integer = 77

    Public Const ItemCount As Integer = 79

    Public Const ItemStart As Integer = 81         'Item value + 80 means equipped, Start of inventory Offset, 16 total.
    Public Const ItemEnd As Integer = 95


    Public Const ExpLow As Integer = 0



End Class
