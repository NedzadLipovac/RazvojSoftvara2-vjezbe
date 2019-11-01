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

namespace eProdaja.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private int? _id = null;
        private ApiService _service = new ApiService("korisnici");
        public frmKorisniciDetalji(int? korisnikId=null)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {


                var request = new KorisniciInsertRequest()
                {
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    KorisnickoIme = txtUsername.Text,
                    Ime = txtIme.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPassworPotvrda.Text,
                    Prezime = txtPrezime.Text

                };
                if (_id.HasValue)
                {
                    await _service.Update<Model.Korisnici>(_id, request);
                }
                else
                {
                    await _service.Insert<Model.Korisnici>(request);
                }
                MessageBox.Show("Operacija je uspjesna");
            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var korisik = await _service.GetById<Model.Korisnici>(_id);
                txtEmail.Text = korisik.Email;
                txtIme.Text = korisik.Ime;
                txtPrezime.Text = korisik.Prezime;
                txtUsername.Text = korisik.KorisnickoIme;
                txtTelefon.Text = korisik.Telefon;
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_Required);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtIme,null);

            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_Required);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtPrezime, null);

            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
      

            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
         

            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text)&& txtUsername.Text.Length < 3)
            {
                errorProvider.SetError(txtUsername, Properties.Resources.Validation_Required);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtUsername, null);
              
            }
        }
    }
}
