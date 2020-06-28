/*
 * Magic, Copyright(c) Thomas Hansen 2019 - 2020, thomas@servergardens.com, all rights reserved.
 * See the enclosed LICENSE file for details.
 */

using System;
using System.Linq;
using System.Globalization;
using Xunit;
using magic.node.extensions;

namespace magic.lambda.dates.tests
{
    public class DateTests
    {
        [Fact]
        public void Now()
        {
            var lambda = Common.Evaluate(@"
date.now");
            Assert.Equal(typeof(DateTime), lambda.Children.First().Value.GetType());
        }

        [Fact]
        public void Format()
        {
            var lambda = Common.Evaluate(@"
date.now
date.format:x:-
   format:""MM:yyyy:ddTHH:mm:ss""");
            Assert.Equal(
                lambda.Children.First().GetEx<DateTime>()
                    .ToString("MM:yyyy:ddTHH:mm:ss", CultureInfo.InvariantCulture),
                lambda.Children.Skip(1).First().Value);
        }

        [Fact]
        public void AddTime()
        {
            var lambda = Common.Evaluate(@"
date.now
math.add
   get-value:x:@date.now
   time
      hours:1");
            Assert.Equal(
                lambda.Children.First().GetEx<DateTime>().AddHours(1),
                lambda.Children.Skip(1).First().Value);
        }
    }
}
