using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    internal class Utility
    {
        public static void constructGrid(DataGridView dg)
        {
            dg.Columns["Member_ID"].Width = 100;
            dg.Columns["Member_ID"].DefaultCellStyle.Format = "000";
            dg.Columns["Member_ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["First_Name"].Width = 100;
            dg.Columns["First_Name"].DefaultCellStyle.Format = "000";
            dg.Columns["First_Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Last_Name"].Width = 100;
            dg.Columns["Last_Name"].DefaultCellStyle.Format = "000";
            dg.Columns["Last_Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["DOB"].Width = 100;
            dg.Columns["DOB"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dg.Columns["DOB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Phone"].Width = 100;
            dg.Columns["Phone"].DefaultCellStyle.Format = "000";
            dg.Columns["Phone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Email"].Width = 200;
            dg.Columns["Email"].DefaultCellStyle.Format = "000";
            dg.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Address_Line1"].Width = 120;
            dg.Columns["Address_Line1"].DefaultCellStyle.Format = "000";
            dg.Columns["Address_Line1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Address_Line2"].Width = 120;
            dg.Columns["Address_Line2"].DefaultCellStyle.Format = "000";
            dg.Columns["Address_Line2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["City"].Width = 100;
            dg.Columns["City"].DefaultCellStyle.Format = "000";
            dg.Columns["City"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["County"].Width = 100;
            dg.Columns["County"].DefaultCellStyle.Format = "000";
            dg.Columns["County"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Eircode"].Width = 100;
            dg.Columns["Eircode"].DefaultCellStyle.Format = "000";
            dg.Columns["Eircode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Registration_Date"].Width = 120;
            dg.Columns["Registration_Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dg.Columns["Registration_Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Status"].Width = 100;
            dg.Columns["Status"].DefaultCellStyle.Format = "000";
            dg.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.ReadOnly = true;
            dg.MultiSelect = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        // https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-set-font-and-color-styles-in-the-windows-forms-datagridview-control
        public static void styleGrid(DataGridView dg)
        {
            dg.BorderStyle = BorderStyle.None;
            dg.BackgroundColor = Color.White;
            dg.EnableHeadersVisualStyles = false;

            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);   // dark blue-grey
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dg.ColumnHeadersHeight = 35;

            dg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185); // blue selection
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dg.RowHeadersVisible = false;

            dg.GridColor = Color.LightGray;
        }

        public static void ColourRowsByStatus(DataGridView dg)
        {
            foreach (DataGridViewRow row in dg.Rows)
            {
                string status = row.Cells["Status"].Value.ToString();

                if (status == "A")
                {
                    dg.DefaultCellStyle.BackColor = Color.White;
                    dg.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (status == "I")
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
        }

        public static void StyleInputBoxes(GroupBox grp)
        {
            foreach (Control control in grp.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).ReadOnly = true;
                    TextBox txt = (TextBox)control;
                    txt.Height = 25;
                    txt.BackColor = Color.FromArgb(245, 245, 245);
                    txt.ForeColor = Color.Black;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        public static void StyleInputBoxesActive(GroupBox grp)
        {
            foreach (Control control in grp.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Height = 25;
                    txt.BackColor = Color.White;
                    txt.ForeColor = Color.Black;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        public static void StyleButton(Button b)
        {
            b.BackColor = Color.FromArgb(52, 73, 94);
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
        }

        public static void StyleLabel(GroupBox grp)
        {
            foreach (Control control in grp.Controls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    lbl.ForeColor = Color.Black;
                    lbl.BackColor = Color.Transparent;
                }
            }
        }

        public static void StyleSearchButton(Button b)
        {
            b.BackColor = Color.FromArgb(0, 120, 215);
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Cursor = Cursors.Hand;
            b.Font = new Font("Segoe UI", 8, FontStyle.Bold);
        }

        public static void StyleDeleteButton(Button b)
        {
            b.BackColor = Color.FromArgb(192, 0, 0);
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 0, 0);
            b.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 0, 0);
            b.Cursor = Cursors.Hand;
        }

        public static void StyleCheckedListBox(CheckedListBox clb)
        {
            clb.BackColor = Color.FromArgb(245, 245, 245);
            clb.ForeColor = Color.FromArgb(30, 30, 30);
            clb.Font = new Font("Segoe UI", 9.5f);
            clb.BorderStyle = BorderStyle.FixedSingle;
            clb.CheckOnClick = true;
        }

        public static void StyleExitButton(ToolStripMenuItem b)
        {
            b.BackColor = Color.FromArgb(192, 0, 0);
            b.ForeColor = Color.White;
        }
    }
}
