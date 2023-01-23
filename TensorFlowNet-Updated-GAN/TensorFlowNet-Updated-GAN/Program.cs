// NuGetPackages:
/*
Install-Package SciSharp.Tensorflow.Redist-Windows-GPU
Install-Package System.Drawing.Common
Install-Package Tensorflow.Keras
Install-Package Tensorflow.NET
*/

namespace TensorFlowNet_Updated_GAN
{
    public class Program
    {
        static void Main(string[] args)
        {
            new MnistGAN().Run();            
        }
    }
}

