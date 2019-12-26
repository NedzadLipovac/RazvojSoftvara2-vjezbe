using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmLogin : Form
    {
        ApiService service = new ApiService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            ApiService.username = txtKorisnickoIme.Text;
            ApiService.password = txtLozinka.Text;
            try
            {

               await service.Get<dynamic>(null);
                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
