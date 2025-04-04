using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConversorMonedas
{
    public partial class Form1 : Form
    {
        // Diccionario con las tasas de cambio
        Dictionary<string, Dictionary<string, double>> tasasCambio = new Dictionary<string, Dictionary<string, double>>
        {
            { "USD", new Dictionary<string, double> { { "MXN", 19.38 }, { "CAD", 1.38 }, { "EUR", 0.92 }, { "JPY", 149.77 } } },
            { "MXN", new Dictionary<string, double> { { "USD", 0.05 }, { "CAD", 0.07 }, { "EUR", 0.05 }, { "JPY", 7.73 } } },
            { "CAD", new Dictionary<string, double> { { "USD", 0.72 }, { "MXN", 14.05 }, { "EUR", 0.66 }, { "JPY", 108.56 } } },
            { "EUR", new Dictionary<string, double> { { "USD", 1.09 }, { "MXN", 21.13 }, { "CAD", 1.50 }, { "JPY", 163.31 } } },
            { "JPY", new Dictionary<string, double> { { "USD", 0.0067 }, { "MXN", 0.1293 }, { "CAD", 0.0092 }, { "EUR", 0.0061 } } }
        };

        public Form1()
        {
            InitializeComponent(); // Inicializa la interfaz
            ConfigurarInterfaz();  // Configura los controles del formulario
        }

        // Método para configurar el ComboBox de monedas de origen
        private void ConfigurarInterfaz()
        {
            cmbOrigen.Items.AddRange(new string[] { "USD", "MXN", "CAD", "EUR", "JPY" });
            cmbOrigen.SelectedIndex = 0; // Selecciona USD por defecto
        }

        // Evento del botón "Seleccionar monedas destino"
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMonto.Text, out double monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abrir el formulario secundario para elegir monedas destino
            FormSeleccion formSeleccion = new FormSeleccion(cmbOrigen.SelectedItem.ToString(), tasasCambio, monto, pnlConversiones);
            formSeleccion.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConversorMonedas
{
    public partial class Form1 : Form
    {
        // Diccionario con las tasas de cambio
        Dictionary<string, Dictionary<string, double>> tasasCambio = new Dictionary<string, Dictionary<string, double>>
        {
            { "USD", new Dictionary<string, double> { { "MXN", 19.38 }, { "CAD", 1.38 }, { "EUR", 0.92 }, { "JPY", 149.77 } } },
            { "MXN", new Dictionary<string, double> { { "USD", 0.05 }, { "CAD", 0.07 }, { "EUR", 0.05 }, { "JPY", 7.73 } } },
            { "CAD", new Dictionary<string, double> { { "USD", 0.72 }, { "MXN", 14.05 }, { "EUR", 0.66 }, { "JPY", 108.56 } } },
            { "EUR", new Dictionary<string, double> { { "USD", 1.09 }, { "MXN", 21.13 }, { "CAD", 1.50 }, { "JPY", 163.31 } } },
            { "JPY", new Dictionary<string, double> { { "USD", 0.0067 }, { "MXN", 0.1293 }, { "CAD", 0.0092 }, { "EUR", 0.0061 } } }
        };

        public Form1()
        {
            InitializeComponent(); // Inicializa la interfaz
            ConfigurarInterfaz();  // Configura los controles del formulario
        }

        // Método para configurar el ComboBox de monedas de origen
        private void ConfigurarInterfaz()
        {
            cmbOrigen.Items.AddRange(new string[] { "USD", "MXN", "CAD", "EUR", "JPY" });
            cmbOrigen.SelectedIndex = 0; // Selecciona USD por defecto
        }

        // Evento del botón "Seleccionar monedas destino"
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMonto.Text, out double monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abrir el formulario secundario para elegir monedas destino
            FormSeleccion formSeleccion = new FormSeleccion(cmbOrigen.SelectedItem.ToString(), tasasCambio, monto, pnlConversiones);
            formSeleccion.ShowDialog();
        }
    }
}
