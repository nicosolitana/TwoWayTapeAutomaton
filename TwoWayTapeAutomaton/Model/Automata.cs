using System.Collections.Generic;

namespace TwoWayTapeAutomaton.Model
{
    enum DIR
    {
        LEFT,
        RIGHT,
        HELL,
        ACCEPT,
        ERROR
    }

    class Automata
    {
        private string _state;
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        private DIR _direction;
        public DIR Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
            }
        }

        private List<IO> _cmd;
        public List<IO> Cmd
        {
            get
            {
                return _cmd;
            }
            set
            {
                _cmd = value;
            }
        }
    }
}
