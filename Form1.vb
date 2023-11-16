

' This program takes the values in textfile ExamScores.txt and diplays its total number of scores, mean, standard deviation, and a table of
' each score and the curve letter grade it earns in dgvDisplayGrades


Public Class frmCurveGrades

    ' Creates a structure to be used in displaying the numeric score and letter grade in dgvDisplayGrades
    Structure CurvedScores
        Dim numberScore As Integer
        Dim letterGrade As Char
    End Structure

    Dim earnedGrades(13) As CurvedScores ' Declares an array with the data type of the structure above (CurvedScores)

    ' Sub handles the button clicked event for the form 
    Private Sub btnAnalyzeGrades_Click(sender As Object, e As EventArgs) Handles btnAnalyzeGrades.Click

        ' Reads data in the txtfile ExamScores.txt and assigns it to a temporary string array (will be copied into a double array)
        Dim tempExamArray() As String = IO.File.ReadAllLines("ExamScores.txt")


        Dim numExams As Integer = tempExamArray.Length ' Finds length of the array (used to determine array sizes and for loop itterations)

        Dim examScores(numExams) As Double ' Declares array with datatype double and same length as tempExamArray()

        ' For loop used to covert and copy data from tempExamArray() to examScores()
        For i As Integer = 0 To (numExams - 1)
            examScores(i) = CDbl(tempExamArray(i))
        Next

        ' Assigns sumExams equal to the value returned from CalculateSum(examScores) where sum of all array element was returned
        Dim sumExams As Double = CalculateSum(examScores)

        ' Assigns meanExams equal to CalculateMean(numExams, sumExams) where mean of all the exam scores was returned
        Dim meanExams As Double = CalculateMean(numExams, sumExams)

        ' Assigns standardDeviationExams = CalculateStandardDeviation(examScores, meanExams, numExams) where SD of array values is calculated
        Dim standardDeviationExams As Double = CalculateStandardDeviation(examScores, meanExams, numExams) ' 

        Dim examLetterGrade() As String ' Creates string array for the letter grades students earned 
        ' Makes examLetterGrade referece array of curved letter grades earned returned from CreateLetterGradeArray where they were
        ' calculated using standard deviation 
        examLetterGrade = CreateLetterGradeArray(examScores, meanExams, standardDeviationExams)

        ' Displays each value into their respective txtboxes and properly formats them
        txtNumExams.Text = numExams
        txtMean.Text = meanExams.ToString("N2")
        txtStandardDeviation.Text = standardDeviationExams.ToString("N2")

        ' Displays contents of DisplayGrades where both arrays are used to display thier respective information in dgvDisplayGrades
        DisplayGrades(examScores, examLetterGrade, numExams)

    End Sub


    ' Fuction CalculateSum uses the array examScores() and adds each value of the array together to find the arrays sum 
    Function CalculateSum(examScores() As Double) As Double

        Dim sumExams As Double = 0 ' Initalizes var used to return sum outside loop and sets = 0 

        ' For loop goes through each value in array and each itteration adds the value to total 
        For i As Integer = 0 To (examScores.Count - 1)
            sumExams += examScores(i)
        Next

        Return sumExams ' Now contains total sum of array and is returned to btn click sub 

    End Function

    ' Fuction CalculateMean calculates and returns the mean of the array using the sum and size of the array
    Function CalculateMean(numExams As Double, sumExams As Double) As Double

        Dim meanExams As Double
        meanExams = sumExams / numExams ' Calculates mean by doing formula (sum of array / # of values in array)

        Return meanExams ' Returns calculated mean to btn click sub

    End Function

    ' Function CalculateStandardDeviation calculated the Standard Deviation of the exam scores in the array 
    Function CalculateStandardDeviation(examScores() As Double, meanExams As Double, numExams As Integer) As Double

        ' EQUATION FOR STANDARD DEVIATION 
        ' s = Standard Deviation, m = mean, n = length of array 
        ' S = √((examScores(0)-m)^2 + (examScores(1)-m)^2...)) / (n)


        Dim numeratorSD As Double = 0 ' Initalizes var for the numerator of the SD equation
        Dim variance As Double ' varience is part of equation inside square root (numeratorSD / n)
        Dim standardDeviationExams As Double ' SD = square root of the varience

        For i As Integer = 0 To (numExams - 1)

            ' Variable for calculation done to each individual element before being added to total of numerator 
            Dim singleElementCalc As Double
            singleElementCalc = Math.Pow(examScores(i) - meanExams, 2)

            numeratorSD += singleElementCalc ' Adds calculated values of each elements together (at end has num total)
        Next

        variance = numeratorSD / numExams ' Calculates varience by dividing the numerator calculated above by the the length of the array

        standardDeviationExams = Math.Sqrt(variance) ' Finds SD by taking sqare root of the vrience calculated above


        Return standardDeviationExams ' Returns the fully calculated SD

    End Function

    ' Function CreateLetterGradeArray uses the array of numeric scores to find curved letter grade each score earned
    Function CreateLetterGradeArray(numericScores() As Double, meanExams As Double, standardDeviationExams As Double) As String()


        Dim numExams As Integer = numericScores.Length ' Calculates size of the arrays
        Dim examLetterGrade(numExams) As String ' Declares String array for examLetterGrade


        ' Declares variables for the upper and lower limits of each curved letter grade 
        Dim aLowerCuttOff As Double = meanExams + (1.5 * standardDeviationExams)

        Dim bUpperCutoff As Double = meanExams + (1.5 * standardDeviationExams)
        Dim bLowerCuttOff As Double = meanExams + (0.5 * standardDeviationExams)

        Dim cUpperCutoff As Double = meanExams + (0.5 * standardDeviationExams)
        Dim cLowerCuttOff As Double = meanExams - (0.5 * standardDeviationExams)

        Dim dUpperCutoff As Double = meanExams - (0.5 * standardDeviationExams)
        Dim dLowerCuttOff As Double = meanExams - (1.5 * standardDeviationExams)

        Dim fUpperCutoff As Double = meanExams - (1.5 * standardDeviationExams)

        ' Uses for loop, scores of the double array, & limits calculated above to determine grade each score and add letter to the String array
        For i As Integer = 0 To (numExams - 1)

            If numericScores(i) >= aLowerCuttOff Then
                examLetterGrade(i) = "A"

            ElseIf numericScores(i) >= bLowerCuttOff And numericScores(i) < bUpperCutoff Then
                examLetterGrade(i) = "B"

            ElseIf numericScores(i) >= cLowerCuttOff And numericScores(i) < cUpperCutoff Then
                examLetterGrade(i) = "C"

            ElseIf numericScores(i) >= dLowerCuttOff And numericScores(i) < dUpperCutoff Then
                examLetterGrade(i) = "D"

            ElseIf numericScores(i) < fUpperCutoff Then
                examLetterGrade(i) = "F"

            End If

        Next

        Return examLetterGrade ' Returns the filled string array back to the btn clicked event sub 


    End Function

    ' Sub DisplayGrades uses Double array of numeric Scores and string array of letter grades to display the info of each into dgvDisplayGrades
    Sub DisplayGrades(examNumericScores() As Double, examLetterGrade() As String, numExams As Integer)

        ' For loop assigns the values of the two passed array into the array earnedGrades with datatype of Structure CurvedScores (declared
        ' at top of program) 
        For i As Integer = 0 To (numExams - 1)
            earnedGrades(i).numberScore = examNumericScores(i)
            earnedGrades(i).letterGrade = examLetterGrade(i)
        Next

        ' Uses structure array earnedGrades in query to retrieve data to be display properly 
        Dim gradesQuery = From earned In earnedGrades
                          Select Score = earned.numberScore, Grade = earned.letterGrade

        ' Uses query and DataSource to display information into dgvDisplayGrades
        dgvDisplayGrades.DataSource = gradesQuery.ToList()

    End Sub
End Class
