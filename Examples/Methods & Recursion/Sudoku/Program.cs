using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        private static SudokuGrid grid = new SudokuGrid();
        static void Main(string[] args)
        {
            PopulateGrid();
            Console.WriteLine(grid.ToString());
            Console.WriteLine("Hit Enter to Begin Solving!!");
            Console.Read();
            // Start Solving.
            grid.Solve();
            Console.WriteLine("Done !!!");
            Console.ReadLine();
        }
    }
}
