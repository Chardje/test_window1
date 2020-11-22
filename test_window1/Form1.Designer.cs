namespace test_window1
{
    partial class MainForm
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
            this.Vvod_the_text = new System.Windows.Forms.Button();
            this.TextForm = new System.Windows.Forms.Label();
            this.Play_zanovo = new System.Windows.Forms.Button();
            this.TextMin = new System.Windows.Forms.Label();
            this.TextMax = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.NumericUpDown();
            this.textBoxMin = new System.Windows.Forms.NumericUpDown();
            this.inputBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Vvod_the_text
            // 
            this.Vvod_the_text.Enabled = false;
            this.Vvod_the_text.Location = new System.Drawing.Point(179, 250);
            this.Vvod_the_text.Name = "Vvod_the_text";
            this.Vvod_the_text.Size = new System.Drawing.Size(222, 23);
            this.Vvod_the_text.TabIndex = 10;
            this.Vvod_the_text.Text = "Ввод текста из поля";
            this.Vvod_the_text.UseVisualStyleBackColor = true;
            this.Vvod_the_text.Visible = false;
            this.Vvod_the_text.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextForm
            // 
            this.TextForm.AutoSize = true;
            this.TextForm.Enabled = false;
            this.TextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextForm.Location = new System.Drawing.Point(133, 116);
            this.TextForm.Name = "TextForm";
            this.TextForm.Size = new System.Drawing.Size(329, 48);
            this.TextForm.TabIndex = 1;
            this.TextForm.Text = "Введите число, которое по вашему\r\nмнению загадал бот, в поле ниже.";
            this.TextForm.Visible = false;
            this.TextForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // Play_zanovo
            // 
            this.Play_zanovo.Enabled = false;
            this.Play_zanovo.Location = new System.Drawing.Point(179, 288);
            this.Play_zanovo.Name = "Play_zanovo";
            this.Play_zanovo.Size = new System.Drawing.Size(222, 23);
            this.Play_zanovo.TabIndex = 3;
            this.Play_zanovo.Text = "Играть заново";
            this.Play_zanovo.UseVisualStyleBackColor = true;
            this.Play_zanovo.Visible = false;
            this.Play_zanovo.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextMin
            // 
            this.TextMin.AutoSize = true;
            this.TextMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextMin.Location = new System.Drawing.Point(210, 189);
            this.TextMin.Name = "TextMin";
            this.TextMin.Size = new System.Drawing.Size(31, 15);
            this.TextMin.TabIndex = 5;
            this.TextMin.Text = "Min";
            this.TextMin.Visible = false;
            // 
            // TextMax
            // 
            this.TextMax.AutoSize = true;
            this.TextMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextMax.Location = new System.Drawing.Point(340, 189);
            this.TextMax.Name = "TextMax";
            this.TextMax.Size = new System.Drawing.Size(34, 15);
            this.TextMax.TabIndex = 6;
            this.TextMax.Text = "Max";
            this.TextMax.Visible = false;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(325, 215);
            this.textBoxMax.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.textBoxMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(76, 20);
            this.textBoxMax.TabIndex = 3;
            this.textBoxMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxMax.Visible = false;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(179, 215);
            this.textBoxMin.Maximum = new decimal(new int[] {
            31999,
            0,
            0,
            0});
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(76, 20);
            this.textBoxMin.TabIndex = 2;
            this.textBoxMin.Visible = false;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(179, 189);
            this.inputBox.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(222, 20);
            this.inputBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.TextMax);
            this.Controls.Add(this.TextMin);
            this.Controls.Add(this.Play_zanovo);
            this.Controls.Add(this.TextForm);
            this.Controls.Add(this.Vvod_the_text);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vvod_the_text;
        private System.Windows.Forms.Label TextForm;
        private System.Windows.Forms.Button Play_zanovo;
        private System.Windows.Forms.Label TextMin;
        private System.Windows.Forms.Label TextMax;
        private System.Windows.Forms.NumericUpDown textBoxMax;
        private System.Windows.Forms.NumericUpDown textBoxMin;
        private System.Windows.Forms.NumericUpDown inputBox;
    }
}

