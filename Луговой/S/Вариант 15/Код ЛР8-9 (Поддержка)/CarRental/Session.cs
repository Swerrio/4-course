using System;

namespace CarRental
{
    // Данные пользователя приложения
    public class AppUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public DateTime CreatedAt { get; set; }

        public string FullName
        {
            get
            {
                string name = ((FirstName ?? "") + " " +
                    (LastName ?? "")).Trim();
                return name.Length == 0 ? "—" : name;
            }
        }
    }

    // Ошибка доступа: операция запрещена текущей роли
    public class AccessDeniedException : Exception
    {
        public AccessDeniedException(string message) : base(message)
        {
        }
    }

    // Текущий сеанс работы: кто вошёл и с какими правами
    public static class Session
    {
        public static AppUser Current;

        public static bool IsAdmin
        {
            get { return Current != null && Current.Role == "Admin"; }
        }

        public static string RoleName
        {
            get
            {
                if (Current == null)
                {
                    return "не выполнен вход";
                }
                return IsAdmin ? "Администратор" : "Пользователь";
            }
        }

        public static void Clear()
        {
            Current = null;
        }

        // Проверка прав выполняется в самой операции, а не только
        // скрытием кнопок на форме
        public static void RequireAdmin(string operation)
        {
            if (!IsAdmin)
            {
                throw new AccessDeniedException(
                    "Операция «" + operation + "» доступна только " +
                    "администратору.");
            }
        }

        public static void RequireSelf(int userId, string operation)
        {
            if (Current == null)
            {
                throw new AccessDeniedException("Вход не выполнен.");
            }
            if (Current.Id != userId && !IsAdmin)
            {
                throw new AccessDeniedException(
                    "Операция «" + operation + "» доступна только для " +
                    "собственного профиля.");
            }
        }
    }
}
