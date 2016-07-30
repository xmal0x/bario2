using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bario2
{
    public partial class Form1 : Form
    {
        DBController dbtest;
        HelpController hlpComplete;

        public Form1()
        {
            InitializeComponent();

            dbtest = new DBController();
            hlpComplete = new HelpController();

            buttonAdd.Enabled = false;
            buttonSave.Enabled = false;
            buttonScan.Enabled = false;

            hlpComplete.iniAuto(textBoxName, hlpComplete.listName);
            hlpComplete.iniAuto(textBoxType, hlpComplete.listType);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            dbtest.Connect();

            buttonAdd.Enabled = true;
            buttonSave.Enabled = true;
            buttonScan.Enabled = true;

            listBoxLog.Items.Add("Успешное соединение");

            dbtest.LoadDB();
            dbtest.LoadDBStat();
            hlpComplete.LoadList();

            hlpComplete.iniAuto(textBoxName, hlpComplete.listName);
            hlpComplete.iniAuto(textBoxType, hlpComplete.listType);

            listBoxLog.Items.Add("Загружено " + dbtest.GetCount().ToString() + " строк данных");

            dbtest.ShowDB(dataGridView, dbtest.db);
            dbtest.ShowDBStat(dataGridViewStat, dbtest.statdb);

            buttonConnect.Enabled = false;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dbtest.SaveDB();
            dbtest.SaveDBStat();
            hlpComplete.SaveList();

            listBoxLog.Items.Add("Успешное сохранение");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                int serial = Int32.Parse(textBoxSerial.Text);
                string type = textBoxType.Text;
                int weightEmpty = Int32.Parse(textBoxWeightEmpty.Text);
                int weightFull = Int32.Parse(textBoxWeightFull.Text);
                int weightNow = Int32.Parse(textBoxWeightNow.Text);
                int capacityFull = Int32.Parse(textBoxCapacityFull.Text);
                int capacityNow = Int32.Parse(textBoxCapacityNow.Text);
                int price = Int32.Parse(textBoxPrice.Text);
                int portion = Int32.Parse(textBoxPortion.Text);

                dbtest.AddPosition(name, serial, type, weightEmpty, weightFull, weightNow, capacityFull, capacityNow, price, portion);

                listBoxLog.Items.Add("Добавлена позиция " + name);

                dbtest.ShowDB(dataGridView, dbtest.db);

                hlpComplete.AddToList(hlpComplete.listName, textBoxName.Text);
                hlpComplete.AddToList(hlpComplete.listType, textBoxType.Text);
                hlpComplete.iniAuto(textBoxName, hlpComplete.listName);
                hlpComplete.iniAuto(textBoxType, hlpComplete.listType);



            } catch (Exception ex)
            {
                MessageBox.Show("Незаполнены необходимые поля!\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


                
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            try
            {
                int weightScan = Int32.Parse(textBoxWeightScan.Text);
                int serialScan = Int32.Parse(textBoxSerialScan.Text);

                Bottle b = dbtest.ScanPosition(weightScan, serialScan);

                int dif = dbtest.FindDiffStat(dbtest.statdb, b);

                if (b.name == "")
                    listBoxLog.Items.Add("Позиция не найдена");
                else
                {
                    dbtest.ShowDB(dataGridView, dbtest.db);
                    dbtest.ShowDBStat(dataGridViewStat, dbtest.statdb);

                    listBoxLog.Items.Add("Позиция " + b.name + " изменена" );
                    listBoxLog.Items.Add("Пролито " + dif.ToString() + " мл" );
                    listBoxLog.SelectedIndex = listBoxLog.Items.Count-1; //Автопрокрутка
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сканировании позиции\n" + ex.Message);
            }
            
        }
    }
}
