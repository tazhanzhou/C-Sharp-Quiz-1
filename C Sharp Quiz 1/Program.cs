using System;
using System.Collections.Generic;

namespace C_Sharp_Quiz_1
{
    class Program
    {
        public delegate int DelCompare(object o1, object o2);
        static void Main(string[] args)
        {
            //1- Which Statement is correct? 
            // b.A dynamic type escapes type checking at run time.

            //2 - Create a class Name is as Employee(id, name, salary)
            //a.Use a generic collection to put 5 employees in that. (Use optional data)
            //b.Iterate through the collection and Write the name of the employee in the console.
            //c.Use delegate to find the lowest and highest salary among the employee
            Employee e1 = new Employee(1, "Jone", 25000);
            Employee e2 = new Employee(22, "Flash", 21000);
            Employee e3 = new Employee(3, "Huck", 22000);
            Employee e4 = new Employee(44, "Spider", 23000);
            Employee e5 = new Employee(5, "Kitty", 24000);
            Employee[] arrayE = new Employee[] { e1, e2, e3, e4, e5 };
            foreach (Employee e in arrayE)
            {
                Console.WriteLine("The employee's name is {0} .", e.name);
            }
            object highestSalary = GetHighestSalary(arrayE,
                (object o1, object o2) => { return ((Employee)o1).salary - ((Employee)o2).salary; });
            Console.WriteLine("{0} have the hightest salary is {1}.",
                ((Employee)highestSalary).name, ((Employee)highestSalary).salary);
            object lowestSalary = GetLowestSalary(arrayE,
                (object o1, object o2) => { return ((Employee)o1).salary - ((Employee)o2).salary; });
            Console.WriteLine("{0} have the lowest salary is {1}.",
                ((Employee)lowestSalary).name, ((Employee)lowestSalary).salary);
            // 3 - Use Tuple to create an object which has 3 fields(name, age, address)
            //and print the fields in the console.
            //a.User Interpolation => $””
            //b.Use Format({ 0}) 
            var studentInfo = Tuple.Create<string, int, string>("MyName", 23, "123 Monreal");
            Console.WriteLine($"Student Info: Name {studentInfo.Item1}, Age {studentInfo.Item2}, Address {studentInfo.Item3}");
            Console.WriteLine("Student Info: Name {0}, Age {1}, Address {2}", studentInfo.Item1, studentInfo.Item2, studentInfo.Item3);
            //4 - Use Dictionary to keep the values of Information of 5 employees in question 2.
            //a.Use employeeId as the key and the office address as the value.
            Dictionary<int, string> eDictionary = new Dictionary<int, string>();
            for (int i = 0; i < arrayE.Length; i++)
            {
                eDictionary.Add(arrayE[i].id, "office address");
            }
            foreach (KeyValuePair<int, string> kvp in eDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            //5 - Create a Generic Class the only accepts class reference
            MyconstraintGenericClass.MyConstraintGenericMethod<Employee>(e5);
            //6 - Use Extension method for integer to check if the number is dividable by 3
            int num = 10;
            num.IsDividable();
            //7 - Write a method that has one string parameter. By Using predicate check if
            //that string has vowel sounds and print all the vowel sounds in the output. 
            string stringHasVowel = "Find all the vowel in this phrase";
            PickUpVowel(stringHasVowel);
            //8 - (Bonus)Use Event / Func / Action / delegate with 2 classes(student,
            //RegisterStudentOperation).If the student graduates, notifies the
            //RegisterStudentOperation and Prints a message in the console.

        }


        static object GetHighestSalary(object[] obj, DelCompare del)
        {
            object hightest = obj[0];
            for (int i = 0; i < obj.Length; i++)
            {
                if (del(hightest, obj[i]) < 0)
                {
                    hightest = obj[i];
                }
            }
            return hightest;
        }
        static object GetLowestSalary(object[] obj, DelCompare del)
        {
            object Lowest = obj[0];
            for (int i = 0; i < obj.Length; i++)
            {
                if (del(Lowest, obj[i]) > 0)
                {
                    Lowest = obj[i];
                }
            }
            return Lowest;
        }
        static void PickUpVowel(string str)
        {
            string[] arrayString = str.Split();
            string[] arrayResult = Array.FindAll(arrayString, (c) => 
            {
                string[] arrayVowel = new string[] { "a","e","i","o","u" };
                foreach(string v in arrayVowel)
                {
                    if (v.Equals(c))
                    {
                        return true;
                    }
                }
                return false;
            }); 
            if(arrayResult.Length == 0)
            {
                Console.WriteLine("No vowel included in this string.");
            }
            else
            {
                foreach(string st in arrayResult)
                {
                    Console.Write(st);
                }
            }
        }
    }
}
