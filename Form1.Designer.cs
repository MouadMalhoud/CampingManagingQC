
namespace MouadMalhoudLaboratoire2
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCamping = new System.Windows.Forms.Label();
            this.lblSysteme = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctrHutte = new System.Windows.Forms.PictureBox();
            this.btnReservation = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.grpBoxRadioParc = new System.Windows.Forms.GroupBox();
            this.radioGaspe = new System.Windows.Forms.RadioButton();
            this.radioBic = new System.Windows.Forms.RadioButton();
            this.radioOka = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHutte)).BeginInit();
            this.grpBoxRadioParc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCamping
            // 
            this.lblCamping.AutoSize = true;
            this.lblCamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamping.Location = new System.Drawing.Point(170, 21);
            this.lblCamping.Name = "lblCamping";
            this.lblCamping.Size = new System.Drawing.Size(373, 42);
            this.lblCamping.TabIndex = 0;
            this.lblCamping.Text = "CAMPING QUÉBEC";
            // 
            // lblSysteme
            // 
            this.lblSysteme.AutoSize = true;
            this.lblSysteme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysteme.Location = new System.Drawing.Point(172, 72);
            this.lblSysteme.Name = "lblSysteme";
            this.lblSysteme.Size = new System.Drawing.Size(419, 25);
            this.lblSysteme.TabIndex = 1;
            this.lblSysteme.Text = "Système de réservation - hébergement";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MouadMalhoudLaboratoire2.Properties.Resources.camping3;
            this.pictureBox1.Location = new System.Drawing.Point(403, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pctrHutte
            // 
            this.pctrHutte.Image = global::MouadMalhoudLaboratoire2.Properties.Resources.camping_icon;
            this.pctrHutte.Location = new System.Drawing.Point(11, 12);
            this.pctrHutte.Name = "pctrHutte";
            this.pctrHutte.Size = new System.Drawing.Size(153, 144);
            this.pctrHutte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHutte.TabIndex = 2;
            this.pctrHutte.TabStop = false;
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(46, 383);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(163, 23);
            this.btnReservation.TabIndex = 4;
            this.btnReservation.Text = "Réservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(248, 383);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(166, 23);
            this.BtnQuitter.TabIndex = 5;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // grpBoxRadioParc
            // 
            this.grpBoxRadioParc.Controls.Add(this.radioGaspe);
            this.grpBoxRadioParc.Controls.Add(this.radioBic);
            this.grpBoxRadioParc.Controls.Add(this.radioOka);
            this.grpBoxRadioParc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRadioParc.Location = new System.Drawing.Point(59, 162);
            this.grpBoxRadioParc.Name = "grpBoxRadioParc";
            this.grpBoxRadioParc.Size = new System.Drawing.Size(235, 190);
            this.grpBoxRadioParc.TabIndex = 0;
            this.grpBoxRadioParc.TabStop = false;
            this.grpBoxRadioParc.Text = "Choix des parcs";
            // 
            // radioGaspe
            // 
            this.radioGaspe.AutoSize = true;
            this.radioGaspe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGaspe.Location = new System.Drawing.Point(21, 129);
            this.radioGaspe.Name = "radioGaspe";
            this.radioGaspe.Size = new System.Drawing.Size(188, 24);
            this.radioGaspe.TabIndex = 3;
            this.radioGaspe.TabStop = true;
            this.radioGaspe.Text = "Parc de la Gaspésie";
            this.radioGaspe.UseVisualStyleBackColor = true;
            // 
            // radioBic
            // 
            this.radioBic.AutoSize = true;
            this.radioBic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBic.Location = new System.Drawing.Point(21, 85);
            this.radioBic.Name = "radioBic";
            this.radioBic.Size = new System.Drawing.Size(118, 24);
            this.radioBic.TabIndex = 2;
            this.radioBic.TabStop = true;
            this.radioBic.Text = "Parc du Bic";
            this.radioBic.UseVisualStyleBackColor = true;
            // 
            // radioOka
            // 
            this.radioOka.AutoSize = true;
            this.radioOka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOka.Location = new System.Drawing.Point(21, 40);
            this.radioOka.Name = "radioOka";
            this.radioOka.Size = new System.Drawing.Size(114, 24);
            this.radioOka.TabIndex = 1;
            this.radioOka.TabStop = true;
            this.radioOka.Text = "Parc d\'Oka";
            this.radioOka.UseVisualStyleBackColor = true;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxRadioParc);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctrHutte);
            this.Controls.Add(this.lblSysteme);
            this.Controls.Add(this.lblCamping);
            this.Name = "FrmAccueil";
            this.Text = "Système de réservation - Camping Québec";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHutte)).EndInit();
            this.grpBoxRadioParc.ResumeLayout(false);
            this.grpBoxRadioParc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamping;
        private System.Windows.Forms.Label lblSysteme;
        private System.Windows.Forms.PictureBox pctrHutte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.GroupBox grpBoxRadioParc;
        private System.Windows.Forms.RadioButton radioGaspe;
        private System.Windows.Forms.RadioButton radioBic;
        private System.Windows.Forms.RadioButton radioOka;
    }
}

