using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Role { get; set; } = string.Empty;

        [MaxLength(200)]
        public string FullName { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        // Метод для хэширования пароля
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Метод для проверки пароля
        public bool VerifyPassword(string password)
        {
            string hashedPassword = HashPassword(password);
            return PasswordHash == hashedPassword;
        }
    }

    // Enum для ролей
    public static class UserRoles
    {
        public const string Admin = "Админ";
        public const string Manager = "Управляющий";
        public const string DeputyManager = "ЗамУправляющего";
        public const string SalesManager = "Менеджер";
        public const string KitchenStaff = "Сотрудник Кухни";
        public const string Courier = "Курьер";
        public const string Intern = "Стажер";
    }
}
