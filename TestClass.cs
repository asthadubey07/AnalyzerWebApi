using System;

namespace WorkflowTest
{
    /// <summary>
    /// Represents a test class demonstrating various coding practices.
    /// </summary>
    public class TestClass
    {
        /// <summary>
        /// Gets or sets a property that is initialized to ensure non-nullability.
        /// </summary>
        public string InitializedProperty { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestClass"/> class.
        /// </summary>
        public TestClass()
        {
            InitializedProperty = string.Empty; // CS8618 resolved by initializing the property.

            string? nullableString = GetNullableString();
            if (nullableString != null)
            {
                Console.WriteLine(nullableString.Length); // CS8602 resolved by null-checking.
            }
            else
            {
                Console.WriteLine("String is null.");
            }
        }

        /// <summary>
        /// A public method with XML documentation.
        /// </summary>
        public void PublicMethodWithComment()
        {
            // Method implementation.
        }

        /// <summary>
        /// Gets a nullable string.
        /// </summary>
        /// <returns>A string that may be null.</returns>
        private string? GetNullableString()
        {
            return null;
        }
    }
}
