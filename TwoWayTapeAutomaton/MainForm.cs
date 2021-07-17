using System;
using System.Windows.Forms;
using TwoWayTapeAutomaton.Controller;

namespace TwoWayTapeAutomaton
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try {
                string prog = txtProgram.Text;
                string input = txtInputStr.Text;
                if ((!string.IsNullOrEmpty(prog)) && (!string.IsNullOrEmpty(input)))
                {
                    Execute exec = new Execute();
                    bool res = exec.Start(input, prog);
                    if (res == true){
                        MessageBox.Show("ACCEPT");
                    }
                    else{
                        MessageBox.Show("REJECT");
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProgram.Clear();
            txtInputStr.Clear();
        }
    }
}
