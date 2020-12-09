using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace excel
{
    class Calculare
    {
        public _Application App;
        public _Workbook Book;
        public Workbooks Books;
        public _Worksheet Sheet;
        public Range rng;
        public void Quit()
        {
            Book.Close();
            App.Quit();
            Marshal.ReleaseComObject(Book);
            Marshal.ReleaseComObject(Books);
            Book = null;
            Books = null;
            rng = null;
            App = null;
            Sheet = null;
            GC.Collect();
        }
        public Calculare( )
        {
            App = new Application();
            App.Visible = true;
            App.DisplayAlerts = false;
            Books = App.Workbooks;
            Book = Books.Add(Missing.Value);
            Sheet = Book.ActiveSheet;
        }
        public double Calc(double[] args, string equation)
        {
            for (int i = 0; i < args.Length; i++)
                Sheet.Cells[i + 1, 24] = args[i];

            if (equation[0] == '=')
                Sheet.Cells[1, 1] = equation;
            else
                Sheet.Cells[1, 1] = "=" + equation;

            rng = Sheet.Cells[1, 1];
            return double.Parse(rng.Value2.ToString());
        }


    }

}
