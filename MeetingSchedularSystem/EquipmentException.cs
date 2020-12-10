using System;


namespace MeetingSchedularSystem
{
    internal class EquipmentException : Exception
    {
        public EquipmentException(string message, Personas persona)
        : base(message)
        {

        }
    }
}

