﻿using Contracts_and_Models.Models;
using Contracts_and_Models.Responses;
using Microsoft.EntityFrameworkCore;
using Property_and_Supply_Management.Database;
using Property_and_Supply_Management.Interface;

namespace Property_and_Supply_Management.Repository
{
	public class ItemRepository : IItemRepository
	{
		private readonly PAS_DBContext _pAS_DBContext;

		public ItemRepository(PAS_DBContext pAS_DBContext)
        {
			_pAS_DBContext = pAS_DBContext;
		}

		public async Task<Item> GetItemByIdAsync(int id)
		{
			var item = await _pAS_DBContext.Items.Where(item => item.id == id).Include(d => d.Department).FirstOrDefaultAsync();
			return item;
		}

		public async Task<List<Item>> GetItemsAsync()
		{
			var items = await _pAS_DBContext.Items.Include(d => d.Department).ToListAsync();
			return items;
		}

		public Task<List<Item>> GetItemsByUser(int id)
		{
			throw new NotImplementedException();
		}
	}
}
