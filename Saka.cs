using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakuStrukturosIlgis
{
    class Saka
    {  
        public int sakosID { get; private set; }
        public IList<Saka> vaikai { get; private set; }

        public Saka (int iD)
        {
            this.sakosID = iD;
            vaikai = new List<Saka>();
        }

        public List<Saka> gylis
        {
            get
            {
                List<Saka> path = new List<Saka>();
                foreach (Saka saka in vaikai)
                {
                    List<Saka> tmp = saka.gylis;
                    if (tmp.Count > path.Count)
                        path = tmp;
                }
                path.Insert(0, this);
                return path;
            }
        }

    }


}

