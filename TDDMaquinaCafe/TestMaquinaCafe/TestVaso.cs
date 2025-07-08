using NUnit.Framework;
using TDDMaquinaCafe.MaquinaCafe;

namespace TDDMaquinaCafe.TestMaquinaCafe
{
    public class TestVaso
    {
        [Test]
        public void deberiaDevolverTrueSiHayVasos()
        {

            Vaso vasoPequeño = new Vaso(10, 2);
            bool result = vasoPequeño.hayVasosDisponibles(2);
            Assert.That(result, Is.True);
        }

        [Test]
        public void deberiaDevolverFalseSiNoHayVasos()
        {

            Vaso vasoMediano = new Vaso(0, 2);
            bool result = vasoMediano.hayVasosDisponibles(2);
            Assert.That(result, Is.False);
        }

        [Test]
        public void deberiaRestarCantidadDeVasos()
        {

            Vaso vasoGrande = new Vaso(10, 3);
            int result = vasoGrande.restarVasos(3);
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void deberiaDevolverFalseSiNoExisteEseVaso()
        {

            Vaso vaso = new Vaso(20, 1);
            bool result = vaso.hayVasosDisponibles(5);
            Assert.That(result, Is.False);
        }
    }
}
