Imports System.Text.RegularExpressions

Public Class Form1

#Region "EventHandler"

    'click event to call CheckCall()
    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        CheckCall()
    End Sub

    'KeyDown event to call CheckCall()
    Private Sub TextBoxCallsign_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxCallsign.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            CheckCall()
        End If
    End Sub

    'Sub to check/format the callsign and call getPass()
    Private Sub CheckCall()
        Dim callsign As String()
        'check if it is a valid callsign, ignore case
        If (Regex.IsMatch(TextBoxCallsign.Text, "^[a-z]+\d[a-z]+(?([-])[-][0-9]+$|$)", RegexOptions.IgnoreCase)) Then
            'splitt the callsign at -
            callsign = TextBoxCallsign.Text.Split("-")
            'only lowercases are allowed
            callsign(0) = callsign(0).ToUpper
            getPass(callsign(0))
        Else
            MsgBox("Invalid Callsign, Try Again!", MsgBoxStyle.Information, "Info")
        End If
    End Sub

#End Region


#Region "Private"

    'Function to generate the passcode
    Private Sub getPass(f_call As String)
        Dim i As Integer = 0
        Dim passcode As Integer = 29666
        While (i + 1 < f_call.Length)
            'passcode xor asscinumber * 2^8
            passcode = passcode Xor Asc(f_call(i)) * 2 ^ 8
            'passcode xor ascinummber
            passcode = passcode Xor Asc(f_call(i + 1))
            i += 2
        End While
        passcode = passcode And 32767
        TextBoxPasscode.Text = passcode
    End Sub

    'Sub to open the about website with the default browser
    Private Sub LinkLabelWeb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelWeb.LinkClicked
        Process.Start("https://github.com/DO3SWW/Aprs-Passcode")
    End Sub

#End Region

End Class
