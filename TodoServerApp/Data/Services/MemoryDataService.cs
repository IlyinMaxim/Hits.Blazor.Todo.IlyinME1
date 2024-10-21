using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> Tasks { get; } = [
            new() { Id = 1, Title="Задача 1", Description="Приготовить покушать", CreatedDate=DateTime.Now},
            new() { Id = 2, Title="Задача 2", Description="Поизучать английский язык", CreatedDate=DateTime.Now},
            new() { Id = 3, Title="Задача 3", Description="Сдать на права", CreatedDate=DateTime.Now},
            new() { Id = 4, Title="Задача 4", Description="Сходить в зал и в бассейн", CreatedDate=DateTime.Now},
            new() { Id = 5, Title="Задача 5", Description="Апнуть 4k elo", CreatedDate=DateTime.Now},
        ];

        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Tasks);
        }
    }
}
