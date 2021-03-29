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
            // ListItem item = new ListItem(txtSite.Text, dlistSite.Items.Count.ToString());
            ListItem item = new ListItem(txtSite.Text, txtAddress.Text);
            dlistSite.Items.Add(item);
            listAddress.Items.Add(item);
            txtAddress.Text = "";
            txtSite.Text = ""; //após adicionar, ele reseta o campo para vazio

            /*
            // Add o site na lista de sites
            item = new ListItem(txtAddress.Text, listAddress.Items.Count.ToString());
            listAddress.Items.Add(item);
            txtAddress.Text = "";
            */
        }

        protected void btnSelect_Click(object sender, EventArgs e) {

            dlistSite.Items.Clear();
            /*
            ListItem li;
            for (int i = 0; i < listAddress.Items.Count; i++) {
                li = listAddress.Items[i];
                if (li.Selected) {
                    li.Selected = false;
                    dlistSite.Items.Add(li);
                }
            }
            */

            //Usndo ForEach
            foreach (ListItem item in listAddress.Items) {
                if (item.Selected) {
                    item.Selected = false;
                    dlistSite.Items.Add(item);
                }

            }

            
            // SelectedItem  devolve o item selecionado
            // Aqui iremos pegar o item selecionado tanto no dropdown como no listbox
            /*ListItem item = dlistSite.SelectedItem;
            txtSite.Text = item.Text;
            item = listAddress.SelectedItem;
            txtAddress.Text = item.Text;
            */

        }
    }
}