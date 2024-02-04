namespace KryptonTest {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            kryptonCheckedListBox1 = new Krypton.Toolkit.KryptonCheckedListBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            Column2 = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // kryptonCheckedListBox1
            // 
            kryptonCheckedListBox1.Items.AddRange(new object[] { "Test1", "Test2", "Test3", "Test4", "Test5" });
            kryptonCheckedListBox1.Location = new Point(40, 117);
            kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            kryptonCheckedListBox1.Size = new Size(240, 192);
            kryptonCheckedListBox1.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(40, 325);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(180, 50);
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.Text = "Click to Crash";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.CausesValidation = false;
            kryptonDataGridView1.ColumnHeadersHeight = 92;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            kryptonDataGridView1.Location = new Point(773, 117);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowHeadersWidth = 82;
            kryptonDataGridView1.Size = new Size(1040, 648);
            kryptonDataGridView1.TabIndex = 2;
            // 
            // Column2
            // 
            Column2.HeaderText = "Krypton Button";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Text = "Buton 1";
            Column2.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(792, 45);
            label1.Name = "label1";
            label1.Size = new Size(363, 32);
            label1.TabIndex = 3;
            label1.Text = "Issue #1280 - Mouseover button";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 407);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 4;
            label2.Text = "Issue #1314";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 818);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonCheckedListBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn Column2;
        private Label label1;
        private Label label2;
    }
}
