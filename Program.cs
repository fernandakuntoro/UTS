using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PEMROGRAMAN
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama, course;
            int nik;

            Dosen tetap = new Dosen();
            tetap.id = 21;
            tetap.nama = "Kamarudin, M.Kom";
            tetap.Nik = 192021;
            tetap.gender = "Laki-laki";
            tetap.course = "Pemrograman";

            Console.WriteLine("===== DATA DOSEN DEFAULT =====");
            Console.WriteLine();
            tetap.dosen();
            Console.WriteLine();

            Console.WriteLine("===== INPUT DATA DOSEN BARU =====");
            Console.WriteLine();
            Console.Write("Masukkan Nama Dosen \t\t: ");
            nama = Console.ReadLine();

            Console.Write("Masukkan NIK Dosen \t\t: ");
            nik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Mata Kuliah Dosen \t: ");
            course = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("===== DATA DOSEN YANG SUDAH DIINPUTKAN =====");
            Console.WriteLine();
            Dosen.attdosen(nama, nik);
            Dosen.addcourse(course);

            Console.ReadKey();
        }
    }
}