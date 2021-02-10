using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceJocMP.Models
{
    //[Serializable]
    public partial class arma
    {
        //[JsonIgnore]
        public static bool serialitza;
        public bool ShouldSerializearmes()
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

        public bool ShouldSerializearmadures()
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