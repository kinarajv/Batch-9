//In
//Literally for performance
void Main()
{
	int a = 2;
	Incrementer(in a);
	a.Dump();
}
void Incrementer(in int a) {
	a++;
	int b = a + 1;
}
