using OpenTK.Windowing.Desktop;

namespace SorcerousLands
{
    public partial class SorcerousLands : Form
    {
        public SorcerousLands()
        {
            InitializeComponent();
        }

        private void ������_Click(object sender, EventArgs e)
        {
            ������.Visible = false;
            ����������.Visible = false;
            ���������.Visible = false;
            �����.Visible = false;
            �������_���_����.Visible = true;
            ����_��������_����.Visible = true;
            ������_������_����.Visible = true;
        }
        private void ����������_Click(object sender, EventArgs e)
        {

        }
        private void ���������_Click(object sender, EventArgs e)
        {

        }

        private void �����_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ������_������_����_Click(object sender, EventArgs e)
        {
            if (����_��������_����.Text == "")
            {
                MessageBox.Show("������� �������� ����.", "������.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}