﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Показать диалоговое окно «Открыть файл».
            //Если пользователь нажимает OK, загружается изображение, выбранное пользователем.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Очистите изображение
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Показать диалоговое окно цвета. Если пользователь нажимает OK,
            // измените фон элемента управления PictureBox на выбранный пользователем цвет.
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Закрыть форму
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Если пользователь устанавливает флажок «Растянуть»,
            // измените свойство SizeMode PictureBox 
            // на «Растянуть». Если пользователь 
            // снимает флажок, измените его на «Обычный».
            if (checkBox1.Checked) 
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            else pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
