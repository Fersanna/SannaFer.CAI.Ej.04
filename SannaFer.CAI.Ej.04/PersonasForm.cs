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
            MessageBox.Show("Formulario cargado");
            model = new PersonasModel();

            if (PersonasListView != null)
            {
                foreach (var persona in model.Personas)
                {
                    //agregar persona a la lista
                    var item = new ListViewItem();

                    item.Text = persona.Documento.ToString();
                    item.SubItems.Add(persona.Apellido.ToString());
                    item.SubItems.Add(persona.Nombre.ToString());
                    item.SubItems.Add(persona.Telefono.ToString());
                    item.Tag = persona;

                    PersonasListView.Items.Add(item);
                }
            }


            else

                MessageBox.Show("PersonasListView es null. Asegúrate de que está inicializado correctamente.");


        }

        private void PersonaBox_Enter(object sender, EventArgs e)
        {

        }



        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (PersonasListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un item de la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Persona personaSeleccionada = (Persona)PersonasListView.SelectedItems[0].Tag;

            DialogResult result = MessageBox.Show($"Esta seguro que desea eliminar a {personaSeleccionada.Apellido} de la lista?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (DialogResult.OK == result)
            {
                var error = model.Borrar(personaSeleccionada);



                if (error != "Ok")
                {
                    MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PersonasListView.Items.Remove(PersonasListView.SelectedItems[0]);
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (PersonasListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un item de la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Persona personaSeleccionada = (Persona)PersonasListView.SelectedItems[0].Tag;

            DocumentoTextBox.Text =personaSeleccionada.Documento.ToString();
            ApellidoTextBox.Text = personaSeleccionada.Apellido.ToString();
            NombreTextBox.Text = personaSeleccionada.Nombre.ToString();
            TelefonoTextBox.Text = personaSeleccionada.Telefono.ToString();

            PersonasEditBox.Enabled = false;
            PersonaBox.Enabled = true;


        }
    }
}

