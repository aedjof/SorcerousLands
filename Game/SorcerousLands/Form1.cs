using OpenTK.Windowing.Desktop;

namespace SorcerousLands
{
    public partial class SorcerousLands : Form
    {
        public SorcerousLands()
        {
            InitializeComponent();
        }

        private void начать_Click(object sender, EventArgs e)
        {
            начать.Visible = false;
            продолжить.Visible = false;
            настройки.Visible = false;
            выход.Visible = false;
            введите_имя_игры.Visible = true;
            ввод_названия_игры.Visible = true;
            кнопка_начать_игру.Visible = true;
        }
        private void продолжить_Click(object sender, EventArgs e)
        {

        }
        private void настройки_Click(object sender, EventArgs e)
        {

        }

        private void выход_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void кнопка_начать_игру_Click(object sender, EventArgs e)
        {
            if (ввод_названия_игры.Text == "")
            {
                MessageBox.Show("Введите название игры.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}