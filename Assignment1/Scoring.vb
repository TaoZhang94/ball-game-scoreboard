Public Class Scoring

    'These are the names for team#1
    Public teamName_1 As String
    Public member_1 As String
    Public member_2 As String
    Public member_3 As String
    Public member_4 As String
    Public member_5 As String

    'These are the names for team#2
    Public teamName_2 As String
    Public member_6 As String
    Public member_7 As String
    Public member_8 As String
    Public member_9 As String
    Public member_10 As String

    'Initial bonus, round, team#1 and team#`s score
    Public round = 0
    Public score_1 = 0
    Public score_2 = 0
    Public bonus = 0

    'This Boolean variable is to determine which team is playing
    Public group1Playing = True

    'Private variable for adding the score
    Dim temp = 0

    'Clear the bonus marks and show on the display window
    Private Sub clearBonus()

        bonus = 0

        lbBonus.Text = "Bonus" + bonus.ToString     'lbBonus is the label that shows the current bonus mark on Scoring window

        'This loop is here to determine which team is playing change the bonus marks
        If group1Playing = True Then

            Display.lbBonus1.Text = bonus.ToString          'Change the label of team#1`s bonus on Display

        Else

            Display.lbBonus2.Text = bonus.ToString          'Change the label of team#2`s bonus on Display

        End If

    End Sub

    'Show the correct bonus window on Display
    Private Sub showBonusWindow()

        'Determine which team is playing
        If group1Playing = True Then        'Close team#2`s window and show team#1`s and vice versa

            Display.lbBonus2.Hide()
            Display.lbBonus1.Show()
            Display.lbBonus1.Text = bonus.ToString

        Else

            Display.lbBonus1.Hide()
            Display.lbBonus2.Show()
            Display.lbBonus2.Text = bonus.ToString

        End If

    End Sub

    'Switch the team each after a goal or an interception occurs
    Private Sub teamSwitch()

        If group1Playing = True Then

            btnSwap.Text = "Group2`s Turn"          'Use a button to show and switch which team is playing
            group1Playing = False                   'Swap the team

            clearBonus()                            'Clear current bonus marks

        Else

            btnSwap.Text = "Group1`s Turn"
            group1Playing = True

            clearBonus()

        End If

        showBonusWindow()                           'Show the correct bonus window

    End Sub

    'Start a new run
    Private Sub newRound()
        'First we reset all bonus and scores for each team
        clearBonus()
        score_1 = 0
        score_2 = 0

        Display.scoreboard.Text = score_1.ToString + " : " + score_2.ToString       'Show the score on scoreboard

        teamSwitch()                    'Switch the team

        'Update the current round number
        lbRound.Text = "Round" + round.ToString
        Display.lbRound.Text = round.ToString()

    End Sub

    'Reduce the current Round number
    Private Sub minRound_Click(sender As Object, e As EventArgs) Handles minRound.Click
        round -= 1


        If round < 1 Then

            round = 1

        End If

        newRound()                  'Start a new round

    End Sub

    'Increase the current Round Number
    Private Sub plusRound_Click(sender As Object, e As EventArgs) Handles plusRound.Click

        round += 1

        'Round number can`t greater than 3
        If round > 3 Then

            round = 1

        End If
        newRound()

    End Sub

    'Store the team name everytime we`ve submmited the info
    Private Sub tbTeamName_TextChanged(sender As Object, e As EventArgs)

        teamName_1 = tbTeamName_1.Text

    End Sub

    'Store the info for Team#1 after a click on Submit Button
    Private Sub enterTeam1_Click_1(sender As Object, e As EventArgs)

        'Store the team name in to a listbox, clear the textbox, change the Label of team#1
        teamName_1 = tbTeamName_1.Text
        lbGroup1.Items.Add(teamName_1)
        tbTeamName_1.ResetText()
        lbTeamName_1.Text = "Team Name: " + teamName_1

        'Store the team members into these variables
        member_1 = tbM1.Text
        member_2 = tbM2.Text
        member_3 = tbM3.Text
        member_4 = tbM4.Text
        member_5 = tbM5.Text

        'Add those String variables into the listbox
        lbGroup1.Items.Add(member_1)
        lbGroup1.Items.Add(member_2)
        lbGroup1.Items.Add(member_3)
        lbGroup1.Items.Add(member_4)
        lbGroup1.Items.Add(member_5)

        tbM1.ResetText()
        tbM2.ResetText()
        tbM3.ResetText()
        tbM4.ResetText()
        tbM5.ResetText()

        'Show the team name on window Display
        Display.lbGroup1.Text = teamName_1

        'Show the members after team name
        Display.lbMember1.Text = member_1
        Display.lbMember2.Text = member_2
        Display.lbMember3.Text = member_3
        Display.lbMember4.Text = member_4
        Display.lbMember5.Text = member_5

    End Sub

    'Reset the info of Team#1
    Private Sub cbTeam1_Click(sender As Object, e As EventArgs)

        teamName_1 = tbTeamName_1.Text
        lbGroup1.Items.Clear()
        tbTeamName_1.ResetText()
        lbTeamName_1.Text = "Team Name: "

        member_1 = ""
        member_2 = ""
        member_3 = ""
        member_4 = ""
        member_5 = ""

        tbM1.ResetText()
        tbM2.ResetText()
        tbM3.ResetText()
        tbM4.ResetText()
        tbM5.ResetText()

    End Sub

    'Basicly the same with the the function before
    Private Sub enterTeam2_Click(sender As Object, e As EventArgs)

        teamName_2 = tbTeamName_2.Text
        lbGroup2.Items.Add(teamName_2)
        tbTeamName_2.ResetText()
        lbTeamName_2.Text = "Team Name: " + teamName_2

        member_6 = tbM6.Text
        member_7 = tbM7.Text
        member_8 = tbM8.Text
        member_9 = tbM9.Text
        member_10 = tbM10.Text

        lbGroup2.Items.Add(member_6)
        lbGroup2.Items.Add(member_7)
        lbGroup2.Items.Add(member_8)
        lbGroup2.Items.Add(member_9)
        lbGroup2.Items.Add(member_10)

        tbM6.ResetText()
        tbM7.ResetText()
        tbM8.ResetText()
        tbM9.ResetText()
        tbM10.ResetText()

        Display.lbGroup2.Text = teamName_2

        Display.lbMember6.Text = member_6
        Display.lbMember7.Text = member_7
        Display.lbMember8.Text = member_8
        Display.lbMember9.Text = member_9
        Display.lbMember10.Text = member_10

    End Sub

    'Basicly the same with the the function before
    Private Sub cbTeam2_Click(sender As Object, e As EventArgs) Handles cbTeam2.Click
        teamName_2 = tbTeamName_2.Text
        lbGroup2.Items.Clear()
        tbTeamName_2.ResetText()
        lbTeamName_2.Text = "Team Name: "

        member_6 = ""
        member_7 = ""
        member_8 = ""
        member_9 = ""
        member_10 = ""

        tbM6.ResetText()
        tbM7.ResetText()
        tbM8.ResetText()
        tbM9.ResetText()
        tbM10.ResetText()
    End Sub

    'Reset the current bonus marks
    Private Sub resetBonus_Click(sender As Object, e As EventArgs) Handles resetBonus.Click

        clearBonus()

    End Sub

    'Increase the bonus marks and show the right window everytime we click on the button
    Private Sub addBonus_Click(sender As Object, e As EventArgs) Handles addBonus.Click

        bonus += 1

        'Bonus can`t greater than 3
        If bonus > 3 Then

            bonus = 3

        End If

        showBonusWindow()
        lbBonus.Text = "Bonus" + bonus.ToString             'Change the bonus marks on Scoring

    End Sub

    'Handles the event that we click on the button Intercepted
    Private Sub btnIntercepted_Click(sender As Object, e As EventArgs) Handles btnIntercepted.Click

        teamSwitch()                        'Switch the team

        temp = 0                            'Reset the protential score

    End Sub

    'Handles the event that we click on the button Goal!!!
    Private Sub btnGoal_Click(sender As Object, e As EventArgs) Handles btnGoal.Click


        temp = 5 + bonus                                'Set the temp eaquals to 5 basic + current bonus points

        'Swap the current playing team on the button, show the score and reset the bonus marks
        If group1Playing = True Then

            btnSwap.Text = "Group1`s Turn"
            score_1 += temp

            Display.scoreboard.Text = score_1.ToString + " : " + score_2.ToString
            clearBonus()

        Else

            score_2 += temp

            btnSwap.Text = "Group2`s Turn"

            Display.scoreboard.Text = score_1.ToString + " : " + score_2.ToString
            clearBonus()

        End If

        temp = 0                        'Set temp back to 0

        teamSwitch()                    'Swap the team

    End Sub

    'Swap the team via the button
    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click

        teamSwitch()

    End Sub

    'Display the window Display everytime we click on button Start
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Display.Show()

    End Sub

End Class
