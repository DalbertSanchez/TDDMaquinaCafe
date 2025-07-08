using TDDMaquinaCafe.MaquinaCafe;

 Azucarero azucarero = new Azucarero(300);
 Vaso vasoPequeño = new Vaso(40, 1);
 Vaso vasoMediano = new Vaso(50, 2);
 Vaso vasoGrande = new Vaso(60, 3);
 Cafetera cafetera = new Cafetera(700);
Maquina maquinaCafe = new Maquina();

int tamanoVaso, cantidadCafe, cantidadAzucar;

Console.WriteLine("--------------------------------");
Console.WriteLine("!Maquina de cafe!");
Console.WriteLine("--------------------------------\n\n");
Console.WriteLine("--------------------------------");
Console.WriteLine("Seleccione un tamaño de vaso:");
Console.WriteLine("1. Pequeño: " + vasoPequeño.getCantidadVasos());
Console.WriteLine("2. Mediano: " + vasoMediano.getCantidadVasos());
Console.WriteLine("3. Grande: " + vasoGrande.getCantidadVasos());
Console.WriteLine("4. Salir");
Console.WriteLine("--------------------------------");
Console.WriteLine("");
tamanoVaso = int.Parse(Console.ReadLine()!);
switch (tamanoVaso)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Has seleccionado un vaso pequeño");
        Console.WriteLine("--------------------------------\n\n");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Diga que cantidad de café quiere (Max " + cafetera.getCantidadCafe() + " ml): ");
        cantidadCafe = int.Parse(Console.ReadLine()!);
        Console.Clear();
        Console.WriteLine("Diga la cantidad de azucar que quiere (Max" + azucarero.getCantidadAzucar() + " gs): ");
        cantidadAzucar = int.Parse(Console.ReadLine()!);
        Console.WriteLine(maquinaCafe.getVasoDeCafe(tamanoVaso, cantidadCafe, cantidadAzucar));
        Console.ReadLine();
        break;
    case 2:
        Console.Clear();
        Console.WriteLine("Has seleccionado un vaso mediano");
        Console.WriteLine("--------------------------------\n\n");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Diga que cantidad de café quiere: " + cafetera.getCantidadCafe() + " ml");
        cantidadCafe = int.Parse(Console.ReadLine()!);
        Console.Clear();
        Console.WriteLine("Diga la cantidad de azucar que quiere (Max " + azucarero.getCantidadAzucar() + " gs): ");
        cantidadAzucar = int.Parse(Console.ReadLine()!);
        Console.WriteLine(maquinaCafe.getVasoDeCafe(tamanoVaso, cantidadCafe, cantidadAzucar));
        Console.ReadLine();
        break;
    case 3:
        Console.Clear();
        Console.WriteLine("Has seleccionado un vaso grande");
        Console.WriteLine("--------------------------------\n\n");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Diga que cantidad de café quiere (Max " + cafetera.getCantidadCafe() + " ml): ");
        Console.WriteLine("");
        cantidadCafe = int.Parse(Console.ReadLine()!);
        Console.Clear();
        Console.WriteLine("Diga la cantidad de azucar que quiere (Max " + azucarero.getCantidadAzucar() + " gs): ");
        cantidadAzucar = int.Parse(Console.ReadLine()!);
        Console.WriteLine(maquinaCafe.getVasoDeCafe(tamanoVaso, cantidadCafe, cantidadAzucar));
        Console.ReadLine();
        break;
    case 4:
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("Digite una opción correcta, por favor");
        Console.ReadLine();
        break;
}