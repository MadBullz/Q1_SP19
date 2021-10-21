
namespace Q1
{
    partial class CorporationListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCorp = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.corpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(795, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 38);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Corporation";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvCorp
            // 
            this.dgvCorp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.corpNo,
            this.corpName,
            this.street,
            this.region,
            this.expr_dt,
            this.Edit});
            this.dgvCorp.Location = new System.Drawing.Point(12, 126);
            this.dgvCorp.Name = "dgvCorp";
            this.dgvCorp.RowHeadersWidth = 51;
            this.dgvCorp.RowTemplate.Height = 29;
            this.dgvCorp.Size = new System.Drawing.Size(957, 475);
            this.dgvCorp.TabIndex = 1;
            this.dgvCorp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorp_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 125;
            // 
            // corpNo
            // 
            this.corpNo.DataPropertyName = "corpNo";
            this.corpNo.HeaderText = "Corporation No";
            this.corpNo.MinimumWidth = 6;
            this.corpNo.Name = "corpNo";
            this.corpNo.Width = 125;
            // 
            // corpName
            // 
            this.corpName.DataPropertyName = "corpName";
            this.corpName.HeaderText = "Corporation Name";
            this.corpName.MinimumWidth = 6;
            this.corpName.Name = "corpName";
            this.corpName.Width = 125;
            // 
            // street
            // 
            this.street.DataPropertyName = "street";
            this.street.HeaderText = "Street";
            this.street.MinimumWidth = 6;
            this.street.Name = "street";
            this.street.Width = 125;
            // 
            // region
            // 
            this.region.DataPropertyName = "region";
            this.region.HeaderText = "Region";
            this.region.MinimumWidth = 6;
            this.region.Name = "region";
            this.region.Width = 125;
            // 
            // expr_dt
            // 
            this.expr_dt.DataPropertyName = "expiredDate";
            this.expr_dt.HeaderText = "ExpiredDate";
            this.expr_dt.MinimumWidth = 6;
            this.expr_dt.Name = "expr_dt";
            this.expr_dt.Width = 125;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Product ID";
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // CorporationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 613);
            this.Controls.Add(this.dgvCorp);
            this.Controls.Add(this.btnDelete);
            this.Name = "CorporationListForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCorp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn corpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn corpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr_dt;
    }
}

