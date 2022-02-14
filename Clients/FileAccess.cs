using Clients.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    internal class FileAccess
    {
        private const string path = @"D:\Список_имен.csv";
        public List<AddMember> OpenFile()
        {
            List<AddMember> member = new List<AddMember>();
            List<AddMember> sortedMember = new List<AddMember>();
            List<string> files = new List<string>();
            using (StreamReader sr = new StreamReader(path, Encoding.Default, true, 10))
            {
               var line = sr.ReadLine();
                while (line != null) 
                {
                files.Add(line);
                    line = sr.ReadLine();
                }
            }
            foreach (var client in files)
            {
                var person = client.Split(new char[] { ';' });
                AddMember memb = new AddMember();
                memb._Fio = person[0];
                memb._Date = Convert.ToInt32(person[1]);
                memb._Pension = memb._Date.ToString();
                member.Add(memb);
            }

            var query = from m in member orderby m._Date select m;
            foreach (var q in query)
            {
                sortedMember.Add(q);
            }
            return sortedMember;
        }
    }
}
