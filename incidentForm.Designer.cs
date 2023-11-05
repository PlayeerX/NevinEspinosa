namespace AssignmentPC102AdjacencyIncident
{
    partial class incidentForm
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
            this.incidentMatrixGridView = new System.Windows.Forms.DataGridView();
            this.incidentListTextBox = new System.Windows.Forms.TextBox();
            this.panelGraph = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.incidentMatrixGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // incidentMatrixGridView
            // 
            this.incidentMatrixGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incidentMatrixGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.incidentMatrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentMatrixGridView.Location = new System.Drawing.Point(12, 12);
            this.incidentMatrixGridView.Name = "incidentMatrixGridView";
            this.incidentMatrixGridView.ReadOnly = true;
            this.incidentMatrixGridView.Size = new System.Drawing.Size(386, 309);
            this.incidentMatrixGridView.TabIndex = 0;
            // 
            // incidentListTextBox
            // 
            this.incidentListTextBox.Location = new System.Drawing.Point(413, 12);
            this.incidentListTextBox.Multiline = true;
            this.incidentListTextBox.Name = "incidentListTextBox";
            this.incidentListTextBox.ReadOnly = true;
            this.incidentListTextBox.Size = new System.Drawing.Size(386, 309);
            this.incidentListTextBox.TabIndex = 1;
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(805, 12);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(386, 309);
            this.panelGraph.TabIndex = 2;
            // 
            // incidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 375);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.incidentListTextBox);
            this.Controls.Add(this.incidentMatrixGridView);
            this.Name = "incidentForm";
            this.Text = "incidentForm";
            ((System.ComponentModel.ISupportInitialize)(this.incidentMatrixGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView incidentMatrixGridView;
        private System.Windows.Forms.TextBox incidentListTextBox;
        private System.Windows.Forms.Panel panelGraph;
    }
}