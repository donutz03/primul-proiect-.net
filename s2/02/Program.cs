namespace Enums
{
    internal enum OccupationEnum
    {
        Child = 0,
        Student,
        Employee
    }

    internal struct PersonStruct
    {
        #region Attributes
        public int Age;
        public string Name;
        public OccupationEnum Occupation;
        #endregion

        public PersonStruct(int age, string name, OccupationEnum occupation)
        {
            Age = age;
            Name = name;
            Occupation = occupation;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Occupation: {2}", Name, Age, Occupation);
        }
    }

    internal class Program
    {
        private static void ValueTypeAssignment()
        {
            Console.WriteLine("###Assigning value types\n");
            var personStruct1 = new PersonStruct(1, "name1", OccupationEnum.Student);
            var personStruct2 = personStruct1;

            Console.WriteLine(personStruct1);
            Console.WriteLine(personStruct2);

            personStruct1.Name = "NewName";
            Console.WriteLine(personStruct1);
            Console.WriteLine(personStruct2);
        }

        public static void Main(string[] args)
        {
            ValueTypeAssignment();
        }
    }
}



