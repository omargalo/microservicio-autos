using MicroServicioAutos.Models;
using System.Net.Http.Json;

namespace MicroServicioAutos.Services
{
    public class AutoService
    {
        private readonly HttpClient _http;

        public AutoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Auto>> ObtenerCatalogoAsync()
        {
            var autos = await _http.GetFromJsonAsync<List<Auto>>("data/autos.json");
            return autos ?? new List<Auto>();
        }
    }
}
