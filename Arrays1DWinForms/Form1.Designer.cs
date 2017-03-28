namespace Arrays1DWinForms
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
            this.labelKlk = new System.Windows.Forms.Label();
            this.buttonGeneric = new System.Windows.Forms.Button();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonRozv = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKlk
            // 
            this.labelKlk.AutoSize = true;
            this.labelKlk.BackColor = System.Drawing.Color.Transparent;
            this.labelKlk.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKlk.ForeColor = System.Drawing.Color.Yellow;
            this.labelKlk.Location = new System.Drawing.Point(3, 13);
            this.labelKlk.Name = "labelKlk";
            this.labelKlk.Size = new System.Drawing.Size(161, 19);
            this.labelKlk.TabIndex = 0;
            this.labelKlk.Text = "Кількість елементів:";
            // 
            // buttonGeneric
            // 
            this.buttonGeneric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneric.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGeneric.Location = new System.Drawing.Point(231, 4);
            this.buttonGeneric.Name = "buttonGeneric";
            this.buttonGeneric.Size = new System.Drawing.Size(104, 36);
            this.buttonGeneric.TabIndex = 1;
            this.buttonGeneric.Text = "Генерувати";
            this.buttonGeneric.UseVisualStyleBackColor = true;
            this.buttonGeneric.Click += new System.EventHandler(this.buttonGeneric_Click);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCount.Location = new System.Drawing.Point(174, 11);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(51, 26);
            this.numericUpDownCount.TabIndex = 2;
            this.numericUpDownCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.BackColor = System.Drawing.Color.Transparent;
            this.labelSum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(3, 67);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(52, 19);
            this.labelSum.TabIndex = 3;
            this.labelSum.Text = "Сума:";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(66, 64);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(239, 26);
            this.textBoxSum.TabIndex = 4;
            // 
            // buttonRozv
            // 
            this.buttonRozv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRozv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRozv.Location = new System.Drawing.Point(341, 4);
            this.buttonRozv.Name = "buttonRozv";
            this.buttonRozv.Size = new System.Drawing.Size(100, 36);
            this.buttonRozv.TabIndex = 5;
            this.buttonRozv.Text = "Розв\'язати";
            this.buttonRozv.UseVisualStyleBackColor = true;
            this.buttonRozv.Click += new System.EventHandler(this.buttonRozv_Click);
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(16, 96);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.Size = new System.Drawing.Size(420, 193);
            this.dataGridViewArray.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(448, 295);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.buttonRozv);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.buttonGeneric);
            this.Controls.Add(this.labelKlk);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(464, 333);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №3. Завдання 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKlk;
        private System.Windows.Forms.Button buttonGeneric;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonRozv;
        private System.Windows.Forms.DataGridView dataGridViewArray;
    }
}

