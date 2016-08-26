namespace WindowsFormsApplication1
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
            this.btnGreet = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGreet
            // 
            this.btnGreet.Location = new System.Drawing.Point(98, 112);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(75, 23);
            this.btnGreet.TabIndex = 0;
            this.btnGreet.Text = "button1";
            this.btnGreet.UseVisualStyleBackColor = true;
            this.btnGreet.Click += new System.EventHandler(this.btnGreet_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(79, 64);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(110, 45);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "label1";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 318);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnGreet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGreet;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox txtName;
    }
}

