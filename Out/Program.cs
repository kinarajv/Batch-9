void Main()
{
	Incrementer(out int a);
	a.Dump();
}
void Incrementer(out int a) {
	a= 1;
	a++;
}
