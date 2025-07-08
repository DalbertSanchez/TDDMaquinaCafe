using NUnit.Framework;
using TDDMaquinaCafe.MaquinaCafe;

namespace TDDMaquinaCafe.TestMaquinaCafe
{
    public class TestMaquina
    {
        Azucarero azucarero = new Azucarero(100);
        Vaso vasoPequeño = new Vaso(30, 1);
        Vaso vasoMediano = new Vaso(40, 2);
        Vaso vasoGrande = new Vaso(60, 3);
        Cafetera cafetera = new Cafetera(200);
        Maquina maquinaCafe = new Maquina();
        int tamañoVaso, cantidadCafe, cantidadAzucar;

        [Test]
        public void deberiaDevolverUnVasoPequeño()
        {
            Assert.That(vasoPequeño.getTamañoVaso(), Is.EqualTo(1));

        }

        [Test]
        public void deberiaDevolverUnVasoMediano()
        {
            Assert.That(vasoMediano.getTamañoVaso(), Is.EqualTo(2));

        }

        [Test]
        public void deberiaDevolverUnVasoGrande()
        {
            Assert.That(vasoGrande.getTamañoVaso(),Is.EqualTo(3));

        }

        [Test]
        public void deberiaDevolverNoHayCafe()
        {
            tamañoVaso = 1;
            cantidadCafe = 201;
            cantidadAzucar = 100;
            Assert.That(maquinaCafe.getVasoDeCafe(tamañoVaso, cantidadCafe, cantidadAzucar), Is.EqualTo("No hay cafe"));

        }

        [Test]
        public void deberiaDevolverNoHayAzucar()
        {
            tamañoVaso = 1;
            cantidadCafe = 60;
            cantidadAzucar = 101;
            Assert.That(maquinaCafe.getVasoDeCafe(tamañoVaso, cantidadCafe, cantidadAzucar), Is.EqualTo("No hay suficiente azucar"));

        }
        [Test]
        public void deberiaDevolverFelicitaciones()
        {
            tamañoVaso = 1;
            cantidadCafe = 60;
            cantidadAzucar = 80;
            string tamaño = "pequeño";
            Assert.That(maquinaCafe.getVasoDeCafe(tamañoVaso, cantidadCafe, cantidadAzucar),
                        Is.EqualTo("Cafe tamaño " + tamaño + " con " + cantidadCafe + " ml y "
                    + cantidadAzucar + " de azucar. Quedan " + vasoMediano.getCantidadVasos() + " vasos " + tamaño + "s disponibles"
                        ));
        }

    }
}
