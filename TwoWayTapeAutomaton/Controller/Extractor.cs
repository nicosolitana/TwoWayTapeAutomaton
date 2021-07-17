using System;
using System.Collections.Generic;
using System.Linq;
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
            return automaLst;
        }
    }
}
