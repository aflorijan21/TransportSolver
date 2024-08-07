namespace TransportSolver
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.lblMatrixSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestinationNeeds = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Location = new System.Drawing.Point(112, 12);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(198, 21);
            this.cmbMethod.TabIndex = 0;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite metodu:";
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.AllowUserToAddRows = false;
            this.dgvMatrix.AllowUserToDeleteRows = false;
            this.dgvMatrix.AllowUserToResizeColumns = false;
            this.dgvMatrix.AllowUserToResizeRows = false;
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatrix.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMatrix.Location = new System.Drawing.Point(263, 75);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersVisible = false;
            this.dgvMatrix.Size = new System.Drawing.Size(504, 463);
            this.dgvMatrix.TabIndex = 2;
            this.dgvMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrix_CellValueChanged);
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(331, 545);
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(47, 20);
            this.nudRows.TabIndex = 3;
            this.nudRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudRows.ValueChanged += new System.EventHandler(this.nudRows_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj stupaca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj redova:";
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(720, 48);
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(47, 20);
            this.nudColumns.TabIndex = 6;
            this.nudColumns.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.nudColumns_ValueChanged);
            // 
            // lblMatrixSize
            // 
            this.lblMatrixSize.AutoSize = true;
            this.lblMatrixSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrixSize.Location = new System.Drawing.Point(487, 32);
            this.lblMatrixSize.Name = "lblMatrixSize";
            this.lblMatrixSize.Size = new System.Drawing.Size(60, 31);
            this.lblMatrixSize.TabIndex = 7;
            this.lblMatrixSize.Text = "3x3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kapaciteti ishodišta:";
            // 
            // txtOutputCapacity
            // 
            this.txtOutputCapacity.Location = new System.Drawing.Point(15, 91);
            this.txtOutputCapacity.Name = "txtOutputCapacity";
            this.txtOutputCapacity.Size = new System.Drawing.Size(224, 20);
            this.txtOutputCapacity.TabIndex = 9;
            this.txtOutputCapacity.TextChanged += new System.EventHandler(this.txtOutputCapacity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Potrebe odredišta:";
            // 
            // txtDestinationNeeds
            // 
            this.txtDestinationNeeds.Location = new System.Drawing.Point(15, 160);
            this.txtDestinationNeeds.Name = "txtDestinationNeeds";
            this.txtDestinationNeeds.Size = new System.Drawing.Size(224, 20);
            this.txtDestinationNeeds.TabIndex = 11;
            this.txtDestinationNeeds.TextChanged += new System.EventHandler(this.txtDestinationNeeds_TextChanged);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(605, 544);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(162, 32);
            this.btnSolve.TabIndex = 12;
            this.btnSolve.Text = "Riješi";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(262, 585);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 24);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "Z = ?";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 637);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtDestinationNeeds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOutputCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMatrixSize);
            this.Controls.Add(this.nudColumns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudRows);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMethod);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transport Solver";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Label lblMatrixSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDestinationNeeds;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblResult;
    }
}

