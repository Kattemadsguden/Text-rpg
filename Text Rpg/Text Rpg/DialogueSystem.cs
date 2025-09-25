
class DialougeSystem
{
    
    private string SpeakerName;
    private string Dialouge; 
 
    public DialougeSystem(string SpeakerName, string Dialouge)
    {

        this.SpeakerName = SpeakerName;
        this.Dialouge = Dialouge;

        
    }

    public void displayDialouge()
    {
        Console.WriteLine(SpeakerName+": "+ Dialouge);
        
    }

}