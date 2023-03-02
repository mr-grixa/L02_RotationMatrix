using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace L02_RotationMatrix
{
    public partial class Form1 : Form
    {
        Point3D[] points;
        Color[] randomColors;
        public Form1()
        {
            InitializeComponent();
            radioButton_perspective.Checked = true;
        }

        private void Draw()
        {
            if (randomColors==null|| randomColors.Length != points.Length)
            {
                randomColors = new Color[points.Length];
                Random random = new Random();
                for (int i = 0; i < randomColors.Length; i++)
                {
                    randomColors[i] = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                }
            }
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
            points = GenerateRandomPoints((int)UpDownCout.Value);
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
                graphics.Clear(Color.MidnightBlue);
            }

            // параметры проекции
            const float near = 4f;  // расстояние до ближней плоскости отсечения
            const float far = 5f;   // расстояние до дальней плоскости отсечения
            const float fov = 90f;  // угол обзора камеры (Field of View)
            float aspect = (float)bmp.Height / bmp.Width; // соотношение сторон битмапа

            // координаты камеры
            float camX = (float)numericUpDownX.Value;
            float camY = (float)numericUpDownY.Value;
            float camZ = (float)numericUpDownZ.Value;

            // проекционная матрица
            Matrix4x4 projectionMatrix = Matrix4x4.CreatePerspectiveFieldOfView(
                (float)numericUpDown2.Value * (float)Math.PI / 180.0f,
                aspect,
                (float)numericUpDown4.Value,
                (float)numericUpDown5.Value);
            //fov * (float)Math.PI / 180.0f, aspect, near, far);

            // модельно-видовая матрица
            Matrix4x4 viewMatrix = Matrix4x4.CreateTranslation(-camX, -camY, -camZ);

            // углы
            float angleX = (float)numericUpDownRX.Value * (float)Math.PI / 180.0f;
            float angleY = (float)numericUpDownRY.Value * (float)Math.PI / 180.0f;
            float angleZ = (float)numericUpDownRZ.Value * (float)Math.PI / 180.0f;
            // Вычисление тригонометрических функций углов поворота
            float cosX = (float)Math.Cos(angleX);
            float cosY = (float)Math.Cos(angleY);
            float cosZ = (float)Math.Cos(angleZ);
            float sinX = (float)Math.Sin(angleX);
            float sinY = (float)Math.Sin(angleY);
            float sinZ = (float)Math.Sin(angleZ);

            // Создание матрицы поворота
            Matrix4x4 rotationMatrix = new Matrix4x4();
            rotationMatrix.M11 = cosY * cosZ;
            rotationMatrix.M12 = -cosY * sinZ;
            rotationMatrix.M13 = sinY;
            rotationMatrix.M14 = 0f;
            rotationMatrix.M21 = sinX * sinY * cosZ + cosX * sinZ;
            rotationMatrix.M22 = -sinX * sinY * sinZ + cosX * cosZ;
            rotationMatrix.M23 = -sinX * cosY;
            rotationMatrix.M24 = 0f;
            rotationMatrix.M31 = -cosX * sinY * cosZ + sinX * sinZ;
            rotationMatrix.M32 = cosX * sinY * sinZ + sinX * cosZ;
            rotationMatrix.M33 = cosX * cosY;
            rotationMatrix.M34 = 0f;
            rotationMatrix.M41 = 0f;
            rotationMatrix.M42 = 0f;
            rotationMatrix.M43 = 0f;
            rotationMatrix.M44 = 1f;

            // Применение матрицы преобразования координат к каждой точке
            for (int i = 0; i < points.Length; i++)
            {
                Vector3 point = new Vector3(
                    (float)points[i].x,
                    (float)points[i].y,
                    (float)points[i].z);
                // перспективное преобразование координат
                Vector3 transformedPoint = Vector3.Transform(point, projectionMatrix * viewMatrix * rotationMatrix);

                // int colorValue = (int)Math.Round(255 * (points[i].z + 1) / 2,MidpointRounding.);
                int px = (int)Math.Round((transformedPoint.X + 1) / 2 * (bmp.Width - 1));
                int py = (int)Math.Round((transformedPoint.Y + 1) / 2 * (bmp.Height - 1));

                if (px > 0 && px < 600 && py > 0 && py < 600)
                {
                    //Color color = Color.FromArgb(colorValue, colorValue, colorValue);
                    bmp.SetPixel(px, py, randomColors[i]);

                }

            }
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.DrawLine(Pens.Red, 0, 300, 600, 300);
                graphics.DrawLine(Pens.Green, 300, 0, 300, 600);
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


        private void Draw_Changed(object sender, EventArgs e)
        {
            if (points != null)
            {
                Draw();
            }

        }
    }
}
