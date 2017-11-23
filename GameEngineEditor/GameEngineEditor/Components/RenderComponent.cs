﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace GameEngineEditor
{
    class RenderComponent : IComponent
    {
        // Data comming from XML
        public string image;
        public Vector2 size = new Vector2(500, 500);
    }
}
