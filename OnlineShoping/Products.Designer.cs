namespace OnlineShoping
{
    partial class Products
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
            this.main_container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // main_container
            // 
            this.main_container.AutoScroll = true;
            this.main_container.Location = new System.Drawing.Point(2, 18);
            this.main_container.Name = "main_container";
            this.main_container.Size = new System.Drawing.Size(732, 425);
            this.main_container.TabIndex = 0;
            this.main_container.Paint += new System.Windows.Forms.PaintEventHandler(this.main_container_Paint);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_container);
            this.Location = new System.Drawing.Point(20, 30);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(696, 462);
            this.Load += new System.EventHandler(this.UserManagment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_container;

    }
}
