using System;

namespace ClassLibrary1
{
    public enum LevelOfResponsibility
    {
        Undetermined,
        Highest, 
        Average, 
        Low
    }

    
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class OfficerAttribute: Attribute
    {
        public LevelOfResponsibility Responsibility { get; set; }
    }

    public abstract class Officer
    {
        public Type GetClassName() => this.GetType();
        
    }
}
