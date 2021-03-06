using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TwoWayTapeAutomaton.Model;

namespace TwoWayTapeAutomaton.Controller
{
    class Execute
    {

        private Automata GetAutomaton(string state, List<Automata> automaLst, out DIR dir)
        {
            Automata automaton = automaLst.Where(o => o.State == state.Trim()).Distinct().FirstOrDefault();
            if (automaton == null)
            {
                dir = DIR.ERROR;
                return null; 
            }

            dir = automaton.Direction;

            if ((dir == DIR.HELL) || (dir == DIR.ACCEPT))
                return null;

            return automaton;
        }

        private string GetNextState(string input, string state, List<Automata> automaLst, DIR dir)
        {
            Automata automaton = GetAutomaton(state, automaLst, out dir);
            IO path = automaton.Cmd.Where(f => f.Input == input).Distinct().FirstOrDefault();
            return path.NextState;
        }

        private bool GetFinalDir(string state, List<Automata> automaLst, DIR dir)
        {
            Automata automaton = GetAutomaton(state, automaLst, out dir);
            if (dir == DIR.HELL)
                return false;
            else
                return true;
        }

        private void UpdateTape(int i, DIR dir)
        {
            if (TwoTapeGUI.IsSimulate)
            {
                TwoTapeGUI.Tape[i].BackColor = Color.Gold;
                if (dir == DIR.RIGHT)
                    TwoTapeGUI.Tape[i - 1].BackColor = Color.Lavender;

                if (dir == DIR.LEFT)
                    TwoTapeGUI.Tape[i + 1].BackColor = Color.Lavender;

                TwoTapeGUI.Tape[i].Invoke(new MethodInvoker(delegate
                {
                    TwoTapeGUI.Tape[i].Focus();
                }));

                Thread.Sleep(200);
            }
        }

        private void UpdateState(string prevState, string nextState)
        {
            TwoTapeGUI.CurrentState.Invoke(new MethodInvoker(delegate
            {
                TwoTapeGUI.CurrentState.Text = prevState;
            }));

            TwoTapeGUI.NextState.Invoke(new MethodInvoker(delegate
            {
                TwoTapeGUI.NextState.Text = nextState;
            }));
            Thread.Sleep(200);
        }

        private bool Simulate(List<Automata> automaLst, string input)
        {
            input = "#" + input + "#";
            string state = automaLst[0].State;
            DIR dir = automaLst[0].Direction;
            Automata automaton;
            int i = 1;
            while (true) {
                if ((dir == DIR.HELL) 
                    || (dir == DIR.ACCEPT) 
                    || (i > input.Length-1)
                    || (i < 0))
                    break;

                UpdateTape(i, dir);

                string prevState = state;
                string value = "" + input[i];
                state = GetNextState(value, state, automaLst, dir);
                automaton = GetAutomaton(state, automaLst, out dir);
                UpdateState(prevState, state);

                if (dir == DIR.RIGHT)
                    i++;

                if (dir == DIR.LEFT)
                    i--;
            }
            return GetFinalDir(state, automaLst, dir);
        }

        public bool Start(string input, string prog)
        {
            Extractor extractor = new Extractor();
            List<Automata> automaLst = extractor.Extract(prog);
            return Simulate(automaLst, input);
        }
    }
}
