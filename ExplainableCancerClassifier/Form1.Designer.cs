namespace ExplainableCancerClassifier
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel_label = new System.Windows.Forms.Panel();
            this.pcBx_label = new System.Windows.Forms.PictureBox();
            this.panel_cancer = new System.Windows.Forms.Panel();
            this.pcBx_cancer = new System.Windows.Forms.PictureBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.backWorkLoadData = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pcBx_decisionImg = new System.Windows.Forms.PictureBox();
            this.pxBx_sim1 = new System.Windows.Forms.PictureBox();
            this.pxBx_sim2 = new System.Windows.Forms.PictureBox();
            this.pxBx_sim3 = new System.Windows.Forms.PictureBox();
            this.label_pxBx_sim1 = new System.Windows.Forms.Label();
            this.label_pxBx_sim2 = new System.Windows.Forms.Label();
            this.label_pxBx_sim3 = new System.Windows.Forms.Label();
            this.label_pcBx_decisionImg = new System.Windows.Forms.Label();
            this.cmbBox_experiments = new System.Windows.Forms.ComboBox();
            this.groupBox_zoom = new System.Windows.Forms.GroupBox();
            this.groupBox_wsi = new System.Windows.Forms.GroupBox();
            this.groupBox_visualisation = new System.Windows.Forms.GroupBox();
            this.pxBx_sim4 = new System.Windows.Forms.PictureBox();
            this.pxBx_sim5 = new System.Windows.Forms.PictureBox();
            this.pxBx_sim6 = new System.Windows.Forms.PictureBox();
            this.label_pxBx_sim4 = new System.Windows.Forms.Label();
            this.label_pxBx_sim6 = new System.Windows.Forms.Label();
            this.label_pxBx_sim5 = new System.Windows.Forms.Label();
            this.groupBox_accuracy = new System.Windows.Forms.GroupBox();
            this.button_class8 = new System.Windows.Forms.Button();
            this.button_class7 = new System.Windows.Forms.Button();
            this.button_class6 = new System.Windows.Forms.Button();
            this.button_class5 = new System.Windows.Forms.Button();
            this.button_class4 = new System.Windows.Forms.Button();
            this.button_class3 = new System.Windows.Forms.Button();
            this.button_class2 = new System.Windows.Forms.Button();
            this.button_class1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_Backward = new System.Windows.Forms.Button();
            this.btn_Statistic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_TODO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel_label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBx_label)).BeginInit();
            this.panel_cancer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBx_cancer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBx_decisionImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim3)).BeginInit();
            this.groupBox_zoom.SuspendLayout();
            this.groupBox_visualisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim6)).BeginInit();
            this.groupBox_accuracy.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(10, 46);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(2030, 90);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 100;
            // 
            // panel_label
            // 
            this.panel_label.AutoScroll = true;
            this.panel_label.Controls.Add(this.pcBx_label);
            this.panel_label.Location = new System.Drawing.Point(2176, 238);
            this.panel_label.Margin = new System.Windows.Forms.Padding(6);
            this.panel_label.Name = "panel_label";
            this.panel_label.Size = new System.Drawing.Size(1000, 962);
            this.panel_label.TabIndex = 8;
            // 
            // pcBx_label
            // 
            this.pcBx_label.Location = new System.Drawing.Point(6, 6);
            this.pcBx_label.Margin = new System.Windows.Forms.Padding(6);
            this.pcBx_label.Name = "pcBx_label";
            this.pcBx_label.Size = new System.Drawing.Size(1000, 962);
            this.pcBx_label.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBx_label.TabIndex = 0;
            this.pcBx_label.TabStop = false;
            this.pcBx_label.Paint += new System.Windows.Forms.PaintEventHandler(this.pcBx_label_Paint);
            // 
            // panel_cancer
            // 
            this.panel_cancer.AutoScroll = true;
            this.panel_cancer.Controls.Add(this.pcBx_cancer);
            this.panel_cancer.Location = new System.Drawing.Point(1152, 238);
            this.panel_cancer.Margin = new System.Windows.Forms.Padding(6);
            this.panel_cancer.Name = "panel_cancer";
            this.panel_cancer.Size = new System.Drawing.Size(1000, 962);
            this.panel_cancer.TabIndex = 7;
            // 
            // pcBx_cancer
            // 
            this.pcBx_cancer.Location = new System.Drawing.Point(6, 6);
            this.pcBx_cancer.Margin = new System.Windows.Forms.Padding(6);
            this.pcBx_cancer.Name = "pcBx_cancer";
            this.pcBx_cancer.Size = new System.Drawing.Size(1000, 962);
            this.pcBx_cancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBx_cancer.TabIndex = 0;
            this.pcBx_cancer.TabStop = false;
            this.pcBx_cancer.Paint += new System.Windows.Forms.PaintEventHandler(this.pcBx_cancer_Paint);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(24, 23);
            this.btn_load.Margin = new System.Windows.Forms.Padding(6);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(216, 58);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Load tissue sample";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // backWorkLoadData
            // 
            this.backWorkLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWorkLoadData_DoWork);
            this.backWorkLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backWorkLoadData_ProgressChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 181);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(598, 302);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // pcBx_decisionImg
            // 
            this.pcBx_decisionImg.Location = new System.Drawing.Point(722, 198);
            this.pcBx_decisionImg.Margin = new System.Windows.Forms.Padding(6);
            this.pcBx_decisionImg.Name = "pcBx_decisionImg";
            this.pcBx_decisionImg.Size = new System.Drawing.Size(300, 288);
            this.pcBx_decisionImg.TabIndex = 11;
            this.pcBx_decisionImg.TabStop = false;
            // 
            // pxBx_sim1
            // 
            this.pxBx_sim1.Location = new System.Drawing.Point(30, 110);
            this.pxBx_sim1.Margin = new System.Windows.Forms.Padding(6);
            this.pxBx_sim1.Name = "pxBx_sim1";
            this.pxBx_sim1.Size = new System.Drawing.Size(300, 288);
            this.pxBx_sim1.TabIndex = 12;
            this.pxBx_sim1.TabStop = false;
            // 
            // pxBx_sim2
            // 
            this.pxBx_sim2.Location = new System.Drawing.Point(396, 110);
            this.pxBx_sim2.Margin = new System.Windows.Forms.Padding(6);
            this.pxBx_sim2.Name = "pxBx_sim2";
            this.pxBx_sim2.Size = new System.Drawing.Size(300, 288);
            this.pxBx_sim2.TabIndex = 13;
            this.pxBx_sim2.TabStop = false;
            // 
            // pxBx_sim3
            // 
            this.pxBx_sim3.Location = new System.Drawing.Point(756, 110);
            this.pxBx_sim3.Margin = new System.Windows.Forms.Padding(6);
            this.pxBx_sim3.Name = "pxBx_sim3";
            this.pxBx_sim3.Size = new System.Drawing.Size(300, 288);
            this.pxBx_sim3.TabIndex = 14;
            this.pxBx_sim3.TabStop = false;
            // 
            // label_pxBx_sim1
            // 
            this.label_pxBx_sim1.AutoSize = true;
            this.label_pxBx_sim1.Location = new System.Drawing.Point(24, 58);
            this.label_pxBx_sim1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_pxBx_sim1.Name = "label_pxBx_sim1";
            this.label_pxBx_sim1.Size = new System.Drawing.Size(0, 37);
            this.label_pxBx_sim1.TabIndex = 15;
            // 
            // label_pxBx_sim2
            // 
            this.label_pxBx_sim2.AutoSize = true;
            this.label_pxBx_sim2.Location = new System.Drawing.Point(390, 58);
            this.label_pxBx_sim2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_pxBx_sim2.Name = "label_pxBx_sim2";
            this.label_pxBx_sim2.Size = new System.Drawing.Size(0, 37);
            this.label_pxBx_sim2.TabIndex = 16;
            // 
            // label_pxBx_sim3
            // 
            this.label_pxBx_sim3.AutoSize = true;
            this.label_pxBx_sim3.Location = new System.Drawing.Point(758, 58);
            this.label_pxBx_sim3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_pxBx_sim3.Name = "label_pxBx_sim3";
            this.label_pxBx_sim3.Size = new System.Drawing.Size(0, 37);
            this.label_pxBx_sim3.TabIndex = 17;
            // 
            // label_pcBx_decisionImg
            // 
            this.label_pcBx_decisionImg.AutoSize = true;
            this.label_pcBx_decisionImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pcBx_decisionImg.Location = new System.Drawing.Point(690, 152);
            this.label_pcBx_decisionImg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_pcBx_decisionImg.Name = "label_pcBx_decisionImg";
            this.label_pcBx_decisionImg.Size = new System.Drawing.Size(0, 37);
            this.label_pcBx_decisionImg.TabIndex = 18;
            // 
            // cmbBox_experiments
            // 
            this.cmbBox_experiments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_experiments.FormattingEnabled = true;
            this.cmbBox_experiments.Location = new System.Drawing.Point(252, 27);
            this.cmbBox_experiments.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBox_experiments.Name = "cmbBox_experiments";
            this.cmbBox_experiments.Size = new System.Drawing.Size(238, 45);
            this.cmbBox_experiments.TabIndex = 19;
            // 
            // groupBox_zoom
            // 
            this.groupBox_zoom.Controls.Add(this.trackBar1);
            this.groupBox_zoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_zoom.Location = new System.Drawing.Point(1142, 23);
            this.groupBox_zoom.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_zoom.Name = "groupBox_zoom";
            this.groupBox_zoom.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_zoom.Size = new System.Drawing.Size(2052, 154);
            this.groupBox_zoom.TabIndex = 20;
            this.groupBox_zoom.TabStop = false;
            this.groupBox_zoom.Text = "Zoom";
            // 
            // groupBox_wsi
            // 
            this.groupBox_wsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_wsi.Location = new System.Drawing.Point(1142, 188);
            this.groupBox_wsi.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_wsi.Name = "groupBox_wsi";
            this.groupBox_wsi.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_wsi.Size = new System.Drawing.Size(2068, 1056);
            this.groupBox_wsi.TabIndex = 21;
            this.groupBox_wsi.TabStop = false;
            this.groupBox_wsi.Text = "Tissue and corresponding labelmap";
            // 
            // groupBox_visualisation
            // 
            this.groupBox_visualisation.Controls.Add(this.pxBx_sim4);
            this.groupBox_visualisation.Controls.Add(this.pxBx_sim5);
            this.groupBox_visualisation.Controls.Add(this.pxBx_sim6);
            this.groupBox_visualisation.Controls.Add(this.label_pxBx_sim4);
            this.groupBox_visualisation.Controls.Add(this.label_pxBx_sim6);
            this.groupBox_visualisation.Controls.Add(this.label_pxBx_sim5);
            this.groupBox_visualisation.Controls.Add(this.pxBx_sim1);
            this.groupBox_visualisation.Controls.Add(this.pxBx_sim2);
            this.groupBox_visualisation.Controls.Add(this.pxBx_sim3);
            this.groupBox_visualisation.Controls.Add(this.label_pxBx_sim1);
            this.groupBox_visualisation.Controls.Add(this.label_pxBx_sim3);
            this.groupBox_visualisation.Controls.Add(this.label_pxBx_sim2);
            this.groupBox_visualisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_visualisation.Location = new System.Drawing.Point(24, 521);
            this.groupBox_visualisation.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_visualisation.Name = "groupBox_visualisation";
            this.groupBox_visualisation.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_visualisation.Size = new System.Drawing.Size(1094, 972);
            this.groupBox_visualisation.TabIndex = 22;
            this.groupBox_visualisation.TabStop = false;
            this.groupBox_visualisation.Text = "Visualization of other type of tissue";
            // 
            // pxBx_sim4
            // 
            this.pxBx_sim4.Location = new System.Drawing.Point(30, 500);
            this.pxBx_sim4.Margin = new System.Windows.Forms.Padding(6);
            this.pxBx_sim4.Name = "pxBx_sim4";
            this.pxBx_sim4.Size = new System.Drawing.Size(300, 288);
            this.pxBx_sim4.TabIndex = 18;
            this.pxBx_sim4.TabStop = false;
            // 
            // pxBx_sim5
            // 
            this.pxBx_sim5.Location = new System.Drawing.Point(396, 500);
            this.pxBx_sim5.Margin = new System.Windows.Forms.Padding(6);
            this.pxBx_sim5.Name = "pxBx_sim5";
            this.pxBx_sim5.Size = new System.Drawing.Size(300, 288);
            this.pxBx_sim5.TabIndex = 19;
            this.pxBx_sim5.TabStop = false;
            // 
            // pxBx_sim6
            // 
            this.pxBx_sim6.Location = new System.Drawing.Point(756, 500);
            this.pxBx_sim6.Margin = new System.Windows.Forms.Padding(6);
            this.pxBx_sim6.Name = "pxBx_sim6";
            this.pxBx_sim6.Size = new System.Drawing.Size(300, 288);
            this.pxBx_sim6.TabIndex = 20;
            this.pxBx_sim6.TabStop = false;
            // 
            // label_pxBx_sim4
            // 
            this.label_pxBx_sim4.AutoSize = true;
            this.label_pxBx_sim4.Location = new System.Drawing.Point(24, 448);
            this.label_pxBx_sim4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_pxBx_sim4.Name = "label_pxBx_sim4";
            this.label_pxBx_sim4.Size = new System.Drawing.Size(0, 37);
            this.label_pxBx_sim4.TabIndex = 21;
            // 
            // label_pxBx_sim6
            // 
            this.label_pxBx_sim6.AutoSize = true;
            this.label_pxBx_sim6.Location = new System.Drawing.Point(758, 448);
            this.label_pxBx_sim6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_pxBx_sim6.Name = "label_pxBx_sim6";
            this.label_pxBx_sim6.Size = new System.Drawing.Size(0, 37);
            this.label_pxBx_sim6.TabIndex = 23;
            // 
            // label_pxBx_sim5
            // 
            this.label_pxBx_sim5.AutoSize = true;
            this.label_pxBx_sim5.Location = new System.Drawing.Point(390, 448);
            this.label_pxBx_sim5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_pxBx_sim5.Name = "label_pxBx_sim5";
            this.label_pxBx_sim5.Size = new System.Drawing.Size(0, 37);
            this.label_pxBx_sim5.TabIndex = 22;
            // 
            // groupBox_accuracy
            // 
            this.groupBox_accuracy.Controls.Add(this.button_class8);
            this.groupBox_accuracy.Controls.Add(this.button_class7);
            this.groupBox_accuracy.Controls.Add(this.button_class6);
            this.groupBox_accuracy.Controls.Add(this.button_class5);
            this.groupBox_accuracy.Controls.Add(this.button_class4);
            this.groupBox_accuracy.Controls.Add(this.button_class3);
            this.groupBox_accuracy.Controls.Add(this.button_class2);
            this.groupBox_accuracy.Controls.Add(this.button_class1);
            this.groupBox_accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_accuracy.Location = new System.Drawing.Point(1130, 1256);
            this.groupBox_accuracy.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_accuracy.Name = "groupBox_accuracy";
            this.groupBox_accuracy.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_accuracy.Size = new System.Drawing.Size(2092, 237);
            this.groupBox_accuracy.TabIndex = 27;
            this.groupBox_accuracy.TabStop = false;
            this.groupBox_accuracy.Text = "Decision of a pathologist";
            // 
            // button_class8
            // 
            this.button_class8.BackColor = System.Drawing.Color.Black;
            this.button_class8.ForeColor = System.Drawing.Color.White;
            this.button_class8.Location = new System.Drawing.Point(1838, 83);
            this.button_class8.Margin = new System.Windows.Forms.Padding(6);
            this.button_class8.Name = "button_class8";
            this.button_class8.Size = new System.Drawing.Size(242, 100);
            this.button_class8.TabIndex = 7;
            this.button_class8.Text = "Background";
            this.button_class8.UseVisualStyleBackColor = false;
            this.button_class8.Click += new System.EventHandler(this.button_class8_Click);
            // 
            // button_class7
            // 
            this.button_class7.BackColor = System.Drawing.Color.Silver;
            this.button_class7.Location = new System.Drawing.Point(1584, 85);
            this.button_class7.Margin = new System.Windows.Forms.Padding(6);
            this.button_class7.Name = "button_class7";
            this.button_class7.Size = new System.Drawing.Size(242, 100);
            this.button_class7.TabIndex = 6;
            this.button_class7.Text = "Adipose tissue";
            this.button_class7.UseVisualStyleBackColor = false;
            this.button_class7.Click += new System.EventHandler(this.button_class7_Click);
            // 
            // button_class6
            // 
            this.button_class6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_class6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_class6.Location = new System.Drawing.Point(1330, 85);
            this.button_class6.Margin = new System.Windows.Forms.Padding(6);
            this.button_class6.Name = "button_class6";
            this.button_class6.Size = new System.Drawing.Size(242, 100);
            this.button_class6.TabIndex = 5;
            this.button_class6.Text = "Normal mucosal glands";
            this.button_class6.UseVisualStyleBackColor = false;
            this.button_class6.Click += new System.EventHandler(this.button_class6_Click);
            // 
            // button_class5
            // 
            this.button_class5.BackColor = System.Drawing.Color.Fuchsia;
            this.button_class5.Location = new System.Drawing.Point(1076, 83);
            this.button_class5.Margin = new System.Windows.Forms.Padding(6);
            this.button_class5.Name = "button_class5";
            this.button_class5.Size = new System.Drawing.Size(242, 100);
            this.button_class5.TabIndex = 4;
            this.button_class5.Text = "Debris";
            this.button_class5.UseVisualStyleBackColor = false;
            this.button_class5.Click += new System.EventHandler(this.button_class5_Click);
            // 
            // button_class4
            // 
            this.button_class4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_class4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_class4.Location = new System.Drawing.Point(822, 85);
            this.button_class4.Margin = new System.Windows.Forms.Padding(6);
            this.button_class4.Name = "button_class4";
            this.button_class4.Size = new System.Drawing.Size(242, 100);
            this.button_class4.TabIndex = 3;
            this.button_class4.Text = "Immune cells";
            this.button_class4.UseVisualStyleBackColor = false;
            this.button_class4.Click += new System.EventHandler(this.button_class4_Click);
            // 
            // button_class3
            // 
            this.button_class3.BackColor = System.Drawing.Color.Yellow;
            this.button_class3.Location = new System.Drawing.Point(568, 83);
            this.button_class3.Margin = new System.Windows.Forms.Padding(6);
            this.button_class3.Name = "button_class3";
            this.button_class3.Size = new System.Drawing.Size(242, 100);
            this.button_class3.TabIndex = 2;
            this.button_class3.Text = "Complex Stroma";
            this.button_class3.UseVisualStyleBackColor = false;
            this.button_class3.Click += new System.EventHandler(this.button_class3_Click);
            // 
            // button_class2
            // 
            this.button_class2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_class2.Location = new System.Drawing.Point(314, 85);
            this.button_class2.Margin = new System.Windows.Forms.Padding(6);
            this.button_class2.Name = "button_class2";
            this.button_class2.Size = new System.Drawing.Size(242, 100);
            this.button_class2.TabIndex = 1;
            this.button_class2.Text = "Simple Stroma";
            this.button_class2.UseVisualStyleBackColor = false;
            this.button_class2.Click += new System.EventHandler(this.button_class2_Click);
            // 
            // button_class1
            // 
            this.button_class1.BackColor = System.Drawing.Color.Red;
            this.button_class1.Location = new System.Drawing.Point(60, 85);
            this.button_class1.Margin = new System.Windows.Forms.Padding(6);
            this.button_class1.Name = "button_class1";
            this.button_class1.Size = new System.Drawing.Size(242, 100);
            this.button_class1.TabIndex = 0;
            this.button_class1.Text = "Tumour";
            this.button_class1.UseVisualStyleBackColor = false;
            this.button_class1.Click += new System.EventHandler(this.button_class1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Semantical explanation of the result";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(512, 114);
            this.label2.TabIndex = 29;
            this.label2.Text = "Visualization of the training sample responsible for the prediction";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_Forward
            // 
            this.btn_Forward.Location = new System.Drawing.Point(240, 37);
            this.btn_Forward.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(84, 75);
            this.btn_Forward.TabIndex = 32;
            this.btn_Forward.Text = ">";
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_Backward
            // 
            this.btn_Backward.Location = new System.Drawing.Point(106, 37);
            this.btn_Backward.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Backward.Name = "btn_Backward";
            this.btn_Backward.Size = new System.Drawing.Size(84, 75);
            this.btn_Backward.TabIndex = 31;
            this.btn_Backward.Text = "<";
            this.btn_Backward.UseVisualStyleBackColor = true;
            this.btn_Backward.Click += new System.EventHandler(this.btn_Backward_Click);
            // 
            // btn_Statistic
            // 
            this.btn_Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Statistic.Location = new System.Drawing.Point(54, 1354);
            this.btn_Statistic.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Statistic.Name = "btn_Statistic";
            this.btn_Statistic.Size = new System.Drawing.Size(266, 88);
            this.btn_Statistic.TabIndex = 33;
            this.btn_Statistic.Text = "Štatistika";
            this.btn_Statistic.UseVisualStyleBackColor = true;
            this.btn_Statistic.Click += new System.EventHandler(this.btn_Statistic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Backward);
            this.groupBox1.Controls.Add(this.btn_Forward);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(366, 1346);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(442, 123);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navrhované oblasti";
            // 
            // label_TODO
            // 
            this.label_TODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_TODO.Location = new System.Drawing.Point(47, 1497);
            this.label_TODO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_TODO.Name = "label_TODO";
            this.label_TODO.Size = new System.Drawing.Size(1169, 51);
            this.label_TODO.TabIndex = 35;
            this.label_TODO.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3204, 1585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox_accuracy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_visualisation);
            this.Controls.Add(this.groupBox_zoom);
            this.Controls.Add(this.cmbBox_experiments);
            this.Controls.Add(this.label_pcBx_decisionImg);
            this.Controls.Add(this.pcBx_decisionImg);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel_label);
            this.Controls.Add(this.panel_cancer);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.groupBox_wsi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Statistic);
            this.Controls.Add(this.label_TODO);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Druhý prístup";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel_label.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBx_label)).EndInit();
            this.panel_cancer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBx_cancer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBx_decisionImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim3)).EndInit();
            this.groupBox_zoom.ResumeLayout(false);
            this.groupBox_zoom.PerformLayout();
            this.groupBox_visualisation.ResumeLayout(false);
            this.groupBox_visualisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx_sim6)).EndInit();
            this.groupBox_accuracy.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel_label;
        private System.Windows.Forms.PictureBox pcBx_label;
        private System.Windows.Forms.Panel panel_cancer;
        private System.Windows.Forms.PictureBox pcBx_cancer;
        private System.Windows.Forms.Button btn_load;
        private System.ComponentModel.BackgroundWorker backWorkLoadData;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pcBx_decisionImg;
        private System.Windows.Forms.PictureBox pxBx_sim1;
        private System.Windows.Forms.PictureBox pxBx_sim2;
        private System.Windows.Forms.PictureBox pxBx_sim3;
        private System.Windows.Forms.Label label_pxBx_sim1;
        private System.Windows.Forms.Label label_pxBx_sim2;
        private System.Windows.Forms.Label label_pxBx_sim3;
        private System.Windows.Forms.Label label_pcBx_decisionImg;
        private System.Windows.Forms.ComboBox cmbBox_experiments;
        private System.Windows.Forms.GroupBox groupBox_zoom;
        private System.Windows.Forms.GroupBox groupBox_wsi;
        private System.Windows.Forms.GroupBox groupBox_visualisation;
        private System.Windows.Forms.PictureBox pxBx_sim4;
        private System.Windows.Forms.PictureBox pxBx_sim5;
        private System.Windows.Forms.PictureBox pxBx_sim6;
        private System.Windows.Forms.Label label_pxBx_sim4;
        private System.Windows.Forms.Label label_pxBx_sim6;
        private System.Windows.Forms.Label label_pxBx_sim5;
        private System.Windows.Forms.GroupBox groupBox_accuracy;
        private System.Windows.Forms.Button button_class8;
        private System.Windows.Forms.Button button_class7;
        private System.Windows.Forms.Button button_class6;
        private System.Windows.Forms.Button button_class5;
        private System.Windows.Forms.Button button_class4;
        private System.Windows.Forms.Button button_class3;
        private System.Windows.Forms.Button button_class2;
        private System.Windows.Forms.Button button_class1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button btn_Backward;
        private System.Windows.Forms.Button btn_Statistic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_TODO;
    }
}

