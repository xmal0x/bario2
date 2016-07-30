using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bario2
{
    class HelpController
    {
        string pathDB = @"dbLst.txt";

        //Списки для автозамен, при добавлении позиции список сохраняется
        public List<string> listName = new List<string>();
        public List<string> listType = new List<string>();

        public string[] AddToList(List<string> lst, string str)
        {
            foreach(string s in lst)
            {
                if ((s == str))
                {
                    return lst.ToArray();
                }

            }

            lst.Add(str);
            return lst.ToArray();

        }

        public void iniAuto(TextBox tbox, List<string> lst)
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(lst.ToArray());
            tbox.AutoCompleteCustomSource = source;
            tbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbox.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        public void SaveList()
        {
            string json = JsonConvert.SerializeObject(listName) + "#";
            json = json + JsonConvert.SerializeObject(listType);

            using (StreamWriter sw = new StreamWriter(pathDB))
            {
                sw.Write(json);
            }
        }

        public void LoadList()
        {
            try
            {
                string json = File.ReadAllText(pathDB);

                string[] jsons = json.Split('#');
                listName = JsonConvert.DeserializeObject<List<string>>(jsons[0]);
                listType = JsonConvert.DeserializeObject<List<string>>(jsons[1]);
            }catch(Exception ex)
            {

            }

        }

    }
}
