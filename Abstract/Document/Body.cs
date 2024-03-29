﻿using System;

namespace Abstract
{
    class Body : Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "No body in the Document. ";
            }

            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor= ConsoleColor.Gray;
        }
    }
}
