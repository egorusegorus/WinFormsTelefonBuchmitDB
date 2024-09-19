using MySqlConnector;
using NPoco;
using System.Configuration;
using System.Diagnostics;

namespace WinFormsTelefonBuchmitDB
{
    public partial class Form1 : Form
    {
        string ConnectionString { get; init; } = ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;
        static List<Kontakt> lstKontakt = new List<Kontakt>();
        public Form1()
        {
            InitializeComponent();
            GridInitialisieren();

        }



        private void GridInitialisieren()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void KontakteAnzeigen(List<Kontakt> lst)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lst;
        }
        private void KontaktHinzufügen(Kontakt k)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Insert(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void KontaktÄndern(Kontakt k)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Update(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<Kontakt> KontakteLaden()
        {
            List<Kontakt> lst = new();
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                connection.Open();
                string sql = "order by nachname, vorname";
                lst = db.Fetch<Kontakt>(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return lst;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kontakt? k = dataGridView1.CurrentRow.DataBoundItem as Kontakt;
            if (k == null)
                return;
            KontaktAnzeigen(k);
        }
        private void KontaktAnzeigen(Kontakt k)
        {
            if (k == null)
                return;
            txtBoxId.Text = Convert.ToString(k.ID);
            txtVorname.Text = k.Vorname;
            txtNachname.Text = k.Nachname;
            txtTelefon.Text = k.Telefon;
            txtEmail.Text = k.Email;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kontakt> lst = KontakteLaden();
            KontakteAnzeigen(lst);
        }
        private void btnKÄndern_Click(object sender, EventArgs e)
        {
            Kontakt k = new Kontakt();
            //  label1.Font = new Font(label1.Font, FontStyle.Italic);
            k.ID = Convert.ToInt32(txtBoxId.Text);
            k.Nachname = txtNachname.Text;
            k.Vorname = txtVorname.Text;
            k.Email = txtEmail.Text;
            k.Telefon = txtTelefon.Text;
            k.Geandert = DateTime.Now;
            if (String.IsNullOrEmpty(txtVorname.Text) || String.IsNullOrEmpty(txtNachname.Text))
            {
                MessageBox.Show("Vorname und Nachname dürfen nicht leer sein.");
                return;
            }
            KontaktÄndern(k);
            List<Kontakt> lst = KontakteLaden();
            KontakteAnzeigen(lst);
        }
        private void KontaktLöschen(Kontakt k)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Delete(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kontakt k = new Kontakt();

            //  k.ID = Convert.ToInt32(txtBoxId.Text);
            k.Nachname = txtNachname.Text;
            k.Vorname = txtVorname.Text;
            k.Email = txtEmail.Text;
            k.Telefon = txtTelefon.Text;
            k.Erstellt = DateTime.Now;
            if (String.IsNullOrEmpty(txtVorname.Text) || String.IsNullOrEmpty(txtNachname.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Die Felder dürfen nicht leer sein.");
                return;
            }
            KontaktHinzufügen(k);
            List<Kontakt> lst = KontakteLaden();
            KontakteAnzeigen(lst);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kontakt k = new Kontakt();

            k.ID = Convert.ToInt32(txtBoxId.Text);


            KontaktLöschen(k);
            List<Kontakt> lst = KontakteLaden();
            KontakteAnzeigen(lst);

        }
    }

}
