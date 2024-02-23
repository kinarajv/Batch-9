//Delegate
//Function Pointer

//Publisher-Subscriber Pattern
public delegate void MyDelegate();
void Main()
{
	Email email = new();
	SMS sms = new();
	MyDelegate delegates = email.EmailNotify;
	delegates += sms.SMSNotify;
	delegates += email.SendEmailToOther;
	
	delegates();
	delegates.Invoke();
}
class Email {
	public void EmailNotify() {
		"Email got notified".Dump();
	}
	public void SendEmailToOther() {
		"Email send notification".Dump();
	}
}
class SMS {
	public void SMSNotify() {
		"SMS got notified".Dump();
	}
}