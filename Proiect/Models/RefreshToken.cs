﻿namespace Proiect.Models
{
	public class RefreshToken
	{
		public string Token { get; set; } = string.Empty;
		public DateTime TokenCreated { get; set; } = DateTime.Now;
		public DateTime TokenExpires { get; set; }
	}
}
