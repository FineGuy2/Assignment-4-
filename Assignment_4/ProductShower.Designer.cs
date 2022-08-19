
namespace Assignment_4
{
    partial class ProductShower
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
            this.lblPSId = new System.Windows.Forms.Label();
            this.lblPSName = new System.Windows.Forms.Label();
            this.lblPSPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPSId
            // 
            this.lblPSId.AutoSize = true;
            this.lblPSId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSId.Location = new System.Drawing.Point(15, 21);
            this.lblPSId.Name = "lblPSId";
            this.lblPSId.Size = new System.Drawing.Size(54, 16);
            this.lblPSId.TabIndex = 0;
            this.lblPSId.Text = "Item Id";
            // 
            // lblPSName
            // 
            this.lblPSName.AutoSize = true;
            this.lblPSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSName.Location = new System.Drawing.Point(16, 61);
            this.lblPSName.Name = "lblPSName";
            this.lblPSName.Size = new System.Drawing.Size(53, 16);
            this.lblPSName.TabIndex = 1;
            this.lblPSName.Text = "Name ";
            // 
            // lblPSPrice
            // 
            this.lblPSPrice.AutoSize = true;
            this.lblPSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSPrice.Location = new System.Drawing.Point(16, 102);
            this.lblPSPrice.Name = "lblPSPrice";
            this.lblPSPrice.Size = new System.Drawing.Size(48, 16);
            this.lblPSPrice.TabIndex = 2;
            this.lblPSPrice.Text = "Price ";
            // 
            // ProductShower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPSPrice);
            this.Controls.Add(this.lblPSName);
            this.Controls.Add(this.lblPSId);
            this.Name = "ProductShower";
            this.Size = new System.Drawing.Size(570, 149);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPSId;
        private System.Windows.Forms.Label lblPSName;
        private System.Windows.Forms.Label lblPSPrice;
    }
}
