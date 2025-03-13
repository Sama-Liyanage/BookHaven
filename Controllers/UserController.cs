using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookHaven.Models.Services;
using BookHeaven.Models.Entity;

namespace BookHaven.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        // Get a user by their ID
        public async Task<AppUser?> GetUserById(Guid userId)
        {
            return await _userService.GetUserByIdAsync(userId);
        }

        // Get a user by their username
        public async Task<AppUser?> GetUserByUsername(string username)
        {
            return await _userService.GetUserByUsernameAsync(username);
        }

        // Get all users
        public async Task<List<AppUser>> GetAllUsers()
        {
            return (List<AppUser>)await _userService.GetAllUsersAsync();
        }

        // Create a new user
        public async Task<bool> CreateUser(AppUser user)
        {
            try
            {
                await _userService.CreateUserAsync(user);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating user: {ex.Message}");
                return false;
            }
        }

        // Update an existing user
        public async Task<bool> UpdateUser(AppUser user)
        {
            try
            {
                await _userService.UpdateUserAsync(user);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating user: {ex.Message}");
                return false;
            }
        }

        // Delete a user by their ID
        public async Task<bool> DeleteUser(Guid userId)
        {
            try
            {
                await _userService.DeleteUserAsync(userId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting user: {ex.Message}");
                return false;
            }
        }

        // Get users by their role
        public async Task<List<AppUser>> GetUsersByRole(UserRole role)
        {
            return (List<AppUser>)await _userService.GetUsersByRoleAsync(role);
        }

        // Validate a user's credentials (username and password)
        public async Task<AppUser?> ValidateUser(string username, string password)
        {
            return await _userService.ValidateUserAsync(username, password);
        }

        // Check if a username already exists
        public async Task<bool> UsernameExists(string username)
        {
            return await _userService.UsernameExistsAsync(username);
        }
    }
}
