namespace ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            List<char> converters = s.ToList();
            var res = true;
            foreach (var symbol in converters)
            {
                if (!ClosedSymbol(symbol, converters))
                {
                    res = false;
                    break;
                }
            }
            return res;
        }

        private bool ContainsSymbol(char symbol, List<char> symbols)
        {
            return symbols.Contains(symbol);
        }

        private bool ClosedSymbol(char symbol, List<char> symbols)
        {
            switch (symbol)
            {
                case '(':
                    return ContainsSymbol(')', symbols);
                    break;
                case '{':
                    return ContainsSymbol('}', symbols);
                case '[':
                    return ContainsSymbol(']', symbols);
                default:
                    return true;

            }
        }
    }
}