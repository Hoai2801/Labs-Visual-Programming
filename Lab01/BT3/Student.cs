﻿namespace Lab01
{
    class Student : People
    {
        private int SID; 
        private string Khoa;
        private float DiemTB;
        
        public Student() //Default constructor
        {
            SID = 1;
            Name = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        
        public Student(Student stu) //Copy constructor
        {
            SID = stu.SID;
            Name = stu.Name;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        
        //Constructor with parameters
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            Name = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        
        public int GetStudentId() => SID;
        public void SetStudentId(int value) => SID = value;

        public string GetFaculty() => Khoa;
        public void SetFaculty(string value) => Khoa = value;

        public float GetMark() => DiemTB;
        public void SetMark(float value) => DiemTB = value;

        public void Show()
        {
            Console.WriteLine("SID: " + GetStudentId());
            Console.WriteLine("Họ và tên: " + Name);
            Console.WriteLine("Khoa: " + GetFaculty());
            Console.WriteLine("Điểm trung bình: " + GetMark());
        }

    }

}