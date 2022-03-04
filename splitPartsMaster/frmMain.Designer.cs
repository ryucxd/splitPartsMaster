namespace splitPartsMaster
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSplitParts = new System.Windows.Forms.DataGridView();
            this.txtDoorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDoorAllocation = new System.Windows.Forms.DataGridView();
            this.btnDupe = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSplitParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoorAllocation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSplitParts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Split Parts Allocation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDoorAllocation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Door Allocation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(932, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSplitParts
            // 
            this.dgvSplitParts.AllowUserToAddRows = false;
            this.dgvSplitParts.AllowUserToDeleteRows = false;
            this.dgvSplitParts.AllowUserToResizeColumns = false;
            this.dgvSplitParts.AllowUserToResizeRows = false;
            this.dgvSplitParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSplitParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSplitParts.Location = new System.Drawing.Point(6, 6);
            this.dgvSplitParts.Name = "dgvSplitParts";
            this.dgvSplitParts.ReadOnly = true;
            this.dgvSplitParts.RowHeadersVisible = false;
            this.dgvSplitParts.Size = new System.Drawing.Size(1004, 334);
            this.dgvSplitParts.TabIndex = 0;
            this.dgvSplitParts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSplitParts_CellDoubleClick);
            // 
            // txtDoorID
            // 
            this.txtDoorID.Location = new System.Drawing.Point(65, 15);
            this.txtDoorID.Name = "txtDoorID";
            this.txtDoorID.Size = new System.Drawing.Size(100, 20);
            this.txtDoorID.TabIndex = 0;
            this.txtDoorID.TextChanged += new System.EventHandler(this.txtDoorID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Door ID";
            // 
            // dgvDoorAllocation
            // 
            this.dgvDoorAllocation.AllowUserToAddRows = false;
            this.dgvDoorAllocation.AllowUserToDeleteRows = false;
            this.dgvDoorAllocation.AllowUserToResizeColumns = false;
            this.dgvDoorAllocation.AllowUserToResizeRows = false;
            this.dgvDoorAllocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoorAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoorAllocation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoorAllocation.Location = new System.Drawing.Point(6, 6);
            this.dgvDoorAllocation.Name = "dgvDoorAllocation";
            this.dgvDoorAllocation.ReadOnly = true;
            this.dgvDoorAllocation.RowHeadersVisible = false;
            this.dgvDoorAllocation.Size = new System.Drawing.Size(1004, 334);
            this.dgvDoorAllocation.TabIndex = 1;
            this.dgvDoorAllocation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoorAllocation_CellDoubleClick);
            // 
            // btnDupe
            // 
            this.btnDupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDupe.Location = new System.Drawing.Point(171, 13);
            this.btnDupe.Name = "btnDupe";
            this.btnDupe.Size = new System.Drawing.Size(94, 23);
            this.btnDupe.TabIndex = 4;
            this.btnDupe.Text = "Find Duplication";
            this.btnDupe.UseVisualStyleBackColor = true;
            this.btnDupe.Click += new System.EventHandler(this.btnDupe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.btnDupe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoorID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fix Bending";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSplitParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoorAllocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSplitParts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDoorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoorAllocation;
        private System.Windows.Forms.Button btnDupe;
    }
}

