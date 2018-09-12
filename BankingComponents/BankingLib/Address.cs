using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Banking
{
    public struct Address
    {
        public string Line1
        {
            get;set;
        }
        public string Line2
        {
            get; set;
        }
        public string City
        {
            get; set;
        }
        public string County
        {
            get; set;
        }
        public string Postcode
        {
            get; set;
        }
        public override string ToString()
        {
            var fullAddress = new StringBuilder(Line1).AppendLine().Append(Line2).AppendLine().Append(City).
                AppendLine().Append(County).AppendLine().Append(Postcode);
            return fullAddress.ToString();
        }
    }
}
