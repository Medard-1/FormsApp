namespace FormsApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            new MushroomForm().Show();
            this.Hide();
        }
    }
}
