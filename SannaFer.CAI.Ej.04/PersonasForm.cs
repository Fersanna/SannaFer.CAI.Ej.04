namespace SannaFer.CAI.Ej._04
{
    public partial class PersonasForm : Form
    {
        PersonasModel model;

        public PersonasForm()
        {
            InitializeComponent();
        }

        private void PersonasForm_Load(object sender, EventArgs e)
        {
            model = new PersonasModel();
        }
    }
}