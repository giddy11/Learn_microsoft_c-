namespace Library.Structures
{
    public struct Category
    {
        //public Category(int categoryID, string categoryName)
        //{
        //    CategoryID = categoryID;
        //    CategoryName = categoryName;
        //}
        public int GetCategoryNameLength()
        {
            return this.CategoryName.Length;
        }
        public int CategoryID { get; set; }
        public int y {  get; set; }
        public string CategoryName { get; set; }
    }

    public struct Point
    {
        public int X;
        public int Y;
    }

    public class MyClass
    {
        public int CategoryID { get; set; }
        public int y { get; set; }
        public string CategoryName { get; set; }
    }

    readonly struct Student
    {
        public Student()
        {
            //studentId = 1;
            //studentName = "Scott";
        }

        public readonly int studentId;
        public readonly string studentName;
    }
}
