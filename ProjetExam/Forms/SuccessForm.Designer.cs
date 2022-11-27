namespace ProjetExam.Forms
{
    partial class SuccessForm
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
            this.done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(98, 66);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(84, 32);
            this.done.TabIndex = 0;
            this.done.Text = "done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 210);
            this.Controls.Add(this.done);
            this.Name = "SuccessForm";
            this.Text = "SuccessForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button done;
    }
}