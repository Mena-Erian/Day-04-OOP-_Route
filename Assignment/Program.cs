using Assignment.Q1;

namespace Assignment
{
    internal class Program
    {
        static void DisplayShape(IShape shape)
        {
            Console.WriteLine("\n---------------------------------");
            shape.DisplayShapeInfo();
            Console.WriteLine("\n---------------------------------");
        }
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

            #endregion
        }
    }
}
