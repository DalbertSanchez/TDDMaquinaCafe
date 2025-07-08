using NUnit.Framework;
using TDDMaquinaCafe.MaquinaCafe;

namespace TDDMaquinaCafe.TestMaquinaCafe
{
    public class TestCafetera
    {
        [Test]
        public void deberiaDevolverTrueSiHayCafeSuficiente()
        {
            //La cafetera devolvera true si el cafe dado se puede sustraer de la cafetera
            Cafetera cafetera = new Cafetera(100);
            bool result = cafetera.hayCafeDisponible(20);
            Assert.That(result, Is.True);
        }

        [Test]
        public void deberiaDevolverFalseSiNoHayCafeSuficiente()
        {
            //La cafetera devolvera false si el cafe dado no se puede sustraer de la cafetera
            Cafetera cafetera = new Cafetera(50);
            bool result = cafetera.hayCafeDisponible(60);
            Assert.That(result, Is.False);
        }

        [Test]
        public void deberiaRestarCafe()
        {
            //La cafetera debera restar el cafe que se le pide, y devolver el valor esperado
            Cafetera cafetera = new Cafetera(80);
            cafetera.restarCafe(50);
            Assert.That(cafetera.getCantidadCafe(), Is.EqualTo(30));
        }
    }
}
