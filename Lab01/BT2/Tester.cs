using System.Collections;

namespace Lab01;

class Tester
{
    public static void Main()
    {
        int n;
        Console.Write("Nhap so luong SV: ");
        n = int.Parse(Console.ReadLine());

        ArrayList DSSV = NhapDS(n);
        XuatDS(DSSV);
    }
    
    public static void Nhap1SV(Student sv)
    {
        Console.Write("Nhap MaSV: ");
        sv.SetStudentId(int.Parse(Console.ReadLine()));
        Console.Write("Ho ten SV: ");
        sv.setName(Console.ReadLine());
        Console.Write("Nhap khoa: ");
        sv.SetFaculty(Console.ReadLine());
        Console.Write("Nhap Diem TB: ");
        sv.SetMark(float.Parse(Console.ReadLine()));
    }
    
    public static ArrayList NhapDS(int n)
    {
        ArrayList ds = new ArrayList(n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin cho sinh vien thu {i + 1}:");
            Student newStudent = new Student();
            Nhap1SV(newStudent);
            ds.Add(newStudent);
        }
        return ds;
    }

    public static void XuatDS(ArrayList DSSV)
    {
        Console.WriteLine("\nXUAT DS SINH VIEN");
        foreach (Student sv in DSSV)
        {
            sv.Show();
        }
    }

}
