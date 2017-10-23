namespace SIAM
{
    partial class FormRekapHasilStudi
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
            this.dataGridViewRHS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRHS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRHS
            // 
            this.dataGridViewRHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewRHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRHS.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewRHS.MultiSelect = false;
            this.dataGridViewRHS.Name = "dataGridViewRHS";
            this.dataGridViewRHS.ReadOnly = true;
            this.dataGridViewRHS.Size = new System.Drawing.Size(653, 399);
            this.dataGridViewRHS.TabIndex = 0;
            // 
            // FormRekapHasilStudi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(678, 424);
            this.Controls.Add(this.dataGridViewRHS);
            this.Name = "FormRekapHasilStudi";
            this.Text = "FormRekapHasilStudi";
            this.Load += new System.EventHandler(this.FormRekapHasilStudi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRHS;
    }
}