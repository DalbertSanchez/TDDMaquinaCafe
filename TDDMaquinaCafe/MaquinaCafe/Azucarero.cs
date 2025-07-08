namespace TDDMaquinaCafe.MaquinaCafe
{
    public class Azucarero
    {
        private int _cantidadAzucar = 0;
        public Azucarero(int cantidadAzucar)
        {
            setCantidadAzucar(cantidadAzucar);
        }

        public int setCantidadAzucar(int cantidadAzucar)
        {
            if (cantidadAzucar < 0)
            {
                Console.WriteLine("Error, digite una cantidad correcta de azucar");
                return 0;
            }
            return _cantidadAzucar = cantidadAzucar;
        }

        public int getCantidadAzucar()
        { return _cantidadAzucar; }

        public bool haySuficienteAzucar(int cantidad)
        {
            if (cantidad > _cantidadAzucar)
            {
                Console.WriteLine("Excedió el azucar");
                return false;
            }
            return true;
        }

        public int restarAzucar(int cantidad)
        {
            if (!haySuficienteAzucar(cantidad))
                return 0;

            int result = _cantidadAzucar -= cantidad;
            return result;

        }
    }
}
