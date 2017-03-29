using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Win_Form_28_03_17
{
    public partial class TestButtonsForm : Form
    {
        static ArrayList arrList = new ArrayList();
        public TestButtonsForm()
        {
            InitializeComponent();
        }
        private void TestButtonsForm_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("       BOOKS");
            foreach (Book n in Library.listBooks)
            {
                arrList.Add(new Book() { Author = n.Author, name = n.name, year = n.year, number = n.number });
                listBox1.Items.Add(n.Author + " " + n.name + " " + n.year + " " + n.number);
            }
            listBox1.Items.Add("       JOURNALS");
            foreach (Journal n in Library.listJournals)
            {
                arrList.Add(new Journal() { name = n.name, numberEdition = n.numberEdition, numberOfPages = n.numberOfPages });
                listBox1.Items.Add(n.name + " " + n.numberEdition + " " + n.numberOfPages);
            }
            listBox1.Items.Add("       NEWSPAPERS");
            foreach (Newspaper n in Library.listNewspaper)
            {
                arrList.Add(new Newspaper() { name = n.name, rating = n.rating, numberOfPages = n.numberOfPages });
                listBox1.Items.Add(n.name + " " + n.rating + " " + n.numberOfPages);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\Books.txt"))
            {
                foreach (Book line in Library.listBooks)
                    outputFile.WriteLine(line.Author+" " +line.name+" "+line.year+" "+line.number);
            }
        }
    }
}
