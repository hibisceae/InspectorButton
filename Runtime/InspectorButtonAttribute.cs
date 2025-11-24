using System;

namespace InspectorButton
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class InspectorButtonAttribute : Attribute
    {
        public String Name { get; }
        public Object[] Params { get; }

        public InspectorButtonAttribute(String pName, params Object[] pParams)
        {
            Name = pName;
            Params = pParams;
        }
    }
}

