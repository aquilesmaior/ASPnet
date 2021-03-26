using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicios_1 {
    public partial class ConhecendoComponentes : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnInsert_Click(object sender, EventArgs e) {
            // Sem Construtor
            // dlistSite.Items.Add(txtSite.Text); // Aqui é uma forma direta e simples e adicionar ao droplist o que for digitado no campo site
            // Label1.Text = txtAddress.Text; // Aqui vai adicionar ao label1 o que for digitado no campo endereço


            // Usando construtor

            // Add o nome da empresa no droplist
            ListItem item = new ListItem(txtSite.Text, dlistSite.Items.Count.ToString());
            dlistSite.Items.Add(item);
            txtSite.Text = ""; //após adicionar, ele reseta o campo para vazio

            // Add o site na lista de sites
            item = new ListItem(txtAddress.Text, listAddress.Items.Count.ToString());
            listAddress.Items.Add(item);
            txtAddress.Text = "";

        }
    }
}