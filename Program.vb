Imports System

'ProjetosSimplesParaFixarSintaxeVBdotNET
Module Program
    Sub Main(args As String())
        Console.ForegroundColor = ConsoleColor.Red

        Console.WriteLine("Tabuada do 5")
        CalcsAndProgram.Tabuada5()
        Console.ReadKey()

        Console.WriteLine("Tabuada")
        CalcsAndProgram.TabuadaV2()
        Console.ReadKey()

        Console.WriteLine("~Tabela ascii de 33 a 126")
        CalcsAndProgram.Ascii()
        Console.ReadKey()

        Console.WriteLine("Numero de divisores")
        CalcsAndProgram.Divisores()
        Console.ReadKey()

    End Sub
End Module

Module CalcsAndProgram

    'Tabuada x5
    Sub Tabuada5()
        Dim calc As Integer

        For _i As Integer = 1 To 10
            calc = _i * 5
            Console.WriteLine("5 x" + _i.ToString + " = " + calc.ToString)
        Next

    End Sub

    'Tabuada + Input
    Sub TabuadaV2()

        Dim InputStr As String
        Dim calc, InputInt As Integer
        InputInt = 0


        Do
            Console.WriteLine("Digite um numero")
            InputStr = Console.ReadLine()
            Try
                InputInt = Convert.ToInt32(InputStr)
            Catch ex As Exception
                Console.WriteLine("Digite um numero valido")
            End Try
            If Not (InputInt = 0) Then Exit Do
        Loop


        For i As Integer = 1 To 10
            calc = InputInt * i
            Console.WriteLine(InputInt.ToString + " x " + i.ToString + " = " + calc.ToString)
        Next

    End Sub

    'Ascii
    Sub Ascii()

        Dim InputStr As String
        Dim InputInt As Integer


        For i As Integer = 33 To 53
            Console.WriteLine("Caracter: " + Chr(i) + "  Valor ascii:" + i.ToString)
        Next
        Console.ReadKey()

        For i As Integer = 54 To 74
            Console.WriteLine("Caracter: " + Chr(i) + "  Valor ascii:" + i.ToString)
        Next
        Console.ReadKey()

        For i As Integer = 75 To 95
            Console.WriteLine("Caracter: " + Chr(i) + "  Valor ascii:" + i.ToString)
        Next
        Console.ReadKey()

        For i As Integer = 96 To 126
            Console.WriteLine("Caracter: " + Chr(i) + "  Valor ascii:" + i.ToString)
        Next

        Do
            Do
                Console.WriteLine("Digite um numero para decobrir seu caracter correspondente")
                InputStr = Console.ReadLine()
                Try
                    InputInt = Convert.ToInt32(InputStr)
                Catch ex As Exception
                    Console.WriteLine("Digite um numero valido")
                End Try
                If Not InputInt = 0 Then Exit Do
            Loop

            If InputInt > 126 Or InputInt < 33 Then
                Console.WriteLine("Apenas entre 33~126")
            End If
            If InputInt > 32 And InputInt < 127 Then Exit Do
        Loop

        Console.WriteLine("Caracter: " + Chr(InputInt) + "  Valor ascii:" + InputInt.ToString)

    End Sub

    Sub Divisores()
        Dim resto As Double
        Dim InputStr As String
        Dim InputInt, _inputSave As Integer
        Dim NumDivisores As Integer

        Do
            Console.WriteLine("Digite um numero")
            InputStr = Console.ReadLine()
            Try
                InputInt = Convert.ToInt32(InputStr)
            Catch ex As Exception
                Console.WriteLine("Digite um numero valido")
            End Try
            If Not InputInt = 0 Then Exit Do
        Loop
        _inputSave = InputInt

        Do
            resto = InputInt Mod 2
            InputInt = InputInt / 2
            Console.WriteLine(InputInt.ToString + "/ 2 = " + InputInt.ToString)
            Console.WriteLine(_inputSave.ToString + " possui " + NumDivisores.ToString + " divisor/divisores")
            NumDivisores = NumDivisores + 1
            If Not resto = 0 Then Exit Do
        Loop
    End Sub

End Module