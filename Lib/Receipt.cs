using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using BookHeaven.Models.Entity;

namespace BookHeaven.Utils
{
    public class Receipt
    {
        public static void GenerateReceipt(Order order)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Order_{order.Id}.pdf");

            Document doc = new Document(PageSize.A4, 40, 40, 50, 50);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            // Use explicit reference to iTextSharp Font
            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
            Paragraph title = new Paragraph("BOOK HEAVEN - ORDER RECEIPT", titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 20
            };
            doc.Add(title);

            iTextSharp.text.Font infoFont = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK);
            doc.Add(new Paragraph($"Order ID: {order.Id}", infoFont));
            doc.Add(new Paragraph($"Date: {order.OrderDate:MM/dd/yyyy}", infoFont));
            doc.Add(new Paragraph("--------------------------------------------------"));

            PdfPTable table = new PdfPTable(4)
            {
                WidthPercentage = 100
            };

            // ✅ Fixing the float array issue
            float[] columnWidths = new float[] { 3f, 1f, 1f, 1f };
            table.SetWidths(columnWidths);

            iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
            BaseColor headerBg = new BaseColor(0, 51, 102);

            // Add Table Header
            AddCell(table, "Book", headerFont, headerBg, Element.ALIGN_CENTER);
            AddCell(table, "Price", headerFont, headerBg, Element.ALIGN_CENTER);
            AddCell(table, "Quantity", headerFont, headerBg, Element.ALIGN_CENTER);
            AddCell(table, "Total", headerFont, headerBg, Element.ALIGN_CENTER);

            iTextSharp.text.Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 11, BaseColor.BLACK);
            foreach (var item in order.Items)
            {
                AddCell(table, item.Book.Title, cellFont, BaseColor.WHITE, Element.ALIGN_LEFT);
                AddCell(table, item.Book.Price.ToString("F2"), cellFont, BaseColor.WHITE, Element.ALIGN_RIGHT);
                AddCell(table, item.Quantity.ToString(), cellFont, BaseColor.WHITE, Element.ALIGN_CENTER);
                AddCell(table, (item.Book.Price * item.Quantity).ToString("F2"), cellFont, BaseColor.WHITE, Element.ALIGN_RIGHT);
            }

            doc.Add(table);
            doc.Add(new Paragraph("--------------------------------------------------"));

            iTextSharp.text.Font totalFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK);
            Paragraph totalAmount = new Paragraph($"Total: {order.Total:C2}", totalFont)
            {
                Alignment = Element.ALIGN_RIGHT,
                SpacingBefore = 10
            };
            doc.Add(totalAmount);

            doc.Close();

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private static void AddCell(PdfPTable table, string text, iTextSharp.text.Font font, BaseColor backgroundColor, int alignment)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font))
            {
                BackgroundColor = backgroundColor,
                Padding = 5,
                HorizontalAlignment = alignment
            };
            table.AddCell(cell);
        }
    }
}
