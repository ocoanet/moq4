// Copyright (c) 2007, Clarius Consulting, Manas Technology Solutions, InSTEDD.
// All rights reserved. Licensed under the BSD 3-Clause License; see License.txt.

namespace Moq
{
	internal interface IMatcher
	{
		bool Matches(object value);

		void SetupEvaluatedSuccessfully(object value);
	}
}
