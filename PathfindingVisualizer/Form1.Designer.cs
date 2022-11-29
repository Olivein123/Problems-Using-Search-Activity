namespace PathfindingVisualizer
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Vizualiziraj_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OcistiPut_button = new System.Windows.Forms.Button();
            this.NoNode_label = new System.Windows.Forms.Label();
            this.NoVisited_label = new System.Windows.Forms.Label();
            this.PathLength_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BFS",
            "A*",
            "Greedy Best-first Search",
            "Bidirectional BFS",
            "Bidirectional Swarm Algoritham"});
            this.comboBox1.Location = new System.Drawing.Point(215, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Algorithm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Vizualiziraj_button
            // 
            this.Vizualiziraj_button.BackColor = System.Drawing.Color.LavenderBlush;
            this.Vizualiziraj_button.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.Vizualiziraj_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.Vizualiziraj_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.Vizualiziraj_button.Location = new System.Drawing.Point(380, 40);
            this.Vizualiziraj_button.Name = "Vizualiziraj_button";
            this.Vizualiziraj_button.Size = new System.Drawing.Size(106, 27);
            this.Vizualiziraj_button.TabIndex = 2;
            this.Vizualiziraj_button.Text = "Find Path";
            this.Vizualiziraj_button.UseVisualStyleBackColor = false;
            this.Vizualiziraj_button.Click += new System.EventHandler(this.Vizualiziraj_button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Location = new System.Drawing.Point(501, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear Board";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // OcistiPut_button
            // 
            this.OcistiPut_button.BackColor = System.Drawing.Color.LavenderBlush;
            this.OcistiPut_button.Location = new System.Drawing.Point(501, 61);
            this.OcistiPut_button.Name = "OcistiPut_button";
            this.OcistiPut_button.Size = new System.Drawing.Size(106, 27);
            this.OcistiPut_button.TabIndex = 5;
            this.OcistiPut_button.Text = "Clear Path";
            this.OcistiPut_button.UseVisualStyleBackColor = false;
            this.OcistiPut_button.Click += new System.EventHandler(this.OcistiPut_button_Click);
            // 
            // NoNode_label
            // 
            this.NoNode_label.AutoSize = true;
            this.NoNode_label.Location = new System.Drawing.Point(12, 117);
            this.NoNode_label.Name = "NoNode_label";
            this.NoNode_label.Size = new System.Drawing.Size(51, 16);
            this.NoNode_label.TabIndex = 10;
            this.NoNode_label.Text = "Nodes:";
            this.NoNode_label.Click += new System.EventHandler(this.NoNode_label_Click);
            // 
            // NoVisited_label
            // 
            this.NoVisited_label.AutoSize = true;
            this.NoVisited_label.Location = new System.Drawing.Point(134, 117);
            this.NoVisited_label.Name = "NoVisited_label";
            this.NoVisited_label.Size = new System.Drawing.Size(51, 16);
            this.NoVisited_label.TabIndex = 11;
            this.NoVisited_label.Text = "Visited:";
            // 
            // PathLength_label
            // 
            this.PathLength_label.AutoSize = true;
            this.PathLength_label.Location = new System.Drawing.Point(243, 117);
            this.PathLength_label.Name = "PathLength_label";
            this.PathLength_label.Size = new System.Drawing.Size(80, 16);
            this.PathLength_label.TabIndex = 12;
            this.PathLength_label.Text = "Path Length:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(619, 603);
            this.Controls.Add(this.PathLength_label);
            this.Controls.Add(this.NoVisited_label);
            this.Controls.Add(this.NoNode_label);
            this.Controls.Add(this.OcistiPut_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Vizualiziraj_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Pathfinding Visualizer -Adnan Galijasevic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Vizualiziraj_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OcistiPut_button;
        private System.Windows.Forms.Label NoNode_label;
        private System.Windows.Forms.Label NoVisited_label;
        private System.Windows.Forms.Label PathLength_label;
        private System.Windows.Forms.Timer timer1;
    }
}

