namespace PhoneBookv2
{
    partial class Add_change_Form
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
            this.Name_label = new System.Windows.Forms.Label();
            this.Surname_label = new System.Windows.Forms.Label();
            this.Mail_label = new System.Windows.Forms.Label();
            this.Skype_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Phone_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(48, 95);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(38, 13);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "Name:";
            // 
            // Surname_label
            // 
            this.Surname_label.AutoSize = true;
            this.Surname_label.Location = new System.Drawing.Point(48, 144);
            this.Surname_label.Name = "Surname_label";
            this.Surname_label.Size = new System.Drawing.Size(52, 13);
            this.Surname_label.TabIndex = 1;
            this.Surname_label.Text = "Surname:";
            // 
            // Mail_label
            // 
            this.Mail_label.AutoSize = true;
            this.Mail_label.Location = new System.Drawing.Point(48, 194);
            this.Mail_label.Name = "Mail_label";
            this.Mail_label.Size = new System.Drawing.Size(29, 13);
            this.Mail_label.TabIndex = 2;
            this.Mail_label.Text = "Mail:";
            // 
            // Skype_label
            // 
            this.Skype_label.AutoSize = true;
            this.Skype_label.Location = new System.Drawing.Point(48, 243);
            this.Skype_label.Name = "Skype_label";
            this.Skype_label.Size = new System.Drawing.Size(40, 13);
            this.Skype_label.TabIndex = 3;
            this.Skype_label.Text = "Skype:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 236);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 7;
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.Location = new System.Drawing.Point(348, 88);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(104, 13);
            this.Phone_label.TabIndex = 8;
            this.Phone_label.Text = "Telephone numbers:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.DescriptionNumber});
            this.dataGridView1.Location = new System.Drawing.Point(470, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(282, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // DescriptionNumber
            // 
            this.DescriptionNumber.HeaderText = "DescriptionNumber";
            this.DescriptionNumber.Name = "DescriptionNumber";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(316, 283);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(113, 47);
            this.Add_button.TabIndex = 10;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Add_change_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 354);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Phone_label);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Skype_label);
            this.Controls.Add(this.Mail_label);
            this.Controls.Add(this.Surname_label);
            this.Controls.Add(this.Name_label);
            this.Name = "Add_change_Form";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Surname_label;
        private System.Windows.Forms.Label Mail_label;
        private System.Windows.Forms.Label Skype_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionNumber;
        private System.Windows.Forms.Button Add_button;
    }
}