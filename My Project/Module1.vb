
Module PolarToComplexConverter

    Sub Main()
        ' Example usage
        Dim magnitude As Double = 5.0
        Dim angle As Double = 30.0

        Dim complexNumber As String = PolarToComplex(magnitude, angle)
        Console.WriteLine("The complex form is: " & complexNumber)
    End Sub

    Function PolarToComplex(ByVal magnitude As Double, ByVal angle As Double) As String
        ' Convert angle from degrees to radians
        Dim angleInRadians As Double = angle * Math.PI / 180

        ' Calculate the real and imaginary parts
        Dim realPart As Double = magnitude * Math.Cos(angleInRadians)
        Dim imaginaryPart As Double = magnitude * Math.Sin(angleInRadians)

        ' Create the complex number string
        Dim complexNumber As String
        If imaginaryPart >= 0 Then
            complexNumber = realPart.ToString() & " + " & imaginaryPart.ToString() & "i"
        Else
            complexNumber = realPart.ToString() & " - " & Math.Abs(imaginaryPart).ToString() & "i"
        End If

        ' Return the complex number
        Return complexNumber
    End Function

End Module


