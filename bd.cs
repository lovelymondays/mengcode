using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            menu:
            Console.WriteLine(" |====================================|");
            Console.WriteLine(" |         Daftar Menu Program        |");
            Console.WriteLine(" |====================================|");
            Console.WriteLine(" | 1. Biodata                         |");
            Console.WriteLine(" | 2. Jenis-jenis tipe data           |");
            Console.WriteLine(" | 3. Operator Aritmatika             |");
            Console.WriteLine(" | 4. LOgika IF                       |");
            Console.WriteLine(" | 5. Logika Switch                   |");
            Console.WriteLine(" | 6. Array 1 Dimensi                 |");
            Console.WriteLine(" | 7. Array 2 Dimensi                 |");
            Console.WriteLine(" | 8. Menghitung 3 luas bangun datar  |");
            Console.WriteLine(" | 9. Logika Sortir                   |");
            Console.WriteLine(" |====================================|");
            Console.Write ("\nMasukkan angka untuk menentukan menu [1-5] : ");
            int pilih = Convert.ToInt32 (Console.ReadLine ());
    
    
    switch (pilih)
    {
        case 1:
        Console.Clear ();
        Console.WriteLine(" ====================================");
        Console.WriteLine("               Biodata               ");
        Console.WriteLine(" ====================================");
        Console.WriteLine("Nama     : Fadli Rachmat Alamsyah    /");
        Console.WriteLine("NPM      : 207006516041              /");
        Console.WriteLine("Kelas    : R02                       /");
        Console.WriteLine("Alamat   : Jl.Menteng Wadas Selatan  /");
        Console.WriteLine("No.HP    : 089602921170              /");
        Console.ReadKey ();
        goto menu;
        break;
        
        case 2:
        Console.Clear();
        Console.WriteLine(" +====================================================+");
        Console.WriteLine("            Penggunaan Jenis-jenis tipe data           ");
        Console.WriteLine(" +====================================================+");
        string nama;
        int umur;
        long npm;
        float tb;
        char nilais1;
        Console.WriteLine("Silahkan Masukkan Data Diri anda : ");
        Console.Write("Nama (String) : ");
        nama = Console.ReadLine();
        Console.Write("Umur (int) : ");
        umur = int.Parse(Console.ReadLine());
        Console.Write("NPM (long) : ");
        npm = long.Parse(Console.ReadLine());
        Console.Write("tinggi Badan (float) : ");
        tb = float.Parse(Console.ReadLine());
        Console.Write("Nilai PDDP Semester 1 |A-D| (char) : ");
        nilais1 = Convert.ToChar(Console.ReadLine());
        Console.WriteLine ("\nTekan tombol enter untuk kembali ke Menu");
        Console.ReadKey ();
        goto menu;
        break;
        
        case 3:
        Console.Clear ();
        Console.WriteLine(" =======================================");
        Console.WriteLine("               ARITMATIKA               ");
        Console.WriteLine(" =======================================");
        Console.Write("\n Angka pertama : ");
        double x = Convert.ToSingle (Console.ReadLine ());
        Console.Write("\n Angka Kedua : ");
        double y = Convert.ToSingle (Console.ReadLine ());
    
        Console.WriteLine(" +=============================================+");
        Console.WriteLine ("                    HASIL                      ");
        Console.WriteLine(" +=============================================+");
        Console.Write ("\n" + x + " + " + y + " = " +
        (x + y));
        Console.Write ("\n" + x + " - " + y + " = " +
        (x - y));
        Console.Write ("\n" + x + " x " + y + " = " +
        (x * y));
        Console.Write ("\n" + x + " : " + y + " = " +
        (x / y));
        Console.Write ("\n" + x + " % " + y + " = " +
        (x % y));
        Console.WriteLine ("\nTekan tombol enter untuk kembali ke Menu");
        Console.ReadKey ();
        goto menu;
        break;
    
        case 4:
        Console.Clear();
        Console.WriteLine(" +=============================================+");
        Console.WriteLine("               Program Logika IF                ");
        Console.WriteLine(" +=============================================+");
        Console.Write ("\n*Syarat nilai untuk mendapat beasiswa minimal 80*");
        Console.Write ("\n Masukkan Nilai : ");
        double nilai = Convert.ToSingle (Console.ReadLine ());
        if (nilai >= 80)
        {
            Console.Write ("\n\n SELAMAT ANDA TELAH LULUS !");
        }
        else
        {
            Console.Write ("\n\n MOHON MAAF ANDA TIDAK LULUS !");
        }
        Console.Write ("\n==========================================");
        Console.WriteLine ("\nTekan tombol enter untuk kembali ke Menu");
        Console.ReadKey ();
        goto menu;    
        break;
        
        case 5:
        Console.Clear();
        Console.WriteLine(" +=============================================+");
        Console.WriteLine("               Program Logika Switch            ");
        Console.WriteLine(" +=============================================+");
        
        string merk;
        Console.WriteLine(" Daftar game terbaik ");                                   
        Console.WriteLine(" 1. CSGO");
        Console.WriteLine(" 2. FIFA21");
        Console.WriteLine(" 3. NBA2K21");
        Console.WriteLine(" 4. RAFT");
        Console.Write(" Silahkan Masukkan Judul Game : ");
        merk = Console.ReadLine();
        switch (merk)
        {
            case "CSGO":
            Console.WriteLine ("\nRating game 90 ");                                                             
            Console.WriteLine ("\nTekan tombol enter untuk kembali ke Menu");
            Console.ReadKey ();
            goto menu;
            break;
            
            case "FIFA21":
            Console.WriteLine ("\nRating game 80 ");                                                                
            Console.WriteLine ("\nTekan tombol enter untuk kembali ke Menu");
            Console.ReadKey ();
            goto menu;
            break;
        
            case "NBA2K21":
            Console.WriteLine ("\nRating game 75 ");                                                                
            Console.WriteLine ("\nTekan tombol enter untuk kembali ke Menu");
            Console.ReadKey ();
            goto menu;
            break;
            
             case "RAFT":
            Console.WriteLine ("\nRating game 87 ");                                                               
            Console.WriteLine ("\nTekan tombol enter untuk kembali ke Menu");
            Console.ReadKey ();
            goto menu;
            break;
            
            default:
            Console.WriteLine(" Mohon Maaf merk yang anda Masukkan Tidak Dapat Ditemukan !!!");
            Console.WriteLine ("\nTekan tombol enter untuk kembali ke Menu");
            Console.ReadKey ();
            goto menu;
            break;
        }
        
        case 6:
        Console.Clear();
        Console.WriteLine(" +==========================================+");
        Console.WriteLine("               Array 1 Dimensi               ");
        Console.WriteLine(" +==========================================+");
        int jumlah;
        Console.Write("Masukkan jenis VGA : ");
        jumlah = int.Parse(Console.ReadLine());
        int[] angka = new int[jumlah];  // ukuran array sesuai inputan pada variabel jumlah
        Console.WriteLine("");
        for (int a = 1 ; a <= angka.Length ; a++){
        Console.Write("Masukkan jenis VGA ke "+a+" : ");
        string sa = Console.ReadLine();
            
        }
        Console.Write("Terima kasih");
        break;
        
        case 7:
        Console.Clear();
        Console.WriteLine(" +==========================================+");
        Console.WriteLine("               Array 1 Dimensi               ");
        Console.WriteLine(" +==========================================+");
        int[][] jagged = new int[5][];
        jagged[0] = new int[9];
        jagged[1] = new int[10];
        jagged[2] = new int[11];
        jagged[3] = new int[12];
        jagged[4] = new int[13];
        int i;
        
        for(i=0; i < 9; i++)
        jagged[0][i] = i;
        
        for(i=0; i < 10; i++)
        jagged[1][i] = i;
        
        for (i = 0; i < 11; i++)
        jagged[2][i] = i;
        
        for (i = 0; i < 12; i++)
        jagged[3][i] = i;
        
        for (i = 0; i < 13; i++)
        jagged[4][i] = i;
        
        for (i = 0; i < 9; i++)
        Console.Write(jagged[0][i] + " ");
        Console.WriteLine();
        
        for (i = 0; i < 10; i++)
        Console.Write(jagged[1][i] + " ");
        Console.WriteLine();
 
        for (i = 0; i < 11; i++)
        Console.Write(jagged[2][i] + " ");
        Console.WriteLine();
        
        for (i = 0; i < 12; i++)
        Console.Write(jagged[3][i] + " ");
        Console.WriteLine();
        
        for (i = 0; i < 13; i++)
        Console.Write(jagged[4][i] + " ");
        Console.WriteLine();
        break;
        
        case 8:
        Console.Clear();
        Console.Clear();
        Console.WriteLine(" +=============================================+");
        Console.WriteLine("               Menghitung Bangun Datar          ");
        Console.WriteLine(" +=============================================+");
        int s, luas;
            Console.WriteLine("1. Hitung Luas Persegi");
            Console.WriteLine("========================================");
            Console.Write("Inputkan Sisi : ");
            s = Convert.ToInt32(Console.ReadLine());
            luas = s * s;
            Console.WriteLine("Luas Persegi Adalah : " + luas);
            Console.WriteLine("=======================================");
                
            int keliling;
            Console.WriteLine("1. Hitung keliling segitiga");
            Console.WriteLine("========================================");
            Console.Write("Inputkan Sisi : ");
            s = Convert.ToInt32(Console.ReadLine());
            keliling = 3 * s;
            Console.WriteLine("keliling Adalah : " + luas);
            Console.WriteLine("=======================================");
                
            int al, tg, l;
            Console.WriteLine("3.Hitung Luas dan Keliling Jajar Genjang");
            Console.WriteLine("======================================");
            Console.Write("Inputkan Alas : ");
            al = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inputkan Tinggi : ");
            tg = Convert.ToInt32(Console.ReadLine());
            l = al * tg;
                
            Console.WriteLine("Luas Jajar Genjang Adalah : " + l);
            Console.WriteLine("=======================================");
            Console.WriteLine(" Terima Kasih ");
            Console.Read();
            break;
            
            case 9:
            Console.Clear();
            Console.Clear();
            Console.WriteLine(" +=====================================+");
            Console.WriteLine("               Logika Sortir            ");
            Console.WriteLine(" +=====================================+");
                
                {
 
        // declaring and initializing the array
        int[] arr = new int[] {1, 9, 6, 7, 5, 9, 8, 112};
 
        // Sort array in ascending order.
        Array.Sort(arr);
 
        // reverse array
        Array.Reverse(arr);
 
        // print all element of array
        foreach(int value in arr)
        {
            Console.Write(value + " ");
        }
    }
            
            Console.Read();
            break; 
 
            
        default:
        Console.WriteLine(" Maaf Tidak ada pilihan");
        break;
    }
        Console.WriteLine(" ===============================================");
        Console.WriteLine("                  TERIMA KASIH                  ");
        Console.WriteLine(" ===============================================");
        Console.ReadLine();
        }
    }
}
 
 