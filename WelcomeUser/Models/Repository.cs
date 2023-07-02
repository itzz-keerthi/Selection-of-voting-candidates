using System.Runtime.CompilerServices;

namespace WelcomeUser.Models
{
    public class Repository
    {
        private static List<UserResponse> responses = new();
        public static IEnumerable<UserResponse> Responses = responses;
        public static void AddResponse(UserResponse response)
        {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}
