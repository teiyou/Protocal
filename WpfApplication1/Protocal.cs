using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
   public  abstract class Protocal
    {
        public abstract Protocal Clone();
        public abstract string  Fight();
 
    }

    public class Sun : Protocal
    {
        public override string  Fight()
        {
            return "金箍棒挥一挥";
        }

       public  override Protocal Clone()
        {
            return (Sun)this.MemberwiseClone();
        }

    }

    public class Erlang : Protocal
    {
        public override string  Fight()
        {
            return "方天画戟挥一挥";
        }

       public  override Protocal Clone()
        {
            return (Erlang)this.MemberwiseClone();
        }
    }

}
