using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name) // INVOKE BASE CONSTRUCTOR ON NAME
            /*This constructor is required to invoke a constructor from BaseGradeBook.
             * This can be done by adding : base(name) after the constructor declaration. 
             * (this will make it so when the StandardGradeBook constructor is called 
             * it will execute code in 
             * both StandardGradeBook's constructor as 
             * well as the BaseGradeBook's constructor)
             * */
        {
            this.Type = GradeBookType.Standard;
        }

        
    }
}