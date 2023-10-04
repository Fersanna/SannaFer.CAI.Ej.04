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

            DocumentoTextBox.Text = personaSeleccionada.Documento.ToString();
            ApellidoTextBox.Text = personaSeleccionada.Apellido.ToString();
            NombreTextBox.Text = personaSeleccionada.Nombre.ToString();
            TelefonoTextBox.Text = personaSeleccionada.Telefono.ToString();

            PersonasEditBox.Enabled = false;
            PersonaBox.Enabled = true;


        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DocumentoTextBox.Text = "";
            ApellidoTextBox.Text = "";
            NombreTextBox.Text = "";
            TelefonoTextBox.Text = "";

            PersonasEditBox.Enabled = true;
            PersonaBox.Enabled = false;
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay elementos seleccionados
            if (PersonasListView.SelectedItems.Count > 0)
            {
                // Modificar persona existente
                Persona personaSeleccionada = (Persona)PersonasListView.SelectedItems[0].Tag;

                // Obtener los nuevos valores desde los TextBox
                if (!int.TryParse(DocumentoTextBox.Text, out int documento))
                {
                    MessageBox.Show("Por favor, ingrese un número válido para el documento.");
                    return;
                }

                string apellido = ApellidoTextBox.Text;
                string nombre = NombreTextBox.Text;
                string telefono = TelefonoTextBox.Text;

                // Validar los nuevos valores si es necesario

                // Crear nueva versión de la persona
                Persona nuevaVersion = new Persona
                {
                    Documento = documento,
                    Apellido = apellido,
                    Nombre = nombre,
                    Telefono = telefono
                };

                // Modificar la persona en el modelo
                var error = model.Modificar(personaSeleccionada, nuevaVersion);

                if (error != "Ok")
                {
                    MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar la vista en el ListView
                var item = PersonasListView.SelectedItems[0];
                item.Text = nuevaVersion.Documento.ToString();
                item.SubItems[1].Text = nuevaVersion.Apellido;
                item.SubItems[2].Text = nuevaVersion.Nombre;
                item.SubItems[3].Text = nuevaVersion.Telefono;
            }
            else
            {
                // Agregar nueva persona
                if (!int.TryParse(DocumentoTextBox.Text, out int documento))
                {
                    MessageBox.Show("Por favor, ingrese un número válido para el documento.");
                    return;
                }

                string apellido = ApellidoTextBox.Text;
                string nombre = NombreTextBox.Text;
                string telefono = TelefonoTextBox.Text;

                // Validar los nuevos valores si es necesario

                // Crear nueva persona
                Persona personaAAgregar = new Persona
                {
                    Documento = documento,
                    Apellido = apellido,
                    Nombre = nombre,
                    Telefono = telefono
                };

                // Agregar la nueva persona al modelo
                var error = model.AgregarPersona(personaAAgregar);

                if (error != null)
                {
                    MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear un nuevo objeto ListViewItem y agregar los datos de la nueva persona a él
                ListViewItem newItem = new ListViewItem();
                newItem.Text = personaAAgregar.Documento.ToString();
                newItem.SubItems.Add(personaAAgregar.Apellido);
                newItem.SubItems.Add(personaAAgregar.Nombre);
                newItem.SubItems.Add(personaAAgregar.Telefono);
                newItem.Tag = personaAAgregar; // Asignar la nueva persona al Tag del ListViewItem

                // Agregar el nuevo item a la lista
                PersonasListView.Items.Add(newItem);

                // Limpiar los TextBox después de agregar la nueva persona
                DocumentoTextBox.Text = "";
                ApellidoTextBox.Text = "";
                NombreTextBox.Text = "";
                TelefonoTextBox.Text = "";
            }

            // Resto del código para habilitar/deshabilitar controles si es necesario
        }




        private void NuevaPersonaBtn_Click_1(object sender, EventArgs e)
        {
            PersonasEditBox.Enabled = false;
            PersonaBox.Enabled = true;

            PersonasListView.SelectedItems.Clear();

            // Limpia los TextBox después de agregar la nueva persona
            DocumentoTextBox.Text = "";
            ApellidoTextBox.Text = "";
            NombreTextBox.Text = "";
            TelefonoTextBox.Text = "";

          

        }
    }
}

