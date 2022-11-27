namespace ProjetExam.Forms
{
    partial class QuestionForm
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
            this.panel_question_form = new System.Windows.Forms.Panel();
            this.label_error = new System.Windows.Forms.Label();
            this.panel_choix = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_choix = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.textBox_note = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_question = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_qcm = new System.Windows.Forms.Button();
            this.button_nouvelle_question = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_question_form.SuspendLayout();
            this.panel_choix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_note)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 101);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nouvelle Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examination Systeme";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel_question_form);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_qcm);
            this.panel2.Controls.Add(this.button_nouvelle_question);
            this.panel2.Location = new System.Drawing.Point(24, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 433);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel_question_form
            // 
            this.panel_question_form.Controls.Add(this.label_error);
            this.panel_question_form.Controls.Add(this.panel_choix);
            this.panel_question_form.Controls.Add(this.button_enregistrer);
            this.panel_question_form.Controls.Add(this.textBox_note);
            this.panel_question_form.Controls.Add(this.label5);
            this.panel_question_form.Controls.Add(this.textBox_question);
            this.panel_question_form.Controls.Add(this.label4);
            this.panel_question_form.Location = new System.Drawing.Point(17, 131);
            this.panel_question_form.Name = "panel_question_form";
            this.panel_question_form.Size = new System.Drawing.Size(588, 286);
            this.panel_question_form.TabIndex = 9;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(22, 226);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 15);
            this.label_error.TabIndex = 10;
            // 
            // panel_choix
            // 
            this.panel_choix.Controls.Add(this.button1);
            this.panel_choix.Controls.Add(this.textBox2);
            this.panel_choix.Controls.Add(this.label7);
            this.panel_choix.Controls.Add(this.comboBox_choix);
            this.panel_choix.Controls.Add(this.label6);
            this.panel_choix.Location = new System.Drawing.Point(22, 113);
            this.panel_choix.Name = "panel_choix";
            this.panel_choix.Size = new System.Drawing.Size(411, 113);
            this.panel_choix.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(286, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 32);
            this.textBox2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ajouter Un choix";
            // 
            // comboBox_choix
            // 
            this.comboBox_choix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_choix.FormattingEnabled = true;
            this.comboBox_choix.Location = new System.Drawing.Point(71, 12);
            this.comboBox_choix.Name = "comboBox_choix";
            this.comboBox_choix.Size = new System.Drawing.Size(256, 23);
            this.comboBox_choix.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Choix";
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_enregistrer.FlatAppearance.BorderSize = 0;
            this.button_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enregistrer.ForeColor = System.Drawing.Color.White;
            this.button_enregistrer.Location = new System.Drawing.Point(22, 244);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(132, 39);
            this.button_enregistrer.TabIndex = 8;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = false;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // textBox_note
            // 
            this.textBox_note.Location = new System.Drawing.Point(93, 84);
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(256, 23);
            this.textBox_note.TabIndex = 3;
            this.textBox_note.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Note";
            // 
            // textBox_question
            // 
            this.textBox_question.Location = new System.Drawing.Point(93, 32);
            this.textBox_question.Multiline = true;
            this.textBox_question.Name = "textBox_question";
            this.textBox_question.Size = new System.Drawing.Size(256, 29);
            this.textBox_question.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Question";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type Question";
            // 
            // button_qcm
            // 
            this.button_qcm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_qcm.FlatAppearance.BorderSize = 0;
            this.button_qcm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_qcm.ForeColor = System.Drawing.Color.White;
            this.button_qcm.Location = new System.Drawing.Point(132, 66);
            this.button_qcm.Name = "button_qcm";
            this.button_qcm.Size = new System.Drawing.Size(93, 39);
            this.button_qcm.TabIndex = 7;
            this.button_qcm.Text = "QCM";
            this.button_qcm.UseVisualStyleBackColor = false;
            this.button_qcm.Click += new System.EventHandler(this.button_qcm_Click);
            // 
            // button_nouvelle_question
            // 
            this.button_nouvelle_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_nouvelle_question.FlatAppearance.BorderSize = 0;
            this.button_nouvelle_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nouvelle_question.ForeColor = System.Drawing.Color.White;
            this.button_nouvelle_question.Location = new System.Drawing.Point(17, 66);
            this.button_nouvelle_question.Name = "button_nouvelle_question";
            this.button_nouvelle_question.Size = new System.Drawing.Size(93, 39);
            this.button_nouvelle_question.TabIndex = 6;
            this.button_nouvelle_question.Text = "Question Reguliaire";
            this.button_nouvelle_question.UseVisualStyleBackColor = false;
            this.button_nouvelle_question.Click += new System.EventHandler(this.button_normal_question_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.reloadData);
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.Leave += new System.EventHandler(this.reloadData);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_question_form.ResumeLayout(false);
            this.panel_question_form.PerformLayout();
            this.panel_choix.ResumeLayout(false);
            this.panel_choix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_note)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Button button_qcm;
        private Button button_nouvelle_question;
        private Panel panel_question_form;
        private NumericUpDown textBox_note;
        private Label label5;
        private TextBox textBox_question;
        private Label label4;
        private Button button_enregistrer;
        private Panel panel_choix;
        private Label label6;
        private Button button1;
        private TextBox textBox2;
        private Label label7;
        private ComboBox comboBox_choix;
        private Label label_error;
    }
}