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
using Newtonsoft.Json;
using Newtonsoft;
using Json_Api.Web_APIs;

namespace Json_Api
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region Arz
        private void btnArz_Click(object sender, EventArgs e)
        {
            lisArz.Clear();
            string urlApi = "https://api.codebazan.ir/arz/?type=arz";
            using (var client = new HttpClient())
            {
                var serial = client.GetStringAsync(urlApi).Result;
                var deserial = JsonConvert.DeserializeObject<Root>(serial);
                foreach (var item in deserial.Result)
                {
                    Result result = new Result()
                    {
                        name = item.name,
                        price = item.price
                    };
                }

                if (deserial.Ok == true)
                {
                    foreach (var pl in deserial.Result)
                    {
                        lisArz.Items.Add(pl.name + " | " + pl.price);
                    }
                }
                else
                {
                    MessageBox.Show("Error !");
                }
            }
        }
        #endregion

        #region Oghat
        private void btnOghatSharee_Click(object sender, EventArgs e)
        {
            lisArz.Clear();
            if (txtOghat.Text != "")
            {
                string urlApi = "https://api.codebazan.ir/owghat/?city=" + txtOghat.Text.ToLower();
                using (var client = new HttpClient())
                {
                    var serial = client.GetStringAsync(urlApi).Result;
                    var deserial = JsonConvert.DeserializeObject<Root>(serial);

                    if (deserial.Result != null && deserial.Result.Any(x => x.shahr != null))
                    {
                        foreach (var item in deserial.Result)
                        {
                            Owghat res = new Owghat()
                            {
                                shahr = item.shahr,
                                azanmaghreb = item.azanmaghreb,
                                azansobh = item.azansobh,
                                azanzohr = item.azanzohr,
                                ghorubaftab = item.ghorubaftab,
                                nimeshab = item.nimeshab,
                                tarikh = item.tarikh,
                                toloaftab = item.toloaftab
                            };
                        }

                        foreach (var pl in deserial.Result)
                        {
                            lisArz.Items.Add("شهر: " + pl.shahr);
                            lisArz.Items.Add("تاریخ:" + pl.tarikh);
                            lisArz.Items.Add("اذان صبح: " + pl.azansobh);
                            lisArz.Items.Add("طلوع آفتاب: " + pl.toloaftab);
                            lisArz.Items.Add("اذان ظهر: " + pl.azanzohr);
                            lisArz.Items.Add("غروب آفتاب: " + pl.ghorubaftab);
                            lisArz.Items.Add("اذان مغرب: " + pl.azanmaghreb);
                            lisArz.Items.Add("نیمه شب شرعی: " + pl.nimeshab);
                        }
                    }
                    else
                    {
                        MessageBox.Show("شهر یافت نشد !");
                    }
                }
            }
            else
            {
                MessageBox.Show("نام شهر را وارد کنید !");
            }
        }
        #endregion
    }
}
