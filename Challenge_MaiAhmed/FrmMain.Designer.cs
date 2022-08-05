namespace Challenge_MaiAhmed
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnShowID = new System.Windows.Forms.Button();
            this.txtOldChar = new System.Windows.Forms.TextBox();
            this.txtNewChar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.cbxKeyValue = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCSVData = new System.Windows.Forms.DataGridView();
            this.bw_FrmMain = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cSVDatarowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSVDatarowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnShowID);
            this.splitContainer1.Panel1.Controls.Add(this.txtOldChar);
            this.splitContainer1.Panel1.Controls.Add(this.txtNewChar);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnReplace);
            this.splitContainer1.Panel1.Controls.Add(this.cbxKeyValue);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCSVData);
            this.splitContainer1.Size = new System.Drawing.Size(782, 553);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnShowID
            // 
            this.btnShowID.Location = new System.Drawing.Point(363, 55);
            this.btnShowID.Name = "btnShowID";
            this.btnShowID.Size = new System.Drawing.Size(198, 29);
            this.btnShowID.TabIndex = 12;
            this.btnShowID.Text = "Show Selected ID";
            this.btnShowID.UseVisualStyleBackColor = true;
            this.btnShowID.Click += new System.EventHandler(this.btnShowID_Click);
            // 
            // txtOldChar
            // 
            this.txtOldChar.Location = new System.Drawing.Point(110, 89);
            this.txtOldChar.MaxLength = 1;
            this.txtOldChar.Name = "txtOldChar";
            this.txtOldChar.Size = new System.Drawing.Size(108, 27);
            this.txtOldChar.TabIndex = 11;
            this.txtOldChar.Text = "a";
            // 
            // txtNewChar
            // 
            this.txtNewChar.Location = new System.Drawing.Point(225, 90);
            this.txtNewChar.MaxLength = 1;
            this.txtNewChar.Name = "txtNewChar";
            this.txtNewChar.Size = new System.Drawing.Size(108, 27);
            this.txtNewChar.TabIndex = 10;
            this.txtNewChar.Text = "@";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Replace Char:";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(363, 88);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(198, 29);
            this.btnReplace.TabIndex = 7;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // cbxKeyValue
            // 
            this.cbxKeyValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyValue.FormattingEnabled = true;
            this.cbxKeyValue.Location = new System.Drawing.Point(110, 54);
            this.cbxKeyValue.Name = "cbxKeyValue";
            this.cbxKeyValue.Size = new System.Drawing.Size(238, 28);
            this.cbxKeyValue.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(467, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load  Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(363, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(110, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 27);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path:";
            // 
            // dgvCSVData
            // 
            this.dgvCSVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSVData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCSVData.Location = new System.Drawing.Point(0, 0);
            this.dgvCSVData.Name = "dgvCSVData";
            this.dgvCSVData.RowHeadersWidth = 51;
            this.dgvCSVData.RowTemplate.Height = 29;
            this.dgvCSVData.Size = new System.Drawing.Size(782, 374);
            this.dgvCSVData.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "CSV";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Choose data file";
            // 
            // cSVDatarowBindingSource
            // 
            this.cSVDatarowBindingSource.DataSource = typeof(Challenge_MaiAhmed.CSVDatarow);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome - Challenge ( Mai Ahmed)";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSVDatarowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvCSVData;
        private TextBox txtOldChar;
        private TextBox txtNewChar;
        private Label label3;
        private Button btnReplace;
        private ComboBox cbxKeyValue;
        private Button btnLoad;
        private Button btnBrowse;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker bw_FrmMain;
        private OpenFileDialog openFileDialog1;
        private BindingSource cSVDatarowBindingSource;
        private Button btnShowID;
    }
}