﻿// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Storage.AssetStorage
{
    public class Asset
    {
        public string Name { get; set; }
        public AssetType Type { get; set; }
        public string IconCssClass { get; set; }
        public long FileSize { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
        public string Description { get; set; }
    }

    public enum AssetType
    {
        File,
        Folder
    }
}