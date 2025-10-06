using System.Linq;

namespace MercatoManager.Models
{
    public class Cliente
    {
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public List<Producto> ProductosComprados { get; set; } = new List<Producto>();

        public decimal CalcularTotalGastado()
        {
            return ProductosComprados.Sum(p => p.Precio);
        }

        // Validaciones recursivas para DNI y celular
        public static bool ValidarDNI(string dni)
        {
            return ValidarDNIRecursivo(dni);
        }

        private static bool ValidarDNIRecursivo(string dni, int index = 0)
        {
            if (dni.Length != 8) return false;
            if (index == dni.Length) return true;
            if (!char.IsDigit(dni[index])) return false;
            return ValidarDNIRecursivo(dni, index + 1);
        }

        public static bool ValidarCelular(string celular)
        {
            return ValidarCelularRecursivo(celular);
        }

        private static bool ValidarCelularRecursivo(string celular, int index = 0)
        {
            if (celular.Length != 9) return false;
            if (index == celular.Length) return true;
            if (!char.IsDigit(celular[index])) return false;
            return ValidarCelularRecursivo(celular, index + 1);
        }
    }
}
