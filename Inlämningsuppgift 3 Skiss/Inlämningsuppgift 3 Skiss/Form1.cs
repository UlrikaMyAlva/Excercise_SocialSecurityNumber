namespace Inlämningsuppgift_3_Skiss
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
        
            /* PSEUDOKOD
             
           Om du väljer registera i menyn och klickar på knappen registera, hämta in förnamn, efternamn och personnummer.
           Registrera i en klass.
           Metoden Algoritm21 kontrollerar om personnumret är giltigt.
           Metoden Kön räknar ut vilken kön personen har.
           Resultatet skrivs ut.
           Om du väljer avsluta i menyn och klickar på knappen avsluta, avslutas programmet. */

            InitializeComponent();

            // Båda knapparna är inaktiverade när programmet startar. 
            if (lbxVälj.SelectedIndex == -1)
            {
                btnOK.Enabled = false;
                btnAvsluta.Enabled = false;
            }

        }


        private void lbxVälj_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Om du väljer registera i menyn kan du välja registera-knappen. Om du väljer avsluta i menyn kan du välja avsluta-knappen. 
            if (lbxVälj.SelectedIndex == 0)
            {
                btnOK.Enabled = true;
                btnAvsluta.Enabled = false;
            }
            if (lbxVälj.SelectedIndex == 1)
            {
                btnOK.Enabled = false;
                btnAvsluta.Enabled = true;

            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (lbxVälj.SelectedIndex == 0)
            {
                // Objekt i klass skapas
                List<Personklass> personklass = new List<Personklass>();

                // Ny personklass läggs till
                personklass.Add(new Personklass { förnamn = tbxFörnamn.Text, efternamn = tbxEfternamn.Text, personnummer = tbxPersonnr.Text });

                // Om personnumret är för kort eller för långt, ombeds personen skriva in det igen
                if (personklass[0].personnummer.Length < 10 || personklass[0].personnummer.Length >= 11)
                {
                    tbxResultat.Text = "Personnummer felaktigt, försök igen! (10 siffror, inget bindestreck).";
                }

                // Om personnumret är korrekt längd går det genom metoderna alogritm21 samt kön. Resultatet skrivs sedan ut. 
                else
                {
                    string algoritm21 = personklass[0].Algoritm21();
                    string kön = personklass[0].Kön();

                    tbxResultat.Text = "Förnamn: " + tbxFörnamn.Text + "\r\n" + "Efternamn: " + tbxEfternamn.Text + "\r\n" + "Personnummer: " + tbxPersonnr.Text + "\r\n" + algoritm21 + "\r\n" + kön;
                }

            }
         
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {

            //Programmet avslutas. 
            if (lbxVälj.SelectedIndex == 1)
            {
                Close();
            }

        }

        private void tbxFörnamn_TextChanged(object sender, EventArgs e)
        {
            tbxResultat.Text = "";
        }

        private void tbxEfternamn_TextChanged(object sender, EventArgs e)
        {
            tbxResultat.Text = "";
        }

        private void tbxPersonnr_TextChanged(object sender, EventArgs e)
        {
            tbxResultat.Text = "";
        }
    }
}