using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILAEV_PRACT_DEDA_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button[] arr_b = new Button[0];
        private bool check = false;

        private void Buttons()
        {
            int buttons = 3;

            int widthSize = ClientSize.Width;
            int heightSize = ClientSize.Height;

            int oneWidthSize = widthSize / buttons;
            int oneHeightSize = heightSize / buttons;

            int buttonWidthSize = oneWidthSize;
            int buttonHeightSize = oneHeightSize;

            int spaceWidthSize = oneWidthSize;
            int spaceHegightSize = oneHeightSize;

            arr_b = new Button[0];

            for (int i = 0; i < buttons; i++)
            {
                for (int j = 0; j < buttons; j++)
                {
                    Array.Resize(ref arr_b, arr_b.Length + 1);
                    arr_b[i] = new Button();
                    arr_b[i].Location = new Point(oneWidthSize * (i), oneHeightSize * (j));
                    arr_b[i].Size = new Size(oneWidthSize, oneHeightSize);
                    Controls.Add(arr_b[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Buttons();
            check = true;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (check)
            {
                Controls.Clear();
                arr_b = new Button[0];
                Buttons();
            }
        }
    }
}
