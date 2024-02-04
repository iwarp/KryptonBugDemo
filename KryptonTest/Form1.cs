namespace KryptonTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e) {
            foreach (var item in this.kryptonCheckedListBox1.CheckedIndices) {
                MessageBox.Show(item.ToString());
            }
        }
    }
}
