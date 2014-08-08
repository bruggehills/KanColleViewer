﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabacr07.KanColleWrapper.Models.Raw
{
	public class kcsapi_battle
	{
		public int api_dock_id { get; set; }
		public api_opening_atack api_opening_atack;
		public api_hougeki1 api_hougeki1;
		public api_hougeki2 api_hougeki2;
		public api_hougeki3 api_hougeki3;
		public api_kouku api_kouku;
		public api_raigeki api_raigeki;
		public int[] api_maxhps;//it works well
		public int[] api_nowhps;
	}
	public class kcsapi_midnight_battle
	{
		public api_hougeki api_hougeki;
		public api_stage3 api_stage3;
		public int[] api_maxhps;//it works well
		public int[] api_nowhps;
	}
	public class api_hougeki
	{
		public object[] api_damage;
		public object[] api_df_list;
	}

	public class api_hougeki1
	{
		public object[] api_damage;
		public object[] api_df_list;
	}
	public class api_hougeki2
	{
		public object[] api_damage;
		public object[] api_df_list;
	}
	public class api_hougeki3
	{
		public object[] api_damage;
		public object[] api_df_list;
	}
	public class api_raigeki
	{
		public decimal[] api_eydam;
		public int[] api_erai;
	}
	public class api_kouku
	{
		public api_stage3 api_stage3;
	}
	public class api_stage3
	{
		public int[] api_frai_flag;
		public decimal[] api_fdam;
	}
	public class listup
	{
		public decimal Damage;
		public int Num;
	}
	public class api_opening_atack
	{
		public decimal[] api_eydam;
		public int[] api_erai;
	}
}
