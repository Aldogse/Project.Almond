﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts_and_Models.Enums;

namespace Contracts_and_Models.Responses
{
	public class ItemDetailsResponse
	{
		public int id { get; set; }
		public string asset_name { get; set; }
		public string item_type { get; set; }
		public string purchase_date { get; set; }
		public string? maintenance_date { get; set; }
		public string? AssignedTo { get; set; }
		public string? User { get; set; }
		public string Status { get; set; }
	}
}
