public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }

    // In this example its not following Kiss because its a large implementation for something that can be more simple
    /*
    
    public int CalculateBookAge()
    {
        DateTime currentDate = DateTime.Now;
        int years = currentDate.Year - PublicationDate.Year;

        if (currentDate.Month < PublicationDate.Month || 
            (currentDate.Month == PublicationDate.Month && currentDate.Day < PublicationDate.Day))
        {
            years--;
        }

        return years;
    }
    
    */

    //In this method its keeping simple

    public int CalculateBookAge()
    {
        return DateTime.Now.Year - PublicationDate.Year;
    }
}
