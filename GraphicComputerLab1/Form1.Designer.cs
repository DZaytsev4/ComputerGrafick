namespace GraphicComputerLab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            фильтToolStripMenuItem = new ToolStripMenuItem();
            матричныеToolStripMenuItem = new ToolStripMenuItem();
            размытиеToolStripMenuItem = new ToolStripMenuItem();
            размытиеПоГауссуToolStripMenuItem = new ToolStripMenuItem();
            фильтрСоболяToolStripMenuItem = new ToolStripMenuItem();
            поОсиXToolStripMenuItem = new ToolStripMenuItem();
            поОсиYToolStripMenuItem = new ToolStripMenuItem();
            повышениеРезкостиToolStripMenuItem = new ToolStripMenuItem();
            тиснениеToolStripMenuItem = new ToolStripMenuItem();
            motionBlurToolStripMenuItem = new ToolStripMenuItem();
            резкостьToolStripMenuItem = new ToolStripMenuItem();
            точечныеToolStripMenuItem = new ToolStripMenuItem();
            инверсияToolStripMenuItem = new ToolStripMenuItem();
            graySkaleToolStripMenuItem = new ToolStripMenuItem();
            сепияToolStripMenuItem = new ToolStripMenuItem();
            серыйМирToolStripMenuItem = new ToolStripMenuItem();
            переносToolStripMenuItem = new ToolStripMenuItem();
            поворотToolStripMenuItem = new ToolStripMenuItem();
            волны1ToolStripMenuItem = new ToolStripMenuItem();
            волны2ToolStripMenuItem = new ToolStripMenuItem();
            эффектСтеклаToolStripMenuItem = new ToolStripMenuItem();
            идеальныйОтражательToolStripMenuItem = new ToolStripMenuItem();
            бинаризацияToolStripMenuItem = new ToolStripMenuItem();
            растяжениеГистограммыToolStripMenuItem = new ToolStripMenuItem();
            медиайныйФильтрToolStripMenuItem = new ToolStripMenuItem();
            светящиесяКраяToolStripMenuItem = new ToolStripMenuItem();
            математическаяМорфологияToolStripMenuItem = new ToolStripMenuItem();
            dilationToolStripMenuItem = new ToolStripMenuItem();
            erosionToolStripMenuItem = new ToolStripMenuItem();
            openingToolStripMenuItem = new ToolStripMenuItem();
            closingToolStripMenuItem = new ToolStripMenuItem();
            topHatToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            stopButton = new Button();
            blackHatToolStripMenuItem = new ToolStripMenuItem();
            gradToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, фильтToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(768, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 22);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(121, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // фильтToolStripMenuItem
            // 
            фильтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { матричныеToolStripMenuItem, точечныеToolStripMenuItem, растяжениеГистограммыToolStripMenuItem, медиайныйФильтрToolStripMenuItem, светящиесяКраяToolStripMenuItem, математическаяМорфологияToolStripMenuItem });
            фильтToolStripMenuItem.Name = "фильтToolStripMenuItem";
            фильтToolStripMenuItem.Size = new Size(69, 22);
            фильтToolStripMenuItem.Text = "Фильтры";
            // 
            // матричныеToolStripMenuItem
            // 
            матричныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размытиеToolStripMenuItem, размытиеПоГауссуToolStripMenuItem, фильтрСоболяToolStripMenuItem, повышениеРезкостиToolStripMenuItem, тиснениеToolStripMenuItem, motionBlurToolStripMenuItem, резкостьToolStripMenuItem });
            матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            матричныеToolStripMenuItem.Size = new Size(240, 22);
            матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            размытиеToolStripMenuItem.Size = new Size(194, 22);
            размытиеToolStripMenuItem.Text = "Размытие";
            размытиеToolStripMenuItem.Click += размытиеToolStripMenuItem_Click;
            // 
            // размытиеПоГауссуToolStripMenuItem
            // 
            размытиеПоГауссуToolStripMenuItem.Name = "размытиеПоГауссуToolStripMenuItem";
            размытиеПоГауссуToolStripMenuItem.Size = new Size(194, 22);
            размытиеПоГауссуToolStripMenuItem.Text = "Размытие по Гауссу";
            размытиеПоГауссуToolStripMenuItem.Click += размытиеПоГауссуToolStripMenuItem_Click;
            // 
            // фильтрСоболяToolStripMenuItem
            // 
            фильтрСоболяToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поОсиXToolStripMenuItem, поОсиYToolStripMenuItem });
            фильтрСоболяToolStripMenuItem.Name = "фильтрСоболяToolStripMenuItem";
            фильтрСоболяToolStripMenuItem.Size = new Size(194, 22);
            фильтрСоболяToolStripMenuItem.Text = "Фильтр Соболя";
            // 
            // поОсиXToolStripMenuItem
            // 
            поОсиXToolStripMenuItem.Name = "поОсиXToolStripMenuItem";
            поОсиXToolStripMenuItem.Size = new Size(123, 22);
            поОсиXToolStripMenuItem.Text = "По оси X";
            поОсиXToolStripMenuItem.Click += поОсиXToolStripMenuItem_Click;
            // 
            // поОсиYToolStripMenuItem
            // 
            поОсиYToolStripMenuItem.Name = "поОсиYToolStripMenuItem";
            поОсиYToolStripMenuItem.Size = new Size(123, 22);
            поОсиYToolStripMenuItem.Text = "По оси Y";
            поОсиYToolStripMenuItem.Click += поОсиYToolStripMenuItem_Click;
            // 
            // повышениеРезкостиToolStripMenuItem
            // 
            повышениеРезкостиToolStripMenuItem.Name = "повышениеРезкостиToolStripMenuItem";
            повышениеРезкостиToolStripMenuItem.Size = new Size(194, 22);
            повышениеРезкостиToolStripMenuItem.Text = "Повышение резкости";
            повышениеРезкостиToolStripMenuItem.Click += повышениеРезкостиToolStripMenuItem_Click;
            // 
            // тиснениеToolStripMenuItem
            // 
            тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            тиснениеToolStripMenuItem.Size = new Size(194, 22);
            тиснениеToolStripMenuItem.Text = "Тиснение";
            тиснениеToolStripMenuItem.Click += тиснениеToolStripMenuItem_Click;
            // 
            // motionBlurToolStripMenuItem
            // 
            motionBlurToolStripMenuItem.Name = "motionBlurToolStripMenuItem";
            motionBlurToolStripMenuItem.Size = new Size(194, 22);
            motionBlurToolStripMenuItem.Text = "MotionBlur";
            motionBlurToolStripMenuItem.Click += motionBlurToolStripMenuItem_Click;
            // 
            // резкостьToolStripMenuItem
            // 
            резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            резкостьToolStripMenuItem.Size = new Size(194, 22);
            резкостьToolStripMenuItem.Text = "Резкость";
            резкостьToolStripMenuItem.Click += резкостьToolStripMenuItem_Click;
            // 
            // точечныеToolStripMenuItem
            // 
            точечныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { инверсияToolStripMenuItem, graySkaleToolStripMenuItem, сепияToolStripMenuItem, серыйМирToolStripMenuItem, переносToolStripMenuItem, поворотToolStripMenuItem, волны1ToolStripMenuItem, волны2ToolStripMenuItem, эффектСтеклаToolStripMenuItem, идеальныйОтражательToolStripMenuItem, бинаризацияToolStripMenuItem });
            точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            точечныеToolStripMenuItem.Size = new Size(240, 22);
            точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            инверсияToolStripMenuItem.Size = new Size(204, 22);
            инверсияToolStripMenuItem.Text = "Инверсия";
            инверсияToolStripMenuItem.Click += инверсияToolStripMenuItem_Click;
            // 
            // graySkaleToolStripMenuItem
            // 
            graySkaleToolStripMenuItem.Name = "graySkaleToolStripMenuItem";
            graySkaleToolStripMenuItem.Size = new Size(204, 22);
            graySkaleToolStripMenuItem.Text = "GraySkale";
            graySkaleToolStripMenuItem.Click += graySkaleToolStripMenuItem_Click;
            // 
            // сепияToolStripMenuItem
            // 
            сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            сепияToolStripMenuItem.Size = new Size(204, 22);
            сепияToolStripMenuItem.Text = "Сепия";
            сепияToolStripMenuItem.Click += сепияToolStripMenuItem_Click;
            // 
            // серыйМирToolStripMenuItem
            // 
            серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            серыйМирToolStripMenuItem.Size = new Size(204, 22);
            серыйМирToolStripMenuItem.Text = "Серый мир";
            серыйМирToolStripMenuItem.Click += серыйМирToolStripMenuItem_Click;
            // 
            // переносToolStripMenuItem
            // 
            переносToolStripMenuItem.Name = "переносToolStripMenuItem";
            переносToolStripMenuItem.Size = new Size(204, 22);
            переносToolStripMenuItem.Text = "Перенос";
            переносToolStripMenuItem.Click += переносToolStripMenuItem_Click;
            // 
            // поворотToolStripMenuItem
            // 
            поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            поворотToolStripMenuItem.Size = new Size(204, 22);
            поворотToolStripMenuItem.Text = "Поворот";
            поворотToolStripMenuItem.Click += поворотToolStripMenuItem_Click;
            // 
            // волны1ToolStripMenuItem
            // 
            волны1ToolStripMenuItem.Name = "волны1ToolStripMenuItem";
            волны1ToolStripMenuItem.Size = new Size(204, 22);
            волны1ToolStripMenuItem.Text = "Волны1";
            волны1ToolStripMenuItem.Click += волны1ToolStripMenuItem_Click;
            // 
            // волны2ToolStripMenuItem
            // 
            волны2ToolStripMenuItem.Name = "волны2ToolStripMenuItem";
            волны2ToolStripMenuItem.Size = new Size(204, 22);
            волны2ToolStripMenuItem.Text = "Волны2";
            волны2ToolStripMenuItem.Click += волны2ToolStripMenuItem_Click;
            // 
            // эффектСтеклаToolStripMenuItem
            // 
            эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
            эффектСтеклаToolStripMenuItem.Size = new Size(204, 22);
            эффектСтеклаToolStripMenuItem.Text = "Эффект стекла";
            эффектСтеклаToolStripMenuItem.Click += эффектСтеклаToolStripMenuItem_Click;
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            идеальныйОтражательToolStripMenuItem.Size = new Size(204, 22);
            идеальныйОтражательToolStripMenuItem.Text = "Идеальный отражатель";
            идеальныйОтражательToolStripMenuItem.Click += идеальныйОтражательToolStripMenuItem_Click;
            // 
            // бинаризацияToolStripMenuItem
            // 
            бинаризацияToolStripMenuItem.Name = "бинаризацияToolStripMenuItem";
            бинаризацияToolStripMenuItem.Size = new Size(204, 22);
            бинаризацияToolStripMenuItem.Text = "Бинаризация";
            бинаризацияToolStripMenuItem.Click += бинаризацияToolStripMenuItem_Click;
            // 
            // растяжениеГистограммыToolStripMenuItem
            // 
            растяжениеГистограммыToolStripMenuItem.Name = "растяжениеГистограммыToolStripMenuItem";
            растяжениеГистограммыToolStripMenuItem.Size = new Size(240, 22);
            растяжениеГистограммыToolStripMenuItem.Text = "Растяжение Гистограммы";
            растяжениеГистограммыToolStripMenuItem.Click += растяжениеГистограммыToolStripMenuItem_Click;
            // 
            // медиайныйФильтрToolStripMenuItem
            // 
            медиайныйФильтрToolStripMenuItem.Name = "медиайныйФильтрToolStripMenuItem";
            медиайныйФильтрToolStripMenuItem.Size = new Size(240, 22);
            медиайныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
            медиайныйФильтрToolStripMenuItem.Click += медиайныйФильтрToolStripMenuItem_Click;
            // 
            // светящиесяКраяToolStripMenuItem
            // 
            светящиесяКраяToolStripMenuItem.Name = "светящиесяКраяToolStripMenuItem";
            светящиесяКраяToolStripMenuItem.Size = new Size(240, 22);
            светящиесяКраяToolStripMenuItem.Text = "Светящиеся края";
            светящиесяКраяToolStripMenuItem.Click += светящиесяКраяToolStripMenuItem_Click;
            // 
            // математическаяМорфологияToolStripMenuItem
            // 
            математическаяМорфологияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dilationToolStripMenuItem, erosionToolStripMenuItem, openingToolStripMenuItem, closingToolStripMenuItem, topHatToolStripMenuItem, blackHatToolStripMenuItem, gradToolStripMenuItem });
            математическаяМорфологияToolStripMenuItem.Name = "математическаяМорфологияToolStripMenuItem";
            математическаяМорфологияToolStripMenuItem.Size = new Size(240, 22);
            математическаяМорфологияToolStripMenuItem.Text = "Математическая морфология";
            // 
            // dilationToolStripMenuItem
            // 
            dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            dilationToolStripMenuItem.Size = new Size(180, 22);
            dilationToolStripMenuItem.Text = "Dilation";
            dilationToolStripMenuItem.Click += dilationToolStripMenuItem_Click;
            // 
            // erosionToolStripMenuItem
            // 
            erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            erosionToolStripMenuItem.Size = new Size(180, 22);
            erosionToolStripMenuItem.Text = "Erosion";
            erosionToolStripMenuItem.Click += erosionToolStripMenuItem_Click;
            // 
            // openingToolStripMenuItem
            // 
            openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            openingToolStripMenuItem.Size = new Size(180, 22);
            openingToolStripMenuItem.Text = "Opening";
            openingToolStripMenuItem.Click += openingToolStripMenuItem_Click;
            // 
            // closingToolStripMenuItem
            // 
            closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            closingToolStripMenuItem.Size = new Size(180, 22);
            closingToolStripMenuItem.Text = "Closing";
            closingToolStripMenuItem.Click += closingToolStripMenuItem_Click;
            // 
            // topHatToolStripMenuItem
            // 
            topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            topHatToolStripMenuItem.Size = new Size(180, 22);
            topHatToolStripMenuItem.Text = "Top Hat";
            topHatToolStripMenuItem.Click += topHatToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(230, 39);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.MaximumSize = new Size(323, 281);
            pictureBox1.MinimumSize = new Size(323, 281);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(230, 337);
            progressBar1.Margin = new Padding(2, 1, 2, 1);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(323, 22);
            progressBar1.TabIndex = 2;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(589, 337);
            stopButton.Margin = new Padding(2, 1, 2, 1);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(81, 22);
            stopButton.TabIndex = 3;
            stopButton.Text = "Отмена";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // blackHatToolStripMenuItem
            // 
            blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            blackHatToolStripMenuItem.Size = new Size(180, 22);
            blackHatToolStripMenuItem.Text = "Black Hat";
            blackHatToolStripMenuItem.Click += blackHatToolStripMenuItem_Click;
            // 
            // gradToolStripMenuItem
            // 
            gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            gradToolStripMenuItem.Size = new Size(180, 22);
            gradToolStripMenuItem.Text = "Grad";
            gradToolStripMenuItem.Click += gradToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 372);
            Controls.Add(stopButton);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem фильтToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem размытиеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Button stopButton;
        private ToolStripMenuItem размытиеПоГауссуToolStripMenuItem;
        private ToolStripMenuItem graySkaleToolStripMenuItem;
        private ToolStripMenuItem сепияToolStripMenuItem;
        private ToolStripMenuItem фильтрСоболяToolStripMenuItem;
        private ToolStripMenuItem поОсиXToolStripMenuItem;
        private ToolStripMenuItem поОсиYToolStripMenuItem;
        private ToolStripMenuItem повышениеРезкостиToolStripMenuItem;
        private ToolStripMenuItem серыйМирToolStripMenuItem;
        private ToolStripMenuItem растяжениеГистограммыToolStripMenuItem;
        private ToolStripMenuItem тиснениеToolStripMenuItem;
        private ToolStripMenuItem переносToolStripMenuItem;
        private ToolStripMenuItem поворотToolStripMenuItem;
        private ToolStripMenuItem волны1ToolStripMenuItem;
        private ToolStripMenuItem волны2ToolStripMenuItem;
        private ToolStripMenuItem эффектСтеклаToolStripMenuItem;
        private ToolStripMenuItem motionBlurToolStripMenuItem;
        private ToolStripMenuItem резкостьToolStripMenuItem;
        private ToolStripMenuItem медиайныйФильтрToolStripMenuItem;
        private ToolStripMenuItem светящиесяКраяToolStripMenuItem;
        private ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        private ToolStripMenuItem математическаяМорфологияToolStripMenuItem;
        private ToolStripMenuItem dilationToolStripMenuItem;
        private ToolStripMenuItem erosionToolStripMenuItem;
        private ToolStripMenuItem openingToolStripMenuItem;
        private ToolStripMenuItem closingToolStripMenuItem;
        private ToolStripMenuItem бинаризацияToolStripMenuItem;
        private ToolStripMenuItem topHatToolStripMenuItem;
        private ToolStripMenuItem blackHatToolStripMenuItem;
        private ToolStripMenuItem gradToolStripMenuItem;
    }
}
