namespace TwoWayTapeAutomaton.Model
{
    class IO
    {
        private string _input;
        public string Input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
            }
        }

        private string _nextState;
        public string NextState
        {
            get
            {
                return _nextState;
            }
            set
            {
                _nextState = value;
            }
        }
    }
}
