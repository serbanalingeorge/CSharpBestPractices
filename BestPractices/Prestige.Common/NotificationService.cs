using System;

namespace Prestige.Common
{
    public static class NotificationService
    {
        /// <summary>
        /// This notifies Talent
        /// </summary>
        /// <param name="talentName"></param>
        /// <returns></returns>
        public static string NotifyTalent(string talentName)
        {
            var message = "Notifying talent: " + talentName;
            Console.WriteLine(message);
            return message;
        }
    }
}
