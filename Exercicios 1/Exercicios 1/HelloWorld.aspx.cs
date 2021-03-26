using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicios_1 {
    public partial class HelloWorld : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnExecutar_Click(object sender, EventArgs e) {
            if (txtMsg.Text == "") {
                lblMsg.Text = "<h1>Olá Mundo!!! - Aula 1</h1>";
            }
            else {
                lblMsg.Text = txtMsg.Text;
            }
        }
    }
}