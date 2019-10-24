﻿/*
Copyright (C) 2018 Wampa842

This file is part of WPlugins.

WPlugins is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

WPlugins is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with WPlugins.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;

namespace WPlugins.Common
{
    public class UpdateSettings
    {
        public enum CancelAction { None, SkipVersion, NeverCheck }

        public CancelAction Cancel { get; set; } = CancelAction.None;
        public SemanticVersion SkipVersion { get; set; } = new SemanticVersion();
        public bool AllowRemoteLog { get; set; } = true;
    }
}
