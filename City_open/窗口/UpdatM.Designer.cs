namespace City_open
{
    partial class UpdatM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatM));
            this.wate3 = new City_open.Wate();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.wate2 = new City_open.Wate();
            this.wate1 = new City_open.Wate();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wate3
            // 
            this.wate3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wate3.Location = new System.Drawing.Point(168, 144);
            this.wate3.MaxLength = 3;
            this.wate3.Name = "wate3";
            this.wate3.Size = new System.Drawing.Size(168, 29);
            this.wate3.TabIndex = 13;
            this.wate3.WatermarkText = "请输入商品价格";
            this.wate3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wate3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(48, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "类型价格：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(129, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wate2
            // 
            this.wate2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wate2.Location = new System.Drawing.Point(168, 88);
            this.wate2.MaxLength = 3;
            this.wate2.Name = "wate2";
            this.wate2.Size = new System.Drawing.Size(168, 29);
            this.wate2.TabIndex = 10;
            this.wate2.WatermarkText = "请输入商品编号";
            this.wate2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wate2_KeyPress);
            // 
            // wate1
            // 
            this.wate1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wate1.Location = new System.Drawing.Point(168, 27);
            this.wate1.Name = "wate1";
            this.wate1.Size = new System.Drawing.Size(168, 29);
            this.wate1.TabIndex = 9;
            this.wate1.WatermarkText = "请输入商品名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "类型编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "商品名称：";
            // 
            // UpdatM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 282);
            this.Controls.Add(this.wate3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wate2);
            this.Controls.Add(this.wate1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品修改";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdatM_FormClosing);
            this.Load += new System.EventHandler(this.UpdatM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wate wate3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Wate wate2;
        private Wate wate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}