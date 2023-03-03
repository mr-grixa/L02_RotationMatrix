namespace L02_RotationMatrix
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
            this.UpDownCout = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRX = new System.Windows.Forms.NumericUpDown();
            this.radioButton_ortogonal = new System.Windows.Forms.RadioButton();
            this.radioButton_perspective = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRX)).BeginInit();
            this.SuspendLayout();
            // 
            // UpDownCout
            // 
            this.UpDownCout.Location = new System.Drawing.Point(150, 17);
            this.UpDownCout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDownCout.Name = "UpDownCout";
            this.UpDownCout.Size = new System.Drawing.Size(120, 20);
            this.UpDownCout.TabIndex = 3;
            this.UpDownCout.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 12);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(131, 26);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(13, 44);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(131, 26);
            this.buttonLoad.TabIndex = 15;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 44);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 26);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(307, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(57, 133);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Location = new System.Drawing.Point(12, 394);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "label4";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 3;
            this.numericUpDown4.Location = new System.Drawing.Point(12, 420);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 24;
            this.numericUpDown4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "label5";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 3;
            this.numericUpDown5.Location = new System.Drawing.Point(12, 446);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown5.TabIndex = 26;
            this.numericUpDown5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.DecimalPlaces = 3;
            this.numericUpDownZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownZ.Location = new System.Drawing.Point(12, 296);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownZ.TabIndex = 32;
            this.numericUpDownZ.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 3;
            this.numericUpDownY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownY.Location = new System.Drawing.Point(12, 260);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownY.TabIndex = 30;
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 3;
            this.numericUpDownX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownX.Location = new System.Drawing.Point(12, 221);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownX.TabIndex = 28;
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // numericUpDownRZ
            // 
            this.numericUpDownRZ.DecimalPlaces = 3;
            this.numericUpDownRZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRZ.Location = new System.Drawing.Point(92, 296);
            this.numericUpDownRZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownRZ.Name = "numericUpDownRZ";
            this.numericUpDownRZ.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRZ.TabIndex = 35;
            this.numericUpDownRZ.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // numericUpDownRY
            // 
            this.numericUpDownRY.DecimalPlaces = 3;
            this.numericUpDownRY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRY.Location = new System.Drawing.Point(92, 260);
            this.numericUpDownRY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownRY.Name = "numericUpDownRY";
            this.numericUpDownRY.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRY.TabIndex = 34;
            this.numericUpDownRY.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // numericUpDownRX
            // 
            this.numericUpDownRX.DecimalPlaces = 3;
            this.numericUpDownRX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRX.Location = new System.Drawing.Point(92, 221);
            this.numericUpDownRX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownRX.Name = "numericUpDownRX";
            this.numericUpDownRX.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRX.TabIndex = 33;
            this.numericUpDownRX.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // radioButton_ortogonal
            // 
            this.radioButton_ortogonal.AutoSize = true;
            this.radioButton_ortogonal.Location = new System.Drawing.Point(13, 76);
            this.radioButton_ortogonal.Name = "radioButton_ortogonal";
            this.radioButton_ortogonal.Size = new System.Drawing.Size(154, 17);
            this.radioButton_ortogonal.TabIndex = 36;
            this.radioButton_ortogonal.TabStop = true;
            this.radioButton_ortogonal.Text = "Ортогональная проекция";
            this.radioButton_ortogonal.UseVisualStyleBackColor = true;
            this.radioButton_ortogonal.CheckedChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // radioButton_perspective
            // 
            this.radioButton_perspective.AutoSize = true;
            this.radioButton_perspective.Location = new System.Drawing.Point(12, 99);
            this.radioButton_perspective.Name = "radioButton_perspective";
            this.radioButton_perspective.Size = new System.Drawing.Size(155, 17);
            this.radioButton_perspective.TabIndex = 37;
            this.radioButton_perspective.TabStop = true;
            this.radioButton_perspective.Text = "Перспективная проекция";
            this.radioButton_perspective.UseVisualStyleBackColor = true;
            this.radioButton_perspective.CheckedChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 618);
            this.Controls.Add(this.radioButton_perspective);
            this.Controls.Add(this.radioButton_ortogonal);
            this.Controls.Add(this.numericUpDownRZ);
            this.Controls.Add(this.numericUpDownRY);
            this.Controls.Add(this.numericUpDownRX);
            this.Controls.Add(this.numericUpDownZ);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.UpDownCout);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UpDownCout;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownRZ;
        private System.Windows.Forms.NumericUpDown numericUpDownRY;
        private System.Windows.Forms.NumericUpDown numericUpDownRX;
        private System.Windows.Forms.RadioButton radioButton_ortogonal;
        private System.Windows.Forms.RadioButton radioButton_perspective;
    }
}

