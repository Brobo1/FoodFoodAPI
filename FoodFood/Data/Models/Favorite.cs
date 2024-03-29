﻿namespace FoodFood.Data.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public int ResturantId { get; set; }
        public int UserId { get; set; }
        public bool IsFavorite { get; set; }
        public User? User { get; set; }
        public RestaurantRating? RestaurantRating { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}
