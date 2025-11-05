using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace ImageConverter
{
    public partial class MainForm : Form
    {
        // Переменная для хранения пути к выбранному изображению
        private string imagePath;

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
