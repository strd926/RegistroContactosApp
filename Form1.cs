namespace RegistroContactosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumero.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text))

            labelEstado.Text = "Por favor, complete todos los campos";

            else
            {
                listBox.Items.Add("Nombre: " + textBoxName.Text);
                listBox.Items.Add("Email: " + textBoxNumero.Text);
                listBox.Items.Add("Numero: " + textBoxEmail.Text);
                

                //string datos = $"Nombre: {textBoxName.Text}, Numero: {textBoxNumero.Text}, Email: {textBoxEmail.Text}" ;

                //listBox.Items.Add(datos);

                labelEstado.Text = "El formulario fue enviado correctamente!";
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxNumero.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            listBox.Items.Clear();

            labelEstado.Text = string.Empty;

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
