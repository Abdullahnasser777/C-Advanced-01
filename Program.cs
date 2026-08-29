namespace C__Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 01
            //// Generic Class : A Class Deined With Type Placeholders (e.g., <T>) Allowing It To Work With Any Data Type Whie Maintaining Type Safety 
            /// Why Use Generics 
            /// 1)Code Reusability : Write Programming Logic Once And Reuse It With Various Data Types 
            /// 2)Type Safety : Catch Type Mismatches At Compile Time Rather Than RunTime 
            /// 3)Performance:Eliminates Boxing And UnBoxing Overhead When Working With Value Types 


            #endregion

            #region Question 02
            //Container<int> intContainer = new Container<int>();
            //intContainer.Add(100);
            //Console.WriteLine(intContainer.Get());

            ///Explanation: The Class Holds An Internal Field Item Of Type T Using Add To Store It And Get To return It 
            #endregion

            #region Question 03
            ////Multiple Type Parameters : The Ability To Specify More Than One Generic Placeholder Separated By Commas Inside Angle Brackets <T1,T2>
            //Pair<int, string> student = new Pair<int, string>(1, "Abdullah");
            //Console.WriteLine($"ID : {student.Key} \nName : {student.Value}");
            ///Explanation:Accepts Two Distnct Type Parameters (TKey And TValue) To Store A Key Value Pair

            #endregion

            #region Question 04
            ////Generic Method : A Method That Defines Its own Type Parameters Independent Of The Class It Resides In
            //int x = 55, y = 65;
            //Helpers.Swap(ref x, ref y);
            //Console.WriteLine($"X : {x}\nY :{y}");
            ///Explanation:Swaps Two Variables Of Any Type T By Reference Using ref
            #endregion

            #region Question 05
            //int maxint = MethHelpers.FindMax(45, 54);
            //string maxstr = MethHelpers.FindMax("Apple", "Mango");
            //Console.WriteLine($"Max int : {maxint} \nMax String : {maxstr}");
            /// Explanation:Uses The Constraint Where T : IComparable <T> To Ensure Type T Exposes The CompareTo Method For EValuation
            #endregion

            #region Question 06
            ////Generic Interface : An InterFace That Defines Contracts Working With Placeholder Types Which Implementing Classes Specify Later
            //IRepository<Product> repo = new ProductRepository();
            //repo.Add(new Product { ID = 2, Name = "laptop" });
            //Console.WriteLine(repo.GetByID(2).Name);
            ///Explanation:Exposes Basic Data Persistence Method (Crud Ops) For Any Entity Type 
            #endregion

            #region Question 07
            ////Struct Constaint: Restricts Type T To Value Types Only (e.g int , double, DataTime)
            //valueCalculator<double> calc = new valueCalculator<double>(90.99);
            //Console.WriteLine(calc.value);
            //valueCalculator<string> invalid;

            ///Explanation:Disallow Reference Types Such As String OR Custom Classes 
            #endregion

            #region Question 08
            //// Class Constraint : Restricts Type T To Reference Types Only
            //RefernceManager<string> manager = new RefernceManager<string>();
            //Console.WriteLine(manager.IsNull(null));
            ///Explanation:Guarantees That Instances Can Be legally Checked Against Null
            #endregion

            #region Question 09
            //// New() Constraint : Specifes That Types T Must Have A Public Parameterless Constructor
            //Factory<Product> factory = new Factory<Product>();
            //Product p = factory.CreateInstance();
            //Console.WriteLine(p.Name);
            ///Explanation: Allow Safe Instantiation Using New T () Within Code
            #endregion

            #region Question 10
            ////interFace Constraint : Specifies That Type T Must Implement A Particular InterFace
            //ExecutionEngine<System.IO.MemoryStream> engine = new ExecutionEngine<System.IO.MemoryStream>();
            //engine.ExecuteAndDispose(new System.IO.MemoryStream());
            ///Explanation:Guarantees Access To InterFace Methods Like Dispose()
            #endregion

            #region Question 11
            ////Base Class Constraint : Requires Type To Iherit From A Specified Base Class
            //EntityManager<User>manager=new EntityManager<User>();
            //manager.PrintID(new User { Id = 102 });
            ///Explanation : Ensures The Method Can Access Properties Like Id Defined In Entity 
            #endregion

            #region Question 12
            ////  ​Applying Multiple Constraints: Comma-separated after where T :. Base Classes must come first, followed by interfaces, then new(). 
            #endregion

            #region Question 13

            ///1) ​default Keyword: Returns the default initial value of type T:
            //​/2) Returns null for reference types.
            ///3)​Returns 0 or false for numeric / boolean value types.

            #endregion

            #region Question 14
            //SafeList<string> names = new SafeList<string>();
            //names.Add("Abdullah");
            //Console.WriteLine(names.GetAt(0));
            //Console.WriteLine(names.GetAt(10) == null ? "null (default)" : names.GetAt(10));
            ///Explanation: Safely returns default rather than throwing an IndexOutOfRangeException.

            #endregion

            #region Question 15 Search Session
            ////Covariance: Allows using a more derived type than originally specified.Declared using the out keyword and applies only to output/return positions.
            ///public interface IReadOnlyProducer<Out T>
            ///{
            ///T Produce();
            ///}

            #endregion

            #region Question 16 Search Session
            ////Contravariance: Allows using a more generic(base) type than originally specified. Declared using the in keyword and applies only to input parameter positions. 
            ///public interface IConsumer<in T>
            ///{
            ///void Consume(T item);
            ///}

            #endregion

            #region Question 17 Search Session
            /// ____________________________________________________________________________ 
            /// |Feature              |     Contravariance     |      Convaiance            |
            /// |___________________________________________________________________________|                     
            /// |KeyWord              |           IN           |         OUT                |
            /// |___________________________________________________________________________|                
            /// |Data Direction       |    Input/Write-Only    |    Output/Read-Only        |
            /// |___________________________________________________________________________|                      
            /// |Conversion Direction |     Base To Derived    |     Derived To Base        |
            /// |___________________________________________________________________________|                      
            /// |Commom Example       |     IComparer<in T>    |   IEnumerable<Out T>       |
            /// |___________________________________________________________________________|                     
            #endregion

            #region Question 18
            ////Static Members: Are not shared across different closed generic types. Each closed generic instantiation creates its own separate static field instance in memory.
            ///public class Counter<T>
            ///{
            ///public static int Count;
            ///}
            /// Counter<int>.Count and Counter<string>.Count are entirely separate memory slots.
            #endregion

            #region Question 19
            ////Three common ways to inherit from a generic base class:  
            ///public class BaseGeneric<T> { }
            /// 1. Specify a concrete type argument
            ///public class IntChild : BaseGeneric<int> { }
            /// 2. Pass through the generic type parameter
            ///public class GenericChild<T> : BaseGeneric<T> { }
            /// 3. Extend with additional type parameters or constraints
            ///public class ExtendedChild<T, U> : BaseGeneric<T> { }

            #endregion

            #region Question 20

            //var cache = new Cache<string, string>();
            //cache.Add("SessionToken", "SH002", TimeSpan.FromSeconds(5));
            //Console.WriteLine($"Token  in Cache : {cache.Get("Session Token")}");
            //System.Threading.Thread.Sleep(5000);
            //Console.WriteLine($"Token After 5s : {cache.Get("Session Token") ??"Expired/Null"}");
            ///Explanation: Encapsulates a Dictionary storing values alongside an ExpirationTime.The Contains method verifies expiration and automatically cleans up stale data. 
            #endregion

        }
    }
}
