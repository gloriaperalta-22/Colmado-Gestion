namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double[] precios = { 35, 80, 65, 25, 120 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProducto.Items.Clear();
            cboProducto.Items.Add("Pan - RD$35");
            cboProducto.Items.Add("Leche - RD$80");
            cboProducto.Items.Add("Arroz - RD$65");
            cboProducto.Items.Add("Refresco - RD$25");
            cboProducto.Items.Add("Aceite - RD$120");

            cboProducto.SelectedIndex = 0;
            rbEfectivo.Checked = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("DIGITE UNA CANTIDAD VALIDA");
                return;
            }

            if (cboProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            double precio = precios[cboProducto.SelectedIndex];
            double total = precio * cantidad;

            if (rbEfectivo.Checked)
            {
                total *= 0.95; // el descuento n efectivo
            }

            lblTotal.Text = "Total: RD$" + total.ToString("N2");
        }
    }
}