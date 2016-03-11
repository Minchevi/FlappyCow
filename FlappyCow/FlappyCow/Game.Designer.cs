namespace FlappyCow
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cow = new System.Windows.Forms.PictureBox();
            this.points = new System.Windows.Forms.TextBox();
            this.retryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cow)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cow
            // 
            this.cow.BackColor = System.Drawing.Color.Transparent;
            this.cow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cow.BackgroundImage")));
            this.cow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cow.Location = new System.Drawing.Point(50, 90);
            this.cow.Name = "cow";
            this.cow.Size = new System.Drawing.Size(60, 50);
            this.cow.TabIndex = 0;
            this.cow.TabStop = false;
            // 
            // points
            // 
            this.points.BackColor = System.Drawing.Color.PapayaWhip;
            this.points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.points.Enabled = false;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.Color.Black;
            this.points.Location = new System.Drawing.Point(663, 12);
            this.points.Margin = new System.Windows.Forms.Padding(5);
            this.points.Name = "points";
            this.points.ReadOnly = true;
            this.points.Size = new System.Drawing.Size(93, 39);
            this.points.TabIndex = 6;
            this.points.Text = "0";
            this.points.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // retryButton
            // 
            this.retryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.retryButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.retryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.retryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryButton.Location = new System.Drawing.Point(295, 104);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(197, 117);
            this.retryButton.TabIndex = 7;
            this.retryButton.Text = "Retry?";
            this.retryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(778, 431);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.points);
            this.Controls.Add(this.cow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Cow";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.cow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox cow;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox points;
        private System.Windows.Forms.Button retryButton;
    }
}

