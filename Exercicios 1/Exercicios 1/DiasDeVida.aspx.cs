using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicios_1 {
    public partial class DiasDeVida : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            Calendar2.SelectedDate = DateTime.Now;
        }

        protected void Button1_Click(object sender, EventArgs e) {
            int diaN = 0, anoN = 0, mesN = 0;
            int diaA = 0, anoA = 0, mesA = 0;
            diaN = Calendar1.SelectedDate.Day;
            mesN = Calendar1.SelectedDate.Month * 30;
            anoN = Calendar1.SelectedDate.Year * 365;

            diaA = Calendar2.SelectedDate.Day;
            mesA = Calendar2.SelectedDate.Month * 30;
            anoA = Calendar2.SelectedDate.Year * 365;

            int Total = (diaA + mesA + anoA) - (diaN + mesN + anoN);
            lbResultado.Text = "Dias de vida: " + Total.ToString();
        }
    }
}