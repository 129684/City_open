namespace City_open
{
    partial class Channel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Channel));
            this.Admin_b = new System.Windows.Forms.Button();
            this.User_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Admin_b
            // 
            this.Admin_b.BackgroundImage = global::City_open.Properties.Resources.t0158ecc6d10822557b;
            this.Admin_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admin_b.Location = new System.Drawing.Point(255, 25);
            this.Admin_b.Name = "Admin_b";
            this.Admin_b.Size = new System.Drawing.Size(142, 138);
            this.Admin_b.TabIndex = 1;
            this.Admin_b.UseVisualStyleBackColor = true;
            this.Admin_b.Click += new System.EventHandler(this.Admin_b_Click);
            // 
            // User_b
            // 
            this.User_b.BackgroundImage = global::City_open.Properties.Resources.t012bd5a2d4e4f01bb2;
            this.User_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_b.Location = new System.Drawing.Point(36, 25);
            this.User_b.Name = "User_b";
            this.User_b.Size = new System.Drawing.Size(142, 138);
            this.User_b.TabIndex = 0;
            this.User_b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.User_b.UseVisualStyleBackColor = true;
            this.User_b.Click += new System.EventHandler(this.User_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户登录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(260, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "管理员登录";
            // 
            // Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::City_open.Properties.Resources.t01b3cfdc5aa2da54a5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin_b);
            this.Controls.Add(this.User_b);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Channel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录通道";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Channel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button User_b;
        private System.Windows.Forms.Button Admin_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}