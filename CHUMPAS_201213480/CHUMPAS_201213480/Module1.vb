Module Module1
    Public Const mano_obra_small = 65.5
    Public Const mano_obra_medium = 85.99
    Public Const mano_obra_large = 99.99

    Public Const precio_yarda_algodon = 15
    Public Const precio_yarda_seda = 23.99
    Public Const precio_yarda_lona = 30.99

    Public Const cantida_yarda_small = 2
    Public Const cantidad_yarda_medium = 2.5
    Public Const cantidad_yarda_large = 3
    Public precio_costo = 0
    Public precio_venta = 0
    Public Function calcular(Material As String, tamaño As String, cantidad As Double)
        Select Case tamaño
            Case "smal"
                precio_costo = cantidad * cantida_yarda_small + mano_obra_small * yarda_algodon
            Case "medium"
                precio_costo = cantidad * cantidad_yarda_medium + mano_obra_medium
            Case "large"
                precio_costo = cantidad * cantidad_yarda_large + mano_obra_large

                Select Case Material
                    Case " algodon "
                        precio_costo = cantidad * mano_obra_small + cantidad * 


        End Select
End Module
