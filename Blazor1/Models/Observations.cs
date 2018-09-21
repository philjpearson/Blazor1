//
//	Last mod:	21 September 2018 12:24:54
//
using System;
using System.Collections.Generic;

namespace Blazor1.Models
	{
	public class Param
		{
		public string name { get; set; }
		public string units { get; set; }
		public string dollar { get; set; }
		}

	public class Wx
		{
		public List<Param> Param { get; set; }
		}

	public class Rep
		{
		public string D { get; set; }
		public string H { get; set; }
		public string P { get; set; }
		public string S { get; set; }
		public string T { get; set; }
		public string V { get; set; }
		public string W { get; set; }
		public string Pt { get; set; }
		public string Dp { get; set; }
		public string dollar { get; set; }
		public string G { get; set; }
		}

	public class Period
		{
		public string type { get; set; }
		public string value { get; set; }
		public Rep Rep { get; set; }
		}

	public class Location
		{
		public int i { get; set; }
		public double lat { get; set; }
		public double lon { get; set; }
		public string name { get; set; }
		public string country { get; set; }
		public string continent { get; set; }
		public double elevation { get; set; }
		public Period Period { get; set; }
		}

	public class DV
		{
		public DateTime dataDate { get; set; }
		public string type { get; set; }
		public List<Location> Location { get; set; }
		}

	public class SiteRep
		{
		public Wx Wx { get; set; }
		public DV DV { get; set; }
		}

	public class Observations
		{
		public SiteRep SiteRep { get; set; }
		}
	}
