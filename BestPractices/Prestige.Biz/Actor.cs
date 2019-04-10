using System;

namespace Prestige.Biz
{
    public class Actor
    {
        private string _actorName;
        private Agency _currentAgency;

        public string ActorName {
            get => _actorName;
            set
            {
                var formattedName = value?.Trim();
                _actorName = formattedName;
            }
        }

        private string JobTitle { get; set; }
        public int ActorAge { get; set; }
        public string ActorDescription { get; set; } = "Regular actor";

        public Agency CurrentAgency
        {
            get => _currentAgency ?? (_currentAgency = new Agency());
            set => _currentAgency = value;
        }

        public Actor()
        {
            Console.WriteLine("An actor is born.");
            //CurrentAgency = new Agency();
        }
        public Actor(string actorName):this()
        {
            ActorName = actorName;
        }
        /// <summary>
        /// Will return title
        /// </summary>
        public string GetOccupation()
        {
            JobTitle = "Actor";
            return JobTitle;
        }
        /// <summary>
        /// Books actor and not date specified.
        /// </summary>
        public string BookActor()
        {
            return BookActor(string.Empty);
        }

        /// <summary>
        /// Books actor on specific date.
        /// </summary>
        /// <param name="theDate"></param>
        /// <returns></returns>
        public string BookActor(string theDate)
        {
            var details = "Booking can change if actor starts trouble.";
            var theActor = "Actor " + ActorName + " is booked";
            if (theDate != string.Empty)
            {
                return theActor + " on " + theDate + ". " + details;
            }
            return theActor + ". " + details;
        }

        public string GetAgency()
        {
            //var currentAgency = new Agency();
            return CurrentAgency.Name;
        }
    }
}
