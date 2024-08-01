﻿Imports System.Numerics

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
        NPS = (Ia_Comp + (alpha_square * Ib_Comp) + (alpha * Ic_Comp)) / 3
        ZPS = (Ia_Comp + Ib_Comp + Ic_Comp) / 3

        PPSmag = RectoPolarMag(PPS)
        PPSang = RectoPolarAngle(PPS)
        NPSmag = RectoPolarMag(NPS)
        NPSang = RectoPolarAngle(NPS)
        ZPSmag = RectoPolarMag(ZPS)
        ZPSang = RectoPolarAngle(ZPS)

        TextBoxPPS.Text = PPSmag
        TextBoxNPS.Text = NPSmag
        TextBoxZPS.Text = ZPSmag

        AngleTextBoxPPS.Text = PPSang
        AngleTextBoxNPS.Text = NPSang
        AngleTextBoxZPS.Text = ZPSang

    End Sub

    Function RectoPolarMag(comp As Complex) As Double
        Dim mag As Double
        mag = Math.Round(Math.Sqrt((comp.Real ^ 2) + (comp.Imaginary ^ 2)), 3)
        Return mag
    End Function

    Function RectoPolarAngle(comp As Complex) As Double
        Dim angle As Double
        angle = Math.Round((Math.Atan2(comp.Imaginary, comp.Real)) * (180 / Math.PI), 1)
        Return angle
    End Function


End Class
