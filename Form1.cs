using System.Windows.Forms;
using System.Xml.Linq;
using WitchPlanner.Modules;

namespace WitchPlanner
{
    public partial class Form1 : Form
    {
        private List<Client> clients = new List<Client>();
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

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            string clientName = textBoxClientName.Text.Trim();

            if (!string.IsNullOrEmpty(clientName))
            {
                Client newClient = new Client(clientName);
                clients.Add(newClient);

                // Добавляем клиента в DataGridView
                dataGridViewClients.Rows.Add(newClient.Date.ToString(), newClient.Name);

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
