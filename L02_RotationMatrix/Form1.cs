using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L02_RotationMatrix
{
    public partial class Form1 : Form
    {
        List<Tuple<double, double, double>> XYZPoints;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            XYZPoints = GenerateRandomPoints((int)UpDownCout.Value);
            DrawPerspective();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Табличные данные (*.CSV)|*.CSV";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XYZPoints = LoadDataFromCSV(openFileDialog.FileName);

            }
        } 
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Табличные данные (*.CSV)|*.CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveDataToCSV(saveFileDialog.FileName, XYZPoints);
            }
        }

        private void DrawOrthogonal()
        {
            Bitmap bitmap = new Bitmap(600, 600);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.MidnightBlue);
            }
            for (int i = 0; i < XYZPoints.Count; i++)
            {
                int px = (int)Math.Round((XYZPoints[i].Item1 + 1) / 2 * (bitmap.Width-1));
                int py = (int)Math.Round((XYZPoints[i].Item2 + 1) / 2 * (bitmap.Height-1));

                int colorValue = (int)Math.Round(255 * (XYZPoints[i].Item3 + 1) / 2);
                Color color = Color.FromArgb(colorValue, colorValue, colorValue);
                bitmap.SetPixel(px, py, color);
            }
            pictureBox1.Image = bitmap;

        }
        private void DrawPerspective()
        {
            Bitmap bitmap = new Bitmap(600, 600);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.MidnightBlue);
            }
            double theta = Math.PI / 4; // угол обзора в радианах
            for (int i = 0; i < XYZPoints.Count; i++)
            {
                double xNew = Math.Cos(theta) * XYZPoints[i].Item1 + Math.Sin(theta) * XYZPoints[i].Item3;
                double yNew = XYZPoints[i].Item2;
                double zNew = -Math.Sin(theta) * XYZPoints[i].Item1 + Math.Cos(theta) * XYZPoints[i].Item3;

                // Вычисляем яркость точки
                int colorValue = (int)Math.Round(255 * (XYZPoints[i].Item3 + 1) / 2);
                Color color = Color.FromArgb(colorValue, colorValue, colorValue);

                // Рисуем точку на битовой карте с заданной яркостью
                int xPixel = (int)((xNew + 1) / 2 * bitmap.Width);
                int yPixel = (int)((yNew+1) / 2 * bitmap.Height);
                bitmap.SetPixel(xPixel, yPixel, color);
            }
            pictureBox1.Image = bitmap;
        }

        static void SaveDataToCSV(string filename, List<Tuple<double, double, double>> data)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Tuple<double, double, double> point in data)
                {
                    writer.WriteLine($"{point.Item1};{point.Item2};{point.Item3}");
                }
            }
        }

        private List<Tuple<double, double, double>> LoadDataFromCSV(string filename)
        {
            List<Tuple<double, double, double>> data = new List<Tuple<double, double, double>>();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');
                    double x = double.Parse(values[0]);
                    double y = double.Parse(values[1]);
                    double z = double.Parse(values[2]);
                    data.Add(new Tuple<double, double, double>(x, y, z));
                }
            }
            return data;
        }

        private List<Tuple<double, double, double>> GenerateRandomPoints(int numPoints)
        {
            Random random = new Random();
            List<Tuple<double, double, double>> points = new List<Tuple<double, double, double>>();
            for (int i = 0; i < numPoints; i++)
            {
                double x = random.NextDouble() * 2 - 1; // случайное число в диапазоне [-1, 1)
                double y = random.NextDouble() * 2 - 1; // случайное число в диапазоне [-1, 1)
                double z = random.NextDouble() * 2 - 1; // случайное число в диапазоне [-1, 1)
                points.Add(new Tuple<double, double, double>(x, y, z));
            }
            return points;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = Math.Sin((double)numericUpDown1.Value).ToString();
        }
    }
}
