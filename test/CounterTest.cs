using System;
using Xunit;
using System.Reflection;

namespace BlazorApp.Test
{
    public class CounterTest
    {
        [Fact]
        public void InitialValueTest()
        {
            var counter = new BlazorApp.Pages.Counter();
            var t = counter.GetType();
            var fi = t.GetField("currentCount", BindingFlags.Instance | BindingFlags.NonPublic);
            var result = (int)fi.GetValue(counter);

            Assert.Equal(0, result);
        }

        [Fact]
        public void IncrementValueTest()
        {
            var counter = new BlazorApp.Pages.Counter();
            var t = counter.GetType();
            var mi = t.GetMethod("IncrementCount", BindingFlags.Instance | BindingFlags.NonPublic);
            mi.Invoke(counter, null);

            var fi = t.GetField("currentCount", BindingFlags.Instance | BindingFlags.NonPublic);
            var result = (int)fi.GetValue(counter);

            Assert.Equal(1, result);
        }
    }
}
