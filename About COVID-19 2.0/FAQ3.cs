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
    public partial class FAQ3 : UserControl
    {
        public FAQ3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " Several dogs and cats (domestic cats and a tiger) in contact with infected humans have tested positive for COVID-19. In addition, \nferrets appear to be susceptible to the infection. In experimental conditions, both cats and ferrets were able to transmit infection to \nother animals of the same species, but there is no evidence that these animals can transmit the disease to human and play a role in \nspreading COVID-19. COVID-19 is mainly spread through droplets produced when an infected person coughs, sneezes, or speaks. It \nis still recommended that people who are sick with COVID-19 and people who are at risk limit contact with companion and other \nanimals. When handling and caring for animals, basic hygiene measures should always be implemented. This includes hand washing \nafter handling animals, their food, or supplies, as well as avoiding kissing, licking or sharing food.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " The most important thing to know about coronavirus on surfaces is that they can easily be cleaned with common household disinf-\nectants that will kill the virus. Studies have shown that the COVID-19 virus can survive for up to 72 hours on plastic and stainless steel, \nless than 4 hours on copper and less than 24 hours on cardboard. As, always clean your hands with an alcohol-based hand rub or \nwash them with soap and water. Avoid touching your eyes, mouth, or nose.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = " When grocery shopping, keep at least 1-metre distance from others and avoid touching your eyes, mouth and nose. If possible, \nsanitize the handles of shopping trolleys or baskets before shopping. Once home, wash your hands thoroughly and also after \nhandling and storing your purchased products. There is currently no confirmed case of COVID-19 transmitted through food or food \npackaging.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = " Fruits and vegetables are important components of a healthy diet. Wash them the same way you should do under any circumstan-\nce: before handling them, wash your hands with soap and water. Then, wash fruits and vegetables thoroughly with clean water, \nespecially if you eat them raw.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = " While initial investigations suggest the virus may be present in faeces in some cases, to date, there have not been reports of faecal-\noral transmission of COVID-19. Additionally, there is no evidence to date on the survival of the COVID-19 virus in water or sewage. \nWHO is assessing ongoing research on the ways COVID-19 is spread and will continue to share new findings on this topic.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "Choose your question, please!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = " If you have been in close contact with someone with COVID-19, you may be infected. Close contact means that you live with or \nhave been in settings of less than 1 meter from those who have the disease. In these cases, it is best to stay at home. However, if \nyou live in an area with malaria or dengue fever it is important that you do not ignore symptoms of fever. Seek medical help. When \nyou attend the health facility wear a mask if possible, keep at least 1 metre distant from other people and do not touch surfaces \nwith your hands. If it is a child who is sick help the child stick to this advice.\nIf you do not live in an area with malaria or dengue fever please do the following:\n *If you become ill, even with very mild symptoms you must self-isolate.\n * Even if you don’t think you have been exposed to COVID-19 but develop symptoms, then self-isolate and monitor yourself\n * You are more likely to infect others in the early stages of the disease when you just have mild symptoms, therefore early \nself-isolation is very important.\n * If you do not have symptoms, but have been exposed to an infected person, self-quarantine for 14 days.\nIf you have definitely had COVID-19 (confirmed by a test) self-isolate for 14 days even after symptoms have disappeared as a preca-\nutionary measure – it is not yet known exactly  how long people remain infectious after they have recovered.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "To self-quarantine means to separate yourself from others because you have been exposed to someone with COVID-19 even though \nyou, yourself, do not have symptoms. During self-quarantine you monitor yourself for symptoms. The goal of the self- quarantine is to \nprevent transmission. Since people who become ill with COVID-19 can infect people immediately self-quarantine can prevent some \ninfections from happening.\n In this case:\n•	Have a large, well-ventilated single room with hand hygiene and toilet facilities\n•	If this is not available place beds at least 1 meter apart.\n•	Keep at least 1 - metre distance from others, even from your family members.\n•	Monitor your symptoms daily\n•	Self - quarantine for 14 days, even if you feel healthy\n•	If you develop difficulty breathing, contact your healthcare provider immediately – call them first if possible.\n•	Stay positive and energized by keeping in touch with loved ones by phone or online, and by exercising yourself at home.\nHowever, if you live in an area with malaria or dengue fever it is important that you do not ignore symptoms of fever. Seek medical \nhelp.When you attend the health facility wear a mask if possible, keep at least 1 metre distant from other people and do not touch \nsurfaces with your hands.If it is a child who is sick help the child stick to this advice.";
        }
    }
}
