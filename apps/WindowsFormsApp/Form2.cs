using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using Volo.Abp.DependencyInjection;

namespace WindowsFormsApp
{
    public partial class Form2 : Form, ITransientDependency
    {
        private readonly IConfiguration _configuration;
        private TokenResponse tokenResponse;

        public Form2(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //if (tokenResponse != null && !string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            //{
            //    tokenResponse = JsonSerializer.Deserialize<TokenResponse>(Properties.Settings.Default.AccessToken);
            //}
            //else
            //{
            //    MessageBox.Show("chua login");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var httpClient = new HttpClient())
            //{
            //    httpClient.SetBearerToken(tokenResponse.AccessToken);

            //    var url = _configuration["RemoteServices:LoginOauth2Demo:BaseUrl"] +
            //              "/api/loginOauth2Demo/book";

            //    var result = await httpClient.GetAsync(url);
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var responseString = await result.Content.ReadAsStringAsync();
            //    }
            //    else
            //    {
            //        throw new Exception("Remote server returns error code: " + result.StatusCode);
            //    }
            //}
        }
    }
}