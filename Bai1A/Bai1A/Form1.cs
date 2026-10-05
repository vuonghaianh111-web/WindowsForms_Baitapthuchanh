namespace Bai1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double r;

            if (txta.Text == "") MessageBox.Show("Hãy nhập dữ liệu");
            else
                if (double.TryParse(txta.Text, out double a))
                {
                    r = double.Parse(txta.Text);
                    if (r < 0)
                    {
                        MessageBox.Show("Bán kính không được âm, vui lòng nhập lại!");
                        return;
                    }
                    txtb.Text = (r * 2 * 3.14) + "";
                    txtc.Text = (r * r * 3.14) + "";
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ, Vui lòng nhập lại!");
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu không?",
                "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txta.Text = "";
                txtb.Text = "";
                txtc.Text = "";
                MessageBox.Show("Đã xóa thành công!");
                txta.Focus();
            }
            else
            {
                MessageBox.Show("Đã hủy thành công");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?",
                "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txta.Focus();
        }

        private void txtb_Click(object sender, EventArgs e)
        {

        }
    }
}
