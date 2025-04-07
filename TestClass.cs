using System;

namespace WorkflowTest
{
    // CS1591: Missing XML comment for publicly visible type or member
    public class TestClass
    {
        // CS8618: Non-nullable field is uninitialized
        public string UninitializedProperty { get; set; }

        // CS1591: Missing XML comment for publicly visible type or member
        public TestClass()
        {
            // CS8602: Dereference of a possibly null reference
            string? nullableString = GetNullableString();
            Console.WriteLine(nullableString.Length);
        }

        // CS1591: Missing XML comment for publicly visible type or member
        public void PublicMethodWithoutComment()
        {
            // Method intentionally left empty to trigger RCS1090
        }

        // IDE0051: Private member is unused
        private void UnusedPrivateMethod()
        {
            Console.WriteLine("This method is never used.");
        }

        private string? GetNullableString()
        {
            return null;
        }
    }
}
