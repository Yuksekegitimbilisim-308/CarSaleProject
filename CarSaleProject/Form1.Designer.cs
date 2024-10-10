namespace CarSaleProject
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
            btnCarForm = new Button();
            btnSalesMForm = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCarForm
            // 
            btnCarForm.Location = new Point(1, 1);
            btnCarForm.Name = "btnCarForm";
            btnCarForm.Size = new Size(124, 23);
            btnCarForm.TabIndex = 0;
            btnCarForm.Text = "Araç Yönetimi";
            btnCarForm.UseVisualStyleBackColor = true;
            // 
            // btnSalesMForm
            // 
            btnSalesMForm.Location = new Point(131, 1);
            btnSalesMForm.Name = "btnSalesMForm";
            btnSalesMForm.Size = new Size(124, 23);
            btnSalesMForm.TabIndex = 1;
            btnSalesMForm.Text = "Satış Temsilcileri";
            btnSalesMForm.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(904, 265);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalesMForm);
            Controls.Add(btnCarForm);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCarForm;
        private Button btnSalesMForm;
        private DataGridView dataGridView1;
    }
}
