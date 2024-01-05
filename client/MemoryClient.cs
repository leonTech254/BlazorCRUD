using System.Collections.Generic;
using System.Linq;
using BlazorBasics.Models;

namespace BlazorBasics.client
{
    public static class MemoryClient
    {
        private static readonly List<MemoriesModel> memories = new()
        {
            new MemoriesModel
            {
                Id = 1,
                Name = "Safari in Maasai Mara",
                Description = "Witnessing the incredible wildlife",
                Date = "2023-06-10",
                Location = "Maasai Mara, Kenya"
            },
            new MemoriesModel
            {
                Id = 2,
                Name = "Climbing Mount Kenya",
                Description = "Reaching the summit of Africa's second-highest peak",
                Date = "2023-04-05",
                Location = "Mount Kenya, Kenya"
            },
            new MemoriesModel
            {
                Id = 3,
                Name = "Exploring Diani Beach",
                Description = "Enjoying the pristine white sand and crystal-clear waters",
                Date = "2023-08-20",
                Location = "Diani Beach, Kenya"
            }
        };

        public static MemoriesModel[] GetMemories()
        {
            return memories.ToArray();
        }

        public static void AddMemory(MemoriesModel memoriesModel)
        {
            memoriesModel.Id = memories.Max(x => x.Id) + 1;
            memories.Add(memoriesModel);
        }

        public static void DeleteMemory(int id)
        {
            MemoriesModel memoryModel = memories.FirstOrDefault(e => e.Id == id);
            memories.Remove(memoryModel);
        }
    }
}
