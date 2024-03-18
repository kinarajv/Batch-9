public interface IAbility 
{
	void StartAbility();
}
class HulkAbility : IAbility 
{
	public void StartAbility() 
	{
		Console.WriteLine("Hulk Smash!");
	}
}
class IronManAbility : IAbility 
{
	public void StartAbility() 
	{
		Console.WriteLine("Repulsor Blast!");
	}
}