using JasylTirsilik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string cs = @"URI=file:" + Application.StartupPath + "/main.db";

        private void categorize_Click(object sender, EventArgs e)
        {
            Clear(output);
            if (items.SelectedItem == "Макулатура")
            {
                output.Text = @"Белые офисные листы и обрезки

Небеленая целлюлоза

Пролинованные листы

Мешки бумажные неводостойкие

Все виды картона

Тетради и блокноты, периодические издания, книгопечатная продукция, каталоги, рекламные брошюры

Гофрированный картон и его отходы";
            }

            else if (items.SelectedItem == "Пластик")
            {
                output.Text = @"PET – полиэтилентерефталат (пластиковые бутылки, тара)

PVC – поливинилхлорид (трубы, комплектующие для мебели)

PS – полистирол (канцтовары, посуда)

PEND – полиэтилен низкого давления (пищевая тара)

PP – полипропилен (игрушки)

LDPE – полиэтилен высокого давления (пакеты, пленка, упаковка)";
            }

            else if (items.SelectedItem == "Металл")
            {
                output.Text = @"Черные (железо и сплавы на его основе)

Цветные (медь, алюминий, цинк, олово, свинец, никель, хром)

Драгоценные (золото, серебро, платина и металлы платиновой группы - палладий, иридий, родий, рутений и осмий)";
            }

            else if (items.SelectedItem == "Стекло")
            {
                output.Text = @"Стеклянная тара (бутылки, банки, посуда)

Стекло-пакеты";
            }
        }

        private void recomendations_Click(object sender, EventArgs e)
        {
            Clear(output);
            if (items.SelectedItem == "Макулатура")
            {
                output.Text = @"Чтобы подготовить макулатуру,достаточно разложить все элементы на стопки. 
Например: книги и журналы, картонные коробки, бумага.
Далее остается перевязать для удобства имеющиеся пачки, чтобы облегчить процесс транспортировки";
            }

            else if (items.SelectedItem == "Пластик")
            {
                output.Text = @"Бутылки достаточно просто ополоснуть обыкновенной водой, если внутри поверхности остались пищевые отходы. Снять этикетку;";
            }

            else if (items.SelectedItem == "Металл")
            {
                output.Text = @"Самый популярный материал для сдачи, на котором можно заработать немало денег.
Легче всего отсортировать от прочих отходов. 
При этом нужно проконтролировать, чтобы баллоны с опасными веществами не попали в контейнер";
            }

            else if (items.SelectedItem == "Стекло")
            {
                output.Text = @"Промыть, снять металические крышки и этикетки";
            }
        }

        private void places_Click(object sender, EventArgs e)
        {
            Clear(output);
            if (items.SelectedItem != null)
            {
                string thing = "";
                switch (items.SelectedItem)
                {
                    case "Макулатура":
                        thing = "paper";
                        break;
                    case "Пластик":
                        thing = "plastic";
                        break;
                    case "Металл":
                        thing = "metal";
                        break;
                    case "Стекло":
                        thing = "glass";
                        break;

                }
                List<string> adresses = GetPlace(thing);
                foreach (string adress in adresses)
                {
                    output.Text += adress + "\n\n";
                }
                OpenUrl("https://2gis.kz/almaty/search/%D0%BF%D1%80%D0%B8%D0%B5%D0%BC_%D0%B2%D1%82%D0%BE%D1%80%D1%81%D1%8B%D1%80%D1%8C%D1%8F");
            }
        }

        private void statistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else
                {
                    throw;
                }
            }
        }

        private List<string> GetPlace(string thing)
        {
            List<string> adresses = new List<string>();
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = $"SELECT adress FROM places WHERE {thing} = 1";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                adresses.Add(dr.GetString(0));
            }
            return adresses;
            
        }

        private void Clear(RichTextBox richTextBox)
        {
            richTextBox.Text = "";
        }

        
    }
}
