using ceTe.DynamicPDF.Rasterizer;
using System;
using System.Text.RegularExpressions;

namespace example_pdf_to_image_dotnet
{
    // This example shows how to convert a PDF document to various image formats (JPG, PNG, TIFF, Multipage TIFF, BMP, GIF).
    // It references the ceTe.DynamicPDF.Rasterizer.NET NuGet package.
    class Program
    {
        static void Main(string[] args)
        {
            PdfToJpeg();

            PdfToPng();

            PdfToTiff();

            PdfToMultiPageTiff();

            PdfToGif();

            PdfToBmp();
        }

        // Convert a PDF document to JPEG images (one for each page).
        // Use the ceTe.DynamicPDF.Rasterizer namespace for the PdfRasterizer class.
        private static void PdfToJpeg()
        {
            // Create a PdfRasterizer object using the source PDF to be converted to JPG image
            PdfRasterizer rasterizer = new PdfRasterizer(GetResourcePath("doc-a.pdf"));

            // Call the Draw method with output image name, image format and the DPI
            rasterizer.Draw("output.jpg", ImageFormat.Jpeg, ImageSize.Dpi72);
        }

        // Convert a PDF document to PNG images (one for each page).
        // Use the ceTe.DynamicPDF.Rasterizer namespace for the PdfRasterizer class.
        private static void PdfToPng()
        {
            // Create a PdfRasterizer object using the source PDF to be converted to PNG image
            PdfRasterizer rasterizer = new PdfRasterizer(GetResourcePath("doc-a.pdf"));

            // Call the Draw method with output image name, image format and the DPI
            rasterizer.Draw("output.png", ImageFormat.Png, ImageSize.Dpi300);
        }

        // Convert a PDF document to TIFF images (one for each page).
        // Use the ceTe.DynamicPDF.Rasterizer namespace for the PdfRasterizer class.
        private static void PdfToTiff()
        {
            // Create a PdfRasterizer object using the source PDF to be converted to TIFF image
            PdfRasterizer rasterizer = new PdfRasterizer(GetResourcePath("doc-a.pdf"));

            // Call the Draw method with output image name, image format and the DPI
            rasterizer.Draw("EachPage.tiff", ImageFormat.TiffWithLzw, ImageSize.Dpi150);
        }

        // Convert a PDF document to a multipage TIFF image.
        // Use the ceTe.DynamicPDF.Rasterizer namespace for the PdfRasterizer class.
        private static void PdfToMultiPageTiff()
        {
            // Create a PdfRasterizer object using the source PDF to be converted to multipage TIFF image
            PdfRasterizer rasterizer = new PdfRasterizer(GetResourcePath("doc-a.pdf"));

            // Call the DrawToMultiPageTiff method with output image name, image format and the DPI
            rasterizer.DrawToMultiPageTiff("MultiPage.tiff", ImageFormat.TiffWithCcitGroup4, ImageSize.Dpi150);
        }

        // Convert a PDF document to GIF images (one for each page).
        // Use the ceTe.DynamicPDF.Rasterizer namespace for the PdfRasterizer class.
        private static void PdfToGif()
        {
            // Create a PdfRasterizer object using the source PDF to be converted to GIF image
            PdfRasterizer rasterizer = new PdfRasterizer(GetResourcePath("doc-a.pdf"));

            // Call the Draw method with output image name, image format and the DPI
            rasterizer.Draw("output.gif", ImageFormat.Gif, ImageSize.Dpi600);
        }

        // Convert a PDF document to BMP images (one for each page).
        // Use the ceTe.DynamicPDF.Rasterizer namespace for the PdfRasterizer class.
        private static void PdfToBmp()
        {
            // Create a PdfRasterizer object using the source PDF to be converted to BMP images
            PdfRasterizer rasterizer = new PdfRasterizer(GetResourcePath("doc-a.pdf"));

            // Call the Draw method with output image name, image format and the DPI
            rasterizer.Draw("output.bmp", ImageFormat.Bmp, ImageSize.Dpi96);
        }

        // This is a helper function to get the full path to a file in the Resources folder.
        public static string GetResourcePath(string inputFileName)
        {
            var exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return System.IO.Path.Combine(appRoot, "Resources", inputFileName);
        }
    }
}
