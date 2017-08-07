namespace RestApi
{
    using RestService;
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task.Factory.StartNew(Test);
            //Console.ReadLine();
            while (true) ;
        }

        static async void Test()
        {

            var rcs = new RestService<Post, int>("http://jsonplaceholder.typicode.com/posts");
            var res = await rcs.AsyncGetAll();
            Console.WriteLine("test");
            foreach (var r in res)
            {
                Console.WriteLine("Post");
                Console.WriteLine(r.Title);

                Console.WriteLine(r.Body);
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine();
            {
                Console.WriteLine("Post");
                var r = await rcs.AsyncGet(1);
                Console.WriteLine(r.Title);
                Console.WriteLine(r.Body);

                Console.WriteLine();
            }
        }
    }
}