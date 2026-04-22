using System;
using System.Collections.Generic;
using IronPdf;

/*
    * Title: Generating PDF file using C#
    * Author: Vivek Kumar
    * Site: c-sharpcorner.com
    * Date: 22 April 2026
    * Code Version: -
    * Availability: https://www.c-sharpcorner.com/UploadFile/f4f047/generating-pdf-file-using-C-Sharp/
    * Accessed: 22 April 2026
    * Modified: Using IronPDF to generate a PDF receipt for book loans.
*/

namespace LibrarySYS
{
    public class LoanReceipt
    {
        public static void GenerateReceipt(int loanID, Member member, List<Book> booksLoaned)
        {
            // Build the book rows for the table
            var bookRows = new System.Text.StringBuilder();
            foreach (Book book in booksLoaned)
            {
                bookRows.Append($@"
                    <tr>
                        <td>{book.BookID}</td>
                        <td>{book.Title} / {book.Author}</td>
                        <td>{DateTime.Now.AddDays(5):dd-MMMM-yyyy}</td>
                    </tr>");
            }

            // Build the full HTML receipt
            string html = $@"
            <html>
            <head>
            <style>
                :root {{
                    --primary:        #34495E;   /* dark blue-grey — header, table header, accents */
                    --border:         #e0e4e8;   /* light border grey — table rows, footer border */
                    --text-muted:     #7f8c8d;   /* medium grey — labels, author, footer text */
                    --text-white:     #ffffff;   /* white — header and table header text */
                }}

                * {{
                    margin: 0;
                    padding: 0;
                }}

                 body {{
                    background: #f0f2f4;
                    font-family: 'Source Sans 3', sans-serif;
                    font-weight: 400;
                    color: #2c3e50;
                }}

                header {{
                    background-color:#34495E;
                    color: white;
                    padding: 2em 3em;
                }}

                header h2, header h3 {{
                    color: var(--text-muted);
                    padding-top: 0.5em;
                    font-size: 1em;
                }}

                header h3 {{
                   text-transform: uppercase;
                }}

                main {{
                    padding: 2em 3em;
                }}

                main h3 {{
                    text-transform: uppercase;
                    color: var(--primary);
                    padding-bottom: 0.5em;
                    font-size: 1.2em;
                    letter-spacing: 0.1em;
                }}

                main hr {{
                    color: var(--border);
                    width: 90%;
                }}

                .memberInfo {{
                    border-left: 0.3em solid var(--primary);
                    background-color: var(--border);
                    margin-top: 2em;
                    margin-bottom: 2em;
                    padding: 1em;
                }}

                .memberInfo p {{
                    color: var(--text-muted);
                    text-transform: uppercase;
                    font-size: 0.7em;
                    margin-bottom: 0.5em;
                }}

                .memberInfo span {{
                    color: var(--primary);
                }}

                .column {{
                    display: flex;
                    justify-content: space-between;
                    text-align: left;
                    width: 50%;
                }}

                .column:first-child {{
                    margin-bottom: 2em;
                }}

                table {{
                    width: 100%;
                }}

                table tr {{
                    border-bottom: 1px solid var(--border);
                }}

                table th {{
                    background-color: var(--primary);
                    color: var(--text-white);
                    padding: 0.5em 1em;
                }}

                table tr:nth-child(odd) {{
                    background-color: var(--border);
                }}
        
                table td {{
                    padding: 0.5em 2em;
                }}

                main p:last-child {{
                    text-align: right;
                    color: var(--text-muted);
                    margin-top: 2em;
                }}

                footer {{
                    padding: 2em 3em;
                    text-align: center;
                    background-color: var(--border);
                    margin-top: 3em;
                    width: 100%;
                }}

                footer h5 {{
                    font-size: 1em;
                }}

                footer p {{
                    font-size: 0.9em;
                    color: var(--text-muted);
                }}
            </style>
        </head>
        <body>
            <header>
                <h1>Killorglin Public Library</h1>
                <h2>Library Place, Killorglin, Co. Kerry</h2>
                <h3>killorglinlibrary.ie</h3>
            </header>

            <main>
                <h3>Checkout Receipt</h3>
                <hr>

                <div class=""memberInfo"">
                    <div class=""column"">
                        <div class=""member"">
                            <p>Member</p>
                            <span>{member.FirstName} {member.LastName}</span>
                        </div>

                        <div class=""memberID"">
                            <p>ID</p>
                            <span>{member.MemberID}</span>
                        </div>
                    </div>

                    <div class=""column"">
                        <div class=""date"">
                            <p>Date</p>
                            <span>{DateTime.Now:dd-MMM-yyyy}</span>
                        </div>

                        <div class=""time"">
                            <p>Time</p>
                            <span>{DateTime.Now:HH:mm}</span>
                        </div>
                    </div>
                </div>

                <table>
                    <tr>
                        <th>Book ID</th>
                        <th>Title/Author</th>
                        <th>DueDate</th>
                    </tr>

                    {bookRows}
                </table>

                <p>Items checked out: {booksLoaned.Count}</p>
            </main>


            <footer>
                <h5>Thank you for visiting Killorglin Public Library</h5>
                <p>Late fees: €0.20/day per item</p>
            </footer>
        </body>
        </html>";

            var renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

            string fileName = $"LoanReceipt_{loanID}.pdf";
            pdf.SaveAs(fileName);

            // Open the PDF automatically after saving
            System.Diagnostics.Process.Start(fileName);
        }
    }
}
/* END OF REFERENCED CONTENT */