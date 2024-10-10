namespace CarSaleProject
{
    partial class CarManagement
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
            txtModel = new TextBox();
            dataGridView1 = new DataGridView();
            txtColor = new TextBox();
            txtCaseType = new TextBox();
            txtFuelType = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddCar = new Button();
            btnUpdateCar = new Button();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtModel
            // 
            txtModel.Location = new Point(12, 28);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(131, 23);
            txtModel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(564, 133);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(12, 77);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(131, 23);
            txtColor.TabIndex = 2;
            // 
            // txtCaseType
            // 
            txtCaseType.Location = new Point(181, 28);
            txtCaseType.Name = "txtCaseType";
            txtCaseType.Size = new Size(131, 23);
            txtCaseType.TabIndex = 3;
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new Point(181, 77);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(131, 23);
            txtFuelType.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(342, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 23);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 6;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Yakıt Tipi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 10);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Kasa Tipi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 59);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 9;
            label4.Text = "Renk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(342, 10);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Marka";
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(12, 106);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(75, 23);
            btnAddCar.TabIndex = 11;
            btnAddCar.Text = "Araç Ekle";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnUpdateCar
            // 
            btnUpdateCar.Location = new Point(113, 106);
            btnUpdateCar.Name = "btnUpdateCar";
            btnUpdateCar.Size = new Size(98, 23);
            btnUpdateCar.TabIndex = 12;
            btnUpdateCar.Text = "Araç Güncelle";
            btnUpdateCar.UseVisualStyleBackColor = true;
            btnUpdateCar.Click += btnUpdateCar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(342, 77);
            txtId.Name = "txtId";
            txtId.Size = new Size(40, 23);
            txtId.TabIndex = 13;
            // 
            // CarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 280);
            Controls.Add(txtId);
            Controls.Add(btnUpdateCar);
            Controls.Add(btnAddCar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtFuelType);
            Controls.Add(txtCaseType);
            Controls.Add(txtColor);
            Controls.Add(dataGridView1);
            Controls.Add(txtModel);
            Name = "CarManagement";
            Text = "CarManagement";
            Load += CarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModel;
        private DataGridView dataGridView1;
        private TextBox txtColor;
        private TextBox txtCaseType;
        private TextBox txtFuelType;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddCar;
        private Button btnUpdateCar;
        private TextBox txtId;
    }
}