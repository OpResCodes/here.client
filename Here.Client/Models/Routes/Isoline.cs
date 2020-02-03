using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Here.Client.Models.Routes
{
    public class Isoline
    {
        public string Range { get; set; }

        public IsolineComponent[] Component { get; set; }


    }

    public class IsolineConnection
    {

    }

    public class IsolineComponent
    {
        public string Id { get; set; }

    }

    public class CoordinateArray : List<string>
    {
        private static readonly CultureInfo _ci = new CultureInfo("en-US");
        private static readonly string _polygonWkt = "POLYGON(({0}))";
        private static readonly string _linestringWkt = "LINESTRING(({0}))";
        private const char _sep = ',';

        public Position[] ToPositionArray()
        {
            Position[] positions = new Position[Count];
            for (int i = 0; i < Count; i++)
            {
                string[] split = SplitLine(i);
                positions[i] = new Position(float.Parse(split[0], _ci), float.Parse(split[1], _ci));
            }
            return positions;
        }

        public string ToWktPolygon()
        {
            return string.Format(_polygonWkt,GetWktCoords());
        }
        public string ToLineStringWkt()
        {
            return string.Format(_linestringWkt, GetWktCoords());
        }

        private string GetWktCoords()
        {
            StringBuilder b = new StringBuilder();
            int k = Count;
            for (int i = 0; i < k; i++)
            {
                string[] split = SplitLine(i);
                b.AppendFormat("{0} {1}", split[0], split[1]);
                if (i < k - 1)
                    b.Append(", ");
            }
            return b.ToString();
        }

        private string[] SplitLine(int i)
        {
            return this[i].Split(_sep);
        }


    }


}
