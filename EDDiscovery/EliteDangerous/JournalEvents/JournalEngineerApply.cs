﻿/*
 * Copyright © 2016 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Fronter Developments plc.
 */
using Newtonsoft.Json.Linq;
using System.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    //When Written: when applying an engineer’s upgrade to a module
    //Parameters:
    //•	Engineer: name of engineer
    //•	Blueprint: blueprint being applied
    //•	Level: crafting level
    //•	Override: whether overriding special effect
    public class JournalEngineerApply : JournalEntry
    {
        public JournalEngineerApply(JObject evt ) : base(evt, JournalTypeEnum.EngineerApply)
        {
            Engineer = JSONHelper.GetStringDef(evt["Engineer"]);
            Blueprint = JSONHelper.GetStringDef(evt["Blueprint"]);
            Level = JSONHelper.GetInt(evt["Level"]);
            Override = JSONHelper.GetStringDef("Override");

        }
        public string Engineer { get; set; }
        public string Blueprint { get; set; }
        public int Level { get; set; }
        public string Override { get; set; }

        public static System.Drawing.Bitmap Icon { get { return EDDiscovery.Properties.Resources.engineerapply; } }
    }
}
