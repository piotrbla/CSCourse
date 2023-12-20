
using System.Reflection;
using Xunit.Sdk;

namespace TestLibraryTest
{
    public class TestLibraryTest
    {
        [Fact]
        public void LibraryStaticAddWorks()
        {
            //Assert.Equal(3, TestClassLibrary.TestLibraryClass.Add(1, 2));
            //Assert.Equal(1, TestClassLibrary.TestInternalClass.Add(1, 2);
        }
        [Fact]
        public void ReflectionTest()
        {
            var assembly = Assembly.LoadFrom("TestClassLibrary.dll");
            var type = assembly.GetType("TestClassLibrary.TestLibraryClass");
            if (type != null)
            {
                var method = type.GetMethod("Add");
                if (method != null)
                {
                    var result = method.Invoke(null, new object[] { 1, 2 });
                    Assert.Equal(3, result);
                }
            }
        }

        [Fact]
        public void ReflectionInternalTest()
        {
            var assembly = Assembly.LoadFrom("TestClassLibrary.dll");
            var type = assembly.GetType("TestClassLibrary.TestInternalClass");
            if (type != null)
            {
                var method = type.GetMethod("Add");
                if (method != null)
                {
                    var result = method.Invoke(null, new object[] { 1, 2 });
                    Assert.Equal(3, result);
                }
            }
        }

        [Fact]
        public void ReflectionCanCreateObjects()
        {
            var assembly = Assembly.LoadFrom("TestClassLibrary.dll");
            var type = assembly.GetType("TestClassLibrary.TestNonStaticClass");
            if (type != null)
            {
                var instance = Activator.CreateInstance(type);
                var method = type.GetMethod("MakeProgress");
                if (method != null)
                {
                    method.Invoke(instance, null);
                    method.Invoke(instance, null);
                    method.Invoke(instance, null);
                    method.Invoke(instance, null);

                    var propertyCount = type.GetProperty("Count");
                    if (propertyCount != null)
                    {
                        var count = propertyCount.GetValue(instance);
                        Assert.Equal(4, count);
                    }
                    
                }
            }
        }
    }
}