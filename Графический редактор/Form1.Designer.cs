namespace Графический_редактор
{
    partial class ГрафическийРедактор
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tool_comboBox = new System.Windows.Forms.ComboBox();
            this.toolColor_comboBox = new System.Windows.Forms.ComboBox();
            this.thickness_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clear_button = new System.Windows.Forms.Button();
            this.backgroundColor_comboBox = new System.Windows.Forms.ComboBox();
            this.backgroundColor_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 548);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tool_comboBox
            // 
            this.tool_comboBox.FormattingEnabled = true;
            this.tool_comboBox.Items.AddRange(new object[] {
            "Карандаш",
            "Прямоугольник",
            "Эллипс",
            "Линия"});
            this.tool_comboBox.Location = new System.Drawing.Point(669, 65);
            this.tool_comboBox.Name = "tool_comboBox";
            this.tool_comboBox.Size = new System.Drawing.Size(117, 21);
            this.tool_comboBox.TabIndex = 1;
            // 
            // toolColor_comboBox
            // 
            this.toolColor_comboBox.FormattingEnabled = true;
            this.toolColor_comboBox.Items.AddRange(new object[] {
            "Black",
            "White",
            "Blue",
            "Red",
            "Yellow",
            "Green"});
            this.toolColor_comboBox.Location = new System.Drawing.Point(701, 104);
            this.toolColor_comboBox.Name = "toolColor_comboBox";
            this.toolColor_comboBox.Size = new System.Drawing.Size(117, 21);
            this.toolColor_comboBox.TabIndex = 2;
            // 
            // thickness_numericUpDown
            // 
            this.thickness_numericUpDown.Location = new System.Drawing.Point(688, 145);
            this.thickness_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thickness_numericUpDown.Name = "thickness_numericUpDown";
            this.thickness_numericUpDown.Size = new System.Drawing.Size(33, 20);
            this.thickness_numericUpDown.TabIndex = 3;
            this.thickness_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(600, 235);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(63, 27);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // backgroundColor_comboBox
            // 
            this.backgroundColor_comboBox.FormattingEnabled = true;
            this.backgroundColor_comboBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Blue",
            "Green",
            "Yellow"});
            this.backgroundColor_comboBox.Location = new System.Drawing.Point(667, 184);
            this.backgroundColor_comboBox.Name = "backgroundColor_comboBox";
            this.backgroundColor_comboBox.Size = new System.Drawing.Size(117, 21);
            this.backgroundColor_comboBox.TabIndex = 5;
            // 
            // backgroundColor_button1
            // 
            this.backgroundColor_button1.Location = new System.Drawing.Point(698, 237);
            this.backgroundColor_button1.Name = "backgroundColor_button1";
            this.backgroundColor_button1.Size = new System.Drawing.Size(63, 25);
            this.backgroundColor_button1.TabIndex = 6;
            this.backgroundColor_button1.Text = "Фон";
            this.backgroundColor_button1.UseVisualStyleBackColor = true;
            this.backgroundColor_button1.Click += new System.EventHandler(this.backgroundColor_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Инструмент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цвет инструмента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Толщина линии:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Цвет фона:";
            // 
            // ГрафическийРедактор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 586);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backgroundColor_button1);
            this.Controls.Add(this.backgroundColor_comboBox);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.thickness_numericUpDown);
            this.Controls.Add(this.toolColor_comboBox);
            this.Controls.Add(this.tool_comboBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ГрафическийРедактор";
            this.Text = "Графический редактор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tool_comboBox;
        private System.Windows.Forms.ComboBox toolColor_comboBox;
        private System.Windows.Forms.NumericUpDown thickness_numericUpDown;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.ComboBox backgroundColor_comboBox;
        private System.Windows.Forms.Button backgroundColor_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

