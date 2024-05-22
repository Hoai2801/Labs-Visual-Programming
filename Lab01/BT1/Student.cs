namespace Lab01.BT1;

class Student
{
    private int SID;
    private string TenSV;
    private string Khoa;
    private float DiemTB;
    
    public Student() //Constructor mac dinh (default constructor)
    {
        SID = 1;
        TenSV = "Nguyen Van Nam";
        Khoa = "CNTT";
        DiemTB = 7;
    }

    public Student(Student stu) //Copy constructor
    {
        SID = stu.SID;
        TenSV = stu.TenSV;
        Khoa = stu.Khoa;
        DiemTB = stu.DiemTB;
    }

    //Constructor with parameters
    public Student(int id, string ten, string kh, float dtb)
    {
        SID = id;
        TenSV = ten;
        Khoa = kh;
        DiemTB = dtb;
    }

    //Properties for each attribute of the class
    public int StudentID 
    {
        get { return SID; } //Get data
        set { SID = value; } //Set data
    }

    public String Name
    {
        get { return TenSV; }
        set { TenSV = value; }
    }
    
    public String Faculty
    {
        get { return Khoa; }
        set { Khoa = value; }
    }

    public float Mark
    {
        get { return DiemTB; }
        set { DiemTB = value; }
    }

    public void Show()
    {
        Console.WriteLine("SID: " + SID);
        Console.WriteLine("Họ và tên: " + Name);
        Console.WriteLine("Khoa: " + Faculty);
        Console.WriteLine("Điểm trung bình: " + Mark);
    }

}

