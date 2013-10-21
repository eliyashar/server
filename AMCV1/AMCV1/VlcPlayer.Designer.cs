namespace AMCV1
{
    partial class VlcPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VlcPlayer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_play = new System.Windows.Forms.Button();
            this.vlc = new AxAXVLC.AxVLCPlugin();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlc)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_play);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.vlc);
            this.splitContainer1.Size = new System.Drawing.Size(725, 465);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(36, 30);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 0;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // vlc
            // 
            this.vlc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlc.Enabled = true;
            this.vlc.Location = new System.Drawing.Point(0, 0);
            this.vlc.Name = "vlc";
            this.vlc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vlc.OcxState")));
            this.vlc.Size = new System.Drawing.Size(480, 465);
            this.vlc.TabIndex = 0;
            // 
            // VlcPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 465);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VlcPlayer";
            this.Text = "VlcPlayer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vlc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_play;
        private AxAXVLC.AxVLCPlugin vlc;
    }
}