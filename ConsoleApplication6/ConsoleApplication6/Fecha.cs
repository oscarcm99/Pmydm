﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Fecha
    {
        private int day;
        private int month;
        private int year;
        public Fecha(int day, int month, int year) {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void escribirFC() {
            Console.WriteLine(Day + "/" + Month + "/" + Year);
        }
        public void escribirFL()
        {
            Console.WriteLine("Dia: "+Day+" Mes: "+Month+" Año: "+Year);
        }
        public bool escorrecta() {
            if ((Day <= 31 && Day > 0) && (Month <= 12 && Month > 0) && (Year <= 2018 && Year > 0))
                return true;
            else
                return false;
        }
    }
}
