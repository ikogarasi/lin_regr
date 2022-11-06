namespace Lin_Regr
{
    partial class Lin_Regr
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_TrSearh = new System.Windows.Forms.Button();
            this.label_Interv = new System.Windows.Forms.Label();
            this.button_AutoCorr = new System.Windows.Forms.Button();
            this.label_Var = new System.Windows.Forms.Label();
            this.label_ExVal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_LD = new System.Windows.Forms.Button();
            this.label_LD = new System.Windows.Forms.Label();
            this.label_lNum = new System.Windows.Forms.Label();
            this.label_startDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_YV = new System.Windows.Forms.Label();
            this.label_XV = new System.Windows.Forms.Label();
            this.trackBar_mD = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_EI = new System.Windows.Forms.Button();
            this.button_SI = new System.Windows.Forms.Button();
            this.label_Tr_Line = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ReDrw = new System.Windows.Forms.Button();
            this.button_EfD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mD)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 795);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(2, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(838, 791);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button_TrSearh, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.label_Interv, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.button_AutoCorr, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label_Var, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label_ExVal, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_LD, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_LD, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_lNum, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_startDate, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.trackBar_mD, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.label_Tr_Line, 0, 14);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 15);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(844, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 16;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 790);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button_TrSearh
            // 
            this.button_TrSearh.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_TrSearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_TrSearh.Location = new System.Drawing.Point(2, 639);
            this.button_TrSearh.Margin = new System.Windows.Forms.Padding(2);
            this.button_TrSearh.Name = "button_TrSearh";
            this.button_TrSearh.Size = new System.Drawing.Size(152, 45);
            this.button_TrSearh.TabIndex = 13;
            this.button_TrSearh.Text = "Trend Search";
            this.button_TrSearh.UseVisualStyleBackColor = true;
            this.button_TrSearh.Click += new System.EventHandler(this.button_TrSearh_Click);
            // 
            // label_Interv
            // 
            this.label_Interv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Interv.AutoSize = true;
            this.label_Interv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Interv.Location = new System.Drawing.Point(2, 600);
            this.label_Interv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Interv.Name = "label_Interv";
            this.label_Interv.Size = new System.Drawing.Size(130, 24);
            this.label_Interv.TabIndex = 12;
            this.label_Interv.Text = "Interval=[0 .. 0]";
            // 
            // button_AutoCorr
            // 
            this.button_AutoCorr.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_AutoCorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AutoCorr.Location = new System.Drawing.Point(2, 345);
            this.button_AutoCorr.Margin = new System.Windows.Forms.Padding(2);
            this.button_AutoCorr.Name = "button_AutoCorr";
            this.button_AutoCorr.Size = new System.Drawing.Size(152, 45);
            this.button_AutoCorr.TabIndex = 8;
            this.button_AutoCorr.Text = "Autocorrelation";
            this.button_AutoCorr.UseVisualStyleBackColor = true;
            this.button_AutoCorr.Click += new System.EventHandler(this.button_AutoCorr_Click);
            // 
            // label_Var
            // 
            this.label_Var.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Var.AutoSize = true;
            this.label_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Var.Location = new System.Drawing.Point(2, 306);
            this.label_Var.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Var.Name = "label_Var";
            this.label_Var.Size = new System.Drawing.Size(96, 24);
            this.label_Var.TabIndex = 7;
            this.label_Var.Text = "Variance=";
            // 
            // label_ExVal
            // 
            this.label_ExVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_ExVal.AutoSize = true;
            this.label_ExVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ExVal.Location = new System.Drawing.Point(2, 257);
            this.label_ExVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ExVal.Name = "label_ExVal";
            this.label_ExVal.Size = new System.Drawing.Size(129, 24);
            this.label_ExVal.TabIndex = 6;
            this.label_ExVal.Text = "ExpectedVal=";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(2, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Analysis";
            // 
            // button_LD
            // 
            this.button_LD.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_LD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LD.Location = new System.Drawing.Point(2, 2);
            this.button_LD.Margin = new System.Windows.Forms.Padding(2);
            this.button_LD.Name = "button_LD";
            this.button_LD.Size = new System.Drawing.Size(152, 45);
            this.button_LD.TabIndex = 0;
            this.button_LD.Text = "Load_Data";
            this.button_LD.UseVisualStyleBackColor = true;
            this.button_LD.Click += new System.EventHandler(this.button_LD_Click);
            // 
            // label_LD
            // 
            this.label_LD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_LD.AutoSize = true;
            this.label_LD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LD.ForeColor = System.Drawing.Color.Red;
            this.label_LD.Location = new System.Drawing.Point(2, 61);
            this.label_LD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LD.Name = "label_LD";
            this.label_LD.Size = new System.Drawing.Size(74, 24);
            this.label_LD.TabIndex = 1;
            this.label_LD.Text = "Loaded";
            this.label_LD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_lNum
            // 
            this.label_lNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_lNum.AutoSize = true;
            this.label_lNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_lNum.Location = new System.Drawing.Point(2, 159);
            this.label_lNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_lNum.Name = "label_lNum";
            this.label_lNum.Size = new System.Drawing.Size(114, 24);
            this.label_lNum.TabIndex = 2;
            this.label_lNum.Text = "NElements=";
            // 
            // label_startDate
            // 
            this.label_startDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_startDate.AutoSize = true;
            this.label_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_startDate.Location = new System.Drawing.Point(2, 110);
            this.label_startDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(115, 24);
            this.label_startDate.TabIndex = 3;
            this.label_startDate.Text = "Time start at ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(2, 404);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Explore";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label_YV, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_XV, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 443);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 45);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label_YV
            // 
            this.label_YV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_YV.AutoSize = true;
            this.label_YV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_YV.Location = new System.Drawing.Point(148, 10);
            this.label_YV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_YV.Name = "label_YV";
            this.label_YV.Size = new System.Drawing.Size(46, 24);
            this.label_YV.TabIndex = 9;
            this.label_YV.Text = "YV=";
            // 
            // label_XV
            // 
            this.label_XV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_XV.AutoSize = true;
            this.label_XV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_XV.Location = new System.Drawing.Point(2, 10);
            this.label_XV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_XV.Name = "label_XV";
            this.label_XV.Size = new System.Drawing.Size(48, 24);
            this.label_XV.TabIndex = 8;
            this.label_XV.Text = "XV=";
            // 
            // trackBar_mD
            // 
            this.trackBar_mD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_mD.Location = new System.Drawing.Point(2, 492);
            this.trackBar_mD.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar_mD.Name = "trackBar_mD";
            this.trackBar_mD.Size = new System.Drawing.Size(292, 45);
            this.trackBar_mD.TabIndex = 10;
            this.trackBar_mD.ValueChanged += new System.EventHandler(this.trackBar_mD_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button_EI, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_SI, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 541);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(292, 45);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // button_EI
            // 
            this.button_EI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_EI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EI.Location = new System.Drawing.Point(148, 2);
            this.button_EI.Margin = new System.Windows.Forms.Padding(2);
            this.button_EI.Name = "button_EI";
            this.button_EI.Size = new System.Drawing.Size(142, 41);
            this.button_EI.TabIndex = 10;
            this.button_EI.Text = "End";
            this.button_EI.UseVisualStyleBackColor = true;
            this.button_EI.Click += new System.EventHandler(this.button_EI_Click);
            // 
            // button_SI
            // 
            this.button_SI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SI.Location = new System.Drawing.Point(2, 2);
            this.button_SI.Margin = new System.Windows.Forms.Padding(2);
            this.button_SI.Name = "button_SI";
            this.button_SI.Size = new System.Drawing.Size(142, 41);
            this.button_SI.TabIndex = 9;
            this.button_SI.Text = "Start";
            this.button_SI.UseVisualStyleBackColor = true;
            this.button_SI.Click += new System.EventHandler(this.button_SI_Click);
            // 
            // label_Tr_Line
            // 
            this.label_Tr_Line.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Tr_Line.AutoSize = true;
            this.label_Tr_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Tr_Line.Location = new System.Drawing.Point(2, 698);
            this.label_Tr_Line.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Tr_Line.Name = "label_Tr_Line";
            this.label_Tr_Line.Size = new System.Drawing.Size(39, 24);
            this.label_Tr_Line.TabIndex = 15;
            this.label_Tr_Line.Text = "Tr=";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.button_ReDrw, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_EfD, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 737);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(292, 51);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // button_ReDrw
            // 
            this.button_ReDrw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ReDrw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ReDrw.Location = new System.Drawing.Point(191, 2);
            this.button_ReDrw.Margin = new System.Windows.Forms.Padding(2);
            this.button_ReDrw.Name = "button_ReDrw";
            this.button_ReDrw.Size = new System.Drawing.Size(99, 47);
            this.button_ReDrw.TabIndex = 15;
            this.button_ReDrw.Text = "ReDrw";
            this.button_ReDrw.UseVisualStyleBackColor = true;
            this.button_ReDrw.Click += new System.EventHandler(this.button_ReDrw_Click);
            // 
            // button_EfD
            // 
            this.button_EfD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_EfD.Enabled = false;
            this.button_EfD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EfD.Location = new System.Drawing.Point(2, 2);
            this.button_EfD.Margin = new System.Windows.Forms.Padding(2);
            this.button_EfD.Name = "button_EfD";
            this.button_EfD.Size = new System.Drawing.Size(185, 47);
            this.button_EfD.TabIndex = 14;
            this.button_EfD.Text = "Extract from Data";
            this.button_EfD.UseVisualStyleBackColor = true;
            this.button_EfD.Click += new System.EventHandler(this.button_EfD_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Lin_Regr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 795);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lin_Regr";
            this.Text = "Lin_Regr";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mD)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_LD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_LD;
        private System.Windows.Forms.Label label_lNum;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AutoCorr;
        private System.Windows.Forms.Label label_Var;
        private System.Windows.Forms.Label label_ExVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TrackBar trackBar_mD;
        private System.Windows.Forms.Label label_YV;
        private System.Windows.Forms.Label label_XV;
        private System.Windows.Forms.Label label_Interv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_EI;
        private System.Windows.Forms.Button button_SI;
        private System.Windows.Forms.Button button_TrSearh;
        private System.Windows.Forms.Button button_EfD;
        private System.Windows.Forms.Label label_Tr_Line;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button_ReDrw;
    }
}

