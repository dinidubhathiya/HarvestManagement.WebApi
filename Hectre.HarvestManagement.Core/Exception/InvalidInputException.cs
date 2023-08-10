using System;
namespace Hectre.HarvestManagement.Core.Errors
{
	public class InvalidInputError: ApplicationException
	{
        public InvalidInputError()
        {
        }

        public InvalidInputError(string message)
            : base(message)
        {
        }

        public InvalidInputError(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}

