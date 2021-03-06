using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Invoiced
{

public class CreditNote : Entity<CreditNote> {


	internal CreditNote(Connection conn) : base(conn) {
	}

	override public long EntityID() {
		return this.Id;
	}

	override public string EntityName() {
		return "customers";
	}

	override public bool HasCRUD() {
		return true;

	}
	override public bool HasList() {
		return false;
	}

	[JsonProperty("id")]
	public long Id { get; set; }

	[JsonProperty("object")]
	public string Object2 { get; set; }

	[JsonProperty("customer")]
	public int Customer { get; set; }

	[JsonProperty("invoice")]
	public int Invoice { get; set; }

	[JsonProperty("name")]
	public object Name { get; set; }

	[JsonProperty("currency")]
	public string Currency { get; set; }

	[JsonProperty("draft")]
	public bool Draft { get; set; }

	[JsonProperty("closed")]
	public bool Closed { get; set; }

	[JsonProperty("paid")]
	public bool Paid { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("number")]
	public string Number { get; set; }

	[JsonProperty("date")]
	public int Date { get; set; }

	[JsonProperty("items")]
	public IList<LineItem> Items { get; set; }

	[JsonProperty("notes")]
	public object Notes { get; set; }

	[JsonProperty("subtotal")]
	public int Subtotal { get; set; }

	[JsonProperty("discounts")]
	public IList<object> Discounts { get; set; }

	[JsonProperty("taxes")]
	public IList<Tax> Taxes { get; set; }

	[JsonProperty("total")]
	public double Total { get; set; }

	[JsonProperty("balance")]
	public double Balance { get; set; }

	[JsonProperty("url")]
	public string Url { get; set; }

	[JsonProperty("pdf_url")]
	public string PdfUrl { get; set; }

	[JsonProperty("created_at")]
	public int CreatedAt { get; set; }

	[JsonProperty("metadata")]
	public  Metadata Metadata { get; set; }

}


}

