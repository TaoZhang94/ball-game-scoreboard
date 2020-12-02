Public Class Display

    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Show the team names
        lbGroup1.Text = Scoring.teamName_1
        lbGroup2.Text = Scoring.teamName_2

        'Show the members after the team name
        lbMember1.Text = Scoring.member_1
        lbMember2.Text = Scoring.member_2
        lbMember3.Text = Scoring.member_3
        lbMember4.Text = Scoring.member_4
        lbMember5.Text = Scoring.member_5

        'Members for team#2
        lbMember6.Text = Scoring.member_6
        lbMember7.Text = Scoring.member_7
        lbMember8.Text = Scoring.member_8
        lbMember9.Text = Scoring.member_9
        lbMember10.Text = Scoring.member_10

        'Show the scoreboard and current round
        scoreboard.Text = Scoring.score_1.ToString + " : " + Scoring.score_2.ToString
        lbRound.Text = Scoring.round.ToString

        'Show the correct bonus window
        If Scoring.group1Playing = True Then

            lbBonus2.Hide()
            lbBonus1.Show()

            lbBonus1.Text = Scoring.bonus

        Else

            lbBonus1.Hide()
            lbBonus2.Show()

            lbBonus2.Text = Scoring.bonus
        End If

    End Sub

End Class