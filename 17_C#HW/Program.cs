using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace _17_C_HW
{
    

    [Serializable]



    public class User
    {
        [Range(1000, 9999, ErrorMessage = "ID must be between 1000 and 9999.")]


        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Login can only contain alphanumeric characters.")]


        public string Login { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Password can only contain alphanumeric characters.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]


        public string Password { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Confirm Password can only contain alphanumeric characters.")]
        [MinLength(8, ErrorMessage = "Confirm Password must be at least 8 characters long.")]

        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]


        public string Email { get; set; }

        [CreditCard(ErrorMessage = "Invalid credit card number.")]

        public string CreditCard { get; set; }

        [RegularExpression(@"^\+38-0\d{2}-\d{3}-\d{2}-\d{2}$", ErrorMessage = "Phone must match the format +38-0**-***-**-**.")]

        public string Phone { get; set; }
    }

    public class UserManager
    {
        private Dictionary<int, User> users = new Dictionary<int, User>();


        private string filePath = "users.bin";




        public void ShowMenu()
        {
            LoadData();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. View Users");
                Console.WriteLine("3. Update User");
                Console.WriteLine("4. Delete User");
                Console.WriteLine("5. Save Data");
                Console.WriteLine("6. Load Data");
                Console.WriteLine("7. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    HandleMenuChoice(choice);
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                }
            }
        }




        private void HandleMenuChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    ViewUsers();
                    break;
                case 3:
                    UpdateUser();
                    break;
                case 4:
                    DeleteUser();
                    break;
                case 5:
                    SaveData();
                    break;
                case 6:
                    LoadData();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }




        private void AddUser()
        {
            while (true)
            {
                var user = new User();

                Console.Write("Enter ID: ");
                user.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Login: ");
                user.Login = Console.ReadLine();

                Console.Write("Enter Password: ");
                user.Password = Console.ReadLine();

                Console.Write("Enter Confirm Password: ");
                user.ConfirmPassword = Console.ReadLine();

                Console.Write("Enter Email: ");
                user.Email = Console.ReadLine();

                Console.Write("Enter Credit Card: ");
                user.CreditCard = Console.ReadLine();

                Console.Write("Enter Phone: ");
                user.Phone = Console.ReadLine();

                var results = new List<ValidationResult>();
                var context = new ValidationContext(user);
                if (Validator.TryValidateObject(user, context, results, true))
                {
                    if (user.Password != user.ConfirmPassword)
                    {
                        Console.WriteLine("Password and Confirm Password do not match.");
                    }
                    else
                    {
                        users.Add(user.Id, user);
                        Console.WriteLine("User added successfully.");
                        break;
                    }
                }
                else
                {
                    foreach (var error in results)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
            }
        }




        private void ViewUsers()
        {
            foreach (var user in users.Values)
            {
                Console.WriteLine($"ID: {user.Id}, Login: {user.Login}, Email: {user.Email}, Credit Card: {user.CreditCard}, Phone: {user.Phone}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }




        private void UpdateUser()
        {
            Console.Write("Enter ID of user to update: ");
            int id = int.Parse(Console.ReadLine());

            if (users.ContainsKey(id))
            {
                var user = users[id];
                Console.WriteLine($"Updating User ID: {id}");

                Console.Write($"Enter new Login (current: {user.Login}): ");
                user.Login = Console.ReadLine();

                Console.Write($"Enter new Password (current: {user.Password}): ");
                user.Password = Console.ReadLine();

                Console.Write($"Enter new Confirm Password (current: {user.ConfirmPassword}): ");
                user.ConfirmPassword = Console.ReadLine();

                Console.Write($"Enter new Email (current: {user.Email}): ");
                user.Email = Console.ReadLine();

                Console.Write($"Enter new Credit Card (current: {user.CreditCard}): ");
                user.CreditCard = Console.ReadLine();

                Console.Write($"Enter new Phone (current: {user.Phone}): ");
                user.Phone = Console.ReadLine();

                users[id] = user;
                Console.WriteLine("User updated successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }




        private void DeleteUser()
        {
            Console.Write("Enter ID of user to delete: ");
            int id = int.Parse(Console.ReadLine());

            if (users.ContainsKey(id))
            {
                users.Remove(id);
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }




        private void SaveData()
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, users);
            }
            Console.WriteLine("Data saved successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }




        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Dictionary<int, User> loadedUsers = (Dictionary<int, User>)formatter.Deserialize(fs);

                    Console.WriteLine("1. Overwrite existing data");
                    Console.WriteLine("2. Merge with existing data");

                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        users = loadedUsers;
                    }
                    else if (choice == 2)
                    {
                        foreach (var user in loadedUsers)
                        {
                            if (!users.ContainsKey(user.Key))
                            {
                                users.Add(user.Key, user.Value);
                            }
                            else
                            {
                                Console.WriteLine($"User ID {user.Key} exists. Choose data to keep:");
                                Console.WriteLine("1. Existing data");
                                Console.WriteLine("2. Loaded data");

                                int subChoice = int.Parse(Console.ReadLine());
                                if (subChoice == 2)
                                {
                                    users[user.Key] = user.Value;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
                Console.WriteLine("Data loaded successfully.");
            }
            else
            {
                Console.WriteLine("No data file found.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


    }




    class Program
    {


        static void Main(string[] args)
        {


            UserManager userManager = new UserManager();

            userManager.ShowMenu();



        }
    }

}
