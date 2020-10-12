using lab3_4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            MarkovChain chain = new MarkovChain();
            Generator generator = new Generator(Convert.ToDouble(txtBoxP.Text), true, chain.Listener);
            HandlerNode handlerNode1 = new HandlerNode(Convert.ToDouble(txtBoxPI1.Text), true, chain.Listener);
            QueueNode queue = new QueueNode(false, 2, chain.Listener);
            HandlerNode handlerNode2 = new HandlerNode(Convert.ToDouble(txtBoxPI2.Text), false, chain.Listener);

            chain.IntializeChain(generator, handlerNode1, queue, handlerNode2);

            chain.TiksCount = Convert.ToInt32(txtBoxTiksCount.Text);
            chain.Work();

            txtBoxDenyvalue.Text = chain.Statistics.DenyChanceValue.ToString();
            txtBoxAvgQueueLen.Text = chain.Statistics.AverageQueueLength.ToString();
            txtBoxAverageReqCountInQueue.Text = chain.Statistics.AvgRequestsCountInSystem.ToString();
            txtBoxQ.Text = chain.Statistics.RelativePassAbility.ToString();
            txtBoxA.Text = chain.Statistics.AbsolutePassAbility.ToString();
            txtBoxAvgReqTimeInQueue.Text = chain.Statistics.AvgTimeRequestInQueue.ToString();
            txtBoxAvgReqTimeInSystem.Text = chain.Statistics.AvgTimeRequestInSystem.ToString();
            txtBoxLoadCoef1.Text = chain.Statistics.CanalLoadCoef[1].ToString();
            txtBoxLoadCoef2.Text = chain.Statistics.CanalLoadCoef[0].ToString();

            int i = 0;
            foreach (var item in chain.Statistics.StatesFrequency)
            {
                dataGridView1.Rows.Add("P" + item.Key, chain.Statistics.StatesChances[i]);
                i++;
            }

        }
    }
}
