namespace MyFirstProject
{
    public class CallCenter
    {

        public static CallCenter getInstance()
        {
            if (instance == null)
                instance = new CallCenter();
            return instance;
        }
        public static CallCenter Instance
        {
            get { return instance; }
        }


        public bool AddPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 0 && !phoneNumbers.Contains(phoneNumber))
            {
                phoneNumbers.Add(phoneNumber);
                return true;
            }
            return false;
        }
        public bool Call(string phoneNumber)
        {
            return phoneNumbers.Contains(phoneNumber) ? true : false;
        }
        public List<string> GetPhoneNumbers()
        {
            return phoneNumbers;
        }


        private List<string> phoneNumbers = new List<string>() { "+711111111111", "+72222222222", "+7333333333333", "+7444444444444", "+755555555555" };

        private static CallCenter instance = new CallCenter();
        private CallCenter()
        { }
    }

    class Programm
    {
        static void Main(string[] args)
        {
            CallCenter callCenter = CallCenter.Instance;

            int command = -1;
            while (command != 0)
            {
                Console.WriteLine("Enter a command: ");
                Console.WriteLine("1 - Display all numbers");
                Console.WriteLine("2 - Add phone number");
                Console.WriteLine("3 - Call");
                Console.WriteLine("0 - Exit");

                command = Int32.Parse(Console.ReadLine());
                switch (command)
                {
                    case 0:
                        break;
                    case 1:
                        foreach (string phoneNumber in callCenter.GetPhoneNumbers())
                        {
                            Console.WriteLine(phoneNumber);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Type phone number:");
                        callCenter.AddPhoneNumber(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Type phone number:");
                        bool result = callCenter.Call(Console.ReadLine());
                        Console.WriteLine(result ? "Calling...." : "Number doesn't exist");
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again");
                        break;
                }

            }
        }
    }
}