using Aspose.Pdf;
using Aspose.Pdf.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertPDFTool.Utils
{
    public class ConvertIMG
    {
        public static void ConvertODFtoIMG(ImageDevice imageDevice, string pathFile,string ext, Document pdfDocument)
        {
            for(int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
            {
                using (FileStream imageStream = new FileStream($"{pathFile}/image{pageCount}.{ext}", FileMode.Create))
                {
                    imageDevice.Process(pdfDocument.Pages[pageCount], imageStream);

                    imageStream.Close();
                } 
            }
        }

    }
}
