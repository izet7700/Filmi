namespace filmi
{
    partial class adminForm
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
            this.adminLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zanrComboBox = new System.Windows.Forms.ComboBox();
            this.drzavaComboBox = new System.Windows.Forms.ComboBox();
            this.imeFilmaTextBox = new System.Windows.Forms.TextBox();
            this.letnicaTextBox = new System.Windows.Forms.TextBox();
            this.povp_ocTextBox = new System.Windows.Forms.TextBox();
            this.zaslužekTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.krajComboBox = new System.Windows.Forms.ComboBox();
            this.vrsta_upComboBox = new System.Windows.Forms.ComboBox();
            this.imeupTextBox = new System.Windows.Forms.TextBox();
            this.priimekTextBox = new System.Windows.Forms.TextBox();
            this.dat_rojDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.igralecComboBox = new System.Windows.Forms.ComboBox();
            this.scenaristComboBox = new System.Windows.Forms.ComboBox();
            this.producentComboBox = new System.Windows.Forms.ComboBox();
            this.addActorButton = new System.Windows.Forms.Button();
            this.addWriterButton = new System.Windows.Forms.Button();
            this.producerButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.directorComboBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.directorButton = new System.Windows.Forms.Button();
            this.changePassButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.oldPassMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.newPassMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.viewMoviesButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.priimekChangeTextBox = new System.Windows.Forms.TextBox();
            this.imeChangeTextBox = new System.Windows.Forms.TextBox();
            this.emailChangeTextBox = new System.Windows.Forms.TextBox();
            this.changeVrUpoButton = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.vrsta_upChangeComboBox = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Minion Pro SmBd", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminLabel.Location = new System.Drawing.Point(496, 9);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(122, 28);
            this.adminLabel.TabIndex = 0;
            this.adminLabel.Text = "Hello, admin!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro SmBd", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dodaj film(prvo dodaj film, potem igralce,režiserje...):";
            // 
            // zanrComboBox
            // 
            this.zanrComboBox.FormattingEnabled = true;
            this.zanrComboBox.Location = new System.Drawing.Point(17, 100);
            this.zanrComboBox.Name = "zanrComboBox";
            this.zanrComboBox.Size = new System.Drawing.Size(92, 21);
            this.zanrComboBox.TabIndex = 3;
            this.zanrComboBox.SelectedIndexChanged += new System.EventHandler(this.zanrComboBox_SelectedIndexChanged);
            this.zanrComboBox.Click += new System.EventHandler(this.zanrComboBox_Click);
            // 
            // drzavaComboBox
            // 
            this.drzavaComboBox.FormattingEnabled = true;
            this.drzavaComboBox.Location = new System.Drawing.Point(130, 100);
            this.drzavaComboBox.Name = "drzavaComboBox";
            this.drzavaComboBox.Size = new System.Drawing.Size(94, 21);
            this.drzavaComboBox.TabIndex = 4;
            this.drzavaComboBox.Click += new System.EventHandler(this.drzavaComboBox_Click);
            // 
            // imeFilmaTextBox
            // 
            this.imeFilmaTextBox.Location = new System.Drawing.Point(240, 100);
            this.imeFilmaTextBox.Name = "imeFilmaTextBox";
            this.imeFilmaTextBox.Size = new System.Drawing.Size(118, 20);
            this.imeFilmaTextBox.TabIndex = 5;
            // 
            // letnicaTextBox
            // 
            this.letnicaTextBox.Location = new System.Drawing.Point(376, 100);
            this.letnicaTextBox.Name = "letnicaTextBox";
            this.letnicaTextBox.Size = new System.Drawing.Size(56, 20);
            this.letnicaTextBox.TabIndex = 6;
            // 
            // povp_ocTextBox
            // 
            this.povp_ocTextBox.Location = new System.Drawing.Point(451, 100);
            this.povp_ocTextBox.Name = "povp_ocTextBox";
            this.povp_ocTextBox.Size = new System.Drawing.Size(30, 20);
            this.povp_ocTextBox.TabIndex = 7;
            // 
            // zaslužekTextBox
            // 
            this.zaslužekTextBox.Location = new System.Drawing.Point(501, 100);
            this.zaslužekTextBox.Name = "zaslužekTextBox";
            this.zaslužekTextBox.Size = new System.Drawing.Size(100, 20);
            this.zaslužekTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Žanr:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Iz države:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Leto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Povp.ocena\r\n    (Imdb):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Zaslužek:";
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(17, 140);
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(482, 20);
            this.opisTextBox.TabIndex = 15;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(526, 138);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(75, 23);
            this.addMovieButton.TabIndex = 16;
            this.addMovieButton.Text = "Add movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(31, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dodaj uporabnika:";
            // 
            // krajComboBox
            // 
            this.krajComboBox.FormattingEnabled = true;
            this.krajComboBox.Location = new System.Drawing.Point(23, 289);
            this.krajComboBox.Name = "krajComboBox";
            this.krajComboBox.Size = new System.Drawing.Size(92, 21);
            this.krajComboBox.TabIndex = 18;
            this.krajComboBox.Click += new System.EventHandler(this.krajComboBox_Click);
            // 
            // vrsta_upComboBox
            // 
            this.vrsta_upComboBox.FormattingEnabled = true;
            this.vrsta_upComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.vrsta_upComboBox.Location = new System.Drawing.Point(135, 289);
            this.vrsta_upComboBox.Name = "vrsta_upComboBox";
            this.vrsta_upComboBox.Size = new System.Drawing.Size(50, 21);
            this.vrsta_upComboBox.TabIndex = 19;
            this.vrsta_upComboBox.SelectedIndexChanged += new System.EventHandler(this.vrsta_upComboBox_SelectedIndexChanged);
            // 
            // imeupTextBox
            // 
            this.imeupTextBox.Location = new System.Drawing.Point(203, 289);
            this.imeupTextBox.Name = "imeupTextBox";
            this.imeupTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeupTextBox.TabIndex = 20;
            // 
            // priimekTextBox
            // 
            this.priimekTextBox.Location = new System.Drawing.Point(309, 289);
            this.priimekTextBox.Name = "priimekTextBox";
            this.priimekTextBox.Size = new System.Drawing.Size(100, 20);
            this.priimekTextBox.TabIndex = 21;
            // 
            // dat_rojDateTimePicker
            // 
            this.dat_rojDateTimePicker.Location = new System.Drawing.Point(423, 289);
            this.dat_rojDateTimePicker.Name = "dat_rojDateTimePicker";
            this.dat_rojDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.dat_rojDateTimePicker.TabIndex = 22;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(23, 333);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(162, 20);
            this.emailTextBox.TabIndex = 23;
            // 
            // passwordMaskedTextBox
            // 
            this.passwordMaskedTextBox.Location = new System.Drawing.Point(203, 334);
            this.passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            this.passwordMaskedTextBox.PasswordChar = '*';
            this.passwordMaskedTextBox.Size = new System.Drawing.Size(160, 20);
            this.passwordMaskedTextBox.TabIndex = 24;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(381, 334);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Opis:";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(531, 331);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 27;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // igralecComboBox
            // 
            this.igralecComboBox.FormattingEnabled = true;
            this.igralecComboBox.Location = new System.Drawing.Point(18, 182);
            this.igralecComboBox.Name = "igralecComboBox";
            this.igralecComboBox.Size = new System.Drawing.Size(121, 21);
            this.igralecComboBox.TabIndex = 28;
            this.igralecComboBox.Click += new System.EventHandler(this.igralecComboBox_Click);
            // 
            // scenaristComboBox
            // 
            this.scenaristComboBox.FormattingEnabled = true;
            this.scenaristComboBox.Location = new System.Drawing.Point(216, 181);
            this.scenaristComboBox.Name = "scenaristComboBox";
            this.scenaristComboBox.Size = new System.Drawing.Size(121, 21);
            this.scenaristComboBox.TabIndex = 29;
            this.scenaristComboBox.Click += new System.EventHandler(this.scenaristComboBox_Click);
            // 
            // producentComboBox
            // 
            this.producentComboBox.FormattingEnabled = true;
            this.producentComboBox.Location = new System.Drawing.Point(421, 181);
            this.producentComboBox.Name = "producentComboBox";
            this.producentComboBox.Size = new System.Drawing.Size(121, 21);
            this.producentComboBox.TabIndex = 30;
            this.producentComboBox.Click += new System.EventHandler(this.producentComboBox_Click);
            // 
            // addActorButton
            // 
            this.addActorButton.Location = new System.Drawing.Point(145, 179);
            this.addActorButton.Name = "addActorButton";
            this.addActorButton.Size = new System.Drawing.Size(65, 23);
            this.addActorButton.TabIndex = 31;
            this.addActorButton.Text = "Add";
            this.addActorButton.UseVisualStyleBackColor = true;
            this.addActorButton.Click += new System.EventHandler(this.addActorButton_Click);
            // 
            // addWriterButton
            // 
            this.addWriterButton.Location = new System.Drawing.Point(343, 180);
            this.addWriterButton.Name = "addWriterButton";
            this.addWriterButton.Size = new System.Drawing.Size(72, 23);
            this.addWriterButton.TabIndex = 32;
            this.addWriterButton.Text = "Add";
            this.addWriterButton.UseVisualStyleBackColor = true;
            this.addWriterButton.Click += new System.EventHandler(this.addWriterButton_Click);
            // 
            // producerButton
            // 
            this.producerButton.Location = new System.Drawing.Point(548, 179);
            this.producerButton.Name = "producerButton";
            this.producerButton.Size = new System.Drawing.Size(53, 23);
            this.producerButton.TabIndex = 33;
            this.producerButton.Text = "Add";
            this.producerButton.UseVisualStyleBackColor = true;
            this.producerButton.Click += new System.EventHandler(this.producerButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Kraj:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Vrsta upor.:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Ime in priimek:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(420, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Datum rojstva:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "email:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(200, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "password:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(384, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "telefon:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(420, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Producent:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(224, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Scenarist:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 166);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Igralec:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // directorComboBox
            // 
            this.directorComboBox.FormattingEnabled = true;
            this.directorComboBox.Location = new System.Drawing.Point(423, 227);
            this.directorComboBox.Name = "directorComboBox";
            this.directorComboBox.Size = new System.Drawing.Size(121, 21);
            this.directorComboBox.TabIndex = 44;
            this.directorComboBox.Click += new System.EventHandler(this.directorComboBox_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(420, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "Režiser:";
            // 
            // directorButton
            // 
            this.directorButton.Location = new System.Drawing.Point(548, 225);
            this.directorButton.Name = "directorButton";
            this.directorButton.Size = new System.Drawing.Size(53, 23);
            this.directorButton.TabIndex = 46;
            this.directorButton.Text = "Add";
            this.directorButton.UseVisualStyleBackColor = true;
            this.directorButton.Click += new System.EventHandler(this.directorButton_Click);
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(145, 457);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(65, 23);
            this.changePassButton.TabIndex = 47;
            this.changePassButton.Text = "Change";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(14, 371);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(176, 20);
            this.label22.TabIndex = 48;
            this.label22.Text = "Spremeni geslo računa:";
            // 
            // oldPassMaskedTextBox
            // 
            this.oldPassMaskedTextBox.Location = new System.Drawing.Point(23, 419);
            this.oldPassMaskedTextBox.Name = "oldPassMaskedTextBox";
            this.oldPassMaskedTextBox.PasswordChar = '*';
            this.oldPassMaskedTextBox.Size = new System.Drawing.Size(116, 20);
            this.oldPassMaskedTextBox.TabIndex = 49;
            // 
            // newPassMaskedTextBox
            // 
            this.newPassMaskedTextBox.Location = new System.Drawing.Point(23, 460);
            this.newPassMaskedTextBox.Name = "newPassMaskedTextBox";
            this.newPassMaskedTextBox.PasswordChar = '*';
            this.newPassMaskedTextBox.Size = new System.Drawing.Size(116, 20);
            this.newPassMaskedTextBox.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 403);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "Stari password:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(23, 442);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "Novi password:";
            // 
            // viewMoviesButton
            // 
            this.viewMoviesButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.viewMoviesButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMoviesButton.ForeColor = System.Drawing.SystemColors.Info;
            this.viewMoviesButton.Location = new System.Drawing.Point(469, 371);
            this.viewMoviesButton.Name = "viewMoviesButton";
            this.viewMoviesButton.Size = new System.Drawing.Size(137, 109);
            this.viewMoviesButton.TabIndex = 53;
            this.viewMoviesButton.Text = "View movies";
            this.viewMoviesButton.UseVisualStyleBackColor = false;
            this.viewMoviesButton.Click += new System.EventHandler(this.viewMoviesButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(212, 371);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(202, 20);
            this.label25.TabIndex = 54;
            this.label25.Text = "Spremeni vrsto uporabnika:";
            // 
            // priimekChangeTextBox
            // 
            this.priimekChangeTextBox.Location = new System.Drawing.Point(329, 419);
            this.priimekChangeTextBox.Name = "priimekChangeTextBox";
            this.priimekChangeTextBox.Size = new System.Drawing.Size(113, 20);
            this.priimekChangeTextBox.TabIndex = 55;
            // 
            // imeChangeTextBox
            // 
            this.imeChangeTextBox.Location = new System.Drawing.Point(216, 419);
            this.imeChangeTextBox.Name = "imeChangeTextBox";
            this.imeChangeTextBox.Size = new System.Drawing.Size(108, 20);
            this.imeChangeTextBox.TabIndex = 56;
            // 
            // emailChangeTextBox
            // 
            this.emailChangeTextBox.Location = new System.Drawing.Point(216, 460);
            this.emailChangeTextBox.Name = "emailChangeTextBox";
            this.emailChangeTextBox.Size = new System.Drawing.Size(108, 20);
            this.emailChangeTextBox.TabIndex = 57;
            // 
            // changeVrUpoButton
            // 
            this.changeVrUpoButton.Location = new System.Drawing.Point(385, 458);
            this.changeVrUpoButton.Name = "changeVrUpoButton";
            this.changeVrUpoButton.Size = new System.Drawing.Size(65, 23);
            this.changeVrUpoButton.TabIndex = 58;
            this.changeVrUpoButton.Text = "Change";
            this.changeVrUpoButton.UseVisualStyleBackColor = true;
            this.changeVrUpoButton.Click += new System.EventHandler(this.changeVrUpoButton_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(213, 403);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 13);
            this.label26.TabIndex = 59;
            this.label26.Text = "Ime:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(326, 403);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 13);
            this.label27.TabIndex = 60;
            this.label27.Text = "Priimek:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(213, 442);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 13);
            this.label28.TabIndex = 61;
            this.label28.Text = "email:";
            // 
            // vrsta_upChangeComboBox
            // 
            this.vrsta_upChangeComboBox.FormattingEnabled = true;
            this.vrsta_upChangeComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.vrsta_upChangeComboBox.Location = new System.Drawing.Point(329, 459);
            this.vrsta_upChangeComboBox.Name = "vrsta_upChangeComboBox";
            this.vrsta_upChangeComboBox.Size = new System.Drawing.Size(50, 21);
            this.vrsta_upChangeComboBox.TabIndex = 62;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(325, 442);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(61, 13);
            this.label29.TabIndex = 63;
            this.label29.Text = "Vrsta upor.:";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 492);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.vrsta_upChangeComboBox);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.changeVrUpoButton);
            this.Controls.Add(this.emailChangeTextBox);
            this.Controls.Add(this.imeChangeTextBox);
            this.Controls.Add(this.priimekChangeTextBox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.viewMoviesButton);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.newPassMaskedTextBox);
            this.Controls.Add(this.oldPassMaskedTextBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.changePassButton);
            this.Controls.Add(this.directorButton);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.directorComboBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.producerButton);
            this.Controls.Add(this.addWriterButton);
            this.Controls.Add(this.addActorButton);
            this.Controls.Add(this.producentComboBox);
            this.Controls.Add(this.scenaristComboBox);
            this.Controls.Add(this.igralecComboBox);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.passwordMaskedTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.dat_rojDateTimePicker);
            this.Controls.Add(this.priimekTextBox);
            this.Controls.Add(this.imeupTextBox);
            this.Controls.Add(this.vrsta_upComboBox);
            this.Controls.Add(this.krajComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zaslužekTextBox);
            this.Controls.Add(this.povp_ocTextBox);
            this.Controls.Add(this.letnicaTextBox);
            this.Controls.Add(this.imeFilmaTextBox);
            this.Controls.Add(this.drzavaComboBox);
            this.Controls.Add(this.zanrComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminLabel);
            this.MaximizeBox = false;
            this.Name = "adminForm";
            this.Text = "Admin panel-Movies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox zanrComboBox;
        private System.Windows.Forms.ComboBox drzavaComboBox;
        private System.Windows.Forms.TextBox imeFilmaTextBox;
        private System.Windows.Forms.TextBox letnicaTextBox;
        private System.Windows.Forms.TextBox povp_ocTextBox;
        private System.Windows.Forms.TextBox zaslužekTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox krajComboBox;
        private System.Windows.Forms.ComboBox vrsta_upComboBox;
        private System.Windows.Forms.TextBox imeupTextBox;
        private System.Windows.Forms.TextBox priimekTextBox;
        private System.Windows.Forms.DateTimePicker dat_rojDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox passwordMaskedTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ComboBox igralecComboBox;
        private System.Windows.Forms.ComboBox scenaristComboBox;
        private System.Windows.Forms.ComboBox producentComboBox;
        private System.Windows.Forms.Button addActorButton;
        private System.Windows.Forms.Button addWriterButton;
        private System.Windows.Forms.Button producerButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox directorComboBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button directorButton;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox oldPassMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox newPassMaskedTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button viewMoviesButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox priimekChangeTextBox;
        private System.Windows.Forms.TextBox imeChangeTextBox;
        private System.Windows.Forms.TextBox emailChangeTextBox;
        private System.Windows.Forms.Button changeVrUpoButton;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox vrsta_upChangeComboBox;
        private System.Windows.Forms.Label label29;
    }
}