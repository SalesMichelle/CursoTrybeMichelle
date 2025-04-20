using System;
using System.Windows.Forms;

namespace MeuAppGrafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Criando controles na janela:
            TextBox input = new TextBox() { Top = 20, Left = 20, Width = 100 };
            Button botao = new Button() { Top = 50, Left = 20, Text = "Mostrar Pares" };
            Label resultado = new Label() { Top = 90, Left = 20, Width = 300 };

            this.Controls.Add(input);
            this.Controls.Add(botao);
            this.Controls.Add(resultado);

            botao.Click += (sender, e) =>
            {
                int numero;
                if (int.TryParse(input.Text, out numero))
                {
                    string pares = "";
                    for (int i = 2; i <= numero; i += 2)
                    {
                        pares += i + " ";
                    }
                    resultado.Text = "Pares: " + pares;
                }
                else
                {
                    MessageBox.Show("Digite um número válido!");
                }
            };
        }
    }
}
