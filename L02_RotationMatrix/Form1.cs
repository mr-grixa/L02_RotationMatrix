using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace L02_RotationMatrix
{
    public partial class Form1 : Form
    {
        Point3D[] points;
        //Color[] randomColors;
        public Form1()
        {
            InitializeComponent();
            radioButton_perspective.Checked = true;
            radioButtonSpin.Checked = true;
        }

        private void Draw()
        {
            //if (randomColors==null|| randomColors.Length != points.Length)
            //{
            //    randomColors = new Color[points.Length];
            //    Random random = new Random();
            //    for (int i = 0; i < randomColors.Length; i++)
            //    {
            //        randomColors[i] = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            //    }
            //}
            if (radioButton_perspective.Checked)
            {
                DrawPerspective();
            }
            else
            {
                DrawOrthogonal();
            }
        }


        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (radioButtonCube.Checked)
            {
                points = GenerateRandomPoints((int)UpDownCout.Value);
            }
            else
            {
                points = GenerateSpinPoints((int)UpDownCout.Value);
            }
            Draw();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Табличные данные (*.CSV)|*.CSV";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                points = LoadDataFromCSV(openFileDialog.FileName);

            }
            Draw();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "data";
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
                graphics.Clear(Color.Black);
            }
            for (int i = 0; i < points.Length; i++)
            {
                int px = (int)Math.Round((points[i].x + 1) / 2 * (bitmap.Width - 1));
                int py = (int)Math.Round((points[i].y + 1) / 2 * (bitmap.Height - 1));

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
                graphics.Clear(Color.Black);
            }

            float aspect = (float)bmp.Height / bmp.Width; // соотношение сторон битмапа

            // координаты камеры
            float camX = (float)numericUpDownX.Value;
            float camY = (float)numericUpDownY.Value;
            float camZ = (float)numericUpDownZ.Value;

            // проекционная матрица
            Matrix4x4 projectionMatrix = Matrix4x4.CreatePerspectiveFieldOfView(
                (float)numericUpDown2.Value * (float)Math.PI / 180.0f,
                aspect,
                0.001f,
                1000f);

            Vector3 cameraPosition = new Vector3(camX, camY, camZ); // начальная позиция камеры
            Vector3 objectPosition = new Vector3(0, 0, 0); // позиция объекта, вокруг которого будем вращать камеру
            Matrix4x4 translationMatrix = Matrix4x4.CreateTranslation(-(objectPosition - cameraPosition));

            // углы
            float angleX = (float)numericUpDownRX.Value * (float)Math.PI / 180.0f;
            float angleY = (float)numericUpDownRY.Value * (float)Math.PI / 180.0f;
            float angleZ = (float)numericUpDownRZ.Value * (float)Math.PI / 180.0f;

            Matrix4x4 rotationX =Matrix4x4.CreateRotationX(angleX);
            Matrix4x4 rotationY =Matrix4x4.CreateRotationY(angleY);
            Matrix4x4 rotationZ =Matrix4x4.CreateRotationZ(angleZ);
            Matrix4x4 rotationMatrix=rotationX*rotationY*rotationZ;

            Matrix4x4 viewMatrix = rotationMatrix * translationMatrix;
            Matrix4x4 viewProjectionMatrix = viewMatrix * projectionMatrix;
            // Применение матрицы преобразования координат к каждой точке
            for (int i = 0; i < points.Length; i++)
            {
                Vector3 point = new Vector3(
                    (float)points[i].x,
                    (float)points[i].y,
                    (float)points[i].z);
                // перспективное преобразование координат
                Vector3 transformedPoint = Vector3.Transform(point, viewProjectionMatrix);

                // int colorValue = (int)Math.Round(255 * (points[i].z + 1) / 2,MidpointRounding.);
                int px = (int)Math.Round((transformedPoint.X + 1) / 2 * (bmp.Width - 1));
                int py = (int)Math.Round((transformedPoint.Y + 1) / 2 * (bmp.Height - 1));

                //освещение
                float ambientIntensity = 0.1f; // интенсивность фонового освещения
                float lightIntensity = 1f; // интенсивность источника света
                float attenuationFactor = 0.1f; // коэффициент затухания
                float distance = Vector3.Distance(cameraPosition, point);
                float attenuation = 1 / (1 + attenuationFactor * distance * distance);
                float intensity = ambientIntensity + lightIntensity * attenuation;
                if (intensity > 1) { intensity= 1; }
                if (px > 0 && px < 600 && py > 0 && py < 600&& transformedPoint.Z<0)
                {
                    Color color = Color.FromArgb(
                    (int)((points[i].x*100+155)* intensity),
                    (int)((points[i].y*100+155)* intensity),
                    (int)((points[i].z*100+155)* intensity));
                    bmp.SetPixel(px, py, color);

                }

            }
            //using (Graphics graphics = Graphics.FromImage(bmp))
            //{
            //    graphics.DrawLine(Pens.Red, 0, 300, 600, 300);
            //    graphics.DrawLine(Pens.Green, 300, 0, 300, 600);
            //}

            pictureBox1.Image = bmp;
        }

        private void SaveDataToCSV(string filename, Point3D[] data)
        {
            if (data != null)
            {
                 using (StreamWriter writer = new StreamWriter(filename))
                 {
                     foreach (Point3D point in data)
                     {
                         writer.WriteLine($"{point.x};{point.y};{point.z}");
                     }
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

        private Point3D[] GenerateSpinPoints(int numPoints)
        {
            Random random = new Random();
            Point3D[] points = new Point3D[numPoints];
            for (int i = 0; i < numPoints; i++)
            {
                double x = 0.7 * Math.Cos(6 * Math.PI * ((double)i / (double)numPoints));
                double y = 0.6 * Math.Sin(4 * Math.PI * ((double)i / (double)numPoints));
                double z = -1 + 2 * ((double)i / (double)numPoints);
                points[i] = new Point3D(x, y, z);
            }
            return points;
        }

        bool DrawOld;
        private void Draw_Changed(object sender, EventArgs e)
        {
            if (points != null)
            {
                DrawOld = true;
            }

        }
        
        private Point startPoint;
        private decimal RX;
        private decimal RY;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                RX = numericUpDownRX.Value;
                RY= numericUpDownRY.Value;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                numericUpDownRY.Value+=((decimal)(startPoint.X-e.X)*(decimal)0.1);
                numericUpDownRX.Value+=((decimal)(startPoint.Y-e.Y)*(decimal)0.1);
                startPoint = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            startPoint = Point.Empty;
            RX = 0;
            RY = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DrawOld)
            {
                DrawOld= false;
                Draw();
            }
        }

        private void buttonSaveImg_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG файлы (*.png)|*.png";
                saveFileDialog.FileName = "img";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName,System.Drawing.Imaging.ImageFormat.Png);
                }   
            }     
        }
    }
}
