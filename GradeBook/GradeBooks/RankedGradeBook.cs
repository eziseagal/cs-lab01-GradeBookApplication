using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook( string name, bool IsWeight ) : base ( name, IsWeight )
        {
            this.Type = GradeBookType.Ranked;
        }
        public override void CalculateStatistics()
        {
            if (this.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students");
            }
            else if (this.Students.Count >= 5)
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics( string name )
        {
            if(this.Students.Count < 5 )
            {
                Console.WriteLine("Ranked grading requires at least 5 students");
            }
            else if (this.Students.Count >= 5)
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }

    
}
