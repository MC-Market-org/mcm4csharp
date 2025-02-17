﻿using System;
using System.Text.Json.Serialization;

namespace mcm4csharp.v1.Data.Content
{
	public struct LicenseContent
	{
		[JsonPropertyName("purchaser_id")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public ulong PurchaserId { get; set; }

		[JsonPropertyName("permanent")]
		public bool Permanent { get; set; }

		[JsonPropertyName("active")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool Active { get; set; }

		[JsonPropertyName("start_date")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public ulong StartDate { get; set; }

		[JsonPropertyName("end_date")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public ulong EndDate { get; set; }
	}
}

