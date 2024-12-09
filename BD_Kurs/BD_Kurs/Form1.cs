using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BD_Kurs
{

    public partial class Form1 : Form
    {
        private Context _context;
        public Form1(Context context)
        {
            InitializeComponent();
            _context = context;
        }
        double de1;
        double trezubec = 0;
        int Z;
        double Y = 0;
        double x = 0;
        string Typ;
        int T1;
        string HB;
        string Opora;
        string zyb;
        int Kd;
        double Km = 0;
        float Kbe;
        double Khb;
        float u;
        int thi;
        double thiHP;
        string marka;
        double Khl;
        double Kfb;
        double Yitog = 0;
        int phi;
        double phiFP;
        double M = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Прямозубые", "Конические", "Тангециальные" });
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox3.Items.AddRange(new string[] { "Шариковые", "Роликовые" });
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
            comboBox4.Items.AddRange(new string[] { "Прямые/Танцегиальные", "Круговые" });
            comboBox4.SelectedIndexChanged += ComboBox4_SelectedIndexChanged;
            comboBox5.Items.AddRange(new string[] { "HB>350", "HB<=350" });
            comboBox5.SelectedIndexChanged += ComboBox5_SelectedIndexChanged;
            comboBox2.Items.AddRange(new object[] { 0.2, 0.4, 0.6, 0.8, 1 });
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            comboBox6.Items.AddRange(new object[] { 1.0, 1.25, 1.4, 1.6, 2.0, 2.5, 3.15, 4 });
            comboBox6.SelectedIndexChanged += ComboBox6_SelectedIndexChanged;
            comboBox7.Items.AddRange(new string[] { "Сталь 45", "Сталь 50Г", "Сталь 40X", "Сталь 40XH", "Сталь 20X" });
            comboBox7.SelectedIndexChanged += ComboBox7_SelectedIndexChanged;
        }
        // Обработчик события SelectedIndexChanged
        private void resh()
        {
            thiHP = thi * Khl;
            de1 = Kd * Math.Pow(T1 * Khb / ((1 - (Kbe / 10)) * (Kbe / 10) * (u / 100) * thiHP * thiHP), 1.0 / 3.0);
            de1 = Math.Round(de1, 2);
            Yitog = Y * Math.Pow(((2.2 + x) / 2.2), 2);
            trezubec = (Kbe / 10) / (2 - (Kbe / 10) * Math.Sin(phi));
            phiFP = (Math.Pow((Math.Pow(10, 7) / 60 * 5 * 3), 1 / 8)) * thi;
            M = Km * Math.Pow((T1 * Kfb * Yitog / (Z * Z * trezubec * (phiFP))), 1.0 / 3.0);
            M = Math.Round(M, 2);
            textBox1.Text = de1.ToString();
            textBox2.Text = M.ToString();
            // Добавляем запись в таблицу Det
            // Добавляем запись в таблицу Det
            Det det = new Det
            {
                Mаrka = marka,
                T1 = T1,
                de1 = de1,
                m = M
            };
            _context.Details.Add(det);
            _context.SaveChanges();  // Сохраняем и получаем ID

            // Получаем ID только что добавленного объекта
            int detId = det.ID;

            // Создаем объект Sborka с установленной связью с Det через DetId
            Sborka sborka = new Sborka
            {
                DetId = detId,  // Устанавливаем внешний ключ
                TypePer = Typ,
                TypeOpor = Opora,
                Kbe = Kbe,
                HB = HB,
                u = u,
                Mater = marka,
                Khb = Khb,
                Kfb = Kfb,
                Y = Yitog,
                x = x,
                Kd = Kd,
                Km = Km,
                Khl = Khl,
                thi = thi,
                thiHP = thiHP,
                z = Z
            };
            _context.Sborki.Add(sborka);
            _context.SaveChanges(); // Сохраняем изменения в Sborka

            // Создаем объект Itog с установленной связью с Det через DetId
            Itog qwe = new Itog
            {
                DetId = detId,  // Устанавливаем внешний ключ
                de1 = de1,
                m = M
            };
            _context.Itogi.Add(qwe);
            _context.SaveChanges(); // Сохраняем изменения в Itog
        }
        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сохраняем выбранное значение в переменную Typ
            u = 100 * Convert.ToSingle(comboBox6.SelectedItem);
            int[] p1 = { 43, 46, 44 };
            int[] p2 = { 38, 51, 39, 50 };
            int[] p3 = { 35, 54, 55 };
            int[] p4 = { 32, 57, 31, 58 };
            int[] p5 = { 25, 64, 26 };
            int[] p6 = { 21, 68, };
            int[] p7 = { 17, 72 };
            int[] p8 = { 14, 75 };
            int[] mys1 = { 21, 22, 28, 28 };
            int[] mys2 = { 19, 24, 24, 26 };
            int[] mys3 = { 18, 21, 22, 24 };
            int[] mys4 = { 17, 18, 23, 23 };
            int[] mys5 = { 15, 16, 20, 23 };
            int[] mys6 = { 15, 19, 19 };
            int[] mys7 = { 16, 16 };
            int[] mys8 = { 15, 15 };
            double[] mus1 = { 3.12, 3.42, 3.78 };
            double[] mus2 = { 3.12, 3.42, 3.78 };
            double[] mus3 = { 3.12, 3.42, 3.78 };
            double[] mus4 = { 3.15, 3.40, 3.72 };
            double[] mus5 = { 3.19, 3.39, 3.61, 3.89, 4.08, 4.28 };
            double[] mus6 = { 3.24, 3.39, 3.57, 3.77, 3.90, 4.05, 4.28 };
            double[] mus7 = { 3.29, 3.41, 3.54, 3.69, 3.78, 3.87, 4.08, 4.45 };
            double[] mus8 = { 3.33, 3.42, 3.53, 3.63, 3.70, 3.77, 3.92, 4.13 };
            int[] mas2 = { 61, 95, 122, 190 };
            int[] mas1 = { 47, 93, 135, 180 };
            int[] mas3 = { 50, 73, 101, 145 };
            int[] mas4 = { 41, 55, 113, 229 };
            int[] mas5 = { 49, 69, 99, 141 };
            int[] mas6 = { 71, 118, 157 };
            int[] mas7 = { 105, 152 };
            int[] mas8 = { 145, 207 };
            double[] mus = { 0.04, 0.08, 0.12, 0.16 };
            Random random1 = new Random();
            int randomnize = random1.Next(0, mus.Length);
            x = mus[randomnize];

            Random random = new Random();
            if (u == 100)
            {
                int randomIndex = random.Next(0, mas1.Length);
                T1 = mas1[randomIndex];
                int randomIndex1 = random.Next(0, mus1.Length);
                Y = mus1[randomIndex1];
                int randomIndex2 = random.Next(0, mys1.Length);
                Z = mys1[randomIndex2];
                int randomIndex3 = random.Next(0, p1.Length);
                phi = p1[randomIndex3];
            }
            if (u == 125)
            {
                int randomIndex = random.Next(0, mas2.Length);
                T1 = mas2[randomIndex];
                int randomIndex1 = random.Next(0, mus2.Length);
                Y = mus2[randomIndex1];
                int randomIndex2 = random.Next(0, mys2.Length);
                Z = mys2[randomIndex2];
                int randomIndex3 = random.Next(0, p2.Length);
                phi = p2[randomIndex3];
            }
            if (u == 140)
            {
                int randomIndex = random.Next(0, mas3.Length);
                T1 = mas3[randomIndex];
                int randomIndex1 = random.Next(0, mus3.Length);
                Y = mus3[randomIndex1];
                int randomIndex2 = random.Next(0, mys3.Length);
                Z = mys3[randomIndex2];
                int randomIndex3 = random.Next(0, p3.Length);
                phi = p3[randomIndex3];
            }
            if (u == 160)
            {
                int randomIndex = random.Next(0, mas4.Length);
                T1 = mas4[randomIndex];
                int randomIndex1 = random.Next(0, mus4.Length);
                Y = mus4[randomIndex1];
                int randomIndex2 = random.Next(0, mys4.Length);
                Z = mys4[randomIndex2];
                int randomIndex3 = random.Next(0, p4.Length);
                phi = p4[randomIndex3];
            }
            if (u == 200)
            {
                int randomIndex = random.Next(0, mas5.Length);
                T1 = mas5[randomIndex];
                int randomIndex1 = random.Next(0, mus5.Length);
                Y = mus5[randomIndex1];
                int randomIndex2 = random.Next(0, mys5.Length);
                Z = mys5[randomIndex2];
                int randomIndex3 = random.Next(0, p5.Length);
                phi = p5[randomIndex3];
            }
            if (u == 250)
            {
                int randomIndex = random.Next(0, mas6.Length);
                T1 = mas6[randomIndex];
                int randomIndex1 = random.Next(0, mus6.Length);
                Y = mus6[randomIndex1];
                int randomIndex2 = random.Next(0, mys6.Length);
                Z = mys6[randomIndex2];
                int randomIndex3 = random.Next(0, p6.Length);
                phi = p6[randomIndex3];
            }
            if (u == 315)
            {
                int randomIndex = random.Next(0, mas7.Length);
                T1 = mas7[randomIndex];
                int randomIndex1 = random.Next(0, mus7.Length);
                Y = mus7[randomIndex1];
                int randomIndex2 = random.Next(0, mys7.Length);
                Z = mys7[randomIndex2];
                int randomIndex3 = random.Next(0, p7.Length);
                phi = p7[randomIndex3];
            }
            if (u == 400)
            {
                int randomIndex = random.Next(0, mas8.Length);
                T1 = mas8[randomIndex];
                int randomIndex1 = random.Next(0, mus8.Length);
                Y = mus8[randomIndex1];
                int randomIndex2 = random.Next(0, mys8.Length);
                Z = mys8[randomIndex2];
                int randomIndex3 = random.Next(0, p8.Length);
                phi = p8[randomIndex3];
            }
            double randomValue = random.NextDouble();

            // Масштабируем в диапазон от 1.0 до 1.4
            double scaledValue = 1.0 + (randomValue * 0.4);
            Khl = scaledValue;

        }
        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            marka = comboBox7.SelectedItem.ToString();
            if (marka == "Сталь 45")
            {
                thi = 600;
            }
            if (marka == "Сталь 50Г")
            {
                thi = 800;
            }
            if (marka == "Сталь 40X")
            {
                thi = 900;
            }
            if (marka == "Сталь 40XH")
            {
                thi = 1000;
            }
            if (marka == "Сталь 20X")
            {
                thi = 1100;
            }


        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сохраняем выбранное значение в переменную Typ
            Typ = comboBox1.SelectedItem.ToString();
            if (Typ == "Прямозубые")
            {
                Kd = 1000;
                Km = 14.5;
            }
            if (Typ == "Конические")
            {
                Kd = 870;
                Km = 11;
            }
            if (Typ == "Тангециальные")
            {
                Kd = 835;
                Km = 10;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранное значение как float
            Kbe = 10 * Convert.ToSingle(comboBox2.SelectedItem);
        }
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сохраняем выбранное значение в переменную Typ
            Opora = comboBox3.SelectedItem.ToString();
        }
        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сохраняем выбранное значение в переменную Typ
            HB = comboBox5.SelectedItem.ToString();
            if (Opora == "Шариковые")
            {
                if (HB == "HB>350")
                {
                    if (zyb == "Прямые/Танцегиальные")
                    {
                        if (Kbe == 2)
                        {
                            Khb = 1.16;
                            Kfb = 1.25;
                        }
                        if (Kbe == 4)
                        {
                            Khb = 1.37;
                            Kfb = 1.55;
                        }
                        if (Kbe == 6)
                        {
                            Khb = 1.58;
                            Kfb = 1.92;
                        }
                        if (Kbe == 8)
                        {
                            Khb = 1.8;
                            Kfb = 1.92;
                        }
                        if (Kbe == 10)
                        {
                            Khb = 1.8;
                            Kfb = 1.92;
                        }
                    }
                    else
                    {
                        if (Kbe == 2)
                        {
                            Khb = 1.08;
                            Kfb = 1.13;
                        }
                        if (Kbe == 4)
                        {
                            Khb = 1.18;
                            Kfb = 1.27;
                        }
                        if (Kbe == 6)
                        {
                            Khb = 1.29;
                            Kfb = 1.45;
                        }
                        if (Kbe == 8)
                        {
                            Khb = 1.4;
                            Kfb = 1.45;
                        }
                        if (Kbe == 10)
                        {
                            Khb = 1.4;
                            Kfb = 1.45;
                        }
                    }
                }
                else
                {
                    if (zyb == "Прямые/Танцегиальные")
                    {
                        if (Kbe == 2)
                        {
                            Khb = 1.07;
                            Kfb = 1.13;
                        }
                        if (Kbe == 4)
                        {
                            Khb = 1.14;
                            Kfb = 1.29;
                        }
                        if (Kbe == 6)
                        {
                            Khb = 1.23;
                            Kfb = 1.47;
                        }
                        if (Kbe == 8)
                        {
                            Khb = 1.34;
                            Kfb = 1.70;
                        }
                        if (Kbe == 10)
                        {
                            Khb = 1.34;
                            Kfb = 1.70;
                        }
                    }
                    else
                    {
                        if (Kbe == 2)
                        {
                            Khb = 1;
                            Kfb = 1.07;
                        }
                        if (Kbe == 4)
                        {
                            Khb = 1;
                            Kfb = 1.15;
                        }
                        if (Kbe == 6)
                        {
                            Khb = 1;
                            Kfb = 1.23;
                        }
                        if (Kbe == 8)
                        {
                            Khb = 1;
                            Kfb = 1.33;
                        }
                        if (Kbe == 10)
                        {
                            Khb = 1;
                            Kfb = 1.33;
                        }
                    }
                }
            }
            // роликовые Khb
            else
            {
                if (HB == "HB>350")
                {
                    if (zyb == "Прямые/Танцегиальные")
                    {
                        if (Kbe == 2)
                        {
                            Khb = 1.08;
                            Kfb = 1.15;
                        }
                        if (Kbe == 4)
                        {
                            Khb = 1.20;
                            Kfb = 1.30;
                        }
                        if (Kbe == 6)
                        {
                            Khb = 1.32;
                            Kfb = 1.48;
                        }
                        if (Kbe == 8)
                        {
                            Khb = 1.44;
                            Kfb = 1.67;
                        }
                        if (Kbe == 10)
                        {
                            Khb = 1.55;
                            Kfb = 1.90;
                        }
                    }
                    else
                    {
                        if (Kbe == 2)
                        {
                            Khb = 1.04;
                            Kfb = 1.07;
                        }
                        if (Kbe == 4)
                        {
                            Khb = 1.10;
                            Kfb = 1.15;
                        }
                        if (Kbe == 6)
                        {
                            Khb = 1.15;
                            Kfb = 1.24;
                        }
                        if (Kbe == 8)
                        {
                            Khb = 1.22;
                            Kfb = 1.34;
                        }
                        if (Kbe == 10)
                        {
                            Khb = 1.28;
                            Kfb = 1.43;
                        }
                    }
                }
                else
                {
                    if (zyb == "Прямые/Танцегиальные")
                    {
                        if (Kbe == 2)
                        {
                            Khb = 1.04;
                            Kfb = 1.08;
                        }
                        if (Kbe == 4)
                        {
                            Khb = 1.08;
                            Kfb = 1.15;
                        }
                        if (Kbe == 6)
                        {
                            Khb = 1.13;
                            Kfb = 1.25;
                        }
                        if (Kbe == 8)
                        {
                            Khb = 1.18;
                            Kfb = 1.35;
                        }
                        if (Kbe == 10)
                        {
                            Khb = 1.23;
                            Kfb = 1.45;
                        }
                    }
                    else
                    {
                        if (Kbe == 2)
                        {
                            Khb = 1;
                            Kfb = 1.04;
                        }
                        if (Kbe == 4)
                        {
                            Khb = 1;
                            Kfb = 1.08;
                        }
                        if (Kbe == 6)
                        {
                            Khb = 1;
                            Kfb = 1.12;
                        }
                        if (Kbe == 8)
                        {
                            Khb = 1;
                            Kfb = 1.17;
                        }
                        if (Kbe == 10)
                        {
                            Khb = 1;
                            Kfb = 1.22;
                        }
                    }
                }
            }
        }
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сохраняем выбранное значение в переменную Typ
            zyb = comboBox4.SelectedItem.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                de1 = 122.76;
                M = 3.82;
                textBox1.Text = de1.ToString();
                textBox2.Text = M.ToString();
                Typ = "Прямозубые";
                Opora = "Шариковые";
                zyb = "Прямые/Танцегиальные";
                HB = "HB>350";
                Kbe = 2;
                u = Convert.ToSingle(1.0);
                marka = "Сталь 45";
            }
            else
            {
                // Выполняем расчет
                resh();
            }
            // Проверяем, выбраны ли значения в ComboBox, если нет — задаем значение по умолчанию.
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.SelectedItem = "Прямозубые"; // Значение по умолчанию для comboBox1
            }

            if (comboBox3.SelectedItem == null)
            {
                comboBox3.SelectedItem = "Шариковые"; // Значение по умолчанию для comboBox3
            }

            if (comboBox4.SelectedItem == null)
            {
                comboBox4.SelectedItem = "Прямые/Танцегиальные"; // Значение по умолчанию для comboBox4
            }

            if (comboBox5.SelectedItem == null)
            {
                comboBox5.SelectedItem = "HB>350"; // Значение по умолчанию для comboBox5
            }

            if (comboBox2.SelectedItem == null)
            {
                comboBox2.SelectedItem = 0.2; // Значение по умолчанию для comboBox2
            }

            if (comboBox6.SelectedItem == null)
            {
                comboBox6.SelectedItem = 1.0; // Значение по умолчанию для comboBox6
            }

            if (comboBox7.SelectedItem == null)
            {
                comboBox7.SelectedItem = "Сталь 45"; // Значение по умолчанию для comboBox7
            }
            // Запись в файл

            using (StreamWriter writer = new StreamWriter("C:\\Users\\vladi\\source\\repos\\BD Kursach\\BD Kursach\\Bd.txt", true)) // true для добавления в файл
            {
                writer.WriteLine($"Тип передачи:{Typ}");
                writer.WriteLine($"Тип опоры:{Opora}");
                writer.WriteLine($"Тип зубьев:{zyb}");
                writer.WriteLine($"Коэффициент ширины зубчатого венца (Kbe):{Kbe}");
                writer.WriteLine($"Твердость рабочих поверхностей:{HB}");
                writer.WriteLine($"Передаточное число:{u}");
                writer.WriteLine($"Материал и Марка:{marka}");
                writer.WriteLine("Рассчёт:");
                writer.WriteLine($"Внешний делительный диаметр(de1): {de1}");
                writer.WriteLine($"Средний нормальный модуль (m): {M}");
                writer.WriteLine("///////////////////////////////////////////////////////////");

            }

        }

    }
}
