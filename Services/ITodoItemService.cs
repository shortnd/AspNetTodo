using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetTodo.Models;

namespace AspNetTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();

        Task<bool> AddItemAsync(TodoItem newItem);
    }
}