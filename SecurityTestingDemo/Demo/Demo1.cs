using System;

namespace SecurityTestingDemo.Demo
{
    /// <summary>
    /// This class is used to demonstrate some SonarQube rules.
    /// Enjoy the horror :-)
    /// </summary>

    public abstract class Demo1
    {
        public string async;
        public static bool ShouldDispose = true;

        //TODO: verify if constructor is needed
        public Demo1()
        {
            
        }

        public override string ToString()
        {
            //FIXME: implement this properly
            return null;
        }

        public void Dispose()
        {
            if (ShouldDispose == true)
            {
                //TODO: implement dispose
            }
            else if (ShouldDispose == true)
            {
                //TODO: implement dispose
            }
        }

        public void Test(string a)
        {
            string b;

            if (ShouldDispose)
            {
                goto DisposeMe;
            } 

            Console.WriteLine("This is a test");


            DisposeMe: Dispose();
        }
    }
}
