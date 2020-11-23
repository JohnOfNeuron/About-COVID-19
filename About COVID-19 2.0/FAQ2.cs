using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace About_COVID_19_2._0
{
    public partial class FAQ2 : UserControl
    {
        public FAQ2()
        {
            InitializeComponent();
            button10.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         label1.Text ="No.Antibiotics do not work against viruses, they only work on bacterial infections. COVID - 19 is caused by a virus, so antibiotics do \nnot work. Antibiotics should not be used as a means of prevention or treatment of COVID - 19. They should only be used as directed by a \nphysician to treat a bacterial infection.";
            button10.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          label1.Text = " While some western, traditional or home remedies may provide comfort and alleviate symptoms of COVID-19, there is no evidence \nthat current medicine can prevent or cure the disease. WHO does not recommend self-medication with any medicines, including \nantibiotics, as a prevention or cure for COVID-19. However, there are several ongoing clinical trials that include both western and \ntraditional medicines. WHO will continue to provide updated information as soon as clinical findings are available.";
            button10.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          label1.Text = " Not yet. To date, there is no vaccine and no specific antiviral medicine to prevent or treat COVID-2019. However, those affected \nshould receive care to relieve symptoms. People with serious illness should be hospitalized. Most patients recover thanks to \nsupportive care. Possible vaccines and some specific drug treatments are under investigation. They are being tested through \nclinical trials. WHO is coordinating efforts to develop vaccines and medicines to prevent and treat COVID-19. The most effective \nways to protect yourself and others against COVID-19 are to frequently clean your hands, cover your cough with the bend of elbow \nor tissue, and maintain a distance of at least 1 meter (3 feet) from people who are coughing or sneezing.";
           button10.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          label1.Text = " No. The virus that causes COVID-19 and the one that caused the outbreak of Severe Acute Respiratory Syndrome (SARS) in 2003 are \nrelated to each other genetically, but the diseases they cause are quite different. SARS was more deadly but much less infectious \nthan COVID-19. There have been no outbreaks of SARS anywhere in the world since 2003.";
          button10.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          label1.Text = " Only wear a mask if you are ill with COVID-19 symptoms (especially coughing) or looking after someone who may have COVID-19. \nDisposable face mask can only be used once. If you are not ill or looking after someone who is ill then you are wasting a mask. \nThere is a world-wide shortage of masks, so WHO urges people to use masks wisely. WHO advises rational use of medical masks to \navoid unnecessary wastage of precious resources and mis-use of masks ( see Advice on the use of masks ). The most effective ways \nto protect yourself and others against COVID-19 are to frequently clean your hands, cover your cough with the bend of elbow or \ntissue and maintain a distance of at least 1 meter (3 feet) from people who are coughing or sneezing.";
          button10.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "Choose your question, please!";
            button10.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = " If you choose to wear a mask:\n1. Before touching the mask, clean hands with an alcohol - based hand rub or soap and water.\n2. Take the mask and inspect it for tears or holes.\n3. Orient which side is the top side(where the metal strip is).\n4. Ensure the proper side of the mask faces outwards(the coloured side).\n5. Place the mask to your face.Pinch the metal strip or stiff edge of the mask so it moulds to the shape of your nose.\n6. Pull down the mask’s bottom so it covers your mouth and your chin.\n7. Do not touch the mask while you are wearing it for protection.\n8. After use, take off the mask with clean hands; remove the elastic loops from behind the ears while keeping the mask away from \nyour face and clothes, to avoid touching potentially contaminated surfaces of the mask.\n9. Discard the mask in a closed bin immediately after use. Do not reuse the mask.\n10. Perform hand hygiene after touching or discarding the mask";
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "–Use alcohol-based hand rub or, if visibly soiled, wash your hands with soap and water.\nBe aware that there is a global shortage of medical masks(both surgical masks and N95 masks).\nThese should be reserved as much as possible for health care workers.\nRemember that masks are not a substitute for other, more effective ways to protect yourself and others against COVID - 19 such as \nfrequently washing your hands, covering your cough with the bend of elbow or tissue and maintain a distance of at least 1 meter\n(3 feet) from others.";
            button10.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = " The time between exposure to COVID-19 and the moment when symptoms start is commonly around\nfive to six days but can range from 1– 14 days.";
            button10.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = " COVID-19 is spread through human-to-human transmission. We already know a lot about other viruses in the coronavirus family and \nmost of these types of viruses have an origin in animals. The COVID-19 virus (also called SARS-CoV-2) is a new virus in humans. \nThe possible animal source of COVID-19 has not yet been confirmed but research is ongoing.";
            button10.Visible = false;
        }
    }
}
