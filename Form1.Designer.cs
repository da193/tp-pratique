namespace tp_pratique
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            nom = new TextBox();
            prenom = new TextBox();
            email = new TextBox();
            submit = new Button();
            naissance = new TextBox();
            telephone = new TextBox();
            gender = new RadioButton();
            gender2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ListesDesEtudiants = new DataGridView();
            update = new Button();
            la = new Label();
            ((System.ComponentModel.ISupportInitialize)ListesDesEtudiants).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(7, 629);
            button1.Name = "button1";
            button1.Size = new Size(147, 32);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nom
            // 
            nom.BackColor = Color.Pink;
            nom.Location = new Point(113, 21);
            nom.Name = "nom";
            nom.PlaceholderText = "entrez votre nom";
            nom.Size = new Size(264, 27);
            nom.TabIndex = 1;
            nom.TextChanged += textBox1_TextChanged;
            // 
            // prenom
            // 
            prenom.BackColor = Color.Pink;
            prenom.Location = new Point(113, 73);
            prenom.Name = "prenom";
            prenom.PlaceholderText = "entrez votre prenom";
            prenom.Size = new Size(264, 27);
            prenom.TabIndex = 2;
            prenom.TextChanged += prenom_TextChanged;
            // 
            // email
            // 
            email.BackColor = Color.Pink;
            email.Location = new Point(113, 179);
            email.Name = "email";
            email.PlaceholderText = "entrez votre e-mail";
            email.Size = new Size(264, 27);
            email.TabIndex = 3;
            email.TextChanged += email_TextChanged;
            // 
            // submit
            // 
            submit.BackColor = Color.DarkSlateGray;
            submit.ForeColor = Color.LavenderBlush;
            submit.Location = new Point(29, 405);
            submit.Name = "submit";
            submit.Size = new Size(160, 45);
            submit.TabIndex = 4;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += button2_Click;
            // 
            // naissance
            // 
            naissance.BackColor = Color.Pink;
            naissance.Location = new Point(113, 127);
            naissance.Name = "naissance";
            naissance.PlaceholderText = "Entrez votre naissance";
            naissance.Size = new Size(264, 27);
            naissance.TabIndex = 5;
            naissance.TextChanged += naissance_TextChanged;
            // 
            // telephone
            // 
            telephone.BackColor = Color.Pink;
            telephone.Location = new Point(117, 230);
            telephone.Name = "telephone";
            telephone.PlaceholderText = "entrez votre telephone";
            telephone.Size = new Size(260, 27);
            telephone.TabIndex = 6;
            telephone.TextChanged += telephne_TextChanged;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(117, 282);
            gender.Name = "gender";
            gender.Size = new Size(43, 24);
            gender.TabIndex = 7;
            gender.TabStop = true;
            gender.Text = "M";
            gender.UseVisualStyleBackColor = true;
            gender.CheckedChanged += gender_CheckedChanged;
            // 
            // gender2
            // 
            gender2.AutoSize = true;
            gender2.Location = new Point(117, 321);
            gender2.Name = "gender2";
            gender2.Size = new Size(37, 24);
            gender2.TabIndex = 8;
            gender2.TabStop = true;
            gender2.Text = "F";
            gender2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 76);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 10;
            label2.Text = "Prenom : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(0, 130);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 11;
            label3.Text = "Date of birth :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 182);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 12;
            label4.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 233);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 13;
            label5.Text = "telepone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 284);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 14;
            label6.Text = "Sex :";
            // 
            // ListesDesEtudiants
            // 
            ListesDesEtudiants.BackgroundColor = Color.Cyan;
            ListesDesEtudiants.BorderStyle = BorderStyle.Fixed3D;
            ListesDesEtudiants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListesDesEtudiants.GridColor = Color.Blue;
            ListesDesEtudiants.Location = new Point(410, 12);
            ListesDesEtudiants.Name = "ListesDesEtudiants";
            ListesDesEtudiants.RowHeadersWidth = 51;
            ListesDesEtudiants.Size = new Size(1073, 577);
            ListesDesEtudiants.TabIndex = 16;
            ListesDesEtudiants.CellContentClick += ListesDesEtudiants_CellContentClick;
            // 
            // update
            // 
            update.Location = new Point(209, 405);
            update.Name = "update";
            update.Size = new Size(129, 45);
            update.TabIndex = 17;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // la
            // 
            la.AutoSize = true;
            la.Location = new Point(44, 28);
            la.Name = "la";
            la.Size = new Size(56, 20);
            la.TabIndex = 18;
            la.Text = "Name :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 780);
            Controls.Add(la);
            Controls.Add(update);
            Controls.Add(ListesDesEtudiants);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gender2);
            Controls.Add(gender);
            Controls.Add(telephone);
            Controls.Add(naissance);
            Controls.Add(submit);
            Controls.Add(email);
            Controls.Add(prenom);
            Controls.Add(nom);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ListesDesEtudiants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox nom;
        private TextBox prenom;
        private TextBox email;
        private Button submit;
        private TextBox naissance;
        private TextBox telephone;
        private RadioButton gender;
        private RadioButton gender2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView ListesDesEtudiants;
        private Button update;
        private Label la;
    }
}
