// Copyright 2020 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Copyright 2020 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;

namespace Nuke.Common.CI
{
    internal class CIBuilder : ICIBuilder
    {
        public ICIBuilder Add<T>(Action<T> action) where T : ICIProvider
        {
            throw new NotImplementedException();
        }
    }
}
