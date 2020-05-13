namespace LINQQueries
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Queries
    {
        public static void Print(IEnumerable<Student> students)
        {
            foreach (var studenet in students)
            {
                Console.WriteLine(studenet);
            }
        }

        public static bool FirstNameBoris(Student student)
        {
            if (student.Name == "Boris")
            {
                return true;
            }

            return false;
        }

        private static void Main()
        {
            var oop = new Course {Id = 1, Name = "OOP"};
            var javaScript = new Course {Id = 2, Name = "JavaScript"};
            var cSharp = new Course {Id = 3, Name = "C#"};
            var html = new Course {Id = 4, Name = "HTML"};

            var students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Zornitca",
                    DateOfBirth = new DateTime(1990, 12, 3),
                    Courses = new List<Course> {oop}
                },
                new Student
                {
                    Id = 2,
                    Name = "Albena",
                    DateOfBirth = new DateTime(1995, 1, 6),
                    Courses = new List<Course> {oop, javaScript, cSharp, html}
                },
                new Student
                {
                    Id = 3,
                    Name = "Pesho",
                    DateOfBirth = new DateTime(1950, 6, 20),
                    Courses = new List<Course>()
                },
                new Student
                {
                    Id = 4,
                    Name = "Boris",
                    DateOfBirth = new DateTime(1989, 4, 9),
                    Courses = new List<Course> {javaScript, html}
                },
                new Student
                {
                    Id = 5,
                    Name = "Unufri",
                    DateOfBirth = new DateTime(1978, 10, 15),
                    Courses = new List<Course> {javaScript, oop, cSharp}
                },
                new Student
                {
                    Id = 6,
                    Name = "Boris",
                    DateOfBirth = new DateTime(2000, 7, 17),
                    Courses = new List<Course> {javaScript, html, cSharp}
                }
            };

            // where first name starts with B
            var studentswithFirstNameB = students.Where(st => st.Name.StartsWith("B"));
            // Print(studentswithFirstNameB);

            //where id  > 3 && courses >= 2
            var whereQueryCoursesId = students.Where(st => st.Id > 3 && st.Courses.Count >= 2);
            // Print(whereQueryCoursesId);


            //first ound with some criteria
            var firstWithNameBoris = students.FirstOrDefault(st => st.Name == "Boris4546");

            //if(firstWithNameBoris == null)
            //{
            //    Console.WriteLine("No such student!");
            //}
            //else
            //{
            //    Console.WriteLine(firstWithNameBoris);
            //}

            var studentName = "Boris";
            var lastWithnameBoris = students.LastOrDefault(st => st.Name == studentName);
            //same thing from the above line can be done as below, but it's slower and we write more code
            // Student lastWithnameBoris = students.LastOrDefault(FirstNameBoris);
            // Console.WriteLine(lastWithnameBoris);

            // select to int
            var coursesCount = students.Select(st => st.Courses.Count);

            //foreach (var courseCount in coursesCount)
            //{
            //    Console.WriteLine(courseCount);
            //}

            //the code below is the same as the one above but done in stupid way, the smarter solution is the code above
            //List<int> coursesCountBalmskiMethod = new List<int>();

            //foreach (var student in students)
            //{
            //    coursesCountBalmskiMethod.Add(student.Courses.Count);
            //}

            // select to class
            var selectToClass = students
                .Select(st =>
                    new ShortStudentinfo
                    {
                        Name = st.Name,
                        CoursesCount = st.Courses.Count
                    });

            // select to anonymous type
            var onlyNamesAndCoursesCount = students
                .Where(st => st.Id > 2)
                .Select(st => new
                {
                    st.Name,
                    CourseCount = st.Courses.Count
                });

            //foreach (var stinfo  in onlyNamesAndCoursesCount)
            //{
            //    Console.WriteLine(stinfo);
            //}

            //cast enum values
            var colours = Enum.GetValues(typeof(ColourEnum)).Cast<ColourEnum>().Select(x => x.ToString());

            //foreach (var colour in colours)
            //{
            //    Console.WriteLine(colour);
            //}

            // order by students by year
            var sortedByYear = students.OrderBy(st => st.DateOfBirth.Year);
            //Print(sortedByYear);

            //order by more things
            var sortedByNameThenByYear = students
                .OrderBy(st => st.Name)
                .ThenBy(st => st.DateOfBirth.Year);

            // Print(sortedByNameThenByYear);

            //nested any
            var someoneInJavaScript =
                students.Any(st => st.Courses.Any(c => c.Name == "javascript"));

            //Console.WriteLine(someoneInJavaScript);

            //anyone with year >= 2000
            var atLeast2000 =
                students.Any(st => st.DateOfBirth.Year >= 2000);
            Console.WriteLine(atLeast2000);

            //cast to array
            var arrayOfStudents = students.ToArray();
            var listOfStudents = students.ToList();

            // reverse
            //students.Reverse();
            //Print(students);

            // student with max and min courses
            var maxStudent = students.Max(st => st.Courses.Count);
            // Console.WriteLine(maxStudent);

            var minStudentId = students.Min(st => st.Id);
            //Console.WriteLine(minStudentId);

            var sum = students.Sum(st => st.DateOfBirth.Year);
            // Console.WriteLine(sum);

            var average = students.Average(st => st.DateOfBirth.Year);
            //Console.WriteLine(average);

            var averageActive = students
                .Where(st => st.Courses.Count > 0)
                .Average(st => st.DateOfBirth.Year);

            // Console.WriteLine(averageActive);

            var countActive = students.Count(st => st.Courses.Count > 2);
            //Console.WriteLine(countActive);

            var someCollection =
                students
                    .Where(st => st.Id > 2 || st.DateOfBirth.Year > 1990)
                    .OrderBy(st => st.Name)
                    .ThenBy(st => st.Courses.Count)
                    .Select(st => new
                    {
                        FirstNameSymbol = st.Name[0],
                        st.DateOfBirth.Year
                    })
                    .ToList();

            foreach (var student in someCollection)
            {
                Console.WriteLine(student);
            }
        }
    }

}