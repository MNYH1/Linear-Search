Public Class Form1
    Const MAXINDEX As Integer = 10
    Dim numbers(MAXINDEX) As Integer

    Dim itemCount As Integer = 0

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        Randomize()

        Dim i As Integer

        'clear display box
        lstDisplay.Items.Clear()

        'Dim letter As String = ""
        'Dim rand As New Random
        'For i = 0 To MAXINDEX
        '    letter = letter & ChrW(rand.Next(Asc("A"), Asc("Z") + 1))
        'Next

        'lstDisplay.Items.Add(letter)


        For i = 0 To MAXINDEX 'loop 20 times
            numbers(i) = CInt(500 * Rnd() + 1) 'pick a random number and store it in an array
            lstDisplay.Items.Add(numbers(i)) 'display the random number in the list box
            itemCount += 1
        Next 'increment value of loops
        btnGen.Enabled = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lstDisplay.Items.Clear()
        itemCount = 0
        btnGen.Enabled = True

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End

    End Sub

    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click
        Dim itemToFind As Integer
        'Dim numComparison As Integer   'used for my search
        Dim subFindIndex As Integer

        itemToFind = CInt(InputBox("What do you want to look for?", "Search"))

        'calls linear search function
        'subFindIndex = linearSearch(itemToFind, numComparison) '***used for my search to locate the number of comparisons
        subFindIndex = linearSearch(itemToFind)

        If subFindIndex > -1 Then
            MsgBox(itemToFind & " was found at position " & subFindIndex)   'for Jansons Search
            'MsgBox(itemToFind & " was found at position " & subFindIndex & " using " & numComparison & " comparisons", , "Found")    'For my search
        Else
            MsgBox(itemToFind & " was not found in the list", , "Not Found")
        End If
    End Sub
#Region "linear search function"
    'Function LinearSearch(ByVal item As Integer, ByRef numComparison As Integer) As Integer    '***used for my search number of comparisons
    '    Dim i As Integer
    '    Dim max As Integer
    '    Dim subFindItemIndex As Integer

    '    i = 0
    '    max = itemCount - 1 'initialize max to number of items in the array
    '    subFindItemIndex = -1   'initialize item to not found
    '    numComparison = 0   'initialize number of comparisons

    '    While i <= max And subFindItemIndex = -1
    '        numComparison += 1
    '        If numbers(i) = item Then
    '            subFindItemIndex = i    'set subFindIndex to index of found element
    '        End If
    '        i += 1
    '    End While

    '    Return subFindItemIndex

    'End Function
#End Region

    Function linearSearch(ByVal item As Integer) As Integer
        Dim i As Integer = 0
        Dim max As Integer
        Dim subFindItemIndex As Integer

        max = itemCount - 1
        subFindItemIndex = -1

        While i <= max And subFindItemIndex = -1
            If numbers(i) = item Then
                subFindItemIndex = i
            End If
            i += 1
        End While
        Return subFindItemIndex
    End Function
End Class
