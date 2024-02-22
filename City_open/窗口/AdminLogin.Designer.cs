namespace City_open
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.pwd_text = new City_open.Wate();
            this.ID_text = new City_open.Wate();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.Loginbot = new System.Windows.Forms.Button();
            this.esc_p = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.esc_p)).BeginInit();
            this.SuspendLayout();
            // 
            // pwd_text
            // 
            this.pwd_text.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwd_text.Location = new System.Drawing.Point(395, 277);
            this.pwd_text.MaxLength = 16;
            this.pwd_text.Name = "pwd_text";
            this.pwd_text.PasswordChar = '*';
            this.pwd_text.Size = new System.Drawing.Size(191, 31);
            this.pwd_text.TabIndex = 7;
            this.pwd_text.WatermarkText = "请输入您的密码";
            // 
            // ID_text
            // 
            this.ID_text.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ID_text.Location = new System.Drawing.Point(395, 204);
            this.ID_text.MaxLength = 9;
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(191, 31);
            this.ID_text.TabIndex = 6;
            this.ID_text.WatermarkText = "请输入您的账号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(286, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "密码：";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable1.Location = new System.Drawing.Point(286, 200);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(103, 29);
            this.lable1.TabIndex = 4;
            this.lable1.Text = "账号：";
            // 
            // Loginbot
            // 
            this.Loginbot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Loginbot.Font = new System.Drawing.Font("华文新魏", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Loginbot.ForeColor = System.Drawing.Color.Blue;
            this.Loginbot.Location = new System.Drawing.Point(260, 389);
            this.Loginbot.Name = "Loginbot";
            this.Loginbot.Size = new System.Drawing.Size(350, 50);
            this.Loginbot.TabIndex = 21;
            this.Loginbot.Text = "登  录";
            this.Loginbot.UseVisualStyleBackColor = false;
            this.Loginbot.Click += new System.EventHandler(this.Loginbot_Click);
            // 
            // esc_p
            // 
            this.esc_p.BackColor = System.Drawing.Color.Transparent;
            this.esc_p.BackgroundImage = global::City_open.Properties.Resources.返回1;
            this.esc_p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.esc_p.Location = new System.Drawing.Point(815, 509);
            this.esc_p.Name = "esc_p";
            this.esc_p.Size = new System.Drawing.Size(57, 40);
            this.esc_p.TabIndex = 22;
            this.esc_p.TabStop = false;
            this.esc_p.Click += new System.EventHandler(this.esc_p_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::City_open.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.esc_p);
            this.Controls.Add(this.Loginbot);
            this.Controls.Add(this.pwd_text);
            this.Controls.Add(this.ID_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员登录窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.esc_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wate pwd_text;
        private Wate ID_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button Loginbot;
        private System.Windows.Forms.PictureBox esc_p;
    }
}