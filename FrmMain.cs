using System.IO;
using System.Text;

namespace Allatkert2
{
    public partial class FrmMain : Form
    {
        List<Állat> allatok = [];

        const string allatoktxt = "C:\\Users\\72553156301\\source\\repos\\Allatkert2\\Allatkert2\\data\\allatok.txt";
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }

        private void FrmMain_Load(object? sender, EventArgs e)
        {
            Beolvas();
            DgvFeltoltese(allatok);
            CbxFeltoltes();
            btnSzures.Click += BtnSzures_Click;
        }

        private void BtnSzures_Click(object? sender, EventArgs e)
        {
            if (comboBox1.Text == "Összes...")
            {
                DgvFeltoltese(allatok);
                return;
            }

            var szurtAllatok = allatok.Where(a => a.Gondozo.Nev == comboBox1.SelectedItem!.ToString());

            dataGridView1.Rows.Clear();

            foreach (var item in szurtAllatok)
            {
                dataGridView1.Rows.Add(item.Get_Row());
            }

        }

        private void DgvFeltoltese(IEnumerable<Állat> altk)
        {
            dataGridView1.Rows.Clear();
            foreach(var item in allatok){
                dataGridView1.Rows.Add(item.Get_Row());
            }
        }

        private void CbxFeltoltes()
        {
            comboBox1.Items.Add("Összes...");
            var gondozok = allatok.DistinctBy(a => a.Gondozo.Nev).Select(a => a.Gondozo);

            foreach (var nev in gondozok)
            {
                comboBox1.Items.Add(nev.Nev);
            }
        }

        private void DgvFeltoltese()
        {
            foreach (var a in allatok)
            {
                dataGridView1.Rows.Add(a.Get_Row());
            }
        }

        private void Beolvas()
        {
            using StreamReader sr = new(allatoktxt, Encoding.UTF8);

            _ = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                allatok.Add(new Állat(sr.ReadLine()));
            }
        }
    }
}
