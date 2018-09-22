using System;
using System.Threading;

namespace App {
	class Program {

		// constant data
		/// <summary>
		/// Minimum producable frequency.
		/// </summary>
		private const int FREQ_MIN = 37;
		/// <summary>
		/// Maximum producable frequency.
		/// </summary>
		private const int FREQ_MAX = 32767;


		// static method
		/// <summary>
		/// My Heart Will Go On
		/// : James Horner, Celine Dion
		/// </summary>
		/// <param name="args">Input arguments.</param>
		static void Main(string[] args) {
			Params p = new Params(args);
			if (p.Time <= 0) return;
			if (p.Freq < FREQ_MIN || p.Freq > FREQ_MAX) Thread.Sleep(p.Time);
			else Console.Beep(p.Freq, p.Time);
		}
	}
}
