namespace WinFormsTelefonBuchmitDB
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnKÄndern = new Button();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtNachname = new TextBox();
            txtVorname = new TextBox();
            txtBoxId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnKÄndern);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtTelefon);
            panel1.Controls.Add(txtNachname);
            panel1.Controls.Add(txtVorname);
            panel1.Controls.Add(txtBoxId);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 175);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11.25F);
            button4.Location = new Point(420, 132);
            button4.Name = "button4";
            button4.Size = new Size(145, 33);
            button4.TabIndex = 14;
            button4.Text = "Beenden";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F);
            button3.Location = new Point(420, 93);
            button3.Name = "button3";
            button3.Size = new Size(145, 33);
            button3.TabIndex = 13;
            button3.Text = "Kontakt löschen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.Location = new Point(420, 54);
            button2.Name = "button2";
            button2.Size = new Size(145, 33);
            button2.TabIndex = 12;
            button2.Text = "Kontakt hinzufügen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnKÄndern
            // 
            btnKÄndern.Font = new Font("Segoe UI", 11.25F);
            btnKÄndern.Location = new Point(420, 15);
            btnKÄndern.Name = "btnKÄndern";
            btnKÄndern.Size = new Size(145, 33);
            btnKÄndern.TabIndex = 11;
            btnKÄndern.Text = "Kontakt ändern";
            btnKÄndern.UseVisualStyleBackColor = true;
            btnKÄndern.Click += btnKÄndern_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(337, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(77, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 11.25F);
            txtTelefon.Location = new Point(251, 57);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(77, 27);
            txtTelefon.TabIndex = 9;
            // 
            // txtNachname
            // 
            txtNachname.Font = new Font("Segoe UI", 11.25F);
            txtNachname.Location = new Point(168, 57);
            txtNachname.Name = "txtNachname";
            txtNachname.Size = new Size(77, 27);
            txtNachname.TabIndex = 8;
            // 
            // txtVorname
            // 
            txtVorname.Font = new Font("Segoe UI", 11.25F);
            txtVorname.Location = new Point(83, 57);
            txtVorname.Name = "txtVorname";
            txtVorname.Size = new Size(77, 27);
            txtVorname.TabIndex = 7;
            // 
            // txtBoxId
            // 
            txtBoxId.Enabled = false;
            txtBoxId.Font = new Font("Segoe UI", 11.25F);
            txtBoxId.Location = new Point(20, 57);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(53, 27);
            txtBoxId.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(82, 28);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 5;
            label5.Text = "Vorname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(168, 28);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "Nachname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 1;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(251, 28);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(339, 28);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(591, 275);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnKÄndern;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtNachname;
        private TextBox txtVorname;
        private TextBox txtBoxId;
        private DataGridView dataGridView1;
    }
}
