<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Scoring
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim enterTeam1 As System.Windows.Forms.Button
        Dim cbTeam1 As System.Windows.Forms.Button
        Dim enterTeam2 As System.Windows.Forms.Button
        Me.scoringLabel = New System.Windows.Forms.Label()
        Me.tbTeamName_1 = New System.Windows.Forms.TextBox()
        Me.lbM1 = New System.Windows.Forms.Label()
        Me.lbTeamName_1 = New System.Windows.Forms.Label()
        Me.tbM1 = New System.Windows.Forms.TextBox()
        Me.tbM2 = New System.Windows.Forms.TextBox()
        Me.tbM5 = New System.Windows.Forms.TextBox()
        Me.tbM3 = New System.Windows.Forms.TextBox()
        Me.tbM4 = New System.Windows.Forms.TextBox()
        Me.lbM2 = New System.Windows.Forms.Label()
        Me.lbM3 = New System.Windows.Forms.Label()
        Me.lbM5 = New System.Windows.Forms.Label()
        Me.lbM4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbGroup1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTeamName_2 = New System.Windows.Forms.Label()
        Me.tbTeamName_2 = New System.Windows.Forms.TextBox()
        Me.tbM9 = New System.Windows.Forms.TextBox()
        Me.tbM6 = New System.Windows.Forms.TextBox()
        Me.tbM10 = New System.Windows.Forms.TextBox()
        Me.tbM7 = New System.Windows.Forms.TextBox()
        Me.tbM8 = New System.Windows.Forms.TextBox()
        Me.lbM6 = New System.Windows.Forms.Label()
        Me.lbM7 = New System.Windows.Forms.Label()
        Me.lbM8 = New System.Windows.Forms.Label()
        Me.lbM9 = New System.Windows.Forms.Label()
        Me.lbM10 = New System.Windows.Forms.Label()
        Me.cbTeam2 = New System.Windows.Forms.Button()
        Me.lbGroup2 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.btnIntercepted = New System.Windows.Forms.Button()
        Me.btnGoal = New System.Windows.Forms.Button()
        Me.lbBonus = New System.Windows.Forms.Label()
        Me.addBonus = New System.Windows.Forms.Button()
        Me.resetBonus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbRound = New System.Windows.Forms.Label()
        Me.plusRound = New System.Windows.Forms.Button()
        Me.minRound = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        enterTeam1 = New System.Windows.Forms.Button()
        cbTeam1 = New System.Windows.Forms.Button()
        enterTeam2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'enterTeam1
        '
        enterTeam1.BackColor = System.Drawing.Color.LimeGreen
        enterTeam1.Font = New System.Drawing.Font("Arial", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        enterTeam1.Location = New System.Drawing.Point(120, 756)
        enterTeam1.Name = "enterTeam1"
        enterTeam1.Size = New System.Drawing.Size(127, 45)
        enterTeam1.TabIndex = 0
        enterTeam1.Text = "Submit"
        enterTeam1.UseVisualStyleBackColor = False
        AddHandler enterTeam1.Click, AddressOf Me.enterTeam1_Click_1
        '
        'cbTeam1
        '
        cbTeam1.BackColor = System.Drawing.Color.OrangeRed
        cbTeam1.Font = New System.Drawing.Font("Arial", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cbTeam1.Location = New System.Drawing.Point(267, 756)
        cbTeam1.Name = "cbTeam1"
        cbTeam1.Size = New System.Drawing.Size(124, 45)
        cbTeam1.TabIndex = 3
        cbTeam1.Text = "Reset"
        cbTeam1.UseVisualStyleBackColor = False
        AddHandler cbTeam1.Click, AddressOf Me.cbTeam1_Click
        '
        'enterTeam2
        '
        enterTeam2.BackColor = System.Drawing.Color.LimeGreen
        enterTeam2.Font = New System.Drawing.Font("Arial", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        enterTeam2.Location = New System.Drawing.Point(1048, 756)
        enterTeam2.Name = "enterTeam2"
        enterTeam2.Size = New System.Drawing.Size(127, 45)
        enterTeam2.TabIndex = 42
        enterTeam2.Text = "Submit"
        enterTeam2.UseVisualStyleBackColor = False
        AddHandler enterTeam2.Click, AddressOf Me.enterTeam2_Click
        '
        'scoringLabel
        '
        Me.scoringLabel.AutoSize = True
        Me.scoringLabel.Font = New System.Drawing.Font("Arial Black", 25.0!, System.Drawing.FontStyle.Bold)
        Me.scoringLabel.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.scoringLabel.Location = New System.Drawing.Point(568, 9)
        Me.scoringLabel.MinimumSize = New System.Drawing.Size(200, 70)
        Me.scoringLabel.Name = "scoringLabel"
        Me.scoringLabel.Size = New System.Drawing.Size(320, 95)
        Me.scoringLabel.TabIndex = 1
        Me.scoringLabel.Text = "Scoring"
        Me.scoringLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbTeamName_1
        '
        Me.tbTeamName_1.BackColor = System.Drawing.Color.White
        Me.tbTeamName_1.Location = New System.Drawing.Point(121, 210)
        Me.tbTeamName_1.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbTeamName_1.Name = "tbTeamName_1"
        Me.tbTeamName_1.Size = New System.Drawing.Size(270, 35)
        Me.tbTeamName_1.TabIndex = 2
        Me.tbTeamName_1.Text = "Enter Team Name..."
        '
        'lbM1
        '
        Me.lbM1.AutoSize = True
        Me.lbM1.Location = New System.Drawing.Point(120, 263)
        Me.lbM1.Name = "lbM1"
        Me.lbM1.Size = New System.Drawing.Size(130, 24)
        Me.lbM1.TabIndex = 4
        Me.lbM1.Text = "Member #1:"
        '
        'lbTeamName_1
        '
        Me.lbTeamName_1.AutoSize = True
        Me.lbTeamName_1.Location = New System.Drawing.Point(120, 171)
        Me.lbTeamName_1.MinimumSize = New System.Drawing.Size(30, 10)
        Me.lbTeamName_1.Name = "lbTeamName_1"
        Me.lbTeamName_1.Size = New System.Drawing.Size(130, 24)
        Me.lbTeamName_1.TabIndex = 5
        Me.lbTeamName_1.Text = "Team Name:"
        Me.lbTeamName_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbM1
        '
        Me.tbM1.BackColor = System.Drawing.Color.White
        Me.tbM1.Location = New System.Drawing.Point(121, 308)
        Me.tbM1.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM1.Name = "tbM1"
        Me.tbM1.Size = New System.Drawing.Size(270, 35)
        Me.tbM1.TabIndex = 6
        Me.tbM1.Text = "Enter The Name..."
        '
        'tbM2
        '
        Me.tbM2.BackColor = System.Drawing.Color.White
        Me.tbM2.Location = New System.Drawing.Point(121, 403)
        Me.tbM2.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM2.Name = "tbM2"
        Me.tbM2.Size = New System.Drawing.Size(270, 35)
        Me.tbM2.TabIndex = 7
        Me.tbM2.Text = "Enter The Name..."
        '
        'tbM5
        '
        Me.tbM5.BackColor = System.Drawing.Color.White
        Me.tbM5.Location = New System.Drawing.Point(121, 702)
        Me.tbM5.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM5.Name = "tbM5"
        Me.tbM5.Size = New System.Drawing.Size(270, 35)
        Me.tbM5.TabIndex = 8
        Me.tbM5.Text = "Enter The Name..."
        '
        'tbM3
        '
        Me.tbM3.BackColor = System.Drawing.Color.White
        Me.tbM3.Location = New System.Drawing.Point(121, 503)
        Me.tbM3.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM3.Name = "tbM3"
        Me.tbM3.Size = New System.Drawing.Size(270, 35)
        Me.tbM3.TabIndex = 9
        Me.tbM3.Text = "Enter The Name..."
        '
        'tbM4
        '
        Me.tbM4.BackColor = System.Drawing.Color.White
        Me.tbM4.Location = New System.Drawing.Point(121, 597)
        Me.tbM4.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM4.Name = "tbM4"
        Me.tbM4.Size = New System.Drawing.Size(270, 35)
        Me.tbM4.TabIndex = 10
        Me.tbM4.Text = "Enter The Name..."
        '
        'lbM2
        '
        Me.lbM2.AutoSize = True
        Me.lbM2.Location = New System.Drawing.Point(120, 361)
        Me.lbM2.Name = "lbM2"
        Me.lbM2.Size = New System.Drawing.Size(130, 24)
        Me.lbM2.TabIndex = 13
        Me.lbM2.Text = "Member #2:"
        '
        'lbM3
        '
        Me.lbM3.AutoSize = True
        Me.lbM3.Location = New System.Drawing.Point(120, 458)
        Me.lbM3.Name = "lbM3"
        Me.lbM3.Size = New System.Drawing.Size(130, 24)
        Me.lbM3.TabIndex = 22
        Me.lbM3.Text = "Member #3:"
        '
        'lbM5
        '
        Me.lbM5.AutoSize = True
        Me.lbM5.Location = New System.Drawing.Point(120, 657)
        Me.lbM5.Name = "lbM5"
        Me.lbM5.Size = New System.Drawing.Size(130, 24)
        Me.lbM5.TabIndex = 23
        Me.lbM5.Text = "Member #5:"
        '
        'lbM4
        '
        Me.lbM4.AutoSize = True
        Me.lbM4.Location = New System.Drawing.Point(117, 554)
        Me.lbM4.Name = "lbM4"
        Me.lbM4.Size = New System.Drawing.Size(130, 24)
        Me.lbM4.TabIndex = 24
        Me.lbM4.Text = "Member #4:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 73)
        Me.Label6.MinimumSize = New System.Drawing.Size(200, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 74)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Group 1"
        '
        'lbGroup1
        '
        Me.lbGroup1.FormattingEnabled = True
        Me.lbGroup1.ItemHeight = 24
        Me.lbGroup1.Location = New System.Drawing.Point(120, 866)
        Me.lbGroup1.Name = "lbGroup1"
        Me.lbGroup1.Size = New System.Drawing.Size(290, 220)
        Me.lbGroup1.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1182, 73)
        Me.Label1.MinimumSize = New System.Drawing.Size(200, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 74)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Group 2"
        '
        'lbTeamName_2
        '
        Me.lbTeamName_2.AutoSize = True
        Me.lbTeamName_2.Location = New System.Drawing.Point(1045, 171)
        Me.lbTeamName_2.MinimumSize = New System.Drawing.Size(30, 10)
        Me.lbTeamName_2.Name = "lbTeamName_2"
        Me.lbTeamName_2.Size = New System.Drawing.Size(130, 24)
        Me.lbTeamName_2.TabIndex = 30
        Me.lbTeamName_2.Text = "Team Name:"
        Me.lbTeamName_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbTeamName_2
        '
        Me.tbTeamName_2.BackColor = System.Drawing.Color.White
        Me.tbTeamName_2.Location = New System.Drawing.Point(1049, 210)
        Me.tbTeamName_2.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbTeamName_2.Name = "tbTeamName_2"
        Me.tbTeamName_2.Size = New System.Drawing.Size(270, 35)
        Me.tbTeamName_2.TabIndex = 31
        Me.tbTeamName_2.Text = "Enter Team Name..."
        '
        'tbM9
        '
        Me.tbM9.BackColor = System.Drawing.Color.White
        Me.tbM9.Location = New System.Drawing.Point(1049, 597)
        Me.tbM9.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM9.Name = "tbM9"
        Me.tbM9.Size = New System.Drawing.Size(270, 35)
        Me.tbM9.TabIndex = 32
        Me.tbM9.Text = "Enter The Name..."
        '
        'tbM6
        '
        Me.tbM6.BackColor = System.Drawing.Color.White
        Me.tbM6.Location = New System.Drawing.Point(1049, 308)
        Me.tbM6.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM6.Name = "tbM6"
        Me.tbM6.Size = New System.Drawing.Size(270, 35)
        Me.tbM6.TabIndex = 33
        Me.tbM6.Text = "Enter The Name..."
        '
        'tbM10
        '
        Me.tbM10.BackColor = System.Drawing.Color.White
        Me.tbM10.Location = New System.Drawing.Point(1049, 702)
        Me.tbM10.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM10.Name = "tbM10"
        Me.tbM10.Size = New System.Drawing.Size(270, 35)
        Me.tbM10.TabIndex = 34
        Me.tbM10.Text = "Enter The Name..."
        '
        'tbM7
        '
        Me.tbM7.BackColor = System.Drawing.Color.White
        Me.tbM7.Location = New System.Drawing.Point(1049, 403)
        Me.tbM7.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM7.Name = "tbM7"
        Me.tbM7.Size = New System.Drawing.Size(270, 35)
        Me.tbM7.TabIndex = 35
        Me.tbM7.Text = "Enter The Name..."
        '
        'tbM8
        '
        Me.tbM8.BackColor = System.Drawing.Color.White
        Me.tbM8.Location = New System.Drawing.Point(1049, 503)
        Me.tbM8.MinimumSize = New System.Drawing.Size(270, 20)
        Me.tbM8.Name = "tbM8"
        Me.tbM8.Size = New System.Drawing.Size(270, 35)
        Me.tbM8.TabIndex = 36
        Me.tbM8.Text = "Enter The Name..."
        '
        'lbM6
        '
        Me.lbM6.AutoSize = True
        Me.lbM6.Location = New System.Drawing.Point(1045, 263)
        Me.lbM6.Name = "lbM6"
        Me.lbM6.Size = New System.Drawing.Size(130, 24)
        Me.lbM6.TabIndex = 37
        Me.lbM6.Text = "Member #1:"
        '
        'lbM7
        '
        Me.lbM7.AutoSize = True
        Me.lbM7.Location = New System.Drawing.Point(1045, 361)
        Me.lbM7.Name = "lbM7"
        Me.lbM7.Size = New System.Drawing.Size(130, 24)
        Me.lbM7.TabIndex = 38
        Me.lbM7.Text = "Member #2:"
        '
        'lbM8
        '
        Me.lbM8.AutoSize = True
        Me.lbM8.Location = New System.Drawing.Point(1045, 458)
        Me.lbM8.Name = "lbM8"
        Me.lbM8.Size = New System.Drawing.Size(130, 24)
        Me.lbM8.TabIndex = 39
        Me.lbM8.Text = "Member #3:"
        '
        'lbM9
        '
        Me.lbM9.AutoSize = True
        Me.lbM9.Location = New System.Drawing.Point(1045, 554)
        Me.lbM9.Name = "lbM9"
        Me.lbM9.Size = New System.Drawing.Size(130, 24)
        Me.lbM9.TabIndex = 40
        Me.lbM9.Text = "Member #4:"
        '
        'lbM10
        '
        Me.lbM10.AutoSize = True
        Me.lbM10.Location = New System.Drawing.Point(1045, 657)
        Me.lbM10.Name = "lbM10"
        Me.lbM10.Size = New System.Drawing.Size(130, 24)
        Me.lbM10.TabIndex = 41
        Me.lbM10.Text = "Member #5:"
        '
        'cbTeam2
        '
        Me.cbTeam2.BackColor = System.Drawing.Color.OrangeRed
        Me.cbTeam2.Font = New System.Drawing.Font("Arial", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTeam2.Location = New System.Drawing.Point(1195, 756)
        Me.cbTeam2.Name = "cbTeam2"
        Me.cbTeam2.Size = New System.Drawing.Size(124, 45)
        Me.cbTeam2.TabIndex = 43
        Me.cbTeam2.Text = "Reset"
        Me.cbTeam2.UseVisualStyleBackColor = False
        '
        'lbGroup2
        '
        Me.lbGroup2.FormattingEnabled = True
        Me.lbGroup2.ItemHeight = 24
        Me.lbGroup2.Location = New System.Drawing.Point(1048, 866)
        Me.lbGroup2.Name = "lbGroup2"
        Me.lbGroup2.Size = New System.Drawing.Size(290, 220)
        Me.lbGroup2.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.btnSwap)
        Me.Panel1.Controls.Add(Me.btnIntercepted)
        Me.Panel1.Controls.Add(Me.btnGoal)
        Me.Panel1.Controls.Add(Me.lbBonus)
        Me.Panel1.Controls.Add(Me.addBonus)
        Me.Panel1.Controls.Add(Me.resetBonus)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbRound)
        Me.Panel1.Controls.Add(Me.plusRound)
        Me.Panel1.Controls.Add(Me.minRound)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(505, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 906)
        Me.Panel1.TabIndex = 45
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Crimson
        Me.btnStart.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStart.Location = New System.Drawing.Point(63, 745)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(297, 147)
        Me.btnStart.TabIndex = 14
        Me.btnStart.Text = "Start A Game!!!"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnSwap
        '
        Me.btnSwap.BackColor = System.Drawing.Color.SlateBlue
        Me.btnSwap.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnSwap.Location = New System.Drawing.Point(63, 592)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(297, 147)
        Me.btnSwap.TabIndex = 13
        Me.btnSwap.Text = "Group1`s Turn"
        Me.btnSwap.UseVisualStyleBackColor = False
        '
        'btnIntercepted
        '
        Me.btnIntercepted.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnIntercepted.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!)
        Me.btnIntercepted.Location = New System.Drawing.Point(63, 478)
        Me.btnIntercepted.Name = "btnIntercepted"
        Me.btnIntercepted.Size = New System.Drawing.Size(297, 105)
        Me.btnIntercepted.TabIndex = 12
        Me.btnIntercepted.Text = "Intercepted"
        Me.btnIntercepted.UseVisualStyleBackColor = False
        '
        'btnGoal
        '
        Me.btnGoal.BackColor = System.Drawing.Color.Orange
        Me.btnGoal.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!)
        Me.btnGoal.Location = New System.Drawing.Point(63, 359)
        Me.btnGoal.Name = "btnGoal"
        Me.btnGoal.Size = New System.Drawing.Size(297, 105)
        Me.btnGoal.TabIndex = 11
        Me.btnGoal.Text = "Goal!!!"
        Me.btnGoal.UseVisualStyleBackColor = False
        '
        'lbBonus
        '
        Me.lbBonus.AutoSize = True
        Me.lbBonus.BackColor = System.Drawing.Color.SteelBlue
        Me.lbBonus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBonus.Location = New System.Drawing.Point(164, 253)
        Me.lbBonus.MaximumSize = New System.Drawing.Size(95, 80)
        Me.lbBonus.MinimumSize = New System.Drawing.Size(95, 80)
        Me.lbBonus.Name = "lbBonus"
        Me.lbBonus.Size = New System.Drawing.Size(95, 80)
        Me.lbBonus.TabIndex = 10
        Me.lbBonus.Text = "Bonus"
        Me.lbBonus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'addBonus
        '
        Me.addBonus.BackColor = System.Drawing.Color.LimeGreen
        Me.addBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBonus.Location = New System.Drawing.Point(265, 253)
        Me.addBonus.Name = "addBonus"
        Me.addBonus.Size = New System.Drawing.Size(95, 80)
        Me.addBonus.TabIndex = 9
        Me.addBonus.Text = "+"
        Me.addBonus.UseVisualStyleBackColor = False
        '
        'resetBonus
        '
        Me.resetBonus.BackColor = System.Drawing.Color.OrangeRed
        Me.resetBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.resetBonus.Location = New System.Drawing.Point(63, 253)
        Me.resetBonus.Name = "resetBonus"
        Me.resetBonus.Size = New System.Drawing.Size(95, 80)
        Me.resetBonus.TabIndex = 8
        Me.resetBonus.Text = "Reset"
        Me.resetBonus.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(163, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Bonus!"
        '
        'lbRound
        '
        Me.lbRound.AutoSize = True
        Me.lbRound.BackColor = System.Drawing.Color.SteelBlue
        Me.lbRound.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRound.Location = New System.Drawing.Point(164, 113)
        Me.lbRound.MaximumSize = New System.Drawing.Size(95, 80)
        Me.lbRound.MinimumSize = New System.Drawing.Size(95, 80)
        Me.lbRound.Name = "lbRound"
        Me.lbRound.Size = New System.Drawing.Size(95, 80)
        Me.lbRound.TabIndex = 6
        Me.lbRound.Text = "Round"
        Me.lbRound.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'plusRound
        '
        Me.plusRound.BackColor = System.Drawing.Color.LimeGreen
        Me.plusRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusRound.Location = New System.Drawing.Point(265, 113)
        Me.plusRound.Name = "plusRound"
        Me.plusRound.Size = New System.Drawing.Size(95, 80)
        Me.plusRound.TabIndex = 2
        Me.plusRound.Text = "+"
        Me.plusRound.UseVisualStyleBackColor = False
        '
        'minRound
        '
        Me.minRound.BackColor = System.Drawing.Color.OrangeRed
        Me.minRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minRound.Location = New System.Drawing.Point(63, 113)
        Me.minRound.Name = "minRound"
        Me.minRound.Size = New System.Drawing.Size(95, 80)
        Me.minRound.TabIndex = 1
        Me.minRound.Text = "-"
        Me.minRound.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(57, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Set The Round Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(509, 121)
        Me.Label2.MinimumSize = New System.Drawing.Size(200, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 74)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "GamePlay"
        '
        'Scoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1505, 1245)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1913, 1335)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbGroup2)
        Me.Controls.Add(Me.cbTeam2)
        Me.Controls.Add(enterTeam2)
        Me.Controls.Add(Me.lbM10)
        Me.Controls.Add(Me.lbM9)
        Me.Controls.Add(Me.lbM8)
        Me.Controls.Add(Me.lbM7)
        Me.Controls.Add(Me.lbM6)
        Me.Controls.Add(Me.tbM8)
        Me.Controls.Add(Me.tbM7)
        Me.Controls.Add(Me.tbM10)
        Me.Controls.Add(Me.tbM6)
        Me.Controls.Add(Me.tbM9)
        Me.Controls.Add(Me.tbTeamName_2)
        Me.Controls.Add(Me.lbTeamName_2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbGroup1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbM4)
        Me.Controls.Add(Me.lbM5)
        Me.Controls.Add(Me.lbM3)
        Me.Controls.Add(Me.lbM2)
        Me.Controls.Add(Me.tbM4)
        Me.Controls.Add(Me.tbM3)
        Me.Controls.Add(Me.tbM5)
        Me.Controls.Add(Me.tbM2)
        Me.Controls.Add(Me.tbM1)
        Me.Controls.Add(Me.lbTeamName_1)
        Me.Controls.Add(Me.lbM1)
        Me.Controls.Add(cbTeam1)
        Me.Controls.Add(Me.tbTeamName_1)
        Me.Controls.Add(Me.scoringLabel)
        Me.Controls.Add(enterTeam1)
        Me.MinimumSize = New System.Drawing.Size(1505, 1245)
        Me.Name = "Scoring"
        Me.Text = "Scoring"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scoringLabel As Label
    Friend WithEvents tbTeamName_1 As TextBox
    Friend WithEvents lbM1 As Label
    Friend WithEvents lbTeamName_1 As Label
    Friend WithEvents tbM1 As TextBox
    Friend WithEvents tbM2 As TextBox
    Friend WithEvents tbM5 As TextBox
    Friend WithEvents tbM3 As TextBox
    Friend WithEvents tbM4 As TextBox
    Friend WithEvents lbM2 As Label
    Friend WithEvents lbM3 As Label
    Friend WithEvents lbM5 As Label
    Friend WithEvents lbM4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbGroup1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTeamName_2 As Label
    Friend WithEvents tbTeamName_2 As TextBox
    Friend WithEvents tbM9 As TextBox
    Friend WithEvents tbM6 As TextBox
    Friend WithEvents tbM10 As TextBox
    Friend WithEvents tbM7 As TextBox
    Friend WithEvents tbM8 As TextBox
    Friend WithEvents lbM6 As Label
    Friend WithEvents lbM7 As Label
    Friend WithEvents lbM8 As Label
    Friend WithEvents lbM9 As Label
    Friend WithEvents lbM10 As Label
    Friend WithEvents lbGroup2 As ListBox
    Friend WithEvents cbTeam2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents plusRound As Button
    Friend WithEvents minRound As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbRound As Label
    Friend WithEvents lbBonus As Label
    Friend WithEvents addBonus As Button
    Friend WithEvents resetBonus As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIntercepted As Button
    Friend WithEvents btnGoal As Button
    Friend WithEvents btnSwap As Button
    Friend WithEvents btnStart As Button
End Class
