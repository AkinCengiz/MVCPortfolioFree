﻿namespace MVCPortfolioFree.DataAccess.Entities;

public class Portfolio
{
	public int Id { get; set; }
	public string Title { get; set; }
	public string SubTitle { get; set; }
	public string Description { get; set; }
	public string ImageUrl { get; set; }
	public string Url { get; set; }
}
