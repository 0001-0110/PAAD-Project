using InversionOfControl;
using SkillIssueDetector.Utilities;

namespace SkillIssueDetector.InversionOfControl
{
    internal class DependencyInjectorTest
    {
        /*DependencyInjector injector;


        [SetUp]
        public void SetUp()
        {
            injector = new DependencyInjector()
                .Map<IOneDependencyClass, OneDependencyClass>()
                .Map<ITwoDependencyClass, TwoDependencyClass>()
                .Map<ITwoDependencyWithDependenciesClass, TwoDependencyWithDependenciesClass>();
        }

        [Test]
        [TestCase(typeof(INoDependencyClass), typeof(NoDependencyClass))]
        [TestCase(typeof(ITwoDependencyClass), typeof(TwoDependencyClass))]
        public void TestDependencyInjectionWithoutArguments(Type _interface, Type implementation)
        {
            //GenericUtility.CallGeneric(injector, "Map", new Type[] { _interface, implementation });

            object? result = ReflectionUtility.CallPrivate(injector, "Instantiate", new object?[] { _interface, new object[] { }, });
            Assert.IsNotNull(result);
            Assert.IsInstanceOf(implementation, result);
            Assert.IsTrue(((ITestClass)result).Dependencies.All(dependency => dependency != null));
        }

        //[Test]
        //[TestCase()]
        public void TestDependencyIjectionWithArgumengts(Type type, params (Type type, object value)[] arguments)
        {

        }*/
    }
}
