using System;
using iTextSharp.text.pdf;

namespace AbbyyPageCounter {
    class Program {
        static void Main(string[] args) {
            var source = args[0];

            var reader = new PdfReader(source);

            for (var i = 1; i <= reader.NumberOfPages; i++) {
                var size = reader.GetPageSize(i);

                var w = (int)(size.Width / 72);
                var h = (int)(size.Height / 72);

                var physicalSize = w * h;
                var a4 = 97;

                var ans = physicalSize / a4;
                Console.WriteLine($" Page {i} {(int)ans}");
            }
        }
    }
}