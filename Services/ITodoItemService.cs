using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetTodo.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync(IdentityUser user);

        Task<bool> AddItemAsync(TodoItem newItem, IdentityUser user);

        Task<bool> MarkDoneAsync(Guid id, IdentityUser user);
    }
}