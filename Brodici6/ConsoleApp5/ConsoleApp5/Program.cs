using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{    
    public class Table
    {
        #region Consts

        private const ConsoleColor DefaultTopBorderBackgroundColor = ConsoleColor.DarkGray;
        private const ConsoleColor DefaultLeftBorderBackgroundColor = ConsoleColor.DarkGray;

        private const int DefaultMarginWidth = 20;
        private const int DefaultColumnCount = 10;

        private const int DefaultLeftBorderWidth = 5;

        private const int DefaultRowCount = 15;

        #endregion

        public ConsoleColor TopBorderBackgroundColor { get; set; } = DefaultTopBorderBackgroundColor;
        public ConsoleColor LeftBorderBackgroundColor { get; set; } = DefaultLeftBorderBackgroundColor;

        private int LeftBorderWidth { get; set; } = DefaultLeftBorderWidth;

        public int MarginWidth { get; set; } = DefaultMarginWidth;

        public int ColumnCount { get; set; } = DefaultColumnCount;

        public int RowCount { get; set; } = DefaultRowCount;

        public void WriteMargin()
        {
            Console.Write("".PadLeft(MarginWidth));
        }

        public void WriteTopBorder()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = TopBorderBackgroundColor;
                        
            int rowHeaderWidth = 3;
            int rightBorderWidth = 2;

            int columnWidth = 3;
            int columnLineWidth = 1;

            
            int topBorderWidth = LeftBorderWidth + rowHeaderWidth + LeftBorderWidth + 
                (ColumnCount * columnWidth + (ColumnCount - 1) * columnLineWidth) + 
                rightBorderWidth;


            Console.Write("".PadLeft(topBorderWidth, ' '));

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }
        public void WriteBottomBorder()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = TopBorderBackgroundColor;

            int rowHeaderWidth = 3;
            int rightBorderWidth = 2;
            int columnWidth = 3;
            int columnLineWidth = 1;

            int botBorderWidth = LeftBorderWidth + rowHeaderWidth + LeftBorderWidth +
                (ColumnCount * columnWidth + (ColumnCount - 1) * columnLineWidth) + rightBorderWidth;



            Console.Write("".PadLeft(botBorderWidth, ' '));

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }
        public void WriteLeftBorder()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = LeftBorderBackgroundColor;            

            Console.Write("".PadRight(LeftBorderWidth));

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }
        public void WriteRightBorder()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.Write("  ");

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        public void WriteRowLine()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            
            int columnWidth = 3;
            int columnLineWidth = 1;

            int rowLineWidth = ColumnCount * columnWidth + (ColumnCount - 1) * columnLineWidth;

            Console.Write("".PadRight(rowLineWidth, ' '));

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }
        public void WriteColumnLine()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }
        public enum BojaPolja
        {
            Black=0,
            Green=10,
            Red=12
        }
        public void WriteTableCell()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write(" ? ");

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        public void WriteColumnHeaderLine()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.Write(" ");

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        public void WriteColumnHeader(string text)
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Write($" {text} ");

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        public void WriteRowHeader(string text)
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Write($" {text} ");

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        public void WriteRowHeaderLine()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.Write("   ");

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        public void WriteNewLine()
        {
            Console.WriteLine();
        }

        public void WriteTableColoredCell(BojaPolja boja)
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = (ConsoleColor)boja;

            Console.Write("   ");

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        public void Write(bool[,] matrica, bool[,] rasporedBrodova)
        {
            // Write Top Border
            WriteMargin();
            WriteTopBorder();
            WriteNewLine();

            // Write Column Headers
            WriteMargin();
            WriteLeftBorder();
            WriteRowHeader("-");
            WriteLeftBorder();
            for (int i = 0; i < ColumnCount; i++)
            {
                WriteColumnHeader(i.ToString());

                if (i < ColumnCount - 1)
                    WriteColumnHeaderLine();
            }
            WriteRightBorder();
            WriteNewLine();

            // Write Top Border
            WriteMargin();
            WriteTopBorder();
            WriteNewLine();

            // Write Table Rows
            for (int j = 0; j < RowCount; j++)
            {
                WriteMargin();
                WriteLeftBorder();
                WriteRowHeader(char.ConvertFromUtf32(65 + j));
                WriteLeftBorder();

                for (int i = 0; i < ColumnCount; i++)
                {
                    if (matrica[j, i] == false )
                    {
                        WriteTableCell();
                    }
                    else 
                    {
                        if (rasporedBrodova[j, i] == true)
                        {
                            // pogodak
                            WriteTableColoredCell(BojaPolja.Green);
                        }
                        else
                        {
                            // promasaj
                            WriteTableColoredCell(BojaPolja.Red);
                        }                                                
                    }
                    

                    if (i < ColumnCount - 1) // ako nije poslednja
                        WriteColumnLine();
                }

                WriteRightBorder();
                WriteNewLine();

                if (j < RowCount-1) // ako nije poslednji red
                {
                    // Write Table Row line
                    WriteMargin();
                    WriteLeftBorder();
                    WriteRowHeaderLine();
                    WriteLeftBorder();
                    WriteRowLine();
                    WriteRightBorder();
                    WriteNewLine();
                }
            }

            // Write Bottom Border
            WriteMargin();
            WriteBottomBorder();
            WriteNewLine();
        }

        public void GadjajPolje(ref bool[,] matrica)
        {
            Console.WriteLine();
            Console.Write("Izaberi polje: ");
            string polje = Console.ReadLine();

            if (polje.Length > 1)
            {
                int x = ((int)polje[0]) - 65;
                
                matrica[x, int.Parse(polje[1].ToString())] = true;                
            }                                   
        }        
    }

    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();                        
            Console.WriteLine();

            Table table = new Table();
            table.TopBorderBackgroundColor = ConsoleColor.Red;
            //table.LeftBorderBackgroundColor = ConsoleColor.Red;
            table.MarginWidth = 5;
            table.ColumnCount = 9;
            table.RowCount = 8;            

            bool[,] matrica = new bool[table.RowCount, table.ColumnCount];            

            bool[,] rasporedBrodova = new bool[table.RowCount, table.ColumnCount];



            Ship brod = new Ship("A3", 2, SmerBroda.Desno);
            Ship brod2 = new Ship("F2", 3, SmerBroda.Gore);
            Ship brod3 = new Ship("G7", 4, SmerBroda.Levo);

            PozicionirajBrod(brod, ref rasporedBrodova);
            PozicionirajBrod(brod2, ref rasporedBrodova);
            PozicionirajBrod(brod3, ref rasporedBrodova);


            while (true)
            {
                Console.Clear();

                table.Write(matrica, rasporedBrodova);

                table.GadjajPolje(ref matrica);                
            }
        }

        public static void PozicionirajBrod(Ship ship, ref bool[,] rasporedBrodova)
        {
            int x = ((int)ship.Position[0]) - 65;

            rasporedBrodova[x, int.Parse(ship.Position[1].ToString())] = true;

            for (int i = 1; i < ship.Duzina; i++)
            {

                switch (ship.Smer)
                {
                    case SmerBroda.Gore: rasporedBrodova[x - i, int.Parse(ship.Position[1].ToString())] = true;
                        break;
                    case SmerBroda.Dole: rasporedBrodova[x + i, int.Parse(ship.Position[1].ToString())] = true;
                        break;
                    case SmerBroda.Levo: rasporedBrodova[x, int.Parse(ship.Position[1].ToString()) - i] = true;
                        break;
                    case SmerBroda.Desno: rasporedBrodova[x, int.Parse(ship.Position[1].ToString()) + i] = true;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
