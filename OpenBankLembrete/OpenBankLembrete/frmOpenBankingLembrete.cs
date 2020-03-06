using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBankLembrete
{
    public partial class frmOpenBankingLembrete : Form
    {
        public frmOpenBankingLembrete()
        {
            InitializeComponent();
        }
        //Timer 18000000 = 5 horas
        //Timer 16200000 = 4 horas e 30 minutos
        //Timer 14400000 = 4 horas
        //Timer 12600000 = 3 horas e 30 minutos
        //Timer 10800000 = 3 horas
        //Timer 9000000 = 2 horas e 30 minutos
        //Timer 7200000 = 2 horas 
        //Timer 5400000 = 1 hora e 30 minutos
        //Timer 3600000 = 1 hora
        //Timer 1800000 = 30 minutos
        //Timer 5000 = 5 segundos


        //Testando Localmente
        private static string UriGet = "https://localhost:44302/api/OpenBankingLembrete";

        //Em produção
        // private static string URI = "http://gventurasistemas-001-site7.ctempurl.com/api/Vendas";
        // private static string URL = "http://gventurasistemas-001-site7.ctempurl.com/SistemaApqp/Views/Vendas.aspx";

        #region FORM
        private void frmOpenBankingLembrete_Load(object sender, EventArgs e)
        {
            int largura = Screen.PrimaryScreen.Bounds.Width;
            int altura = Screen.PrimaryScreen.Bounds.Height;

            this.DesktopLocation = new Point(largura - 320, altura - 300);

            this.Hide();
        }
        private void frmOpenBankingLembrete_Resize(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide();
            //}
        }
        #endregion

        #region METODOS
        private async void PegarRegistros()
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(UriGet);

                if (response.IsSuccessStatusCode)
                {
                    int cont = 0;

                    var dadosJson = await response.Content.ReadAsStringAsync();
                    if (dadosJson != null)
                    {
                      
                        foreach (LembreteModel item in JsonConvert.DeserializeObject<LembreteModel[]>(dadosJson).ToList<LembreteModel>())
                        {
                            if (item.Status == false)
                            {
                                dataGridView1.Rows[0].Cells[0].Value = item.Usuario.NomeUsuario;
                                dataGridView1.Rows[0].Cells[1].Value = item.DescricaoLembrete;
                                dataGridView1.Rows[0].Cells[2].Value = item.Status;
                                dataGridView1.Rows[0].Cells[3].Value = item.Efetuado;

                                cont = cont + 1;
                            }
                        }
                      
                       // dataGridView1.Rows[2].Cells[1].Value = item.DescricaoLembrete;

                        //dataGridView1.Rows.Add(item.DescricaoLembrete);
                        //dataGridView1.Rows.Add(item.Status);
                        //dataGridView1.Rows.Add(item.Visto);
                        //dataGridView1.Rows.Add(item.Usuario.NomeUsuario);
                    }

                    if (cont > 0)
                    {
                        this.Show();
                        this.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception er)
            {
                //MessageBox.Show("Não foi possível obter o produto : " + er);
                // return;
            }
        }

        #endregion

        #region BOTOES
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }
        #endregion

        #region TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            PegarRegistros();
        }
        #endregion
    }
}
