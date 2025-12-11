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

            // ========= TOP PANEL =========
            this.topPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Height = 80;
            this.topPanel.Padding = new System.Windows.Forms.Padding(20);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Label para tamaño
            this.lblSizeTitle = new System.Windows.Forms.Label();
            this.lblSizeTitle.Text = "Tamaño del arreglo";
            this.lblSizeTitle.Location = new System.Drawing.Point(20, 5);
            this.lblSizeTitle.AutoSize = true;
            this.lblSizeTitle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // NumericUpDown
            this.nudSize.Minimum = 2;
            this.nudSize.Maximum = 10000;
            this.nudSize.Value = 2; ////////////////
            this.nudSize.Location = new System.Drawing.Point(20, 25);
            this.nudSize.Width = 120;



////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Agregar al panel
            this.topPanel.Controls.Add(this.lblSizeTitle);          
            this.topPanel.Controls.Add(this.nudSize);      
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Botón Directa
            this.btnDirecta.Text = "Merge Sort Directo";
            this.btnDirecta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDirecta.ForeColor = System.Drawing.Color.White;
            this.btnDirecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirecta.Location = new System.Drawing.Point(160, 20);
            this.btnDirecta.Size = new System.Drawing.Size(180, 35);
            this.btnDirecta.Click += new System.EventHandler(this.BtnDirecta_Click);

            // Botón Natural
            this.btnNatural.Text = "Merge Sort Natural";
            this.btnNatural.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNatural.ForeColor = System.Drawing.Color.White;
            this.btnNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatural.Location = new System.Drawing.Point(350, 20);
            this.btnNatural.Size = new System.Drawing.Size(180, 35);
            this.btnNatural.Click += new System.EventHandler(this.BtnNatural_Click);

            this.topPanel.Controls.Add(this.nudSize);
            this.topPanel.Controls.Add(this.btnDirecta);
            this.topPanel.Controls.Add(this.btnNatural);

            // ========= BOTTOM PANEL =========
            this.bottomPanel.BackColor = System.Drawing.Color.LightYellow;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Height = 180;
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10);

            this.lblStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStats.Font = new System.Drawing.Font("Consolas", 10, System.Drawing.FontStyle.Bold);
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStats.Text = "Estadísticas aparecerán aquí...";

            this.bottomPanel.Controls.Add(this.lblStats);

            // ========= SPLIT CONTAINER =========
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;

            // Panel izquierdo
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.lblOriginalTitle.Text = "Arreglo Original";
            this.lblOriginalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOriginalTitle.Height = 30;
            this.lblOriginalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;

            this.splitContainer.Panel1.Controls.Add(this.lbOriginal);
            this.splitContainer.Panel1.Controls.Add(this.lblOriginalTitle);

            // Panel derecho
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.lblSortedTitle.Text = "Arreglo Ordenado";
            this.lblSortedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSortedTitle.Height = 30;
            this.lblSortedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lbSorted.Dock = System.Windows.Forms.DockStyle.Fill;

            this.splitContainer.Panel2.Controls.Add(this.lbSorted);
            this.splitContainer.Panel2.Controls.Add(this.lblSortedTitle);

            // ========= FORM =========
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Text = "Merge Sort Tester";
        }

        #endregion
    }
}
