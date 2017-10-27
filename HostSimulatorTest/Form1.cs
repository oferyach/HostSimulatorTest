using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostSimulatorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void UpdateTextDelegate(object sender, UpdateTextEventArgs e);

        public class UpdateTextEventArgs
        {
            public string Text { get; set; }
            public UpdateTextEventArgs(string text)
            {
                Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            HostService.HostServiceClient s = new HostService.HostServiceClient();
            HostService.AuthResult res = new HostService.AuthResult();
            string databack="o";
            try
            {
                //databack = s.DoWork(CardNumber.Text);                
                //DataBack.Text = databack;
                res = s.GetAuth(CardNumber.Text, Code.Text);

                if (res.Allowed)
                    Allowed.Text = "true";
                else
                    Allowed.Text = "false";


                Message.Text = res.ErrorDesc;

                Reference.Text = res.Reference;

                DriverName.Text = res.DriverName;

                Limit.Text = res.Limit.ToString();


                
            }
            catch (Exception ex)
            {
                
            }
        }

        private void SendTrans_Click(object sender, EventArgs e)
        {
            try 
            {
                HostService.HostServiceClient s = new HostService.HostServiceClient();
                s.TransactionComplete(Reference.Text, double.Parse(Money.Text), double.Parse(Volume.Text), int.Parse(Product.Text), DateTime.Now);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
