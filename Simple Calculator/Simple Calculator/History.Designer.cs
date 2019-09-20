namespace Simple_Calculator
{
    partial class History
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
            this.historyScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // historyScreen
            // 
            this.historyScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.historyScreen.Location = new System.Drawing.Point(14, 23);
            this.historyScreen.Name = "historyScreen";
            this.historyScreen.Size = new System.Drawing.Size(700, 962);
            this.historyScreen.TabIndex = 0;
            this.historyScreen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 1009);
            this.Controls.Add(this.historyScreen);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label historyScreen;
    }
}