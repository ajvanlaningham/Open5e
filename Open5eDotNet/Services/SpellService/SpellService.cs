using System.Collections.Generic;
using System.Threading.Tasks;
using Open5eDotNet.Models.Spells;
using Open5eDotNet.Services.APIClient;

namespace Open5eDotNet.Services.SpellService
{
    public class SpellService
    {
        private readonly ApiClient _apiClient;

        public SpellService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<Spell> GetSpellByKeyAsync(string key)
        {
            return await _apiClient.GetAsync<Spell>($"spells/{key}/");
        }

        public async Task<List<Spell>> GetSpellsAsync(int limit = 10, int offset = 0)
        {
            var response = await _apiClient.GetAsync<ApiResponse<List<Spell>>>($"spells/?limit={limit}&offset={offset}");
            return response.Results;
        }
    }
}