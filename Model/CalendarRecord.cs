using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class CalendarRecord
    {
        protected string title;
        protected DateTime startDate;
        protected DateTime startTime;
        protected DateTime endDate;
        protected DateTime endTime;
       
      

       public abstract void addRecord(); 

    }
}
