using NUnit.Framework;

namespace PrimeService.Tests {
	public class PrimeServiceTest {
		private PrimeService subject;

		[SetUp]
		public void Setup() {
			this.subject = new PrimeService();
		}

		[TestCase(0, ExpectedResult = false)]
		[TestCase(1, ExpectedResult = false)]
		[TestCase(4, ExpectedResult = false)]
		[TestCase(6, ExpectedResult = false)]
		public bool Not_a_Prime(int number) => this.subject.IsPrime(number);

		[TestCase(2, ExpectedResult = true)]
		[TestCase(3, ExpectedResult = true)]
		[TestCase(5, ExpectedResult = true)]
		[TestCase(7, ExpectedResult = true)]
		// [TestCase(9, ExpectedResult = false)] // Ja, warum bloß ist denn die 9 keine Primzahl?
		public bool Is_a_Prime(int number) => this.subject.IsPrime(number);
	}
}