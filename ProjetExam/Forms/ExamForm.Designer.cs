namespace ProjetExam.Forms
{
    partial class ExamForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_exam_formulaire = new System.Windows.Forms.Panel();
            this.label_err = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.duree_picker = new System.Windows.Forms.NumericUpDown();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.titre_picker = new System.Windows.Forms.TextBox();
            this.label_titre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.level_picker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_exam_formulaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duree_picker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 105);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Creer un exam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examination Systeme";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel_exam_formulaire);
            this.panel2.Location = new System.Drawing.Point(34, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 310);
            this.panel2.TabIndex = 2;
            // 
            // panel_exam_formulaire
            // 
            this.panel_exam_formulaire.Controls.Add(this.label_err);
            this.panel_exam_formulaire.Controls.Add(this.button_save);
            this.panel_exam_formulaire.Controls.Add(this.duree_picker);
            this.panel_exam_formulaire.Controls.Add(this.date_picker);
            this.panel_exam_formulaire.Controls.Add(this.label5);
            this.panel_exam_formulaire.Controls.Add(this.titre_picker);
            this.panel_exam_formulaire.Controls.Add(this.label_titre);
            this.panel_exam_formulaire.Controls.Add(this.label4);
            this.panel_exam_formulaire.Controls.Add(this.level_picker);
            this.panel_exam_formulaire.Controls.Add(this.label3);
            this.panel_exam_formulaire.Location = new System.Drawing.Point(31, 32);
            this.panel_exam_formulaire.Name = "panel_exam_formulaire";
            this.panel_exam_formulaire.Size = new System.Drawing.Size(349, 265);
            this.panel_exam_formulaire.TabIndex = 8;
            this.panel_exam_formulaire.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_exam_formulaire_Paint);
            // 
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.Location = new System.Drawing.Point(77, 198);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(0, 15);
            this.label_err.TabIndex = 11;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(77, 216);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(123, 39);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Enregistrer";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // duree_picker
            // 
            this.duree_picker.Location = new System.Drawing.Point(77, 161);
            this.duree_picker.Name = "duree_picker";
            this.duree_picker.Size = new System.Drawing.Size(200, 23);
            this.duree_picker.TabIndex = 9;
            this.duree_picker.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // date_picker
            // 
            this.date_picker.CustomFormat = "yyyy-mm-dd  hh:mm:ss";
            this.date_picker.Location = new System.Drawing.Point(77, 116);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(200, 23);
            this.date_picker.TabIndex = 8;
            this.date_picker.ValueChanged += new System.EventHandler(this.date_picker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "durée :";
            // 
            // titre_picker
            // 
            this.titre_picker.Location = new System.Drawing.Point(77, 28);
            this.titre_picker.Multiline = true;
            this.titre_picker.Name = "titre_picker";
            this.titre_picker.Size = new System.Drawing.Size(200, 24);
            this.titre_picker.TabIndex = 0;
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_titre.Location = new System.Drawing.Point(14, 28);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(49, 21);
            this.label_titre.TabIndex = 1;
            this.label_titre.Text = "titre  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "date  :";
            // 
            // level_picker
            // 
            this.level_picker.Location = new System.Drawing.Point(77, 72);
            this.level_picker.Multiline = true;
            this.level_picker.Name = "level_picker";
            this.level_picker.Size = new System.Drawing.Size(200, 24);
            this.level_picker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "level  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_exam_formulaire.ResumeLayout(false);
            this.panel_exam_formulaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duree_picker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel_exam_formulaire;
        private Label label5;
        private TextBox titre_picker;
        private Label label_titre;
        private Label label4;
        private TextBox level_picker;
        private Label label3;
        private NumericUpDown duree_picker;
        private DateTimePicker date_picker;
        private Button button_save;
        private Label label_err;
    }
}