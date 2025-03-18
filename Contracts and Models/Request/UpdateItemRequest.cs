using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts_and_Models.Enums;
using Contracts_and_Models.Models;

namespace Contracts_and_Models.Request
{
	public  class UpdateItemRequest
	{
		public string asset_name { get; set; }
		public ItemType item_type { get; set; }
		public DateTime purchase_date { get; set; }
		public DateTime? maintenance_date { get; set; }
		public int? AssignedTo { get; set; }
		public ItemUser? User { get; set; }
		public DateTime? LastMaintenanceDate { get; set; }
	}
}
