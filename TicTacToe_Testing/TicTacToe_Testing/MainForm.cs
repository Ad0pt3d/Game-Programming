
using System.Windows.Forms;

namespace TicTacToe_Testing
{
    public partial class MainForm : Form
    {
        private const int INIT_TOP = 50;
        private const int INIT_LEFT = 20;
        private const int WIDTH = 150;
        private const int HEIGHT = 150;
        private const int GAP = 10;

        private Bitmap circleImage;
        private Bitmap xImage;

        public MainForm()
        {
            InitializeComponent();
            InitializeGrid(3);
        }

        private void InitializeGrid(int numberOfRows)
        {
            int x = INIT_TOP;
            int y = INIT_LEFT;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Left = x;
                    pictureBox.Top = y;
                    pictureBox.Width = WIDTH;
                    pictureBox.Height = HEIGHT;
                    pictureBox.BackColor = Color.White;
                    pictureBox.Name = i.ToString() + "," + j.ToString();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    this.Controls.Add(pictureBox);

                    pictureBox.Click += B_Click;

                    x += pictureBox.Width + GAP;
                }
            }
        }

        private void B_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
