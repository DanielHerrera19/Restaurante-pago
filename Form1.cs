namespace Restaurante_pago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double montoconsumo = Convert.ToDouble(montoconsumotxt.Text);
            double descuento;
            double impuesto;
            double totaldescuento;
            double totalpagar;

            if (montoconsumo <= 100)
            {
                descuento = montoconsumo * 0.10;
            }
            else
            {
                descuento = montoconsumo * 0.20;
            }

            totaldescuento = montoconsumo - descuento;
            impuesto = totaldescuento * 0.18;
            totalpagar = totaldescuento + impuesto;

            lbldescuento.Text = $"Descuento: S/ {descuento}";
            lblimpuesto.Text = $"Impuesto: S/ {impuesto}";
            lbltotaldescuento.Text = $"Pago con descuento: S/ {totaldescuento}";
            lbltotalpagar.Text = $"Total a pagar: S/ {totalpagar}";
        }
    }
}