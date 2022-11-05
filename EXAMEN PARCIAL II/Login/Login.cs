using Datos;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void aceptarbutton_Click(object sender, EventArgs e)
        {
            if (usuariotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(usuariotextBox, "Ingrese un codigo de usuario");
                usuariotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (clavetextBox.Text == String.Empty)
            {
                errorProvider1.SetError(clavetextBox, "Ingrese una clave");
                clavetextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();
            bool valido = await userDatos.LoginAsync(usuariotextBox.Text, clavetextBox.Text);

            if (valido)
            {
                Menu formulario = new Menu();
                Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}