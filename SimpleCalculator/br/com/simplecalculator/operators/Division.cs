﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.br.com.simplecalculator.operators
{
    internal class Division
    {
        private double value1;
        private double value2;
        private double resultDouble;
        private int resultInt;
        private string number;
        public Division() { }

        public bool IsInt(double value)
        {
            this.resultInt = (int)value;

            if (value - this.resultInt != 0) return false;
            else return true;
        }

        public void DivisionMenu()
        {
            Console.Clear();
            Console.WriteLine("Division");
            Console.WriteLine();
            Console.WriteLine("Type the first number:");
            this.number = Console.ReadLine();
            this.value1 = double.Parse(this.number.Replace(',', '.'));
            Console.WriteLine("Type the second number:");
            this.number = Console.ReadLine();
            this.value2 = double.Parse(this.number.Replace(',', '.'));
            this.resultDouble = this.value1 / this.value2;
        }

        public void WriteResult()
        {
            if (IsInt(this.resultDouble)) Console.WriteLine($"The division of the numbers {this.value1} and {this.value2} is equals to {this.resultInt}");
            else Console.WriteLine($"The division of the numbers {this.value1} and {this.value2} is equals to {this.resultDouble}");
        }

    }
}
