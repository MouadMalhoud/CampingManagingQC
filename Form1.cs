using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouadMalhoudLaboratoire2
{

    public partial class FrmAccueil : Form
    {
        public int numCamping = 0;
        static Camping[] camping = new Camping[10];
        public static String nomRadio;
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Êtes vous sur de vouloir quitter ?", "Fermeture", MessageBoxButtons.YesNo);
            if(m == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton[] radioBoutons = { radioOka, radioBic, radioGaspe };
            bool selected = false;
            foreach (var r in radioBoutons)
            {
                if (r.Checked)
                {
                    nomRadio = r.Text;
                    selected = true;
                }
            }
            if (selected == false)
            {
                MessageBox.Show("Veuillez selectionner un parc avant de réserver", "Selection de parc");
            }
            else
            {
                if (nomRadio.Equals("Parc d'Oka"))
                {
                    camping[numCamping] = new Camping(numCamping, nomRadio, @"camping1.jpg");

                }
                if (nomRadio.Equals("Parc du Bic"))
                {
                    camping[numCamping] = new Camping(numCamping, nomRadio, @"camping2.jpg");

                }
                if (nomRadio.Equals("Parc de la Gaspésie"))
                {
                    camping[numCamping] = new Camping(numCamping, nomRadio, @"camping3.jpg");

                }
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
        }
    }
}
