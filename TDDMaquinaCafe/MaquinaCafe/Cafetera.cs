namespace TDDMaquinaCafe.MaquinaCafe
{
    public class Cafetera
    {
        private int _cantidadCafe = 0;
        public Cafetera(int cantidadCafe)
        {
            setCantidadCafe(cantidadCafe);
        }

        public int setCantidadCafe(int cantidadCafe) 
        { 
            if (cantidadCafe < 0)
            {
                Console.WriteLine("Error, digite una cantidad correcta de cafe");
                return 0;
            }
            return _cantidadCafe = cantidadCafe;
        }

        public int getCantidadCafe() { return _cantidadCafe; }

        public bool hayCafeDisponible(int cantidadCafe)
        {
            if (cantidadCafe > _cantidadCafe)
            {
                Console.WriteLine("Error, escriba otra cantidad");
                return false;
            }
            else if (cantidadCafe <= 0)
            {
                Console.WriteLine("No se aceptan valores menor o igual a 0");
                return false;
            }
            else
            {
                return true;
            }
        }

        public int restarCafe(int cantidadCafe)
        {
            if (!hayCafeDisponible(cantidadCafe)) 
            {
                return 0;
            }
            else
            {
                _cantidadCafe -= cantidadCafe;
                Console.WriteLine("Dispensando cafe...");
                Thread.Sleep(2000); 
                return _cantidadCafe;
            }
        }
    }
}
