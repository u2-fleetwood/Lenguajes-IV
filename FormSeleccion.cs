using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConversorMonedas
{
    public partial class FormSeleccion : Form
    {
        private string monedaOrigen;
        private Dictionary<string, double> tasas;
        private double monto;
        private Panel panelResultados;

        public FormSeleccion(string monedaOrigen, Dictionary<string, Dictionary<string, double>> tasasCambio, double monto, Panel panelResultados)
        {
            InitializeComponent();
            this.monedaOrigen = monedaOrigen;
            this.tasas = tasasCambio[monedaOrigen];
            this.monto = monto;
            this.panelResultados = panelResultados;

            foreach (var moneda in tasas.Keys)
                chkMonedasDestino.Items.Add(moneda);
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (chkMonedasDestino.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una moneda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            panelResultados.Controls.Clear();
            int yPos = 10;

            foreach (string monedaDestino in chkMonedasDestino.CheckedItems)
            {
                double montoConvertido = monto * tasas[monedaDestino];

                Label lblResultado = new Label
                {
                    Text = $"{monto} {monedaOrigen} = {montoConvertido:F2} {monedaDestino}",
                    Location = new System.Drawing.Point(10, yPos),
                    AutoSize = true
                };

                panelResultados.Controls.Add(lblResultado);
                yPos += 25;
            }

            this.Close();
        }
    }
}