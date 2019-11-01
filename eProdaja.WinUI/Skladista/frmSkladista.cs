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
    public partial class frmSkladista : Form
    {
        public ApiService _apiService = new ApiService("Skladista");
        public frmSkladista()
        {
            InitializeComponent();
        }

        private void txtSkladistaPretraga_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSkladista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new SkladistaSearchRequest()
            {
                Naziv = txtSkladistaPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Skladista>>(search);
            dgvSkladista.AutoGenerateColumns = false;
            dgvSkladista.DataSource = result;
        
        }

        private void dgvSkladista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvSkladista.SelectedRows[0].Cells[0].Value;
            frmSkladistaDetalji frm = new frmSkladistaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
