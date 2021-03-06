﻿//============================================================================*
// cAmmoTest.cs
//
// Copyright © 2013-2017, Kevin S. Beebe
// All Rights Reserved
//============================================================================*

//============================================================================*
// .Net Using Statements
//============================================================================*

using System;

//============================================================================*
// NameSpace
//============================================================================*

namespace ReloadersWorkShop
	{
	//============================================================================*
	// cAmmoTest class
	//============================================================================*

	[Serializable]
	public partial class cAmmoTest
		{
		//----------------------------------------------------------------------------*
		// Private Data Members
		//----------------------------------------------------------------------------*

		// General Data

		private cAmmo m_Ammo = null;

		private DateTime m_TestDate = new DateTime(DateTime.Today.Ticks);

		private cFirearm m_Firearm = null;

		private double m_dBarrelLength = 0.0;
		private double m_dTwist = 0;
		private int m_nNumRounds = 0;
		private double m_dBestGroup = 0.0;
		private double m_dBestGroupRange = 0.0;
		private string m_strNotes;

		private int m_nMuzzleVelocity = 0;

		private cTestShotList m_TestShotList = new cTestShotList();

		//============================================================================*
		// cAmmoTest() - Constructor
		//============================================================================*

		public cAmmoTest()
			{
			}

		//============================================================================*
		// cAmmoTest() - Copy Constructor
		//============================================================================*

		public cAmmoTest(cAmmoTest AmmoTest)
			{
			Copy(AmmoTest);
			}

		//============================================================================*
		// Append()
		//============================================================================*

		public int Append(cAmmoTest AmmoTest, bool fCountOnly = false)
			{
			int nUpdateCount = 0;

			if (m_dBarrelLength == 0.0 && AmmoTest.m_dBarrelLength != 0.0)
				{
				if (!fCountOnly)
					m_dBarrelLength =  AmmoTest.m_dBarrelLength;

				nUpdateCount++;
				}

			if (m_dTwist == 0.0 && AmmoTest.m_dTwist != 0.0)
				{
				if (!fCountOnly)
					m_dTwist = AmmoTest.m_dTwist;

				nUpdateCount++;
				}

			if (m_nNumRounds == 0 && AmmoTest.m_nNumRounds != 0)
				{
				if (!fCountOnly)
					m_nNumRounds = AmmoTest.m_nNumRounds;

				nUpdateCount++;
				}

			if (m_nMuzzleVelocity == 0 && AmmoTest.m_nMuzzleVelocity != 0)
				{
				if (!fCountOnly)
					m_nMuzzleVelocity = AmmoTest.m_nMuzzleVelocity;

				nUpdateCount++;
				}

			if (m_dBestGroup == 0.0 && AmmoTest.m_dBestGroup != 0.0)
				{
				if (!fCountOnly)
					m_dBestGroup = AmmoTest.m_dBestGroup;

				nUpdateCount++;
				}

			if (m_dBestGroupRange == 0.0 && AmmoTest.m_dBestGroupRange != 0.0)
				{
				if (!fCountOnly)
					m_dBestGroupRange = AmmoTest.m_dBestGroupRange;

				nUpdateCount++;
				}

			if (String.IsNullOrEmpty(m_strNotes) && !String.IsNullOrEmpty(AmmoTest.m_strNotes))
				{
				if (!fCountOnly)
					m_strNotes = AmmoTest.m_strNotes;

				nUpdateCount++;
				}

			return (nUpdateCount);
			}

		//============================================================================*
		// Copy()
		//============================================================================*

		public void Copy(cAmmoTest AmmoTest)
			{
			m_Ammo = AmmoTest.m_Ammo;
			m_Firearm = AmmoTest.m_Firearm;

			m_TestDate = AmmoTest.m_TestDate;
			m_dBarrelLength = AmmoTest.m_dBarrelLength;
			m_dTwist = AmmoTest.m_dTwist;
			m_nNumRounds = AmmoTest.m_nNumRounds;
			m_nMuzzleVelocity = AmmoTest.m_nMuzzleVelocity;
			m_dBestGroup = AmmoTest.m_dBestGroup;
			m_dBestGroupRange = AmmoTest.m_dBestGroupRange;
			m_strNotes = AmmoTest.m_strNotes;

			m_TestShotList = new cTestShotList(AmmoTest.TestShotList);
			}

		//============================================================================*
		// Ammo Property
		//============================================================================*

		public cAmmo Ammo
			{
			get
				{
				return (m_Ammo);
				}
			set
				{
				m_Ammo = value;
				}
			}

		//============================================================================*
		// BarrelLength Property
		//============================================================================*

		public double BarrelLength
			{
			get
				{
				return (m_dBarrelLength);
				}
			set
				{
				m_dBarrelLength = value;
				}
			}

		//============================================================================*
		// BestGroup Property
		//============================================================================*

		public double BestGroup
			{
			get
				{
				return (m_dBestGroup);
				}
			set
				{
				m_dBestGroup = value;
				}
			}

		//============================================================================*
		// BestGroupRange Property
		//============================================================================*

		public double BestGroupRange
			{
			get
				{
				return (m_dBestGroupRange);
				}
			set
				{
				m_dBestGroupRange = value;
				}
			}

		//============================================================================*
		// Comparer()
		//============================================================================*

		public static int Comparer(cAmmoTest AmmoTest1, cAmmoTest AmmoTest2)
			{
			if (AmmoTest1 == null)
				{
				if (AmmoTest2 != null)
					return (-1);
				else
					return (0);
				}
			else
				{
				if (AmmoTest2 == null)
					return (1);
				}

			return (AmmoTest1.CompareTo(AmmoTest2));
			}

		//============================================================================*
		// CompareTo()
		//============================================================================*

		public int CompareTo(cAmmoTest AmmoTest)
			{
			if (AmmoTest == null)
				return (1);

			//----------------------------------------------------------------------------*
			// Date
			//----------------------------------------------------------------------------*

			int rc = m_TestDate.CompareTo(AmmoTest.m_TestDate);

			//----------------------------------------------------------------------------*
			// Firearm
			//----------------------------------------------------------------------------*

			if (rc == 0)
				{
				if (m_Firearm == null)
					{
					if (AmmoTest.m_Firearm != null)
						rc = -1;
					else
						rc = 0;
					}
				else
					{
					if (AmmoTest.m_Firearm == null)
						rc = 1;
					else
						rc = m_Firearm.CompareTo(AmmoTest.m_Firearm);
					}

				//----------------------------------------------------------------------------*
				// NumRounds
				//----------------------------------------------------------------------------*

				if (rc == 0)
					{
					rc = m_nNumRounds.CompareTo(AmmoTest.m_nNumRounds);

					//----------------------------------------------------------------------------*
					// Detail Data
					//----------------------------------------------------------------------------*

					if (rc == 0)
						{
						rc = m_nMuzzleVelocity.CompareTo(AmmoTest.m_nMuzzleVelocity);

						if (rc == 0)
							{
							rc = m_dBarrelLength.CompareTo(AmmoTest.m_dBarrelLength);

							if (rc == 0)
								{
								rc = m_dTwist.CompareTo(AmmoTest.m_dTwist);

								if (rc == 0)
									{
									rc = m_dBestGroup.CompareTo(AmmoTest.m_dBestGroup);

									if (rc == 0)
										{
										rc = m_dBestGroupRange.CompareTo(AmmoTest.m_dBestGroupRange);

										if (rc == 0)
											{
											if (m_strNotes == null)
												m_strNotes = "";

											rc = m_strNotes.CompareTo(AmmoTest.m_strNotes);
											}
										}
									}
								}
							}
						}
					}
				}

			return (rc);
			}

		//============================================================================*
		// Firearm Property
		//============================================================================*

		public cFirearm Firearm
			{
			get
				{
				return (m_Firearm);
				}
			set
				{
				m_Firearm = value;
				}
			}

		//============================================================================*
		// MuzzleVelocity Property
		//============================================================================*

		public int MuzzleVelocity
			{
			get
				{
				if (m_TestShotList.Count == 0)
					return (m_nMuzzleVelocity);

				int nTotal = 0;

				foreach (cTestShot TestShot in m_TestShotList)
					nTotal += TestShot.MuzzleVelocity;

				m_nMuzzleVelocity = nTotal / m_TestShotList.Count;

				return (m_nMuzzleVelocity);
				}

			set
				{
				m_nMuzzleVelocity = value;
				}
			}

		//============================================================================*
		// Notes Property
		//============================================================================*

		public string Notes
			{
			get
				{
				return (m_strNotes);
				}
			set
				{
				m_strNotes = value;
				}
			}

		//============================================================================*
		// NumRounds Property
		//============================================================================*

		public int NumRounds
			{
			get
				{
				return (m_nNumRounds);
				}
			set
				{
				m_nNumRounds = value;
				}
			}

		//============================================================================*
		// Pressure Property
		//============================================================================*

		public int Pressure
			{
			get
				{
				if (m_TestShotList.Count == 0)
					return (0);

				int nTotal = 0;

				foreach (cTestShot TestShot in m_TestShotList)
					nTotal += TestShot.Pressure;

				return (nTotal / m_TestShotList.Count);
				}
			}

		//============================================================================*
		// ResolveIdentities()
		//============================================================================*

		public bool ResolveIdentities(cDataFiles Datafiles)
			{
			bool fChanged = false;

			if (m_Ammo != null && m_Ammo.Identity)
				{
				foreach (cAmmo Ammo in Datafiles.AmmoList)
					{
					if (m_Ammo.CompareTo(Ammo) == 0)
						{
						m_Ammo = Ammo;

						fChanged = true;

						break;
						}
					}
				}

			if (m_Firearm != null && m_Firearm.Identity)
				{
				foreach (cFirearm Firearm in Datafiles.FirearmList)
					{
					if (m_Firearm.CompareTo(Firearm) == 0)
						{
						m_Firearm = Firearm;

						fChanged = true;

						break;
						}
					}
				}

			return (fChanged);
			}

		//============================================================================*
		// Synch() - AmmoTest
		//============================================================================*

		public void Synch(cAmmo CheckFactoryAmmo)
			{
			if (CheckFactoryAmmo != null && CheckFactoryAmmo.CompareTo(m_Ammo) == 0)
				m_Ammo = CheckFactoryAmmo;
			}

		//============================================================================*
		// TestDate Property
		//============================================================================*

		public DateTime TestDate
			{
			get
				{
				return (m_TestDate);
				}
			set
				{
				m_TestDate = value;
				}
			}

		//============================================================================*
		// TestShotList Property
		//============================================================================*

		public cTestShotList TestShotList
			{
			get
				{
				return (m_TestShotList);
				}
			set
				{
				m_TestShotList = value;
				}
			}

		//============================================================================*
		// ToString Property
		//============================================================================*

		public override string ToString()
			{
			string strString = String.Format("Firearm: {0}, {1} Rounds Tested", m_Firearm.ToString(), m_nNumRounds);

			return (strString);
			}

		//============================================================================*
		// Twist Property
		//============================================================================*

		public double Twist
			{
			get
				{
				return (m_dTwist);
				}
			set
				{
				m_dTwist = value;
				}
			}

		//============================================================================*
		// Validate()
		//============================================================================*

		public bool Validate()
			{
			if (m_Ammo == null)
				return (false);

			return (true);
			}
		}
	}
