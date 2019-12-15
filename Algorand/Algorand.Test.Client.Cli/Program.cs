﻿using Algorand.Process.Algod.Client;
using Algorand.Tools.Api;
using System;

namespace Algorand.Test.Client.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var algoApi = new AlgorandApiClient("https://testnet-algorand.api.purestake.io/ps1");
            algoApi.SetApiKey("X-API-Key", "");

            var algod = new AlgodClient(algoApi);

            var addre = algod.GetVersionAsync().Result;

            Console.ReadLine();
        }
    }
}