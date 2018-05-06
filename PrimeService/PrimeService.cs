namespace PrimeService {
	public class PrimeService {
		public bool IsPrime(int candidate) {
			if (candidate <= 1) {
				return false;
			}
			if (candidate == 2) {
				return true;
			}
			else {
				return candidate % 2 != 0;
			}
		}
	}
}