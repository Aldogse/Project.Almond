﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts_and_Models.Enums;

namespace Contracts_and_Models.Models
{
	public  class Item
	{
		[Key]
		public int id {  get; set; }
		public string asset_name { get; set; }
		public ItemType item_type { get; set; }
		public DateTime purchase_date { get; set; }
		public DateTime? maintenance_date { get; set; }
		[ForeignKey("Department")]
		public int? AssignedTo { get; set; }
		public Department? Department { get; set; }
		public ItemUser? User { get; set; }
		public Status Status { get; set; }
		public DateTime? LastMaintenanceDate { get; set; }

	}
}
