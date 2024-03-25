using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections;



namespace GraphicComputerLab1
{
    abstract class Filters
    {
        public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            int x, y;
            for (x = 0;x < resultImage.Width;x++)
            {
                worker.ReportProgress((int)((float)x / resultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (y = 0; y < resultImage.Height; y++)
                {
                    resultImage.SetPixel(x, y, calculateNewPixelColor(sourceImage, x, y));
                }
            }
            return resultImage;
        }
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);
        public int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
    class MedianFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int k = 0;
            int[] mR = new int[25];
            int[] mG = new int[25];
            int[] mB = new int[25];
            for (int i = x - 2; i <= x + 2; i++)
            {
                for (int j = y - 2; j <= y + 2; j++)
                {
                    if (i < 0 || j < 0 || i >= sourceImage.Width || j >= sourceImage.Height)
                    {
                        mR[k] = 0;
                        mG[k] = 0;
                        mB[k] = 0;
                        k++;
                    }
                    else
                    {
                        Color sourceColor = sourceImage.GetPixel(i, j);
                        mR[k] = sourceColor.R;
                        mG[k] = sourceColor.G;
                        mB[k] = sourceColor.B;
                        k++;
                    }
                }
            }
            Array.Sort(mR);
            Array.Sort(mG);
            Array.Sort(mB);
            return Color.FromArgb(mR[12], mG[12], mB[12]);
        }
    }
    class Maximum: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int cR = 1, cG = 1, cB = 1;
            int k = 0;
            for (int i = x - 2; i <= x + 2; i++)
            {
                for (int j = y - 2; j <= y + 2; j++)
                {
                    if (i < 0 || j < 0 || i >= sourceImage.Width || j >= sourceImage.Height)
                    {
                        
                        k++;
                    }
                    else
                    {
                        Color sourceColor = sourceImage.GetPixel(i, j);
                        if (sourceColor.R >= cR) cR = sourceColor.R;
                        if (sourceColor.G >= cG) cG = sourceColor.G;
                        if (sourceColor.B >= cB) cB = sourceColor.B;
                    }
                }
            }
            return Color.FromArgb(cR, cG, cB);
        }
    }
    
    class Perenos: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            int newX, newY;
            newX = x + 50;
            newY = y;
            if (newX < sourceImage.Width)
            {
                return sourceImage.GetPixel(newX, newY);
            }
            else 
            { 
                return Color.FromArgb(0, 0, 0);
            }
        }
    }
    class Povorot: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX, newY;
            int u = 15;
            double angle = u * (Math.PI / 180);
            int x0 = sourceImage.Width / 2, y0 = sourceImage.Height / 2;

            newX = (int)Math.Round((x - x0) * Math.Cos(angle) - (y - y0) * Math.Sin(angle) + x0);
            newY = (int)Math.Round((x - x0) * Math.Sin(angle) + (y - y0) * Math.Cos(angle) + y0);

            if (newX >= 0 && newY >= 0 && newX < sourceImage.Width && newY < sourceImage.Height)
            {
                return sourceImage.GetPixel(newX, newY);
            }
            else
            {
                return Color.FromArgb(0, 0, 0);
            }
        }
    }
    class Volni1: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX;
            newX = (int)(x + 20 * Math.Sin(2 * Math.PI * y / 60));
            return sourceImage.GetPixel(Clamp(newX, 0, sourceImage.Width-1), y);
        }
    }
    class Volni2: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX;
            newX = (int)(x + 20 * Math.Sin(2 * Math.PI * x / 30));
            return sourceImage.GetPixel(Clamp(newX, 0, sourceImage.Width - 1), y);
        }
    }
    class Glass: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX, newY;
            Random rnd = new Random();
            newX = (int)(x + (rnd.NextDouble() - 0.5) * 10);
            newY = (int)(y + (rnd.NextDouble() - 0.5) * 10);
            return sourceImage.GetPixel(Clamp(newX,0, sourceImage.Width - 1),
                Clamp(newY,0,sourceImage.Height-1));
        }
    }
    class InvertFilter: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
            return resultColor;
        }
    }
    class GraySkale : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Double intensity;
            Color sourceColor = sourceImage.GetPixel(x, y);
            intensity = (double)sourceColor.R * 0.299 + (double)sourceColor.G * 0.587 + (double)sourceColor.B * 0.144;
            Color resultColor =
                Color.FromArgb(
                    Clamp((int)(intensity),0,255),
                    Clamp((int)(intensity), 0, 255), 
                    Clamp((int)(intensity), 0, 255));
            return resultColor; 
        }
    }
    class Sepia : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double intensite = (double)sourceColor.R * 0.299 + (double)sourceColor.G * 0.587 + (double)sourceColor.B * 0.144;
            int r, g, b, k = 20;
            r = Clamp((int)(intensite) + 2 * k, 0, 255);
            g = Clamp((int)(intensite) +(int)( 0.5 * k), 0, 255);
            b = Clamp((int)(intensite) - k, 0, 255);
            Color resultColor = Color.FromArgb(r, g, b);
            return resultColor;
        }
    }
    class GrayWorld : Filters
    {
        int Rd, Gd, Bd, avg;
        public GrayWorld(Bitmap image)
        {
            int tR = 0, tG = 0, tB = 0;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color tekColor = image.GetPixel(x, y);
                    tR += tekColor.R;
                    tG += tekColor.G;
                    tB += tekColor.B;
                }
            }
            Rd = tR / (image.Width * image.Height);
            Gd = tG / (image.Height * image.Width);
            Bd = tB / (image.Width * image.Height);
            avg = Rd + Gd + Bd / 3;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            
            Color resultColor = Color.FromArgb(
                Clamp((int)(sourceColor.R * avg / Rd),0,255),
                Clamp((int)(sourceColor.G * avg / Gd), 0, 255),
                Clamp((int)(sourceColor.B * avg / Bd), 0, 255)
                );
            return resultColor;
        }
    }

    class RastGist : Filters
    {
        int minIntensivite, maxIntensivite;
        public RastGist(Bitmap image)
        {
            minIntensivite = 255;
            maxIntensivite = 0;
            int intensive;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixelColor = image.GetPixel(i, j);
                    intensive = (int)(pixelColor.R + 0.299 + pixelColor.G * 0.587 + pixelColor.B * 0.114);
                    if (intensive < minIntensivite) minIntensivite = intensive;
                    if (intensive > maxIntensivite) maxIntensivite = intensive;
                }
            }
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int r, g, b;
            r = Clamp((int)((sourceColor.R - minIntensivite) / (double)(maxIntensivite - minIntensivite) * 255),0, 255);
            g = Clamp((int)((sourceColor.G - minIntensivite) / (double)(maxIntensivite - minIntensivite) * 255), 0, 255);
            b = Clamp((int)((sourceColor.B - minIntensivite) / (double)(maxIntensivite - minIntensivite) * 255), 0, 255);
            Color resultImage = Color.FromArgb(r, g, b);
            return resultImage;
        }
    }
    class IdealOtr : Filters
    {
        int maxR = 0, maxG = 0, maxB = 0;
        public IdealOtr(Bitmap image) 
        { 
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color sourceColor = image.GetPixel(x, y);
                    if (sourceColor.R > maxR)  maxR = sourceColor.R;
                    if (sourceColor.G > maxG) maxG = sourceColor.G;
                    if (sourceColor.B > maxB) maxB = sourceColor.B;
                }
            }
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return Color.FromArgb(Clamp(sourceImage.GetPixel(x, y).R * 255 / maxR, 0, 255),
                Clamp(sourceImage.GetPixel(x, y).G * 255 / maxG, 0, 255),
                Clamp(sourceImage.GetPixel(x, y).B * 255 / maxB, 0, 255));
        }
    }
    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusX; l <= radiusX; l++)
            {
                for (int k = -radiusY; k <= radiusY; k++)
                {
                    int idX = Clamp(x + l, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + k, 0, sourceImage.Height - 1);
                    Color nColor = sourceImage.GetPixel(idX, idY);
                    resultR += nColor.R * kernel[l + radiusX, k + radiusY];
                    resultG += nColor.G * kernel[l + radiusX, k + radiusY];
                    resultB += nColor.B * kernel[l + radiusX, k + radiusY];
                }
            }

            return Color.FromArgb(Clamp((int)resultR, 0, 255),
                Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));

        }
    }
        class BlurFilter: MatrixFilter
        {
            public BlurFilter()
            {
                int sizeX = 3;
                int sizeY = 3;
                kernel = new float[sizeX, sizeY];
                for (int i = 0; i < sizeX; i++)
                {
                    for (int j = 0; j < sizeY; j++)
                    {
                        kernel[i,j] = 1.0f / (float)(sizeX*sizeY);
                    }
                }
            }
        }
    class GausFilter: MatrixFilter
    {
        public GausFilter()
        {
            createGausFilter(3, 2);
        }
        public void createGausFilter(int radius, float sigma)
        {
            int size = 2 * radius + 1;
            kernel = new float[size, size];
            float norm = 0;
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] =
                        (float)(Math.Exp(-(i * i + j * j) / (2 * sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;
            }
        }
    }
    class SobolY: MatrixFilter
    {
        public SobolY()
        {
            kernel = new float[3, 3];
            kernel[0, 0] = -1; kernel[0, 1] = -2; kernel[0, 2] = -1;
            kernel[1, 0] = 0; kernel[1, 1] = 0; kernel[1, 2] = 0;
            kernel[2, 0] = 2; kernel[2, 1] = 2; kernel[2, 2] = 1;
        }
    }
    class SobolX: MatrixFilter
    {
        public SobolX()
        {
            kernel = new float[3, 3];
            kernel[0, 0] = -1; kernel[0, 1] = 0; kernel[0, 2] = 1;
            kernel[1, 0] = -2; kernel[1, 1] = 0; kernel[1, 2] = 2;
            kernel[2, 0] = -1; kernel[2, 1] = 0; kernel[2, 2] = 1;
        }
    }
    class SharraY: MatrixFilter
    {
        public SharraY() 
        {
            kernel = new float[3, 3]
            {
                {3,10,3 },
                {0, 0, 0 },
                {-3, -10, -3 },
            };
        }
    }
    class SharraX: MatrixFilter
    {
        public SharraX()
        {
            kernel = new float[3, 3]
            {
                {3,0,-3 },
                {10, 0, -10 },
                {3, 0, -3 },
            };
        }
    }
    class PruitY : MatrixFilter
    {
        public PruitY()
        {
            kernel = new float[3, 3]
            {
                {-1,-1,-1 },
                {0, 0, 0 },
                {1, 1, 1 },
            };
        }
    }
    class PruitX: MatrixFilter
    {
        public PruitX()
        {
            kernel = new float[3, 3]
            {
                {-1,0,1 },
                {-1, 0, 1 },
                {-1, 0, 1 },
            };
        }
    }
    class UpSharpness: MatrixFilter
    {
        public UpSharpness()
        {
            kernel = new float[3, 3];
            kernel[0, 0] = 0; kernel[0, 1] = -1; kernel[0, 2] = 0;
            kernel[1, 0] = -1; kernel[1, 1] = 5; kernel[1, 2] = -1;
            kernel[2, 0] = 0; kernel[2, 1] = -1; kernel[2, 2] = 0;
        }
    }
    class Tisn: MatrixFilter
    {
        public Tisn()
        {
            kernel = new float[3, 3];
            kernel[0, 0] = 0; kernel[0, 1] = 1; kernel[0, 2] = 0;
            kernel[1, 0] = 1; kernel[1,1] = 0; kernel[1 , 2] = -1;
            kernel[2, 0] = 0; kernel[2, 1] = -1; kernel[2, 2] = 0;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusX; l <= radiusX; l++)
            {
                for (int k = -radiusY; k <= radiusY; k++)
                {
                    int idX = Clamp(x + l, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + k, 0, sourceImage.Height - 1);
                    Color nColor = sourceImage.GetPixel(idX, idY);
                    resultR += nColor.R * kernel[l + radiusX, k + radiusY];
                    resultG += nColor.G * kernel[l + radiusX, k + radiusY];
                    resultB += nColor.B * kernel[l + radiusX, k + radiusY];
                }
            }

            return Color.FromArgb(Clamp((int)((resultR + 255)/2),0,255), 
                Clamp((int)((resultG + 255) / 2),0,255), Clamp((int)((resultB + 255) / 2),0,255));

        }
    }
    class MotionBlur : MatrixFilter
    {
        public MotionBlur() 
        {
            int n = 5;
            kernel = new float[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    kernel[i, j] = 0.0f;
                    if (j == i)
                    {
                        kernel[i, j] = 1.0f/n;
                    }
                }
            }
        }
    }
    class Rezkost : MatrixFilter
    {
        public Rezkost()
        {
            kernel = new float[3,3];
            for ( int i = 0;i < 3; i++)
            {
                for (int j = 0; j < 3; j++) kernel[i, j] = -1;
            }
            kernel[1, 1] = 9;
        }
    }
    class Binarization : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (sourceImage.GetPixel(x,y).G > 127) return Color.FromArgb(255,255,255);
            else return Color.FromArgb(0,0,0);
        }
    }
    class Dilation : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int maxR = 0, maxG = 0, maxB = 0;
            int rad = 3;
            for (int i = x - rad; i <= x + rad; i++)
            {
                for (int j = y - rad; j <= y + rad; j++)
                {
                    if (i < 0 || j < 0 || i >= sourceImage.Width || j >= sourceImage.Height)
                        continue;

                    Color sourceColor = sourceImage.GetPixel(i, j);
                    if (sourceColor.R > maxR) maxR = sourceColor.R;
                    if (sourceColor.G > maxG) maxG = sourceColor.G;
                    if (sourceColor.B > maxB) maxB = sourceColor.B;
                }
            }
            return Color.FromArgb(maxR, maxG, maxB);
        }
        public Color GetColor(Bitmap sourceImage, int x, int y)
        {
            return calculateNewPixelColor(sourceImage, x, y);
        }
    }
    class Erosion : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int minR = 255, minG = 255, minB = 255;
            int rad = 3;
            for (int i = x - rad; i <= x + rad; i++)
            {
                for (int j = y - rad; j <= y + rad; j++)
                {
                    if (i < 0 || j < 0 || i >= sourceImage.Width || j >= sourceImage.Height)
                        continue;

                    Color sourceColor = sourceImage.GetPixel(i, j);
                    if (sourceColor.R < minR) minR = sourceColor.R;
                    if (sourceColor.G < minG) minG = sourceColor.G;
                    if (sourceColor.B < minB) minB = sourceColor.B;
                }
            }
            return Color.FromArgb(minR, minG, minB);
        }
        public Color GetColor(Bitmap sourceImage, int x, int y)
        {
           return calculateNewPixelColor(sourceImage, x, y);

        }
    }

    class TopHat : Filters
    {
        private Dilation dilation;
        private Erosion erosion;

        public TopHat()
        {
            dilation = new Dilation();
            erosion = new Erosion();
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color eroded = erosion.GetColor(sourceImage, x, y);
            Color dilated = dilation.GetColor(sourceImage, x, y);
            Color original = sourceImage.GetPixel(x, y);

            // Вычитаем открытие из исходного изображения
            int R = Clamp(original.R - eroded.R, 0, 255);
            int G = Clamp(original.G - eroded.G, 0, 255);
            int B = Clamp(original.B - eroded.B, 0, 255);

            return Color.FromArgb(R, G, B);
        }
    }
    class BlackHat : Filters
    {
        private Dilation dilation;
        private Erosion erosion;

        public BlackHat()
        {
            dilation = new Dilation();
            erosion = new Erosion();
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color dilated = dilation.GetColor(sourceImage, x, y);
            Color eroded = erosion.GetColor(sourceImage, x, y);
            Color original = sourceImage.GetPixel(x, y);

            // Вычитаем исходное изображение из закрытия
            int R = Clamp(dilated.R - original.R, 0, 255);
            int G = Clamp(dilated.G - original.G, 0, 255);
            int B = Clamp(dilated.B - original.B, 0, 255);

            return Color.FromArgb(R, G, B);
        }
    }
    class MorphologicalGradient : Filters
    {
        private Dilation dilation;
        private Erosion erosion;

        public MorphologicalGradient()
        {
            dilation = new Dilation();
            erosion = new Erosion();
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color dilated = dilation.GetColor(sourceImage, x, y);
            Color eroded = erosion.GetColor(sourceImage, x, y);

            // Разница между дилатацией и эрозией
            int R = Clamp(dilated.R - eroded.R, 0, 255);
            int G = Clamp(dilated.G - eroded.G, 0, 255);
            int B = Clamp(dilated.B - eroded.B, 0, 255);

            return Color.FromArgb(R, G, B);
        }
    }
}
