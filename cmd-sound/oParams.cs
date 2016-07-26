namespace cmd_sound {
	class oParams {

		// data
		/// <summary>
		/// Frequency of sound to produce.
		/// </summary>
		public double Freq;
		/// <summary>
		/// Duration of sound in milliseconds.
		/// </summary>
		public double Time;


		// constructor
		/// <summary>
		/// Get parameters from input arguments.
		/// </summary>
		/// <param name="a">Input arguments.</param>
		public oParams(string[] a) {
			for (int i = 0; i < a.Length; i++) {
				if (i == 0) double.TryParse(a[i], out Freq);
				else if (i == 1) double.TryParse(a[i], out Time);
			}
		}
	}
}
