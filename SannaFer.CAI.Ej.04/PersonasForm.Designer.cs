namespace SannaFer.CAI.Ej._04
{
    partial class PersonasForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PersonaBox = new GroupBox();
            CancelarBtn = new Button();
            AceptarBtn = new Button();
            ApellidoTextBox = new TextBox();
            ApellidoLabel = new Label();
            TelefonoTextBox = new TextBox();
            TelefonoLabel = new Label();
            NombreTextBox = new TextBox();
            NombreLabel = new Label();
            DocumentoTextBox = new TextBox();
            DocumentoLabel = new Label();
            PersonasEditBox = new GroupBox();
            NuevaPersonaBtn = new Button();
            ModificarBtn = new Button();
            EliminarBtn = new Button();
            PersonasListView = new ListView();
            DocumentoHeader = new ColumnHeader();
            ApellidoHeader = new ColumnHeader();
            NombreHeader = new ColumnHeader();
            TelefonoHeader = new ColumnHeader();
            PersonaBox.SuspendLayout();
            PersonasEditBox.SuspendLayout();
            SuspendLayout();
            // 
            // PersonaBox
            // 
            PersonaBox.Controls.Add(CancelarBtn);
            PersonaBox.Controls.Add(AceptarBtn);
            PersonaBox.Controls.Add(ApellidoTextBox);
            PersonaBox.Controls.Add(ApellidoLabel);
            PersonaBox.Controls.Add(TelefonoTextBox);
            PersonaBox.Controls.Add(TelefonoLabel);
            PersonaBox.Controls.Add(NombreTextBox);
            PersonaBox.Controls.Add(NombreLabel);
            PersonaBox.Controls.Add(DocumentoTextBox);
            PersonaBox.Controls.Add(DocumentoLabel);
            PersonaBox.Location = new Point(22, 232);
            PersonaBox.Name = "PersonaBox";
            PersonaBox.Size = new Size(769, 255);
            PersonaBox.TabIndex = 4;
            PersonaBox.TabStop = false;
            PersonaBox.Text = "Persona";
            PersonaBox.Enter += PersonaBox_Enter;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(383, 165);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(94, 29);
            CancelarBtn.TabIndex = 9;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // AceptarBtn
            // 
            AceptarBtn.Location = new Point(283, 165);
            AceptarBtn.Name = "AceptarBtn";
            AceptarBtn.Size = new Size(94, 29);
            AceptarBtn.TabIndex = 8;
            AceptarBtn.Text = "Aceptar";
            AceptarBtn.UseVisualStyleBackColor = true;
            AceptarBtn.Click += AceptarBtn_Click;
            // 
            // ApellidoTextBox
            // 
            ApellidoTextBox.Location = new Point(288, 51);
            ApellidoTextBox.Name = "ApellidoTextBox";
            ApellidoTextBox.Size = new Size(189, 27);
            ApellidoTextBox.TabIndex = 7;
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Location = new Point(288, 28);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(66, 20);
            ApellidoLabel.TabIndex = 6;
            ApellidoLabel.Text = "Apellido";
            // 
            // TelefonoTextBox
            // 
            TelefonoTextBox.Location = new Point(288, 114);
            TelefonoTextBox.Name = "TelefonoTextBox";
            TelefonoTextBox.Size = new Size(189, 27);
            TelefonoTextBox.TabIndex = 5;
            // 
            // TelefonoLabel
            // 
            TelefonoLabel.AutoSize = true;
            TelefonoLabel.Location = new Point(288, 91);
            TelefonoLabel.Name = "TelefonoLabel";
            TelefonoLabel.Size = new Size(87, 20);
            TelefonoLabel.TabIndex = 4;
            TelefonoLabel.Text = "Documento";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(33, 114);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(189, 27);
            NombreTextBox.TabIndex = 3;
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(33, 91);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(64, 20);
            NombreLabel.TabIndex = 2;
            NombreLabel.Text = "Nombre";
            // 
            // DocumentoTextBox
            // 
            DocumentoTextBox.Location = new Point(33, 51);
            DocumentoTextBox.Name = "DocumentoTextBox";
            DocumentoTextBox.Size = new Size(189, 27);
            DocumentoTextBox.TabIndex = 1;
            // 
            // DocumentoLabel
            // 
            DocumentoLabel.AutoSize = true;
            DocumentoLabel.Location = new Point(33, 28);
            DocumentoLabel.Name = "DocumentoLabel";
            DocumentoLabel.Size = new Size(87, 20);
            DocumentoLabel.TabIndex = 0;
            DocumentoLabel.Text = "Documento";
            // 
            // PersonasEditBox
            // 
            PersonasEditBox.Controls.Add(NuevaPersonaBtn);
            PersonasEditBox.Controls.Add(ModificarBtn);
            PersonasEditBox.Controls.Add(EliminarBtn);
            PersonasEditBox.Controls.Add(PersonasListView);
            PersonasEditBox.Location = new Point(22, 12);
            PersonasEditBox.Name = "PersonasEditBox";
            PersonasEditBox.Size = new Size(776, 214);
            PersonasEditBox.TabIndex = 5;
            PersonasEditBox.TabStop = false;
            // 
            // NuevaPersonaBtn
            // 
            NuevaPersonaBtn.Location = new Point(675, 26);
            NuevaPersonaBtn.Name = "NuevaPersonaBtn";
            NuevaPersonaBtn.Size = new Size(94, 29);
            NuevaPersonaBtn.TabIndex = 7;
            NuevaPersonaBtn.Text = "Nueva";
            NuevaPersonaBtn.UseVisualStyleBackColor = true;
            // 
            // ModificarBtn
            // 
            ModificarBtn.Location = new Point(575, 26);
            ModificarBtn.Name = "ModificarBtn";
            ModificarBtn.Size = new Size(94, 29);
            ModificarBtn.TabIndex = 6;
            ModificarBtn.Text = "Modificar";
            ModificarBtn.UseVisualStyleBackColor = true;
            ModificarBtn.Click += ModificarBtn_Click;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(475, 26);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(94, 29);
            EliminarBtn.TabIndex = 5;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            EliminarBtn.Click += EliminarBtn_Click;
            // 
            // PersonasListView
            // 
            PersonasListView.Columns.AddRange(new ColumnHeader[] { DocumentoHeader, ApellidoHeader, NombreHeader, TelefonoHeader });
            PersonasListView.FullRowSelect = true;
            PersonasListView.Location = new Point(17, 61);
            PersonasListView.MultiSelect = false;
            PersonasListView.Name = "PersonasListView";
            PersonasListView.Size = new Size(752, 147);
            PersonasListView.TabIndex = 4;
            PersonasListView.UseCompatibleStateImageBehavior = false;
            PersonasListView.View = View.Details;
            // 
            // DocumentoHeader
            // 
            DocumentoHeader.Text = "Documento";
            DocumentoHeader.Width = 120;
            // 
            // ApellidoHeader
            // 
            ApellidoHeader.Text = "Apellido";
            ApellidoHeader.Width = 120;
            // 
            // NombreHeader
            // 
            NombreHeader.Text = "Nombre";
            NombreHeader.Width = 120;
            // 
            // TelefonoHeader
            // 
            TelefonoHeader.Text = "Telefono";
            TelefonoHeader.Width = 120;
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 562);
            Controls.Add(PersonasEditBox);
            Controls.Add(PersonaBox);
            Name = "PersonasForm";
            Text = "Form1";
            Load += PersonasForm_Load;
            PersonaBox.ResumeLayout(false);
            PersonaBox.PerformLayout();
            PersonasEditBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox PersonaBox;
        private TextBox ApellidoTextBox;
        private Label ApellidoLabel;
        private TextBox TelefonoTextBox;
        private Label TelefonoLabel;
        private TextBox NombreTextBox;
        private Label NombreLabel;
        private TextBox DocumentoTextBox;
        private Label DocumentoLabel;
        private Button CancelarBtn;
        private Button AceptarBtn;
        private GroupBox PersonasEditBox;
        private Button NuevaPersonaBtn;
        private Button ModificarBtn;
        private Button EliminarBtn;
        private ListView PersonasListView;
        private ColumnHeader DocumentoHeader;
        private ColumnHeader ApellidoHeader;
        private ColumnHeader NombreHeader;
        private ColumnHeader TelefonoHeader;
    }
}