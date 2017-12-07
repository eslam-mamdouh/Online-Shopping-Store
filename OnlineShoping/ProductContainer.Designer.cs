namespace OnlineShoping
{
    partial class ProductContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductContainer));
            this.button3 = new System.Windows.Forms.Button();
            this.NProPrice = new System.Windows.Forms.Label();
            this.NproDis = new System.Windows.Forms.RichTextBox();
            this.NProName = new System.Windows.Forms.Label();
            this.NProImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NProImg)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(122, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Buy Now";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NProPrice
            // 
            this.NProPrice.AutoSize = true;
            this.NProPrice.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NProPrice.ForeColor = System.Drawing.Color.Teal;
            this.NProPrice.Location = new System.Drawing.Point(17, 246);
            this.NProPrice.Name = "NProPrice";
            this.NProPrice.Size = new System.Drawing.Size(79, 21);
            this.NProPrice.TabIndex = 9;
            this.NProPrice.Text = "500 L.E";
            // 
            // NproDis
            // 
            this.NproDis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.NproDis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NproDis.Location = new System.Drawing.Point(21, 164);
            this.NproDis.Name = "NproDis";
            this.NproDis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.NproDis.Size = new System.Drawing.Size(176, 65);
            this.NproDis.TabIndex = 8;
            this.NproDis.Text = "Eslam mamdouh mohamed mohamed hassan elsaify studies at faculty of computer and i" +
    "nformation scienc";
            // 
            // NProName
            // 
            this.NProName.AutoSize = true;
            this.NProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NProName.Location = new System.Drawing.Point(16, 14);
            this.NProName.Name = "NProName";
            this.NProName.Size = new System.Drawing.Size(122, 20);
            this.NProName.TabIndex = 6;
            this.NProName.Text = "Product Name";
            // 
            // NProImg
            // 
            this.NProImg.Image = ((System.Drawing.Image)(resources.GetObject("NProImg.Image")));
            this.NProImg.Location = new System.Drawing.Point(21, 52);
            this.NProImg.Name = "NProImg";
            this.NProImg.Size = new System.Drawing.Size(176, 106);
            this.NProImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NProImg.TabIndex = 7;
            this.NProImg.TabStop = false;
            // 
            // ProductContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NProPrice);
            this.Controls.Add(this.NproDis);
            this.Controls.Add(this.NProImg);
            this.Controls.Add(this.NProName);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ProductContainer";
            this.Size = new System.Drawing.Size(211, 287);
            this.Load += new System.EventHandler(this.ProductContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NProImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label NProPrice;
        private System.Windows.Forms.RichTextBox NproDis;
        private System.Windows.Forms.PictureBox NProImg;
        private System.Windows.Forms.Label NProName;
    }
}
