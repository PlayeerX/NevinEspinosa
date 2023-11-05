namespace AssignmentPC102AdjacencyIncident
{
    partial class InputForm
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
            this.txtGraphInput = new System.Windows.Forms.TextBox();
            this.btnAdjacentForm = new System.Windows.Forms.Button();
            this.btnIncidentForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGraphInput
            // 
            this.txtGraphInput.Location = new System.Drawing.Point(12, 12);
            this.txtGraphInput.Multiline = true;
            this.txtGraphInput.Name = "txtGraphInput";
            this.txtGraphInput.Size = new System.Drawing.Size(350, 426);
            this.txtGraphInput.TabIndex = 0;
            // 
            // btnAdjacentForm
            // 
            this.btnAdjacentForm.Location = new System.Drawing.Point(411, 227);
            this.btnAdjacentForm.Name = "btnAdjacentForm";
            this.btnAdjacentForm.Size = new System.Drawing.Size(143, 55);
            this.btnAdjacentForm.TabIndex = 1;
            this.btnAdjacentForm.Text = "Adjacent Form";
            this.btnAdjacentForm.UseVisualStyleBackColor = true;
            this.btnAdjacentForm.Click += new System.EventHandler(this.btnAdjacentForm_Click);
            // 
            // btnIncidentForm
            // 
            this.btnIncidentForm.Location = new System.Drawing.Point(619, 227);
            this.btnIncidentForm.Name = "btnIncidentForm";
            this.btnIncidentForm.Size = new System.Drawing.Size(143, 55);
            this.btnIncidentForm.TabIndex = 2;
            this.btnIncidentForm.Text = "Incident Form";
            this.btnIncidentForm.UseVisualStyleBackColor = true;
            this.btnIncidentForm.Click += new System.EventHandler(this.btnIncidentForm_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncidentForm);
            this.Controls.Add(this.btnAdjacentForm);
            this.Controls.Add(this.txtGraphInput);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGraphInput;
        private System.Windows.Forms.Button btnAdjacentForm;
        private System.Windows.Forms.Button btnIncidentForm;
    }
}

