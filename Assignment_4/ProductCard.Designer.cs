
namespace Assignment_4
{
    partial class ProductCard
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
            this.lblPcId = new System.Windows.Forms.Label();
            this.lblPcName = new System.Windows.Forms.Label();
            this.lblPcPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPcId
            // 
            this.lblPcId.AutoSize = true;
            this.lblPcId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcId.Location = new System.Drawing.Point(35, 20);
            this.lblPcId.Name = "lblPcId";
            this.lblPcId.Size = new System.Drawing.Size(74, 20);
            this.lblPcId.TabIndex = 0;
            this.lblPcId.Text = "Product Id";
            // 
            // lblPcName
            // 
            this.lblPcName.AutoSize = true;
            this.lblPcName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcName.Location = new System.Drawing.Point(35, 60);
            this.lblPcName.Name = "lblPcName";
            this.lblPcName.Size = new System.Drawing.Size(88, 20);
            this.lblPcName.TabIndex = 1;
            this.lblPcName.Text = "Object Name";
            // 
            // lblPcPrice
            // 
            this.lblPcPrice.AutoSize = true;
            this.lblPcPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcPrice.Location = new System.Drawing.Point(35, 104);
            this.lblPcPrice.Name = "lblPcPrice";
            this.lblPcPrice.Size = new System.Drawing.Size(41, 20);
            this.lblPcPrice.TabIndex = 2;
            this.lblPcPrice.Text = "Price";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPcPrice);
            this.Controls.Add(this.lblPcName);
            this.Controls.Add(this.lblPcId);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(507, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPcId;
        private System.Windows.Forms.Label lblPcName;
        private System.Windows.Forms.Label lblPcPrice;
    }
}
