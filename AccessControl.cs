using dodoEF.MyEF.Entities;
using System.Collections.Generic;

namespace dodoEF
{
    public static class AccessControl
    {
        // Определяем права доступа для каждой роли
        private static readonly Dictionary<string, HashSet<string>> RolePermissions = new Dictionary<string, HashSet<string>>
        {
            {
                UserRoles.Admin, new HashSet<string>
                {
                    "PersonalListForm",
                    "OderListForm",
                    "ClientListForm",
                    "TovarListForm",
                    "CategoriEnumForm",
                    "EvelobEnumForm",
                    "IngrEnumForm",
                    "PlategEnumForm"
                }
            },
            {
                UserRoles.Manager, new HashSet<string>
                {
                    "PersonalListForm",
                    "OderListForm",
                    "ClientListForm",
                    "TovarListForm",
                    "EvelobEnumForm",
                    "IngrEnumForm",
                    "PlategEnumForm"
                }
            },
            {
                UserRoles.DeputyManager, new HashSet<string>
                {
                    "PersonalListForm",
                    "OderListForm",
                    "ClientListForm",
                    "TovarListForm",
                    "EvelobEnumForm",
                    "IngrEnumForm",
                    "PlategEnumForm"
                }
            },
            {
                UserRoles.SalesManager, new HashSet<string>
                {
                    "OderListForm",
                    "ClientListForm",
                    "TovarListForm",
                    "IngrEnumForm",
                    "PlategEnumForm"
                }
            },
            {
                UserRoles.KitchenStaff, new HashSet<string>
                {
                    "OderListForm",
                    "TovarListForm",
                    "IngrEnumForm"
                }
            },
            {
                UserRoles.Courier, new HashSet<string>
                {
                    "OderListForm",
                    "ClientListForm",
                    "PlategEnumForm"
                }
            },
            {
                UserRoles.Intern, new HashSet<string>
                {
                    "TovarListForm",
                    "IngrEnumForm"
                }
            }
        };

        public static bool HasAccess(string role, string formName)
        {
            // Нормализуем роль (убираем пробелы и приводим к нижнему регистру)
            string normalizedRole = role?.Trim().ToLower() ?? "";
            
            foreach (var kvp in RolePermissions)
            {
                if (kvp.Key.Trim().ToLower() == normalizedRole)
                {
                    return kvp.Value.Contains(formName);
                }
            }
            return false;
        }

        public static HashSet<string> GetPermissions(string role)
        {
            // Нормализуем роль (убираем пробелы и приводим к нижнему регистру)
            string normalizedRole = role?.Trim().ToLower() ?? "";
            
            foreach (var kvp in RolePermissions)
            {
                if (kvp.Key.Trim().ToLower() == normalizedRole)
                {
                    return kvp.Value;
                }
            }
            return new HashSet<string>();
        }
    }
}
