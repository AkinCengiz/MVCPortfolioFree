namespace MVCPortfolioFree.DataAccess.Entities;

public class Message
{
	public int Id { get; set; }
	public string FullName { get; set; }
	public string Subject { get; set; }
	public string Email { get; set; }
	public string MessageContent { get; set; }
	public DateTime SendDate { get; set; }
	public bool IsRead { get; set; }
}
