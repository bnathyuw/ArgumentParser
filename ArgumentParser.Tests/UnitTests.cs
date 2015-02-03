using ArgumentParser.App;
using NUnit.Framework;

namespace ArgumentParser.Tests
{
	[TestFixture]
	public class UnitTests
	{
		[Test]
		public void Should_set_boolean_to_true_when_it_is_passed_in()
		{
			var args = new[] {"-l"};
			var arg = new Args("l", args);
			Assert.That(arg.GetBoolean('l'), Is.True);
			Assert.That(arg.IsValid(), Is.True);
		}

		[Test]
		public void Should_set_boolean_to_false_when_it_is_not_passed_in()
		{
			var args = new string[] {};
			var arg = new Args("l", args);
			Assert.That(arg.GetBoolean('l'), Is.False);
			Assert.That(arg.IsValid(), Is.True);
		}

		[Test]
		public void Should_not_be_valid_if_unknown_argument_is_supplied()
		{
			var args = new[] {"-m"};
            var arg = new Args("l", args);
			Assert.That(arg.IsValid(), Is.False);
		}

        [Test]
        public void Should_set_integer_when_it_is_passed_in()
        {
            var args = new[] {"-p", "3000"};
            var arg = new Args("p#", args);
            Assert.That(arg.GetInt('p'), Is.EqualTo(3000));
            Assert.That(arg.IsValid(), Is.True);
        }

        [Test]
        public void Should_set_integer_to_zero_when_no_value_is_passed_in()
        {
            var args = new string[]{};
            var arg = new Args("p#", args);
            Assert.That(arg.GetInt('p'), Is.EqualTo(0));
            Assert.That(arg.IsValid(), Is.True);
        }

        [Test]
        public void Should_set_string_when_it_is_passed_in()
        {
            var args = new[] {"-d", "myPath"};
            var arg = new Args("d*", args);
            Assert.That(arg.GetString('d'), Is.EqualTo("myPath"));
            Assert.That(arg.IsValid(), Is.True);
        }

        [Test]
        public void Should_set_string_to_empty_when_no_value_is_passed_in()
        {
            var args = new string[]{};
            var arg = new Args("d*", args);
            Assert.That(arg.GetString('d'), Is.EqualTo(""));
            Assert.That(arg.IsValid(), Is.True);
        }
    
	}
}