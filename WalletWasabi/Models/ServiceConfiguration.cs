﻿using System;
using System.Collections.Generic;
using System.Text;
using WalletWasabi.Helpers;

namespace WalletWasabi.Models
{
	public class ServiceConfiguration
	{
		public int MixUntilAnonymitySet { get; set; }
		public int PrivacyLevelSome { get; set; }
		public int PrivacyLevelFine { get; set; }
		public int PrivacyLevelStrong { get; set; }

		public ServiceConfiguration(
			int mixUntilAnonymitySet,
			int privacyLevelSome,
			int privacyLevelFine,
			int privacyLevelStrong)
		{
			MixUntilAnonymitySet = Guard.NotNull(nameof(mixUntilAnonymitySet), mixUntilAnonymitySet);
			PrivacyLevelSome = Guard.NotNull(nameof(privacyLevelSome), privacyLevelSome);
			PrivacyLevelFine = Guard.NotNull(nameof(privacyLevelFine), privacyLevelFine);
			PrivacyLevelStrong = Guard.NotNull(nameof(privacyLevelStrong), privacyLevelStrong);
		}
	}
}
