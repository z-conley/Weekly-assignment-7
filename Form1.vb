' Program name: Karaoke Music night
' Name: Zachary Conley
' Date: 4/4/2023
' Purpose: This app is used to find the prices for a karaoke music night

Option Strict On

Public Class Frmkaraoke

    Private _decsong As Decimal = 2.99D
    Private _decHourlyrate As Decimal = 8.99D
    Private Sub Frmkaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When loading the form, the splash screen stays up for 6 seconds
        Threading.Thread.Sleep(3000)
        ClearForm()

    End Sub


    Private Function InputValidate() As Boolean
        ' This function is used for the msgboxes which display error messages for when the user inputs incorrect options
        Dim Number As Integer
        Dim blnValid As Boolean = False
        Try
            Number = Convert.ToInt32(Txthours.Text)
            If Number > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number that is greater than zero", , "Error")
            End If
        Catch exception As FormatException
            MsgBox("Please enter an amount that is valid", , "Error")
        Catch exception As OverflowException
            MsgBox("Please enter a reasonable amount of hours", , "Error")
        Catch excerption As SystemException
            MsgBox("Entry is invalid, please enter a valid number", , "Error")

        End Try
        Txthours.Focus()
        Txthours.Clear()
        Return blnValid

    End Function

    Private Function Roomcost(ByVal intpass As Integer) As Decimal
        ' This function serves as the multiplication of the hourly rate for the number inputed by the user
        Dim decTicket As Decimal
        decTicket = intpass * _decHourlyrate
        Return decTicket

    End Function

    Private Function Songcost(ByVal intpass As Integer) As Decimal
        ' this used the song rate and multiplies it by the users input
        Dim decSong As Decimal
        decSong = intpass * _decsong
        Return decSong

    End Function

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        ClearForm()

    End Sub


    Private Sub ClearForm()
        ' The clearform event takes everything off of the screen, clears the choice box and then inputs select an option: back in
        Lblcostdisplay.Visible = False
        Txthours.Visible = False
        Btntotal.Visible = False
        Btnclear.Visible = False
        Lblhourly.Visible = False
        Txthours.Clear()
        CboChoices.SelectedIndex = -1
        CboChoices.Text = "Select an option:"

    End Sub

    Private Sub Btntotal_Click(sender As Object, e As EventArgs) Handles Btntotal.Click
        'This is the conversion for the button total click event which takes the songcost and roomcost depending on the user choice
        Dim blnAmountvalid As Boolean = False
        Dim intvalue As Integer
        Dim decTot As Decimal

        blnAmountvalid = InputValidate()
        If blnAmountvalid = True Then
            intvalue = Convert.ToInt32(Txthours.Text)
            If CboChoices.SelectedIndex = 0 Then
                decTot = Songcost(intvalue)
            Else
                decTot = Roomcost(intvalue)
            End If

            Lblcostdisplay.Visible = True
            Lblcostdisplay.Text = "Total cost of karaoke night - " & decTot.ToString("C")

        End If
    End Sub

    Private Sub CboChoices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboChoices.SelectedIndexChanged
        If CboChoices.SelectedIndex = 0 Then
            Lblhourly.Text = "Number of karaoke songs:"
            Lblhourly.Visible = True
            Txthours.Visible = True
            Btntotal.Visible = True
            Btnclear.Visible = True
            Txthours.Focus()

        End If
        If CboChoices.SelectedIndex = 1 Then
            Lblhourly.Text = "Hourly rental of karaoke room:"
            Lblhourly.Visible = True
            Txthours.Visible = True
            Btnclear.Visible = True
            Btntotal.Visible = True
            Txthours.Focus()

        End If
    End Sub
End Class
