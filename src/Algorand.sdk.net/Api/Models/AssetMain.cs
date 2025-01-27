﻿using System.Text.Json.Serialization;

namespace Algorand.SDK.Dotnet.Api.Models
{
    public class AssetMain
    {
        [JsonPropertyName("AssetIndex")]
        public int AssetIndex { get; set; }

        [JsonPropertyName("AssetParams")]
        public AssetInfo AssetInfo { get; set; }
    }
}