using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TwoWayTapeAutomaton.Model;

namespace TwoWayTapeAutomaton.Controller
{
    class Extractor
    {
        private List<string> _errMsg = new List<string>();

        private string[] ExtractData(string value, string delimeter)
        {
            var strLst = value.Split(new[] { delimeter },
                StringSplitOptions.None);
            strLst = strLst.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToArray();
            strLst = strLst.Select(s => s.Trim()).ToArray();
            return strLst;
        }

        private DIR GetDirection(string direction)
        {
            switch (direction)
            {
                case "left": return DIR.LEFT;
                case "right": return DIR.RIGHT;
                case "hell": return DIR.HELL;
                case "accept": return DIR.ACCEPT;
                default: return DIR.ERROR;
            }
        }

        private IO ExtractPath(string value)
        {
            var valLst = ExtractData(value, ",");

            if (valLst.Length != 2)
            {
                return null;
            }

            return new IO()
            {
                Input = valLst[0].Replace("(",""),
                NextState = valLst[1].Replace(")", "")
            };
        }

        private List<IO> ExtractPathList(string[] tokenLst)
        {
            List<IO> pathList = new List<IO>();
            for (int i = 2; i < tokenLst.Length; i++)
            {

                IO path = ExtractPath(tokenLst[i]);

                if (path == null)
                {
                    return null;
                }
                else
                {
                    pathList.Add(path);
                }
            }
            return pathList;
        }

        private Automata ExtractInfo(string code)
        {
            var tokenLst = ExtractData(code, " ");

            Automata automaton = new Automata();
            automaton.State = (tokenLst[0]).Replace("]", "");

            if (tokenLst.Length > 1)
            {
                automaton.Direction = GetDirection(tokenLst[1].ToLower());
            }

            if (tokenLst.Length > 2)
            {
                List<IO> pathList = ExtractPathList(tokenLst);
                if (pathList == null) {
                    automaton.Direction = DIR.ERROR;
                } else {
                    automaton.Cmd = pathList;
                }
            }
            return automaton;
        }

        private static void ExtractFormalDef(List<Automata> automaLst)
        {
            var aState = automaLst.Select(a => a.State).Distinct().ToList();
            var fState = automaLst.Where(a => a.Direction == DIR.HELL || a.Direction == DIR.ACCEPT)
                .Select(a => a.State).Distinct().ToList();
            var iState = automaLst[0].State;
            var symbols = automaLst.Where(w => w.Cmd != null)
                .Select(a => a.Cmd.Select(c => c.Input).Distinct().ToList())
                .SelectMany(x => x).Distinct().ToList();
            symbols.Remove("#");
            string formalDef = "Q = { " + String.Join(", ", aState) + " }" + Environment.NewLine +
                "S = { " + String.Join(", ", symbols) + " }" + Environment.NewLine +
                "F = { " + String.Join(", ", fState) + " }" + Environment.NewLine +
                "qi = { " + String.Join(", ", iState) + " }" + Environment.NewLine;

            TwoTapeGUI.FormalDef.Invoke(new MethodInvoker(delegate
            {
                TwoTapeGUI.FormalDef.Text = formalDef;
            }));
        }

        public List<Automata> Extract(string prog)
        {
            var codeLst = ExtractData(prog, Environment.NewLine);
            List<Automata> automaLst = new List<Automata>();
            foreach (var code in codeLst)
            {
                Automata value = ExtractInfo(code);
                if (value.Direction == DIR.ERROR)
                    break;
                automaLst.Add(value);
            }
            ExtractFormalDef(automaLst);
            return automaLst;
        }
    }
}
