using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace MouadMalhoudLaboratoire2
{
    public partial class Form2 : Form
    {
        public int nbReservation = 0;
        String[] province = { "Québec", "Ontario", "Nouveau-Brunswick", "Nouvelle-Écosse" };
        String[] etat = { "Maine", "New York", "New Hampshire", "Vermont"};
        Regex rxCourriel = new Regex(@"[a-zA-Z0-9_.+]+@[a-zA-Z0-9_.+]+\.[a-zA-Z]");
        string nomRadio = FrmAccueil.nomRadio;
        Reservation[] reservation = new Reservation[10];
        bool valide1 = false;
        bool valide2 = false;
        bool valide3 = false;
        bool valide4 = false;
        bool valide5 = true;
        bool valide6 = true;
        bool valide7 = false;
        bool valide8 = false;



        public Form2()
        {
            InitializeComponent();
            lblLocalisation.Text = "Camping " + nomRadio;
            listBoxServices.SelectedIndex = 0;
            errorProviderNom.SetError(txtNom, "Veuillez entrer un nom");
            saveFileDialogSauvegarde.InitialDirectory = @"\";
            saveFileDialogSauvegarde.Title = "Sauvegarde du fichier de reservation";
            saveFileDialogSauvegarde.DefaultExt = "txt";
            saveFileDialogSauvegarde.Filter = "fichier texte (*.txt)|*txt";
            saveFileDialogSauvegarde.FileName = "RESERV_" + nomRadio;

        }
        private void comboBoxPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProvince.Items.Clear();
            if (comboBoxPays.SelectedIndex == 0)
            {
                comboBoxProvince.Items.AddRange(province);
            }
            if (comboBoxPays.SelectedIndex == 1)
            {
                comboBoxProvince.Items.AddRange(etat);
            }
        }

        private void txtCourriel_TextChanged(object sender, EventArgs e)
        {
            String courrier = txtCourriel.Text;
            if(rxCourriel.IsMatch(courrier))
            {
                errorProviderCourriel.Clear();
                valide1 = true;
            }
            else
            {
                errorProviderCourriel.SetError(txtCourriel, "Entrez un courriel valide");
            }
        }

        private void dateDepart_ValueChanged(object sender, EventArgs e)
        {
            if(dateArrive.Value > dateDepart.Value)
            {
                errorProviderDate.SetError(dateDepart, "La date de départ ne peut pas être inférieur à la date d'arrivé");
            }
            else if(dateArrive.Value == dateDepart.Value)
            {
                errorProviderDate.SetError(dateDepart, "Une réservation à 0 nuit n'est pas possible");
            }
            else
            {
                errorProviderDate.Clear();
                valide2 = true;
            }
        }

        private void btnFaireReservation_Click(object sender, EventArgs e)
        {
            int nbJours = dateDepart.Value.Day - dateArrive.Value.Day;
            int nbAdulte = Convert.ToInt32(numericUpDownAdulte.Value);
            int nbEnfantAge = Convert.ToInt32(numericUpDownEnfantAge.Value);
            int nbEnfantJeune = Convert.ToInt32(numericUpDownEnfantJeune.Value);
            double totalAdulte = 0;
            double totalEnfantAge = 0;
            double totalEnfantJeune = 0;
            double total = 0;
            double totalService = 0;
            int numTotal = Convert.ToInt32(numericUpDownAdulte.Value + numericUpDownEnfantAge.Value + numericUpDownEnfantJeune.Value);
            if (numTotal > 8)
            {
                errorProviderEtape2.SetError(numericUpDownEnfantJeune, "Impossible de reserver plus de 8 personnes au total");
            }
            else
            {
                errorProviderEtape2.Clear();
                valide3 = true;
            }
            // Calcul Facture
            if (nomRadio.Equals("Parc d'Oka"))
            {
                totalAdulte += nbAdulte * 15;
                totalEnfantAge += nbEnfantAge * 8;
                totalEnfantJeune += nbEnfantJeune * 0;
                if (listBoxServices.SelectedItem.Equals("Rustique"))
                {
                    totalService += 0;
                }
                if (listBoxServices.SelectedItem.Equals("Aménagé sans service"))
                {
                    totalService += 5;
                }
                if (listBoxServices.SelectedItem.Equals("Aménagé avec services"))
                {
                    totalService += 10;
                }
                if (listBoxServices.SelectedItem.Equals("Tente-roulotte"))
                {
                    totalService += 20;
                }
                if (listBoxServices.SelectedItem.Equals("Véhicule récréatif"))
                {
                    totalService += 15;
                }
            }
            if (nomRadio.Equals("Parc du Bic"))
            {
                totalAdulte += nbAdulte * 10;
                totalEnfantAge += nbEnfantAge * 5;
                totalEnfantJeune += nbEnfantJeune * 0;
                if (listBoxServices.SelectedItem.Equals("Rustique"))
                {
                    totalService += 2;
                }
                if (listBoxServices.SelectedItem.Equals("Aménagé sans service"))
                {
                    totalService += 5;
                }
                if (listBoxServices.SelectedItem.Equals("Aménagé avec services"))
                {
                    totalService += 10;
                }
                if (listBoxServices.SelectedItem.Equals("Tente-roulotte"))
                {
                    totalService += 20;
                }
                if (listBoxServices.SelectedItem.Equals("Véhicule récréatif"))
                {
                    totalService += 15;
                }
            }
            if (nomRadio.Equals("Parc de la Gaspésie"))
            {
                totalAdulte += nbAdulte * 20;
                totalEnfantAge += nbEnfantAge * 10;
                totalEnfantJeune += nbEnfantJeune * 5;
                if (listBoxServices.SelectedItem.Equals("Rustique"))
                {
                    totalService += 5;
                }
                if (listBoxServices.SelectedItem.Equals("Aménagé sans service"))
                {
                    totalService += 10;
                }
                if (listBoxServices.SelectedItem.Equals("Aménagé avec services"))
                {
                    totalService += 15;
                }
                if (listBoxServices.SelectedItem.Equals("Tente-roulotte"))
                {
                    totalService += 30;
                }
                if (listBoxServices.SelectedItem.Equals("Véhicule récréatif"))
                {
                    totalService += 15;
                }
            }
            total += (totalAdulte + totalEnfantAge + totalEnfantJeune + totalService) * nbJours;
            // if (valide1 == true && valide2 == true && valide3 == true && valide4 == true && valide5 == true && valide6 == true && valide7 == true && valide8 == true)
            //   {
                // Affichage
                txtFacture.Text = "ADULTES : " + totalAdulte + "\r\nENFANTS(6 À 17 ANS) : " + totalEnfantAge + "\r\nENFANTS(5 ANS ET MOINS) : " +
                    totalEnfantJeune + "\r\nTotal de personnages : " + numTotal + "\r\n==========" + "\r\nService : " + listBoxServices.SelectedItem + '(' +
                    totalService + "$)" + "\r\nNombre de nuits : " + nbJours + "\r\n==========" + "\r\nCoût total : " + total + "$";
            //   reservation[nbReservation] = new Reservation(nbReservation, nbReservation, txtNom.Text, comboBoxPays.SelectedItem, comboBoxProvince.SelectedItem,
            // txtCourriel.Text, dateArrive, dateDepart, listBoxServices.SelectedItem, totalService, nbAdulte, nbEnfantAge, nbEnfantJeune, total);
            //  }
            try
            {
                if (saveFileDialogSauvegarde.ShowDialog() == DialogResult.OK)
                {
                    string line = "";
                    //FileStream fichierStream = new FileStream(saveFileDialogSauvegarde.FileName, FileMode.OpenOrCreate);
                    StreamWriter objFichierEcriture = new StreamWriter(saveFileDialogSauvegarde.FileName);
                    line = nbReservation + ";" + dateArrive.Value.Day + ";" + dateDepart.Value.Day + ";" + totalAdulte + ";" + totalEnfantAge + ";" + totalEnfantJeune + ";" + listBoxServices.SelectedItem
                         + ";" + txtNom.Text + ";" + txtCourriel.Text + ";" + comboBoxPays.SelectedItem + ";" + comboBoxProvince.SelectedItem + ";" + total;
                    objFichierEcriture.WriteLine(line);
                    objFichierEcriture.Close();


                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fichier introuvable ! ");
            }
            catch (DirectoryNotFoundException)

            {
                MessageBox.Show("Répertoire introuvable ! ");
            }
            catch (DriveNotFoundException)
            {
                MessageBox.Show("Lecteur spécifié dans le chemin est invalide ! ");
            }
        }

        private void nouvelleRéservationCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateArrive.Value = DateTime.Today;
            dateDepart.Value = DateTime.Today;
            numericUpDownAdulte.Value = 0;
            numericUpDownEnfantAge.Value = 0;
            numericUpDownEnfantJeune.Value = 0;
            listBoxServices.SelectedIndex = 0;
            txtNom.Text = "";
            txtCourriel.Text = "";
            comboBoxPays.SelectedItem = null;
            comboBoxProvince.SelectedItem = null;
            txtFacture.Text = "";
            errorProviderDate.Clear();
            errorProviderCourriel.Clear();
            errorProviderEtape2.Clear();
            errorProviderPays.Clear();
            errorProviderProvince.Clear();
        }

        private void retourAuMenuPrincipalCtrlQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAccueil frm1 = new FrmAccueil();
            frm1.Show();
        }

        private void dateArrive_ValueChanged(object sender, EventArgs e)
        {
            if (dateArrive.Value > dateDepart.Value)
            {
                errorProviderDate.SetError(dateDepart, "La date de départ ne peut pas être inférieur à la date d'arrivé");
            }
            else if (dateArrive.Value == dateDepart.Value)
            {
                errorProviderDate.SetError(dateDepart, "Une réservation à 0 nuit n'est pas possible");
            }
            else
            {
                errorProviderDate.Clear();
                valide4 = true;
            }
        }

        private void numericUpDownAdulte_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownAdulte.Value == 0 && numericUpDownEnfantAge.Value == 0 && numericUpDownEnfantJeune.Value == 0)
            {
                errorProviderEtape2.SetError(numericUpDownEnfantJeune, "Impossible de faire une reservation de 0 personnes");
            }
            else
            {
                errorProviderEtape2.Clear();
                valide7 = true;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if(txtNom.Text != "")
            {
                errorProviderNom.Clear();
                valide8 = true;
            }
            else
            {
                errorProviderNom.SetError(txtNom, "Veuillez entrer un nom");
            }
        }

        private void faireLaRéservationCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFaireReservation_Click(
                sender, e);
            
        }
    }
    }

