using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicios_1 {
    public partial class Tabuada : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            // a propriedade IsPostBack serve para indicar que já estive ou não nessa página, então ele executa ou não a condição abaixo. Em outras palavras, se a requisição já foi feita ou não, se for a primeira vez executa, se não, não
            if (!IsPostBack) {

                //  Preenche o droplist com números de 2 à 10
                for (int i = 2; i < 11; i++) {
                    dpNum.Items.Add(i.ToString());

                }
            }

        }

        protected void lbxDados_SelectedIndexChanged(object sender, EventArgs e) {


        }


        protected void btnExecutar_Click(object sender, EventArgs e) {

            //lbxDados.Items.Clear();
            ListItem li = dpNum.SelectedItem;
            int num = Convert.ToInt32(li.Value);
          //  int total = 0;
            //for (int i = 0; i < 11; i++) {
            //    total = i * num;
            //    lbxDados.Items.Add(i.ToString() + " x " + num.ToString() + " = " + total.ToString());
            //}

            Table tabela = new Table();
            int total = 0;
            for (int i = 0; i <= 10; i++) {
                TableRow linha = new TableRow();
                // 1 Coluna
                TableCell coluna = new TableCell();
                coluna.Text = i.ToString() + " x " + num.ToString() + " = ";
                linha.Cells.Add(coluna);
                // 2 Coluna
                coluna = new TableCell();
                total = i * num;
                coluna.Text = total.ToString();
                linha.Cells.Add(coluna);
                tabela.Rows.Add(linha);
            }
            PlaceHolder1.Controls.Add(tabela);

    }
    }
}