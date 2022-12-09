namespace StandartSapmaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.view_degerler = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degerler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSonucIteratif = new System.Windows.Forms.TextBox();
            this.txtSonucRecursive = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label_iteratif = new System.Windows.Forms.Label();
            this.label_recursive = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_degerler)).BeginInit();
            this.SuspendLayout();
            // 
            // view_degerler
            // 
            resources.ApplyResources(this.view_degerler, "view_degerler");
            this.view_degerler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_degerler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.degerler});
            this.view_degerler.Name = "view_degerler";
            // 
            // index
            // 
            this.index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.index, "index");
            this.index.Name = "index";
            // 
            // degerler
            // 
            this.degerler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.degerler, "degerler");
            this.degerler.Name = "degerler";
            this.degerler.ReadOnly = true;
            this.degerler.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtSonucIteratif
            // 
            resources.ApplyResources(this.txtSonucIteratif, "txtSonucIteratif");
            this.txtSonucIteratif.Name = "txtSonucIteratif";
            this.txtSonucIteratif.ReadOnly = true;
            // 
            // txtSonucRecursive
            // 
            resources.ApplyResources(this.txtSonucRecursive, "txtSonucRecursive");
            this.txtSonucRecursive.Name = "txtSonucRecursive";
            this.txtSonucRecursive.ReadOnly = true;
            // 
            // btnRestart
            // 
            resources.ApplyResources(this.btnRestart, "btnRestart");
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label_iteratif
            // 
            resources.ApplyResources(this.label_iteratif, "label_iteratif");
            this.label_iteratif.Name = "label_iteratif";
            // 
            // label_recursive
            // 
            resources.ApplyResources(this.label_recursive, "label_recursive");
            this.label_recursive.Name = "label_recursive";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_recursive);
            this.Controls.Add(this.label_iteratif);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtSonucRecursive);
            this.Controls.Add(this.txtSonucIteratif);
            this.Controls.Add(this.view_degerler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.view_degerler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view_degerler;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn degerler;
        private System.Windows.Forms.TextBox txtSonucIteratif;
        private System.Windows.Forms.TextBox txtSonucRecursive;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label_iteratif;
        private System.Windows.Forms.Label label_recursive;
    }
}

