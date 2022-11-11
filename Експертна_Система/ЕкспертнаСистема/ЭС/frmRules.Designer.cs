namespace ЭС
{
    partial class frmRules
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRules));
            this.btnAddRule = new System.Windows.Forms.Button();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnAddReason = new System.Windows.Forms.Button();
            this.btnEditReason = new System.Windows.Forms.Button();
            this.btnDeleteReason = new System.Windows.Forms.Button();
            this.btnModifyResult = new System.Windows.Forms.Button();
            this.btnDeleteResult = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstReasons = new ЭС.DragListBox();
            this.lstResult = new ЭС.DragListBox();
            this.lstRules = new ЭС.DragListBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRule
            // 
            this.btnAddRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRule.Location = new System.Drawing.Point(636, 67);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(234, 44);
            this.btnAddRule.TabIndex = 3;
            this.btnAddRule.Text = "Додати";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnEditRule
            // 
            this.btnEditRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditRule.Enabled = false;
            this.btnEditRule.Location = new System.Drawing.Point(636, 119);
            this.btnEditRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(234, 44);
            this.btnEditRule.TabIndex = 4;
            this.btnEditRule.Text = "Змінити";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRule.Enabled = false;
            this.btnDeleteRule.Location = new System.Drawing.Point(636, 171);
            this.btnDeleteRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(234, 44);
            this.btnDeleteRule.TabIndex = 5;
            this.btnDeleteRule.Text = "Видалити";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnAddReason
            // 
            this.btnAddReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReason.Enabled = false;
            this.btnAddReason.Location = new System.Drawing.Point(247, 32);
            this.btnAddReason.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReason.Name = "btnAddReason";
            this.btnAddReason.Size = new System.Drawing.Size(100, 28);
            this.btnAddReason.TabIndex = 6;
            this.btnAddReason.Text = "Додати";
            this.btnAddReason.UseVisualStyleBackColor = true;
            this.btnAddReason.Click += new System.EventHandler(this.btnAddReason_Click);
            // 
            // btnEditReason
            // 
            this.btnEditReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditReason.Enabled = false;
            this.btnEditReason.Location = new System.Drawing.Point(247, 68);
            this.btnEditReason.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditReason.Name = "btnEditReason";
            this.btnEditReason.Size = new System.Drawing.Size(100, 28);
            this.btnEditReason.TabIndex = 7;
            this.btnEditReason.Text = "Змінити";
            this.btnEditReason.UseVisualStyleBackColor = true;
            this.btnEditReason.Click += new System.EventHandler(this.btnEditReason_Click);
            // 
            // btnDeleteReason
            // 
            this.btnDeleteReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteReason.Enabled = false;
            this.btnDeleteReason.Location = new System.Drawing.Point(247, 103);
            this.btnDeleteReason.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteReason.Name = "btnDeleteReason";
            this.btnDeleteReason.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteReason.TabIndex = 8;
            this.btnDeleteReason.Text = "Видалити";
            this.btnDeleteReason.UseVisualStyleBackColor = true;
            this.btnDeleteReason.Click += new System.EventHandler(this.btnDeleteReason_Click);
            // 
            // btnModifyResult
            // 
            this.btnModifyResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyResult.Enabled = false;
            this.btnModifyResult.Location = new System.Drawing.Point(245, 32);
            this.btnModifyResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyResult.Name = "btnModifyResult";
            this.btnModifyResult.Size = new System.Drawing.Size(100, 42);
            this.btnModifyResult.TabIndex = 9;
            this.btnModifyResult.Text = "Додати";
            this.btnModifyResult.UseVisualStyleBackColor = true;
            this.btnModifyResult.Click += new System.EventHandler(this.btnModifyResult_Click);
            // 
            // btnDeleteResult
            // 
            this.btnDeleteResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteResult.Enabled = false;
            this.btnDeleteResult.Location = new System.Drawing.Point(245, 103);
            this.btnDeleteResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteResult.Name = "btnDeleteResult";
            this.btnDeleteResult.Size = new System.Drawing.Size(100, 42);
            this.btnDeleteResult.TabIndex = 10;
            this.btnDeleteResult.Text = "Видалити";
            this.btnDeleteResult.UseVisualStyleBackColor = true;
            this.btnDeleteResult.Click += new System.EventHandler(this.btnDeleteResult_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(263, 437);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(240, 28);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Готово";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Якщо";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "ТО";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 267);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnEditReason);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddReason);
            this.splitContainer1.Panel1.Controls.Add(this.lstReasons);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteReason);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteResult);
            this.splitContainer1.Panel2.Controls.Add(this.lstResult);
            this.splitContainer1.Panel2.Controls.Add(this.btnModifyResult);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(720, 162);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 20;
            // 
            // lstReasons
            // 
            this.lstReasons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstReasons.FormattingEnabled = true;
            this.lstReasons.HorizontalScrollbar = true;
            this.lstReasons.ItemHeight = 16;
            this.lstReasons.Location = new System.Drawing.Point(12, 32);
            this.lstReasons.Margin = new System.Windows.Forms.Padding(4);
            this.lstReasons.Name = "lstReasons";
            this.lstReasons.Size = new System.Drawing.Size(225, 116);
            this.lstReasons.TabIndex = 18;
            this.lstReasons.AfterDrop += new ЭС.AfterDropEventHandler(this.lstReasons_AfterDrop);
            // 
            // lstResult
            // 
            this.lstResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.HorizontalScrollbar = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Location = new System.Drawing.Point(12, 32);
            this.lstResult.Margin = new System.Windows.Forms.Padding(4);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(225, 116);
            this.lstResult.TabIndex = 19;
            // 
            // lstRules
            // 
            this.lstRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRules.FormattingEnabled = true;
            this.lstRules.HorizontalScrollbar = true;
            this.lstRules.ItemHeight = 16;
            this.lstRules.Location = new System.Drawing.Point(16, 15);
            this.lstRules.Margin = new System.Windows.Forms.Padding(4);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(611, 244);
            this.lstRules.TabIndex = 17;
            this.lstRules.AfterDrop += new ЭС.AfterDropEventHandler(this.lstRules_AfterDrop);
            this.lstRules.SelectedIndexChanged += new System.EventHandler(this.lstRules_SelectedIndexChanged);
            // 
            // frmRules
            // 
            this.AcceptButton = this.btnOk;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 480);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lstRules);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDeleteRule);
            this.Controls.Add(this.btnEditRule);
            this.Controls.Add(this.btnAddRule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(853, 516);
            this.Name = "frmRules";
            this.Text = "Правила";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnAddReason;
        private System.Windows.Forms.Button btnEditReason;
        private System.Windows.Forms.Button btnDeleteReason;
        private System.Windows.Forms.Button btnModifyResult;
        private System.Windows.Forms.Button btnDeleteResult;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DragListBox lstRules;
        private DragListBox lstReasons;
        private DragListBox lstResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}