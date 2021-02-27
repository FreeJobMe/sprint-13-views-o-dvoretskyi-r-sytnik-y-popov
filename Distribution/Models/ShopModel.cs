﻿using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.Models
{
	public class ShopModel
	{
		public string Title { get; set; }
		public List<Position> Positions { get; set; } = new List<Position>();
	}
}
