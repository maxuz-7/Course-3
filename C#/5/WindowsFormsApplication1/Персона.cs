using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    public class Person
    {
        public string Firstname = "";
        public string Lastname = "";
        public string Phone = "";
        public override string ToString()
        {
            string s = Lastname;
            if (Firstname.Trim()!="")
            {
                s+=" " + Firstname.Trim()[0] + ".";
            }
            return s;
        }
        public void SaveToStream (Stream s)
        {
            BinaryWriter bw=new BinaryWriter(s);
            bw.Write(Firstname);
            bw.Write(Lastname);
            bw.Write(Phone);
        }
         public void LoadFromStream (Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Firstname = br.ReadString();
            Lastname = br.ReadString();
            Phone = br.ReadString();
        }
    }
}
