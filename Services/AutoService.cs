using MicroServicioAutos.Models;

namespace MicroServicioAutos.Services
{
    public class AutoService
    {
        private static readonly List<Auto> _catalogo = new()
        {
            new Auto { Marca = "Alfa Romeo", Modelo = "Giulia", Año = 2022, Precio = 950000, Color = "Rojo" },
            new Auto { Marca = "Alfa Romeo", Modelo = "Stelvio", Año = 2023, Precio = 1100000, Color = "Blanco" },
            new Auto { Marca = "Alfa Romeo", Modelo = "Tonale", Año = 2024, Precio = 870000, Color = "Gris" },
            new Auto { Marca = "Alfa Romeo", Modelo = "4C Spider", Año = 2021, Precio = 1200000, Color = "Negro" },

            new Auto { Marca = "Rolls Royce", Modelo = "Phantom", Año = 2023, Precio = 9500000, Color = "Negro" },
            new Auto { Marca = "Rolls Royce", Modelo = "Ghost", Año = 2022, Precio = 8200000, Color = "Gris" },
            new Auto { Marca = "Rolls Royce", Modelo = "Cullinan", Año = 2024, Precio = 9800000, Color = "Blanco" },
            new Auto { Marca = "Rolls Royce", Modelo = "Wraith", Año = 2021, Precio = 9100000, Color = "Azul" },

            new Auto { Marca = "Lamborghini", Modelo = "Huracán EVO", Año = 2023, Precio = 6200000, Color = "Amarillo" },
            new Auto { Marca = "Lamborghini", Modelo = "Aventador S", Año = 2022, Precio = 7800000, Color = "Verde" },
            new Auto { Marca = "Lamborghini", Modelo = "Urus", Año = 2024, Precio = 6300000, Color = "Gris" },
            new Auto { Marca = "Lamborghini", Modelo = "Revuelto", Año = 2024, Precio = 9000000, Color = "Naranja" }
        };

        public Task<List<Auto>> ObtenerCatalogoAsync()
        {
            return Task.FromResult(_catalogo);
        }
    }
}
