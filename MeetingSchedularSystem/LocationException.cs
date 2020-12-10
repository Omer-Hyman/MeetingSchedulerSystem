using System;


namespace MeetingSchedularSystem
{
    internal class LocationException : Exception
    {
        public LocationException(string message, Personas persona)
        : base(message)
        {

        }
    }
}
