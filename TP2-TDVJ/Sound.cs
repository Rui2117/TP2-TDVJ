using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace TP2_TDVJ
{
    public static class Sounds
    {
        public static SoundEffect jump, shoot, lose;


        public static void LoadSounds(ContentManager Content)
        {
            jump = Content.Load<SoundEffect>("jump");
            shoot = Content.Load<SoundEffect>("shoot");
            lose = Content.Load<SoundEffect>("lose");
        }
    }
}
