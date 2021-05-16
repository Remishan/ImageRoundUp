using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRoundUp
{
   
    public partial class Form1 : Form
    {
        int leftCount = 0,rigtCount=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (leftCount == 0)
            {
                pbxStrawberry.Image = ImageRoundUp.Properties.Resources.download;
                pbxBanana.Image = ImageRoundUp.Properties.Resources.images;
                pbxOrange.Image = ImageRoundUp.Properties.Resources.download__3_;
                pbxMango.Image = ImageRoundUp.Properties.Resources.download__2_;
                leftCount++; 
            }
            else if (leftCount == 1)
            {

                pbxStrawberry.Image = ImageRoundUp.Properties.Resources.download__2_;
                pbxBanana.Image = ImageRoundUp.Properties.Resources.download;
                pbxOrange.Image = ImageRoundUp.Properties.Resources.images;
                pbxMango.Image = ImageRoundUp.Properties.Resources.download__3_;
                leftCount++;
            }
            else if (leftCount == 2)
            {

                pbxStrawberry.Image = ImageRoundUp.Properties.Resources.download__3_;
                pbxBanana.Image = ImageRoundUp.Properties.Resources.download__2_;
                pbxOrange.Image = ImageRoundUp.Properties.Resources.download;
                pbxMango.Image = ImageRoundUp.Properties.Resources.images;
                leftCount++;
            }
            else if (leftCount == 3)
            {

                pbxStrawberry.Image = ImageRoundUp.Properties.Resources.images;
                pbxBanana.Image = ImageRoundUp.Properties.Resources.download__3_;
                pbxOrange.Image = ImageRoundUp.Properties.Resources.download__2_;
                pbxMango.Image = ImageRoundUp.Properties.Resources.download;
                leftCount = 0;
            }
        }

        private void tmrStrwberry_Tick(object sender, EventArgs e)
        {
          //  tmrStrwberry.Start();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (rigtCount == 0)
            {
                pbxStrawberry.Image = ImageRoundUp.Properties.Resources.download__3_;
                pbxBanana.Image = ImageRoundUp.Properties.Resources.download__2_;
                pbxOrange.Image = ImageRoundUp.Properties.Resources.download;
                pbxMango.Image = ImageRoundUp.Properties.Resources.images;
                rigtCount++;
            }
            else if (rigtCount == 1)
            {

                pbxStrawberry.Image = ImageRoundUp.Properties.Resources.download__2_;
                pbxBanana.Image = ImageRoundUp.Properties.Resources.download;
                pbxOrange.Image = ImageRoundUp.Properties.Resources.images;
                pbxMango.Image = ImageRoundUp.Properties.Resources.download__3_;
                rigtCount++;
            }
            else if (rigtCount == 2)
            {

                pbxStrawberry.Image = ImageRoundUp.Properties.Resources.download;
                pbxBanana.Image = ImageRoundUp.Properties.Resources.images;
                pbxOrange.Image = ImageRoundUp.Properties.Resources.download__3_;
                pbxMango.Image = ImageRoundUp.Properties.Resources.download__2_;
                rigtCount++;
            }
            else if (rigtCount == 3)
            {

                pbxStrawberry.Image = ImageRoundUp.Properties.Resources.images;
                pbxBanana.Image = ImageRoundUp.Properties.Resources.download__3_;
                pbxOrange.Image = ImageRoundUp.Properties.Resources.download__2_;
                pbxMango.Image = ImageRoundUp.Properties.Resources.download;
                rigtCount = 0;
            }
        }
    }
}
