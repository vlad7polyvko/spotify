﻿namespace Core.DTOs.Account
{
    public class UserUpdateDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? PublicPerformerNickName { get; set; }
        public string? Email { get; set; }
        public string? AboutMe { get; set; }
        public string? Image { get; set; }
    }
}