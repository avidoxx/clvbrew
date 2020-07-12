namespace clvbrew
{
    partial class clvbrew
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clvbrew));
            this.encStrings = new System.Windows.Forms.CheckBox();
            this.encImpStrings = new System.Windows.Forms.CheckBox();
            this.obfCtrlFlow = new System.Windows.Forms.CheckBox();
            this.compBytecode = new System.Windows.Forms.CheckBox();
            this.prsvLnInfo = new System.Windows.Forms.CheckBox();
            this.obfuscate = new System.Windows.Forms.Button();
            this.apikey = new System.Windows.Forms.TextBox();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // encStrings
            // 
            this.encStrings.AutoSize = true;
            this.encStrings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.encStrings.Location = new System.Drawing.Point(557, 12);
            this.encStrings.Name = "encStrings";
            this.encStrings.Size = new System.Drawing.Size(111, 17);
            this.encStrings.TabIndex = 1;
            this.encStrings.Text = "Encrypt All Strings";
            this.encStrings.UseVisualStyleBackColor = true;
            // 
            // encImpStrings
            // 
            this.encImpStrings.AutoSize = true;
            this.encImpStrings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.encImpStrings.Location = new System.Drawing.Point(557, 35);
            this.encImpStrings.Name = "encImpStrings";
            this.encImpStrings.Size = new System.Drawing.Size(144, 17);
            this.encImpStrings.TabIndex = 2;
            this.encImpStrings.Text = "Encrypt Important Strings";
            this.encImpStrings.UseVisualStyleBackColor = true;
            // 
            // obfCtrlFlow
            // 
            this.obfCtrlFlow.AutoSize = true;
            this.obfCtrlFlow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.obfCtrlFlow.Location = new System.Drawing.Point(557, 58);
            this.obfCtrlFlow.Name = "obfCtrlFlow";
            this.obfCtrlFlow.Size = new System.Drawing.Size(136, 17);
            this.obfCtrlFlow.TabIndex = 3;
            this.obfCtrlFlow.Text = "Obfuscate Control Flow";
            this.obfCtrlFlow.UseVisualStyleBackColor = true;
            // 
            // compBytecode
            // 
            this.compBytecode.AutoSize = true;
            this.compBytecode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.compBytecode.Location = new System.Drawing.Point(557, 104);
            this.compBytecode.Name = "compBytecode";
            this.compBytecode.Size = new System.Drawing.Size(120, 17);
            this.compBytecode.TabIndex = 5;
            this.compBytecode.Text = "Compress Bytecode";
            this.compBytecode.UseVisualStyleBackColor = true;
            // 
            // prsvLnInfo
            // 
            this.prsvLnInfo.AutoSize = true;
            this.prsvLnInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.prsvLnInfo.Location = new System.Drawing.Point(557, 81);
            this.prsvLnInfo.Name = "prsvLnInfo";
            this.prsvLnInfo.Size = new System.Drawing.Size(112, 17);
            this.prsvLnInfo.TabIndex = 4;
            this.prsvLnInfo.Text = "Preserve Line Info";
            this.prsvLnInfo.UseVisualStyleBackColor = true;
            // 
            // obfuscate
            // 
            this.obfuscate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.obfuscate.FlatAppearance.BorderSize = 0;
            this.obfuscate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.obfuscate.ForeColor = System.Drawing.Color.White;
            this.obfuscate.Location = new System.Drawing.Point(12, 267);
            this.obfuscate.Name = "obfuscate";
            this.obfuscate.Size = new System.Drawing.Size(97, 35);
            this.obfuscate.TabIndex = 6;
            this.obfuscate.Text = "Obfuscate";
            this.obfuscate.UseVisualStyleBackColor = false;
            this.obfuscate.Click += new System.EventHandler(this.obfuscate_Click);
            // 
            // apikey
            // 
            this.apikey.BackColor = System.Drawing.Color.White;
            this.apikey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apikey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apikey.Location = new System.Drawing.Point(115, 275);
            this.apikey.Name = "apikey";
            this.apikey.Size = new System.Drawing.Size(302, 20);
            this.apikey.TabIndex = 7;
            this.apikey.UseSystemPasswordChar = true;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBrackets = true;
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentChars = false;
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(187, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CommentPrefix = "--";
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(13, 12);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(538, 249);
            this.fastColoredTextBox1.TabIndex = 8;
            this.fastColoredTextBox1.Text = "print(\"Hello World\")";
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.fastColoredTextBox1_DragDrop);
            this.fastColoredTextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.fastColoredTextBox1_DragEnter);
            // 
            // clvbrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 313);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.apikey);
            this.Controls.Add(this.obfuscate);
            this.Controls.Add(this.compBytecode);
            this.Controls.Add(this.prsvLnInfo);
            this.Controls.Add(this.obfCtrlFlow);
            this.Controls.Add(this.encImpStrings);
            this.Controls.Add(this.encStrings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "clvbrew";
            this.Text = "clvbrew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.clvbrew_FormClosing);
            this.Load += new System.EventHandler(this.clvbrew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox encStrings;
        private System.Windows.Forms.CheckBox encImpStrings;
        private System.Windows.Forms.CheckBox obfCtrlFlow;
        private System.Windows.Forms.CheckBox compBytecode;
        private System.Windows.Forms.CheckBox prsvLnInfo;
        private System.Windows.Forms.Button obfuscate;
        private System.Windows.Forms.TextBox apikey;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    }
}

