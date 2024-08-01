Imports System.Numerics
Imports Microsoft.Office.Interop.Excel

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alpha As Complex
        Dim alpha_square As Complex
        Dim alphaphase, alphasquare_phase As Double
        Dim PPSmag, PPSang, NPSmag, NPSang, ZPSmag, ZPSang As Double
        Dim Ia_mag, Ib_mag, Ic_mag As Integer
        Dim Ia_ph, Ib_ph, Ic_ph As Double
        Dim Ia_Comp, Ib_Comp, Ic_Comp As Complex
        Dim PPS, NPS, ZPS As Complex

        Ia_mag = TextBox_Iamag.Text
        Ib_mag = TextBox_Ibmag.Text
        Ic_mag = TextBox_Icmag.Text
        Ia_ph = TextBox_Iaph.Text
        Ib_ph = TextBox_Ibph.Text
        Ic_ph = TextBox_Icph.Text

        alphaphase = 120 * (Math.PI / 180)
        alphasquare_phase = 240 * (Math.PI / 180)

        alpha = Complex.FromPolarCoordinates(1, alphaphase)
        alpha_square = Complex.FromPolarCoordinates(1, alphasquare_phase)

        Ia_Comp = Complex.FromPolarCoordinates(Ia_mag, Ia_ph * (Math.PI / 180))
        Ib_Comp = Complex.FromPolarCoordinates(Ib_mag, Ib_ph * (Math.PI / 180))
        Ic_Comp = Complex.FromPolarCoordinates(Ic_mag, Ic_ph * (Math.PI / 180))

        PPS = (Ia_Comp + (alpha * Ib_Comp) + (alpha_square * Ic_Comp)) / 3
        'Console.WriteLine(Ia_Comp)
        'Console.WriteLine(Ib_Comp)
        'Console.WriteLine(Ic_Comp)
        'Console.WriteLine(PPS.Real)
        NPS = (Ia_Comp + (alpha_square * Ib_Comp) + (alpha * Ic_Comp)) / 3
        ZPS = (Ia_Comp + Ib_Comp + Ic_Comp) / 3

        PPSmag = RectoPolarMag(PPS)
        PPSang = RectoPolarAngle(PPS)
        NPSmag = RectoPolarMag(NPS)
        NPSang = RectoPolarAngle(NPS)
        ZPSmag = RectoPolarMag(ZPS)
        ZPSang = 0

        Console.WriteLine(PPSmag)
        Console.WriteLine(NPSmag)
        Console.WriteLine(ZPSmag)


        TextBoxPPS.Text = PPSmag
        TextBoxNPS.Text = NPSmag
        TextBoxZPS.Text = ZPSmag

    End Sub

    Function RectoPolarMag(comp As Complex) As Double
        Dim mag As Double
        Console.WriteLine(comp)
        Console.WriteLine(comp.Real ^ 2)
        Console.WriteLine(comp.Imaginary ^ 2)
        Console.WriteLine(Math.Round(Math.Sqrt((comp.Real ^ 2) + (comp.Imaginary ^ 2)), 3))
        mag = Math.Round(Math.Sqrt((comp.Real ^ 2) + (comp.Imaginary ^ 2)), 3)
        Return mag
    End Function

    Function RectoPolarAngle(comp As Complex) As Double
        Dim angle As Double
        angle = Math.Atan((comp.Imaginary) / comp.Real)
        Console.WriteLine(angle)
        Return angle
    End Function


End Class
