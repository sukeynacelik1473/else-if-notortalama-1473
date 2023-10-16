using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_not_ortalama_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDurumgoster_Click(object sender, EventArgs e)
        {
            double notortalama, devamsılıksayi;
            int zayıfsayı;

            notortalama = Convert.ToDouble(txtOrtalama.Text);
            devamsılıksayi= Convert.ToDouble(txtDevamsızlık.Text);
            zayıfsayı = Convert.ToInt32(txtZayıf.Text);

            if (notortalama >= 70 && notortalama < 85 && devamsılıksayi<5 && zayıfsayı == 0)
            {
                lblDurum.Text = "TEŞEKÜR BELGESI ALAÇAKSIN";
            }
            else if(notortalama >= 85 && notortalama <=100 && devamsılıksayi <5 && zayıfsayı ==0)
            {
                lblDurum.Text = "TAKTİR BELGESİ ALAÇAKSIN";
            }
            else if(devamsılıksayi> 5)
            {
                lblDurum.Text = "DEVAMSILIĞINIZ FAZLA";
            }
            else if(zayıfsayı != 0)
            {
                lblDurum.Text = "ZAYIF VAR";
            }
            else
            {
                lblDurum.Text = "ÜZGÜNUM BELGE YOK";
            }

        }
    }
}
