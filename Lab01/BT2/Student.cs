namespace Lab01
{
    class Student 
    {
        private int SID; 
        private string Khoa;
        private string TenSV;
        private float DiemTB;
        
        public Student() //Default constructor
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
        
        public int GetStudentId() => SID;
        public void SetStudentId(int value) => SID = value;

        public string getName() => TenSV;
        public void setName(string value) => TenSV = value;
        
        public string GetFaculty() => Khoa;
        public void SetFaculty(string value) => Khoa = value;

        public float GetMark() => DiemTB;
        public void SetMark(float value) => DiemTB = value;

        public void Show()
        {
            Console.WriteLine("SID: " + GetStudentId());
            Console.WriteLine("Họ và tên: " + getName());
            Console.WriteLine("Khoa: " + GetFaculty());
            Console.WriteLine("Điểm trung bình: " + GetMark());
        }

    }

}