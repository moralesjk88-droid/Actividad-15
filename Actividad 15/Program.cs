// See https://aka.ms/new-console-template for more information

Dictionary<int, Producto> inventario = new Dictionary<int, Producto>();
int opcion;

do
{
    Console.Clear();
    Console.WriteLine("Menu Producto");
    Console.WriteLine("1. Agregar Producto");
    Console.WriteLine("2. Modificar Producto");
    Console.WriteLine("3. Eliminar Producto");
    Console.WriteLine("4. Buscar producto");
    Console.WriteLine("5. Mostrar Productos");
    Console.WriteLine("6. Registrar venta");
    Console.WriteLine("7. Registrar compra o ingreso de inventario ");
    Console.WriteLine("8. Mostrar el producto más caro");
    Console.WriteLine("9. Mostrar el producto con menor exixtencia");
    Console.WriteLine("10. Mostrar EL valor total del inventario");
    Console.WriteLine("11. salir");
    opcion=int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Agregar producto");
            Console.Write("Cuantos Productos desea ingresar");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Producto e = new Producto();
                Console.WriteLine($"\n Producto {i + 1} ");
                Console.Write("Codigo del Producto:_ ");
                e.codigo=int.Parse(Console.ReadLine());
                if (inventario.ContainsKey(e.codigo))
                {
                    Console.WriteLine("Codigo ya existente");
                    break;
                }
                else
                {
                    Console.Write("Nombre del producto:_ ");
                    e.nombre = Console.ReadLine();
                    Console.Write("Precio:_");
                    e.precio=double.Parse(Console.ReadLine());
                    Console.Write("Cantidad:_ ");
                    e.cantidadExistencia=int.Parse(Console.ReadLine());
                    
                }
                if (e.precio<=0|| e.cantidadExistencia<=0)
                {
                        Console.WriteLine(" No puede ser menor a cero");
                    break;
               
                }
                inventario.Add(e.codigo,e);
               
            }

            break;
            case 2:
            break;
                case 3:
            break;
            case 4:
            break;
            case 5:
            break;
            case 6:
            break;
        case 7:
            break;
            case 8:
            break;
            case 9:
            break;
            case 10:
            break;
            case 11:
            Console.WriteLine("¡Hasta Pronto!.");
            Console.WriteLine("Preciona cualquir letra para salir");
            Console.ReadKey();
            break;
            default:
            Console.WriteLine("Opcion no valida, Precione cualquier letra");
            Console.ReadKey();
            break;

    }



}
while (opcion!=11);




public class Producto
{
    public int codigo;
    public string nombre;
    public double precio;
    public double cantidadExistencia;

    public void MostrarDatos()
    {
        Console.WriteLine($"Codigo:_ {codigo}");
        Console.WriteLine($" Nombre:_ {nombre}");
        Console.WriteLine($"Precio:_ {precio:F2}");
        Console.WriteLine($"Cantidad Exixtencia:_ {cantidadExistencia}");
      
    }


}
