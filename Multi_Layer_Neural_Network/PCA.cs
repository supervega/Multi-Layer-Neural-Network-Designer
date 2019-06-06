using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using Emgu.CV;

namespace Multi_Layer_Neural_Network
{
    public class PCA
    {
        private double[] meanImage;
        public double[,] Images;
        private int matrixHeight;
        private int matrixWidth;
        public double[,] eigenFaces;

        public PCA()
        {
            
        }

        public int MatrixHeight
        {
            get
            {
                return matrixHeight;
            }
            set
            {
                matrixHeight = value;
            }
        }

        public int MatrixWidth
        {
            get
            {
                return matrixWidth;
            }
            set
            {
                matrixWidth = value;
            }
        }

        public double[] MeanImage
        {
            get
            {
                return meanImage;
            }
            set
            {
                meanImage = value;
            }
        }
        
        public void CalculateMeanImage()
        {            
            MeanImage = new double[matrixWidth];
           
            for (int i = 0; i < MatrixWidth; i++)
            {
                double CurrentMean=0;
                for (int j = 0; j < MatrixHeight; j++)
                {
                    CurrentMean+=Images[j,i];
                }                
                MeanImage[i] = CurrentMean / MatrixHeight;
            }
        }

        public double[,] GetEigenFaces(double[] X)
        {
            //pca = new PrincipalComponentAnalysis(Images,PrincipalComponentAnalysis.AnalysisMethod.Correlation);
            // Compute the Principal Component Analysis
            //pca.Compute();
            //double[,] component = pca.Transform(Images,100);
            //eigenFaces = new double[matrixHeight, matrixWidth];
            //for (int i = 0; i < component.Length ; i++)
            //{
                //PrincipalComponent component = pca.Components[i];
             //   for (int j = 0; j < matrixWidth; j++)
    		//	{
            //        eigenFaces[i, j] = (Images[i, j] - MeanImage[j]) * component[i,j];
    		//	}
            //}
            eigenFaces = new double[matrixHeight, matrixHeight];

            for (int i = 0; i < matrixHeight; i++)
            {
                double[] Temp = new double[matrixWidth];
                for (int k = 0; k < matrixWidth; k++)
                {
                    Temp[k] = Images[i, k] - MeanImage[k];
                }
                for (int j = 0; j <= i; j++)
                {
                    double Result=0;
                    for (int k = 0; k < matrixWidth; k++)
                    {
                        Result += Images[j, k] * Temp[k];
                    }
                    eigenFaces[i,j] = Result;
                    eigenFaces[j,i] = Result;
                }
            }
           
            return eigenFaces;
        }
    }
}
