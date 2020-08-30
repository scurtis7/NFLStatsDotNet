using System.Collections.ObjectModel;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace NflStatsDotNet.Services.Model
{
    public class NflTeams
    {
        [JsonProperty("NFLTeams")]
        public Collection<NflTeam> Teams { get; set; }
    }
}