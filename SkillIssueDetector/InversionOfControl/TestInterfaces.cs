namespace SkillIssueDetector.InversionOfControl
{
    internal interface ITestClass
    {
        public ICollection<object> Dependencies { get; }
    }

    internal interface INoDependencyClass : ITestClass { }

    internal interface IOneDependencyClass : ITestClass { }

    internal interface ITwoDependencyClass : ITestClass { }
    
    internal interface ITwoDependencyWithDependenciesClass : ITestClass { }
}
