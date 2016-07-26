using System;

namespace cmd_sound {
	class Program {

		// static method
		/// <summary>
		/// My Heart Will Go On
		/// : James Horner, Celine Dion
		/// </summary>
		/// <param name="args">Input arguments.</param>
		static void Main(string[] args) {
			oParams p = new oParams(args);
			if (p.Freq <= 0 || p.Time <= 0) return;
			Console.Beep((int)p.Freq, (int)p.Time);
		}
	}
}
