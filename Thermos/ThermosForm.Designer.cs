namespace Thermos
{
    partial class ThermosForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buildValButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diameterThermosUpDown1 = new Thermos.ParameterUpDown();
            this.lengthThermosUpDown1 = new Thermos.ParameterUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.diameterThermosUpDown2 = new Thermos.ParameterUpDown();
            this.lengthThermosUpDown2 = new Thermos.ParameterUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.diameterThermosUpDown3 = new Thermos.ParameterUpDown();
            this.lengthThermosUpDown3 = new Thermos.ParameterUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.diameterThermosUpDown4 = new Thermos.ParameterUpDown();
            this.lengthThermosUpDown4 = new Thermos.ParameterUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.parameterUpDown1 = new Thermos.ParameterUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.diameterThermosUpDown5 = new Thermos.ParameterUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 32;
            // 
            // buildValButton
            // 
            this.buildValButton.Location = new System.Drawing.Point(356, 274);
            this.buildValButton.Name = "buildValButton";
            this.buildValButton.Size = new System.Drawing.Size(109, 34);
            this.buildValButton.TabIndex = 26;
            this.buildValButton.Text = "Построить";
            this.buildValButton.UseVisualStyleBackColor = true;
            this.buildValButton.Click += new System.EventHandler(this.BuildVal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diameterThermosUpDown1);
            this.groupBox1.Controls.Add(this.lengthThermosUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 71);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размеры дна корпуса";
            // 
            // diameterThermosUpDown1
            // 
            this.diameterThermosUpDown1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diameterThermosUpDown1.Location = new System.Drawing.Point(88, 45);
            this.diameterThermosUpDown1.Name = "diameterThermosUpDown1";
            this.diameterThermosUpDown1.Parameter = null;
            this.diameterThermosUpDown1.Size = new System.Drawing.Size(106, 20);
            this.diameterThermosUpDown1.TabIndex = 3;
            // 
            // lengthThermosUpDown1
            // 
            this.lengthThermosUpDown1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lengthThermosUpDown1.Location = new System.Drawing.Point(88, 19);
            this.lengthThermosUpDown1.Name = "lengthThermosUpDown1";
            this.lengthThermosUpDown1.Parameter = null;
            this.lengthThermosUpDown1.Size = new System.Drawing.Size(106, 20);
            this.lengthThermosUpDown1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Диаметр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Длина";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.diameterThermosUpDown2);
            this.groupBox2.Controls.Add(this.lengthThermosUpDown2);
            this.groupBox2.Location = new System.Drawing.Point(6, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 71);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размеры стенок корпуса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Диаметр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Длина";
            // 
            // diameterThermosUpDown2
            // 
            this.diameterThermosUpDown2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diameterThermosUpDown2.Location = new System.Drawing.Point(88, 45);
            this.diameterThermosUpDown2.Name = "diameterThermosUpDown2";
            this.diameterThermosUpDown2.Parameter = null;
            this.diameterThermosUpDown2.Size = new System.Drawing.Size(106, 20);
            this.diameterThermosUpDown2.TabIndex = 1;
            // 
            // lengthThermosUpDown2
            // 
            this.lengthThermosUpDown2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lengthThermosUpDown2.Location = new System.Drawing.Point(88, 19);
            this.lengthThermosUpDown2.Name = "lengthThermosUpDown2";
            this.lengthThermosUpDown2.Parameter = null;
            this.lengthThermosUpDown2.Size = new System.Drawing.Size(106, 20);
            this.lengthThermosUpDown2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.diameterThermosUpDown3);
            this.groupBox3.Controls.Add(this.lengthThermosUpDown3);
            this.groupBox3.Location = new System.Drawing.Point(6, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 71);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Размеры горлышка корпуса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Диаметр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Длина";
            // 
            // diameterThermosUpDown3
            // 
            this.diameterThermosUpDown3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diameterThermosUpDown3.Location = new System.Drawing.Point(88, 45);
            this.diameterThermosUpDown3.Name = "diameterThermosUpDown3";
            this.diameterThermosUpDown3.Parameter = null;
            this.diameterThermosUpDown3.Size = new System.Drawing.Size(106, 20);
            this.diameterThermosUpDown3.TabIndex = 1;
            // 
            // lengthThermosUpDown3
            // 
            this.lengthThermosUpDown3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lengthThermosUpDown3.Location = new System.Drawing.Point(88, 19);
            this.lengthThermosUpDown3.Name = "lengthThermosUpDown3";
            this.lengthThermosUpDown3.Parameter = null;
            this.lengthThermosUpDown3.Size = new System.Drawing.Size(106, 20);
            this.lengthThermosUpDown3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.diameterThermosUpDown4);
            this.groupBox4.Controls.Add(this.lengthThermosUpDown4);
            this.groupBox4.Location = new System.Drawing.Point(6, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 71);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Размеры пробки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Диаметр";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Длина";
            // 
            // diameterThermosUpDown4
            // 
            this.diameterThermosUpDown4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diameterThermosUpDown4.Location = new System.Drawing.Point(88, 45);
            this.diameterThermosUpDown4.Name = "diameterThermosUpDown4";
            this.diameterThermosUpDown4.Parameter = null;
            this.diameterThermosUpDown4.Size = new System.Drawing.Size(106, 20);
            this.diameterThermosUpDown4.TabIndex = 1;
            // 
            // lengthThermosUpDown4
            // 
            this.lengthThermosUpDown4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lengthThermosUpDown4.Location = new System.Drawing.Point(88, 18);
            this.lengthThermosUpDown4.Name = "lengthThermosUpDown4";
            this.lengthThermosUpDown4.Parameter = null;
            this.lengthThermosUpDown4.Size = new System.Drawing.Size(106, 20);
            this.lengthThermosUpDown4.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.parameterUpDown1);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.diameterThermosUpDown5);
            this.groupBox5.Location = new System.Drawing.Point(243, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 85);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Размеры крышки";
            // 
            // parameterUpDown1
            // 
            this.parameterUpDown1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.parameterUpDown1.Location = new System.Drawing.Point(92, 45);
            this.parameterUpDown1.Name = "parameterUpDown1";
            this.parameterUpDown1.Parameter = null;
            this.parameterUpDown1.Size = new System.Drawing.Size(106, 20);
            this.parameterUpDown1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Диаметр";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Длина";
            // 
            // diameterThermosUpDown5
            // 
            this.diameterThermosUpDown5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diameterThermosUpDown5.Location = new System.Drawing.Point(92, 19);
            this.diameterThermosUpDown5.Name = "diameterThermosUpDown5";
            this.diameterThermosUpDown5.Parameter = null;
            this.diameterThermosUpDown5.Size = new System.Drawing.Size(106, 20);
            this.diameterThermosUpDown5.TabIndex = 1;
            // 
            // ThermosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 508);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buildValButton);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(535, 547);
            this.MinimumSize = new System.Drawing.Size(535, 547);
            this.Name = "ThermosForm";
            this.Text = "Построение термоса";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buildValButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private ParameterUpDown diameterThermosUpDown1;
        private ParameterUpDown lengthThermosUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ParameterUpDown diameterThermosUpDown2;
        private ParameterUpDown lengthThermosUpDown2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private ParameterUpDown diameterThermosUpDown3;
        private ParameterUpDown lengthThermosUpDown3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private ParameterUpDown diameterThermosUpDown4;
        private ParameterUpDown lengthThermosUpDown4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private ParameterUpDown diameterThermosUpDown5;  
        private ParameterUpDown parameterUpDown1;
    }
}

