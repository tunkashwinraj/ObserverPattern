namespace ObserverPattern_1262774
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
            this.btnObserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObserver
            // 
            this.btnObserver.Location = new System.Drawing.Point(249, 141);
            this.btnObserver.Name = "btnObserver";
            this.btnObserver.Size = new System.Drawing.Size(186, 23);
            this.btnObserver.TabIndex = 0;
            this.btnObserver.Text = "btnObserver";
            this.btnObserver.UseVisualStyleBackColor = true;
            this.btnObserver.Click += new System.EventHandler(this.btnObserver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObserver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObserver;
    }
}

