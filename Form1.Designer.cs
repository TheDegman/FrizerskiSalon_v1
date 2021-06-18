namespace FrizerskiSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.womenhaircutsBtn = new System.Windows.Forms.Button();
            this.menhaircutBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menHaircuts1 = new FrizerskiSalon.MenHaircuts();
            this.home1 = new FrizerskiSalon.HomeUI();
            this.womenHaircuts1 = new FrizerskiSalon.WomenHaircuts();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.womenhaircutsBtn);
            this.panel1.Controls.Add(this.menhaircutBtn);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 609);
            this.panel1.TabIndex = 0;
            // 
            // womenhaircutsBtn
            // 
            this.womenhaircutsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.womenhaircutsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.womenhaircutsBtn.FlatAppearance.BorderSize = 0;
            this.womenhaircutsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.womenhaircutsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.womenhaircutsBtn.ForeColor = System.Drawing.Color.White;
            this.womenhaircutsBtn.Image = ((System.Drawing.Image)(resources.GetObject("womenhaircutsBtn.Image")));
            this.womenhaircutsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.womenhaircutsBtn.Location = new System.Drawing.Point(0, 240);
            this.womenhaircutsBtn.Name = "womenhaircutsBtn";
            this.womenhaircutsBtn.Size = new System.Drawing.Size(264, 70);
            this.womenhaircutsBtn.TabIndex = 5;
            this.womenhaircutsBtn.Text = "             Women Haircuts";
            this.womenhaircutsBtn.UseVisualStyleBackColor = true;
            this.womenhaircutsBtn.Click += new System.EventHandler(this.womenhaircutsBtn_Click);
            // 
            // menhaircutBtn
            // 
            this.menhaircutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menhaircutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.menhaircutBtn.FlatAppearance.BorderSize = 0;
            this.menhaircutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menhaircutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menhaircutBtn.ForeColor = System.Drawing.Color.White;
            this.menhaircutBtn.Image = ((System.Drawing.Image)(resources.GetObject("menhaircutBtn.Image")));
            this.menhaircutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menhaircutBtn.Location = new System.Drawing.Point(0, 170);
            this.menhaircutBtn.Name = "menhaircutBtn";
            this.menhaircutBtn.Size = new System.Drawing.Size(264, 70);
            this.menhaircutBtn.TabIndex = 4;
            this.menhaircutBtn.Text = "       Men Haircuts";
            this.menhaircutBtn.UseVisualStyleBackColor = true;
            this.menhaircutBtn.Click += new System.EventHandler(this.menhaircutBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutBtn.Image")));
            this.aboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.Location = new System.Drawing.Point(0, 539);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(264, 70);
            this.aboutBtn.TabIndex = 3;
            this.aboutBtn.Text = "      About us";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 100);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(264, 70);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 49F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "TSSB";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(264, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 100);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel4.Controls.Add(this.menHaircuts1);
            this.panel4.Controls.Add(this.home1);
            this.panel4.Controls.Add(this.womenHaircuts1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(264, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(893, 508);
            this.panel4.TabIndex = 2;
            // 
            // menHaircuts1
            // 
            this.menHaircuts1.BackColor = System.Drawing.Color.White;
            this.menHaircuts1.Location = new System.Drawing.Point(0, -3);
            this.menHaircuts1.Name = "menHaircuts1";
            this.menHaircuts1.Size = new System.Drawing.Size(892, 508);
            this.menHaircuts1.TabIndex = 1;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Dock = System.Windows.Forms.DockStyle.Top;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(893, 508);
            this.home1.TabIndex = 0;
            // 
            // womenHaircuts1
            // 
            this.womenHaircuts1.Location = new System.Drawing.Point(0, 0);
            this.womenHaircuts1.Name = "womenHaircuts1";
            this.womenHaircuts1.Size = new System.Drawing.Size(892, 509);
            this.womenHaircuts1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 609);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TSSB";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button menhaircutBtn;
        private System.Windows.Forms.Button womenhaircutsBtn;
        private HomeUI home1;
        private MenHaircuts menHaircuts1;
        private WomenHaircuts womenHaircuts1;
        private System.Windows.Forms.Label label1;
    }
}

