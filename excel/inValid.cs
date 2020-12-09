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
    class inValid
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


        public inValid()
        {
            App = new Application();
            App.Visible = true;
            App.DisplayAlerts = false;
            Books = App.Workbooks;
            Book = Books.Add(Missing.Value);
            Sheet = Book.ActiveSheet;
        }

        public Ecuatii[] Valid(Ecuatii[] result)
        {


            List<Ecuatii> Validnsti = new List<Ecuatii>();
            //  Sheet.Cells[1, 1].Formula = "=5x1+6";

            for (int i = 0; i < result.Length; i++)
            {
                try
                {
                    if (result[i].equation.IndexOf("X0") != -1 || result[i].equation.IndexOf("x0") != -1)
                        throw new Exception();
                    if (result[i].equation[0] != '=')
                        Sheet.Cells[1, 1].Formula = "=" + result[i].equation;
                    else
                        Sheet.Cells[1, 1].Formula = result[i].equation;
                    Validnsti.Add(result[i]);
                }
                catch { }

            }
            return Validnsti.ToArray();
        }
    }
}

