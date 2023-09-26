
namespace MouadMalhoudLaboratoire2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pctrHutte = new System.Windows.Forms.PictureBox();
            this.lblSysteme = new System.Windows.Forms.Label();
            this.lblCamping = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLocalisation = new System.Windows.Forms.Label();
            this.lblEtape = new System.Windows.Forms.Label();
            this.lblEtape2 = new System.Windows.Forms.Label();
            this.lblEtape3 = new System.Windows.Forms.Label();
            this.lblEtape4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateArrive = new System.Windows.Forms.DateTimePicker();
            this.lblArrive = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.lblAdulte = new System.Windows.Forms.Label();
            this.lblEnfantsAge = new System.Windows.Forms.Label();
            this.lblEnfantJeune = new System.Windows.Forms.Label();
            this.btnFaireReservation = new System.Windows.Forms.Button();
            this.numericUpDownAdulte = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnfantAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnfantJeune = new System.Windows.Forms.NumericUpDown();
            this.lblService = new System.Windows.Forms.Label();
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.comboBoxPays = new System.Windows.Forms.ComboBox();
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCourriel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPays = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProvince = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFacture = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.réservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleRéservationCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faireLaRéservationCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afficherUneRéservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.retourAuMenuPrincipalCtrlQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogOuverture = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSauvegarde = new System.Windows.Forms.SaveFileDialog();
            this.errorProviderEtape2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrHutte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdulte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnfantAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnfantJeune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCourriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProvince)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEtape2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrHutte
            // 
            this.pctrHutte.Image = global::MouadMalhoudLaboratoire2.Properties.Resources.camping_icon;
            this.pctrHutte.Location = new System.Drawing.Point(4, 37);
            this.pctrHutte.Name = "pctrHutte";
            this.pctrHutte.Size = new System.Drawing.Size(153, 144);
            this.pctrHutte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHutte.TabIndex = 5;
            this.pctrHutte.TabStop = false;
            // 
            // lblSysteme
            // 
            this.lblSysteme.AutoSize = true;
            this.lblSysteme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysteme.Location = new System.Drawing.Point(165, 128);
            this.lblSysteme.Name = "lblSysteme";
            this.lblSysteme.Size = new System.Drawing.Size(419, 25);
            this.lblSysteme.TabIndex = 4;
            this.lblSysteme.Text = "Système de réservation - hébergement";
            // 
            // lblCamping
            // 
            this.lblCamping.AutoSize = true;
            this.lblCamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamping.Location = new System.Drawing.Point(163, 70);
            this.lblCamping.Name = "lblCamping";
            this.lblCamping.Size = new System.Drawing.Size(373, 42);
            this.lblCamping.TabIndex = 3;
            this.lblCamping.Text = "CAMPING QUÉBEC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MouadMalhoudLaboratoire2.Properties.Resources.camping3;
            this.pictureBox1.Location = new System.Drawing.Point(606, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblLocalisation
            // 
            this.lblLocalisation.AutoSize = true;
            this.lblLocalisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalisation.Location = new System.Drawing.Point(167, 163);
            this.lblLocalisation.Name = "lblLocalisation";
            this.lblLocalisation.Size = new System.Drawing.Size(79, 18);
            this.lblLocalisation.TabIndex = 7;
            this.lblLocalisation.Text = "Camping ";
            // 
            // lblEtape
            // 
            this.lblEtape.AutoSize = true;
            this.lblEtape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape.Location = new System.Drawing.Point(40, 235);
            this.lblEtape.Name = "lblEtape";
            this.lblEtape.Size = new System.Drawing.Size(57, 16);
            this.lblEtape.TabIndex = 8;
            this.lblEtape.Text = "Étape 1:";
            // 
            // lblEtape2
            // 
            this.lblEtape2.AutoSize = true;
            this.lblEtape2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape2.Location = new System.Drawing.Point(186, 235);
            this.lblEtape2.Name = "lblEtape2";
            this.lblEtape2.Size = new System.Drawing.Size(57, 16);
            this.lblEtape2.TabIndex = 9;
            this.lblEtape2.Text = "Étape 2:";
            // 
            // lblEtape3
            // 
            this.lblEtape3.AutoSize = true;
            this.lblEtape3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape3.Location = new System.Drawing.Point(327, 235);
            this.lblEtape3.Name = "lblEtape3";
            this.lblEtape3.Size = new System.Drawing.Size(57, 16);
            this.lblEtape3.TabIndex = 10;
            this.lblEtape3.Text = "Étape 3:";
            // 
            // lblEtape4
            // 
            this.lblEtape4.AutoSize = true;
            this.lblEtape4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape4.Location = new System.Drawing.Point(479, 235);
            this.lblEtape4.Name = "lblEtape4";
            this.lblEtape4.Size = new System.Drawing.Size(57, 16);
            this.lblEtape4.TabIndex = 11;
            this.lblEtape4.Text = "Étape 4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(851, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Facture";
            // 
            // dateArrive
            // 
            this.dateArrive.Location = new System.Drawing.Point(43, 266);
            this.dateArrive.Name = "dateArrive";
            this.dateArrive.Size = new System.Drawing.Size(110, 20);
            this.dateArrive.TabIndex = 1;
            this.dateArrive.ValueChanged += new System.EventHandler(this.dateArrive_ValueChanged);
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Location = new System.Drawing.Point(40, 251);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(73, 13);
            this.lblArrive.TabIndex = 14;
            this.lblArrive.Text = "Date d\'arrivée";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(40, 288);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(78, 13);
            this.lblDepart.TabIndex = 15;
            this.lblDepart.Text = "Date de départ";
            // 
            // dateDepart
            // 
            this.dateDepart.Location = new System.Drawing.Point(43, 305);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(110, 20);
            this.dateDepart.TabIndex = 2;
            this.dateDepart.ValueChanged += new System.EventHandler(this.dateDepart_ValueChanged);
            // 
            // lblAdulte
            // 
            this.lblAdulte.AutoSize = true;
            this.lblAdulte.Location = new System.Drawing.Point(186, 251);
            this.lblAdulte.Name = "lblAdulte";
            this.lblAdulte.Size = new System.Drawing.Size(42, 13);
            this.lblAdulte.TabIndex = 17;
            this.lblAdulte.Text = "Adultes";
            // 
            // lblEnfantsAge
            // 
            this.lblEnfantsAge.AutoSize = true;
            this.lblEnfantsAge.Location = new System.Drawing.Point(186, 289);
            this.lblEnfantsAge.Name = "lblEnfantsAge";
            this.lblEnfantsAge.Size = new System.Drawing.Size(102, 13);
            this.lblEnfantsAge.TabIndex = 18;
            this.lblEnfantsAge.Text = "Enfants (6 à 17 ans)";
            // 
            // lblEnfantJeune
            // 
            this.lblEnfantJeune.AutoSize = true;
            this.lblEnfantJeune.Location = new System.Drawing.Point(186, 328);
            this.lblEnfantJeune.Name = "lblEnfantJeune";
            this.lblEnfantJeune.Size = new System.Drawing.Size(120, 13);
            this.lblEnfantJeune.TabIndex = 19;
            this.lblEnfantJeune.Text = "Enfants (5 ans et moins)";
            // 
            // btnFaireReservation
            // 
            this.btnFaireReservation.Location = new System.Drawing.Point(43, 451);
            this.btnFaireReservation.Name = "btnFaireReservation";
            this.btnFaireReservation.Size = new System.Drawing.Size(852, 23);
            this.btnFaireReservation.TabIndex = 11;
            this.btnFaireReservation.Text = "Faire la réservation";
            this.btnFaireReservation.UseVisualStyleBackColor = true;
            this.btnFaireReservation.Click += new System.EventHandler(this.btnFaireReservation_Click);
            // 
            // numericUpDownAdulte
            // 
            this.numericUpDownAdulte.Location = new System.Drawing.Point(189, 266);
            this.numericUpDownAdulte.Name = "numericUpDownAdulte";
            this.numericUpDownAdulte.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownAdulte.TabIndex = 3;
            this.numericUpDownAdulte.ValueChanged += new System.EventHandler(this.numericUpDownAdulte_ValueChanged);
            // 
            // numericUpDownEnfantAge
            // 
            this.numericUpDownEnfantAge.Location = new System.Drawing.Point(189, 305);
            this.numericUpDownEnfantAge.Name = "numericUpDownEnfantAge";
            this.numericUpDownEnfantAge.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownEnfantAge.TabIndex = 4;
            // 
            // numericUpDownEnfantJeune
            // 
            this.numericUpDownEnfantJeune.Location = new System.Drawing.Point(189, 344);
            this.numericUpDownEnfantJeune.Name = "numericUpDownEnfantJeune";
            this.numericUpDownEnfantJeune.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownEnfantJeune.TabIndex = 5;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(327, 251);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(48, 13);
            this.lblService.TabIndex = 24;
            this.lblService.Text = "Services";
            // 
            // listBoxServices
            // 
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.Items.AddRange(new object[] {
            "Rustique",
            "Aménagé sans service",
            "Aménagé avec services",
            "Tente-roulotte",
            "Véhicule récréatif"});
            this.listBoxServices.Location = new System.Drawing.Point(330, 269);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(120, 95);
            this.listBoxServices.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(482, 269);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(157, 20);
            this.txtNom.TabIndex = 7;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(482, 308);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(157, 20);
            this.txtCourriel.TabIndex = 8;
            this.txtCourriel.TextChanged += new System.EventHandler(this.txtCourriel_TextChanged);
            // 
            // comboBoxPays
            // 
            this.comboBoxPays.FormattingEnabled = true;
            this.comboBoxPays.Items.AddRange(new object[] {
            "Canada",
            "États-Unis"});
            this.comboBoxPays.Location = new System.Drawing.Point(482, 344);
            this.comboBoxPays.Name = "comboBoxPays";
            this.comboBoxPays.Size = new System.Drawing.Size(157, 21);
            this.comboBoxPays.TabIndex = 9;
            this.comboBoxPays.SelectedIndexChanged += new System.EventHandler(this.comboBoxPays_SelectedIndexChanged);
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(482, 385);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(157, 21);
            this.comboBoxProvince.TabIndex = 10;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(482, 250);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 30;
            this.lblNom.Text = "Nom";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(482, 292);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(42, 13);
            this.lblCourriel.TabIndex = 31;
            this.lblCourriel.Text = "Courriel";
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(482, 328);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(30, 13);
            this.lblPays.TabIndex = 32;
            this.lblPays.Text = "Pays";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(483, 369);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(73, 13);
            this.lblProvince.TabIndex = 33;
            this.lblProvince.Text = "Province/État";
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderCourriel
            // 
            this.errorProviderCourriel.ContainerControl = this;
            // 
            // errorProviderPays
            // 
            this.errorProviderPays.ContainerControl = this;
            // 
            // errorProviderProvince
            // 
            this.errorProviderProvince.ContainerControl = this;
            // 
            // txtFacture
            // 
            this.txtFacture.Location = new System.Drawing.Point(715, 251);
            this.txtFacture.Multiline = true;
            this.txtFacture.Name = "txtFacture";
            this.txtFacture.ReadOnly = true;
            this.txtFacture.Size = new System.Drawing.Size(196, 155);
            this.txtFacture.TabIndex = 34;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réservationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // réservationToolStripMenuItem
            // 
            this.réservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleRéservationCtrlNToolStripMenuItem,
            this.faireLaRéservationCtrlSToolStripMenuItem,
            this.toolStripSeparator1,
            this.afficherUneRéservationToolStripMenuItem,
            this.toolStripSeparator2,
            this.retourAuMenuPrincipalCtrlQToolStripMenuItem});
            this.réservationToolStripMenuItem.Name = "réservationToolStripMenuItem";
            this.réservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.réservationToolStripMenuItem.Text = "Réservation";
            // 
            // nouvelleRéservationCtrlNToolStripMenuItem
            // 
            this.nouvelleRéservationCtrlNToolStripMenuItem.Name = "nouvelleRéservationCtrlNToolStripMenuItem";
            this.nouvelleRéservationCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouvelleRéservationCtrlNToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.nouvelleRéservationCtrlNToolStripMenuItem.Text = "Nouvelle réservation ";
            this.nouvelleRéservationCtrlNToolStripMenuItem.Click += new System.EventHandler(this.nouvelleRéservationCtrlNToolStripMenuItem_Click);
            // 
            // faireLaRéservationCtrlSToolStripMenuItem
            // 
            this.faireLaRéservationCtrlSToolStripMenuItem.Name = "faireLaRéservationCtrlSToolStripMenuItem";
            this.faireLaRéservationCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.faireLaRéservationCtrlSToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.faireLaRéservationCtrlSToolStripMenuItem.Text = "Faire la réservation";
            this.faireLaRéservationCtrlSToolStripMenuItem.Click += new System.EventHandler(this.faireLaRéservationCtrlSToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // afficherUneRéservationToolStripMenuItem
            // 
            this.afficherUneRéservationToolStripMenuItem.Name = "afficherUneRéservationToolStripMenuItem";
            this.afficherUneRéservationToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.afficherUneRéservationToolStripMenuItem.Text = "Afficher une réservation";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // retourAuMenuPrincipalCtrlQToolStripMenuItem
            // 
            this.retourAuMenuPrincipalCtrlQToolStripMenuItem.Name = "retourAuMenuPrincipalCtrlQToolStripMenuItem";
            this.retourAuMenuPrincipalCtrlQToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.retourAuMenuPrincipalCtrlQToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.retourAuMenuPrincipalCtrlQToolStripMenuItem.Text = "Retour au menu principal ";
            this.retourAuMenuPrincipalCtrlQToolStripMenuItem.Click += new System.EventHandler(this.retourAuMenuPrincipalCtrlQToolStripMenuItem_Click);
            // 
            // openFileDialogOuverture
            // 
            this.openFileDialogOuverture.FileName = "openFileDialog1";
            // 
            // errorProviderEtape2
            // 
            this.errorProviderEtape2.ContainerControl = this;
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 488);
            this.Controls.Add(this.txtFacture);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.lblCourriel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.comboBoxProvince);
            this.Controls.Add(this.comboBoxPays);
            this.Controls.Add(this.txtCourriel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.listBoxServices);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.numericUpDownEnfantJeune);
            this.Controls.Add(this.numericUpDownEnfantAge);
            this.Controls.Add(this.numericUpDownAdulte);
            this.Controls.Add(this.btnFaireReservation);
            this.Controls.Add(this.lblEnfantJeune);
            this.Controls.Add(this.lblEnfantsAge);
            this.Controls.Add(this.lblAdulte);
            this.Controls.Add(this.dateDepart);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblArrive);
            this.Controls.Add(this.dateArrive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEtape4);
            this.Controls.Add(this.lblEtape3);
            this.Controls.Add(this.lblEtape2);
            this.Controls.Add(this.lblEtape);
            this.Controls.Add(this.lblLocalisation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctrHutte);
            this.Controls.Add(this.lblSysteme);
            this.Controls.Add(this.lblCamping);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Réservation d\'un client - TP2 - Malhoud Mouad";
            ((System.ComponentModel.ISupportInitialize)(this.pctrHutte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdulte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnfantAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnfantJeune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCourriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProvince)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEtape2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrHutte;
        private System.Windows.Forms.Label lblSysteme;
        private System.Windows.Forms.Label lblCamping;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLocalisation;
        private System.Windows.Forms.Label lblEtape;
        private System.Windows.Forms.Label lblEtape2;
        private System.Windows.Forms.Label lblEtape3;
        private System.Windows.Forms.Label lblEtape4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateArrive;
        private System.Windows.Forms.Label lblArrive;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.Label lblAdulte;
        private System.Windows.Forms.Label lblEnfantsAge;
        private System.Windows.Forms.Label lblEnfantJeune;
        private System.Windows.Forms.Button btnFaireReservation;
        private System.Windows.Forms.NumericUpDown numericUpDownAdulte;
        private System.Windows.Forms.NumericUpDown numericUpDownEnfantAge;
        private System.Windows.Forms.NumericUpDown numericUpDownEnfantJeune;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ListBox listBoxServices;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.ComboBox comboBoxPays;
        private System.Windows.Forms.ComboBox comboBoxProvince;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
        private System.Windows.Forms.ErrorProvider errorProviderCourriel;
        private System.Windows.Forms.ErrorProvider errorProviderPays;
        private System.Windows.Forms.ErrorProvider errorProviderProvince;
        private System.Windows.Forms.TextBox txtFacture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem réservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleRéservationCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faireLaRéservationCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem afficherUneRéservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem retourAuMenuPrincipalCtrlQToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogOuverture;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSauvegarde;
        private System.Windows.Forms.ErrorProvider errorProviderEtape2;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
    }
}