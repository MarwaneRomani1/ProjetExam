﻿namespace ProjetExam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.question_grid_view = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.question_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 105);
            this.panel1.TabIndex = 0;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liste des Exam";
            // 
            // button_nouveau
            // 
            this.button_nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_nouveau.FlatAppearance.BorderSize = 0;
            this.button_nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nouveau.ForeColor = System.Drawing.Color.White;
            this.button_nouveau.Location = new System.Drawing.Point(118, 277);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(123, 39);
            this.button_nouveau.TabIndex = 3;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = false;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_modifier.FlatAppearance.BorderSize = 0;
            this.button_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modifier.ForeColor = System.Drawing.Color.White;
            this.button_modifier.Location = new System.Drawing.Point(258, 277);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(123, 39);
            this.button_modifier.TabIndex = 4;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_supprimer.FlatAppearance.BorderSize = 0;
            this.button_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supprimer.ForeColor = System.Drawing.Color.White;
            this.button_supprimer.Location = new System.Drawing.Point(401, 277);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(123, 39);
            this.button_supprimer.TabIndex = 5;
            this.button_supprimer.Text = "supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_supprimer);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button_modifier);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_nouveau);
            this.panel2.Location = new System.Drawing.Point(97, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 380);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.question_grid_view);
            this.panel3.Location = new System.Drawing.Point(118, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 197);
            this.panel3.TabIndex = 6;
            // 
            // question_grid_view
            // 
            this.question_grid_view.BackgroundColor = System.Drawing.Color.White;
            this.question_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.question_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.Type});
            this.question_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question_grid_view.Location = new System.Drawing.Point(0, 0);
            this.question_grid_view.Name = "question_grid_view";
            this.question_grid_view.RowTemplate.Height = 25;
            this.question_grid_view.Size = new System.Drawing.Size(406, 197);
            this.question_grid_view.TabIndex = 0;
            this.question_grid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Question
            // 
            this.Question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Question.HeaderText = "question";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.question_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button_nouveau;
        private Button button_modifier;
        private Button button_supprimer;
        private Panel panel2;
        private Panel panel3;
        private DataGridView question_grid_view;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn Type;
    }
}