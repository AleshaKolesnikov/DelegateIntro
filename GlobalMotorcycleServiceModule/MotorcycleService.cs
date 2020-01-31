using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalMotorcycleServiceModule
{
    public class MotorcycleService
    {
        //public static int TotalDistance { get; set; }
        public static int DistanceFromLastService { get; set; }

        public MotorcycleService()
        {
            CheckDistance();
        }
        void CheckDistance()
        {
            if (DistanceFromLastService >= 9_800)
            {
                //Notify
                NotifyAboutService();
            }
        }

        void NotifyAboutService()
        {
            //?
            ResetDistance();
        }

        void ResetDistance()
        {
            DistanceFromLastService = 0;
        }
    }
}
