namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name): base(name)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }
    }
}