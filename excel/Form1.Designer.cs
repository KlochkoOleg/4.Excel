namespace excel
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
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Super = new System.Windows.Forms.DataGridView();
            this.NumParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Super)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "Импорт данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1, 104);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(144, 270);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вычисление";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 307);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 67);
            this.textBox1.TabIndex = 3;
            // 
            // Super
            // 
            this.Super.AllowUserToAddRows = false;
            this.Super.AllowUserToDeleteRows = false;
            this.Super.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Super.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumParam,
            this.NumResult});
            this.Super.Location = new System.Drawing.Point(151, 1);
            this.Super.Name = "Super";
            this.Super.Size = new System.Drawing.Size(240, 300);
            this.Super.TabIndex = 4;
            // 
            // NumParam
            // 
            this.NumParam.HeaderText = "Variable";
            this.NumParam.Name = "NumParam";
            this.NumParam.ReadOnly = true;
            // 
            // NumResult
            // 
            this.NumResult.HeaderText = "Result";
            this.NumResult.Name = "NumResult";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 377);
            this.Controls.Add(this.Super);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Excel";
            ((System.ComponentModel.ISupportInitialize)(this.Super)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView Super;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumResult;
    }
}

