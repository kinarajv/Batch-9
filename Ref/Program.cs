void Main()
{
	int a = 1;
	Incrementer(ref a);
	a.Dump();
}
void Incrementer(ref int a) {
	a++;
}
