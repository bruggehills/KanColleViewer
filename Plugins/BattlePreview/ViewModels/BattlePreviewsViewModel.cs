﻿using Grabacr07.KanColleWrapper;
using Grabacr07.KanColleWrapper.Models;
using Grabacr07.KanColleWrapper.Models.Raw;
using Livet;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Grabacr07.KanColleViewer.Plugins.ViewModels
{
	public class BattlePreviewsViewModel : ViewModel
	{
		#region KanResultReport 変更通知プロパティ

		private List<PreviewBattleResults> _KanResultReport;

		public List<PreviewBattleResults> KanResultReport
		{
			get { return this._KanResultReport; }
			set
			{
				if (this._KanResultReport != value)
				{
					this._KanResultReport = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region EnemyResultReport 変更通知プロパティ

		private List<PreviewBattleResults> _EnemyResultReport;

		public List<PreviewBattleResults> EnemyResultReport
		{
			get { return this._EnemyResultReport; }
			set
			{
				if (this._EnemyResultReport != value)
				{
					this._EnemyResultReport = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region SecondResultReport 変更通知プロパティ

		private List<PreviewBattleResults> _SecondResultReport;

		public List<PreviewBattleResults> SecondResultReport
		{
			get { return this._SecondResultReport; }
			set
			{
				if (this._SecondResultReport != value)
				{
					this._SecondResultReport = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region CellStatus 変更通知プロパティ

		private int _CellStatus;

		public int CellStatus
		{
			get { return this._CellStatus; }
			set
			{
				if (this._CellStatus != value)
				{
					this._CellStatus = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region PerfectRank 変更通知プロパティ

		private Visibility _PerfectRank;

		public Visibility PerfectRank
		{
			get { return this._PerfectRank; }
			set
			{
				if (this._PerfectRank != value)
				{
					this._PerfectRank = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region RankS 変更通知プロパティ

		private Visibility _RankS;

		public Visibility RankS
		{
			get { return this._RankS; }
			set
			{
				if (this._RankS != value)
				{
					this._RankS = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region RankA 変更通知プロパティ

		private Visibility _RankA;

		public Visibility RankA
		{
			get { return this._RankA; }
			set
			{
				if (this._RankA != value)
				{
					this._RankA = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region RankB 変更通知プロパティ

		private Visibility _RankB;

		public Visibility RankB
		{
			get { return this._RankB; }
			set
			{
				if (this._RankB != value)
				{
					this._RankB = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region RankC 変更通知プロパティ

		private Visibility _RankC;

		public Visibility RankC
		{
			get { return this._RankC; }
			set
			{
				if (this._RankC != value)
				{
					this._RankC = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region RankD 変更通知プロパティ

		private Visibility _RankD;

		public Visibility RankD
		{
			get { return this._RankD; }
			set
			{
				if (this._RankD != value)
				{
					this._RankD = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region RankOut 変更通知プロパティ

		private Visibility _RankOut;

		public Visibility RankOut
		{
			get { return this._RankOut; }
			set
			{
				if (this._RankOut != value)
				{
					this._RankOut = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region BattlePreview 変更通知プロパティ

		private Visibility _BattlePreview;

		public Visibility BattlePreview
		{
			get { return this._BattlePreview; }
			set
			{
				if (this._BattlePreview != value)
				{
					this._BattlePreview = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region EnemyPreview 変更通知プロパティ

		private Visibility _EnemyPreview;

		public Visibility EnemyPreview
		{
			get { return this._EnemyPreview; }
			set
			{
				if (this._EnemyPreview != value)
				{
					this._EnemyPreview = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region UnknownEnemy 変更通知プロパティ

		private Visibility _UnknownEnemy;

		public Visibility UnknownEnemy
		{
			get { return this._UnknownEnemy; }
			set
			{
				if (this._UnknownEnemy != value)
				{
					this._UnknownEnemy = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region EnemyShips 変更通知プロパティ

		private List<string> _EnemyShips;

		public List<string> EnemyShips
		{
			get { return this._EnemyShips; }
			set
			{
				if (this._EnemyShips != value)
				{
					this._EnemyShips = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region FleetName 変更通知プロパティ

		private string _FleetName;

		public string FleetName
		{
			get { return this._FleetName; }
			set
			{
				if (this._FleetName != value)
				{
					this._FleetName = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		public BattlePreviewsViewModel()
		{
			PerfectRank = Visibility.Hidden;
			RankS = Visibility.Hidden;
			RankA = Visibility.Hidden;
			RankB = Visibility.Hidden;
			RankC = Visibility.Hidden;
			RankD = Visibility.Hidden;
			RankOut = Visibility.Hidden;
			this.BattlePreview = Visibility.Collapsed;
			this.EnemyPreview = Visibility.Collapsed;
			this.UnknownEnemy = Visibility.Collapsed;

			this.UpdateFleetStatus();
		}
		private void UpdateFleetStatus()
		{
			try
			{
				if (KanColleClient.Current.OracleOfCompass.EnableBattlePreview)
				{
					KanColleClient.Current.OracleOfCompass.UnknownEnemy += () =>
					{
						this.UnknownEnemy = Visibility.Visible;
						this.BattlePreview = Visibility.Collapsed;
						this.EnemyPreview = Visibility.Collapsed;
					};
					KanColleClient.Current.OracleOfCompass.PreviewNextEnemy += () =>
					{
						this.EnemyShips = new List<string>(KanColleClient.Current.OracleOfCompass.EnemyFleet.EnemyShips);
						this.FleetName = KanColleClient.Current.OracleOfCompass.EnemyFleet.FleetName;

						this.BattlePreview = Visibility.Collapsed;
						this.EnemyPreview = Visibility.Visible;
						this.UnknownEnemy = Visibility.Collapsed;
					};
					KanColleClient.Current.OracleOfCompass.ReadyForNextCell += () =>
					{
						CellStatus = KanColleClient.Current.OracleOfCompass.CellData;
					};
					KanColleClient.Current.OracleOfCompass.PreviewCriticalCondition += () =>
					{
						VIsibleBattleResult();
						//연합함대가 아닌경우 second를 비우고 작업개시
						if (!KanColleClient.Current.Homeport.Organization.Combined)
						{
							if (this.SecondResultReport != null)
								this.SecondResultReport = new List<PreviewBattleResults>();

							this.KanResultReport = new List<PreviewBattleResults>(KanColleClient.Current.OracleOfCompass.KanResult());
						}
						else//연합함대인경우
						{
							if (KanColleClient.Current.Homeport.Organization.Fleets[1].IsInSortie)
							{
								this.KanResultReport = new List<PreviewBattleResults>(KanColleClient.Current.OracleOfCompass.KanResult(1));

								this.SecondResultReport = new List<PreviewBattleResults>(KanColleClient.Current.OracleOfCompass.SecondResult());
							}
							else
							{
								if (this.SecondResultReport != null)
									this.SecondResultReport = new List<PreviewBattleResults>();

								this.KanResultReport = new List<PreviewBattleResults>(KanColleClient.Current.OracleOfCompass.KanResult());
							}
						}
						this.EnemyResultReport = new List<PreviewBattleResults>(KanColleClient.Current.OracleOfCompass.EnemyResult());

						this.RankIntToVisibility(KanColleClient.Current.OracleOfCompass.RankOut());
					};
				}
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine(e);
				KanColleClient.Current.CatchedErrorLogWriter.ReportException(e.Source, e);
			}
		}
		private void VIsibleBattleResult()
		{
			this.BattlePreview = Visibility.Visible;
			this.EnemyPreview = Visibility.Collapsed;
			this.UnknownEnemy = Visibility.Collapsed;
		}
		private void RankIntToVisibility(int value)
		{
			switch (value)
			{
				case 0:
					PerfectRank = Visibility.Visible;
					RankS = Visibility.Hidden;
					RankA = Visibility.Hidden;
					RankB = Visibility.Hidden;
					RankC = Visibility.Hidden;
					RankD = Visibility.Hidden;
					RankOut = Visibility.Hidden;

					break;
				case 1:
					PerfectRank = Visibility.Hidden;
					RankS = Visibility.Visible;
					RankA = Visibility.Hidden;
					RankB = Visibility.Hidden;
					RankC = Visibility.Hidden;
					RankD = Visibility.Hidden;
					RankOut = Visibility.Hidden;

					break;
				case 2:
					PerfectRank = Visibility.Hidden;
					RankS = Visibility.Hidden;
					RankA = Visibility.Visible;
					RankB = Visibility.Hidden;
					RankC = Visibility.Hidden;
					RankD = Visibility.Hidden;
					RankOut = Visibility.Hidden;

					break;
				case 3:
					PerfectRank = Visibility.Hidden;
					RankS = Visibility.Hidden;
					RankA = Visibility.Hidden;
					RankB = Visibility.Visible;
					RankC = Visibility.Hidden;
					RankD = Visibility.Hidden;
					RankOut = Visibility.Hidden;

					break;
				case 4:
					PerfectRank = Visibility.Hidden;
					RankS = Visibility.Hidden;
					RankA = Visibility.Hidden;
					RankB = Visibility.Hidden;
					RankC = Visibility.Visible;
					RankD = Visibility.Hidden;
					RankOut = Visibility.Hidden;

					break;
				case 5:
					PerfectRank = Visibility.Hidden;
					RankS = Visibility.Hidden;
					RankA = Visibility.Hidden;
					RankB = Visibility.Hidden;
					RankC = Visibility.Hidden;
					RankD = Visibility.Visible;
					RankOut = Visibility.Hidden;

					break;
				case -1:
					PerfectRank = Visibility.Hidden;
					RankS = Visibility.Hidden;
					RankA = Visibility.Hidden;
					RankB = Visibility.Hidden;
					RankC = Visibility.Hidden;
					RankD = Visibility.Hidden;
					RankOut = Visibility.Visible;

					break;
			}
		}

	}
}
