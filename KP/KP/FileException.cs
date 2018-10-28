using System;

namespace KP
{
    class FileException : Exception
    {
        public FileException(string message) : base(message) { }
    }
}
