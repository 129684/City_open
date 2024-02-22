namespace City_open
{
    partial class Findpwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Findpwd));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ent_b = new System.Windows.Forms.Button();
            this.esc_b = new System.Windows.Forms.Button();
            this.tpwd_text = new City_open.Wate();
            this.pwd_text = new City_open.Wate();
            this.ID_text = new City_open.Wate();
            this.Name_text = new City_open.Wate();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(370, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "证件号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(401, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(339, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "确认密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(401, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "密码：";
            // 
            // ent_b
            // 
            this.ent_b.BackColor = System.Drawing.Color.DodgerBlue;
            this.ent_b.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ent_b.Location = new System.Drawing.Point(375, 481);
            this.ent_b.Name = "ent_b";
            this.ent_b.Size = new System.Drawing.Size(118, 46);
            this.ent_b.TabIndex = 19;
            this.ent_b.Text = "确认";
            this.ent_b.UseVisualStyleBackColor = false;
            this.ent_b.Click += new System.EventHandler(this.ent_b_Click);
            // 
            // esc_b
            // 
            this.esc_b.BackColor = System.Drawing.Color.DodgerBlue;
            this.esc_b.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.esc_b.Location = new System.Drawing.Point(622, 481);
            this.esc_b.Name = "esc_b";
            this.esc_b.Size = new System.Drawing.Size(118, 46);
            this.esc_b.TabIndex = 20;
            this.esc_b.Text = "取消";
            this.esc_b.UseVisualStyleBackColor = false;
            this.esc_b.Click += new System.EventHandler(this.esc_b_Click);
            // 
            // tpwd_text
            // 
            this.tpwd_text.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpwd_text.Location = new System.Drawing.Point(513, 371);
            this.tpwd_text.MaxLength = 16;
            this.tpwd_text.Name = "tpwd_text";
            this.tpwd_text.Size = new System.Drawing.Size(227, 35);
            this.tpwd_text.TabIndex = 16;
            this.tpwd_text.WatermarkText = "请确认你的密码";
            // 
            // pwd_text
            // 
            this.pwd_text.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwd_text.Location = new System.Drawing.Point(513, 285);
            this.pwd_text.MaxLength = 16;
            this.pwd_text.Name = "pwd_text";
            this.pwd_text.Size = new System.Drawing.Size(227, 35);
            this.pwd_text.TabIndex = 16;
            this.pwd_text.WatermarkText = "请输入你的密码";
            // 
            // ID_text
            // 
            this.ID_text.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ID_text.Location = new System.Drawing.Point(513, 199);
            this.ID_text.MaxLength = 18;
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(227, 35);
            this.ID_text.TabIndex = 18;
            this.ID_text.WatermarkText = "请输入你的证件号";
            // 
            // Name_text
            // 
            this.Name_text.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_text.Location = new System.Drawing.Point(513, 113);
            this.Name_text.MaxLength = 50;
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(227, 35);
            this.Name_text.TabIndex = 12;
            this.Name_text.WatermarkText = "请输入你的姓名";
            // 
            // Findpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::City_open.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.esc_b);
            this.Controls.Add(this.ent_b);
            this.Controls.Add(this.tpwd_text);
            this.Controls.Add(this.pwd_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Findpwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "找回密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Findpwd_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wate ID_text;
        private Wate Name_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Wate tpwd_text;
        private Wate pwd_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ent_b;
        private System.Windows.Forms.Button esc_b;
    }
}