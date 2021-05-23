namespace UniversityDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();

            var result = model.SubjectsThatReadAtTheUniversity("BSU");
        }
    }
}
