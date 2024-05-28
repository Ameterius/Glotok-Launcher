namespace Glotok
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Main_FormClosing); // ����������� �������-�������
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) // ������� ��-�� ������������ ����
        {
            Environment.Exit(0); // �������� ���������� � ����� 0 (��� ������ ������ � VS Studio)
        }

        private void Fixes_Click(object sender, EventArgs e)
        {
            Fixes form2 = new Fixes();
            this.Hide();
            form2.StartPosition = FormStartPosition.CenterParent;  // 13 - 17 �������, ������������ ����
            form2.ShowDialog();
            this.Close();
        }
    }
}
