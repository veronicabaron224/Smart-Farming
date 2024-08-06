
namespace CAL_Lab4
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.title_lbl = new System.Windows.Forms.Label();
            this.data_lbl = new System.Windows.Forms.Label();
            this.low_lbl = new System.Windows.Forms.Label();
            this.med_lbl = new System.Windows.Forms.Label();
            this.high_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connect_btn = new System.Windows.Forms.Button();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.switch_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar.ForeColor = System.Drawing.Color.SpringGreen;
            this.progressBar.Location = new System.Drawing.Point(65, 139);
            this.progressBar.Maximum = 999;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(262, 63);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_lbl.Location = new System.Drawing.Point(291, 36);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(232, 29);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "SMART  FARMING";
            // 
            // data_lbl
            // 
            this.data_lbl.AutoSize = true;
            this.data_lbl.BackColor = System.Drawing.Color.Transparent;
            this.data_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_lbl.ForeColor = System.Drawing.Color.Black;
            this.data_lbl.Location = new System.Drawing.Point(135, 113);
            this.data_lbl.Name = "data_lbl";
            this.data_lbl.Size = new System.Drawing.Size(123, 17);
            this.data_lbl.TabIndex = 2;
            this.data_lbl.Text = "Soil Moisture Data";
            // 
            // low_lbl
            // 
            this.low_lbl.AutoSize = true;
            this.low_lbl.BackColor = System.Drawing.Color.Transparent;
            this.low_lbl.Location = new System.Drawing.Point(62, 223);
            this.low_lbl.Name = "low_lbl";
            this.low_lbl.Size = new System.Drawing.Size(33, 17);
            this.low_lbl.TabIndex = 3;
            this.low_lbl.Text = "Wet";
            // 
            // med_lbl
            // 
            this.med_lbl.AutoSize = true;
            this.med_lbl.BackColor = System.Drawing.Color.Transparent;
            this.med_lbl.Location = new System.Drawing.Point(172, 223);
            this.med_lbl.Name = "med_lbl";
            this.med_lbl.Size = new System.Drawing.Size(48, 17);
            this.med_lbl.TabIndex = 4;
            this.med_lbl.Text = "Humid";
            // 
            // high_lbl
            // 
            this.high_lbl.AutoSize = true;
            this.high_lbl.BackColor = System.Drawing.Color.Transparent;
            this.high_lbl.Location = new System.Drawing.Point(296, 223);
            this.high_lbl.Name = "high_lbl";
            this.high_lbl.Size = new System.Drawing.Size(30, 17);
            this.high_lbl.TabIndex = 5;
            this.high_lbl.Text = "Dry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(604, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Motor Manual Control";
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(283, 357);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(102, 36);
            this.connect_btn.TabIndex = 8;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Location = new System.Drawing.Point(428, 357);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(101, 36);
            this.disconnect_btn.TabIndex = 9;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // switch_btn
            // 
            this.switch_btn.Location = new System.Drawing.Point(636, 242);
            this.switch_btn.Name = "switch_btn";
            this.switch_btn.Size = new System.Drawing.Size(75, 23);
            this.switch_btn.TabIndex = 10;
            this.switch_btn.Text = "ON";
            this.switch_btn.UseVisualStyleBackColor = true;
            this.switch_btn.Click += new System.EventHandler(this.switch_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CAL_Lab4.Properties.Resources.water_pump_vector;
            this.pictureBox1.Location = new System.Drawing.Point(600, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAL_Lab4.Properties.Resources.Green_Watercolor_Leaves_Blank_Page_Notes_A4_Document;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.switch_btn);
            this.Controls.Add(this.disconnect_btn);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.high_lbl);
            this.Controls.Add(this.med_lbl);
            this.Controls.Add(this.low_lbl);
            this.Controls.Add(this.data_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label data_lbl;
        private System.Windows.Forms.Label low_lbl;
        private System.Windows.Forms.Label med_lbl;
        private System.Windows.Forms.Label high_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.Button switch_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

