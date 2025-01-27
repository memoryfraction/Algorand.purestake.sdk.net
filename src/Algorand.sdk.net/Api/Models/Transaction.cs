﻿using System.Text.Json.Serialization;

namespace Algorand.SDK.Dotnet.Api.Models
{
    public class Transaction
    {
        [JsonPropertyName("curcfg")]
        public Curcfg Curcfg { get; set; }

        [JsonPropertyName("curfrz")]
        public Curfrz Curfrz { get; set; }

        [JsonPropertyName("curxfer")]
        public Curxfer Curxfer { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("tx")]
        public string Tx { get; set; }

        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("fee")]
        public int Fee { get; set; }

        [JsonPropertyName("first-round")]
        public int FirstRound { get; set; }

        [JsonPropertyName("last-round")]
        public int LastRound { get; set; }

        [JsonPropertyName("noteb64")]
        public object Noteb64 { get; set; }

        [JsonPropertyName("round")]
        public int Round { get; set; }

        [JsonPropertyName("poolerror")]
        public string Poolerror { get; set; }

        [JsonPropertyName("payment")]
        public Payment Payment { get; set; }

        [JsonPropertyName("fromrewards")]
        public long Fromrewards { get; set; }

        [JsonPropertyName("genesisID")]
        public string GenesisID { get; set; }

        [JsonPropertyName("genesishashb64")]
        public string Genesishashb64 { get; set; }

        [JsonPropertyName("group")]
        public string Group { get; set; }
    }
}