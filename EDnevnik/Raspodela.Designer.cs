﻿namespace EDnevnik
{
    partial class Raspodela
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
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_odeljenje = new System.Windows.Forms.Label();
            this.lbl_predmet = new System.Windows.Forms.Label();
            this.lbl_nastavnik = new System.Windows.Forms.Label();
            this.lbl_godina = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.cmb_nastavnik = new System.Windows.Forms.ComboBox();
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(426, 310);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 23);
            this.btn_last.TabIndex = 33;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click_1);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(426, 281);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 32;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(345, 281);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Brisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(264, 281);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "Izmeni";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(183, 281);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 29;
            this.btn_insert.Text = "Dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(97, 281);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 23);
            this.btn_previous.TabIndex = 28;
            this.btn_previous.Text = "<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click_1);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(97, 310);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 23);
            this.btn_first.TabIndex = 27;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(67, 34);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(226, 20);
            this.txt_id.TabIndex = 26;
            // 
            // lbl_odeljenje
            // 
            this.lbl_odeljenje.AutoSize = true;
            this.lbl_odeljenje.Location = new System.Drawing.Point(8, 199);
            this.lbl_odeljenje.Name = "lbl_odeljenje";
            this.lbl_odeljenje.Size = new System.Drawing.Size(54, 13);
            this.lbl_odeljenje.TabIndex = 25;
            this.lbl_odeljenje.Text = "Odeljenje:";
            // 
            // lbl_predmet
            // 
            this.lbl_predmet.AutoSize = true;
            this.lbl_predmet.Location = new System.Drawing.Point(8, 160);
            this.lbl_predmet.Name = "lbl_predmet";
            this.lbl_predmet.Size = new System.Drawing.Size(49, 13);
            this.lbl_predmet.TabIndex = 24;
            this.lbl_predmet.Text = "Predmet:";
            // 
            // lbl_nastavnik
            // 
            this.lbl_nastavnik.AutoSize = true;
            this.lbl_nastavnik.Location = new System.Drawing.Point(8, 120);
            this.lbl_nastavnik.Name = "lbl_nastavnik";
            this.lbl_nastavnik.Size = new System.Drawing.Size(58, 13);
            this.lbl_nastavnik.TabIndex = 23;
            this.lbl_nastavnik.Text = "Nastavnik:";
            // 
            // lbl_godina
            // 
            this.lbl_godina.AutoSize = true;
            this.lbl_godina.Location = new System.Drawing.Point(8, 78);
            this.lbl_godina.Name = "lbl_godina";
            this.lbl_godina.Size = new System.Drawing.Size(44, 13);
            this.lbl_godina.TabIndex = 22;
            this.lbl_godina.Text = "Godina:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(8, 34);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 21;
            this.lbl_id.Text = "ID";
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(67, 199);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(226, 21);
            this.cmb_odeljenje.TabIndex = 20;
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(67, 160);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(226, 21);
            this.cmb_predmet.TabIndex = 19;
            // 
            // cmb_nastavnik
            // 
            this.cmb_nastavnik.FormattingEnabled = true;
            this.cmb_nastavnik.Location = new System.Drawing.Point(67, 120);
            this.cmb_nastavnik.Name = "cmb_nastavnik";
            this.cmb_nastavnik.Size = new System.Drawing.Size(226, 21);
            this.cmb_nastavnik.TabIndex = 18;
            // 
            // cmb_godina
            // 
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(67, 78);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(226, 21);
            this.cmb_godina.TabIndex = 17;
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 407);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_odeljenje);
            this.Controls.Add(this.lbl_predmet);
            this.Controls.Add(this.lbl_nastavnik);
            this.Controls.Add(this.lbl_godina);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.cmb_nastavnik);
            this.Controls.Add(this.cmb_godina);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_odeljenje;
        private System.Windows.Forms.Label lbl_predmet;
        private System.Windows.Forms.Label lbl_nastavnik;
        private System.Windows.Forms.Label lbl_godina;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.ComboBox cmb_nastavnik;
        private System.Windows.Forms.ComboBox cmb_godina;
    }
}