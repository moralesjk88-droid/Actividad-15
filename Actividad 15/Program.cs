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
            Console.Write("Cuantos Productos desea ingresar:_ ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Producto e = new Producto();
                Console.WriteLine($"\n Producto {i + 1} ");
                Console.Write("Codigo del Producto:_ ");
                e.codigo = int.Parse(Console.ReadLine());
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
                    e.precio = double.Parse(Console.ReadLine());
                    Console.Write("Cantidad:_ ");
                    e.cantidadExistencia = int.Parse(Console.ReadLine());

                }
                if (e.precio < 0 || e.cantidadExistencia < 0)
                {
                    Console.WriteLine(" No puede ser menor a cero");
                    break;

                }
                inventario.Add(e.codigo, e);
                Console.ReadKey();

            }

            break;
        case 2:
            Console.WriteLine("Modificar Producto");

            Console.Write("Codigo a modificar:_");

            int CodiogoModificar = int.Parse(Console.ReadLine());
            if (inventario.ContainsKey(CodiogoModificar))
            {
                Producto modificar = inventario[CodiogoModificar];
                Console.Write("Nombre:_");
                modificar.nombre = Console.ReadLine();
                Console.Write("Precio:_ ");
                modificar.precio = double.Parse(Console.ReadLine());
                Console.Write("Cantidad:_");
                modificar.cantidadExistencia = int.Parse(Console.ReadLine());
                if (modificar.precio < 0 || modificar.cantidadExistencia < 0)
                {
                    Console.WriteLine(" No puede ser menor a cero");
                    break;

                }
                Console.WriteLine("Producto Modificado con exito");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("El producto no exite");
                Console.ReadKey();
            }
            break;
        case 3:
            Console.WriteLine("Eliminar Producto");
            Console.Write("Codigo del producto a eliminar");
            int eliminar = int.Parse(Console.ReadLine());
            if (inventario.ContainsKey(eliminar))
            {
                inventario.Remove(eliminar);
                Console.WriteLine("Producto ELiminado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadKey();
            }
            break;
            case 4:
            Console.WriteLine("Buscar Producto");
            Console.Write("Codigo del producto:_");
            int BuscarCodigo=int.Parse(Console.ReadLine());
            if (inventario.ContainsKey(BuscarCodigo))
            {
                Producto buscar=inventario[BuscarCodigo];
                Console.WriteLine("Producto encontrado");
                inventario[BuscarCodigo]. MostrarDatos();
                Console.ReadKey() ;
            }
            else
            {
                Console.WriteLine("Codigo no encontrado");
            }
            break;
            case 5:
            Console.WriteLine("Todos los Productos Regisrtados");
            if (inventario.Count==0)
            {
                Console.WriteLine("No se ha encontradoproductos");
                Console.ReadKey();
            }
            else
            {
                foreach (var item in inventario)
            {
                    Console.WriteLine("\nInventario");
                    item.Value.MostrarDatos();
                    Console.ReadKey();
                 }
            }
            
            break;
            case 6:
            Console.WriteLine("Registro de venta");

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
        Console.WriteLine($"Cantidad Existencia:_ {cantidadExistencia}");
      
    }


}
