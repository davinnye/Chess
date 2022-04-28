using System;


namespace Boards
{
    internal class BoardException : Exception
    {
        public BoardException(string msg) : base(msg) { }
    }
}
