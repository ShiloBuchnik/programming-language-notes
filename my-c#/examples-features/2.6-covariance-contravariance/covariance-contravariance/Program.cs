using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ns1
{
    class Program
    {
        static void MySetObject(object o)
        {
        }

        static void Main(string[] args)
        {
            {
                // covariance and contravariance enable
                //  implicit reference conversion for
                //      array types,
                //      delegate types, and
                //      generic type arguments
                //
                //  Covariance
                //      preserves assignment compatibility and
                //          Contravariance reverses it.


                // Assignment compatibility.   
                string str = "test";
                object obj = str;   // An object of a more derived type is assigned to an object of a less derived type

                // Covariance.   
                IEnumerable<string> strings = new List<string>();
                // An object that is instantiated with a more derived type argument is assigned
                //      to an object instantiated with a less derived type argument.   
                //          Assignment compatibility is preserved.   
                IEnumerable<object> objects = strings;

                // Contravariance.             
                // Assume that the following method is in the class:   
                Action<object> actObject = MySetObject;
                // An object that is instantiated with a less derived type argument is assigned
                //      to an object instantiated with a more derived type argument.   
                //          Assignment compatibility is (P?)REVERSED.   
                Action<string> actString = actObject;
            }

            {
                //  IEnumerable<T> interface is covariant.

                // interfaces are variant
                //      interface object - because IEnumerable is an interface
                IEnumerable<String> strings = new List<String>();
                IEnumerable<Object> objects = strings;
                //      since 2.0 this is not a compiler error

                IEnumerable<int> integers = new List<int>();
                //IEnumerable<Object> listObjects2 = integers;
                //      compiler error - because int is a value type.  
                //          Error CS0266  Cannot implicitly convert type 'System.Collections.Generic.IEnumerable<int>' to 'System.Collections.Generic.IEnumerable<object>'.An explicit conversion exists (are you missing a cast?)

                // classes are invariant
                IEnumerable<Object> list = new List<String>(); // OK
                //List<Object> list = new List<String>(); // NOT OK
                //      compiler error - because List is a class
                //          Error CS0029  Cannot implicitly convert type 'System.Collections.Generic.List<string>' to 'System.Collections.Generic.List<object>'
            }
        }
    }
}
