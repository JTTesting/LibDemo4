﻿namespace LibDemo
{
    public class LibClass
    {
        private string _message;
        public LibClass(string message) 
        {
            _message = message;
        }
        public string GetMessage()
        {
            return $"{_message} from library4";
        }
    }
}
