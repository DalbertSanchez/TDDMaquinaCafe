namespace TDDMaquinaCafe.MaquinaCafe
{
    public class Maquina
    {
        public Azucarero azucarero = new Azucarero(300);
        public Vaso vasoPequeño = new Vaso(30, 1);
        public Vaso vasoMediano = new Vaso(40, 2);
        public Vaso vasoGrande = new Vaso(60, 3);
        public Cafetera cafetera = new Cafetera(700);

        public int getTamañoVaso(int tamañoVaso)
        {
            if (tamañoVaso == vasoPequeño.getTamañoVaso())
            {
                return tamañoVaso;
            }
            else if (tamañoVaso == vasoMediano.getTamañoVaso())
            {
                return tamañoVaso;
            }
            else if (tamañoVaso == vasoGrande.getTamañoVaso())
            {
                return tamañoVaso;
            }
            else
            {
                Console.WriteLine("Este tamaño no existe, o no esta disponible");
                return tamañoVaso;
            }
        }

        public string getVasoDeCafe(int tamañoVaso, int cantidadCafe, int cantidadAzucar)
        {
            getTamañoVaso(tamañoVaso);
            if (tamañoVaso == 1)
            {
                string tamaño = "pequeño";
                vasoPequeño.restarVasos(tamañoVaso);
                if (!cafetera.hayCafeDisponible(cantidadCafe))
                {
                    return "No hay cafe";
                }
                else
                {
                    cafetera.restarCafe(cantidadCafe);
                    if (!azucarero.haySuficienteAzucar(cantidadAzucar))
                    {
                        return "No hay suficiente azucar";
                    }
                    else
                    {
                        azucarero.restarAzucar(cantidadAzucar);
                    }
                }
                 return "Cafe tamaño " + tamaño + " con " + cantidadCafe + " ml y "
                    + cantidadAzucar + " de azucar. Quedan " + vasoMediano.getCantidadVasos() + " vasos " + tamaño + "s disponibles";

            }
            else if (tamañoVaso == 2)
            {
                string tamaño = "mediano";
                vasoMediano.restarVasos(tamañoVaso);
                if (!cafetera.hayCafeDisponible(cantidadCafe))
                {
                    return "No hay cafe";
                }
                else
                {
                    cafetera.restarCafe(cantidadCafe);
                    if (!azucarero.haySuficienteAzucar(cantidadAzucar))
                    {
                        return "No hay suficiente azucar";
                    }
                    else
                    {
                        azucarero.restarAzucar(cantidadAzucar);
                    }
                }
                return "Cafe tamaño " + tamaño + " con " + cantidadCafe + " ml y "
                    + cantidadAzucar + " de azucar. Quedan " + vasoMediano.getCantidadVasos() + " vasos " + tamaño + "s disponibles";

            }
            else if (tamañoVaso == 3)
            {
                string tamaño = "grande";
                vasoGrande.restarVasos(tamañoVaso);
                if (!cafetera.hayCafeDisponible(cantidadCafe))
                {
                    return "No hay cafe";
                }
                else
                {
                    cafetera.restarCafe(cantidadCafe);
                    if (!azucarero.haySuficienteAzucar(cantidadAzucar))
                    {
                        return "No hay suficiente azucar";
                    }
                    else
                    {
                        azucarero.restarAzucar(cantidadAzucar);
                    }
                }
                return "Cafe tamaño " + tamaño + " con " + cantidadCafe + " ml y "
                    + cantidadAzucar + " de azucar. Quedan " + vasoMediano.getCantidadVasos() + " vasos " + tamaño + "s disponibles";

            }
            return "Error, ingrese otro tamaño";
        }
    }
}
