using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Screen : Form
    {
        int[,] Peremennaya_2kras; // Двумерный массив, хранящий красные клетки
        int[,] Peremennaya_2kras_new; // Двумерный массив, заносящий новые поколения красных клеток
        int[,] Peremennaya_2sin; // Двумерный массив, хранящий синие клетки
        int[,] Peremennaya_2sin_new; // Двумерный массив, заносящий новые поколения синих клеток
        int Peremennaya_vremeni = 1; // Переменная для времени
        bool Peremennaya_vibor_cveta = false; // Переменная отвечающая за выбор цвета
        // False - красный 
        // True - синий
        int Peremennaya_razmer_carti = 30;

        private void button1_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false; // Выключение таймера
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true; // Включение таймера
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Peremennaya_vibor_cveta = false;  // False - красный 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Peremennaya_vibor_cveta = true; // True - синий
        }

        void Funkciya_zhizn_kras()   //  Функция размножения красных клеток
        {
            //  Переменные определяющие индекс клеток
            int Peremennaya_Levo, Peremennaya_Pravo, Peremennaya_Verh, Peremennaya_Vniz, Peremennaya_zhizni; // "Peremennaya_zhizni" определяет количество живых клеток рядом с клеткой
            for (int Peremennaya_k = 0; Peremennaya_k < Peremennaya_razmer_carti; Peremennaya_k++)      
                for (int Peremennaya_g = 0; Peremennaya_g < Peremennaya_razmer_carti; Peremennaya_g++)
                { 
                    if (Peremennaya_k != 0) // Если не первый столбец в поле
                        Peremennaya_Levo = Peremennaya_k - 1;
                    else
                        Peremennaya_Levo = Peremennaya_razmer_carti - 1;
                    if (Peremennaya_k != Peremennaya_razmer_carti - 1) // Если не последний столбец в поле
                        Peremennaya_Pravo = Peremennaya_k + 1;
                    else
                        Peremennaya_Pravo = 0;
                    if (Peremennaya_g != 0) // Если не верхняя строка 
                        Peremennaya_Verh = Peremennaya_g - 1;
                    else
                        Peremennaya_Verh = Peremennaya_razmer_carti - 1;
                    if (Peremennaya_g != Peremennaya_razmer_carti - 1) // Если не нижняя строка 
                        Peremennaya_Vniz = Peremennaya_g + 1;
                    else
                        Peremennaya_Vniz = 0;
                    Peremennaya_zhizni = 0;
                    // Подсчет живых клеток вокруг
                    Peremennaya_zhizni += Peremennaya_2kras[Peremennaya_k, Peremennaya_Verh];
                    Peremennaya_zhizni += Peremennaya_2kras[Peremennaya_k, Peremennaya_Vniz];
                    Peremennaya_zhizni += Peremennaya_2kras[Peremennaya_Levo, Peremennaya_g];
                    Peremennaya_zhizni += Peremennaya_2kras[Peremennaya_Pravo, Peremennaya_g];
                    Peremennaya_zhizni += Peremennaya_2kras[Peremennaya_Levo, Peremennaya_Verh];
                    Peremennaya_zhizni += Peremennaya_2kras[Peremennaya_Levo, Peremennaya_Vniz];
                    Peremennaya_zhizni += Peremennaya_2kras[Peremennaya_Pravo, Peremennaya_Verh];
                    Peremennaya_zhizni += Peremennaya_2kras[Peremennaya_Pravo, Peremennaya_Vniz];
                    // Если вокруг три живых клетки и клетка пуста
                    if (Peremennaya_zhizni == 3 && Peremennaya_2kras[Peremennaya_k, Peremennaya_g] == 0)  
                        Peremennaya_2kras_new[Peremennaya_k, Peremennaya_g] = 1; // Клетка становится живой
                    // Если вокруг > 2 или  < 3 клеток и клетка живая
                    else if ((Peremennaya_zhizni < 2 || Peremennaya_zhizni > 3) && (Peremennaya_2kras[Peremennaya_k, Peremennaya_g] == 1))
                        Peremennaya_2kras_new[Peremennaya_k, Peremennaya_g] = 0; // Peremennaya_kлетка R.I.P.
                    else
                        Peremennaya_2kras_new[Peremennaya_k, Peremennaya_g] = Peremennaya_2kras[Peremennaya_k, Peremennaya_g]; // Иначе клетка в стагнации
                }
        }

        void Funkciya_zhizn_sin() // Функция размножения синих клеток
        {
            int Peremennaya_Levo, Peremennaya_Pravo, Peremennaya_Verh, Peremennaya_Vniz, Peremennaya_zhizni;
            for (int Peremennaya_i = 0; Peremennaya_i < Peremennaya_razmer_carti; Peremennaya_i++)
                for (int Peremennaya_j = 0; Peremennaya_j < Peremennaya_razmer_carti; Peremennaya_j++)
                {
                    if (Peremennaya_i != 0) // Если не первый столбец в поле
                        Peremennaya_Levo = Peremennaya_i - 1;
                    else
                        Peremennaya_Levo = Peremennaya_razmer_carti - 1;
                    if (Peremennaya_i != Peremennaya_razmer_carti - 1) // Если не последний столбец в поле
                        Peremennaya_Pravo = Peremennaya_i + 1;
                    else
                        Peremennaya_Pravo = 0;
                    if (Peremennaya_j != 0) // Если не верхняя строка 
                        Peremennaya_Verh = Peremennaya_j - 1;
                    else
                        Peremennaya_Verh = Peremennaya_razmer_carti - 1;
                    if (Peremennaya_j != Peremennaya_razmer_carti - 1)  // Если не нижняя строка  
                        Peremennaya_Vniz = Peremennaya_j + 1;
                    else
                        Peremennaya_Vniz = 0;
                    Peremennaya_zhizni = 0;
                    // Подсчет живых клеток вокруг
                    Peremennaya_zhizni += Peremennaya_2sin[Peremennaya_i, Peremennaya_Verh];
                    Peremennaya_zhizni += Peremennaya_2sin[Peremennaya_i, Peremennaya_Vniz];
                    Peremennaya_zhizni += Peremennaya_2sin[Peremennaya_Levo, Peremennaya_j];
                    Peremennaya_zhizni += Peremennaya_2sin[Peremennaya_Pravo, Peremennaya_j];
                    Peremennaya_zhizni += Peremennaya_2sin[Peremennaya_Levo, Peremennaya_Verh];
                    Peremennaya_zhizni += Peremennaya_2sin[Peremennaya_Levo, Peremennaya_Vniz];
                    Peremennaya_zhizni += Peremennaya_2sin[Peremennaya_Pravo, Peremennaya_Verh];
                    Peremennaya_zhizni += Peremennaya_2sin[Peremennaya_Pravo, Peremennaya_Vniz];
                    // Если вокруг три живых клетки и клетка пуста
                    if (Peremennaya_zhizni == 3 && Peremennaya_2sin[Peremennaya_i, Peremennaya_j] == 0)
                        Peremennaya_2sin_new[Peremennaya_i, Peremennaya_j] = 1;
                    // Если вокруг > 2 или  < 3 клеток и клетка живая
                    else if ((Peremennaya_zhizni < 2 || Peremennaya_zhizni > 3) && (Peremennaya_2sin[Peremennaya_i, Peremennaya_j] == 1))
                        Peremennaya_2sin_new[Peremennaya_i, Peremennaya_j] = 0; // Peremennaya_kлетка R.I.P.
                    else
                        Peremennaya_2sin_new[Peremennaya_i, Peremennaya_j] = Peremennaya_2sin[Peremennaya_i, Peremennaya_j]; // Иначе клетка в стагнации
                }
        }

        void Funkciya_smen_kras_pokoleniy() // Функция приравнивания нынешнего поколения следующему
        {
            for (int Peremennaya_k = 0; Peremennaya_k < Peremennaya_razmer_carti; Peremennaya_k++)
                for (int Peremennaya_g = 0; Peremennaya_g < Peremennaya_razmer_carti; Peremennaya_g++)
                    Peremennaya_2kras[Peremennaya_k, Peremennaya_g] = Peremennaya_2kras_new[Peremennaya_k, Peremennaya_g];
        }

        void Funkciya_smen_sin_pokoleniy() // Функция приравнивания нынешнего поколения следующему
        {
            for (int Peremennaya_i = 0; Peremennaya_i < Peremennaya_razmer_carti; Peremennaya_i++)
                for (int Peremennaya_j = 0; Peremennaya_j < Peremennaya_razmer_carti; Peremennaya_j++)
                    Peremennaya_2sin[Peremennaya_i, Peremennaya_j] = Peremennaya_2sin_new[Peremennaya_i, Peremennaya_j];
        }

        void Funkciya_otrisovki_kras() // Отображение красных клеток
        {
            for (int Peremennaya_i = 0; Peremennaya_i < Peremennaya_razmer_carti; Peremennaya_i++)
                for (int Peremennaya_j = 0; Peremennaya_j < Peremennaya_razmer_carti; Peremennaya_j++)
                {
                    // Если в данной ячейке поля красная клетка жива и синяя мертва
                    if (Peremennaya_2kras[Peremennaya_i, Peremennaya_j] == 1 && Peremennaya_2sin[Peremennaya_i, Peremennaya_j] == 0) 
                        MapIsLife[Peremennaya_j, Peremennaya_i].Style.BackColor = System.Drawing.Color.Red; // Ячейка красная
                    // Если в ячейке красная мертва и синяя живы
                    else if (Peremennaya_2kras[Peremennaya_i, Peremennaya_j] == 0 && Peremennaya_2sin[Peremennaya_i, Peremennaya_j] == 1)
                        MapIsLife[Peremennaya_j, Peremennaya_i].Style.BackColor = System.Drawing.Color.Blue; // Ячейка синяя
                    // Если в ячейке красная и синяя жива
                    else if (Peremennaya_2kras[Peremennaya_i, Peremennaya_j] == 1 && Peremennaya_2sin[Peremennaya_i, Peremennaya_j] == 1) 
                    {
                        Peremennaya_2sin[Peremennaya_i, Peremennaya_j] = 0; // Синяя клетка умирает
                        MapIsLife[Peremennaya_j, Peremennaya_i].Style.BackColor = System.Drawing.Color.Red; // Ячейка красная
                    }
                    else
                        MapIsLife[Peremennaya_j, Peremennaya_i].Style.BackColor = System.Drawing.Color.White; // Иначе ячейка белая
                }
            MapIsLife.Refresh();
        }

        void Funkciya_otrisovki_sin() // Отображение синих клеток
        {
            for (int Peremennaya_i = 0; Peremennaya_i < Peremennaya_razmer_carti; Peremennaya_i++)
                for (int Peremennaya_j = 0; Peremennaya_j < Peremennaya_razmer_carti; Peremennaya_j++)
                {
                    // Если в данной ячейке поля синяя жива и красная мертва
                    if (Peremennaya_2sin[Peremennaya_i, Peremennaya_j] == 1 && Peremennaya_2kras[Peremennaya_i, Peremennaya_j] == 0)
                        MapIsLife[Peremennaya_j, Peremennaya_i].Style.BackColor = System.Drawing.Color.Blue; //ячейка синяя
                    // Если синяя клетка мертва и красная жива
                    else if(Peremennaya_2sin[Peremennaya_i, Peremennaya_j] == 0 && Peremennaya_2kras[Peremennaya_i, Peremennaya_j] == 1)
                        MapIsLife[Peremennaya_j, Peremennaya_i].Style.BackColor = System.Drawing.Color.Red; //ячейка красная
                    // Если красная и синяя живы
                    else if (Peremennaya_2kras[Peremennaya_i, Peremennaya_j] == 1 && Peremennaya_2sin[Peremennaya_i, Peremennaya_j] == 1)
                    {
                        Peremennaya_2kras[Peremennaya_i, Peremennaya_j] = 0; // Красная клетка умирает
                        MapIsLife[Peremennaya_j, Peremennaya_i].Style.BackColor = System.Drawing.Color.Blue; // Ячейка синяя
                    }
                    else
                        MapIsLife[Peremennaya_j, Peremennaya_i].Style.BackColor = System.Drawing.Color.White; // Иначе ячейка белая
                }
        }

        public Screen() // Свойства экрана
        {
            InitializeComponent();
            Peremennaya_2kras = new int[Peremennaya_razmer_carti, Peremennaya_razmer_carti]; // Определение размера массива 
            Peremennaya_2sin = new int[Peremennaya_razmer_carti, Peremennaya_razmer_carti]; // Определение размера массива
            Peremennaya_2kras_new = new int[Peremennaya_razmer_carti, Peremennaya_razmer_carti]; // Определение размера массива
            Peremennaya_2sin_new = new int[Peremennaya_razmer_carti, Peremennaya_razmer_carti]; // Определение размера массива
            MapIsLife.ColumnCount = Peremennaya_razmer_carti; // Количество столбцов поля
            MapIsLife.RowCount = Peremennaya_razmer_carti; // Количество строк в поле
            MapIsLife.ReadOnly = true; // Запрет на изменение данных в ячейках 
            MapIsLife.AllowUserToDeleteRows = false; // Запрещает пользователю удалять строки
            MapIsLife.RowHeadersVisible = false; // Убирает столбец показыающий, что происходит со строками
            MapIsLife.AllowUserToResizeColumns = false; // Запрещает пользователю менять размер столбцов
            MapIsLife.AllowUserToResizeRows = false; // Запрещает пользователю менять размер полей
            for (int Peremennaya_i = 0; Peremennaya_i < Peremennaya_razmer_carti; Peremennaya_i++)
            {
                MapIsLife.Columns[Peremennaya_i].Width = 20; // Ширина ячеек в поле
                MapIsLife.Rows[Peremennaya_i].Height = 20; // Высота ячеек в поле
                MapIsLife.Columns[Peremennaya_i].SortMode = DataGridViewColumnSortMode.NotSortable; // Отключает сортировку столбца
                for (int Peremennaya_j = 0; Peremennaya_j < Peremennaya_razmer_carti; Peremennaya_j++)
                {
                    Peremennaya_2kras[Peremennaya_i, Peremennaya_j] = 0;
                    Peremennaya_2sin[Peremennaya_i, Peremennaya_j] = 0;
                    Peremennaya_2kras_new[Peremennaya_i, Peremennaya_j] = 0;
                    Peremennaya_2sin_new[Peremennaya_i, Peremennaya_j] = 0;
                }
            }
            MapIsLife.ColumnHeadersVisible = false; // Удаление заголовков
        }

        private void Stop_Click(object sender, EventArgs e) 
        {
            if (Timer.Enabled) // Если таймер включен 
                Timer.Enabled = false; // Таймер выключается
            else 
                Timer.Enabled = true; // Иначе включается
        }

        private void PoleLife_CellClick(object sender, DataGridViewCellEventArgs e) // Событие клик по ячейке
        {
            if (Peremennaya_vibor_cveta == false) // Если выбран красный
            {
                if (MapIsLife[e.ColumnIndex, e.RowIndex].Style.BackColor != System.Drawing.Color.Red) // Если не красная
                {
                    MapIsLife[e.ColumnIndex, e.RowIndex].Style.BackColor = System.Drawing.Color.Red; // Она становится красной
                    Peremennaya_2kras[e.RowIndex, e.ColumnIndex] = 1; // Красная ячейка становится живой
                    Peremennaya_2sin[e.RowIndex, e.ColumnIndex] = 0; // Синяя ячейка становится мёртвой
                }
                else
                {
                    MapIsLife[e.ColumnIndex, e.RowIndex].Style.BackColor = System.Drawing.Color.White; // Она становится белой
                    Peremennaya_2kras[e.RowIndex, e.ColumnIndex] = 0; // Красная ячейка становится мёртвой
                    Peremennaya_2sin[e.RowIndex, e.ColumnIndex] = 0; // Синяя ячейка становится мёртвой
                }
            }
            else if (Peremennaya_vibor_cveta == true) // Если выбран синий
            {
                if (MapIsLife[e.ColumnIndex, e.RowIndex].Style.BackColor != System.Drawing.Color.Blue) // Если ячейка не синяя
                {
                    MapIsLife[e.ColumnIndex, e.RowIndex].Style.BackColor = System.Drawing.Color.Blue; // Она становится синей
                    Peremennaya_2kras[e.RowIndex, e.ColumnIndex] = 0; // Красная ячейка становится мёртвой
                    Peremennaya_2sin[e.RowIndex, e.ColumnIndex] = 1; // Синяя ячейка становится живой
                }
                else
                {
                    MapIsLife[e.ColumnIndex, e.RowIndex].Style.BackColor = System.Drawing.Color.White; // Она становится белой
                    Peremennaya_2kras[e.RowIndex, e.ColumnIndex] = 0; // Красная ячейка становится мёртвой
                    Peremennaya_2sin[e.RowIndex, e.ColumnIndex] = 0; // Синяя ячейка становится мёртвой
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Вызываем все функции
            Peremennaya_vremeni += 1;
            Race.Text = "Время: " + Convert.ToString(Peremennaya_vremeni);
            Funkciya_zhizn_kras();
            Funkciya_smen_kras_pokoleniy();
            Funkciya_zhizn_sin();
            Funkciya_smen_sin_pokoleniy();
            Funkciya_otrisovki_kras();
            Funkciya_otrisovki_sin();
        }
    }
}
