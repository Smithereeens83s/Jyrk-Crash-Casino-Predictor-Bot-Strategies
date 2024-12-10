using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class Stake
{
    private readonly string _access_token;
    private readonly HttpClient _client;

    private const string ENDPOINT = "https://stake.com/_api/graphql";

    public Stake(string access_token)
    {
        _access_token = access_token;
        _client = new HttpClient();
    }

    public async Task<string> UserBalances()
    {
        var json_data = @"{
            ""query"": ""query UserBalances {\n  user {\n    id\n    balances {\n      available {\n        amount\n        currency\n        __typename\n      }\n      vault {\n        amount\n        currency\n        __typename\n      }\n      __typename\n    }\n    __typename\n  }\n}\n"",
            ""operationName"": ""UserBalances""
        }";

        return await SendRequest(json_data);
    }

    public async Task<string> CurrencyConversionRate()
    {
        var json_data = @"{
            ""query"": ""query CurrencyConversionRate {\n  info {\n    currencies {\n      name\n      eur: value(fiatCurrency: eur)\n      jpy: value(fiatCurrency: jpy)\n      usd: value(fiatCurrency: usd)\n      brl: value(fiatCurrency: brl)\n      cad: value(fiatCurrency: cad)\n      cny: value(fiatCurrency: cny)\n      idr: value(fiatCurrency: idr)\n      inr: value(fiatCurrency: inr)\n      krw: value(fiatCurrency: krw)\n      php: value(fiatCurrency: php)\n      rub: value(fiatCurrency: rub)\n      mxn: value(fiatCurrency: mxn)\n      dkk: value(fiatCurrency: dkk)\n    }\n  }\n}\n"",
            ""variables"": {}
        }";

        return await SendRequest(json_data);
    }
    private async Task<string> SendRequest(string json_data)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, ENDPOINT);
        request.Headers.Add("x-access-token", _access_token);
        request.Content = new StringContent(json_data, Encoding.UTF8, "application/json");

        var response = await _client.SendAsync(request);
        return await response.Content.ReadAsStringAsync();
    }
}
