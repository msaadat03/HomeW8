using System;

namespace HomeW8
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[6];
            //numbers[0] = 3;
            //numbers[1] = 5;
            //numbers[3] = 7;
            //numbers[4] = 100; 

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            ////UnhandledException
            //int[] numbers = new int[6];
            //numbers[0] = 3;
            //numbers[1] = 5;
            //numbers[3] = 7;
            //numbers[4] = 100;
            //numbers[10] = 66;

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            ////arrayi genişləndirmək
            //int[] number = new int[6];
            //number[0] = 3;
            //number[1] = 5;
            //number[3] = 7;
            //number[4] = 100;

            //Array.Resize(ref number, 30);

            //number[10] = 66;

            //foreach ( var item in number)
            //{
            //    Console.WriteLine(item);
            //}



            ////arrayi siralama
            //int[] nums = { 1, 5, 7, 10, 57, 2, 24 };
            //Array.Sort(nums);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}



            ////#1
            //string name1 = "Saadat";
            //string surname1 = "Mursaliyeva";
            //int age1 = 18;

            //string name2 = "Fidan";
            //string surname2 = "Merdanli";
            //int age2 = 17;

            //Console.WriteLine(name1 + " " + surname1);
            //Console.WriteLine(name2 + " " + surname2);


            ////#2
            //var obj1 = new
            //{
            //    name = "Saadat",
            //    surname = "Murseliyeva",
            //    age = 18
            //};

            //var obj2 = new
            //{
            //    name = "Fidan",
            //    surname = "Merdenli",
            //    age = "17"
            //};

            //Console.WriteLine(obj2 + " " + obj2.surname);



            ////#3
//            Student st1 = new Student();

//            st1.name = "Saadat";
//            st1.surname = "Mursaliyeva";
//            st1.age = 18;

//            Student st2 = new Student();
//            st2.name = "Fidan";
//            st2.surname = "Merdanli";
//            st2.age = 17;

//            Console.WriteLine(st1.FullName());
//            Console.WriteLine(st1.FullData());

//            Student student = new Student();

//            var result = student.GetGroupInfo();


//            Console.WriteLine(result);



//        }

//        class Student
//        {
//            public string name;
//            public int age;
//            public string surname;
//            public string adress;


//            //public Student()
//            //{
//            //    Console.WriteLine("constructor");
//            //}

//            public Student(int age, string adress) : this(adress)
//            {
//                this.adress = adress;
//                Console.WriteLine("Age : " + age);
//            }

//            public Student(string adds) : this(true)
//            {
//                Console.WriteLine("Adress :" + adds);
//            }

//            public Student(bool isnotMarried)
//            {
//                Console.WriteLine("is not married");
//            }




//            public Student(string studentName, int studentAge)
//            {
//                name = studentName;
//                age = studentAge;
//                Console.WriteLine(name);
//            }




//            public string FullName(string adress)
//            {
//                return name + " " + surname + " " + adress;
//            }

//            public string FullData()
//            {
//                return name + " " + surname + "" + age;
//            }


//            public string GetGroupInfo()
//            {
//                Teacher teacher = new Teacher();
//                teacher.name = "Sada";

//                return ($"Teacher name: {teacher.GetTeacherName()} Student name: {name}
//            }
//        }
//    }
//}



