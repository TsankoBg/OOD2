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
      
        public void save(List<Component> CompList)
        {
            if (filename == null)
            {
                int name = updateFileName();
                //see UpdateFileName Method for explaination
                if (name == 1)
                {
                    return;
                }
                else if (name == 2)
                {
                    save(CompList);
                }
                else
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream s = new FileStream(filename, FileMode.OpenOrCreate))
                    {
                        bf.Serialize(s, CompList);
                    }
                }
            }
            else
            { 
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream s = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    bf.Serialize(s, CompList);
                }
            }
        }

        public List<Component> load()
        {
            if (filename == null)
            {
                int name = updateFileName();
                if (name == 1)
                {
                    return null;
                }
                else if (name == 2)
                {
                   return load();
                }
                else
                {
                    List<Component> tempList = null;
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        tempList = (List<Component>)bf.Deserialize(fs);
                    }
                    return tempList;
                }
            }
            else
            {
                List<Component> tempList = null;
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    tempList = (List<Component>)bf.Deserialize(fs);
                }
                return tempList;
            }
          

        }
        public int updateFileName()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "bin|*.bin";
            DialogResult r = ofd.ShowDialog();
            if (r == DialogResult.OK)
            {
                //If results are ok returns 0 which will proceed to work with filename
                filename = ofd.FileName;
                return 0;
                
            }
            else if(r == DialogResult.Cancel)
            {
                //if user cancels will exit Open dialog 
                return 1;
            }
            else
            {
                //selected wrong file or anything else,
                //Another Open File Dialog will appear 
                //until user selects the right file or hits cancel
                return 2;
            }
            
        }
    }
}

