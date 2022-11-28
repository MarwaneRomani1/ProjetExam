namespace ProjetExam.Forms
{
    partial class QuestionManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_exam_container = new System.Windows.Forms.Panel();
            this.button_retirer_question = new System.Windows.Forms.Button();
            this.button2_modifier_question = new System.Windows.Forms.Button();
            this.button_ajoute_question_exam = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_delete_question = new System.Windows.Forms.Button();
            this.button1_modifier_question = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_nouvelle_question = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exam_titre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_exam_container.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 105);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examination Systeme";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_exam_container);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 367);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel_exam_container
            // 
            this.panel_exam_container.BackColor = System.Drawing.Color.White;
            this.panel_exam_container.Controls.Add(this.exam_titre);
            this.panel_exam_container.Controls.Add(this.button_retirer_question);
            this.panel_exam_container.Controls.Add(this.button2_modifier_question);
            this.panel_exam_container.Controls.Add(this.button_ajoute_question_exam);
            this.panel_exam_container.Controls.Add(this.comboBox3);
            this.panel_exam_container.Controls.Add(this.label3);
            this.panel_exam_container.Location = new System.Drawing.Point(416, 45);
            this.panel_exam_container.Name = "panel_exam_container";
            this.panel_exam_container.Size = new System.Drawing.Size(408, 230);
            this.panel_exam_container.TabIndex = 6;
            // 
            // button_retirer_question
            // 
            this.button_retirer_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_retirer_question.FlatAppearance.BorderSize = 0;
            this.button_retirer_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_retirer_question.ForeColor = System.Drawing.Color.White;
            this.button_retirer_question.Location = new System.Drawing.Point(247, 44);
            this.button_retirer_question.Name = "button_retirer_question";
            this.button_retirer_question.Size = new System.Drawing.Size(84, 39);
            this.button_retirer_question.TabIndex = 8;
            this.button_retirer_question.Text = "retirer";
            this.button_retirer_question.UseVisualStyleBackColor = false;
            this.button_retirer_question.Click += new System.EventHandler(this.button_retirer_question_Click);
            // 
            // button2_modifier_question
            // 
            this.button2_modifier_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button2_modifier_question.FlatAppearance.BorderSize = 0;
            this.button2_modifier_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_modifier_question.ForeColor = System.Drawing.Color.White;
            this.button2_modifier_question.Location = new System.Drawing.Point(146, 44);
            this.button2_modifier_question.Name = "button2_modifier_question";
            this.button2_modifier_question.Size = new System.Drawing.Size(84, 39);
            this.button2_modifier_question.TabIndex = 7;
            this.button2_modifier_question.Text = "modifier";
            this.button2_modifier_question.UseVisualStyleBackColor = false;
            this.button2_modifier_question.Click += new System.EventHandler(this.modifier_question);
            // 
            // button_ajoute_question_exam
            // 
            this.button_ajoute_question_exam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_ajoute_question_exam.FlatAppearance.BorderSize = 0;
            this.button_ajoute_question_exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajoute_question_exam.ForeColor = System.Drawing.Color.White;
            this.button_ajoute_question_exam.Location = new System.Drawing.Point(35, 44);
            this.button_ajoute_question_exam.Name = "button_ajoute_question_exam";
            this.button_ajoute_question_exam.Size = new System.Drawing.Size(84, 39);
            this.button_ajoute_question_exam.TabIndex = 6;
            this.button_ajoute_question_exam.Text = "Ajouter";
            this.button_ajoute_question_exam.UseVisualStyleBackColor = false;
            this.button_ajoute_question_exam.Click += new System.EventHandler(this.button_ajoute_question_exam_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(43, 126);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(270, 23);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "questions";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button_delete_question);
            this.panel3.Controls.Add(this.button1_modifier_question);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.button_nouvelle_question);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 230);
            this.panel3.TabIndex = 5;
            // 
            // button_delete_question
            // 
            this.button_delete_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_delete_question.FlatAppearance.BorderSize = 0;
            this.button_delete_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_question.ForeColor = System.Drawing.Color.White;
            this.button_delete_question.Location = new System.Drawing.Point(240, 26);
            this.button_delete_question.Name = "button_delete_question";
            this.button_delete_question.Size = new System.Drawing.Size(93, 39);
            this.button_delete_question.TabIndex = 6;
            this.button_delete_question.Text = "supprimer";
            this.button_delete_question.UseVisualStyleBackColor = false;
            // 
            // button1_modifier_question
            // 
            this.button1_modifier_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button1_modifier_question.FlatAppearance.BorderSize = 0;
            this.button1_modifier_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_modifier_question.ForeColor = System.Drawing.Color.White;
            this.button1_modifier_question.Location = new System.Drawing.Point(127, 26);
            this.button1_modifier_question.Name = "button1_modifier_question";
            this.button1_modifier_question.Size = new System.Drawing.Size(93, 39);
            this.button1_modifier_question.TabIndex = 5;
            this.button1_modifier_question.Text = "modifier";
            this.button1_modifier_question.UseVisualStyleBackColor = false;
            this.button1_modifier_question.Click += new System.EventHandler(this.modifier_question);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(270, 23);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button_nouvelle_question
            // 
            this.button_nouvelle_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_nouvelle_question.FlatAppearance.BorderSize = 0;
            this.button_nouvelle_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nouvelle_question.ForeColor = System.Drawing.Color.White;
            this.button_nouvelle_question.Location = new System.Drawing.Point(12, 26);
            this.button_nouvelle_question.Name = "button_nouvelle_question";
            this.button_nouvelle_question.Size = new System.Drawing.Size(93, 39);
            this.button_nouvelle_question.TabIndex = 4;
            this.button_nouvelle_question.Text = "Nouvelle Question";
            this.button_nouvelle_question.UseVisualStyleBackColor = false;
            this.button_nouvelle_question.Click += new System.EventHandler(this.button_nouvelle_question_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toutes les questions";
            // 
            // exam_titre
            // 
            this.exam_titre.AutoSize = true;
            this.exam_titre.Location = new System.Drawing.Point(35, 17);
            this.exam_titre.Name = "exam_titre";
            this.exam_titre.Size = new System.Drawing.Size(0, 15);
            this.exam_titre.TabIndex = 9;
            // 
            // QuestionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionManager";
            this.Text = "QuestionManager";
            this.Load += new System.EventHandler(this.QuestionManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_exam_container.ResumeLayout(false);
            this.panel_exam_container.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox comboBox2;
        private Label label2;
        private Panel panel_exam_container;
        private Button button_ajoute_question_exam;
        private ComboBox comboBox3;
        private Label label3;
        private Panel panel3;
        private Button button_nouvelle_question;
        private Button button2_modifier_question;
        private Button button1_modifier_question;
        private Button button_retirer_question;
        private Button button_delete_question;
        private Label exam_titre;
    }
}