Public Class Form2
    Dim firstnum As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim operators As String
    Const mcTax_Rate = 0.75
    Const labour = 40
    Const travel = 1
    Const plastic = 2
    Const copper = 3
    Const chrome = 4
    Dim labourhours As Double = 0
    Dim travelmiles As Double = 0
    Dim plasticmeteres As Double = 0
    Dim coppermeteres As Double = 0
    Dim chromemeteres As Double = 0
    Dim Tax As Double
    Dim Total As Double
    Dim Subtotal As Double
    Dim labouramount As Double
    Dim plasticamount As Double
    Dim copperamount As Double
    Dim chromeamount As Double
    Dim travelamount As Double
    Dim sapi
    Dim txt As Object


    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "C:\Windows\System32\osk.exe"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "7"
        Else
            txtDisplay.Text = txtDisplay.Text & "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "8"
        Else
            txtDisplay.Text = txtDisplay.Text & "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "9"
        Else
            txtDisplay.Text = txtDisplay.Text & "9"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "4"
        Else
            txtDisplay.Text = txtDisplay.Text & "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "5"
        Else
            txtDisplay.Text = txtDisplay.Text & "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "6"
        Else
            txtDisplay.Text = txtDisplay.Text & "6"
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "1"
        Else
            txtDisplay.Text = txtDisplay.Text & "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "2"
        Else
            txtDisplay.Text = txtDisplay.Text & "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "3"
        Else
            txtDisplay.Text = txtDisplay.Text & "3"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "0"
        Else
            txtDisplay.Text = txtDisplay.Text & "0"
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        firstnum = txtDisplay.Text
        txtDisplay.Text = ""
        Operators = "+"
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        firstnum = txtDisplay.Text
        txtDisplay.Text = ""
        Operators = "-"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        firstnum = txtDisplay.Text
        txtDisplay.Text = ""
        Operators = "/"
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        firstnum = txtDisplay.Text
        txtDisplay.Text = ""
        Operators = "*"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnPlusMinus_Click(sender As Object, e As EventArgs) Handles btnPlusMinus.Click
        If (txtDisplay.Text.Contains("-")) Then
            txtDisplay.Text = txtDisplay.Text.Remove(0, 1)
        Else
            txtDisplay.Text = "-" + txtDisplay.Text
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If InStr(txtDisplay.Text, ".") = 0 Then
            txtDisplay.Text = txtDisplay.Text + "."
        End If
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secondnum = txtDisplay.Text
        If Operators = "+" Then
            answer = firstnum + secondnum
            txtDisplay.Text = answer
        ElseIf Operators = "-" Then
            answer = firstnum - secondnum
            txtDisplay.Text = answer
        ElseIf Operators = "*" Then
            answer = firstnum * secondnum
            txtDisplay.Text = answer
        ElseIf Operators = "/" Then
            answer = firstnum / secondnum
            txtDisplay.Text = answer
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        labourhours = Val(txtLabour.Text)
        travelmiles = Val(txtTravel.Text)
        plasticmeteres = Val(txtPlastic.Text)
        coppermeteres = Val(txtCopper.Text)
        chromemeteres = Val(txtChrome.Text)

        labouramount = labouramount * labourhours
        plasticamount = plastic * plasticmeteres
        copperamount = copper * coppermeteres
        chromeamount = chrome * chromemeteres
        travelamount = travel * travelmiles

        Subtotal = Subtotal + labouramount + travelamount + plasticamount + copperamount + chromeamount
        Tax = cFindTax(Subtotal)
        Total = Subtotal + Tax


        txtSubtotal.Text = FormatCurrency(Subtotal)
        txtTax.Text = FormatCurrency(Tax)
        txtTotal.Text = FormatCurrency(Total)
        txtLabour.Focus()

        Dim sTravelTimeMiles As String = travelmiles
        Dim sWorkTimeHours As String = labourhours
        Dim sPlasticPipeMeters As String = plasticmeteres
        Dim sCopperPipeMeters As String = coppermeteres
        Dim sChromePipeMeters As String = chromemeteres
        Dim sSubtotal As String = (Subtotal)
        Dim sTax As String = (Tax)
        Dim sTotal As String = (Total)

        rtReceipt.AppendText("********************************************" + vbNewLine)
        rtReceipt.AppendText("Labour" + vbTab + txtLabour.Text + vbNewLine)
        rtReceipt.AppendText("Travel" + vbTab + txtTravel.Text + vbNewLine)
        rtReceipt.AppendText("Plastic" + vbTab + txtPlastic.Text + vbNewLine)
        rtReceipt.AppendText("Copper" + vbTab + txtCopper.Text + vbNewLine)
        rtReceipt.AppendText("Chrome" + vbTab + txtChrome.Text + vbNewLine)
        rtReceipt.AppendText("**************************" + vbNewLine)
        rtReceipt.AppendText("Tax" + vbTab + txtTax.Text + vbNewLine)
        rtReceipt.AppendText("Subtotal" + vbTab + txtSubtotal.Text + vbNewLine)
        rtReceipt.AppendText("Total" + vbTab + txtTotal.Text + vbNewLine)
        rtReceipt.AppendText("*************************************" + vbNewLine)
        rtReceipt.AppendText("****************Thank You For Your Purchase.****************" + vbNewLine)

    End Sub
    Private Function cfindtax(ByVal Amount As Double)
        cfindtax = Amount * mcTax_Rate


    End Function
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub rtReciept_TextChanged(sender As Object, e As EventArgs) Handles rtReceipt.TextChanged

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtChrome.Text = ""
        txtCopper.Text = ""
        txtLabour.Text = ""
        txtTravel.Text = ""
        txtPlastic.Text = ""
        txtTax.Text = ""
        txtSubtotal.Text = ""
        txtTotal.Text = ""

        rtReceipt.Clear()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to exit.", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(rtReceipt.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 0))
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOSK.Click
        Wow64DisableWow64FsRedirection(0)
        Process.Start(osk)
    End Sub

    Private Sub InternetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InternetToolStripMenuItem.Click
        Dim f3 As New Form3

        f3.Show()
    End Sub

    Private Sub HelpSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpSystemToolStripMenuItem.Click
        Dim helpfile As New Form4
        helpfile.Show()
    End Sub
End Class