
namespace GUI_Learning
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.cbxSubjectsExcel = new System.Windows.Forms.ComboBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_Input = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbxCSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(877, 42);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(203, 135);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Klicka på mig";
            this.btn_Start.UseVisualStyleBackColor = true;
           
            // 
            // cbxSubjectsExcel
            // 
            this.cbxSubjectsExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubjectsExcel.FormattingEnabled = true;
            this.cbxSubjectsExcel.Location = new System.Drawing.Point(22, 89);
            this.cbxSubjectsExcel.Name = "cbxSubjectsExcel";
            this.cbxSubjectsExcel.Size = new System.Drawing.Size(234, 37);
            this.cbxSubjectsExcel.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(898, 272);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(169, 29);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Skriv ditt namn";
            // 
            // txb_Input
            // 
            this.txb_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Input.Location = new System.Drawing.Point(843, 329);
            this.txb_Input.Name = "txb_Input";
            this.txb_Input.Size = new System.Drawing.Size(333, 34);
            this.txb_Input.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(30, 44);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(226, 29);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Välj ett ämne(Excel)";
            // 
            // cbxCSV
            // 
            this.cbxCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCSV.FormattingEnabled = true;
            this.cbxCSV.Location = new System.Drawing.Point(22, 198);
            this.cbxCSV.Name = "cbxCSV";
            this.cbxCSV.Size = new System.Drawing.Size(231, 37);
            this.cbxCSV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Välj från CSV fil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 845);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCSV);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txb_Input);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.cbxSubjectsExcel);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "GUI inlärning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ComboBox cbxSubjectsExcel;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_Input;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbxCSV;
        private System.Windows.Forms.Label label1;
    }
}

