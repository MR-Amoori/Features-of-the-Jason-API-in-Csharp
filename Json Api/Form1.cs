using System;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using Json_Api.Web_APIs;
using System.IO;

namespace Json_Api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void LoadImageFromUrl(string imageUrl)
        {
            pbClock.Enabled = true;
            pbClock.Visible = true;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // client.Timeout = TimeSpan.FromSeconds(30); // افزایش زمان انتظار
                    // دریافت تصویر به صورت بایت‌آرایه
                    byte[] imageData = await client.GetByteArrayAsync(imageUrl);

                    // تبدیل بایت‌آرایه به تصویر و نمایش آن
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        // آزاد کردن تصویر قبلی اگر وجود دارد
                        if (pbClock.Image != null)
                        {
                            pbClock.Image.Dispose();
                        }

                        Image image = Image.FromStream(stream);
                        pbClock.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگذاری تصویر: {ex.Message}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbClock.Enabled)
            {
                LoadImageFromUrl("https://api.codebazan.ir/clock/image.php");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lisArz.Clear();
            pbClock.Visible = false;
            pbClock.Enabled = false;
        }

        #region Arz
        private void btnArz_Click(object sender, EventArgs e)
        {
            lisArz.Clear();
            pbClock.Visible = false;
            pbClock.Enabled = false;
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

                        pbClock.Visible = true;
                        pbClock.Enabled = true;
                        LoadImageFromUrl("https://api.codebazan.ir/clock/image.php");
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
