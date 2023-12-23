namespace Exam_5_Modul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exam!\n1-Task.\n2-Task.\n3-Task");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n == 3)
            {
                _13_Bilet bilet = new _13_Bilet();
                bilet.Third();
            }
            if(n == 2)
            {
                Console.WriteLine("1-DeferredExecution.\n2-ImmediateExecution.");
                int func=Convert.ToInt32(Console.ReadLine());

                SecondTask secondTasks = new SecondTask();
                if (func == 1)
                {
                    secondTasks.DeferredExecution();
                }
                if(func == 2)
                {
                    secondTasks.ImmediateExecution();
                }
            }
            if( n == 1)
            {
                First first=new First();
                first.Run();
            }
        }
    }
}