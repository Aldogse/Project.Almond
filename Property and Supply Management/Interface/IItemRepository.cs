﻿using Contracts_and_Models.Models;
using Contracts_and_Models.Responses;

namespace Property_and_Supply_Management.Interface
{
	public interface IItemRepository
	{
		Task<List<Item>> GetItemsAsync();
		Task<Item> GetItemByIdAsync(int id);
		Task<List<Item>> GetItemsByUser(int id);
	}
}
