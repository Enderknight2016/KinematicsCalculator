

Public Class frmKinematicsCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If rbVelocityFinal1.Checked = True Then

            If rbVelocityInitial2.Checked = True Then


                If rbAcceleration3.Checked = True Then
                    MessageBox.Show(Displacement1(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m", "Displacement")
                    MessageBox.Show(Time1(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " s", "Time")

                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(Acceleration1(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Time2(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " s", "Time")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(Acceleration2(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Displacement2(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m", "Displacement")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbAcceleration2.Checked = True Then

                If rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(Displacement1(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m", "Displacement")
                    MessageBox.Show(Time1(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " s", "Time")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityInitial1(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Time3(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " s", "Time")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityInitial2(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Displacement3(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m", "Displacement")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbDisplacement2.Checked = True Then


                If rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(Acceleration1(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Time2(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " s", "Time")
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityInitial1(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Time3(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " s", "Time")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityInitial3(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Acceleration3(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s^2", "Acceleration")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbTime2.Checked = True Then

                If rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(Acceleration2(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Displacement2(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m", "Displacement")
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityInitial2(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Displacement3(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m", "Displacement")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityInitial3(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Acceleration3(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s^2", "Acceleration")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            Else
                MessageBox.Show("Not all Variables have been selected")
                txtVariable1.Text = ""
                txtVariable2.Text = ""
                txtVariable3.Text = ""
            End If
        ElseIf rbVelocityInitial1.Checked = True Then

            If rbVelocityFinal2.Checked = True Then

                If rbAcceleration3.Checked = True Then
                    MessageBox.Show(Displacement1(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m", "Displacement")
                    MessageBox.Show(Time1(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " s", "Time")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(Acceleration1(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Time2(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " s", "Time")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(Acceleration2(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Displacement2(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m", "Displacement")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbVelocityInitial2.Checked = True Then

                MessageBox.Show("Not all Variables have been selected")
                txtVariable1.Text = ""
                txtVariable2.Text = ""
                txtVariable3.Text = ""

            ElseIf rbAcceleration2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(Displacement1(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m", "Displacement")
                    MessageBox.Show(Time1(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " s", "Time")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityFinal1(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Time4(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " s", "Time")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityFinal2(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Displacement4(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m", "Displacement")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbDisplacement2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(Acceleration1(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Time2(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " s", "Time")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityFinal1(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Time4(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " s", "Time")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityFinal3(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Acceleration4(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s^2", "Acceleration")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbTime2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(Acceleration2(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Displacement2(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m", "Displacement")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityFinal2(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Displacement4(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m", "Displacement")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityFinal3(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Acceleration4(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s^2", "Acceleration")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            Else
                MessageBox.Show("Not all Variables have been selected")
                txtVariable1.Text = ""
                txtVariable2.Text = ""
                txtVariable3.Text = ""
            End If
        ElseIf rbAcceleration1.Checked = True Then

            If rbVelocityFinal2.Checked = True Then


                If rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(Displacement1(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m", "Displacement")
                    MessageBox.Show(Time1(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " s", "Time")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityInitial1(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Time3(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " s", "Time")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityInitial2(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Displacement3(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m", "Displacement")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbVelocityInitial2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(Displacement1(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m", "Displacement")
                    MessageBox.Show(Time1(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " s", "Time")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityFinal1(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Time4(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " s", "Time")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityFinal2(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Displacement4(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m", "Displacement")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbDisplacement2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(VelocityInitial1(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Time3(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " s", "Time")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(VelocityFinal1(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Time4(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " s", "Time")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityInitial4(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(VelocityFinal4(txtVariable1.Text, txtVariable2.Text, txtVariable3.Text) + " m/s", "Final Velocity")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbTime2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(VelocityInitial2(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Displacement3(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m", "Displacement")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(VelocityFinal2(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Displacement4(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m", "Displacement")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityInitial4(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(VelocityFinal4(txtVariable1.Text, txtVariable3.Text, txtVariable2.Text) + " m/s", "Final Velocity")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            Else
                MessageBox.Show("Not all Variables have been selected")
                txtVariable1.Text = ""
                txtVariable2.Text = ""
                txtVariable3.Text = ""
            End If
        ElseIf rbDisplacement1.Checked = True Then

            If rbVelocityFinal2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(Acceleration1(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Time2(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " s", "Time")
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityInitial1(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Time3(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " s", "Time")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityInitial3(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Acceleration3(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s^2", "Acceleration")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbVelocityInitial2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(Acceleration1(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Time2(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " s", "Time")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityFinal1(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Time4(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " s", "Time")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityFinal3(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Acceleration4(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s^2", "Acceleration")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbAcceleration2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(VelocityInitial1(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Time3(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " s", "Time")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(VelocityFinal1(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Time4(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " s", "Time")
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show(VelocityInitial4(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(VelocityFinal4(txtVariable2.Text, txtVariable1.Text, txtVariable3.Text) + " m/s", "Final Velocity")
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbDisplacement2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbTime2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(VelocityInitial3(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Acceleration3(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s^2", "Acceleration")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(VelocityFinal3(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Acceleration4(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s^2", "Acceleration")
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityInitial4(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(VelocityFinal4(txtVariable2.Text, txtVariable3.Text, txtVariable1.Text) + " m/s", "Final Velocity")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            Else
                MessageBox.Show("Not all Variables have been selected")
                txtVariable1.Text = ""
                txtVariable2.Text = ""
                txtVariable3.Text = ""
            End If
        ElseIf rbTime1.Checked = True Then

            If rbVelocityFinal2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(Acceleration2(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Displacement2(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m", "Displacement")
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityInitial2(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Displacement3(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m", "Displacement")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityInitial3(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Acceleration3(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s^2", "Acceleration")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbVelocityInitial2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(Acceleration2(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s^2", "Acceleration")
                    MessageBox.Show(Displacement2(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m", "Displacement")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityFinal2(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Displacement4(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m", "Displacement")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityFinal3(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Acceleration4(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s^2", "Acceleration")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbAcceleration2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(VelocityInitial2(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Displacement3(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m", "Displacement")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(VelocityFinal2(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Displacement4(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m", "Displacement")
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show(VelocityInitial4(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(VelocityFinal4(txtVariable3.Text, txtVariable1.Text, txtVariable2.Text) + " m/s", "Final Velocity")
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbDisplacement2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show(VelocityInitial3(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(Acceleration3(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s^2", "Acceleration")
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show(VelocityFinal3(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s", "Final Velocity")
                    MessageBox.Show(Acceleration4(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s^2", "Acceleration")
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show(VelocityInitial4(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s", "Initial Velocity")
                    MessageBox.Show(VelocityFinal4(txtVariable3.Text, txtVariable2.Text, txtVariable1.Text) + " m/s", "Final Velocity")
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            ElseIf rbTime2.Checked = True Then

                If rbVelocityFinal3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbVelocityInitial3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbAcceleration3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbDisplacement3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                ElseIf rbTime3.Checked = True Then
                    MessageBox.Show("You have Identical Variables selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                Else
                    MessageBox.Show("Not all Variables have been selected")
                    txtVariable1.Text = ""
                    txtVariable2.Text = ""
                    txtVariable3.Text = ""
                End If

            Else
                MessageBox.Show("Not all Variables have been selected")
                txtVariable1.Text = ""
                txtVariable2.Text = ""
                txtVariable3.Text = ""

            End If
        Else
            MessageBox.Show("Not all Variables have been selected")
            txtVariable1.Text = ""
            txtVariable2.Text = ""
            txtVariable3.Text = ""
        End If




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function Time1(ByVal vF As String, ByVal vI As String, ByVal a As String) As String
        Dim convertvF As Boolean
        Dim convertvI As Boolean
        Dim converta As Boolean

        convertvF = IsNumeric(vF)
        convertvI = IsNumeric(vI)
        converta = IsNumeric(a)

        If convertvF = True And convertvI = True And converta = True And ZeroAll(vF, vI, a) = True Then
            Return ((CDbl(vF) - CDbl(vI)) / (CDbl(a))).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Time2(ByVal vF As String, ByVal vI As String, ByVal d As String) As String
        Dim convertvF As Boolean
        Dim convertvI As Boolean
        Dim convertd As Boolean

        convertvF = IsNumeric(vF)
        convertvI = IsNumeric(vI)
        convertd = IsNumeric(d)

        If convertvF = True And convertvI = True And convertd = True And ZeroAll(vF, vI, d) = True Then
            Return ((CDbl(d)) / ((CDbl(vF) + CDbl(vI)) / 2)).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Time3(ByVal vF As String, ByVal a As String, ByVal d As String) As String
        Dim convertvF As Boolean
        Dim converta As Boolean
        Dim convertd As Boolean

        convertvF = IsNumeric(vF)
        converta = IsNumeric(a)
        convertd = IsNumeric(d)

        If convertvF = True And converta = True And convertd = True And ZeroAll(vF, a, d) = True Then
            If CDbl(a) = 0 Then
                Return (CDbl(d) / CDbl(vF)).ToString
            Else
                Return (((-1 * CDbl(vF)) + Math.Sqrt((CDbl(vF) * CDbl(vF)) - 2 * CDbl(a) * CDbl(d))) / (CDbl(a) * -1)).ToString + " s or " + (((-1 * CDbl(vF)) - Math.Sqrt((CDbl(vF) * CDbl(vF)) - 2 * CDbl(a) * CDbl(d))) / (CDbl(a) * -1)).ToString
            End If
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Time4(ByVal vI As String, ByVal a As String, ByVal d As String) As String
        Dim convertvI As Boolean
        Dim converta As Boolean
        Dim convertd As Boolean

        convertvI = IsNumeric(vI)
        converta = IsNumeric(a)
        convertd = IsNumeric(d)

        If convertvI = True And converta = True And convertd = True And ZeroAll(vI, a, d) = True Then
            If CDbl(a) = 0 Then
                Return (CDbl(d) / CDbl(vI)).ToString
            Else
                Return (((-1 * CDbl(vI)) + Math.Sqrt((CDbl(vI) * CDbl(vI)) + 2 * CDbl(a) * CDbl(d))) / (CDbl(a))).ToString + " s or " + (((-1 * CDbl(vI)) - Math.Sqrt((CDbl(vI) * CDbl(vI)) + 2 * CDbl(a) * CDbl(d))) / (CDbl(a))).ToString
            End If
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Displacement1(ByVal vF As String, ByVal vI As String, ByVal a As String) As String
        Dim convertvF As Boolean
        Dim convertvI As Boolean
        Dim converta As Boolean

        convertvF = IsNumeric(vF)
        convertvI = IsNumeric(vI)
        converta = IsNumeric(a)

        If convertvF = True And convertvI = True And converta = True And ZeroAll(vF, vI, a) = True Then
            Return ((((CDbl(vF)) * (CDbl(vF))) - ((CDbl(vI)) * (CDbl(vI)))) / (2 * CDbl(a))).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Displacement2(ByVal vF As String, ByVal vI As String, ByVal t As String) As String
        Dim convertvF As Boolean
        Dim convertvI As Boolean
        Dim convertt As Boolean

        convertvF = IsNumeric(vF)
        convertvI = IsNumeric(vI)
        convertt = IsNumeric(t)

        If convertvF = True And convertvI = True And convertt = True And ZeroAll(vF, vI, t) = True Then
            Return (((CDbl(vF) + CDbl(vI)) / 2) * CDbl(t)).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Displacement3(ByVal vF As String, ByVal a As String, ByVal t As String) As String
        Dim convertvF As Boolean
        Dim converta As Boolean
        Dim convertt As Boolean

        convertvF = IsNumeric(vF)
        converta = IsNumeric(a)
        convertt = IsNumeric(t)

        If convertvF = True And converta = True And convertt = True And ZeroAll(vF, a, t) = True Then
            Return (CDbl(vF) * CDbl(t)) - (0.5 * CDbl(a) * CDbl(t) * CDbl(t)).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Displacement4(ByVal vI As String, ByVal a As String, ByVal t As String) As String
        Dim convertvI As Boolean
        Dim converta As Boolean
        Dim convertt As Boolean

        convertvI = IsNumeric(vI)
        converta = IsNumeric(a)
        convertt = IsNumeric(t)

        If convertvI = True And converta = True And convertt = True And ZeroAll(vI, a, t) = True Then
            Return (CDbl(vI) * CDbl(t)) + (0.5 * CDbl(a) * CDbl(t) * CDbl(t)).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Acceleration1(ByVal vF As String, ByVal vI As String, ByVal a As String) As String
        Dim convertvF As Boolean
        Dim convertvI As Boolean
        Dim converta As Boolean

        convertvF = IsNumeric(vF)
        convertvI = IsNumeric(vI)
        converta = IsNumeric(a)

        If convertvF = True And convertvI = True And converta = True And ZeroAll(vF, vI, a) = True Then
            Return (((CDbl(vF) * CDbl(vF)) - (CDbl(vI) * CDbl(vI))) / (2 * CDbl(a))).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Acceleration2(ByVal vF As String, ByVal vI As String, ByVal t As String) As String
        Dim convertvF As Boolean
        Dim convertvI As Boolean
        Dim convertt As Boolean

        convertvF = IsNumeric(vF)
        convertvI = IsNumeric(vI)
        convertt = IsNumeric(t)

        If convertvF = True And convertvI = True And convertt = True And ZeroAll(vF, vI, t) = True Then
            Return ((CDbl(vF) - CDbl(vI)) / CDbl(t)).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Acceleration3(ByVal vF As String, ByVal d As String, ByVal t As String) As String
        Dim convertvF As Boolean
        Dim convertd As Boolean
        Dim convertt As Boolean

        convertvF = IsNumeric(vF)
        convertd = IsNumeric(d)
        convertt = IsNumeric(t)

        If convertvF = True And convertd = True And convertt = True And ZeroAll(vF, d, t) = True Then
            Return ((CDbl(d) - (CDbl(vF) * CDbl(t))) / (CDbl(t) * CDbl(t) * 0.5 * -1)).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function Acceleration4(ByVal vI As String, ByVal d As String, ByVal t As String) As String
        Dim convertvI As Boolean
        Dim convertd As Boolean
        Dim convertt As Boolean

        convertvI = IsNumeric(vI)
        convertd = IsNumeric(d)
        convertt = IsNumeric(t)

        If convertvI = True And convertd = True And convertt = True And ZeroAll(vI, d, t) = True Then
            Return ((CDbl(d) - (CDbl(vI) * CDbl(t))) / (CDbl(t) * CDbl(t) * 0.5)).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function VelocityInitial1(ByVal vF As String, ByVal a As String, ByVal d As String) As String
        Dim convertvF As Boolean
        Dim converta As Boolean
        Dim convertd As Boolean

        convertvF = IsNumeric(vF)
        converta = IsNumeric(a)
        convertd = IsNumeric(d)

        If convertvF = True And converta = True And convertd = True And ZeroAll(vF, a, d) = True Then
            Return (Math.Sqrt(Math.Abs((CDbl(vF) * (CDbl(vF)) - 2 * CDbl(a) * CDbl(d))))).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function VelocityInitial2(ByVal vF As String, ByVal a As String, ByVal t As String) As String
        Dim convertvF As Boolean
        Dim converta As Boolean
        Dim convertt As Boolean

        convertvF = IsNumeric(vF)
        converta = IsNumeric(a)
        convertt = IsNumeric(t)

        If convertvF = True And converta = True And convertt = True And ZeroAll(vF, a, t) = True Then
            Return (CDbl(vF) - (CDbl(a) * CDbl(t))).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function VelocityInitial3(ByVal vF As String, ByVal d As String, ByVal t As String) As String
        Dim convertvF As Boolean
        Dim convertd As Boolean
        Dim convertt As Boolean

        convertvF = IsNumeric(vF)
        convertd = IsNumeric(d)
        convertt = IsNumeric(t)

        If convertvF = True And convertd = True And convertt = True And ZeroAll(vF, d, t) = True Then
            Return ((2 * (CDbl(d) / CDbl(t))) - CDbl(vF)).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function VelocityInitial4(ByVal a As String, ByVal d As String, ByVal t As String) As String
        Dim converta As Boolean
        Dim convertd As Boolean
        Dim convertt As Boolean

        converta = IsNumeric(a)
        convertd = IsNumeric(d)
        convertt = IsNumeric(t)

        If converta = True And convertd = True And convertt = True And ZeroAll(a, d, t) = True Then
            Return ((CDbl(d) - (0.5 * CDbl(a) * CDbl(t) * CDbl(t))) / CDbl(t))
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function VelocityFinal1(ByVal vI As String, ByVal a As String, ByVal d As String) As String
        Dim convertvI As Boolean
        Dim converta As Boolean
        Dim convertd As Boolean

        convertvI = IsNumeric(vI)
        converta = IsNumeric(a)
        convertd = IsNumeric(d)

        If convertvI = True And converta = True And convertd = True And ZeroAll(vI, a, d) = True Then
            Return (Math.Sqrt(Math.Abs((CDbl(vI) * (CDbl(vI)) + 2 * CDbl(a) * CDbl(d))))).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function VelocityFinal2(ByVal vI As String, ByVal a As String, ByVal t As String) As String
        Dim convertvI As Boolean
        Dim converta As Boolean
        Dim convertt As Boolean

        convertvI = IsNumeric(vI)
        converta = IsNumeric(a)
        convertt = IsNumeric(t)

        If convertvI = True And converta = True And convertt = True And ZeroAll(vI, a, t) = True Then
            Return (CDbl(vI) + (CDbl(a) * CDbl(t))).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function VelocityFinal3(ByVal vI As String, ByVal d As String, ByVal t As String) As String
        Dim convertvI As Boolean
        Dim convertd As Boolean
        Dim convertt As Boolean

        convertvI = IsNumeric(vI)
        convertd = IsNumeric(d)
        convertt = IsNumeric(t)

        If convertvI = True And convertd = True And convertt = True And ZeroAll(vI, d, t) = True Then
            Return ((2 * (CDbl(d) / CDbl(t))) - CDbl(vI)).ToString
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function VelocityFinal4(ByVal a As String, ByVal d As String, ByVal t As String) As String
        Dim converta As Boolean
        Dim convertd As Boolean
        Dim convertt As Boolean

        converta = IsNumeric(a)
        convertd = IsNumeric(d)
        convertt = IsNumeric(t)

        If converta = True And convertd = True And convertt = True And ZeroAll(a, d, t) = True Then
            Return ((CDbl(d) + (0.5 * CDbl(a) * CDbl(t) * CDbl(t))) / CDbl(t))
        Else
            Return "This is not a number, check your variables"
        End If

    End Function

    Function ZeroAll(ByVal var1 As String, ByVal var2 As String, ByVal var3 As String) As Boolean
        If var1 = "0" And var2 = "0" And var3 = "0" Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
