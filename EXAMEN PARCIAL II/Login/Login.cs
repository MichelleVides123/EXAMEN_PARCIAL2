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
            Menu formulario = new Menu();
            Hide();
            formulario.Show();

            /*
            if (codigousuariotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(codigousuariotextBox, "Ingrese un codigo de usuario");
                codigousuariotextBox.Focus();
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
            bool valido = await userDatos.LoginAsync(codigousuariotextBox.Text, clavetextBox.Text);

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
            */

        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}