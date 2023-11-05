namespace AssignmentPC102AdjacencyIncident
{
    partial class adjacentForm
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
            this.panelGraph = new System.Windows.Forms.Panel();
            this.adjacencyListTextBox = new System.Windows.Forms.TextBox();
            this.adjacencyMatrixGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.adjacencyMatrixGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(799, 12);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(386, 309);
            this.panelGraph.TabIndex = 5;
            // 
            // adjacencyListTextBox
            // 
            this.adjacencyListTextBox.Location = new System.Drawing.Point(407, 12);
            this.adjacencyListTextBox.Multiline = true;
            this.adjacencyListTextBox.Name = "adjacencyListTextBox";
            this.adjacencyListTextBox.ReadOnly = true;
            this.adjacencyListTextBox.Size = new System.Drawing.Size(386, 309);
            this.adjacencyListTextBox.TabIndex = 4;
            // 
            // adjacencyMatrixGridView
            // 
            this.adjacencyMatrixGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adjacencyMatrixGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.adjacencyMatrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adjacencyMatrixGridView.Location = new System.Drawing.Point(6, 12);
            this.adjacencyMatrixGridView.Name = "adjacencyMatrixGridView";
            this.adjacencyMatrixGridView.ReadOnly = true;
            this.adjacencyMatrixGridView.Size = new System.Drawing.Size(386, 309);
            this.adjacencyMatrixGridView.TabIndex = 3;
            // 
            // adjacentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 372);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.adjacencyListTextBox);
            this.Controls.Add(this.adjacencyMatrixGridView);
            this.Name = "adjacentForm";
            this.Text = "adjacentForm";
            ((System.ComponentModel.ISupportInitialize)(this.adjacencyMatrixGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.TextBox adjacencyListTextBox;
        private System.Windows.Forms.DataGridView adjacencyMatrixGridView;
    }
}