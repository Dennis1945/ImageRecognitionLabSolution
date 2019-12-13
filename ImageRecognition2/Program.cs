using System;
using System.IO;

namespace ImageRecognition2
{
    class Program
    {
        static readonly string modelPath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "Img");
        static void Main(string[] args)
        {
            string checkImageName = "cifar_test2.jpg";
            string imagePath = Path.Combine(modelPath, checkImageName);
            Cifar10_CNN.Run();
            var cifar_pred = Cifar10_CNN.Predict(imagePath);
            Console.WriteLine("cifar_test2.jpg is " + cifar_pred);
            Console.ReadLine();
        }
    }
}
