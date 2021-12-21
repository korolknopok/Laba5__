using System.ComponentModel;

namespace Laba5_2
{
    partial class ReplaceColumnForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dgMatrix1 = new System.Windows.Forms.DataGridView();
            this.dgMatrix2 = new System.Windows.Forms.DataGridView();
            this.b_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dgMatrix1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgMatrix2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMatrix1
            // 
            this.dgMatrix1.AllowUserToAddRows = false;
            this.dgMatrix1.AllowUserToDeleteRows = false;
            this.dgMatrix1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMatrix1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgMatrix1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatrix1.Location = new System.Drawing.Point(44, 196);
            this.dgMatrix1.Name = "dgMatrix1";
            this.dgMatrix1.RowTemplate.Height = 24;
            this.dgMatrix1.Size = new System.Drawing.Size(260, 169);
            this.dgMatrix1.TabIndex = 0;
            this.dgMatrix1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMatrix1_CellContentClick);
            // 
            // dgMatrix2
            // 
            this.dgMatrix2.AllowUserToAddRows = false;
            this.dgMatrix2.AllowUserToDeleteRows = false;
            this.dgMatrix2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMatrix2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgMatrix2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatrix2.Location = new System.Drawing.Point(374, 196);
            this.dgMatrix2.Name = "dgMatrix2";
            this.dgMatrix2.RowTemplate.Height = 24;
            this.dgMatrix2.Size = new System.Drawing.Size(282, 169);
            this.dgMatrix2.TabIndex = 1;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(300, 99);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(64, 58);
            this.b_ok.TabIndex = 2;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввод строки в первой матрцы столбца, который хотите заменить";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(374, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ввод строки во второй  матрцы столбца, который хотите заменить";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 22);
            this.textBox2.TabIndex = 6;
            // 
            // ReplaceColumnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 377);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.dgMatrix2);
            this.Controls.Add(this.dgMatrix1);
            this.Name = "ReplaceColumnForm";
            this.Text = "Поменять матрицу...";
            this.Load += new System.EventHandler(this.ReplaceColumnForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgMatrix1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgMatrix2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dgMatrix2;

        private System.Windows.Forms.DataGridView dgMatrix1;

        #endregion
    }
}