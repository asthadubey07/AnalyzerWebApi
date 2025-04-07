// <copyright>
// Copyright (c) 2025 Astha.
// Licensed under the MIT License.
// </copyright>

namespace MyAnalyzerEnabledApi
{
    public class TestClass
    {
        private string? name;

        public string? Name
        {
            get => name;
            set => name = value;
        }

        public void DoStuff()
        {
            string? risky = null;

            if (risky != null)
            {
                Console.WriteLine(risky.Length);
            }
            else
            {
                Console.WriteLine("risky is null");
            }
        }
    }
}
