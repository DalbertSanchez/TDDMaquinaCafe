using TDDMaquinaCafe.MaquinaCafe;
using NUnit.Framework;

namespace TDDMaquinaCafe.TestMaquinaCafe
{
    public class TestAzucarero
    {
        [Test]
        public void deberiaDevolverTrueSiHaySuficienteAzucar()
        {
            //Devolvera true si el azucarero tiene suficiente azucar
            Azucarero azucarero = new Azucarero(100);
            bool result = azucarero.haySuficienteAzucar(50);
            Assert.That(result, Is.True);
        }

        [Test]
        public void deberiaDevolverFalseSiNoHaySuficienteAzucar()
        {
            //Devolvera false si el azucarero no tiene suficiente azucar
            Azucarero azucarero = new Azucarero(50);
            bool result = azucarero.haySuficienteAzucar(100);
            Assert.That(result, Is.False);
        }

        [Test]
        public void deberiaRestarCantidadDeAzucar()
        {
            Azucarero azucarero = new Azucarero(80);
            azucarero.restarAzucar(20);
            Assert.That(azucarero.getCantidadAzucar(), Is.EqualTo(60));
            
        }
    }
}
