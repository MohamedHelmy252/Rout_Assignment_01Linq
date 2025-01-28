
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Linq01.ListGenerators;
using static Linq01.ListGenerators.ListGenerator;
namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq Session 01");
            #region Session 01
            #region 1-Intro To Linq
            //-Language Integrated Query
            //-SQL => DQL , C# => Functions
            //-+ 40 Methods
            //-LINQ operators that added to the existing 
            //IEnumerable and IEnumerable<T> types
            //-Categorized into 13 category
            //------------------------------------------
            //Sequence
            //=>Static    [L2Object]]     [XML [L2XML]]
            //=>Remote    Remote
            //-------------------------------------------
            //طريقه استرجاعه البيانات من اي نوع داتابيز 

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> Odd = list.Where((Num) => Num % 2 == 1).ToList();
            //foreach (int num in Odd)
            //{
            //    Console.WriteLine(num);
            //}




            #endregion
            #region 2-Linq Syntax
            //Syntax => [1.Fluent Syntax] Or [2.Query Syntax]
            //---------------------------------------------
            #region[1.Fluent Syntax]
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //////1-Call "Linq Operator "As => Static Method Through [Enumerable Class]
            ////List<int> Odd = Enumerable.Where(Numbers,(N)=>N%2==1).ToList();
            ////foreach (int n in Odd)
            ////{
            ////    Console.Write(n+" "); //1 3 5 7 9
            ////}

            //////2-Call "Linq Operator "As =>Extension Method
            //List<int> ODD = Numbers.Where(N => N % 2 == 1).ToList();

            //foreach (int n in ODD)
            //{
            //    Console.Write(n + " "); //1 3 5 7 9
            //}
            #endregion
            #region[2.Query Syntax]
            ////Starting With    : KeyWorg "From"
            ////Range Variable N : Represent Each Or Every Element In Sequence
            ////End Use          : Select 

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var Even = from N in Numbers
            //           where N % 2 == 0
            //           select N;


            //foreach (var e in Even)
            //{
            //    Console.Write(e + " "); //2 4 6 8
            //}



            #endregion


            #endregion
            #region 3-LINQ Excusion Way 
            ////1-Deferred execution لو هشتغل مع لست لازم قبل متشتغل تشوف جميل التعديلات الي حصلت حتي لو بعد سطرها
            ////2-Immediate execution عند التعامل مع لست اخرها عن السطر بتاعها حتي لو حصل تعديل تاني تحت سطرها مش هتعتد
            ////=>Element Operators 
            ////=>Casting Operators 
            ////=>Aggregate Operators
            #region 1-Deferred execution 
            //List<int> list= new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Even = list.Where(N=>N%2==0);  //2 4 6 8 10 12 14 16    //Where => Filter Operator
            //list.AddRange(new[] { 12, 14, 16 });
            //foreach (var i in Even) 
            //{
            //    Console.Write(i+" ");
            //}
            #endregion

            #region 2-Immediate execution
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Even = list.Where(N => N % 2 == 0).ToList();  //2 4 6 8 10   //ToList => Filter Operator
            //list.AddRange(new[] { 12, 14, 16 });
            //foreach (var i in Even)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion



            #endregion
            #region 4-Test And Setup Xml File To Vs
            //Console.WriteLine(ListGenerators.ListGenerator.ProductList[0]);
            ////ProductID: 1, ProductName: Chai, Category: Beverages, UnitPrice: $18.00, UnitsInStock: 100
            //Console.WriteLine(ProductList[0]);//هي هي لاني استدعيت ال name space and class name 

            #endregion
            #region 5-LINQ Operators [Filtration operators] Where

            #region 1 ] Get products out of stock
            ////=====================================================================================
            //                                    // Query Syntax            
            ////=====================================================================================


            //var test = from pl in ProductList where pl.UnitsInStock == 0 select pl;
            //foreach (var x in test)
            //{
            //    Console.WriteLine(x);
            //}
            ////ProductID:  5, ProductName: Chef Anton's Gumbo Mix, Category: Condiments, UnitPrice: $21.35        , UnitsInStock: 0
            ////ProductID: 17, ProductName: Alice Mutton, Category: Meat / Poultry, UnitPrice: $39.00             , UnitsInStock: 0
            ////ProductID: 29, ProductName: Thüringer Rostbratwurst, Category: Meat / Poultry, UnitPrice: $123.79 , UnitsInStock: 0
            ////ProductID: 31, ProductName: Gorgonzola Telino, Category: Dairy Products, UnitPrice: $12.50        , UnitsInStock: 0
            ////ProductID: 53, ProductName: Perth Pasties, Category: Meat / Poultry, UnitPrice: $32.80              UnitsInStock: 0
            ////=====================================================================================
            ////Fluent Syntax
            ////=====================================================================================
            //Console.WriteLine("-----------------------------------------------------------------");
            //var test2 = ProductList.Where((N)=>N.UnitsInStock==0);
            //foreach (var x in test2)
            //{
            //    Console.WriteLine(x);
            //}
            ////---------------------------------------------------------------------------------------
            //Console.WriteLine("-----------------------------------------------------------------");
            //var test3 = Enumerable.Where(ProductList,(N)=>N.UnitsInStock==0);
            //foreach (var x in test3)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region 2 ] Get products in stock and in category of Meat/Poultry 
            ////=====================================================================================
            //                                    // Query Syntax            
            ////=====================================================================================


            //var test = from pl in ProductList where(pl.UnitsInStock>0 && pl.Category== "Meat/Poultry")  select pl;
            //foreach (var x in test)
            //{
            //    Console.WriteLine(x);
            //}
            //// ProductID: 9, ProductName: Mishi Kobe Niku, Category: Meat / Poultry, UnitPrice: $97.00, UnitsInStock: 29
            ////ProductID: 54, ProductName: Tourtière, Category: Meat / Poultry, UnitPrice: $7.45, UnitsInStock: 21
            ////ProductID: 55, ProductName: Pâté chinois, Category: Meat / Poultry, UnitPrice: $24.00, UnitsInStock: 115
            ////=====================================================================================
            //                                //Fluent Syntax
            ////=====================================================================================
            //Console.WriteLine("-----------------------------------------------------------------");
            ////Console.WriteLine("-----------------------------------------------------------------");

            //var test2 = Enumerable.Where(ProductList,(N)=>N.UnitsInStock>0 && N.Category== "Meat/Poultry");
            //var test3 = ProductList.Where((N) => N.UnitsInStock > 0 && N.Category == "Meat/Poultry");
            //foreach (var x in test3)
            //{
            //    Console.WriteLine(x);
            //}
            //// ProductID: 9, ProductName: Mishi Kobe Niku, Category: Meat / Poultry, UnitPrice: $97.00, UnitsInStock: 29
            ////ProductID: 54, ProductName: Tourtière, Category: Meat / Poultry, UnitPrice: $7.45, UnitsInStock: 21
            ////ProductID: 55, ProductName: Pâté chinois, Category: Meat / Poultry, UnitPrice: $24.00, UnitsInStock: 115

            #endregion
            #region 3 ] Get products out of stock in first 10 elements


            ////=====================================================================================
            //                                //Fluent Syntax
            ////=====================================================================================
            //Console.WriteLine("-----------------------------------------------------------------");
            ////Where =>>>>>>> index where =>> Give Index TO Make Operation Or Detect Condiction
            //var test3 = ProductList.Where((p,i)=>i<10 && p.UnitsInStock==0);

            //foreach (var x in test3)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion


            #endregion
            #region 6-LINQ Operators [Transformation operators] => [1-Select] , [2-SelectMany]
            #region 1-=Select
            #region 1 ] Select product name
            ////====================Query Syntax========================
            //var test = from PL in ProductList 
            //           select PL.ProductName;
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}
            ////====================Fluent Syntax========================
            //var text2 = ProductList.Select(PL => PL.ProductName);
            //foreach (var item in text2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #region 2-SelectMany  && index 
            #region 3 ] Select customer orders
            ////====================Query Syntax========================
            //var Res = from CL in CustomerList
            //           from O in CL.Orders
            //           select O;
            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}
            //////====================Fluent Syntax========================
            //Console.WriteLine("-----------------------------------------------");
            //var text2 = CustomerList.SelectMany((O)=>O.Orders);
            //foreach (var item in text2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 4 ] Select product id and product name 

            ////====================Query Syntax========================
            //var Res = from PL in ProductList
            //          select (PL.ProductName , PL.ProductID);
            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}
            ////////====================Fluent Syntax========================

            //var test = ProductList.Select(P => P.ProductName + " | " + P.ProductID);
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5 ] Select product in stock and apply discount 10 % on مهممممم       مهممممم  obj مجهول

            ////====================Query Syntax========================
            //var Res = from PL in ProductList
            //          where PL.UnitsInStock > 0
            //          select new {id=PL.ProductID , OldPrice=PL.UnitPrice , NewProce=PL.UnitPrice-(PL.UnitPrice*0.1m) };
            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}
            ////////====================Fluent Syntax========================

            //var test = ProductList.Where(p => p.UnitsInStock > 0).
            //    Select
            //    (p =>  new { id=p.ProductID  ,oldPrice=p.UnitPrice, newPrice=p.UnitPrice-(p.UnitPrice*0.1m) } );
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Indexed
            //var test = ProductList.Where(p => p.UnitsInStock > 0).Select((p, i) => new{Name=p.ProductName,Index=i }) ;
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion





            #endregion
















            #endregion
            #region 7-Ordering Operators
            #region 1 ] Get Products Ordered By Price Asc
            ////Fiuent Syntax
            //var test = ProductList.OrderBy(p => p.UnitPrice);//Asc
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}
            ////Query Syntax
            //Console.WriteLine("---------------------------------------");
            //var test2 = from PL in ProductList
            //            orderby PL.UnitPrice select PL;
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 2 ] Get Products Ordered By Price Desc

            //////Fiuent Syntax
            //var test = ProductList.OrderByDescending(p => p.UnitPrice);//Desc
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}
            //////Query Syntax
            //Console.WriteLine("---------------------------------------");
            //var test2=from PL in ProductList 
            //          orderby PL.UnitPrice descending
            //          select PL;
            //foreach (var item in test2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 3 ] Get Products Ordered By Price Asc and Number Of Items In Stock
            // var test = ProductList.OrderBy(p=>p.UnitPrice).ThenBy(p=>p.UnitsInStock);
            // //order First By [UnitPrice] if We see 2 == price Order by Unitsinstock
            //// var test = ProductList.OrderBy(p => p.UnitPrice).ThenByDescending(p => p.UnitsInStock);
            // foreach (var t in test)
            // {
            //     Console.WriteLine(t);
            // }

            #endregion

            #region Reverse











            #endregion





            #endregion

            #endregion
            #region Assignment 01
            #region 1-LINQ - Restriction Operators


            #region 1.Find all products that are out of stock.
            ////Fluent Syntax
            //var list = Enumerable.Where(ProductList,(P)=>P.UnitsInStock==0);
            //var list2 = ProductList.Where(P=>P.UnitsInStock==0);

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax 
            //Console.WriteLine("--------------------------------");
            //var list3=from PL in ProductList
            //          where PL.UnitsInStock==0
            //          select PL;
            //foreach (var item in list3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            ////Fluent Syntax
            //var list = Enumerable.Where(ProductList,(P)=>P.UnitsInStock>0 && P.UnitPrice>3.00m);
            //var list2 = ProductList.Where(P => P.UnitsInStock > 0 &&P.UnitPrice>3.00m);

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax 
            //Console.WriteLine("--------------------------------");
            //var list3 = from PL in ProductList
            //            where PL.UnitsInStock > 0  && PL.UnitPrice >3.00m
            //            select PL;
            //foreach (var item in list3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Returns digits whose name is shorter than their value.

            //fluent
            //var list = arr.Select((P, I) => new { name = P, value = I }).Where(p => p.name.Length < p.value);

            //foreach (var i in list)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion





            #endregion
            #region 2-LINQ - Ordering Operators

            #region 1-Sort a list of products by name
            ////fluent Syntax
            //var list0 = Enumerable.OrderBy(ProductList,p=>p.ProductName);
            //var list = ProductList.OrderBy(p=>p.ProductName);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////Query Syntax
            //Console.WriteLine("------------------------------");
            //var list2 = from PL in ProductList
            //            orderby PL.ProductName
            //            select PL;
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 2.Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var list = Arr.Order();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region  3.Sort a list of products by units in stock from highest to lowest.
            ////fluent Syntax
            //var list = ProductList.OrderByDescending(p => p.UnitsInStock);
            //var list2 = Enumerable.OrderByDescending(ProductList, P => P.UnitsInStock);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //var list3 = from PL in ProductList
            //            orderby PL.UnitsInStock descending
            //            select PL;
            //foreach (var item in list3)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region  4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ////Fluent Syntax
            //var list = Arr.OrderBy(p => p.Length).ThenBy(p => p);
            //var list2 = Enumerable.OrderBy(Arr,p=>p.Length).ThenBy(p=>p);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //Console.WriteLine("-------------------");
            //var list3 = from A in Arr 
            //            orderby A.Length ,A
            //            select A;

            //foreach (var item in list3)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array. رااااجعع 
            //   string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //Fluent Syntax 
            //var list = words.OrderBy(P => P.Length).ThenBy(P => P, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////Query Syntax 
            //var list2 = from W in words
            //            orderby W.Length, W.ToLower()
            //            select W;
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region  6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //Fluent
            //var list = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //var list2 =from PL in ProductList
            //           orderby PL.Category , PL.UnitPrice descending
            //           select PL;
            #endregion

            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var list = Arr.OrderBy(P => P.Length).ThenBy(P=>P,StringComparer.Ordinal);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ////Fluent Syntax
            //var list = Arr.Where(P => P[1]=='i').Reverse();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////Query Syntax
            //Console.WriteLine("-----------------------------------------------");
            //var list2=(from A in Arr 
            //          where (A[1]=='i')
            //          select A).Reverse();

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            //8 راجع علي ال Query Syntax
            #endregion
            #region 3-LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            ////Fluent Syntax 
            //var list = ProductList.Select(P=>P.ProductName).ToList();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////Query Syntax 
            //Console.WriteLine("-------------------------");
            //var list2 = from PL in ProductList
            //            select PL.ProductName;
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            ////Fluent 
            //var list = words.Select(P => new { Uper=P.ToUpper() , Lower=P.ToLower()});
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //fluent 
            //var list = ProductList.Select(P => new {Name=P.ProductName , Price=P.UnitPrice });
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////Query Syntax 
            //Console.WriteLine("-----------------------------");
            //var list2 = from PL in ProductList 
            //            select new {Name = PL.ProductName , Price= PL.UnitPrice };
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////Floent 
            ////Return Only Number Based On Condition
            //var list = Arr.Select((P, I) => new { Number = P, Index = I }).Where(P => P.Number == P.Index);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////Return True Ans False
            //List<bool> list2 = Arr.Select((P, I) => P == I).ToList();
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var list = from A in numbersA
            //           from B in numbersB
            //           where A < B
            //           select ($"{A} IS Smaler Than {B}");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion
            #region 6. Select all orders where the order total is less than 500.00.
            ////Query Syntax
            //var list = from PL in ProductList
            //           where PL.UnitPrice < 500.00m
            //           select PL;

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////Fluent
            //Console.WriteLine("=================================");
            //var list2 =ProductList.Where(P=>P.UnitPrice<500.00m).Select(P=>P);
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            # region 7. Select all orders where the order was made in 1998 or later

            //var list = ListGenerator.CustomerList.SelectMany(P => P.Orders, (Customer, Order) => new { Order = Order }).Where(x => x.Order.OrderDate.Year >= 1998);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            //7-مهم



            #endregion




            #endregion

        }
    }

}
