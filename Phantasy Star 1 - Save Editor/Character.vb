Imports Microsoft.VisualBasic

Public Class Character

    'These will be the offsets based on the save in an array.

    Public Shared Alis As Integer() = {1280, 0, 0, 0, 0}     'Alis starts at offset 1280 for Save 1
    Public Shared Myau As Integer() = {1296, 0, 0, 0, 0}     'Myau starts at offset 1280 for Save 1
    Public Shared Odin As Integer() = {1312, 0, 0, 0, 0}     'Odin starts at offset 1280 for Save 1
    Public Shared Noah As Integer() = {1328, 0, 0, 0, 0}     'Noah starts at offset 1280 for Save 1

    Public Const ActiveInParty As Integer = 0                          'The first hex character is active in party status.
    Public Const CurrentHP As Integer = 1                              'So forth and so on.
    Public Const CurrentTP As Integer = 2
    Public Const ExpLow As Integer = 3
    Public Const ExpHigh As Integer = 4
    Public Const Level As Integer = 5
    Public Const MaxHP As Integer = 6
    Public Const MaxTP As Integer = 7
    Public Const Attack As Integer = 8
    Public Const Defense As Integer = 9
    Public Const Weapon As Integer = 10
    Public Const Armor As Integer = 11
    Public Const Shield As Integer = 12

End Class
