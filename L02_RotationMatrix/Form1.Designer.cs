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
            this.components = new System.ComponentModel.Container();
            this.UpDownCout = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRX = new System.Windows.Forms.NumericUpDown();
            this.radioButton_ortogonal = new System.Windows.Forms.RadioButton();
            this.radioButton_perspective = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSpin = new System.Windows.Forms.RadioButton();
            this.radioButtonCube = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveImg = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_track = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpDownCout
            // 
            this.UpDownCout.Location = new System.Drawing.Point(150, 17);
            this.UpDownCout.Maximum = new decimal(new int[] {
            100000,
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
            this.pictureBox1.Location = new System.Drawing.Point(307, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Угол обзора";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(96, 317);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.DecimalPlaces = 3;
            this.numericUpDownZ.Location = new System.Drawing.Point(27, 277);
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
            this.numericUpDownZ.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            this.numericUpDownY.Location = new System.Drawing.Point(27, 245);
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
            this.numericUpDownX.Location = new System.Drawing.Point(27, 213);
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
            this.numericUpDownRZ.Location = new System.Drawing.Point(96, 277);
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
            this.numericUpDownRY.Location = new System.Drawing.Point(96, 245);
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
            this.numericUpDownRX.Location = new System.Drawing.Point(96, 213);
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
            this.radioButton_ortogonal.Location = new System.Drawing.Point(7, 19);
            this.radioButton_ortogonal.Name = "radioButton_ortogonal";
            this.radioButton_ortogonal.Size = new System.Drawing.Size(103, 17);
            this.radioButton_ortogonal.TabIndex = 36;
            this.radioButton_ortogonal.TabStop = true;
            this.radioButton_ortogonal.Text = "Ортогональная";
            this.radioButton_ortogonal.UseVisualStyleBackColor = true;
            this.radioButton_ortogonal.CheckedChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // radioButton_perspective
            // 
            this.radioButton_perspective.AutoSize = true;
            this.radioButton_perspective.Location = new System.Drawing.Point(7, 42);
            this.radioButton_perspective.Name = "radioButton_perspective";
            this.radioButton_perspective.Size = new System.Drawing.Size(104, 17);
            this.radioButton_perspective.TabIndex = 37;
            this.radioButton_perspective.TabStop = true;
            this.radioButton_perspective.Text = "Перспективная";
            this.radioButton_perspective.UseVisualStyleBackColor = true;
            this.radioButton_perspective.CheckedChanged += new System.EventHandler(this.Draw_Changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_perspective);
            this.groupBox1.Controls.Add(this.radioButton_ortogonal);
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 68);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проекция";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSpin);
            this.groupBox2.Controls.Add(this.radioButtonCube);
            this.groupBox2.Location = new System.Drawing.Point(150, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 68);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фигура";
            // 
            // radioButtonSpin
            // 
            this.radioButtonSpin.AutoSize = true;
            this.radioButtonSpin.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSpin.Name = "radioButtonSpin";
            this.radioButtonSpin.Size = new System.Drawing.Size(68, 17);
            this.radioButtonSpin.TabIndex = 39;
            this.radioButtonSpin.TabStop = true;
            this.radioButtonSpin.Text = "Спирали";
            this.radioButtonSpin.UseVisualStyleBackColor = true;
            // 
            // radioButtonCube
            // 
            this.radioButtonCube.AutoSize = true;
            this.radioButtonCube.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCube.Name = "radioButtonCube";
            this.radioButtonCube.Size = new System.Drawing.Size(43, 17);
            this.radioButtonCube.TabIndex = 38;
            this.radioButtonCube.TabStop = true;
            this.radioButtonCube.Text = "Куб";
            this.radioButtonCube.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Положение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Направление";
            // 
            // buttonSaveImg
            // 
            this.buttonSaveImg.Location = new System.Drawing.Point(12, 372);
            this.buttonSaveImg.Name = "buttonSaveImg";
            this.buttonSaveImg.Size = new System.Drawing.Size(131, 26);
            this.buttonSaveImg.TabIndex = 42;
            this.buttonSaveImg.Text = "Сохранить картинку";
            this.buttonSaveImg.UseVisualStyleBackColor = true;
            this.buttonSaveImg.Click += new System.EventHandler(this.buttonSaveImg_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(16, 145);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(265, 45);
            this.trackBar1.TabIndex = 47;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Z";
            // 
            // label_track
            // 
            this.label_track.AutoSize = true;
            this.label_track.Location = new System.Drawing.Point(278, 160);
            this.label_track.Name = "label_track";
            this.label_track.Size = new System.Drawing.Size(13, 13);
            this.label_track.TabIndex = 51;
            this.label_track.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 618);
            this.Controls.Add(this.label_track);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonSaveImg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownRZ);
            this.Controls.Add(this.numericUpDownRY);
            this.Controls.Add(this.numericUpDownRX);
            this.Controls.Add(this.numericUpDownZ);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.UpDownCout);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "Щербинин Григорий 201-325";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UpDownCout;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownRZ;
        private System.Windows.Forms.NumericUpDown numericUpDownRY;
        private System.Windows.Forms.NumericUpDown numericUpDownRX;
        private System.Windows.Forms.RadioButton radioButton_ortogonal;
        private System.Windows.Forms.RadioButton radioButton_perspective;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSpin;
        private System.Windows.Forms.RadioButton radioButtonCube;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveImg;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_track;
    }
}

