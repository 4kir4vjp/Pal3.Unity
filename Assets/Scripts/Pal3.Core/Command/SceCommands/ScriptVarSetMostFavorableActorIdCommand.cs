﻿// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Core.Command.SceCommands
{
    [SceCommand(52, "取得主角对谁的好感最高并赋值给变量，" +
                    "参数：变量名", 0b0001)]
    public class ScriptVarSetMostFavorableActorIdCommand : ICommand
    {
        public ScriptVarSetMostFavorableActorIdCommand(ushort variable)
        {
            Variable = variable;
        }

        public ushort Variable { get; }
    }
}