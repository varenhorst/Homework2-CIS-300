﻿namespace Ksu.Cis300.TextEditor
{
    partial class UserInterface
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
            this.uxMenuBar = new System.Windows.Forms.MenuStrip();
            this.uxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncryptWithString = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncryptWithStringBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEditBuffer = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.uxUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.uxRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuBar
            // 
            this.uxMenuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uxMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile,
            this.uxEncrypt,
            this.uxEdit});
            this.uxMenuBar.Location = new System.Drawing.Point(0, 0);
            this.uxMenuBar.Name = "uxMenuBar";
            this.uxMenuBar.Size = new System.Drawing.Size(583, 33);
            this.uxMenuBar.TabIndex = 0;
            this.uxMenuBar.Text = "menuStrip1";
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxSaveAs});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(50, 29);
            this.uxFile.Text = "File";
            // 
            // uxOpen
            // 
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(185, 30);
            this.uxOpen.Text = "Open . . .";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxSaveAs
            // 
            this.uxSaveAs.Name = "uxSaveAs";
            this.uxSaveAs.Size = new System.Drawing.Size(185, 30);
            this.uxSaveAs.Text = "Save As . . .";
            this.uxSaveAs.Click += new System.EventHandler(this.uxSaveAs_Click);
            // 
            // uxEncrypt
            // 
            this.uxEncrypt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxEncryptWithString,
            this.uxEncryptWithStringBuilder});
            this.uxEncrypt.Name = "uxEncrypt";
            this.uxEncrypt.Size = new System.Drawing.Size(83, 29);
            this.uxEncrypt.Text = "Encrypt";
            // 
            // uxEncryptWithString
            // 
            this.uxEncryptWithString.Name = "uxEncryptWithString";
            this.uxEncryptWithString.Size = new System.Drawing.Size(238, 30);
            this.uxEncryptWithString.Text = "With String";
            this.uxEncryptWithString.Click += new System.EventHandler(this.uxEncryptWithString_Click);
            // 
            // uxEncryptWithStringBuilder
            // 
            this.uxEncryptWithStringBuilder.Name = "uxEncryptWithStringBuilder";
            this.uxEncryptWithStringBuilder.Size = new System.Drawing.Size(238, 30);
            this.uxEncryptWithStringBuilder.Text = "With StringBuilder";
            this.uxEncryptWithStringBuilder.Click += new System.EventHandler(this.uxEncryptWithStringBuilder_Click);
            // 
            // uxEditBuffer
            // 
            this.uxEditBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxEditBuffer.Location = new System.Drawing.Point(12, 36);
            this.uxEditBuffer.MaxLength = 0;
            this.uxEditBuffer.Multiline = true;
            this.uxEditBuffer.Name = "uxEditBuffer";
            this.uxEditBuffer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxEditBuffer.Size = new System.Drawing.Size(559, 474);
            this.uxEditBuffer.TabIndex = 1;
            this.uxEditBuffer.TextChanged += new System.EventHandler(this.uxEditBuffer_TextChanged);
            // 
            // uxEdit
            // 
            this.uxEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxUndo,
            this.uxRedo});
            this.uxEdit.Name = "uxEdit";
            this.uxEdit.Size = new System.Drawing.Size(54, 29);
            this.uxEdit.Text = "Edit";
            // 
            // uxUndo
            // 
            this.uxUndo.Enabled = false;
            this.uxUndo.Name = "uxUndo";
            this.uxUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.uxUndo.Size = new System.Drawing.Size(252, 30);
            this.uxUndo.Text = "Undo";
            this.uxUndo.Click += new System.EventHandler(this.uxUndo_Click);
            // 
            // uxRedo
            // 
            this.uxRedo.Enabled = false;
            this.uxRedo.Name = "uxRedo";
            this.uxRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.uxRedo.Size = new System.Drawing.Size(252, 30);
            this.uxRedo.Text = "Redo";
            this.uxRedo.Click += new System.EventHandler(this.uxRedo_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 522);
            this.Controls.Add(this.uxEditBuffer);
            this.Controls.Add(this.uxMenuBar);
            this.MainMenuStrip = this.uxMenuBar;
            this.Name = "UserInterface";
            this.Text = "Text Editor";
            this.uxMenuBar.ResumeLayout(false);
            this.uxMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuBar;
        private System.Windows.Forms.ToolStripMenuItem uxFile;
        private System.Windows.Forms.ToolStripMenuItem uxOpen;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAs;
        private System.Windows.Forms.TextBox uxEditBuffer;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
        private System.Windows.Forms.ToolStripMenuItem uxEncrypt;
        private System.Windows.Forms.ToolStripMenuItem uxEncryptWithString;
        private System.Windows.Forms.ToolStripMenuItem uxEncryptWithStringBuilder;
        private System.Windows.Forms.ToolStripMenuItem uxEdit;
        private System.Windows.Forms.ToolStripMenuItem uxUndo;
        private System.Windows.Forms.ToolStripMenuItem uxRedo;
    }
}

