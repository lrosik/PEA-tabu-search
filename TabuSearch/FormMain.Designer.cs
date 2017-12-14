namespace TabuSearch
{
    partial class FormMain
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
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonRunSwap = new System.Windows.Forms.Button();
            this.buttonRunInsert = new System.Windows.Forms.Button();
            this.buttonRunInvert = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxSwap = new System.Windows.Forms.TextBox();
            this.textBoxInsert = new System.Windows.Forms.TextBox();
            this.textBoxInvert = new System.Windows.Forms.TextBox();
            this.labelSwap = new System.Windows.Forms.Label();
            this.labelInsert = new System.Windows.Forms.Label();
            this.labelInvert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Wczytaj plik";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonRunSwap
            // 
            this.buttonRunSwap.Enabled = false;
            this.buttonRunSwap.Location = new System.Drawing.Point(12, 65);
            this.buttonRunSwap.Name = "buttonRunSwap";
            this.buttonRunSwap.Size = new System.Drawing.Size(75, 23);
            this.buttonRunSwap.TabIndex = 1;
            this.buttonRunSwap.Text = "Swap";
            this.buttonRunSwap.UseVisualStyleBackColor = true;
            this.buttonRunSwap.Click += new System.EventHandler(this.buttonRunSwap_Click);
            // 
            // buttonRunInsert
            // 
            this.buttonRunInsert.Enabled = false;
            this.buttonRunInsert.Location = new System.Drawing.Point(93, 65);
            this.buttonRunInsert.Name = "buttonRunInsert";
            this.buttonRunInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonRunInsert.TabIndex = 2;
            this.buttonRunInsert.Text = "Insert";
            this.buttonRunInsert.UseVisualStyleBackColor = true;
            this.buttonRunInsert.Click += new System.EventHandler(this.buttonRunInsert_Click);
            // 
            // buttonRunInvert
            // 
            this.buttonRunInvert.Enabled = false;
            this.buttonRunInvert.Location = new System.Drawing.Point(174, 65);
            this.buttonRunInvert.Name = "buttonRunInvert";
            this.buttonRunInvert.Size = new System.Drawing.Size(75, 23);
            this.buttonRunInvert.TabIndex = 3;
            this.buttonRunInvert.Text = "Invert";
            this.buttonRunInvert.UseVisualStyleBackColor = true;
            this.buttonRunInvert.Click += new System.EventHandler(this.buttonRunInvert_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(192, 35);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(72, 20);
            this.textBoxTime.TabIndex = 4;
            this.textBoxTime.Text = "10";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(9, 38);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(177, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Podaj czas wykonywania algorytmu:";
            // 
            // textBoxSwap
            // 
            this.textBoxSwap.Location = new System.Drawing.Point(52, 110);
            this.textBoxSwap.Name = "textBoxSwap";
            this.textBoxSwap.Size = new System.Drawing.Size(116, 20);
            this.textBoxSwap.TabIndex = 6;
            // 
            // textBoxInsert
            // 
            this.textBoxInsert.Location = new System.Drawing.Point(52, 136);
            this.textBoxInsert.Name = "textBoxInsert";
            this.textBoxInsert.Size = new System.Drawing.Size(116, 20);
            this.textBoxInsert.TabIndex = 7;
            // 
            // textBoxInvert
            // 
            this.textBoxInvert.Location = new System.Drawing.Point(52, 162);
            this.textBoxInvert.Name = "textBoxInvert";
            this.textBoxInvert.Size = new System.Drawing.Size(116, 20);
            this.textBoxInvert.TabIndex = 8;
            // 
            // labelSwap
            // 
            this.labelSwap.AutoSize = true;
            this.labelSwap.Location = new System.Drawing.Point(9, 113);
            this.labelSwap.Name = "labelSwap";
            this.labelSwap.Size = new System.Drawing.Size(37, 13);
            this.labelSwap.TabIndex = 9;
            this.labelSwap.Text = "Swap:";
            // 
            // labelInsert
            // 
            this.labelInsert.AutoSize = true;
            this.labelInsert.Location = new System.Drawing.Point(9, 139);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(36, 13);
            this.labelInsert.TabIndex = 10;
            this.labelInsert.Text = "Insert:";
            // 
            // labelInvert
            // 
            this.labelInvert.AutoSize = true;
            this.labelInvert.Location = new System.Drawing.Point(8, 165);
            this.labelInvert.Name = "labelInvert";
            this.labelInvert.Size = new System.Drawing.Size(37, 13);
            this.labelInvert.TabIndex = 11;
            this.labelInvert.Text = "Invert:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 275);
            this.Controls.Add(this.labelInvert);
            this.Controls.Add(this.labelInsert);
            this.Controls.Add(this.labelSwap);
            this.Controls.Add(this.textBoxInvert);
            this.Controls.Add(this.textBoxInsert);
            this.Controls.Add(this.textBoxSwap);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonRunInvert);
            this.Controls.Add(this.buttonRunInsert);
            this.Controls.Add(this.buttonRunSwap);
            this.Controls.Add(this.buttonLoadFile);
            this.Name = "FormMain";
            this.Text = "Tabu Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonRunSwap;
        private System.Windows.Forms.Button buttonRunInsert;
        private System.Windows.Forms.Button buttonRunInvert;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxSwap;
        private System.Windows.Forms.TextBox textBoxInsert;
        private System.Windows.Forms.TextBox textBoxInvert;
        private System.Windows.Forms.Label labelSwap;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.Label labelInvert;
    }
}

