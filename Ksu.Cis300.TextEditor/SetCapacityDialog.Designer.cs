namespace Ksu.Cis300.TextEditor
{
    partial class SetCapacityDialog
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
            this.uxCapacity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.UxOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCapacity
            // 
            this.uxCapacity.Location = new System.Drawing.Point(12, 30);
            this.uxCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxCapacity.Name = "uxCapacity";
            this.uxCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxCapacity.Size = new System.Drawing.Size(117, 20);
            this.uxCapacity.TabIndex = 0;
            this.uxCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Capacity:";
            // 
            // UxOk
            // 
            this.UxOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UxOk.Location = new System.Drawing.Point(28, 56);
            this.UxOk.Name = "UxOk";
            this.UxOk.Size = new System.Drawing.Size(75, 23);
            this.UxOk.TabIndex = 2;
            this.UxOk.Text = "OK";
            this.UxOk.UseVisualStyleBackColor = true;
            this.UxOk.Click += new System.EventHandler(this.UxOk_Click);
            // 
            // SetCapacityDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(140, 86);
            this.Controls.Add(this.UxOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxCapacity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SetCapacityDialog";
            this.Text = "CapacityDialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown uxCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UxOk;
    }
}