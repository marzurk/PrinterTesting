namespace PrinterTesting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lsbPrinters = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.btnSavePrinterName = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lsbPrinters
            // 
            this.lsbPrinters.FormattingEnabled = true;
            this.lsbPrinters.ItemHeight = 19;
            this.lsbPrinters.Location = new System.Drawing.Point(12, 31);
            this.lsbPrinters.Name = "lsbPrinters";
            this.lsbPrinters.Size = new System.Drawing.Size(201, 118);
            this.lsbPrinters.TabIndex = 0;
            this.lsbPrinters.SelectedIndexChanged += new System.EventHandler(this.lsbPrinters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Printers detected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Printer Name";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(13, 179);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.ReadOnly = true;
            this.txtPrinterName.Size = new System.Drawing.Size(200, 27);
            this.txtPrinterName.TabIndex = 3;
            // 
            // btnSavePrinterName
            // 
            this.btnSavePrinterName.Location = new System.Drawing.Point(232, 148);
            this.btnSavePrinterName.Name = "btnSavePrinterName";
            this.btnSavePrinterName.Size = new System.Drawing.Size(118, 58);
            this.btnSavePrinterName.TabIndex = 4;
            this.btnSavePrinterName.Text = "Save Printer Name";
            this.btnSavePrinterName.UseVisualStyleBackColor = true;
            this.btnSavePrinterName.Click += new System.EventHandler(this.btnSavePrinterName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 223);
            this.Controls.Add(this.btnSavePrinterName);
            this.Controls.Add(this.txtPrinterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbPrinters);
            this.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbPrinters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Button btnSavePrinterName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

