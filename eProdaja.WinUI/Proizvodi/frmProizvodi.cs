using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI.Proizvodi
{
    public partial class frmProizvodi : Form
    {
        private readonly ApiService _vrsteProizvodaService = new ApiService("VrsteProizvoda");
        private readonly ApiService _jediniceMjereService = new ApiService("JediniceMjere");
        private readonly ApiService _proizvodiService = new ApiService("Proizvod");
        ProizvodiUpSetRequest request = new ProizvodiUpSetRequest();

        public frmProizvodi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                request.SlikaThumb = file;
                txtSlikaInput.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }


        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {

            var idObj = cmbVrsta.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int vrstaId))
            {
                request.VrstaId = vrstaId;
            }

            var jedMjereIdObj = cmbJedMjere.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int jedMjereId))
            {
                request.JedinicaMjereId = jedMjereId;
            }

            request.Naziv = txtNaziv.Text;
            request.Sifra = txtSifra.Text;
            request.Cijena = decimal.Parse(txtCijena.Text);
                  
            await _proizvodiService.Insert<Model.Proizvod>(request);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            await LoadVrsteProizvoda();
            await LoadJediniceMjere();
        }
        private async Task LoadVrsteProizvoda()
        {
            var result = await _vrsteProizvodaService.Get<List<Model.VrsteProizvoda>>(null);
            result.Insert(0, new Model.VrsteProizvoda());
            cmbVrsta.DisplayMember = "Naziv";
            cmbVrsta.ValueMember = "VrstaId";
            cmbVrsta.DataSource = result;


        }
        private async Task LoadJediniceMjere()
        {
            var result = await _jediniceMjereService.Get<List<Model.JediniceMjere>>(null);
            result.Insert(0, new Model.JediniceMjere());

            cmbJedMjere.DisplayMember = "Naziv";
            cmbJedMjere.ValueMember = "JedinicaMjereId";
            cmbJedMjere.DataSource = result;


        }

        private async void cmbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {


            var idObj = cmbVrsta.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                MessageBox.Show("usao u if ");
                await LoadProizvodi(id);

            }

        }
        public async Task LoadProizvodi(int vrstaId)
        {
            var result = await _proizvodiService.Get<List<Model.Proizvod>>(new ProizvodSearchRequest()
            {
                VrstaId = vrstaId
            });

            proizvodiGridView.DataSource = result;
        }
        private void proizvodiGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }
        private void proizvodiGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
