using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AlgoritmsCourse
{
    public partial class Form1 : Form
    {
        static List<int> mainList = new List<int>();
        static List<int> sortList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Прямой обмен");
            dataGridView1.Rows.Add("Прямое включение");
            dataGridView1.Rows.Add("Прямой выбор");
        }

        /* СОЗДАНИЕ РАЗНЫХ ВИДОВ СПИСКА */

        // Неупорядоченный список
        static void generate1(int size)
        {
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                mainList.Add(rnd.Next(0, size));
            }
        }

        // Упорядоченный список
        static void generate2(int size)
        {
            Random rnd = new Random();

            for (int i = 0, current = 0; i < size; i++)
            {
                if (current + 4 < size)
                {
                    mainList.Add(rnd.Next(0, 5) + current);
                    current = mainList[i];
                }
                else
                {
                    mainList.Add(size);
                }
            }
        }

        // Упорядоченный в обратном порядке список
        static void generate3(int size)
        {
            Random rnd = new Random();

            for (int i = 0, current = size; i < size; i++)
            {
                if (current - 4 > 0)
                {
                    mainList.Add(current - rnd.Next(0, 5));
                    current = mainList[i];
                }
                else
                {
                    mainList.Add(0);
                }
            }
        }

        // Частично упорядоченный список
        static void generate4(int size, int procent)
        {
            Random rnd = new Random();

            int index = procent * size / 100;
            for (int i = 0, current = 0; i < size; i++)
            {
                if (i < index)
                {
                    if (current + 4 < size)
                    {
                        mainList.Add(rnd.Next(0, 5) + current);
                        current = mainList[i];
                    }
                    else
                    {
                        mainList.Add(size);
                    }
                }
                else
                {
                    mainList.Add(rnd.Next(0, size));
                }
            }
        }

        // Алгоритмы сортировок 

        // Метод прямого включения
        void directInsert(int Size)
        {
            int i, j, k;
            for (i = 1; i < Size; i++)
            {
                k = sortList[i];
                j = i - 1; 
                while (j >= 0 && k < sortList[j])
                {
                    sortList[j + 1] = sortList[j];
                    j--; 
                }
                sortList[j + 1] = k;
            }
        }

        // Сортировка бинарными вставками
        void binInsert(int Size) 
        {
            int x, left, right, sred;
            for (int i = 1; i < Size; i++)
            {
                if (sortList[i - 1] > sortList[i])
                {
                    x = sortList[i];
                    left = 0; 
                    right = i - 1;
                    do
                    {
                        sred = (left + right) / 2; 
                        if (sortList[sred] < x) left = sred + 1;
                        else right = sred - 1;
                    } while (left <= right); 
                    for (int j = i - 1; j >= left; j--) sortList[j + 1] = sortList[j];
                    sortList[left] = x;
                }
            }

        }

        // Вычисление длин промежутков,для сортировки методом Шелла,предложенный Седжвиком метод
        int increment(int[] inc)
        {
            int p1 = 1, p2 = 1,p3 = 1, s = -1;
            do
            {
                if (++s % 2 == 0)
                {
                    inc[s] = 8 * p1 - 6 * p2 + 1;
                }
                else
                {
                    inc[s] = 9 * p1 - 9 * p3 + 1;
                    p2 *= 2;
                    p3 *= 2;
                }
                p1 *= 2;
            } while (3 * inc[s] < inc.Length);

            return s > 0 ? --s : 0;
        }
        //Сортировка методом Шелла
        void shellSort(int Size)
        {
            int inc, i, j;
            int[] seq = new int[40];

            int s = increment(seq);
            while (s >= 0)
            {
                inc = seq[s--];

                for (i = inc; i < Size; i++)
                {
                    int temp = sortList[i];
                    for (j = i - inc; (j >= 0) && (sortList[j] > temp); j -= inc)
                        sortList[j + inc] = sortList[j];
                    sortList[j + inc] = temp;
                }
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Max_List_Size = (int)arraySize.Value;

            if (Max_List_Size == 0)
            {
                MessageBox.Show("Неверный размер линейного списка!");
                return;

            }
            int Procent = (int)sortPercent.Value;
            bool radbut1 = notSortedRadio.Checked;
            bool radbut2 = sortedRadio.Checked;
            bool radbut3 = backSortedRadio.Checked;
            bool radbut4 = percentSortRadio.Checked;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, 0);
            chart1.Series[1].Points.Clear();
            chart1.Series[1].Points.AddXY(0, 0);
            chart1.Series[2].Points.Clear();
            chart1.Series[2].Points.AddXY(0, 0);
           // Проверка radioButton
            if (radbut1)
            {
                generate1(Max_List_Size);
            }
            else if (radbut2)
            {
                generate2(Max_List_Size);
            }
            else if (radbut3)
            {
                generate3(Max_List_Size);
            }
            else if (radbut4)
            {
                generate4(Max_List_Size, Procent);
            }
            else
            {
                MessageBox.Show("Не выбран тип списка!");
                return;
            }
            for (int numSort = 0; numSort < 3; numSort++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int index;
                    if (i == 10)
                    {
                        index = Max_List_Size;
                    }
                    else
                    {
                        index = Max_List_Size / 10 * i;
                    }

                    // Заполнение списка для сортировок
                    for (int j = 0; j < index; j++)
                    {
                        sortList.Add(mainList[j]);
                    }
                    switch (numSort)
                    {
                        case 0:
                            int startTime0 = Environment.TickCount;
                            directInsert(index);
                            int time0 = Environment.TickCount - startTime0;
                            dataGridView1.Rows[numSort].Cells[i].Value = (time0).ToString();
                            chart1.Series[numSort].Points.AddXY(index, time0);
                            break;
                       case 1:
                            int startTime1 = Environment.TickCount;
                            binInsert(index);
                            int time1 = Environment.TickCount - startTime1;
                            dataGridView1.Rows[numSort].Cells[i].Value = (time1).ToString();
                            chart1.Series[numSort].Points.AddXY(index, time1);
                            break;
                        case 2:
                            int startTime2 = Environment.TickCount;
                            shellSort(index);
                            int time2 = Environment.TickCount - startTime2;
                            dataGridView1.Rows[numSort].Cells[i].Value = (time2).ToString();
                            chart1.Series[numSort].Points.AddXY(index, time2);
                            break;
                    }

                    sortList.Clear();
                }
            }
            mainList.Clear();
        }
    }
}
