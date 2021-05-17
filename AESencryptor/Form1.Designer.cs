
namespace AESencryptor
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.labelImport = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonECB = new System.Windows.Forms.RadioButton();
            this.radioButtonCBC = new System.Windows.Forms.RadioButton();
            this.radioButtonCFB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxPreviewImport = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewImport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelImport);
            this.groupBox1.Controls.Add(this.buttonImport);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1: Import File";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(9, 44);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 28);
            this.buttonImport.TabIndex = 0;
            this.buttonImport.Text = "&Import file...";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // labelImport
            // 
            this.labelImport.AutoSize = true;
            this.labelImport.Location = new System.Drawing.Point(90, 52);
            this.labelImport.Name = "labelImport";
            this.labelImport.Size = new System.Drawing.Size(95, 13);
            this.labelImport.TabIndex = 1;
            this.labelImport.Text = "Please import a file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonCFB);
            this.groupBox2.Controls.Add(this.radioButtonCBC);
            this.groupBox2.Controls.Add(this.radioButtonECB);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2: Select cipher mode";
            // 
            // radioButtonECB
            // 
            this.radioButtonECB.AutoSize = true;
            this.radioButtonECB.Checked = true;
            this.radioButtonECB.Location = new System.Drawing.Point(9, 38);
            this.radioButtonECB.Name = "radioButtonECB";
            this.radioButtonECB.Size = new System.Drawing.Size(157, 17);
            this.radioButtonECB.TabIndex = 0;
            this.radioButtonECB.TabStop = true;
            this.radioButtonECB.Text = "ECB -  Electronic Codebook";
            this.radioButtonECB.UseVisualStyleBackColor = true;
            // 
            // radioButtonCBC
            // 
            this.radioButtonCBC.AutoSize = true;
            this.radioButtonCBC.Location = new System.Drawing.Point(9, 61);
            this.radioButtonCBC.Name = "radioButtonCBC";
            this.radioButtonCBC.Size = new System.Drawing.Size(159, 17);
            this.radioButtonCBC.TabIndex = 1;
            this.radioButtonCBC.Text = "CBC - Cipher Block Chaining";
            this.radioButtonCBC.UseVisualStyleBackColor = true;
            // 
            // radioButtonCFB
            // 
            this.radioButtonCFB.AutoSize = true;
            this.radioButtonCFB.Location = new System.Drawing.Point(9, 84);
            this.radioButtonCFB.Name = "radioButtonCFB";
            this.radioButtonCFB.Size = new System.Drawing.Size(135, 17);
            this.radioButtonCFB.TabIndex = 2;
            this.radioButtonCFB.Text = "CFB - Cipher Feedback";
            this.radioButtonCFB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxKey);
            this.groupBox3.Location = new System.Drawing.Point(12, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3: Enter Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(9, 55);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(306, 20);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.Text = "770A8A65DA156D24EE2A093277530142";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key (Hexadecimal):";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Location = new System.Drawing.Point(9, 42);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 30);
            this.buttonEncrypt.TabIndex = 3;
            this.buttonEncrypt.Text = "&Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonEncrypt);
            this.groupBox4.Location = new System.Drawing.Point(12, 445);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 4: Encrypt and Save";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxPreviewImport
            // 
            this.pictureBoxPreviewImport.Location = new System.Drawing.Point(349, 12);
            this.pictureBoxPreviewImport.Name = "pictureBoxPreviewImport";
            this.pictureBoxPreviewImport.Size = new System.Drawing.Size(492, 533);
            this.pictureBoxPreviewImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreviewImport.TabIndex = 5;
            this.pictureBoxPreviewImport.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 555);
            this.Controls.Add(this.pictureBoxPreviewImport);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelImport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonCFB;
        private System.Windows.Forms.RadioButton radioButtonCBC;
        private System.Windows.Forms.RadioButton radioButtonECB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxPreviewImport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

