using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceJocMP.Models
{
    //[Serializable]
    public partial class armadura
    {
        //[JsonIgnore]
        public bool serialitza;
        public bool ShouldSerializearmadures()
        {
            return false;
        }
        public bool ShouldSerializeusuaris()
        {
            return false;
        }
        public bool ShouldSerializejugadors()
        {
            return false;
        }
        public bool ShouldSerializearmes()
        {
            return false;
        }

        public bool ShouldSerializepersonatges()
        {
            return false;
        }
        public bool ShouldSerializemonstres()
        {
            return false;
        }
    }
}