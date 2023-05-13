namespace SkillIssueDetector.InversionOfControl
{
    internal abstract class TestClass : ITestClass
    {
        public ICollection<object> Dependencies { get; protected set; }

        public TestClass(params object[] dependencies)
        {
            Dependencies = dependencies.ToList();
        }
    }

    internal class NoDependencyClass : TestClass, INoDependencyClass
    {
        public NoDependencyClass() : base() { }
    }

    internal class OneDependencyClass : TestClass, IOneDependencyClass
    {
        public OneDependencyClass(NoDependencyClass noDependencyClass) : base(noDependencyClass) { }
    }

    internal class TwoDependencyClass : TestClass, ITwoDependencyClass
    {
        public TwoDependencyClass(NoDependencyClass noDependencyClass1, NoDependencyClass noDependencyClass2) : base(noDependencyClass1, noDependencyClass2) { }
    }

    internal class TwoDependencyWithDependenciesClass : TestClass, ITwoDependencyWithDependenciesClass
    {
        public TwoDependencyWithDependenciesClass(OneDependencyClass oneDependencyClass, TwoDependencyClass twoDependencyClass) : base(oneDependencyClass, twoDependencyClass) { }
    }
}
