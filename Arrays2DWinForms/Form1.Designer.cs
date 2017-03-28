namespace Arrays2DWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.buttonRozv = new System.Windows.Forms.Button();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.numericUpDownCows = new System.Windows.Forms.NumericUpDown();
            this.buttonGeneric = new System.Windows.Forms.Button();
            this.labelRows = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.labelCows = new System.Windows.Forms.Label();
            this.dataGridViewMin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMatrix.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(36, 143);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(402, 116);
            this.dataGridViewMatrix.TabIndex = 13;
            // 
            // buttonRozv
            // 
            this.buttonRozv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRozv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRozv.Location = new System.Drawing.Point(356, 13);
            this.buttonRozv.Name = "buttonRozv";
            this.buttonRozv.Size = new System.Drawing.Size(100, 36);
            this.buttonRozv.TabIndex = 12;
            this.buttonRozv.Text = "Розв\'язати";
            this.buttonRozv.UseVisualStyleBackColor = true;
            this.buttonRozv.Click += new System.EventHandler(this.buttonRozv_Click);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMax.Location = new System.Drawing.Point(86, 111);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(88, 26);
            this.textBoxMax.TabIndex = 11;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.BackColor = System.Drawing.Color.Transparent;
            this.labelMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax.Location = new System.Drawing.Point(23, 114);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(46, 19);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "Max:";
            // 
            // numericUpDownCows
            // 
            this.numericUpDownCows.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCows.Location = new System.Drawing.Point(189, 20);
            this.numericUpDownCows.Name = "numericUpDownCows";
            this.numericUpDownCows.Size = new System.Drawing.Size(51, 26);
            this.numericUpDownCows.TabIndex = 9;
            this.numericUpDownCows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonGeneric
            // 
            this.buttonGeneric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneric.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGeneric.Location = new System.Drawing.Point(246, 13);
            this.buttonGeneric.Name = "buttonGeneric";
            this.buttonGeneric.Size = new System.Drawing.Size(104, 36);
            this.buttonGeneric.TabIndex = 8;
            this.buttonGeneric.Text = "Генерувати";
            this.buttonGeneric.UseVisualStyleBackColor = true;
            this.buttonGeneric.Click += new System.EventHandler(this.buttonGeneric_Click);
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.BackColor = System.Drawing.Color.Transparent;
            this.labelRows.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRows.Location = new System.Drawing.Point(18, 22);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(134, 19);
            this.labelRows.TabIndex = 7;
            this.labelRows.Text = "Кількість рядків:";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRows.Location = new System.Drawing.Point(189, 59);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(51, 26);
            this.numericUpDownRows.TabIndex = 15;
            this.numericUpDownRows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelCows
            // 
            this.labelCows.AutoSize = true;
            this.labelCows.BackColor = System.Drawing.Color.Transparent;
            this.labelCows.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCows.Location = new System.Drawing.Point(18, 61);
            this.labelCows.Name = "labelCows";
            this.labelCows.Size = new System.Drawing.Size(150, 19);
            this.labelCows.TabIndex = 14;
            this.labelCows.Text = "Кількість стовпців:";
            // 
            // dataGridViewMin
            // 
            this.dataGridViewMin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMin.Location = new System.Drawing.Point(35, 265);
            this.dataGridViewMin.Name = "dataGridViewMin";
            this.dataGridViewMin.Size = new System.Drawing.Size(403, 71);
            this.dataGridViewMin.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 358);
            this.Controls.Add(this.dataGridViewMin);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.labelCows);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.buttonRozv);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.numericUpDownCows);
            this.Controls.Add(this.buttonGeneric);
            this.Controls.Add(this.labelRows);
            this.MinimumSize = new System.Drawing.Size(481, 396);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №3. Завдання 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button buttonRozv;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.NumericUpDown numericUpDownCows;
        private System.Windows.Forms.Button buttonGeneric;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Label labelCows;
        private System.Windows.Forms.DataGridView dataGridViewMin;
    }
}

