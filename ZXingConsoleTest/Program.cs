using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace ZXingConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new BarcodeWriter();

            writer.Format = BarcodeFormat.CODE_128;
            writer.Options.Height = 200;
            writer.Options.Width = 400;
            writer.Options.PureBarcode = false;
            writer.Options.Margin = 10;

            var bmp = writer.Write("1234567890");

            // 画像として保存
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Barcode.png");
            bmp.Save(@"R:\barcode.png", ImageFormat.Png);



            //var qrwriter = new BarcodeWriter
            //{
            //    Format = BarcodeFormat.QR_CODE,
            //    Options = new ZXing.Common.EncodingOptions
            //    {
            //        Height = 160,
            //        Width = 160,
            //        PureBarcode = false
            //    }
            //};

            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options.Height = 200;
            writer.Options.Width = 200;
            writer.Options.PureBarcode = false;
            writer.Options.Margin = 10;

            var result = writer.Write("http://aniproms.net/");
            //var wb = result.ToBitmap() as WriteableBitmap;

            //add to image component
            //imgQRCode.Source = result;

            result.Save(@"R:\qrcode.png", ImageFormat.Png);



        }
    }
}
