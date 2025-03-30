using MicroServicioAutos.Models;

namespace MicroServicioAutos.Services
{
    public class AutoService
    {
        private static readonly List<Auto> _catalogo = new()
        {
            new Auto { Marca = "Toyota", Modelo = "Corolla", Año = 2022, Precio = 320000, Color = "Blanco" },
            new Auto { Marca = "Honda", Modelo = "Civic", Año = 2021, Precio = 295000, Color = "Negro" },
            new Auto { Marca = "Mazda", Modelo = "3", Año = 2023, Precio = 340000, Color = "Rojo" }
        };

        public Task<List<Auto>> ObtenerCatalogoAsync()
        {
            return Task.FromResult(_catalogo);
        }
    }
}
