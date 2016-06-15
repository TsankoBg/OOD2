using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class SaveLoad
    {

        public string filename { get; set; }
        public SaveLoad()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "bin|*.bin";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
            }
            else
            {
                bool b = updateFileName();
                while (!b)
                {
                    b = updateFileName();
                };

            }

        }
        public bool save(List<Component> CompList)
        {
            if (filename != null)
            {

                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream s = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    for (int i = 0; i < CompList.Count; i++)
                    {
                        bf.Serialize(s, CompList[i]);
                    }
                    return true;
                }

            }
            return false;
        }

        public List<Component> load()
        {
            List<Component> tempList = null;
            BinaryFormatter bf = new BinaryFormatter();
            Object ob = null;
            Component comp = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                ob = bf.Deserialize(fs);
                if (ob is Merger)
                {
                    comp = (Merger)ob;
                    tempList.Add(comp);
                }
                else if (ob is Pipe)
                {
                    comp = (Pipe)ob;
                    tempList.Add(comp);
                }
                else if (ob is Pump)
                {
                    comp = (Pump)ob;
                    tempList.Add(comp);
                }
                else if (ob is Sink)
                {
                    comp = (Sink)ob;
                    tempList.Add(comp);
                }
                else if (ob is Splitter)
                {
                    comp = (Splitter)ob;
                    tempList.Add(comp);

                }
                else
                {
                    return null;
                }
                return tempList;

            }

        }
        public bool updateFileName()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "bin|*.bin";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
}
