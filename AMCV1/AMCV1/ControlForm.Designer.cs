namespace AMCV1
{
    partial class ControlForm
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
            this.button_runServer = new System.Windows.Forms.Button();
            this.button_runClient = new System.Windows.Forms.Button();
            this.button_openvlc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_runServer
            // 
            this.button_runServer.Location = new System.Drawing.Point(31, 22);
            this.button_runServer.Name = "button_runServer";
            this.button_runServer.Size = new System.Drawing.Size(75, 23);
            this.button_runServer.TabIndex = 0;
            this.button_runServer.Text = "Run Server";
            this.button_runServer.UseVisualStyleBackColor = true;
            this.button_runServer.Click += new System.EventHandler(this.button_runServer_Click);
            // 
            // button_runClient
            // 
            this.button_runClient.Location = new System.Drawing.Point(161, 22);
            this.button_runClient.Name = "button_runClient";
            this.button_runClient.Size = new System.Drawing.Size(75, 23);
            this.button_runClient.TabIndex = 1;
            this.button_runClient.Text = "Run Client";
            this.button_runClient.UseVisualStyleBackColor = true;
            this.button_runClient.Click += new System.EventHandler(this.button_runClient_Click);
            // 
            // button_openvlc
            // 
            this.button_openvlc.Location = new System.Drawing.Point(320, 114);
            this.button_openvlc.Name = "button_openvlc";
            this.button_openvlc.Size = new System.Drawing.Size(75, 23);
            this.button_openvlc.TabIndex = 2;
            this.button_openvlc.Text = "VLC";
            this.button_openvlc.UseVisualStyleBackColor = true;
            this.button_openvlc.Click += new System.EventHandler(this.button_openvlc_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 573);
            this.Controls.Add(this.button_openvlc);
            this.Controls.Add(this.button_runClient);
            this.Controls.Add(this.button_runServer);
            this.Name = "ControlForm";
            this.Text = "Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_runServer;
        private System.Windows.Forms.Button button_runClient;
        private System.Windows.Forms.Button button_openvlc;
    }
}

