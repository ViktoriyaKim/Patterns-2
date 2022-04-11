﻿using System.Drawing;

namespace Patterns.Builder
{
    internal class BadSmileBuilder : ISmileBuilder
    {
        private Smile _smile;
        private Graphics _graphics;

        public BadSmileBuilder(Graphics graphics)
        {
            _smile = new Smile();

            _graphics = graphics;
        }

        public void CreateEyes()
        {
            _smile.SetEyes(new Eyes(Color.Black, _graphics));

            _smile.Eyes.Draw(": (");
        }

        public void CreateHead()
        {
            _smile.SetHead(new Head(Color.Black, _graphics));

            _smile.Head.Draw();
        }

        public void CreateMouth()
        {
            _smile.SetMouth(new Mouth(_graphics, Color.Black));

            _smile.Eyes.Draw("");
        }

        public Smile GetSmileType()
        {
            return _smile;
        }
    }
}
