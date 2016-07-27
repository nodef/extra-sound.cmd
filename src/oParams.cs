namespace orez.osound {
	class oParams {

		// data
		/// <summary>
		/// Frequency of sound to produce.
		/// </summary>
		public int Freq;
		/// <summary>
		/// Duration of sound in milliseconds.
		/// </summary>
		public int Time;


		// constructor
		/// <summary>
		/// Get parameters from input arguments.
		/// </summary>
		/// <param name="a">Input arguments.</param>
		public oParams(string[] a) {
			double n = 0;
			for (int i = 0; i < a.Length; i++) {
				if (i == 0) { double.TryParse(a[i], out n); Freq = (int)n; }
				else if (i == 1) { double.TryParse(a[i], out n); Time = (int)n; }
			}
		}
	}
}
