﻿namespace FoodFood.Data.Models;

public class MealOrder {
	public int Id      { get; set; }
	public int MealId  { get; set; }
	public int OrderId { get; set; }
	public int Quantity { get; set; }
	public Order? Order { get; set; }
	public Meal? Meal { get; set; }
}