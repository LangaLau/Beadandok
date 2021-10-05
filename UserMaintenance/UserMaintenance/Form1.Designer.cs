
namespace UserMaintenance
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
            this.listBox1_fullname = new System.Windows.Forms.ListBox();
            this.label1_last = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_lastname = new System.Windows.Forms.TextBox();
            this.button2_SaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1_fullname
            // 
            this.listBox1_fullname.FormattingEnabled = true;
            this.listBox1_fullname.Location = new System.Drawing.Point(12, 12);
            this.listBox1_fullname.Name = "listBox1_fullname";
            this.listBox1_fullname.Size = new System.Drawing.Size(120, 160);
            this.listBox1_fullname.TabIndex = 0;
            // 
            // label1_last
            // 
            this.label1_last.AutoSize = true;
            this.label1_last.Location = new System.Drawing.Point(138, 15);
            this.label1_last.Name = "label1_last";
            this.label1_last.Size = new System.Drawing.Size(35, 13);
            this.label1_last.TabIndex = 3;
            this.label1_last.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_lastname
            // 
            this.textBox1_lastname.Location = new System.Drawing.Point(210, 12);
            this.textBox1_lastname.Name = "textBox1_lastname";
            this.textBox1_lastname.Size = new System.Drawing.Size(147, 20);
            this.textBox1_lastname.TabIndex = 8;
            // 
            // button2_SaveFile
            // 
            this.button2_SaveFile.Location = new System.Drawing.Point(289, 54);
            this.button2_SaveFile.Name = "button2_SaveFile";
            this.button2_SaveFile.Size = new System.Drawing.Size(68, 32);
            this.button2_SaveFile.TabIndex = 9;
            this.button2_SaveFile.Text = "button2";
            this.button2_SaveFile.UseVisualStyleBackColor = true;
            this.button2_SaveFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 206);
            this.Controls.Add(this.button2_SaveFile);
            this.Controls.Add(this.textBox1_lastname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1_last);
            this.Controls.Add(this.listBox1_fullname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1_fullname;
        private System.Windows.Forms.Label label1_last;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_lastname;
        private System.Windows.Forms.Button button2_SaveFile;
    }
}

