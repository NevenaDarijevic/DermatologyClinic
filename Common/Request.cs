using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
  public  class Request
    {
        public Operation Operacija { get; set; }
        public object Objekat { get; set; }
    }
}
