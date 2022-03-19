using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Sorter
    {
        private Dictionary<string, double> _pairs = new Dictionary<string, double>();

        public void SetValues(string a, string b, string c)
        {
            try
            {
                _pairs["A"] = Convert.ToDouble(a);
                _pairs["B"] = Convert.ToDouble(b);
                _pairs["C"] = Convert.ToDouble(c);
            }
            catch (FormatException)
            {
                SetNormalValues();
            }
            catch (OverflowException)
            {
                SetNormalValues();
            }
        }

        private void SetNormalValues()
        {
            _pairs["A"] = int.MinValue;
            _pairs["B"] = int.MinValue;
            _pairs["C"] = int.MinValue;
        }

        public string GetValues()
        {
            if (_pairs["A"].Equals(_pairs["B"]) && _pairs["B"].Equals(_pairs["C"]) && _pairs["A"] == int.MinValue)
            {
                return "Введены неверные данные";
            }

            var sortedValues = _pairs.Values.OrderByDescending(number => number).ToArray();

            string result = "";
            var notTakenKeys = _pairs.Keys.ToList();
            foreach (var value in sortedValues)
            {
                foreach (var key in _pairs.Keys)
                {
                    if (_pairs[key] == value && notTakenKeys.Contains(key))
                    {
                        result += $"{key}={_pairs[key]} ";
                        notTakenKeys.Remove(key);
                    }
                }
            }

            return result;
        }
    }
}
