using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI.Skladista
{
    public partial class frmSkladistaDetalji : Form
    {
        private ApiService _service = new ApiService("Skladista");
        private int? _id = null;
        public frmSkladistaDetalji(int? skladisteId=null)
        {
            InitializeComponent();
            _id = skladisteId;
        }

        private async void frmSkladistaDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var skladiste = await _service.GetById<Model.Skladista>(_id);
                txtAdresa.Text = skladiste.Adresa;
                txtNaziv.Text = skladiste.Naziv;
                txtOpis.Text = skladiste.Opis;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
            var skladiste = new SkladistaUpsertRequest()
            {
                Adresa = txtAdresa.Text,
                Naziv = txtNaziv.Text,
                Opis = txtOpis.Text
            };
            if (_id.HasValue)
            {
                await _service.Update<Model.Skladista>(_id, skladiste);
            }
            else
            {
                await _service.Insert<Model.Skladista>(skladiste);
            }
                MessageBox.Show("Operacija je uspjesna");
            }

        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }

        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider1.SetError(txtAdresa, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresa, null);
            }
        }
    }
}
