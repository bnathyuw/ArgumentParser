using ArgumentParser.App;
using NUnit.Framework;

namespace ArgumentParser.Tests
{
	[TestFixture]
	public class Class1
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
			var args = new string[] {"-m"};
			var arg = new Args("l", args);
			Assert.That(arg.IsValid(), Is.False);
		}
	}
}