using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lin_Regr
{
    public partial class Lin_Regr : Form
    {
        const int Depth = 10000;
        string mfile;
        double[] DrawData = new double[Depth]; 
        double[] mCurr = new double[Depth]; // array with exchange rate currency1/currency2
        double[] mAC = new double[Depth]; // array of autocorrelation
        int lNum; //elements count
        double ExVal = 0; // average value, first order moment
        double Var = 0; // dispersion, second order moment
        int i_old = 0; // needs for cursor
        int SI = 0, EI = 0; //interval boundaries
        double k = 1, b = 0; // tred line parameters

        public Lin_Regr()
        {
            InitializeComponent();
        }

        private void button_LD_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mfile = openFileDialog1.FileName;

                label_LD.Text = Path.GetFileName(mfile);
                label_LD.ForeColor = Color.Black;

                lNum = Load_Data(mfile);

                label_lNum.Text ="Time period is " + Convert.ToString(lNum) + " days" ;

                DrawData = mCurr;

                Draw_Data(lNum);

                Analysis(lNum);

                trackBar_mD.Maximum = lNum - 1;
            }
        }

        private int Load_Data(string mfile)
        {
            File.OpenRead(mfile);

            StreamReader reader;

            reader = new StreamReader(mfile);
            int i = 0;
            label_startDate.Text = "Time start at " + reader.ReadLine();
            while (!reader.EndOfStream)
            {
                mCurr[i] = Convert.ToDouble(reader.ReadLine());
                i++;
            }

            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin); // reader now reading from position 0
            reader.BaseStream.Position = 0;

            button_EfD.Enabled = false;

            return i; 
        }

        private void Draw_Data(int lNum)
        {
            chart1.Series[0].Points.Clear(); //Form cleaning
            chart1.Series[0].Color = Color.Blue;
            chart1.Series[0].MarkerSize = 5;

            label_XV.Text = "XV= ";
            label_YV.Text = "YV= ";

            for (int i = 0; i < lNum; i++)
            {
                chart1.Series[0].Points.AddXY(i, DrawData[i]);
            }
           
        }

        private void Analysis(int lNum)
        {
            //-----average value-------
            ExVal = 0;
            for (int i = 0; i < lNum; i++) ExVal += mCurr[i];
            ExVal /= lNum;
            label_ExVal.Text = "ExpectedVal= " + ExVal.ToString("0.###");
            //------dispersion
            Var = 0;
            for (int i = 0; i < lNum; i++) Var += (mCurr[i] - ExVal)* (mCurr[i] - ExVal);
            Var /= (lNum - 1);
            label_Var.Text = "Variance= " + Var.ToString("0.###");
        }

        private void button_AutoCorr_Click(object sender, EventArgs e)
        {
            //-----autocorrelation array------

            double temp = 0;
            for (int j = 0; j < lNum; j++)
            {
                temp = 0;
                for (int i = j; i < lNum; i++)
                {
                    temp += (mCurr[i] - ExVal) * (mCurr[i - j] - ExVal);
                }
                mAC[j] = temp / (Var*(lNum - j));
            }
            DrawData = mAC;
            Draw_Data(lNum);
        }

        private void button_SI_Click(object sender, EventArgs e)
        {
            SI = i_old;
            label_Interv.Text = "Interval=[" + Convert.ToString(SI) + " .. " + Convert.ToString(EI) + "]";
            label_Tr_Line.Text = "Tr = ";
        }

        private void button_EI_Click(object sender, EventArgs e)
        {
            EI = i_old;
            label_Interv.Text = "Interval=[" + Convert.ToString(SI) + " .. " + Convert.ToString(EI) + ")";
            label_Tr_Line.Text = "Tr = ";
        }

        private void button_EfD_Click(object sender, EventArgs e)
        {
            for (int i = SI; i < EI; i++)
            {
                mCurr[i] -= k * i + b;

                if (i == (lNum - 2)) mCurr[lNum - 1] -= k * (lNum - 1) + b; //for the last dot

                chart1.Series[0].Points[i].Color = Color.Yellow;
            }
            button_EfD.Enabled = false;
         }

        private void button_ReDrw_Click(object sender, EventArgs e)
        {
            DrawData = mCurr;
            Draw_Data(lNum);
            Analysis(lNum);
        }

        private void button_TrSearh_Click(object sender, EventArgs e)
        {
            k = (mCurr[SI] - mCurr[EI]) / (SI - EI);
            b = mCurr[SI] - k * SI;
            label_Tr_Line.Text = "Tr = " + k.ToString("0.##") + "*d";
            if (b >= 0) label_Tr_Line.Text += " + ";
            label_Tr_Line.Text += b.ToString("0.##");
            button_EfD.Enabled = true;
        }

        private void trackBar_mD_ValueChanged(object sender, EventArgs e)
        {
            int i = trackBar_mD.Value;
            chart1.Series[0].Points[i_old].MarkerSize = 5;
            chart1.Series[0].Points[i_old].Color = Color.Blue;
            chart1.Series[0].Points[i].MarkerSize = 15;
            //chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Cross;
            chart1.Series[0].Points[i].Color = Color.Red;
            label_XV.Text = "XV= " + Convert.ToString(i);
            label_YV.Text = "YV= " + DrawData[i].ToString("0.##");
            i_old = i;          
        }
    }
}
