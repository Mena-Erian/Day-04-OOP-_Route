using Assignment.Q1;
using Assignment.Q2;
using Assignment.Q3.Channels;
using Assignment.Q3.NotificationServices;
using System.Threading.Channels;

namespace Assignment
{
    internal class Program
    {

        #region Part02 Q3

        static void sendNotification(INotificationService notificationService, IChannel channel, string massege)
        {
            notificationService.SendNotification(channel, massege);
            channel.ShowNewsToUser();
        }
        #endregion

        #region Part02 Q1
        static void DisplayShape(IShape shape)
        {
            Console.WriteLine("\n---------------------------------");
            shape.DisplayShapeInfo();
            Console.WriteLine("\n---------------------------------");
        }
        #endregion
        static void Main()
        {
            #region Part 01

            #region Q1
            // b) To define  a blueprint for a class
            #endregion

            #region Q2
            // b) protected
            #endregion

            #region Q3
            // b) No
            #endregion

            #region Q4
            // b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5
            // d) implements
            #endregion

            #region Q6
            // a) Yes        (the Default Methods)
            #endregion

            #region Q7
            // a) Yes, for all members
            #endregion

            ///Recap Here---8
            #region Q8
            // b) To provide a clear separation between interface and class members
            #endregion

            #region Q9
            // d) Only if the constructor is static
            #endregion

            #region Q10
            // c) By separating interface names with commas
            #endregion

            #endregion

            #region Part 02

            #region Q1
            /// Rectangle Rectangle = new Rectangle(5, 3);
            /// Circle Circle = new Circle(5);
            ///
            /// DisplayShape(Rectangle);
            /// DisplayShape(Circle);
            #endregion

            #region Q2: Authentication Service
            /// IAuthenticationService authService;
            /// User user = new User() { UserName = "Mona", Password = "pas123", Number = 0 ,Role = Role.Employee };
            /// Console.WriteLine(user.Role);
            /// 
            /// BasicAuthenticationService bAS = new BasicAuthenticationService(new DataBase());
            /// authService = bAS;
            /// 
            /// Console.WriteLine($"authService.AuthenticateUser(user) => {authService.AuthenticateUser(user)}");
            /// Console.WriteLine($"authService.AuthorizeUser(user) => {authService.AuthorizeUser(user)}");
            #endregion

            #region Q3: Notification Service and Channels
            /// ChannelA channelA = new ChannelA()
            /// {
            ///     Id = 1, 
            ///     Name = "ChannelA",
            ///     ChannelProtocol = 456405,
            /// };
            /// ChannelB channelB = new ChannelB()
            /// {
            ///     Id = 2, 
            ///     Name = "ChannelB",
            ///     ChannelProtocol = 5654551,
            /// };
            /// ChannelC channelC = new ChannelC()
            /// {
            ///     Id = 1,
            ///     Name = "ChannelC",
            ///     ChannelProtocol = 456405,
            /// };
            /// 
            /// sendNotification(new PushNotificationService(), channelA, "Push Notification : heres the news....");
            /// sendNotification(new SmsNotificationService(), channelB, "SMS Notification : heres the news....");
            /// sendNotification(new EmailNotificationService(), channelC, "Email Notification : heres the news....");
            #endregion

            #endregion
        }
    }
}
