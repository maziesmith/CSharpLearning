﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _108_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicConcept();
            //QueryStep();
            //QueryOperation();
            //QueryKeyword();
            //OrderResults();
            //AggregateResults();

            List<Customer> customers = new List<Customer>
                {
                    new Customer { ID="A", City="New York", Country="USA",
                    Region="North America", Sales=9999},
                    new Customer { ID="B", City="Mumbai", Country="India",
                    Region="Asia", Sales=8888},
                    new Customer { ID="C", City="Karachi", Country="Pakistan",
                    Region="Asia", Sales=7777},
                    new Customer { ID="D", City="Delhi", Country="India",
                    Region="Asia", Sales=6666},
                    new Customer { ID="E", City="São Paulo", Country="Brazil",
                    Region="South America", Sales=5555 },
                    new Customer { ID="F", City="Moscow", Country="Russia",
                    Region="Europe", Sales=4444 },
                    new Customer { ID="G", City="Seoul", Country="Korea",
                    Region="Asia", Sales=3333 },
                    new Customer { ID="H", City="Istanbul", Country="Turkey",
                    Region="Asia", Sales=2222 },
                    new Customer { ID="I", City="Shanghai", Country="China",
                    Region="Asia", Sales=1111 },
                    new Customer { ID="J", City="Lagos", Country="Nigeria",
                    Region="Africa", Sales=1000 },
                    new Customer { ID="K", City="Mexico City", Country="Mexico",
                    Region="North America", Sales=2000 },
                    new Customer { ID="L", City="Jakarta", Country="Indonesia",
                    Region="Asia", Sales=3000 },
                    new Customer { ID="M", City="Tokyo", Country="Japan",
                    Region="Asia", Sales=4000 },
                    new Customer { ID="N", City="Los Angeles", Country="USA",Region="North America", Sales=5000 },
                    new Customer { ID="O", City="Cairo", Country="Egypt",
                    Region="Africa", Sales=6000 },
                    new Customer { ID="P", City="Tehran", Country="Iran",
                    Region="Asia", Sales=7000 },
                    new Customer { ID="Q", City="London", Country="UK",
                    Region="Europe", Sales=8000 },
                    new Customer { ID="R", City="Beijing", Country="China",
                    Region="Asia", Sales=9000 },
                    new Customer { ID="S", City="Bogotá", Country="Colombia",
                    Region="South America", Sales=1001 },
                    new Customer { ID="T", City="Lima", Country="Peru",
                    Region="South America", Sales=2002 }
                };//For Complicated Object
            QueryComplicatedObject(customers);
        }

        public static void BasicConcept()
        {
            //Linq: Language Integrated Query
            //SQL: SELECT ID, Name FROM tablename
            //IEnumerable,
            //LINQ to SQL, LINQ to XML, LINQ to DataSet, LINQ to Objects
            #region First
            //int[] numbers = { 5, 10, 8, 3, 6, 12 };

            ////1.Query syntax
            //IEnumerable<int> numQuery1 = from num in numbers
            //                where num % 2 == 0
            //                orderby num
            //                select num;
            //foreach (int num in numQuery1)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("###################");
            ////2.Method Syntax
            //IEnumerable<int> numQuery2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

            //foreach (int item in numQuery2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            #endregion

            int[] numbers = { 5, 10, 8, 3, 6, 12 };

            //1.Query Syntax
            IEnumerable<int> numQuery1 = from num in numbers
                                         where num % 2 == 0
                                         orderby num
                                         select num;
            foreach (int n in numQuery1)
            {
                Console.WriteLine(n);
            }

            //2.Method Syntax
            IEnumerable<int> numQuery2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            foreach (int i in numQuery2)
            {
                Console.WriteLine(i);
            }
        }

        public static void QueryStep()
        {
            //1.Data Source
            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            //2.Query Creation
            IEnumerable<int> numQuery = from num in numbers
                                        where num % 2 == 0
                                        select num;
            //force to execute
            int count = numQuery.Count();
            Console.WriteLine(count);
            numQuery.ToList();
            numQuery.ToArray();
            //3.Query Execution
            foreach (var item in numQuery)//delay to execute
            {

            }
        }

        public static void QueryOperation()
        {
            int[] numbers = { 0, 1, 2, 4, 6, 7 };

            IEnumerable<int> numQuery = from num in numbers
                                            //where num % 2 == 1 && num % 3 == 1
                                        where num % 2 == 1 || num % 3 == 1
                                        select num;
            foreach (int item in numQuery)
            {
                Console.Write("{0} ", item);
            }

            List<LocalCustomer> customers = new List<LocalCustomer>();
            customers.Add(new LocalCustomer { Name = "Jack", City = "BeiJing" });
            customers.Add(new LocalCustomer { Name = "LiLei", City = "ShangHai" });
            customers.Add(new LocalCustomer { Name = "Wangmeimei", City = "BeiJing" });
            IEnumerable<IGrouping<string, LocalCustomer>> queryCustomer = from c in customers
                                                                          group c by c.City;
            foreach (var cg in queryCustomer)
            {
                Console.WriteLine(cg.Key);
                foreach (var c in cg)
                {
                    Console.WriteLine(c.Name);
                }
            }

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Name = "Jack", ID = 101 });
            employees.Add(new Employee { Name = "Emily", ID = 202 });

            var queryJoin = from c in customers
                            join e in employees on c.Name equals e.Name
                            select new { PersonName = c.Name, PersonID = e.ID, PersonCity = c.City };

            foreach (var p in queryJoin)
            {
                Console.WriteLine("{0},{1},{2}", p.PersonName, p.PersonID, p.PersonCity);
            }
            Console.ReadLine();
        }

        public static void QueryKeyword()
        {
            List<LocalCustomer> customers = new List<LocalCustomer>();
            customers.Add(new LocalCustomer { Name = "Zhangsan", City = "ShangHai" });
            customers.Add(new LocalCustomer { Name = "Lisi", City = "Beijing" });
            customers.Add(new LocalCustomer { Name = "Wangwu", City = "Beijing" });

            var queryCustomer = from c in customers
                                group c by c.City into cusGroup
                                where cusGroup.Count() >= 2
                                select new { City = cusGroup.Key, Number = cusGroup.Count() };

            foreach (var c in queryCustomer)
            {
                Console.WriteLine("{0}, {1}", c.City, c.Number);
            }

            string[] strBuffer = { "Hello World", "This is Friday", "Are you happy?" };

            IEnumerable<string> queryStr = from str in strBuffer
                                           let words = str.Split(' ')
                                           from word in words
                                           let w = word.ToUpper()
                                           select w;

            foreach (string item in queryStr)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 排序
        /// </summary>
        public static void OrderResults()
        {
            string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small",
                            "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah"};

            //查询语法
            //var queryResults =
            //    from n in names
            //    where n.StartsWith("S")
            //    orderby n descending
            //    select n;

            //方法语法
            var queryResults = names.OrderBy(n => n).Where(n => n.StartsWith("S"));
            //var queryResults = names.OrderByDescending(n => n).Where(n => n.StartsWith("S"));

            foreach (var item in queryResults)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 聚合运算符 -> 大型数据集
        /// </summary>
        public static void AggregateResults()
        {
            int[] numbers = GenerateManyNumbers(12345678);

            var queryResults =
                from n in numbers
                where n > 1000
                select n;

            Console.WriteLine("Count of Numbers > 1000");
            Console.WriteLine(queryResults.Count());

            Console.WriteLine("Max of Numbers > 1000");
            Console.WriteLine(queryResults.Max());

            Console.WriteLine("Min of Numbers > 1000");
            Console.WriteLine(queryResults.Min());

            Console.WriteLine("Average of Numbers > 1000");
            Console.WriteLine(queryResults.Average());

            Console.WriteLine("Sum of Numbers > 1000");
            Console.WriteLine(queryResults.Sum(n => (long)n));
        }

        /// <summary>
        /// 生成一个大型数据集
        /// </summary>
        public static int[] GenerateManyNumbers(int count)
        {
            Random generator = new Random(0);
            int[] result = new int[count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = generator.Next();
            }

            return result;
        }

        public static void QueryComplicatedObject(List<Customer> customers)
        {
            var queryResults =
                from c in customers
                where c.Region == "Asia"
                select c;

            foreach (var c in queryResults)
            {
                Console.WriteLine(c);
            }
        }
    }

    class LocalCustomer
    {
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    class Customer
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public decimal Sales { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + " City: " + City + " Country: " + Country +
            " Region: " + Region + " Sales: " + Sales;
        }
    }
}
