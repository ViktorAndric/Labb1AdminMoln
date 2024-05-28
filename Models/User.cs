using System.ComponentModel.DataAnnotations;

namespace Labb1AdminMoln.Models;

public class User
{
	public Guid Id { get; set; }
	[Required]
	public string Name { get; set; }
	[Required]
	[Range(1, 120)]
	public int Age { get; set; }
}