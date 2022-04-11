
namespace praktikum_w8
{
    partial class FormHasilPertandingan
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
            this.comboBoxKiri = new System.Windows.Forms.ComboBox();
            this.comboBoxKanan = new System.Windows.Forms.ComboBox();
            this.labelVS = new System.Windows.Forms.Label();
            this.labelManagerKiri = new System.Windows.Forms.Label();
            this.labelManagerKanan = new System.Windows.Forms.Label();
            this.labelstadium = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKaptenKiri = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKaptenKanan = new System.Windows.Forms.Label();
            this.labelkapasitas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKiri
            // 
            this.comboBoxKiri.FormattingEnabled = true;
            this.comboBoxKiri.Location = new System.Drawing.Point(64, 44);
            this.comboBoxKiri.Name = "comboBoxKiri";
            this.comboBoxKiri.Size = new System.Drawing.Size(197, 28);
            this.comboBoxKiri.TabIndex = 0;
            this.comboBoxKiri.SelectedIndexChanged += new System.EventHandler(this.comboBoxKiri_SelectedIndexChanged);
            this.comboBoxKiri.SelectedValueChanged += new System.EventHandler(this.comboBoxKiri_SelectedValueChanged);
            // 
            // comboBoxKanan
            // 
            this.comboBoxKanan.FormattingEnabled = true;
            this.comboBoxKanan.Location = new System.Drawing.Point(530, 44);
            this.comboBoxKanan.Name = "comboBoxKanan";
            this.comboBoxKanan.Size = new System.Drawing.Size(216, 28);
            this.comboBoxKanan.TabIndex = 1;
            this.comboBoxKanan.SelectedIndexChanged += new System.EventHandler(this.comboBoxKanan_SelectedIndexChanged);
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Location = new System.Drawing.Point(376, 47);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(31, 20);
            this.labelVS.TabIndex = 2;
            this.labelVS.Text = "VS";
            // 
            // labelManagerKiri
            // 
            this.labelManagerKiri.AutoSize = true;
            this.labelManagerKiri.Location = new System.Drawing.Point(146, 124);
            this.labelManagerKiri.Name = "labelManagerKiri";
            this.labelManagerKiri.Size = new System.Drawing.Size(0, 20);
            this.labelManagerKiri.TabIndex = 3;
            // 
            // labelManagerKanan
            // 
            this.labelManagerKanan.AutoSize = true;
            this.labelManagerKanan.Location = new System.Drawing.Point(660, 124);
            this.labelManagerKanan.Name = "labelManagerKanan";
            this.labelManagerKanan.Size = new System.Drawing.Size(0, 20);
            this.labelManagerKanan.TabIndex = 4;
            // 
            // labelstadium
            // 
            this.labelstadium.AutoSize = true;
            this.labelstadium.Location = new System.Drawing.Point(462, 286);
            this.labelstadium.Name = "labelstadium";
            this.labelstadium.Size = new System.Drawing.Size(0, 20);
            this.labelstadium.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(723, 82);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manager :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Captain :";
            // 
            // labelKaptenKiri
            // 
            this.labelKaptenKiri.AutoSize = true;
            this.labelKaptenKiri.Location = new System.Drawing.Point(146, 162);
            this.labelKaptenKiri.Name = "labelKaptenKiri";
            this.labelKaptenKiri.Size = new System.Drawing.Size(0, 20);
            this.labelKaptenKiri.TabIndex = 9;
            this.labelKaptenKiri.Click += new System.EventHandler(this.labelKaptenKiri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Captain :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Manager :";
            // 
            // labelKaptenKanan
            // 
            this.labelKaptenKanan.AutoSize = true;
            this.labelKaptenKanan.Location = new System.Drawing.Point(660, 161);
            this.labelKaptenKanan.Name = "labelKaptenKanan";
            this.labelKaptenKanan.Size = new System.Drawing.Size(0, 20);
            this.labelKaptenKanan.TabIndex = 12;
            // 
            // labelkapasitas
            // 
            this.labelkapasitas.AutoSize = true;
            this.labelkapasitas.Location = new System.Drawing.Point(462, 333);
            this.labelkapasitas.Name = "labelkapasitas";
            this.labelkapasitas.Size = new System.Drawing.Size(0, 20);
            this.labelkapasitas.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stadium :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Capacity :";
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelkapasitas);
            this.Controls.Add(this.labelKaptenKanan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelKaptenKiri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelstadium);
            this.Controls.Add(this.labelManagerKanan);
            this.Controls.Add(this.labelManagerKiri);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.comboBoxKanan);
            this.Controls.Add(this.comboBoxKiri);
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKiri;
        private System.Windows.Forms.ComboBox comboBoxKanan;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.Label labelManagerKiri;
        private System.Windows.Forms.Label labelManagerKanan;
        private System.Windows.Forms.Label labelstadium;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKaptenKiri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKaptenKanan;
        private System.Windows.Forms.Label labelkapasitas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

