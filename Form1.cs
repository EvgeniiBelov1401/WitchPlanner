using System.Windows.Forms;
using System.Xml.Linq;
using WitchPlanner.Modules;

namespace WitchPlanner
{
    public partial class Form1 : Form
    {
        private readonly List<Client> clients = [];
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {
            dataGridViewClients.Columns.Add("Date", "Дата");
            dataGridViewClients.Columns.Add("Name", "Имя");
        }

        private void ButtonRecord_Click(object sender, EventArgs e)
        {
            string? clientName = textBoxClientName.Text.Trim();

            if (!string.IsNullOrEmpty(clientName))
            {
                var newClient = new Client()
                {
                    Name = clientName,
                    Date = DateTime.Now.ToString("dd.MM.yyyy")
                };
                clients.Add(newClient);

                // Добавляем клиента в DataGridView
                dataGridViewClients.Rows.Add(newClient.Date!, newClient.Name!);

                // Очищаем текстовое поле
                textBoxClientName.Clear();
                textBoxClientName.Focus();
            }
            else
            {
                MessageBox.Show("Введите имя клиента.");
            }
        }
    }
}
