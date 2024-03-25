namespace GraphicComputerLab1
{
    public partial class Form1 : Form
    {
        Bitmap image;
        List<Filters> filtersList = new List<Filters>();
        private void ApplyFilters()
        {
            foreach (Filters filter in filtersList)
            {
                backgroundWorker1.RunWorkerAsync(filter);
                while (backgroundWorker1.IsBusy)
                {
                    Application.DoEvents();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(ofd.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void èíâåğñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ğàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true) image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void ğàçìûòèåÏîÃàóññóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GausFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void graySkaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new GraySkale();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ñåïèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Sepia();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ïîÎñèYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new SobolY();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ïîÎñèXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new SobolX();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ïîâûøåíèåĞåçêîñòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new UpSharpness();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ñåğûéÌèğToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new GrayWorld(image);
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ğàñòÿæåíèåÃèñòîãğàììûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new RastGist(image);
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void òèñíåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Tisn();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ïåğåíîñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Perenos();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ïîâîğîòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Povorot();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void âîëíû1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Volni1();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void âîëíû2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Volni2();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ıôôåêòÑòåêëàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Glass();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new MotionBlur();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ğåçêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Rezkost();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ìåäèàéíûéÔèëüòğToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void ñâåòÿùèåñÿÊğàÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtersList.Clear();
            filtersList.Add(new MedianFilter());
            filtersList.Add(new PruitX());
            filtersList.Add(new PruitY());
            filtersList.Add(new Maximum());
            ApplyFilters();
        }

        private void èäåàëüíûéÎòğàæàòåëüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new IdealOtr(image);
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Dilation();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void áèíàğèçàöèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Binarization();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new Erosion();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtersList.Clear();
            filtersList.Add(new Erosion());
            filtersList.Add(new Dilation());
            ApplyFilters();
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtersList.Clear();
            filtersList.Add(new Dilation());
            filtersList.Add(new Erosion());
            ApplyFilters();
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new TopHat();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new BlackHat();
            backgroundWorker1.RunWorkerAsync(fil);
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters fil = new MorphologicalGradient();
            backgroundWorker1.RunWorkerAsync(fil);
        }
    }
}
