namespace Portafolio_Grupo13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnTarea1 = new Button();
            headerPanel = new Panel();
            btnGitHub = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblTituloTareas = new Label();
            lineaTareas = new Panel();
            cardTarea1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            bordeWow = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btnTarea2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            label7 = new Label();
            btnT2 = new Button();
            label8 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label9 = new Label();
            btnT1 = new Button();
            label10 = new Label();
            panel7 = new Panel();
            label13 = new Label();
            panel8 = new Panel();
            label11 = new Label();
            label12 = new Label();
            btnEF = new Button();
            label15 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            label17 = new Label();
            label16 = new Label();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cardTarea1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // btnTarea1
            // 
            btnTarea1.BackColor = Color.FromArgb(108, 92, 231);
            btnTarea1.Cursor = Cursors.Hand;
            btnTarea1.FlatAppearance.BorderSize = 0;
            btnTarea1.FlatStyle = FlatStyle.Flat;
            btnTarea1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarea1.ForeColor = Color.White;
            btnTarea1.Location = new Point(278, 3);
            btnTarea1.Name = "btnTarea1";
            btnTarea1.Size = new Size(47, 84);
            btnTarea1.TabIndex = 0;
            btnTarea1.Text = "Ver";
            btnTarea1.UseVisualStyleBackColor = false;
            btnTarea1.Click += btnTarea1_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(22, 33, 62);
            headerPanel.Controls.Add(btnGitHub);
            headerPanel.Controls.Add(pictureBox1);
            headerPanel.Controls.Add(label1);
            headerPanel.Controls.Add(lblTitulo);
            headerPanel.Controls.Add(lblSubtitulo);
            headerPanel.Location = new Point(40, 40);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(720, 140);
            headerPanel.TabIndex = 4;
            // 
            // btnGitHub
            // 
            btnGitHub.Cursor = Cursors.Hand;
            btnGitHub.FlatStyle = FlatStyle.Flat;
            btnGitHub.Image = (Image)resources.GetObject("btnGitHub.Image");
            btnGitHub.Location = new Point(625, 42);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(75, 78);
            btnGitHub.TabIndex = 8;
            btnGitHub.UseVisualStyleBackColor = true;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 185, 255);
            label1.Location = new Point(145, 100);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 7;
            label1.Text = "C# • .NET • Windows Forms";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(145, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(192, 47);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "GRUPO 13";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(162, 155, 254);
            lblSubtitulo.Location = new Point(145, 70);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(202, 25);
            lblSubtitulo.TabIndex = 6;
            lblSubtitulo.Text = "Portfolio de Proyectos";
            // 
            // lblTituloTareas
            // 
            lblTituloTareas.AutoSize = true;
            lblTituloTareas.BackColor = Color.Transparent;
            lblTituloTareas.FlatStyle = FlatStyle.Flat;
            lblTituloTareas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTareas.ForeColor = Color.White;
            lblTituloTareas.Location = new Point(60, 200);
            lblTituloTareas.Name = "lblTituloTareas";
            lblTituloTareas.Size = new Size(127, 32);
            lblTituloTareas.TabIndex = 5;
            lblTituloTareas.Text = "📋 Tareas";
            // 
            // lineaTareas
            // 
            lineaTareas.BackColor = Color.FromArgb(108, 92, 231);
            lineaTareas.ForeColor = Color.Transparent;
            lineaTareas.Location = new Point(60, 235);
            lineaTareas.Name = "lineaTareas";
            lineaTareas.Size = new Size(100, 3);
            lineaTareas.TabIndex = 6;
            // 
            // cardTarea1
            // 
            cardTarea1.BackColor = Color.FromArgb(22, 33, 62);
            cardTarea1.Controls.Add(label3);
            cardTarea1.Controls.Add(btnTarea1);
            cardTarea1.Controls.Add(label2);
            cardTarea1.Controls.Add(bordeWow);
            cardTarea1.Location = new Point(60, 260);
            cardTarea1.Name = "cardTarea1";
            cardTarea1.Size = new Size(330, 90);
            cardTarea1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(178, 190, 195);
            label3.Location = new Point(25, 50);
            label3.Name = "label3";
            label3.Size = new Size(193, 17);
            label3.TabIndex = 2;
            label3.Text = "Sistema de gestión de tutorías";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 25);
            label2.Name = "label2";
            label2.Size = new Size(247, 25);
            label2.TabIndex = 1;
            label2.Text = "Caso Wow Centro Tutorías";
            // 
            // bordeWow
            // 
            bordeWow.BackColor = Color.FromArgb(108, 92, 231);
            bordeWow.Location = new Point(0, 0);
            bordeWow.Name = "bordeWow";
            bordeWow.Size = new Size(6, 90);
            bordeWow.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 190, 195);
            label4.Location = new Point(25, 50);
            label4.Name = "label4";
            label4.Size = new Size(201, 17);
            label4.TabIndex = 2;
            label4.Text = "Simulador de cajero automático";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 25);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 1;
            label5.Text = "Caso CajeroATM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 33, 62);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnTarea2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(410, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 90);
            panel1.TabIndex = 8;
            // 
            // btnTarea2
            // 
            btnTarea2.BackColor = Color.FromArgb(0, 184, 148);
            btnTarea2.Cursor = Cursors.Hand;
            btnTarea2.FlatAppearance.BorderSize = 0;
            btnTarea2.FlatStyle = FlatStyle.Flat;
            btnTarea2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarea2.ForeColor = Color.White;
            btnTarea2.Location = new Point(276, 3);
            btnTarea2.Name = "btnTarea2";
            btnTarea2.Size = new Size(49, 84);
            btnTarea2.TabIndex = 0;
            btnTarea2.Text = "Ver";
            btnTarea2.UseVisualStyleBackColor = false;
            btnTarea2.Click += btnTarea2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 184, 148);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 90);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 112, 85);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(60, 415);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 3);
            panel3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(60, 380);
            label6.Name = "label6";
            label6.Size = new Size(168, 32);
            label6.TabIndex = 9;
            label6.Text = "🎯 Exámenes";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(22, 33, 62);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btnT2);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(410, 440);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 90);
            panel4.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(225, 112, 85);
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 33);
            label14.Name = "label14";
            label14.Size = new Size(27, 20);
            label14.TabIndex = 4;
            label14.Text = "T2";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(178, 190, 195);
            label7.Location = new Point(60, 45);
            label7.Name = "label7";
            label7.Size = new Size(114, 17);
            label7.TabIndex = 2;
            label7.Text = "Segundo examen";
            // 
            // btnT2
            // 
            btnT2.BackColor = Color.FromArgb(225, 112, 85);
            btnT2.Cursor = Cursors.Hand;
            btnT2.FlatAppearance.BorderSize = 0;
            btnT2.FlatStyle = FlatStyle.Flat;
            btnT2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnT2.ForeColor = Color.White;
            btnT2.Location = new Point(276, 2);
            btnT2.Name = "btnT2";
            btnT2.Size = new Size(51, 84);
            btnT2.TabIndex = 0;
            btnT2.Text = "Próx.";
            btnT2.UseVisualStyleBackColor = false;
            btnT2.Click += btnT2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(60, 20);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 1;
            label8.Text = "Próximamente";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(225, 112, 85);
            panel5.ForeColor = Color.Transparent;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(30, 90);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(22, 33, 62);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(btnT1);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(60, 440);
            panel6.Name = "panel6";
            panel6.Size = new Size(330, 90);
            panel6.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(178, 190, 195);
            label9.Location = new Point(60, 45);
            label9.Name = "label9";
            label9.Size = new Size(208, 17);
            label9.TabIndex = 2;
            label9.Text = "Primer examen - CRUD completo";
            // 
            // btnT1
            // 
            btnT1.BackColor = Color.FromArgb(253, 203, 110);
            btnT1.Cursor = Cursors.Hand;
            btnT1.FlatAppearance.BorderSize = 0;
            btnT1.FlatStyle = FlatStyle.Flat;
            btnT1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnT1.ForeColor = Color.White;
            btnT1.Location = new Point(278, 3);
            btnT1.Name = "btnT1";
            btnT1.Size = new Size(47, 84);
            btnT1.TabIndex = 0;
            btnT1.Text = "Ver";
            btnT1.UseVisualStyleBackColor = false;
            btnT1.Click += btnT1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(60, 20);
            label10.Name = "label10";
            label10.Size = new Size(158, 25);
            label10.TabIndex = 1;
            label10.Text = "Gestor de Tareas";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(253, 203, 110);
            panel7.Controls.Add(label13);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(25, 90);
            panel7.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(0, 33);
            label13.Name = "label13";
            label13.Size = new Size(27, 20);
            label13.TabIndex = 3;
            label13.Text = "T1";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(22, 33, 62);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(btnEF);
            panel8.Controls.Add(label15);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(61, 544);
            panel8.Name = "panel8";
            panel8.Size = new Size(680, 90);
            panel8.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(214, 48, 49);
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(-1, 33);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(25, 20);
            label11.TabIndex = 3;
            label11.Text = "EF";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(178, 190, 195);
            label12.Location = new Point(70, 45);
            label12.Name = "label12";
            label12.Size = new Size(104, 17);
            label12.TabIndex = 2;
            label12.Text = "Evaluación Final";
            // 
            // btnEF
            // 
            btnEF.BackColor = Color.FromArgb(255, 192, 192);
            btnEF.Cursor = Cursors.Hand;
            btnEF.FlatAppearance.BorderSize = 0;
            btnEF.FlatStyle = FlatStyle.Flat;
            btnEF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEF.ForeColor = Color.FromArgb(214, 48, 49);
            btnEF.Location = new Point(597, 2);
            btnEF.Name = "btnEF";
            btnEF.Size = new Size(80, 84);
            btnEF.TabIndex = 0;
            btnEF.Text = "Pendiente";
            btnEF.UseVisualStyleBackColor = false;
            btnEF.Click += btnEF_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(70, 20);
            label15.Name = "label15";
            label15.Size = new Size(129, 25);
            label15.TabIndex = 1;
            label15.Text = "Examen Final";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(214, 48, 49);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(26, 90);
            panel9.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(15, 52, 96);
            panel10.Controls.Add(label17);
            panel10.Controls.Add(label16);
            panel10.Location = new Point(60, 680);
            panel10.Name = "panel10";
            panel10.Size = new Size(680, 80);
            panel10.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.FromArgb(99, 110, 114);
            label17.Location = new Point(233, 41);
            label17.Name = "label17";
            label17.Size = new Size(246, 15);
            label17.TabIndex = 1;
            label17.Text = "Desarrollado con C# y Windows Forms • 2025";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(116, 185, 255);
            label16.Location = new Point(198, 20);
            label16.Name = "label16";
            label16.Size = new Size(303, 21);
            label16.TabIndex = 0;
            label16.Text = "💡 Selecciona un proyecto para comenzar";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 46);
            ClientSize = new Size(834, 911);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(cardTarea1);
            Controls.Add(lineaTareas);
            Controls.Add(lblTituloTareas);
            Controls.Add(headerPanel);
            Controls.Add(panel8);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GRUPO 13 - Portfolio de Proyectos";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cardTarea1.ResumeLayout(false);
            cardTarea1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTarea1;
        private Panel headerPanel;
        private Label lblTitulo;
        private Label label1;
        private Label lblSubtitulo;
        private Label lblTituloTareas;
        private Panel lineaTareas;
        private Panel cardTarea1;
        private Panel bordeWow;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button btnTarea2;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private Panel panel4;
        private Label label7;
        private Button btnT2;
        private Label label8;
        private Panel panel5;
        private Panel panel6;
        private Label label9;
        private Button btnT1;
        private Label label10;
        private Panel panel7;
        private Label label13;
        private Label label14;
        private Panel panel8;
        private Label label11;
        private Label label12;
        private Button btnEF;
        private Label label15;
        private Panel panel9;
        private Panel panel10;
        private Label label16;
        private PictureBox pictureBox1;
        private Label label17;
        private Button btnGitHub;
    }
}
