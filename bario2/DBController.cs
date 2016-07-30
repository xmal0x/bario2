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
    class DBController
    {
        public Dictionary<int, Bottle> db;
        public Dictionary<int, Stat> statdb;

        private string pathDB = @"db2.txt";
        private string pathDBstat = @"dbStat.txt";


        public void Connect()
        {
            db = new Dictionary<int, Bottle>();
            statdb = new Dictionary<int, Stat>();
        }

        public void AddPosition(string name, int serial, string type, int weightEmpty, int weightFull,
             int weightNow, int capacityFull, int capacityNow, int price, int portion)
        {
            Bottle bottle = new Bottle();

            bottle.name = name;
            bottle.serial = serial;
            bottle.type = type;
            bottle.weightEmpty = weightEmpty;
            bottle.weightFull = weightFull;
            bottle.weightNow = weightNow;
            bottle.capacityFull = capacityFull;
            bottle.capacityNow = capacityNow;
            bottle.price = price;
            bottle.portion = portion;

            bottle.posNum = db.Count;

            db.Add(bottle.posNum, bottle);

        }

        public void SaveDB()
        {
            string json = JsonConvert.SerializeObject(db);

            using (StreamWriter sw = new StreamWriter(pathDB))
            {
                sw.Write(json);
            }
        }

        public void LoadDB()
        {
            string json = File.ReadAllText(pathDB);

            db = JsonConvert.DeserializeObject<Dictionary<int, Bottle>>(json);
        }

        public int GetCount()
        {
            int count = db.Count;
            return count;
        }

        public void ShowDB(DataGridView dg, Dictionary<int, Bottle> dict)
        {
            dg.Columns.Clear();
            dg.Rows.Clear();

            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.Columns.Add("posNum", "Номер");
            dg.Columns.Add("name", "Название");
            dg.Columns.Add("type", "Тип");
            dg.Columns.Add("serial", "Код");
            dg.Columns.Add("weightNow", "Вес сейчас, гр");
            dg.Columns.Add("capacityNow", "Емкость сейчас, гр");

            dg.Rows.Add(dict.Count);

            foreach(int k in dict.Keys)
            {
                dg.Rows[k].Cells["posNum"].Value = dict[k].posNum; 
                dg.Rows[k].Cells["name"].Value = dict[k].name;
                dg.Rows[k].Cells["type"].Value = dict[k].type;
                dg.Rows[k].Cells["serial"].Value = dict[k].serial;
                dg.Rows[k].Cells["weightNow"].Value = dict[k].weightNow;
                dg.Rows[k].Cells["capacityNow"].Value = dict[k].capacityNow;
            }
        }

        public Bottle ScanPosition(int weightScan,int serial)
        {
            Bottle newBottle = new Bottle();
            newBottle.name = "";

            foreach (int k in db.Keys)
            {
                if (db[k].serial == serial)
                {
                    float result = Calculate(db[k], weightScan);

                    CalculateStat(db[k], (int)result);

                    newBottle = db[k];

                    newBottle.weightNow = weightScan;
                    newBottle.capacityNow = (int)result;

                    db.Remove(k);
                    db.Add(k, newBottle);

                    break;
                } 
                
            }
            return newBottle;

        }

        private float Calculate(Bottle bottle, int weightScan)
        {
            float result = (bottle.capacityFull * (weightScan - bottle.weightEmpty)) / (bottle.weightFull - bottle.weightEmpty);
            return result;
        }

        public void CalculateStat(Bottle bottle, int res)
        {
            Stat stat = new Stat();
            stat.date = DateTime.Now;
            stat.name = bottle.name;
            stat.portion = bottle.portion;
            stat.price = bottle.price;
            stat.serial = bottle.serial;

            int diff = bottle.capacityNow - res;

            stat.difference = diff;

            statdb.Add(statdb.Count, stat);
        }

        public int FindDiffStat(Dictionary<int, Stat> dict, Bottle b)
        {
            int dif = -100;
            foreach (int k in dict.Keys)
            {
                if (dict[k].serial == b.serial)
                    dif = dict[k].difference;
            }
            return dif;
        }

        public void ShowDBStat(DataGridView dg, Dictionary<int, Stat> dict)
        {
            try
            {
                dg.Columns.Clear();
                dg.Rows.Clear();

                dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dg.Columns.Add("date", "Дата");
                dg.Columns.Add("name", "Название");
                dg.Columns.Add("serial", "Код");
                dg.Columns.Add("difference", "Пролито, мл");
                dg.Columns.Add("credit", "Сумма, руб");

                dg.Rows.Add(dict.Count);

                foreach (int k in dict.Keys)
                {
                    dg.Rows[k].Cells["date"].Value = dict[k].date;
                    dg.Rows[k].Cells["name"].Value = dict[k].name;

                    dg.Rows[k].Cells["serial"].Value = dict[k].serial;
                    dg.Rows[k].Cells["difference"].Value = dict[k].difference;
                    dg.Rows[k].Cells["credit"].Value = (dict[k].difference / dict[k].portion) * dict[k].price;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        public void SaveDBStat()
        {
            string json = JsonConvert.SerializeObject(statdb);

            using (StreamWriter sw = new StreamWriter(pathDBstat))
            {
                sw.Write(json);
            }
        }

        public void LoadDBStat()
        {
            string json = File.ReadAllText(pathDBstat);

            statdb = JsonConvert.DeserializeObject<Dictionary<int, Stat>>(json);
        }


    }
}
