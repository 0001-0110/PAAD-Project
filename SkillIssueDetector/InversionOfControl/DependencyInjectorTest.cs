using InversionOfControl;
using SkillIssueDetector.Utilities;

namespace SkillIssueDetector.InversionOfControl
{
    internal class DependencyInjectorTest
    {
        DependencyInjector injector;

        [SetUp]
        public void SetUp()
        {
            injector = new DependencyInjector()
                .Map<INoDependencyClass, NoDependencyClass>()
                .Map<IOneDependencyClass, OneDependencyClass>()
                .Map<ITwoDependencyClass, TwoDependencyClass>()
                .Map<ITwoDependencyWithDependenciesClass, TwoDependencyWithDependenciesClass>()
                .Map<INoDependencyWithArgsClass, NoDependencyWithArgsClass>()
                .Map<IOneDependencyWithArgsClass, OneDependencyWithArgsClass>()
                .Map<IOneDependencyWithDependenciesAndArgsClass, OneDependencyWithDependenciesAndArgsClass>();
        }

        [Test]
        [TestCase(typeof(INoDependencyClass), typeof(NoDependencyClass))]
        [TestCase(typeof(IOneDependencyClass), typeof(OneDependencyClass))]
        [TestCase(typeof(ITwoDependencyClass), typeof(TwoDependencyClass))]
        [TestCase(typeof(ITwoDependencyWithDependenciesClass), typeof(TwoDependencyWithDependenciesClass))]
        public void TestDependencyInjectionWithoutArguments(Type _interface, Type implementation)
        {
            object? result = ReflectionUtility.CallPrivate(injector, "Instantiate", new object?[] { implementation, new object[] { }, });
            Assert.IsNotNull(result);
            Assert.IsInstanceOf(implementation, result);
            Assert.IsTrue(((ITestClass)result).Dependencies.All(dependency => dependency != null));
            foreach (object dependency in ((ITestClass)result).Dependencies)
                Assert.IsTrue(((ITestClass)dependency).Dependencies.All(dependency => dependency != null));
        }

        [Test]
        [TestCase(typeof(INoDependencyWithArgsClass), typeof(NoDependencyWithArgsClass), "test")]
        [TestCase(typeof(INoDependencyWithArgsClass), typeof(NoDependencyWithArgsClass), 10)]
        [TestCase(typeof(INoDependencyWithArgsClass), typeof(NoDependencyWithArgsClass), 10f)]
        [TestCase(typeof(IOneDependencyWithArgsClass), typeof(OneDependencyWithArgsClass), "test")]
        [TestCase(typeof(IOneDependencyWithArgsClass), typeof(OneDependencyWithArgsClass), 90)]
        [TestCase(typeof(IOneDependencyWithArgsClass), typeof(OneDependencyWithArgsClass), true)]
        [TestCase(typeof(IOneDependencyWithDependenciesAndArgsClass), typeof(OneDependencyWithDependenciesAndArgsClass), "", 10)]
        [TestCase(typeof(IOneDependencyWithDependenciesAndArgsClass), typeof(OneDependencyWithDependenciesAndArgsClass), false, true)]
        [TestCase(typeof(IOneDependencyWithDependenciesAndArgsClass), typeof(OneDependencyWithDependenciesAndArgsClass), 10f)]
        public void TestDependencyIjectionWithArgumengts(Type _interface, Type implementation, params object[] arguments)
        {
            object? result = ReflectionUtility.CallPrivate(injector, "Instantiate", new object?[] { implementation, arguments, });
            Assert.IsNotNull(result);
            Assert.IsInstanceOf(implementation, result);
            Assert.IsTrue(((ITestClass)result).Dependencies.All(dependency => dependency != null));
            foreach (object dependency in ((ITestClass)result).Dependencies)
                Assert.IsTrue(((ITestClass)dependency).Dependencies.All(dependency => dependency != null));
            Assert.IsTrue(arguments.All(arg => ((ITestClassWithArgs)result).Arguments.Contains(arg)));
        }
    }
}
