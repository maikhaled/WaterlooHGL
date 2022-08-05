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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowID = new System.Windows.Forms.Button();
            this.txtOldChar = new System.Windows.Forms.TextBox();
            this.txtNewChar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.cbxKeyValue = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.dgvCSVData = new System.Windows.Forms.DataGridView();
            this.bw_FrmMain = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cSVDatarowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bwLoadData = new System.ComponentModel.BackgroundWorker();
            this.bwSaveData = new System.ComponentModel.BackgroundWorker();
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
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnShowID);
            this.splitContainer1.Panel1.Controls.Add(this.txtOldChar);
            this.splitContainer1.Panel1.Controls.Add(this.txtNewChar);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnReplace);
            this.splitContainer1.Panel1.Controls.Add(this.cbxKeyValue);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.txtFilePath);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblFilePath);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.dgvCSVData);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowID
            // 
            resources.ApplyResources(this.btnShowID, "btnShowID");
            this.btnShowID.Name = "btnShowID";
            this.btnShowID.UseVisualStyleBackColor = true;
            this.btnShowID.Click += new System.EventHandler(this.btnShowID_Click);
            // 
            // txtOldChar
            // 
            resources.ApplyResources(this.txtOldChar, "txtOldChar");
            this.txtOldChar.Name = "txtOldChar";
            // 
            // txtNewChar
            // 
            resources.ApplyResources(this.txtNewChar, "txtNewChar");
            this.txtNewChar.Name = "txtNewChar";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnReplace
            // 
            resources.ApplyResources(this.btnReplace, "btnReplace");
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // cbxKeyValue
            // 
            resources.ApplyResources(this.cbxKeyValue, "cbxKeyValue");
            this.cbxKeyValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyValue.FormattingEnabled = true;
            this.cbxKeyValue.Name = "cbxKeyValue";
            // 
            // btnLoad
            // 
            resources.ApplyResources(this.btnLoad, "btnLoad");
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            resources.ApplyResources(this.txtFilePath, "txtFilePath");
            this.txtFilePath.Name = "txtFilePath";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblFilePath
            // 
            resources.ApplyResources(this.lblFilePath, "lblFilePath");
            this.lblFilePath.Name = "lblFilePath";
            // 
            // dgvCSVData
            // 
            resources.ApplyResources(this.dgvCSVData, "dgvCSVData");
            this.dgvCSVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSVData.Name = "dgvCSVData";
            this.dgvCSVData.RowTemplate.Height = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "CSV";
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // cSVDatarowBindingSource
            // 
            this.cSVDatarowBindingSource.DataSource = typeof(Challenge_MaiAhmed.CSVDatarow);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // bwLoadData
            // 
            this.bwLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // bwSaveData
            // 
            this.bwSaveData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSaveData_DoWork);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
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
        private TextBox txtFilePath;
        private Label label2;
        private Label lblFilePath;
        private System.ComponentModel.BackgroundWorker bw_FrmMain;
        private OpenFileDialog openFileDialog1;
        private BindingSource cSVDatarowBindingSource;
        private Button btnShowID;
        private Button btnSave;
        private SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker bwLoadData;
        private System.ComponentModel.BackgroundWorker bwSaveData;
    }
}