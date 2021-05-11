using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DBSimulation
{
    class PcDatabase
    {
        private List<PC> _Db = new List<PC>();

        //додати
        public void Add(PC Pc)
        {
            _Db.Add(Pc);
        }

        //вилучити
        public void Remove(PC Pc)
        {
            _Db.Remove(Pc);
        }

        //дізнатись кількість записів в базі
        public int Count
        {
            get
            {
                return _Db.Count;
            }
        }

        public List<PC> Query(Func<PC, bool>  condition)
        {
            return _Db.Where(condition).ToList();
        }

        public List<PC> GetAll()
        {
            return this._Db;
        }

        public PC GetByIndex(int index)
        {
            return this._Db[index];
        }

        //Зерегти до текстового файлу
        private StreamWriter OutFile;
        public void SaveToFile(string FileName)
        {
            try
            {
                OutFile = new StreamWriter(FileName);
                OutFile.WriteLine(this._Db.Count);
                foreach (PC pc in this._Db)
                {
                    OutFile.WriteLine(pc.Frequency.ToString());
                    OutFile.WriteLine(pc.HddVolume.ToString());
                    OutFile.WriteLine(pc.Processor);
                    OutFile.WriteLine(pc.RamVolume.ToString());
                    OutFile.WriteLine(pc.Videocard);
                    OutFile.WriteLine(pc.Price.ToString());
                }
                
            }
            catch (FileNotFoundException err)
            {

            }
            finally
            {
                OutFile.Close();
            }
        }

        //Зчитати з  текстового файлу

        private StreamReader InFile;
        public void ReadFromFile(string FileName)
        {
            try
            {
                InFile = new StreamReader(FileName);
                this._Db.Clear();
                int count = Convert.ToInt32(InFile.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    double Frequency = Convert.ToDouble(InFile.ReadLine());
                    double HddVolume = Convert.ToDouble(InFile.ReadLine());
                    string Processor = InFile.ReadLine();
                    double RamVolume = Convert.ToDouble(InFile.ReadLine());
                    string Videocard = InFile.ReadLine();
                    double Price = Convert.ToDouble(InFile.ReadLine());
                    PC pc = new PC(Processor, Frequency, RamVolume, HddVolume, Videocard, Price);
                    Add(pc);
                }

            }
            catch (FileNotFoundException err)
            {

            }
            finally
            {
                InFile.Close();
            }
        }
    }
}
