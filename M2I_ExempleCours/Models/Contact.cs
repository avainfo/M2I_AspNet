using System.ComponentModel.DataAnnotations;

namespace M2I_ExempleCours.Models;

public class Contact
{
	public int Id { get; set; }
	[MaxLength(50)] public string Name { get; set; } = "";
	[MaxLength(255)] public string Email { get; set; } = "";
	[MaxLength(9)] public string PhoneNumber { get; set; } = "";

	public override string ToString()
	{
		return $"Id({Id}):\n\tName: {Name}\n\tEmail: {Email}\n\tPhoneNumber: {PhoneNumber}";
	}
}