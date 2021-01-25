using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;
using Volo.Abp.DependencyInjection;
using Volo.Abp.IdentityModel;

namespace WindowsFormsApp
{
    public partial class Form1 : Form, ITransientDependency
    {
        private readonly IIdentityModelAuthenticationService _authenticationService;
        private readonly IConfiguration _configuration;
        private readonly Form2 _form2;

        public Form1(
            IIdentityModelAuthenticationService authenticationService,
            IConfiguration configuration,
            Form2 form2
            )
        {
            _authenticationService = authenticationService;
            _configuration = configuration;
            _form2 = form2;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // login
        private async void button3_Click(object sender, EventArgs e)
        {
            var userName = textBox2.Text;
            var pasWord = textBox3.Text;
            var accessToken = await _authenticationService.GetAccessTokenAsync(
               new IdentityClientConfiguration(
                   _configuration["IdentityClients:Default:Authority"],
                   _configuration["IdentityClients:Default:Scope"],
                   _configuration["IdentityClients:Default:ClientId"],
                   _configuration["IdentityClients:Default:ClientSecret"],
                   _configuration["IdentityClients:Default:GrantType"],
                   //_configuration["IdentityClients:Default:UserName"],
                   userName,
                   //_configuration["IdentityClients:Default:UserPassword"]
                   pasWord
               )
            );
            //var client = new HttpClient();
            //var disco = await client.GetDiscoveryDocumentAsync(_configuration["IdentityClients:Default:Authority"]);
            //if (disco.IsError)
            //{
            //    Console.WriteLine(disco.Error);
            //    return;
            //}
            //var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
            //{
            //    Address = disco.TokenEndpoint,
            //    ClientId = _configuration["IdentityClients:Default:ClientId"],
            //    ClientSecret = _configuration["IdentityClients:Default:ClientSecret"],
            //    //UserName = _configuration["IdentityClients:Default:UserName"],
            //    UserName = userName,
            //    //Password = _configuration["IdentityClients:Default:UserPassword"],
            //    Password = pasWord,
            //    Scope = _configuration["IdentityClients:Default:Scope"]
            //});
            //if (tokenResponse.IsError)
            //{
            //    Console.WriteLine(tokenResponse.Error);
            //    MessageBox.Show("Co loi xay ra");
            //    return;
            //}
            // Properties.Settings.Default.AccessToken = JsonSerializer.Serialize(tokenResponse);
            Properties.Settings.Default.AccessToken = accessToken;
            Properties.Settings.Default.Save();
            _form2.ShowDialog();
        }
    }
}