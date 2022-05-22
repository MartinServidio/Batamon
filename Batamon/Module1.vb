Module Module1
    Dim CantMons As Integer = 0
    Dim Rival(CantMons) As Integer
    Dim Hechi(CantMons) As Integer
    Dim enfrentamientos(CantMons) As Integer

    Function batamon(Hechi, Rival) As Integer
        Dim victory As Integer = 0
        Dim ayu As Integer
        Dim ayu2 As Integer

        For k = 0 To CantMons
            enfrentamientos(k) = k + 1
        Next


        'Metodo de burbujeo para comparar el poder de la hechicera y rival,
        'para luego asi ordenar cuales enfrentamientos ganaria y tambien ordenar la lista de enfrentamientos.
        For v = 1 To CantMons
            For l = 0 To CantMons - 1
                If (Hechi(l) > Rival(v)) Or (Hechi(l) = Rival(v)) Then
                    ayu = Hechi(l + 1)
                    Hechi(l + 1) = Hechi(l)
                    Hechi(l) = ayu
                    ayu2 = enfrentamientos(l + 1)
                    enfrentamientos(l + 1) = enfrentamientos(l)
                    enfrentamientos(l) = ayu2
                End If
            Next
        Next

        For a = 0 To CantMons
            If (Hechi(a) > Rival(a)) Or (Hechi(a) = Rival(a)) Then
                victory += 1
            End If
        Next

        Return victory
    End Function


    Sub Main()
        Try
            Console.Write("Ingrese numero de monstruos: ")
            CantMons = Console.ReadLine()
            If CantMons < 1 And CantMons > 200000 Then
                Console.WriteLine("Numeros invalidos")
                Console.ReadKey()
            Else
                CantMons -= 1
            End If
        Catch ex As Exception
            Console.WriteLine("Caracter invalido")
            Console.ReadKey()
            End

        End Try


        ReDim Preserve Hechi(CantMons)
        ReDim Preserve Rival(CantMons)
        ReDim Preserve enfrentamientos(CantMons)


        Try
            Console.Write("Ingrese nivel de monstruos Hechicera: ")
            For i = 0 To CantMons
                Hechi(i) = Console.ReadLine()
                If Hechi(i) > 1000000 Then
                    Console.WriteLine("Numeros invalidos")
                    Console.ReadKey()
                End If
            Next

            Console.Write("Ingrese nivel de monstruos Rival: ")
            For i = 0 To CantMons
                Rival(i) = Console.ReadLine()
                If Rival(i) > 1000000 Then
                    Console.WriteLine("Numeros invalidos")
                    Console.ReadKey()
                    End
                End If
            Next

        Catch ex As Exception
            Console.WriteLine("Caracter invalido")
            Console.ReadKey()
            End
        End Try

        Console.WriteLine("El resultado es: ")
        Console.WriteLine(batamon(Hechi, Rival))
        For i = 0 To CantMons
            Console.Write(enfrentamientos(i))
            Console.Write("  ")
        Next
        Console.ReadKey()
    End Sub


End Module

