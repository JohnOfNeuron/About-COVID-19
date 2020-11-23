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
    public partial class FAQ1 : UserControl
    {
        public FAQ1()
        {
            InitializeComponent();
            button10.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " Coronaviruses are a large family of viruses which may cause illnes in animals or humans. In humans, several coronaviruses are \nknown to cause respiratory infections ranging from the common cold to more severe diseases such as Middle East Respiratory \nSyndrome (MERS) and Severe Acute Respiratory Syndrome(SARS). The most recently discovered coronavirus \ncauses coronavirus disease COVID-19.";
            button10.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " COVID-19 is the infectious disease caused by the most recently discovered coronavirus. This new virus and disease were unknown \nbefore the outbreak began in Whuan, China, in December 2019.";
            button10.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = " The most common symptoms of COVID-19 are fever, tiredness, and dry cough. Some patients may have aches and pains, nasal \ncongestion, runny nose, sore throat or diarrhea. These symptoms are usually mild and begin gradually. Some people become \ninfected but don't develop any symptoms and don't feel unwell. Most people (about 80%) recover from the disease with out \nneeding special treatment. Around 1 out of every 6 people who gets COVID-19 becomes seriously ill and develops difficulty \nbreathin. Older people, and those with underlying medical problems like high blood preassure, heart problems or dibetes, are more \nlikely to develop serious illness. People with fever, cough and difficulty breathing should seek medical attention.";
            button10.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = " People can catch COVID-19 from others who have the virus. The disease can spread from person to person through small droplets \nfrom the nose or mouth which are spread when a person with COVID-19 coughs or exhales. These droplets land on objects and \nsurfaces around the person. Other people then catch COVID-19 by touching these objects or surfaces, then touching their eyes, \nnose or mouth.People can also catch COVID-19 if they breathe in droplets from a person with COVID-19 who coughs out or exhales \ndroplets. This is why it is important to stay more than 1 meter (3 feet) away from a person who is sick.";
            button10.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "Choose your question, please!";
            button10.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "* Regularly and thoroughly clean your hands with an alcohol-based hand rub or wash them with soap\nand water. Why? Washing your hands with soap and water or using alcohol-based hand rub kills\nviruses that may be on your hands.\n*Maintain at least 1 metre (3 feet) distance between yourself and anyone who is coughing or sneezing.\nWhy? When someone coughs or sneezes they spray small liquid droplets from their nose or\nmouth which may contain virus. If you are too close, you can breathe in the droplets, including the\nCOVID-19 virus if the person coughing has the disease.\n* Avoid touching eyes, nose and mouth. Why? Hands touch many surfaces and can pick up viruses. Once contaminated, \nhands can transfer the virus to your eyes, nose or mouth. From there, the virus can enter your body and can make you sick.\n*Make sure you, and the people around you, follow good respiratory hygiene. This\nmeans covering your mouth and nose with your bent elbow or tissue when you cough or sneeze.\nThen dispose of the used tissue immediately. Why? Droplets spread virus. By following good\nrespiratory hygiene you protect the people around you from viruses such as cold, flu and\nCOVID-19.\n";
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text= "* Stay home if you feel unwell. If you have a fever, cough and difficulty breathing, seek medical attention\nand call in advance.Follow the directions of your local health authority. Why? National and\nlocal authorities will have the most up to date information on the situation in your area. Calling in\nadvance will allow your health care provider to quickly direct you to the right health facility. This will\nalso protect you and help prevent spread of viruses and other infections.\n* Keep up to date on the latest COVID - 19 hotspots(cities or local areas where COVID - 19 is spreading widely).If possible,\navoid traveling to places – especially if you are an older person or have diabetes, heart or\nlung disease. Why? You have a higher chance of catching COVID - 19 in one of these areas.";
            button10.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = " The risk depends on where you are - and more specifically, whether there is a COVID-19 outbreak unfolding there. For most people \nin most locations the risk of catching COVID-19 is still low. However, there are now places around the world (cities or areas) where \nthe disease is spreading. For people living in, or visiting, these areas the risk of catching COVID-19 is higher. Governments and \nhealth authorities are taking vigorous action every time a new case of COVID-19 is identified. Be sure to comply with any local \nrestrictions on travel, movement or large gatherings. Cooperating with disease control efforts will reduce your risk of catching or \nspreading COVID-19.";
            button10.Visible = false;        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = " Illness due to COVID-19 infection is generally mild, especially for children and young adults. However, it can cause serious illness: \nabout 1 in every 5 people who catch it need hospital care. It is therefore quite normal for people to worry about how the COVID-19 \noutbreak will affect them and their loved ones. We can channel our concerns into actions to protect ourselves, our loved ones \nand our communities. First and foremost among these actions is regular and thorough hand-washing and good respiratory hygiene. \nSecondly, keep informed and follow the advice of the local health authorities including any restrictions put in place on travel, \nmovement and gatherings.";
            button10.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = " While we are still learning about how COVID-2019 affects people, older persons and persons with pre- existing medical conditions \n(such as high blood pressure, heart disease, lung disease, cancer or diabetes) appear to develop serious illness more often than \nothers.";
            button10.Visible = false;
        }
    }
}
