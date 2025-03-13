using BookHaven.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeaven.Views
{
    public partial class Reports : Form
    {
        // Services for retrieving book, customer, and order data
        private readonly BookService bookService;
        private readonly CustomerService customerService;
        private readonly OrderService orderService;

        // Constructor initializing services
        public Reports(BookService bookService, CustomerService customerService, OrderService orderService)
        {
            InitializeComponent();
            this.bookService = bookService;
            this.customerService = customerService;
            this.orderService = orderService;
        }


        // Fetches and displays the best-selling books
        private async void btnBestSelling_Click(object sender, EventArgs e)
        {
            ClearTables();
            var bestSellingBooks = await orderService.GetBestSellingBooksAsync();
            dgvReports.Visible = true;
            dgvReports.DataSource = bestSellingBooks;
            btnDownload.Visible = true;
        }

        // Fetches and displays the current inventory of books
        private async void Inventory_Click(object sender, EventArgs e)
        {
            ClearTables();
            var inventory = await bookService.GetInventory();
            dgvReports.Visible = true;
            dgvReports.DataSource = inventory;
            btnDownload.Visible = true;
        }

        // Fetches and displays the best customers based on order history
        private async void btnBestcustomer_Click(object sender, EventArgs e)
        {
            ClearTables();
            var bestCustomers = await orderService.GetBestCustomersAsync();
            dgvReports.Visible = true;
            dgvReports.DataSource = bestCustomers;
            btnDownload.Visible = true;
        }

        // Clears the DataGridView and hides buttons
        private void ClearTables()
        {
            dgvReports.Visible = false;
            dgvReports.DataSource = null;
            btnDownload.Visible = false;
        }

        // Loads order details based on the selected date range
        private async Task LoadOrdersIntoGrid(DateTime startDate, DateTime endDate)
        {
            dgvReports.Visible = true;
            var orders = await orderService.GetOrdersByDateRangeAsync(startDate, endDate);

            dgvReports.DataSource = orders.Select(o => new
            {
                OrderID = o.Id,
                Date = o.OrderDate.ToString("yyyy-MM-dd"),
                TotalAmount = o.Total
            }).ToList();
            btnDownload.Visible = true;
        }

        // Generates and downloads a PDF report from the DataGridView data
        private void GenerateReport()
        {
            // Get the Downloads folder path
            var downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            var reportPath = System.IO.Path.Combine(downloadsFolder, "Report.pdf");

            // Access the rows from the DataGridView
            var rows = dgvReports.Rows;
            var document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);

            using (var stream = new System.IO.FileStream(reportPath, System.IO.FileMode.Create))
            {
                var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, stream);
                document.Open();

                // Adding Report Header
                document.Add(new iTextSharp.text.Paragraph("Summary Report"));
                document.Add(new iTextSharp.text.Paragraph($"Generated on: {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}"));

                var table = new iTextSharp.text.pdf.PdfPTable(dgvReports.ColumnCount)
                {
                    WidthPercentage = 100
                };

                // Adding column headers
                foreach (DataGridViewColumn column in dgvReports.Columns)
                {
                    table.AddCell(new iTextSharp.text.Phrase(column.HeaderText));
                }

                // Adding data rows
                foreach (DataGridViewRow row in rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString() ?? string.Empty);
                    }
                }

                document.Add(table);
                document.Close();
            }

            // Opens the generated report automatically
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(reportPath)
            {
                UseShellExecute = true
            });
        }

        // Navigates back to the admin dashboard
        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminDashboardForm();
            adminForm.Show();
            this.Hide();
        }

        // Handles the report download button click
        private void btnDownload_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
