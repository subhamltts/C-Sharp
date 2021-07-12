using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_BussinessLogic
{
    public class Instructor
    {
        private float avgFeedback;
        private int experience;
        private string instructorName;
        private string[] instructorSkill;

        /*public Instructor()
        {

        }*/

        public Instructor(string instructorName, float avgFeedback, int experience, string[] instructorSkill)
        {
            if (avgFeedback < 1.0 || avgFeedback>5.0)
            {
                throw (new FormatException("Average Feedback should be greater than 1.0 and less than 5.0"));
            }

            if (experience < 2)
            {
                throw (new FormatException("Minimum 2 years experience required."));
            }

            if(instructorName == null)
            {
                throw (new ArgumentNullException("Instructor name can not be null"));
            }
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;
        }

        public bool CheckSkill(string technology)
        {
            if (ValidateEligibility())
            {
                if (instructorSkill.Contains(technology))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public bool ValidateEligibility()
        {
            if (experience > 3 && avgFeedback >= 4.5)
            {
                return true;
            }
            else if (experience <= 3 && avgFeedback >= 4.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
