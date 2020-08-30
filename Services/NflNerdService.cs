using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NflStatsDotNet.Services.Model;

namespace NflStatsDotNet.Services
{
    public class NflNerdService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IOptions<NerdServiceOptions> _options;
        private readonly ILogger<NflNerdService> _logger;

        public NflNerdService(IHttpClientFactory clientFactory, IOptions<NerdServiceOptions> options,
            ILogger<NflNerdService> logger)
        {
            _clientFactory = clientFactory;
            _options = options;
            _logger = logger;
        }

        public async Task<NflPlayers> GetAllPlayers()
        {
            var uri = new Uri($"{_options.Value.BaseUrl}/players/json/{_options.Value.Token}/");
            var client = _clientFactory.CreateClient();
            var msg = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri
            };

            var result = await client.SendAsync(msg);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var jsonPlayers = await result.Content.ReadAsStringAsync();
                return await result.Content.ReadAsAsync<NflPlayers>(new[] {new JsonMediaTypeFormatter()});
            }
            else
            {
                return null;
            }
        }

        public async Task<NflTeams> GetAllTeams()
        {
            var uri = new Uri($"{_options.Value.BaseUrl}/nfl-teams/json/{_options.Value.Token}/");
            _logger.LogInformation($"URL: {uri}");
            var client = _clientFactory.CreateClient();
            var msg = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri
            };

            var result = await client.SendAsync(msg);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var jsonTeams = await result.Content.ReadAsStringAsync();
                return await result.Content.ReadAsAsync<NflTeams>(new[] {new JsonMediaTypeFormatter()});
            }
            else
            {
                return null;
            }
        }
    }
}