using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX.DirectInput;
using Microsoft.DirectX;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace NewGame
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }
      
        private void ResultsForm_Load(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Hashtable deserilizePeople;
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                deserilizePeople = (Hashtable)formatter.Deserialize(fs);
                
                foreach (DictionaryEntry item in deserilizePeople)
                {
                    ListViewItem item_new = new ListViewItem(item.Key.ToString());
                    item_new.SubItems.Add(item.Value.ToString());
                    listView1.GridLines = true;
                    listView1.Items.Add(item_new);    
                    listView1.Sorting = SortOrder.Ascending;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
