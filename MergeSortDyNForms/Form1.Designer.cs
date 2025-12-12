namespace MergeSortDyNForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Button btnDirecta;
        private System.Windows.Forms.Button btnNatural;
        private System.Windows.Forms.ListBox lbOriginal;
        private System.Windows.Forms.ListBox lbSorted;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblOriginalTitle;
        private System.Windows.Forms.Label lblSortedTitle;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblSizeTitle;  ////////


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblSizeTitle = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.btnDirecta = new System.Windows.Forms.Button();
            this.btnNatural = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lblStats = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lbOriginal = new System.Windows.Forms.ListBox();
            this.lblOriginalTitle = new System.Windows.Forms.Label();
            this.lbSorted = new System.Windows.Forms.ListBox();
            this.lblSortedTitle = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Controls.Add(this.lblSizeTitle);
            this.topPanel.Controls.Add(this.nudSize);
            this.topPanel.Controls.Add(this.btnDirecta);
            this.topPanel.Controls.Add(this.btnNatural);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(20);
            this.topPanel.Size = new System.Drawing.Size(900, 80);
            this.topPanel.TabIndex = 2;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // lblSizeTitle
            // 
            this.lblSizeTitle.AutoSize = true;
            this.lblSizeTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeTitle.Location = new System.Drawing.Point(20, 5);
            this.lblSizeTitle.Name = "lblSizeTitle";
            this.lblSizeTitle.Size = new System.Drawing.Size(166, 23);
            this.lblSizeTitle.TabIndex = 0;
            this.lblSizeTitle.Text = "Tamaño del arreglo";
            // 
            // nudSize
            // 
            this.nudSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSize.Location = new System.Drawing.Point(23, 33);
            this.nudSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 27);
            this.nudSize.TabIndex = 1;
            this.nudSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnDirecta
            // 
            this.btnDirecta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDirecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirecta.ForeColor = System.Drawing.Color.White;
            this.btnDirecta.Location = new System.Drawing.Point(191, 12);
            this.btnDirecta.Name = "btnDirecta";
            this.btnDirecta.Size = new System.Drawing.Size(196, 54);
            this.btnDirecta.TabIndex = 2;
            this.btnDirecta.Text = "Merge Sort Directo";
            this.btnDirecta.UseVisualStyleBackColor = false;
            this.btnDirecta.Click += new System.EventHandler(this.BtnDirecta_Click);
            // 
            // btnNatural
            // 
            this.btnNatural.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatural.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatural.ForeColor = System.Drawing.Color.White;
            this.btnNatural.Location = new System.Drawing.Point(440, 12);
            this.btnNatural.Name = "btnNatural";
            this.btnNatural.Size = new System.Drawing.Size(210, 54);
            this.btnNatural.TabIndex = 3;
            this.btnNatural.Text = "Merge Sort Natural";
            this.btnNatural.UseVisualStyleBackColor = false;
            this.btnNatural.Click += new System.EventHandler(this.BtnNatural_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.LightYellow;
            this.bottomPanel.Controls.Add(this.lblStats);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 470);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10);
            this.bottomPanel.Size = new System.Drawing.Size(900, 180);
            this.bottomPanel.TabIndex = 1;
            // 
            // lblStats
            // 
            this.lblStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStats.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblStats.Location = new System.Drawing.Point(10, 10);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(880, 160);
            this.lblStats.TabIndex = 0;
            this.lblStats.Text = "Estadísticas aparecerán aquí...";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 80);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lbOriginal);
            this.splitContainer.Panel1.Controls.Add(this.lblOriginalTitle);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lbSorted);
            this.splitContainer.Panel2.Controls.Add(this.lblSortedTitle);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer.Size = new System.Drawing.Size(900, 390);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.TabIndex = 0;
            // 
            // lbOriginal
            // 
            this.lbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginal.ItemHeight = 29;
            this.lbOriginal.Location = new System.Drawing.Point(10, 40);
            this.lbOriginal.Name = "lbOriginal";
            this.lbOriginal.Size = new System.Drawing.Size(280, 340);
            this.lbOriginal.TabIndex = 0;
            // 
            // lblOriginalTitle
            // 
            this.lblOriginalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOriginalTitle.Location = new System.Drawing.Point(10, 10);
            this.lblOriginalTitle.Name = "lblOriginalTitle";
            this.lblOriginalTitle.Size = new System.Drawing.Size(280, 30);
            this.lblOriginalTitle.TabIndex = 1;
            this.lblOriginalTitle.Text = "Arreglo Original";
            this.lblOriginalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSorted
            // 
            this.lbSorted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSorted.ItemHeight = 29;
            this.lbSorted.Location = new System.Drawing.Point(10, 40);
            this.lbSorted.Name = "lbSorted";
            this.lbSorted.Size = new System.Drawing.Size(576, 340);
            this.lbSorted.TabIndex = 0;
            // 
            // lblSortedTitle
            // 
            this.lblSortedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSortedTitle.Location = new System.Drawing.Point(10, 10);
            this.lblSortedTitle.Name = "lblSortedTitle";
            this.lblSortedTitle.Size = new System.Drawing.Size(576, 30);
            this.lblSortedTitle.TabIndex = 1;
            this.lblSortedTitle.Text = "Arreglo Ordenado";
            this.lblSortedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.Text = "Merge Sort Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
