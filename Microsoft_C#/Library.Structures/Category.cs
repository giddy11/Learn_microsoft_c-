namespace Library.Structures
{
    public struct Category
    {
        public int GetCategoryNameLength()
        {
            return this.CategoryName.Length;
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
