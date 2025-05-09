namespace LibDemo4
{
    public class LibClass4
    {
        private string _message;
        public LibClass4(string message) 
        {
            _message = message;
        }
        public string GetMessage4()
        {
            return $"{_message} from Library4";
        }
    }
}
