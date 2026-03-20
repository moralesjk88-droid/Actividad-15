// See https://aka.ms/new-console-template for more information

Dictionary<int, Producto> producto = new Dictionary<int, Producto>();
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

    }



}
while (opcion!=11);




public class Producto
{
    public int codigo;
    public string nombre;
    public double precio;
    public double cantidadExistencia;



}
