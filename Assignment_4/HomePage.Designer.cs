
namespace Assignment_4
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblInvNum = new System.Windows.Forms.Label();
            this.lblObjName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblNothing = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtInvNum = new System.Windows.Forms.TextBox();
            this.txtObjName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.chkAvailablity = new System.Windows.Forms.CheckBox();
            this.chkOption = new System.Windows.Forms.CheckedListBox();
            this.EpValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(34, 44);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Number";
            // 
            // lblInvNum
            // 
            this.lblInvNum.AutoSize = true;
            this.lblInvNum.Location = new System.Drawing.Point(265, 44);
            this.lblInvNum.Name = "lblInvNum";
            this.lblInvNum.Size = new System.Drawing.Size(91, 13);
            this.lblInvNum.TabIndex = 1;
            this.lblInvNum.Text = "Inventory Number";
            // 
            // lblObjName
            // 
            this.lblObjName.AutoSize = true;
            this.lblObjName.Location = new System.Drawing.Point(34, 84);
            this.lblObjName.Name = "lblObjName";
            this.lblObjName.Size = new System.Drawing.Size(69, 13);
            this.lblObjName.TabIndex = 2;
            this.lblObjName.Text = "Object Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(34, 127);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(265, 127);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Count";
            // 
            // lblNothing
            // 
            this.lblNothing.AutoSize = true;
            this.lblNothing.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNothing.Location = new System.Drawing.Point(92, 2);
            this.lblNothing.Name = "lblNothing";
            this.lblNothing.Size = new System.Drawing.Size(264, 34);
            this.lblNothing.TabIndex = 5;
            this.lblNothing.Text = "Please Fill the following Form ";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(98, 41);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 6;
            // 
            // txtInvNum
            // 
            this.txtInvNum.Location = new System.Drawing.Point(392, 41);
            this.txtInvNum.Name = "txtInvNum";
            this.txtInvNum.Size = new System.Drawing.Size(100, 20);
            this.txtInvNum.TabIndex = 7;
            // 
            // txtObjName
            // 
            this.txtObjName.Location = new System.Drawing.Point(109, 81);
            this.txtObjName.Name = "txtObjName";
            this.txtObjName.Size = new System.Drawing.Size(236, 20);
            this.txtObjName.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(98, 124);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(336, 124);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 10;
            // 
            // dtpDate
            // 
            this.dtpDate.AllowDrop = true;
            this.dtpDate.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpDate.Location = new System.Drawing.Point(442, 78);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(383, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Reg Date";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Location = new System.Drawing.Point(225, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.Location = new System.Drawing.Point(361, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Location = new System.Drawing.Point(508, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvShowData
            // 
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Location = new System.Drawing.Point(12, 248);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.Size = new System.Drawing.Size(692, 190);
            this.dgvShowData.TabIndex = 16;
            // 
            // chkAvailablity
            // 
            this.chkAvailablity.AutoSize = true;
            this.chkAvailablity.Location = new System.Drawing.Point(508, 127);
            this.chkAvailablity.Name = "chkAvailablity";
            this.chkAvailablity.Size = new System.Drawing.Size(115, 17);
            this.chkAvailablity.TabIndex = 17;
            this.chkAvailablity.Text = "Product Availability";
            this.chkAvailablity.UseVisualStyleBackColor = true;
            // 
            // chkOption
            // 
            this.chkOption.BackColor = System.Drawing.Color.Gold;
            this.chkOption.FormattingEnabled = true;
            this.chkOption.Items.AddRange(new object[] {
            "Delivered",
            "Expired ",
            "Item Status"});
            this.chkOption.Location = new System.Drawing.Point(37, 164);
            this.chkOption.Name = "chkOption";
            this.chkOption.Size = new System.Drawing.Size(120, 49);
            this.chkOption.TabIndex = 18;
            // 
            // EpValidator
            // 
            this.EpValidator.ContainerControl = this;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUser.Location = new System.Drawing.Point(677, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 27);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "Login";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.Location = new System.Drawing.Point(722, 424);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 20;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.chkOption);
            this.Controls.Add(this.chkAvailablity);
            this.Controls.Add(this.dgvShowData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtObjName);
            this.Controls.Add(this.txtInvNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNothing);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblObjName);
            this.Controls.Add(this.lblInvNum);
            this.Controls.Add(this.lblNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblInvNum;
        private System.Windows.Forms.Label lblObjName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblNothing;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtInvNum;
        private System.Windows.Forms.TextBox txtObjName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.CheckBox chkAvailablity;
        private System.Windows.Forms.CheckedListBox chkOption;
        private System.Windows.Forms.ErrorProvider EpValidator;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogOut;
    }
}

