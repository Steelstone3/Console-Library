using System;

namespace ConsoleLibrary.Presenters.Interfaces
{
    public interface ITextParser
    {
        string Read(string message);
        int Read(string message, int minimumValue, int maximumValue);
        string Read(string message, string regex);
    }
}