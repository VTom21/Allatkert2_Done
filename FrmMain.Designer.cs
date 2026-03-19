namespace Allatkert2
{
    partial class FrmMain
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
            dataGridView1 = new DataGridView();
            Faj = new DataGridViewTextBoxColumn();
            Név = new DataGridViewTextBoxColumn();
            Életkor = new DataGridViewTextBoxColumn();
            Részleg = new DataGridViewTextBoxColumn();
            Gondozó = new DataGridViewTextBoxColumn();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnSzures = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Faj, Név, Életkor, Részleg, Gondozó });
            dataGridView1.Location = new Point(87, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(567, 378);
            dataGridView1.TabIndex = 0;
            // 
            // Faj
            // 
            Faj.HeaderText = "Faj";
            Faj.Name = "Faj";
            // 
            // Név
            // 
            Név.HeaderText = "Név";
            Név.Name = "Név";
            // 
            // Életkor
            // 
            Életkor.HeaderText = "Életkor";
            Életkor.Name = "Életkor";
            // 
            // Részleg
            // 
            Részleg.HeaderText = "Részleg";
            Részleg.Name = "Részleg";
            // 
            // Gondozó
            // 
            Gondozó.HeaderText = "Gondozó";
            Gondozó.Name = "Gondozó";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 11);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Gondozó:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(151, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Összes...";
            // 
            // btnSzures
            // 
            btnSzures.Location = new Point(317, 8);
            btnSzures.Name = "btnSzures";
            btnSzures.Size = new Size(139, 23);
            btnSzures.TabIndex = 3;
            btnSzures.Text = "Filter";
            btnSzures.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSzures);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Faj;
        private DataGridViewTextBoxColumn Név;
        private DataGridViewTextBoxColumn Életkor;
        private DataGridViewTextBoxColumn Részleg;
        private DataGridViewTextBoxColumn Gondozó;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnSzures;
    }
}
