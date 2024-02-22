public enum HumanType {
	Baby,
	Teen,
	Adult
}

class Human {
	private HumanType Type {get;set;}
	public Human() {
		Type = HumanType.Baby;
	}
	public void DoAction() {
		if(Type == HumanType.Baby) {
			Console.WriteLine(HumanType.Baby);
		}
		if(Type == HumanType.Teen) {
			Console.WriteLine(HumanType.Teen);
		}
		if(Type == HumanType.Adult) {
			Console.WriteLine(HumanType.Adult);
		}
	}
	public bool ChangeHumanType(HumanType type) {
		if(Type == type) {
			return false;
		}
		Type = type;
		return true;
	}
}