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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
            this.txtSolutionSteps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnExample = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Location = new System.Drawing.Point(110, 12);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(235, 21);
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
            this.dgvMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatrix.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatrix.Location = new System.Drawing.Point(451, 75);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersVisible = false;
            this.dgvMatrix.Size = new System.Drawing.Size(504, 463);
            this.dgvMatrix.TabIndex = 2;
            this.dgvMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrix_CellValueChanged);
            // 
            // nudRows
            // 
            this.nudRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudRows.Location = new System.Drawing.Point(519, 545);
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(838, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj stupaca:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj redova:";
            // 
            // nudColumns
            // 
            this.nudColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudColumns.Location = new System.Drawing.Point(908, 48);
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
            this.lblMatrixSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatrixSize.AutoSize = true;
            this.lblMatrixSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrixSize.Location = new System.Drawing.Point(675, 32);
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
            this.txtOutputCapacity.Size = new System.Drawing.Size(254, 20);
            this.txtOutputCapacity.TabIndex = 9;
            this.txtOutputCapacity.TextChanged += new System.EventHandler(this.txtOutputCapacity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Potrebe odredišta:";
            // 
            // txtDestinationNeeds
            // 
            this.txtDestinationNeeds.Location = new System.Drawing.Point(15, 144);
            this.txtDestinationNeeds.Name = "txtDestinationNeeds";
            this.txtDestinationNeeds.Size = new System.Drawing.Size(254, 20);
            this.txtDestinationNeeds.TabIndex = 11;
            this.txtDestinationNeeds.TextChanged += new System.EventHandler(this.txtDestinationNeeds_TextChanged);
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolve.Location = new System.Drawing.Point(793, 544);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(162, 32);
            this.btnSolve.TabIndex = 12;
            this.btnSolve.Text = "Riješi";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(450, 585);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 24);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "Z = ?";
            // 
            // txtSolutionSteps
            // 
            this.txtSolutionSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSolutionSteps.Location = new System.Drawing.Point(15, 196);
            this.txtSolutionSteps.Multiline = true;
            this.txtSolutionSteps.Name = "txtSolutionSteps";
            this.txtSolutionSteps.ReadOnly = true;
            this.txtSolutionSteps.Size = new System.Drawing.Size(409, 413);
            this.txtSolutionSteps.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Koraci rješenja:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Odredište";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "D";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "o";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "b";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "a";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "v";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "lj";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(436, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "a";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(436, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "č";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(867, 613);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Aleks Florijan, 2024.";
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(351, 12);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(75, 23);
            this.btnExample.TabIndex = 26;
            this.btnExample.Text = "Učitaj primjer";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(714, 544);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 628);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSolutionSteps);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(983, 667);
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
        private System.Windows.Forms.TextBox txtSolutionSteps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Button btnReset;
    }
}

