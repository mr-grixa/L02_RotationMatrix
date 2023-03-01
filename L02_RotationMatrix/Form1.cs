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
using System.Numerics;

namespace L02_RotationMatrix
{
    public partial class Form1 : Form
    {
        Point3D[] points;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            points = GenerateRandomPoints((int)UpDownCout.Value);
            DrawPerspective();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Табличные данные (*.CSV)|*.CSV";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                points = LoadDataFromCSV(openFileDialog.FileName);

            }
        } 
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Табличные данные (*.CSV)|*.CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveDataToCSV(saveFileDialog.FileName, points);
            }
        }

        private void DrawOrthogonal()
        {
            Bitmap bitmap = new Bitmap(600, 600);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.MidnightBlue);
            }
            for (int i = 0; i < points.Length; i++)
            {
                int px = (int)Math.Round((points[i].x + 1) / 2 * (bitmap.Width-1));
                int py = (int)Math.Round((points[i].y + 1) / 2 * (bitmap.Height-1));

                int colorValue = (int)Math.Round(255 * (points[i].z + 1) / 2);
                Color color = Color.FromArgb(colorValue, colorValue, colorValue);
                bitmap.SetPixel(px, py, color);
            }
            pictureBox1.Image = bitmap;

        }

        private void DrawPerspective()
        {
            Bitmap bmp = new Bitmap(600, 600);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.Clear(Color.MidnightBlue);
            }

            // параметры проекции
            const float near = 4f;  // расстояние до ближней плоскости отсечения
            const float far = 5f;   // расстояние до дальней плоскости отсечения
            const float fov = 90f;  // угол обзора камеры (Field of View)
            float aspect = (float)bmp.Height / bmp.Width; // соотношение сторон битмапа

            // координаты камеры
            float camX = 0.0f;
            float camY = 0.0f;
            float camZ = 0.0f;

            // проекционная матрица
            Matrix4x4 projectionMatrix = Matrix4x4.CreatePerspective(400,400,4,5);
                //fov * (float)Math.PI / 180.0f, aspect, near, far);

            // модельно-видовая матрица
            Matrix4x4 viewMatrix = Matrix4x4.CreateTranslation(-camX, -camY, -camZ);



            // Применение матрицы преобразования координат к каждой точке
            for (int i = 0; i < points.Length; i++)
            {
                Vector3 point = new Vector3(
                    (float)points[i].x,
                    (float)points[i].y,
                    (float)points[i].z);
                // перспективное преобразование координат
                Vector3 transformedPoint = Vector3.Transform(point, projectionMatrix);
                points[i] = new Point3D(transformedPoint.X, transformedPoint.Y, transformedPoint.Z);

                int colorValue = (int)Math.Round(255 * (points[i].z + 1) / 2);
                //Color color = Color.FromArgb(colorValue, colorValue, colorValue);
                //bmp.SetPixel((int)points[i].x, (int)points[i].y, color);
            }


            pictureBox1.Image = bmp;
        }

        private void SaveDataToCSV(string filename, Point3D[] data)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Point3D point in data)
                {
                    writer.WriteLine($"{point.x};{point.y};{point.z}");
                }
            }
        }

        private Point3D[] LoadDataFromCSV(string filename)
        {
            List<Point3D> data = new List<Point3D>();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');
                    double x = double.Parse(values[0]);
                    double y = double.Parse(values[1]);
                    double z = double.Parse(values[2]);
                    data.Add(new Point3D(x, y, z));
                }
            }
            return data.ToArray();
        }

        private Point3D[] GenerateRandomPoints(int numPoints)
        {
            Random random = new Random();
            Point3D[] points = new Point3D[numPoints];
            for (int i = 0; i < numPoints; i++)
            {
                double x = random.NextDouble() * 2 - 1; // случайное число в диапазоне [-1, 1)
                double y = random.NextDouble() * 2 - 1; // случайное число в диапазоне [-1, 1)
                double z = random.NextDouble() * 2 - 1; // случайное число в диапазоне [-1, 1)
                points[i] = new Point3D(x, y, z);
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
