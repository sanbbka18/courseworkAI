namespace ЭС
{
    partial class frmVariables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVariables));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.btnEditVar = new System.Windows.Forms.Button();
            this.btnDelVar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAddVal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new ЭС.DragListBox();
            this.listBox1 = new ЭС.DragListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Змінні:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Домен:";
            // 
            // btnAddVar
            // 
            this.btnAddVar.Location = new System.Drawing.Point(34, 532);
            this.btnAddVar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(100, 28);
            this.btnAddVar.TabIndex = 4;
            this.btnAddVar.Text = "Додати";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // btnEditVar
            // 
            this.btnEditVar.Location = new System.Drawing.Point(142, 532);
            this.btnEditVar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditVar.Name = "btnEditVar";
            this.btnEditVar.Size = new System.Drawing.Size(100, 28);
            this.btnEditVar.TabIndex = 5;
            this.btnEditVar.Text = "Змінити";
            this.btnEditVar.UseVisualStyleBackColor = true;
            this.btnEditVar.Click += new System.EventHandler(this.btnEditVar_Click);
            // 
            // btnDelVar
            // 
            this.btnDelVar.Location = new System.Drawing.Point(250, 532);
            this.btnDelVar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelVar.Name = "btnDelVar";
            this.btnDelVar.Size = new System.Drawing.Size(100, 28);
            this.btnDelVar.TabIndex = 6;
            this.btnDelVar.Text = "Видалити";
            this.btnDelVar.UseVisualStyleBackColor = true;
            this.btnDelVar.Click += new System.EventHandler(this.btnDelVar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.Location = new System.Drawing.Point(296, 23);
            this.btnAddDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(31, 24);
            this.btnAddDomain.TabIndex = 8;
            this.btnAddDomain.Text = "+";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Можливі значення";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(25, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(264, 91);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 53);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Питання";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 25);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Результат";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Текст питання:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 340);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 116);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(486, 532);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(193, 28);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Готово";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAddVal
            // 
            this.btnAddVal.Location = new System.Drawing.Point(302, 86);
            this.btnAddVal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVal.Name = "btnAddVal";
            this.btnAddVal.Size = new System.Drawing.Size(31, 24);
            this.btnAddVal.TabIndex = 16;
            this.btnAddVal.Text = "+";
            this.btnAddVal.UseVisualStyleBackColor = true;
            this.btnAddVal.Click += new System.EventHandler(this.btnAddVal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnAddVal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btnAddDomain);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(397, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(357, 484);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(31, 86);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(263, 116);
            this.listBox2.TabIndex = 18;
            this.listBox2.AfterDrop += new ЭС.AfterDropEventHandler(this.listBox2_AfterDrop);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(35, 33);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 484);
            this.listBox1.TabIndex = 19;
            this.listBox1.AfterDrop += new ЭС.AfterDropEventHandler(this.listBox1_AfterDrop);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmVariables
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 575);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDelVar);
            this.Controls.Add(this.btnEditVar);
            this.Controls.Add(this.btnAddVar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVariables";
            this.Text = "Змінні";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddVar;
        private System.Windows.Forms.Button btnEditVar;
        private System.Windows.Forms.Button btnDelVar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAddVal;
        private System.Windows.Forms.GroupBox groupBox2;
        private DragListBox listBox2;
        private DragListBox listBox1;
    }
}