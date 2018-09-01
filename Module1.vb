Module Module1

    Dim cant_par As Integer
    Dim total_suma As Integer
    Dim cant_impar As Integer

    Dim valores() As Integer
    Dim valores_pares As New ArrayList
    Dim valores_impares As New ArrayList

    Sub Main()

        Console.Write("¿Cúantos datos va a agregar? ")

        For index = 1 To Integer.Parse(Console.ReadLine())
            Console.WriteLine("")
            Console.Write("Introduzca el valor #" + index.ToString + ": ")
            ReDim Preserve valores(index)
            valores(index) = Integer.Parse(Console.ReadLine())
            total_suma += valores(index)
            If (valores(index) Mod 2 = 0) Then
                valores_pares.Add(valores(index))
            Else
                valores_impares.Add(valores(index))
            End If
        Next

        cant_par = valores_pares.Count()
        cant_impar = valores_impares.Count()

        Console.Clear()

        Console.WriteLine("RESULTADOS: ")
        Console.WriteLine("")
        Console.WriteLine("Total de la Suma de los Elementos Ingresados: " + total_suma.ToString)

        Console.WriteLine("")
        Console.WriteLine("Elementos Pares: [" + cant_par.ToString + "]")
        For i = LBound(valores_pares.ToArray()) To UBound(valores_pares.ToArray())
            Console.WriteLine(valores_pares(i))
        Next

        Console.WriteLine("")
        Console.WriteLine("Elementos Impares: [" + cant_impar.ToString + "]")
        For i = LBound(valores_impares.ToArray()) To UBound(valores_impares.ToArray())
            Console.WriteLine(valores_impares(i))
        Next

        Console.ReadLine()

    End Sub

End Module
