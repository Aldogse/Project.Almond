﻿using Contracts_and_Models.Models;

namespace Property_and_Supply_Management.Interface
{
	public interface IMaintenanceItemRepository
	{
		Task<List<MaintenanceItem>> GetItemsAsync();
		Task<MaintenanceItem> GetItemIdAsync(int id);
		Task<List<MaintenanceItem>> GetItemInProgressStatusAsync();
		Task<List<MaintenanceItem>> GetItemCompletedStatusAsync();
		Task<List<MaintenanceItem>> GetItemPendingPartsStatusAsync();
	}
}
