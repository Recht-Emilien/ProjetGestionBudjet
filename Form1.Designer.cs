namespace ProjetGestionBudjet
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.buttAjoutType = new System.Windows.Forms.Button();
            this.checkPercu = new System.Windows.Forms.CheckBox();
            this.checkRecette = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAjouterTrans = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.montantText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.dateTransaction = new System.Windows.Forms.DateTimePicker();
            this.Type = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newNomTxt = new System.Windows.Forms.TextBox();
            this.newPrenomTxt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Affichage 1 à 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newPrenomTxt);
            this.tabPage2.Controls.Add(this.newNomTxt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnActualiser);
            this.tabPage2.Controls.Add(this.buttAjoutType);
            this.tabPage2.Controls.Add(this.checkPercu);
            this.tabPage2.Controls.Add(this.checkRecette);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnAjouterTrans);
            this.tabPage2.Controls.Add(this.comboBoxType);
            this.tabPage2.Controls.Add(this.montantText);
            this.tabPage2.Controls.Add(this.descriptionText);
            this.tabPage2.Controls.Add(this.dateTransaction);
            this.tabPage2.Controls.Add(this.Type);
            this.tabPage2.Controls.Add(this.Montant);
            this.tabPage2.Controls.Add(this.Description);
            this.tabPage2.Controls.Add(this.date);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ajout d\'une transaction";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(152, 346);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(74, 24);
            this.btnActualiser.TabIndex = 13;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // buttAjoutType
            // 
            this.buttAjoutType.Location = new System.Drawing.Point(324, 316);
            this.buttAjoutType.Name = "buttAjoutType";
            this.buttAjoutType.Size = new System.Drawing.Size(27, 24);
            this.buttAjoutType.TabIndex = 12;
            this.buttAjoutType.Text = "...";
            this.buttAjoutType.UseVisualStyleBackColor = true;
            this.buttAjoutType.Click += new System.EventHandler(this.buttAjoutType_Click);
            // 
            // checkPercu
            // 
            this.checkPercu.AutoSize = true;
            this.checkPercu.Location = new System.Drawing.Point(254, 243);
            this.checkPercu.Name = "checkPercu";
            this.checkPercu.Size = new System.Drawing.Size(54, 17);
            this.checkPercu.TabIndex = 11;
            this.checkPercu.Text = "Perçu";
            this.checkPercu.UseVisualStyleBackColor = true;
            // 
            // checkRecette
            // 
            this.checkRecette.AutoSize = true;
            this.checkRecette.Location = new System.Drawing.Point(152, 243);
            this.checkRecette.Name = "checkRecette";
            this.checkRecette.Size = new System.Drawing.Size(64, 17);
            this.checkRecette.TabIndex = 10;
            this.checkRecette.Text = "Recette";
            this.checkRecette.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 100);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ajouter une personne";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAjouterTrans
            // 
            this.btnAjouterTrans.Location = new System.Drawing.Point(152, 389);
            this.btnAjouterTrans.Name = "btnAjouterTrans";
            this.btnAjouterTrans.Size = new System.Drawing.Size(175, 60);
            this.btnAjouterTrans.TabIndex = 8;
            this.btnAjouterTrans.Text = "Ajouter";
            this.btnAjouterTrans.UseVisualStyleBackColor = true;
            this.btnAjouterTrans.Click += new System.EventHandler(this.btnAjouterTrans_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(152, 319);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(166, 21);
            this.comboBoxType.TabIndex = 7;
            // 
            // montantText
            // 
            this.montantText.Location = new System.Drawing.Point(152, 176);
            this.montantText.Name = "montantText";
            this.montantText.Size = new System.Drawing.Size(156, 20);
            this.montantText.TabIndex = 6;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(152, 110);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(230, 20);
            this.descriptionText.TabIndex = 5;
            // 
            // dateTransaction
            // 
            this.dateTransaction.CustomFormat = "dd/mm/yyyy";
            this.dateTransaction.Location = new System.Drawing.Point(152, 46);
            this.dateTransaction.Name = "dateTransaction";
            this.dateTransaction.Size = new System.Drawing.Size(193, 20);
            this.dateTransaction.TabIndex = 4;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(34, 322);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 3;
            this.Type.Text = "Type";
            // 
            // Montant
            // 
            this.Montant.AutoSize = true;
            this.Montant.Location = new System.Drawing.Point(34, 179);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(46, 13);
            this.Montant.TabIndex = 2;
            this.Montant.Text = "Montant";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(34, 113);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(34, 52);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 13);
            this.date.TabIndex = 0;
            this.date.Text = "Date de la dépense";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(797, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suppression d\'une transaction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(797, 487);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Modification d\'une transaction";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(797, 487);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Recapitulatif";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prénom :";
            // 
            // newNomTxt
            // 
            this.newNomTxt.Location = new System.Drawing.Point(587, 155);
            this.newNomTxt.Name = "newNomTxt";
            this.newNomTxt.Size = new System.Drawing.Size(100, 20);
            this.newNomTxt.TabIndex = 16;
            // 
            // newPrenomTxt
            // 
            this.newPrenomTxt.Location = new System.Drawing.Point(587, 198);
            this.newPrenomTxt.Name = "newPrenomTxt";
            this.newPrenomTxt.Size = new System.Drawing.Size(100, 20);
            this.newPrenomTxt.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Budget du mois";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttAjoutType;
        private System.Windows.Forms.CheckBox checkPercu;
        private System.Windows.Forms.CheckBox checkRecette;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAjouterTrans;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox montantText;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.DateTimePicker dateTransaction;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Montant;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPrenomTxt;
        private System.Windows.Forms.TextBox newNomTxt;
    }
}

