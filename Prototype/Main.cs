namespace Glotok
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Main_FormClosing); // Регистрация события-костыля
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) // Костыль из-за переключения форм
        {
            Environment.Exit(0); // Закрытие приложения с кодом 0 (Код влияет только в VS Studio)
        }

        private void Fixes_Click(object sender, EventArgs e)
        {
            Fixes form2 = new Fixes();
            this.Hide();
            form2.StartPosition = FormStartPosition.CenterParent;  // 13 - 17 строчку, переключение форм
            form2.ShowDialog();
            this.Close();
        }
    }
}
