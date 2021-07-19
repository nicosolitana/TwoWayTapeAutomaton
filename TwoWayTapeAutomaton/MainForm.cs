using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TwoWayTapeAutomaton.Controller;
using TwoWayTapeAutomaton.Model;

namespace TwoWayTapeAutomaton
{
    public partial class MainForm : Form
    {
        private List<Label> _tape;
        private Thread simThread = null;

        public MainForm()
        {
            InitializeComponent();
            pnlTwoTape.HorizontalScroll.Visible = false;
            TwoTapeGUI.CurrentState = lblCurState;
            TwoTapeGUI.NextState = lblNxtState;
            TwoTapeGUI.FormalDef = lblFormaDef;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Start(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlTwoTape.Controls.Clear();
            txtProgram.Clear();
            txtInputStr.Clear();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            Start(true);
        }

        private void Start(bool IsSimulate)
        {
            pnlTwoTape.Controls.Clear();
            TwoTapeGUI.IsSimulate = IsSimulate;
            simThread = new Thread(new ThreadStart(Execute));
            simThread.Start();
        }

        private void Execute()
        {
            try
            {
                string prog = txtProgram.Text;
                string input = txtInputStr.Text;
                if ((!string.IsNullOrEmpty(prog)) && (!string.IsNullOrEmpty(input))) {
                    if (TwoTapeGUI.IsSimulate) {
                        GenerateTape(input);
                        TwoTapeGUI.Tape = _tape;
                    }
                    Execute exec = new Execute();
                    bool res = exec.Start(input, prog);
                    if (res == true) {
                        MessageBox.Show("The input string is ACCEPTED.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("The input string is REJECTED", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } else {
                    MessageBox.Show("Please input a value on input string or program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateTape(string input)
        {
            input = "#" + input + "#";
            _tape = new List<Label>();
            int x = 0;
            foreach (var i in input)
            {
                Label lbl = new Label();
                lbl.Text = i.ToString();
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.BackColor = Color.Lavender;
                lbl.Size = new Size(60, 60);
                lbl.Location = new Point(x, 0);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font("Product Sans", 18);
                _tape.Add(lbl);

                pnlTwoTape.Invoke(new MethodInvoker(delegate
                {
                    pnlTwoTape.Controls.Add(lbl);
                }));

                x += 60;
            }
        }
    }
}
