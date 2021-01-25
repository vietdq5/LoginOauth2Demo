using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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
        private readonly string AccessToken;

        public Form2(IConfiguration configuration)
        {
            _configuration = configuration;
            InitializeComponent();
            AccessToken = Properties.Settings.Default.AccessToken;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AccessToken))
            {
                MessageBox.Show("chua login");
            }
            using (var httpClient = new HttpClient())
            {
                httpClient.SetBearerToken(AccessToken);

                var url = _configuration["RemoteServices:LoginOauth2Demo:BaseUrl"] +
                          "api/loginOauth2Demo/book";

                var responseMessage = await httpClient.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseString = await responseMessage.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<PageResultBookDto>(responseString);
                    var dataTable = result.items.ToDataTable<BookResultDto>();
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    throw new Exception("Remote server returns error code: " + responseMessage.StatusCode);
                }
            }
        }
    }

    public class PageResultBookDto
    {
        public long totalCount { get; set; }
        public List<BookResultDto> items { get; set; }
    }

    public class BookResultDto
    {
        public string name { get; set; }
        public DateTime publishDate { get; set; }
        public int price { get; set; }
        public object lastModificationTime { get; set; }
        public object lastModifierId { get; set; }
        public DateTime creationTime { get; set; }
        public string creatorId { get; set; }
        public string id { get; set; }
    }
}