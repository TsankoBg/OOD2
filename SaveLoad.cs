using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                  
                        bf.Serialize(s, CompList);
                    
                    return true;
                }

            }
            return false;
        }

        public List<Component> load()
        {
            List<Component> tempList = null;
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                tempList = bf.Deserialize(fs);
               
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

