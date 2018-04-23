namespace lot1api
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
            this.nom_Ent = new System.Windows.Forms.Label();
            this.secteurs = new System.Windows.Forms.Label();
            this.son_Per = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nomEntreprise = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.RadioButton();
            this.Dep = new System.Windows.Forms.RadioButton();
            this.Nat = new System.Windows.Forms.RadioButton();
            this.date_creation = new System.Windows.Forms.DateTimePicker();
            this.secteurs_textbox = new System.Windows.Forms.TextBox();
            this.bValide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nom_Ent
            // 
            this.nom_Ent.AutoSize = true;
            this.nom_Ent.Location = new System.Drawing.Point(69, 107);
            this.nom_Ent.Name = "nom_Ent";
            this.nom_Ent.Size = new System.Drawing.Size(97, 13);
            this.nom_Ent.TabIndex = 0;
            this.nom_Ent.Text = "Nom de l\'entreprise";
            this.nom_Ent.Click += new System.EventHandler(this.label1_Click);
            // 
            // secteurs
            // 
            this.secteurs.AutoSize = true;
            this.secteurs.Location = new System.Drawing.Point(69, 253);
            this.secteurs.Name = "secteurs";
            this.secteurs.Size = new System.Drawing.Size(70, 13);
            this.secteurs.TabIndex = 1;
            this.secteurs.Text = "Ses Secteurs";
            // 
            // son_Per
            // 
            this.son_Per.AutoSize = true;
            this.son_Per.Location = new System.Drawing.Point(69, 182);
            this.son_Per.Name = "son_Per";
            this.son_Per.Size = new System.Drawing.Size(75, 13);
            this.son_Per.TabIndex = 2;
            this.son_Per.Text = "Son périmetre ";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(69, 348);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(30, 13);
            this.date.TabIndex = 3;
            this.date.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // nomEntreprise
            // 
            this.nomEntreprise.Location = new System.Drawing.Point(239, 107);
            this.nomEntreprise.Name = "nomEntreprise";
            this.nomEntreprise.Size = new System.Drawing.Size(291, 20);
            this.nomEntreprise.TabIndex = 8;
            this.nomEntreprise.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loc
            // 
            this.loc.AutoSize = true;
            this.loc.Location = new System.Drawing.Point(253, 182);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(51, 17);
            this.loc.TabIndex = 12;
            this.loc.TabStop = true;
            this.loc.Text = "Local";
            this.loc.UseVisualStyleBackColor = true;
            // 
            // Dep
            // 
            this.Dep.AutoSize = true;
            this.Dep.Location = new System.Drawing.Point(414, 182);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(94, 17);
            this.Dep.TabIndex = 13;
            this.Dep.TabStop = true;
            this.Dep.Text = "Départemental";
            this.Dep.UseVisualStyleBackColor = true;
            // 
            // Nat
            // 
            this.Nat.AutoSize = true;
            this.Nat.Location = new System.Drawing.Point(615, 182);
            this.Nat.Name = "Nat";
            this.Nat.Size = new System.Drawing.Size(64, 17);
            this.Nat.TabIndex = 14;
            this.Nat.TabStop = true;
            this.Nat.Text = "National";
            this.Nat.UseVisualStyleBackColor = true;
            // 
            // date_creation
            // 
            this.date_creation.CustomFormat = "dd/MM/yy  HH:mm:ss";
            this.date_creation.Location = new System.Drawing.Point(239, 348);
            this.date_creation.Name = "date_creation";
            this.date_creation.Size = new System.Drawing.Size(291, 20);
            this.date_creation.TabIndex = 18;
            // 
            // secteurs_textbox
            // 
            this.secteurs_textbox.Location = new System.Drawing.Point(239, 250);
            this.secteurs_textbox.Multiline = true;
            this.secteurs_textbox.Name = "secteurs_textbox";
            this.secteurs_textbox.Size = new System.Drawing.Size(302, 45);
            this.secteurs_textbox.TabIndex = 19;
            // 
            // bValide
            // 
            this.bValide.Location = new System.Drawing.Point(97, 448);
            this.bValide.Name = "bValide";
            this.bValide.Size = new System.Drawing.Size(156, 28);
            this.bValide.TabIndex = 20;
            this.bValide.Text = "valider";
            this.bValide.UseVisualStyleBackColor = true;
            this.bValide.Click += new System.EventHandler(this.bValide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 550);
            this.Controls.Add(this.bValide);
            this.Controls.Add(this.secteurs_textbox);
            this.Controls.Add(this.date_creation);
            this.Controls.Add(this.Nat);
            this.Controls.Add(this.Dep);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.nomEntreprise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date);
            this.Controls.Add(this.son_Per);
            this.Controls.Add(this.secteurs);
            this.Controls.Add(this.nom_Ent);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom_Ent;
        private System.Windows.Forms.Label secteurs;
        private System.Windows.Forms.Label son_Per;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nomEntreprise;
        private System.Windows.Forms.RadioButton loc;
        private System.Windows.Forms.RadioButton Dep;
        private System.Windows.Forms.RadioButton Nat;
        private System.Windows.Forms.DateTimePicker date_creation;
        private System.Windows.Forms.TextBox secteurs_textbox;
        private System.Windows.Forms.Button bValide;
    }
}

