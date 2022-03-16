class Calculator
 {
	 static void main(string[] args)
	 {
		 int a = 10;
		 int b = 6;
		 console.Writeline("Hasil penambahan : {0} + {1} = {2}", a, b, penambahan(a, b));
		 console.Writeline("Hasil pengurangan : {0} - {1} = {2}", a, b, pengurangan(a, b));
		 
		 console.Writeline("\Tekan Sembarang key untuk keluar");
		 console.ReadKey();
	}
	 static int Penambahan(int a, int b )
	{
		return a + b;
	}
	static int Pengurangan(int a, int b )
	{
		return a - b;
	}
 }
