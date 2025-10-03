namespace Json_Api
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
            this.btnArz = new System.Windows.Forms.Button();
            this.btnOghatSharee = new System.Windows.Forms.Button();
            this.txtOghat = new System.Windows.Forms.TextBox();
            this.lisArz = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnArz
            // 
            this.btnArz.Location = new System.Drawing.Point(12, 12);
            this.btnArz.Name = "btnArz";
            this.btnArz.Size = new System.Drawing.Size(262, 23);
            this.btnArz.TabIndex = 0;
            this.btnArz.Text = "نمایش ارز";
            this.btnArz.UseVisualStyleBackColor = true;
            this.btnArz.Click += new System.EventHandler(this.btnArz_Click);
            // 
            // btnOghatSharee
            // 
            this.btnOghatSharee.Location = new System.Drawing.Point(173, 41);
            this.btnOghatSharee.Name = "btnOghatSharee";
            this.btnOghatSharee.Size = new System.Drawing.Size(101, 23);
            this.btnOghatSharee.TabIndex = 1;
            this.btnOghatSharee.Text = "اوقات شرعی";
            this.btnOghatSharee.UseVisualStyleBackColor = true;
            this.btnOghatSharee.Click += new System.EventHandler(this.btnOghatSharee_Click);
            // 
            // txtOghat
            // 
            this.txtOghat.Location = new System.Drawing.Point(12, 43);
            this.txtOghat.Name = "txtOghat";
            this.txtOghat.Size = new System.Drawing.Size(155, 20);
            this.txtOghat.TabIndex = 2;
            this.txtOghat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lisArz
            // 
            this.lisArz.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.price});
            this.lisArz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lisArz.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lisArz.GridLines = true;
            this.lisArz.HideSelection = false;
            this.lisArz.Location = new System.Drawing.Point(0, 70);
            this.lisArz.Name = "lisArz";
            this.lisArz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lisArz.RightToLeftLayout = true;
            this.lisArz.Size = new System.Drawing.Size(286, 316);
            this.lisArz.TabIndex = 3;
            this.lisArz.UseCompatibleStateImageBehavior = false;
            this.lisArz.View = System.Windows.Forms.View.Tile;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 386);
            this.Controls.Add(this.lisArz);
            this.Controls.Add(this.txtOghat);
            this.Controls.Add(this.btnOghatSharee);
            this.Controls.Add(this.btnArz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش وب ای پی آی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArz;
        private System.Windows.Forms.Button btnOghatSharee;
        private System.Windows.Forms.TextBox txtOghat;
        private System.Windows.Forms.ListView lisArz;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
    }
}

