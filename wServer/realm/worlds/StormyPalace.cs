﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wServer.realm.worlds
{
    public class StormyPalace : World
    {
        public StormyPalace()
        {
            Name = "Stormy Palace";
            ClientWorldName = "Stormy Palace";
            Background = 0;
            Difficulty = 4;
            AllowTeleport = true;
        }

        public override bool NeedsPortalKey => true;

        protected override void Init()
        {
            LoadMap("wServer.realm.worlds.maps.stormypalace.wmap", MapType.Wmap);
        }
    }
}