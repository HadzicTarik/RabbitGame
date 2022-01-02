using System;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Windows.Forms;

namespace ZekaWinForm
{
    public partial class RabitGame : Form
    {
        private int dimenzijaMatrice;
        private int vrijemeTrajanjaIgre;
        private int br;
        private int brojPojedenihKupusa = 0;
        private int brojSkokova = 0;
        private bool goLeft, goUp, goRight, goDown, goRightD;
        private Random random = new Random();
        private string[] voce = new string[]{"KU","PA","SH","X"};
        private PictureBox zeka = new PictureBox();
        private TimeSpan startTime = new TimeSpan();
        private TimeSpan finishTime = new TimeSpan();

        public RabitGame(int dimenzijaMatrice, int vrijemeTrajanjaIgre)
        {
            InitializeComponent();

            this.dimenzijaMatrice = dimenzijaMatrice;
            this.vrijemeTrajanjaIgre = vrijemeTrajanjaIgre;

            startTime = DateTime.Now.TimeOfDay;
            finishTime = DateTime.Now.TimeOfDay + new TimeSpan(0, 0, vrijemeTrajanjaIgre);
            //rrr = DateTime.Now.TimeOfDay.Seconds + vrijemeTrajanjaIgre;
            //MessageBox.Show(finishTime.ToString());

            RabitGameElementProperty();
        }
        private void RabitGameElementProperty()
        {
            lblVrijemeIgranja.Text = this.vrijemeTrajanjaIgre.ToString();

            label1.Location = new Point(0, 0);
            lblBrojKupusa.Location = new Point(label1.Location.X + label1.Width, 0);
            label6.Location = new Point(this.Width / 2 - (label6.Width + lblBrojSkokova.Width) / 2, 0);
            lblBrojSkokova.Location = new Point(label6.Location.X + label6.Width, 0);
            label3.Location = new Point(this.Width - label3.Width - lblVrijemeIgranja.Width - 16, 0);
            lblVrijemeIgranja.Location = new Point(label3.Location.X + label3.Width, 0);

            panGamePlay.Location = new Point(2, label1.Height + 2);
            panGamePlay.Width = this.Width - 20;
            panGamePlay.Height = this.Height - label1.Height - 43;

            //Pen pen = new Pen(Color.Red, 1);
            int dsKvadrata = panGamePlay.Height / dimenzijaMatrice;
            int ostatak = panGamePlay.Height % dimenzijaMatrice;
            if (ostatak > 1)
            {
                panGamePlay.Width -= (ostatak - 1);
                panGamePlay.Height -= (ostatak - 1);
                this.Width -= (ostatak - 1);
                this.Height -= (ostatak - 1);
            }
            for (int i = 0; i < dimenzijaMatrice; i++)
            {
                for (int j = 0; j < dimenzijaMatrice; j++)
                {
                    Label label = new Label
                    {
                        Name = "Label" + i + j,
                        Tag = "povrce",
                        Text = voce[random.Next(voce.Length)],
                        ForeColor = Color.Yellow,
                        BackColor = Color.Transparent,
                        Location = new Point(j * dsKvadrata + 1, i * dsKvadrata + 1),
                        Font = new Font("Calibri", dsKvadrata / 5),
                        AutoSize = true
                    };
                    panGamePlay.Controls.Add(label);

                    if (i == 0 && j == 0)
                    {
                        zeka = new PictureBox
                        {
                            Name = "zeka",
                            Tag = "zeka",
                            BackColor = Color.Red,
                            Width = dsKvadrata / 4,
                            Height = dsKvadrata / 4,
                            Location = new Point(dsKvadrata / 2 - dsKvadrata / 8, dsKvadrata / 2 - dsKvadrata / 8)
                        };
                        GraphicsPath graphicsPath = new GraphicsPath();
                        graphicsPath.AddEllipse(0, 0, zeka.Height, zeka.Width);
                        Region region = new Region(graphicsPath);
                        zeka.Region = region;
                        panGamePlay.Controls.Add(zeka);
                    }
                    PictureBox polje = new PictureBox
                    {
                        Name = "polje" + i + j,
                        Tag = "polje",
                        BackColor = Color.Green,
                        Width = dsKvadrata - 1,
                        Height = dsKvadrata - 1,
                        Location = new Point(j * dsKvadrata + 1, i * dsKvadrata + 1),
                    };
                    panGamePlay.Controls.Add(polje);
                }
            }
        }
        private void RabitGameTimer_Event(object sender, EventArgs e)
        {
            ++br;
            if(br == 31)
            {
                br = 0;
                lblVrijemeIgranja.Text = (--vrijemeTrajanjaIgre).ToString();
            }

            int brzinaZeke = panGamePlay.Width / dimenzijaMatrice;
            
            if (finishTime < DateTime.Now.TimeOfDay)
            {
                RabitGameTimer.Stop();
                MessageBox.Show("Broj pojedenih kupusa: " + brojPojedenihKupusa.ToString() + "\n" +
                                "Broj skokova: " + brojSkokova.ToString() + "\nVrijeme trajanja igre: " + vrijemeTrajanjaIgre.ToString() + "sec");
                this.Close();
            }
            /*if(sec == rrr - vrijemeTrajanjaIgre)
            {
                lblVrijemeIgranja.Text = vrijemeTrajanjaIgre.ToString();
                vrijemeTrajanjaIgre--;
                if (vrijemeTrajanjaIgre < 0)
                {
                    RabitGameTimer.Stop();
                    MessageBox.Show("KRAJ");
                }
            }*/
            if (goRight == true)
            {
                if (zeka.Left <= panGamePlay.Width - brzinaZeke)
                {
                    zeka.Left += brzinaZeke;
                    goRight = false;
                    brojSkokova++;
                    lblBrojSkokova.Text = brojSkokova.ToString();
                }
            }
            if (goLeft == true)
            {
                if (zeka.Left >= brzinaZeke)
                {
                    zeka.Left -= brzinaZeke;
                    goLeft = false;
                    brojSkokova++;
                    lblBrojSkokova.Text = brojSkokova.ToString();
                }
            }
            if (goUp == true)
            {
                if (zeka.Top >= brzinaZeke)
                {
                    zeka.Top -= brzinaZeke;
                    goUp = false;
                    brojSkokova++;
                    lblBrojSkokova.Text = brojSkokova.ToString();
                }
            }
            if (goDown == true)
            {
                if (zeka.Top <= panGamePlay.Height - brzinaZeke)
                {
                    zeka.Top += brzinaZeke;
                    goDown = false;
                    brojSkokova++;
                    lblBrojSkokova.Text = brojSkokova.ToString();
                }
            }
            foreach (Control x in panGamePlay.Controls)
            {
                foreach(Control y in panGamePlay.Controls)
                {
                    if ((string)x.Tag == "polje" && (string)y.Tag == "povrce" && zeka.Bounds.IntersectsWith(x.Bounds) && y.Bounds.IntersectsWith(x.Bounds))
                    {
                        if(y.Text == "KU")
                        {
                            brojPojedenihKupusa++;
                            lblBrojKupusa.Text = brojPojedenihKupusa.ToString();
                            y.Text = "X";
                        }
                    }   
                }
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRightD = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRightD = false;
            }
        }
    }
}
//rectangleMatrix[i,j] = new Rectangle(j * dsKvadrata + 1, i * dsKvadrata + 1, dsKvadrata - 2, dsKvadrata - 2);
//e.Graphics.DrawRectangle(pen, rectangleMatrix[i,j]);
//Font font = new Font("Arial", rectangleMatrix[i,j].Width/4, FontStyle.Bold, GraphicsUnit.Point);
//e.Graphics.DrawString(voce[random.Next(voce.Length)], font, Brushes.Yellow, rectangleMatrix[i,j]);


/*System.Threading.Timer _timer;
public void Start30DayTimer()
{
    TimeSpan span = new TimeSpan(30, 0, 0, 0);
    TimeSpan disablePeriodic = new TimeSpan(0, 0, 0, 0, -1);
    _timer = new System.Threading.Timer(timer_TimerCallback, null, 
        span, disablePeriodic);
}

public void timer_TimerCallback(object state)
{
    // do whatever needs to be done after 30 days
    _timer.Dispose();
}*/