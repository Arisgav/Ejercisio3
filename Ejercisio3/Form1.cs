using System;
using System.Windows.Forms;

namespace Ejercisio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botón Buscar
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string parrafo = TboxParrafo.Text.ToLower();
            string palabra = TboxPalabra.Text.ToLower();

            LboxResultados.Items.Clear(); // Limpiar resultados previos
            int contador = 0;

            for (int i = 0; i <= parrafo.Length - palabra.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (parrafo[i + j] != palabra[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    contador++;
                    LboxResultados.Items.Add($"Ocurrencia #{contador} en índice {i}");
                }
            }

            if (contador == 0)
                LboxResultados.Items.Add("No se encontraron coincidencias.");
            else
                LboxResultados.Items.Add($"La palabra '{palabra}' aparece {contador} veces en total.");
        }

        // Eventos vacíos que puedes mantener
        private void LboxResultados_SelectedIndexChanged(object sender, EventArgs e) { }

        private void TboxParrafo_TextChanged(object sender, EventArgs e) { }

        private void TboxPalabra_TextChanged(object sender, EventArgs e) { }
    }
}
