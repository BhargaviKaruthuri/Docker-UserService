﻿namespace UserService.Models
{
    public class UserDto
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public string Address { get;set; } = string.Empty;  
        public bool isActive { get; set; }
    }
}
