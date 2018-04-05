﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite.SDK
{
    public interface IPlayniteAPI
    {
        IGameDataseAPI Database
        {
            get;
        }

        IDialogsFactory Dialogs
        {
            get;
        }
    }
}
